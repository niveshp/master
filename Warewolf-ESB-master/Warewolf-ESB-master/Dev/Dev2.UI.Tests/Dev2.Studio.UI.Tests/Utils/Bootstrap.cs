
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2014 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/


using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev2.Studio.UI.Tests.Utils
{
    /// <summary>
    /// Used to bootstrap the server for coded UI test runs
    /// </summary>
    [TestClass]
    public class Bootstrap
    {
        private const bool EnableLocalRestart = false;

        public const string ServerProcName = "Warewolf Server";
        public const string StudioProcName = "Warewolf Studio";
        private const string ServerExeName = ServerProcName + ".exe";
        private const int ServerTimeOut = 3000;
        private const int StudioTimeOut = 12000;

        public static string LogLocation = @"C:\UI_Test.log";
        public static string BuildDirectory = @"C:\Builds\UITestRunWorkspace";//If UI tests are going to be run with no deploy by a build agent (copy this straight out of the build agent config)

        public static string ServerLocation;
        public static string StudioLocation;
        private static string _resourceLocation;
        private static string _serverWorkspaceLocation;
        public TestContext TestContext
        {
            get;
            set;
        }

        public static int WaitMs = 5000;

        public static bool IsLocal = false;

        /// <summary>
        /// Inits the ServerLocation.
        /// </summary>
        /// <param name="testCtx">Test context.</param>
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext testCtx)
        {
            IsLocal = testCtx.Properties["ControllerName"] == null || testCtx.Properties["ControllerName"].ToString() == "localhost:6901";
            ResolvePathsToTestAgainst();
        }

        public static void ResolvePathsToTestAgainst()
        {
            var serverProcess = TryGetProcess(ServerProcName);
            if(serverProcess == null)
            {
                LogTestRunMessage("No server running.", true);
                throw new Exception("No server running.");
            }
            var studioProcess = TryGetProcess(StudioProcName);
            if(studioProcess == null)
            {
                LogTestRunMessage("No studio running.", true);
                throw new Exception("No studio running.");
            }
            ServerLocation = GetProcessPath(serverProcess);
            if(!File.Exists(ServerLocation))
            {
                LogTestRunMessage("Could not locate server to test against.", true);
                throw new FileNotFoundException("Server not found at " + ServerLocation);
            }
            StudioLocation = GetProcessPath(studioProcess);
            if(!File.Exists(StudioLocation))
            {
                LogTestRunMessage("Could not locate studio to test against.", true);
                throw new FileNotFoundException("Studio not found at " + StudioLocation);
            }
            //Set resource location
            _resourceLocation = StudioLocation.Replace(ServerExeName, @"Resources\");
            //Set workspace location
            _serverWorkspaceLocation = ServerLocation.Replace(ServerExeName, @"Workspaces\");
        }

        private static string GetProcessPath(ICollection processes)
        {
            if(processes == null || processes.Count == 0)
            {
                return null;
            }
            return (from ManagementObject process in processes select (process.Properties["ExecutablePath"].Value ?? string.Empty).ToString()).FirstOrDefault();
        }

        public static void Init()
        {
            // Remove old log files ;)
            if(File.Exists(LogLocation))
            {
                File.Delete(LogLocation);
            }

            //Check for runnning server/studio
            var studioProc = TryGetProcess(StudioProcName);
            var serverProc = TryGetProcess(ServerProcName);

            //Don't touch the server or studio for local runs on a developers desk he might be debugging!
            if(serverProc != null && studioProc != null)
            {
                return;
            }

            if(!EnableLocalRestart && (Environment.CurrentDirectory.Contains(BuildDirectory) && IsLocal))
            {
                return;
            }
            // term any existing studio processes ;)
            KillProcess(studioProc);
            // term any existing server processes ;)
            KillProcess(serverProc);

            // remove workspaces to avoid mutation issues
            RemoveWorkspaces();

            StartServer(ServerLocation);
            StartStudio(StudioLocation);

            Thread.Sleep(WaitMs);
        }

        /// <summary>
        /// Tear downs this instance.
        /// </summary>
        public static void Teardown()
        {
            //Don't touch the server or studio for local runs on a developers desk he might be debugging!
            var studioProc = TryGetProcess(StudioProcName);
            var serverProc = TryGetProcess(ServerProcName);
            if(serverProc != null && studioProc != null)
            {
                return;
            }

            if(!EnableLocalRestart && (Environment.CurrentDirectory.Contains(BuildDirectory) && IsLocal))
            {
                return;
            }

            if(File.Exists(ServerLocation) && File.Exists(StudioLocation))
            {
                //Server was deployed and started, stop it now.
                KillServer();

                //Studio was deployed and started, stop it now.
                KillStudio();
            }
            else
            {
                LogTestRunMessage("Could not locate CodedUI Binaries", true);
            }

            if(!IsLocal)
            {
                // Now clean up next test run ;)
                CloseAllInstancesOfIE();
            }
        }

        public static void KillServer()
        {
            KillProcess(TryGetProcess(ServerProcName));
        }

        public static void KillStudio()
        {
            KillProcess(TryGetProcess(StudioProcName));
        }

        /// <summary>
        /// Deletes the source.
        /// </summary>
        /// <param name="sourceName">Name of the source.</param>
        public static void DeleteSource(string sourceName, string serviceCategory = null)
        {
            var path = _resourceLocation + (serviceCategory != null ? (serviceCategory + "\\") : string.Empty) + sourceName;
            if(File.Exists(path))
            {
                File.Delete(path);
            }
        }

        /// <summary>
        /// Deletes the service.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        public static void DeleteService(string serviceName, string serviceCategory = null)
        {
            var path = _resourceLocation + (serviceCategory != null ? (serviceCategory + "\\") : string.Empty) + serviceName;
            if(File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private static Exception Exception(string p)
        {
            throw new NotImplementedException();
        }

        static void CloseAllInstancesOfIE()
        {
            var browsers = new[] { "iexplore" };

            foreach(var browser in browsers)
            {
                Process[] processList = Process.GetProcessesByName(browser);
                foreach(Process p in processList)
                {
                    try
                    {
                        p.Kill();
                    }
                    // ReSharper disable EmptyGeneralCatchClause
                    catch
                    // ReSharper restore EmptyGeneralCatchClause
                    {
                    }
                }
            }
        }

        /// <summary>
        /// Removes the workspaces.
        /// </summary>
        static void RemoveWorkspaces()
        {
            try
            {
                if(Directory.Exists(_serverWorkspaceLocation))
                {
                    Directory.Delete(_serverWorkspaceLocation, true);
                }
            }
            catch(Exception e)
            {
                LogTestRunMessage(e.Message, true);
            }
        }

        static void StartStudio(string location)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo { CreateNoWindow = false, UseShellExecute = true, FileName = location };

            var started = false;
            var startCnt = 0;

            while(!started && startCnt < 5)
            {
                try
                {
                    var StudioProc = Process.Start(startInfo);

                    // Wait for studio to start
                    Thread.Sleep(StudioTimeOut); // wait for server to start ;)
                    if(StudioProc != null && !StudioProc.HasExited)
                    {
                        started = true;
                        LogTestRunMessage("Started Studio");
                    }
                }
                catch
                {
                    // most likely a studio is already running, kill it and try again ;)
                    LogTestRunMessage("Could not locate Start Studio [ " + StudioLocation + " ] Attempt Count [ " + startCnt + " ]", true);
                    startCnt++;
                }
                finally
                {
                    if(!started)
                    {
                        LogTestRunMessage("Failed To Start Studio.... Aborting", true);
                        // term any existing server processes ;)
                        KillProcess(TryGetProcess(StudioProcName));
                        throw new Exception("Failed to start Studio at " + location);
                    }
                }
            }
        }

        static void StartServer(string location)
        {
            const string args = "-t";

            ProcessStartInfo startInfo = new ProcessStartInfo { CreateNoWindow = false, UseShellExecute = true, Arguments = args, FileName = location };

            var started = false;
            var startCnt = 0;

            while(!started && startCnt < 5)
            {
                try
                {
                    var ServerProc = Process.Start(startInfo);

                    // Wait for server to start
                    Thread.Sleep(ServerTimeOut); // wait for server to start ;)
                    if(ServerProc != null && !ServerProc.HasExited)
                    {
                        started = true;
                        LogTestRunMessage("Started Server");
                    }
                }
                catch(Exception)
                {
                    // most likely a server is already running, kill it and try again ;)
                    LogTestRunMessage("Could not locate Start Server [ " + ServerLocation + " ] Attempt Count [ " + startCnt + " ]", true);
                    startCnt++;
                }
                finally
                {
                    if(!started)
                    {
                        LogTestRunMessage("Failed To Start Server.... Aborting", true);
                        // term any existing server processes ;)
                        KillProcess(TryGetProcess(ServerProcName));
                        throw new Exception("Failed to start server at " + location);
                    }
                }
            }
        }

        // Click here to force exit all processes 
        [AssemblyCleanup]
        public static void RunTeardown()
        {
            Teardown();
        }

        public static ManagementObjectCollection TryGetProcess(string procName)
        {
            var processName = procName;
            var query = new SelectQuery(@"SELECT * FROM Win32_Process where Name LIKE '%" + processName + ".exe'");
            //initialize the searcher with the query it is
            //supposed to execute
            using(ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                //execute the query
                ManagementObjectCollection processes = searcher.Get();
                if(processes.Count <= 0)
                {
                    return null;
                }
                return processes;
            }
        }

        static void KillProcess(ManagementObjectCollection processes)
        {
            if(processes == null)
            {
                return;
            }
            foreach(ManagementObject process in processes)
            {
                //print process properties
                try
                {
                    process.Get();
                    var pid = process.Properties["ProcessID"].Value.ToString();
                    var proc = Process.GetProcessById(Int32.Parse(pid));
                    proc.Kill();
                }
                // ReSharper disable EmptyGeneralCatchClause
                catch(Exception e)
                // ReSharper restore EmptyGeneralCatchClause
                {
                    // Do nothing
                    LogTestRunMessage(e.Message, true);
                }
            }
        }

        public static void LogTestRunMessage(string msg, bool isError = false)
        {
            if(Directory.Exists(Path.GetDirectoryName(LogLocation)))
            {
                if(isError)
                {
                    File.AppendAllText(LogLocation, "ERROR :: " + msg);
                }
                else
                {
                    File.AppendAllText(LogLocation, "INFO :: " + msg);
                }

                File.AppendAllText(LogLocation, Environment.NewLine);
            }
        }
    }
}


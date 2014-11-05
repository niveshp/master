
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
using Dev2.Integration.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev2.Integration.Tests.Dev2.Activities.Tests
{
    /// <summary>
    /// Summary description for PathOperationsWFTests
    /// </summary>
    [TestClass]
    // ReSharper disable InconsistentNaming
    public class PathOperationsWFTests
    {
        readonly string WebserverURI = ServerSettings.WebserverURI;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Language Tests

        [TestMethod]
        public void CreateFileUsingRecordsetWithNoIndex()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/CreateFileUsingRecordsetWithNoIndexTest");
            const string expected = "<CreateFileRes>Success</CreateFileRes><DeleteFileRes>Success</DeleteFileRes>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        [TestMethod]
        public void CreateFileUsingRecordsetWithRecordsetWithIndex()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/CreateFileUsingRecordsetWithRecordsetWithIndex");
            string expected = @"<CreateFileRes>Success</CreateFileRes><DeleteFileRes>Success</DeleteFileRes><CreateFileErr></CreateFileErr><DeleteFileErr></DeleteFileErr><Recordset index=""1""><record>C:\Windows\Temp\PathOperationsTestFolder\CreateFileUsingRecordsetWithRecordsetWithIndex\NewFolder\NewFolderFirstInnerFolder\NewCreatedFile.txt</record></Recordset>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        [TestMethod]
        public void CreateFileUsingRecordsetWithStar()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/CreateFileUsingRecordsetWithStar");

            // Why is this using a specific IP Address?? Is this service only on this machine?
            //string PostData = String.Format("{0}{1}", "http://192.168.104.33:1234/services", "CreateFileUsingRecordsetWithStar");
            string expected =
                @"<DeleteFileRes>Success</DeleteFileRes><Recorset index=""1""><record>C:\Temp\PathOperationsTestFolder\CreateFileUsingRecordsetWithStar\NewFolder\NewFolderFirstInnerFolder\NewCreatedFile.txt</record></Recorset><Recorset index=""2""><record>C:\Temp\PathOperationsTestFolder\CreateFileUsingRecordsetWithStar\NewFolder\NewFolderFirstInnerFolder\NewCreatedFile2.txt</record></Recorset><Recorset index=""3""><record>C:\Temp\PathOperationsTestFolder\CreateFileUsingRecordsetWithStar\NewFolder\NewFolderFirstInnerFolder\NewCreatedFile3.txt</record></Recorset><Recorset index=""4""><record>C:\Temp\PathOperationsTestFolder\CreateFileUsingRecordsetWithStar\NewFolder\NewFolderFirstInnerFolder\NewCreatedFile4.txt</record></Recorset><RESULT index=""1""><RES>Success</RES></RESULT><RESULT index=""2""><RES>Success</RES></RESULT><RESULT index=""3""><RES>Success</RES></RESULT><RESULT index=""4""><RES>Success</RES></RESULT>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        [TestMethod]
        public void CreateFileUsingScalar()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/CreateFileUsingScalar");
            string expected = @"<Path>C:\Temp\PathOperationsTestFolder\CreateFileUsingScalar\NewFolder\NewFolderFirstInnerFolder\NewCreatedFile.txt</Path><CreateFileRes>Success</CreateFileRes><DeleteFileRes>Success</DeleteFileRes>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        #endregion Language Tests

        #region Create File Tests

        [TestMethod]
        public void CreateFile()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/CreateFileOnFileSystemTest");
            string expected = @"<CreateFileRes>Success</CreateFileRes><DeleteFileRes>Success</DeleteFileRes>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        #endregion Create File Tests

        #region Read File Tests

        [TestMethod]
        public void ReadFile()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/ReadFileOffFileSystemTest");
            string expected = @"<FileReadResult>ABC</FileReadResult><WriteFileRes>Success</WriteFileRes><DeleteFileRes>Success</DeleteFileRes>";
            // A deferred read is expected RE Travis's feedback rom The Unlimited
            //string expected = "Contents not visible because this value is a deferred read of";
            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        #endregion Read File Tests

        #region Write File Tests

        [TestMethod]
        public void WriteToFile()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/WriteToFileOnFileSysytemTest");
            string expected = @"<WriteFileRes>Success</WriteFileRes><DeleteFileRes>Success</DeleteFileRes>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        #endregion Write File Tests

        #region Create Folder Tests

        [TestMethod]
        public void CreateFolder()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/CreateFolderOnFileSystemTest");
            string expected = @"<DataList><CreateFolderRes>Success</CreateFolderRes><DeleteFolderRes>Success</DeleteFolderRes>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        #endregion Create Folder Tests

        #region Read Folder Tests

        [TestMethod]
        public void ReadFolder()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/ReadFolderFromFileSystemTest");
            string expected = @"<CreateFileRes1>Success</CreateFileRes1><CreateFileRes2>Success</CreateFileRes2><DeleteFileRes>Success</DeleteFileRes><CreateFileErr1></CreateFileErr1><CreateFileErr2></CreateFileErr2><DeleteFileErr></DeleteFileErr><ReadFolderResult index=""1""><results>C:\Windows\Temp\PathOperationsTestFolder\ReadFolderFromFileSystemTest\OldFolder\OldFolderFirstInnerFolder\testfile1.txt</results></ReadFolderResult><ReadFolderResult index=""2""><results>C:\Windows\Temp\PathOperationsTestFolder\ReadFolderFromFileSystemTest\OldFolder\OldFolderFirstInnerFolder\testfile2.txt</results></ReadFolderResult><ReadFolderErrors index=""1""><errors></errors></ReadFolderErrors>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        [TestMethod]
        public void ReadFolderInForEachLoop_Expected_NoNotImplementedError()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/FolderReadInForEachTest");
            const string notExpected = "<InnerError>The method or operation is not implemented.</InnerError>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            Assert.IsFalse(ResponseData.Contains(notExpected));
        }


        [TestMethod]
        public void FolderReadUsingScalar()
        {
            string postData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/FolderReadUsingScalar");
            const string expected = ",";

            string responseData = TestHelper.PostDataToWebserver(postData);

            StringAssert.Contains(responseData, expected);
        }

        #endregion Read Folder Tests

        #region Copy Tests

        [TestMethod]
        public void CopyFile()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/CopyFileLocalToLocalTest");
            const string expected = @"<CreateFileRes>Success</CreateFileRes><CopyFileRes>Success</CopyFileRes><DeleteFileRes>Success</DeleteFileRes>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        [TestMethod]
        public void CopyFileToFTP()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/CreateFileCopyToFTP");
            const string expected = @"<CopyRes>Success</CopyRes><CreateRes>Success</CreateRes><FTPDeleteRes>Success</FTPDeleteRes><CreateErr></CreateErr><CopyErr></CopyErr><FTPDeleteErr></FTPDeleteErr>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        #endregion Copy Tests

        #region Delete Tests

        [TestMethod]
        public void DeleteFolder()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/DeleteFolderFromFileSystemTest");
            string expected = @"<DeleteFolderRes>Success</DeleteFolderRes><CreateFolderRes>Success</CreateFolderRes>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        #endregion Delete Tests

        #region Move Tests

        [TestMethod]
        public void MoveFolder()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/MoveFolderOnFileSystemTest");
            string expected = @"<MoveFileRes>Success</MoveFileRes><CreateFileRes>Success</CreateFileRes><DeleteFileRes>Success</DeleteFileRes><CreateFileErr></CreateFileErr><MoveFileErr></MoveFileErr><DeleteFileErr></DeleteFileErr>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        #endregion Move Tests

        #region Rename Tests

        [TestMethod]
        public void RenameFolder()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/RenameFolderOnFileSystemTest");
            string expected = @"<CreateFileRes>Success</CreateFileRes><RenameFileRes>Success</RenameFileRes><DeleteFileRes>Success</DeleteFileRes>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        #endregion Rename Tests

        #region UnZip Tests

        [TestMethod]
        public void UnZip()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/UnZipOnFileSystemTest");
            string expected = @"<CreateFileRes>Success</CreateFileRes><ZipFileRes>Success</ZipFileRes><UnZipFileRes>Success</UnZipFileRes><DeleteFileRes1>Success</DeleteFileRes1><DeleteFileRes2>Success</DeleteFileRes2><CreateFileErr></CreateFileErr><ZipFileErr></ZipFileErr><DeleteFileErr1></DeleteFileErr1><UnZipFileErr></UnZipFileErr><DeleteFileErr2></DeleteFileErr2>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        #endregion UnZip Tests

        #region Zip Tests

        [TestMethod]
        public void ZipFolder()
        {
            string PostData = String.Format("{0}{1}", WebserverURI, "Integration Test Resources/ZipFolderOnFileSystemTest");
            string expected = @"<DeleteFileRes>Success</DeleteFileRes><ZipFileRes>Success</ZipFileRes><CreateFileRes>Success</CreateFileRes><CreateFileErr></CreateFileErr><ZipFileErr></ZipFileErr><DeleteFileErr></DeleteFileErr>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }

        #endregion Zip Tests

    }
}

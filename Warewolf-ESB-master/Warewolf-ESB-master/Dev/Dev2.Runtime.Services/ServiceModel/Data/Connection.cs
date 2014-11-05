
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
using System.Configuration;
using System.Linq;
using System.Xml.Linq;
using Dev2.Common;
using Dev2.Data.ServiceModel;
using Dev2.DynamicServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Dev2.Runtime.ServiceModel.Data
{
    public class Connection : Resource
    {
        public const int DefaultWebServerPort = 3142;

        public string Address { get; set; }

        [JsonIgnore]
        public string WebAddress
        {
            get
            {
                var address = new UriBuilder(Address) { Port = WebServerPort, Path = string.Empty };
                return address.ToString();
            }
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public AuthenticationType AuthenticationType { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public int WebServerPort { get; set; }

        #region CTOR

        public Connection()
        {
            ResourceType = ResourceType.Server;
        }

        public Connection(XElement xml)
            : base(xml)
        {
            ResourceType = ResourceType.Server;

            var connectionString = xml.AttributeSafe("ConnectionString");
            var props = connectionString.Split(';');
            foreach(var p in props.Select(prop => prop.Split('=')).Where(p => p.Length >= 1))
            {
                switch(p[0].ToLowerInvariant())
                {
                    case "appserveruri":
                        Address = p[1];
                        break;
                    case "webserverport":
                        int port;
                        WebServerPort = Int32.TryParse(p[1], out port) ? port : DefaultWebServerPort;
                        break;
                    case "authenticationtype":
                        AuthenticationType authType;
                        AuthenticationType = Enum.TryParse(p[1], true, out authType) ? authType : AuthenticationType.Windows;
                        break;
                    case "username":
                        UserName = p[1];
                        break;
                    case "password":
                        Password = p[1];
                        break;
                }
                if(WebServerPort == 77)
                {
                    WebServerPort = Int32.Parse(GlobalConstants.WebServerPort);
                }
            }
        }

        #endregion

        #region ToXml

        public override XElement ToXml()
        {
            var result = base.ToXml();
            var connectionString = string.Join(";",
                string.Format("AppServerUri={0}", Address),
                string.Format("WebServerPort={0}", WebServerPort),
                string.Format("AuthenticationType={0}", AuthenticationType)
                );
            if(AuthenticationType == AuthenticationType.User)
            {
                connectionString = string.Join(";",
                    connectionString,
                    string.Format("UserName={0}", UserName),
                    string.Format("Password={0}", Password)
                    );
            }

            result.Add(
                new XAttribute("ConnectionString", connectionString),
                new XAttribute("Type", enSourceType.Dev2Server),
                new XElement("TypeOf", enSourceType.Dev2Server)
                );

            return result;
        }

        #endregion

    }
}

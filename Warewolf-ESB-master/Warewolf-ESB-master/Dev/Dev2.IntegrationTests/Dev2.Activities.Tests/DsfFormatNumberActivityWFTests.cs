
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
using System.Text.RegularExpressions;
using Dev2.Integration.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev2.Integration.Tests.Dev2.Activities.Tests
{
    [TestClass]
    // ReSharper disable InconsistentNaming
    public class DsfFormatNumberActivityWFTests
    {
        [TestMethod]
        public void TestFormatNumber_Rounding()
        {
            string PostData = String.Format("{0}{1}", ServerSettings.WebserverURI, "Integration Test Resources/FormatNumber_Rounding");
            string expected = @"<amount1>100.12222</amount1><amount2>100.15555</amount2><result_no_rounding>100.12222</result_no_rounding><result_normal_rounding_up>100.12</result_normal_rounding_up><result_normal_rounding_down>100.16</result_normal_rounding_down><result_round_up>101</result_round_up><result_round_down>100.1</result_round_down><result_negative_rounding>450</result_negative_rounding><amount3>456</amount3><amounts index=""1""><value>123.123</value></amounts><amounts index=""2""><value>456.456</value></amounts><result_amounts index=""1""><value>123</value></result_amounts><result_amounts index=""2""><value>456</value></result_amounts>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            Regex regex = new Regex(@">\s*<");

            expected = regex.Replace(expected, "><");
            ResponseData = regex.Replace(ResponseData, "><");

            StringAssert.Contains(ResponseData, expected);
        }

        [TestMethod]
        public void TestFormatNumber_ShowDecimalPlaces()
        {
            string PostData = String.Format("{0}{1}", ServerSettings.WebserverURI, "Integration Test Resources/FormatNumber_ShowDecimalPlaces");
            string expected = @"<amount1>123.123</amount1><amount2>456.456456</amount2><amount3>456</amount3><result_no_decimals>123</result_no_decimals><result_less_decimals>456.45</result_less_decimals><result_more_decimals>123.1230</result_more_decimals><result_negative_decimals>1</result_negative_decimals><amounts index=""1""><value>123.123</value></amounts><amounts index=""2""><value>456.456</value></amounts>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            Regex regex = new Regex(@">\s*<");

            expected = regex.Replace(expected, "><");
            ResponseData = regex.Replace(ResponseData, "><");

            StringAssert.Contains(ResponseData, expected);
        }
    }
}

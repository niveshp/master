
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2014 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System.Text;
using Dev2.Common;
using Dev2.Data.Binary_Objects;
using Dev2.DataList.Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev2.Data.Tests.BinaryDataList.Converters
{
    /// <summary>
    /// Summary description for StudioDebugTranslatorTest
    /// </summary>
    [TestClass]
    public class StudioDebugTranslatorTest
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        // ReSharper disable InconsistentNaming

        [TestMethod]
        [Owner("Travis Frisinger")]
        [TestCategory("StudioDebugTranslator_ConvertAndOnlyMapInputs")]
        public void StudioDebugTranslator_ConvertAndOnlyMapInputs_WhenCallingNormally_ExpectNotImplementedException()
        {
            //------------Setup for test--------------------------
            var compiler = DataListFactory.CreateDataListCompiler();
            ErrorResultTO errors;

            //------------Execute Test---------------------------
            compiler.ConvertAndOnlyMapInputs(DataListFormat.CreateFormat(GlobalConstants._Studio_Debug_XML), new StringBuilder(), new StringBuilder(), out errors);

            //------------Assert Results-------------------------
            var theErrors = errors.FetchErrors();
            Assert.AreEqual(1, theErrors.Count);
            StringAssert.Contains(theErrors[0], "The method or operation is not implemented.");

        }

        [TestMethod]
        [Owner("Travis Frisinger")]
        [TestCategory("StudioDebugTranslator_ConvertTo")]
        public void StudioDebugTranslator_ConvertTo_WhenRecordsetColumnMappedAsInput_ExpectDataListWithColumnMappingDirection()
        {
            //------------Setup for test--------------------------
            var compiler = DataListFactory.CreateDataListCompiler();
            ErrorResultTO errors;

            var data = new StringBuilder("<DataList></DataList>");
            var shape = new StringBuilder(@"<DataList><rec Description="""" IsEditable=""True"" ColumnIODirection=""None"" ><a Description="""" IsEditable=""True"" ColumnIODirection=""Input"" /><b Description="""" IsEditable=""True"" ColumnIODirection=""None"" /></rec></DataList>");

            //------------Execute Test---------------------------
            var dlID = compiler.ConvertTo(DataListFormat.CreateFormat(GlobalConstants._Studio_Debug_XML), data, shape, out errors);
            var bdl = compiler.FetchBinaryDataList(dlID, out errors);

            //------------Assert Results-------------------------
            Assert.IsFalse(bdl.HasErrors());

            var recs = bdl.FetchRecordsetEntries();
            Assert.AreEqual(1, recs.Count);
            var cols = recs[0].Columns;
            Assert.AreEqual(2, cols.Count);
            var magicCol = cols[0];
            Assert.AreEqual("a", magicCol.ColumnName);
            Assert.AreEqual(enDev2ColumnArgumentDirection.Input, magicCol.ColumnIODirection);
            var nonMagicCol = cols[1];
            Assert.AreEqual("b", nonMagicCol.ColumnName);
            Assert.AreEqual(enDev2ColumnArgumentDirection.None, nonMagicCol.ColumnIODirection);

        }

        // ReSharper restore InconsistentNaming
    }
}

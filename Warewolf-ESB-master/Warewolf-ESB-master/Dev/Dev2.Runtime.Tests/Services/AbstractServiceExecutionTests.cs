
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
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Dev2.DynamicServices;
using Dev2.Runtime.Hosting;
using Dev2.Runtime.ServiceModel.Data;
using Dev2.Services.Execution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Dev2.Tests.Runtime.Services
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class AbstractServiceExecutionTests
    {
        #region Create Service

        [TestMethod]
        [TestCategory("UnitTest")]
        [Description("Test ServiceExecutionAbstract's CreateService function: It is expected to get a service and a source resource")]
        [Owner("Ashley Lewis")]
        // ReSharper disable InconsistentNaming
        public void ServiceExecutionAbstract_ServiceExecutionAbstractUnitTest_CreateService_ResourceCatalogRetrievesBothResources()
        // ReSharper restore InconsistentNaming
        {
            //init
            var databaseService = new MockServiceExecutionAbstract<DbService, DbSource>(new DsfDataObject("<DataList></DataList>", Guid.NewGuid()), It.IsAny<bool>());
            var mockResourceCatalog = new Mock<ResourceCatalog>(It.IsAny<IEnumerable<DynamicService>>());
            mockResourceCatalog.Setup(c => c.GetResource<DbService>(It.IsAny<Guid>(), It.IsAny<Guid>())).Verifiable();
            mockResourceCatalog.Setup(c => c.GetResource<DbService>(It.IsAny<Guid>(), It.IsAny<Guid>())).Returns(new DbService());
            mockResourceCatalog.Setup(c => c.GetResource<DbSource>(It.IsAny<Guid>(), It.IsAny<Guid>())).Verifiable();
            mockResourceCatalog.Setup(c => c.GetResource<DbSource>(It.IsAny<Guid>(), It.IsAny<Guid>())).Returns(new DbSource());

            //exe
            databaseService.MockCreateService(mockResourceCatalog.Object);

            //assert
            mockResourceCatalog.Verify(c => c.GetResource<DbService>(It.IsAny<Guid>(), It.IsAny<Guid>()), Times.Once());
            mockResourceCatalog.Verify(c => c.GetResource<DbSource>(It.IsAny<Guid>(), It.IsAny<Guid>()), Times.Once());
        }

        #endregion

    }
}

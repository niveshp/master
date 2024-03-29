
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
using Dev2.Studio.Core.Interfaces;

// ReSharper disable once CheckNamespace
namespace Dev2.Studio.Core.AppResources.Exceptions
{
    public class WebResourceUploadFailedException : Exception
    {

        readonly IWebResourceViewModel _failedResource;
        readonly string _errorMessage;

        public WebResourceUploadFailedException(IWebResourceViewModel failedResource, string errorMessage)
        {
            _failedResource = failedResource;
            _errorMessage = errorMessage;
        }

        public override string Message
        {
            get
            {
                return _errorMessage;
            }
        }

        public IWebResourceViewModel FailedWebResource
        {
            get
            {
                return _failedResource;
            }
        }

    }
}

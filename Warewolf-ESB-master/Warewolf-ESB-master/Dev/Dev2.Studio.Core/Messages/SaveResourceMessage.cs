
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2014 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/


using Dev2.Studio.Core.Interfaces;

// ReSharper disable once CheckNamespace
namespace Dev2.Studio.Core.Messages
{
    public class SaveResourceMessage : IMessage
    {
        public IContextualResourceModel Resource { get; set; }
        public bool IsLocalSave { get; set; }
        public bool AddToTabManager { get; set; }

        public SaveResourceMessage(IContextualResourceModel resource, bool isLocalSave, bool addToTabManager = true)
        {
            Resource = resource;
            IsLocalSave = isLocalSave;
            AddToTabManager = addToTabManager;
        }
    }
}

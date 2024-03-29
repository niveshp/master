
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2014 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/


// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

using Dev2.CodedUI.Tests;

namespace Dev2.Studio.UI.Tests.UIMaps.ServerWizardClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public partial class ServerWizard
    {
        
        /// <summary>
        /// ClickNewServerAddress
        /// </summary>
        public void ClickNewServerAddress()
        {
            #region Variable Declarations
            var uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            #endregion

            // Click image
            Mouse.Click(uIItemImage, new Point(236, 63));
        }
        
        /// <summary>
        /// RunTest
        /// </summary>
        public void RunTest()
        {
            #region Variable Declarations
            var uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            #endregion

            // Click image
            Mouse.Click(uIItemImage, new Point(350, 137));
        }
        
        /// <summary>
        /// ClickSaveConnection
        /// </summary>
        public void ClickSaveConnection()
        {
            #region Variable Declarations
            var uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            #endregion

            // Click image
            Mouse.Click(uIItemImage, new Point(514, 456));
        }
        
        /// <summary>
        /// ClickSave
        /// </summary>
        public void ClickSave()
        {
            #region Variable Declarations
            var uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            #endregion

            // Click image
            Mouse.Click(uIItemImage, new Point(482, 432));
        }
        
        #region Properties
        public UIBusinessDesignStudioWindow UIBusinessDesignStudioWindow
        {
            get
            {
                if ((this.mUIBusinessDesignStudioWindow == null))
                {
                    this.mUIBusinessDesignStudioWindow = new UIBusinessDesignStudioWindow();
                }
                return this.mUIBusinessDesignStudioWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIBusinessDesignStudioWindow mUIBusinessDesignStudioWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIBusinessDesignStudioWindow : WpfWindow
    {
        
        public UIBusinessDesignStudioWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.Name, "Warewolf", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public WpfImage UIItemImage
        {
            get
            {
                if ((this.mUIItemImage == null))
                {
                    this.mUIItemImage = new WpfImage(this);
                    #region Search Criteria
                    this.mUIItemImage.WindowTitles.Add(TestBase.GetStudioWindowName());
                    #endregion
                }
                return this.mUIItemImage;
            }
        }
        #endregion
        
        #region Fields
        private WpfImage mUIItemImage;
        #endregion
    }
}

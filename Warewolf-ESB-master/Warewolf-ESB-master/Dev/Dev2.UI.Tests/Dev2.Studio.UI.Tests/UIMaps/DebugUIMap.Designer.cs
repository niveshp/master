
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

using Dev2.Studio.UI.Tests.Utils;

namespace Dev2.Studio.UI.Tests.UIMaps.DebugUIMapClasses
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
    public partial class DebugUIMap : UIMapBase
    {

        /// <summary>
        /// DebugWindowExists
        /// </summary>
        /// 

        public WpfRow GetRow(int row)
        {


            var debugWindow = GetDebugWindow();
            debugWindow.WaitForControlEnabled();
            var inputGrid = VisualTreeWalker.GetChildByAutomationIdPath(debugWindow, "TabItems", "UI_InputDataTab_AutoID", "DataListInputs");
            return inputGrid.GetChildren()[row] as WpfRow;
        }

        public WpfWindow GetDebugWindow()
        {
            return StudioWindow.GetChildren()[0] as WpfWindow;
        }

        #region Properties
        public UIDebugWindow UIDebugWindow
        {
            get
            {
                if((this.mUIDebugWindow == null))
                {
                    this.mUIDebugWindow = new UIDebugWindow();
                }
                return this.mUIDebugWindow;
            }
        }
        #endregion

        #region Fields
        private UIDebugWindow mUIDebugWindow;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIDebugWindow : WpfWindow
    {

        public UIDebugWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Debug input data";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Debug input data");
            #endregion
        }
    }
}

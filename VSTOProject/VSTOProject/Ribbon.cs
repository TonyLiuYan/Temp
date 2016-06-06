using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Ribbon;
using CustomTaskPane = Microsoft.Office.Tools.CustomTaskPane;


namespace VSTOProject
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            UserControlCTP uc = new UserControlCTP();
            CustomTaskPane ctp = Globals.ThisAddIn.CustomTaskPanes.Add(uc, "Hello");
            ctp.DockPosition=MsoCTPDockPosition.msoCTPDockPositionBottom;
            ctp.Visible = true;
        }
    }
}

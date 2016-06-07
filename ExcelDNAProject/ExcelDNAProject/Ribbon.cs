using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelDna.Integration.CustomUI;

namespace ExcelDNAProject
{
    public class Ribbon : ExcelRibbon
    {
        public  void Show(IRibbonControl control)
        {
           UserControlCTP uc=new UserControlCTP();
           CustomTaskPane ctp = CustomTaskPaneFactory.CreateCustomTaskPane(uc, "Hello");
           ctp.DockPosition = MsoCTPDockPosition.msoCTPDockPositionBottom;
           ctp.Visible = true;
        }
    }
}

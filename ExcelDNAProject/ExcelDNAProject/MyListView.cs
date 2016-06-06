using System.Windows.Forms;

namespace ExcelDNAProject
{
    public class MyListView : ListView
    {
        public MyListView()
        {
            FullRowSelect = true;
            GridLines = true;
            View = View.Details;
            SetStyle(ControlStyles.DoubleBuffer |
                              ControlStyles.OptimizedDoubleBuffer |
                              ControlStyles.AllPaintingInWmPaint,
                              true);
            UpdateStyles();
        }
    }
}

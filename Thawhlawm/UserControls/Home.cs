using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Thawhlawm.UserControls
{
    public partial class Home : DevExpress.XtraEditors.XtraUserControl
    {
        public Home()
        {
            InitializeComponent();
            //dashboardViewer1.Dashboard = "Thawhlawm.xml";
            dashboardViewer1.DashboardSource = Application.StartupPath + "\\Thawhlawm.xml";
        }
    }
}

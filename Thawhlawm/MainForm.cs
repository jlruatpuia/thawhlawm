using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Thawhlawm
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            UserControls.Home h = new UserControls.Home() { Dock = DockStyle.Fill };
            scc.Panel2.Controls.Clear();
            scc.Panel2.Controls.Add(h);
        }
    }
}

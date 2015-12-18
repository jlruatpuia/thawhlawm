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

        private void nbiPuipate_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UserControls.KohhranUpa uc = new UserControls.KohhranUpa() { Dock = DockStyle.Fill };
            scc.Panel2.Controls.Clear();
            scc.Panel2.Controls.Add(uc);
            ribbonControl1.MergeRibbon(uc.ribbonControl1);
            ribbonControl1.SelectedPage = ribbonControl1.MergedPages[0];
        }
    }
}

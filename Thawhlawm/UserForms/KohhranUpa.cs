using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Thawhlawm.UserForms
{
    public partial class KohhranUpa : DevExpress.XtraEditors.XtraForm
    {

        private int id;

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Nihna
        {
            get { return cboNHN.Text; }
            set { cboNHN.Text = value; }
        }

        public string Hming
        {
            get { return txtHMG.Text; }
            set { txtHMG.Text = value; }
        }

        public string Phone
        {
            get { return txtPHN.Text; }
            set { txtPHN.Text = value; }
        }
        public KohhranUpa()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
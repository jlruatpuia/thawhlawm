using System;

namespace Thawhlawm.UserControls
{
    public partial class KohhranUpa : DevExpress.XtraEditors.XtraUserControl
    {
        UserCodes.KohhranUpa uc = new UserCodes.KohhranUpa();
        UserForms.KohhranUpa uf = new UserForms.KohhranUpa();

        void FillData()
        {
            if (uc.SelectAll().Rows.Count < 1)
            {
                bNew.Enabled = false;
                bDel.Enabled = false;
            }
            else
            {
                bNew.Enabled = true;
                bDel.Enabled = true;
            }
            grd.DataSource = uc.SelectAll();
        }
        public KohhranUpa()
        {
            InitializeComponent();
            
            FillData();
        }

        private void bNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(uf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (uc.Insert(uf.Nihna, uf.Hming, uf.Phone))
                    FillData();
            }
        }

        private void bEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uf.ID = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
            uf.Nihna = grv.GetFocusedRowCellValue(colHming).ToString().Substring(0, 4);
            uf.Hming = grv.GetFocusedRowCellValue(colHming).ToString().Substring(5);
            uf.Phone = grv.GetFocusedRowCellValue(colPhoneNo).ToString();
            if(uf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (uc.Update(uf.ID, uf.Nihna, uf.Hming, uf.Phone))
                    FillData();
            }
        }

        private void bFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bFind.Down)
                grv.OptionsFind.AlwaysVisible = true;
            else
                grv.OptionsFind.AlwaysVisible = false;
        }
    }
}

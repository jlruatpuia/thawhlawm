using System;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

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

        private void bFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MoveFirst();
        }

        private void bPrev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MovePrev();
        }

        private void bNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MoveNext();
        }

        private void bLast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MoveLast();
        }

        XtraReport rpt()
        {
            Reports.KohhranUpa rp = new Reports.KohhranUpa() { DataSource = uc.SelectAll() };
            rp.lblHMG.DataBindings.Add("Text", null, "HmingPum");
            rp.lblPHN.DataBindings.Add("Text", null, "PhoneNo");
            return rp;
        }

        private void bPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpt().ShowPreviewDialog();
            //rp.ShowPreviewDialog();
            //rp.lbHming.            
        }

        private void xPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf|All Files|*.*" };
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                rpt().ExportToPdf(sfd.FileName);
            }
        }

        private void xXLS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel 2003 File|*.xls|All Files|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                rpt().ExportToXls(sfd.FileName);
            }
        }

        private void xXLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel 2007 File|*.xlsx|All Files|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                rpt().ExportToXlsx(sfd.FileName);
            }
        }

        private void grv_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
        }

        private void grv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grv.FocusedRowHandle == 0)
            {
                bFirst.Enabled = false;
                bPrev.Enabled = false;
            }
            else
            {
                bFirst.Enabled = true;
                bPrev.Enabled = true;
            }
            if (grv.FocusedRowHandle == grv.RowCount - 1)
            {
                bLast.Enabled = false;
                bNext.Enabled = false;
            }
            else
            {
                bLast.Enabled = true;
                bNext.Enabled = true;
            }
        }

        private void bDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int ID = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
            if(MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (uc.Delete(ID))
                    MessageBox.Show("Record deleted successfully!");
            }
        }
    }
}

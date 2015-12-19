namespace Thawhlawm.UserControls
{
    public partial class KohhranUpa : DevExpress.XtraEditors.XtraUserControl
    {
        UserCodes.KohhranUpa uc = new UserCodes.KohhranUpa();
        UserForms.KohhranUpa uf = new UserForms.KohhranUpa();
        public KohhranUpa()
        {
            InitializeComponent();
            grd.DataSource = uc.SelectAll();
        }

        private void bNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(uf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (uc.Insert(uf.Nihna, uf.Hming, uf.Phone))
                    grd.DataSource = uc.SelectAll();
            }
        }
    }
}

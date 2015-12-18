namespace Thawhlawm.UserControls
{
    public partial class KohhranUpa : DevExpress.XtraEditors.XtraUserControl
    {
        UserCodes.KohhranUpa ku = new UserCodes.KohhranUpa();
        public KohhranUpa()
        {
            InitializeComponent();
            grd.DataSource = ku.SelectAll();
        }
    }
}

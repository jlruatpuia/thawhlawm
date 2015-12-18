using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace Thawhlawm.UserCodes
{
    class KohhranUpa
    {
        SQLiteConnection cm = new SQLiteConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

        public DataTable SelectAll()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT ID, Nihna, Hming, PhoneNo FROM KohhranUpa", cm);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}

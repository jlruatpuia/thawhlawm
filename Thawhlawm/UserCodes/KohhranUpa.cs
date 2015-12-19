using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Thawhlawm.UserCodes
{
    class KohhranUpa
    {
        SQLiteConnection cm = new SQLiteConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

        public DataTable SelectAll()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT ID, Nihna || ' ' || Hming AS HmingPum, PhoneNo FROM KohhranUpa", cm);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public bool Insert(string Nihna, string Hming, string Phone)
        {
            bool val = false;
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO KohhranUpa(Nihna, Hming, PhoneNo) VALUES(@NHN, @HMG, @PHN)", cm);
            cmd.Parameters.AddWithValue("@NHN", Nihna);
            cmd.Parameters.AddWithValue("@HMG", Hming);
            cmd.Parameters.AddWithValue("@PHN", Phone);
            try
            {
                cm.Open();
                cmd.ExecuteNonQuery();
                val = true;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); val = false; }
            finally { cm.Close(); }
            return val;
        }

        public bool Update(int ID, string Nihna, string Hming, string Phone)
        {
            bool val = false;
            SQLiteCommand cmd = new SQLiteCommand("UPDATE KohhranUpa SET Nihna=@NHN, Hming=@HMG, PhoneNo=@PHN WHERE ID=" + ID, cm);
            cmd.Parameters.AddWithValue("@NHN", Nihna);
            cmd.Parameters.AddWithValue("@HMG", Hming);
            cmd.Parameters.AddWithValue("@PHN", Phone);
            try
            {
                cm.Open();
                cmd.ExecuteNonQuery();
                val = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); val = false; }
            finally { cm.Close(); }
            return val;
        }

        public bool Delete(int ID)
        {
            bool val = false;
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM KohhranUpa WHERE ID=" + ID, cm);
            try
            {
                cm.Open();
                cmd.ExecuteNonQuery();
                val = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); val = false; }
            finally { cm.Close(); }
            return val;
        }
    }
}

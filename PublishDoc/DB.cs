using System;
using System.Data.SQLite;

namespace PublishDoc
{
    class DB
    {
        public static void CreateDB()
        {
            SQLiteConnection.CreateFile(Config.DB_PATH);
            SQLiteConnection con = Connect();
            string sql = "create table fileInfo (sourcePath varchar(1000), publishPath varchar(1000), isDirectory integer, createdAt datetime, modifiedAt datetime, publishedAt datetime)";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            CloseConnection(con);
        }

        public static bool IsValid(ref string Message)
        {
            bool valid = false;
            SQLiteConnection con;
            try
            {
                con = Connect();
                try
                {
                    string sql = "select sourcePath, publishPath, isDirectory, createdAt, modifiedAt, publishedAt from fileInfo";
                    SQLiteCommand command = new SQLiteCommand(sql, con);
                    SQLiteDataReader dr = command.ExecuteReader();
                    valid = true;
                }
                catch (Exception exi)
                {
                    Message += $"La base de datos no tiene la estructura esperada {exi.Message}";
                }
                finally
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Message += $"No es posible conectarse a la base de datos. {ex.Message}";
            }

            return valid;
        }


        public static void InsertFileInfo(string sourcePath, string publishPath, int isDirectory, DateTime createdAt, DateTime modifiedAt, DateTime publishedAt)
        {
            SQLiteConnection con = Connect();
            string sql = "insert into fileInfo(sourcePath, publishPath, isDirectory, createdAt, modifiedAt, publishedAt)";
            sql += "values($sourcePath, $publishPath, $isDirectory, $createdAt, $modifiedAt, $publishedAt)";
            SQLiteCommand command = new SQLiteCommand(sql, con);

            command.Parameters.AddWithValue("$sourcePath", sourcePath);
            command.Parameters.AddWithValue("$publishPath", publishPath);
            command.Parameters.AddWithValue("$isDirectory", isDirectory);
            command.Parameters.AddWithValue("$createdAt", createdAt);
            command.Parameters.AddWithValue("$modifiedAt", modifiedAt);
            command.Parameters.AddWithValue("$publishedAt", publishedAt);
            command.ExecuteNonQuery();
            CloseConnection(con);
        }

        public static DateTime? GetPublicationDate(string sourcePath)
        {
            SQLiteConnection con = Connect();
            string sql = "select publishedAt from fileInfo where sourcePath = $sourcePath";
            SQLiteCommand command = new SQLiteCommand(sql, con);

            command.Parameters.AddWithValue("$sourcePath", sourcePath);
            var publishedAt = command.ExecuteScalar();
            if (publishedAt == DBNull.Value)
                publishedAt = null;
            CloseConnection(con);
            return (DateTime?)publishedAt;
        }

        public static void GetFileDates(string sourcePath, ref DateTime? createdAt, ref DateTime? modifiedAt, ref DateTime? publishedAt)
        {
            SQLiteConnection con = Connect();
            string sql = "select createdAt, modifiedAt, publishedAt from fileInfo where sourcePath = $sourcePath";
            SQLiteCommand command = new SQLiteCommand(sql, con);

            command.Parameters.AddWithValue("$sourcePath", sourcePath);
            SQLiteDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {

                if (dr.IsDBNull(0))
                    createdAt = null;
                else
                    createdAt = dr.GetDateTime(0);

                if (dr.IsDBNull(1))
                    modifiedAt = null;
                else
                    modifiedAt = dr.GetDateTime(1);

                if (dr.IsDBNull(2))
                    publishedAt = null;
                else
                    publishedAt = dr.GetDateTime(2);

            }
            CloseConnection(con);
        }


        public static SQLiteConnection Connect()
        {
            SQLiteConnection con = new SQLiteConnection($"Data Source={Config.DB_PATH};Version=3;");
            con.Open();
            return con;
        }

        public static void CloseConnection(SQLiteConnection con)
        {
            con.Close();
        }
    }
}

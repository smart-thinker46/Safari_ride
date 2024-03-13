using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class AlbumDAO
    {
        //version 1 only contains fake data. No connection to actual database
        // public List<Album> Albums = new List<Album>();
        string connectionString = "datasource=localhost;port=3307;username=root;password='1031 Smart...#';database = music";

        public List<Album> getAllAlbums()
        {
            //creating an empty list
            List<Album> returnThese = new List<Album>();
            //connect to mysql database
            MysqlConnection connection = new MysqlConnection(connectionString);
            connection.open();

            MySqlCommand command  = new MySqlCommand("SELECT * FROM ALBUMS", connection);

            using (MySqlDataReader reader = command.ExecuteReader()) 
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    returnThese.Add(a);
                }
            }
            connection.close();


            return returnThese;
        }

        public List<Album> searchTitles(string searchTerm)
        {
            //creating an empty list
            List<Album> returnThese = new List<Album>();
            //connect to mysql database
            MysqlConnection connection = new MysqlConnection(connectionString);
            connection.open();

            String searchWildPhrase = "%" + searchTerm + "%";  
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID, Artist, Year, Image_Name, " +
                "Description FROM ALBUMS WHERE ALBUM_TITLE LIKE @search";

            command.parameter.AddWithValue("@search", searchWildPhrase);
            command.
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    returnThese.Add(a);
                }
            }
            connection.close();


            return returnThese;
        }
        private class MysqlConnection
        {
            private string connectionString;

            public MysqlConnection(string connectionString)
            {
                this.connectionString = connectionString;
            }

            internal void open()
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class MySqlDataReader
    {
    }
}

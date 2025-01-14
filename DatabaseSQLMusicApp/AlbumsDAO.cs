using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLMusicApp
{
    internal class AlbumsDAO
    {
        //public List <Album> albums = new List<Album>();

        string connectionString = "datasource= localhost;port=3306;username=root;password=root;database=music2;";

        public List<Album> getAllAlbums()
        {
            //start with am empty list
            List<Album> returnThease = new List<Album>();

            //connect to the mysql server

            MySqlConnection connection = new MySqlConnection (connectionString);
            connection.Open ();

            //define the sql statement to fetch all albums

            MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUMS", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read()) 
                
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)

                    };

                    returnThease.Add(a);
                
                
                }
            }

            connection.Close();

            return returnThease;

        }
    }
}

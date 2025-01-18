using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLMusicApp
{
    public class AlbumsDAO_Framework
    {
        //public List <Album> albums = new List<Album>();

        string connectionString = "datasource= localhost;port=3306;username=root;password=1234578;database=music2;";

        public List<Album> getAllAlbums()
        {
            //start with am empty list
            List<Album> returnThease = new List<Album>();

            //connect to the mysql server

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();



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

        public List<Album> searchTitles(String searchTerm)
        {
            //start with am empty list
            List<Album> returnThease = new List<Album>();

            String searchWildPhrase = "%" + searchTerm + "%";

            //connect to the mysql server

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all albums

            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT ID, ALBUM_TITLE, " +
                "ARTIST, YEAR, IMAGE_NAME, DESCRIPTION " +
                "FROM ALBUMS WHERE ALBUM_TITLE LIKE @search";

            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

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

        internal void addOneAlbum(Album2 album)
        {

            using (var context = new AppDbContext())
            {
                var album2 = new Album2
                {
                    AlbumName = "Album Name",
                    ArtistName = "Artist Name",
                    Year = 2025,
                    ImageURL = "http://example.com/image.jpg",
                    Description = "Album description"
                }; 
                context.albums.Add(album2); 
                context.SaveChanges();
            }


            ////connect to the mysql server

            //MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();



            ////define the sql statement to fetch all albums

            //MySqlCommand command = new MySqlCommand("INSERT INTO `albums`(" +
            //    " `ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) " +
            //    "VALUES (@albumtitle,@artist,@year, @imageURL, @description )", connection);

            //command.Parameters.AddWithValue("@albumtitle", album.AlbumName);
            //command.Parameters.AddWithValue("@artist", album.ArtistName);
            //command.Parameters.AddWithValue("@year", album.Year);
            //command.Parameters.AddWithValue("@imageURL", album.ImageURL);
            //command.Parameters.AddWithValue("@description", album.Description);

            //int newRows = command.ExecuteNonQuery();

            //connection.Close();

            //return newRows;
        }
    }
}

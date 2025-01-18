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

        string connectionString = "datasource= localhost;port=3306;username=root;password=12345678;database=music2;";



        public void Create3Mocks()
        {
            using (var context = new AppDbContext())
            {
                if (!context.albums.Any()) // If the table is empty
                {
                    context.albums.AddRange(
                        new AlbumFW
                        {
                            AlbumName = "Mock Album 1",
                            ArtistName = "Mock Artist 1",
                            Year = 2025,
                            ImageURL = "http://example.com/album1.jpg",
                            Description = "Description of mock album 1"
                        },
                        new AlbumFW
                        {
                            AlbumName = "Mock Album 2",
                            ArtistName = "Mock Artist 2",
                            Year = 2026,
                            ImageURL = "http://example.com/album2.jpg",
                            Description = "Description of mock album 2"
                        },
                        new AlbumFW
                        {
                            AlbumName = "Mock Album 3",
                            ArtistName = "Mock Artist 3",
                            Year = 2027,
                            ImageURL = "http://example.com/album3.jpg",
                            Description = "Description of mock album 3"
                        }
                    );

                    context.SaveChanges();
                }
            }
        }
        public List<AlbumFW> GetAllAlbums()
        {



            //With framework -- instead of this:
            ////start with am empty list
            //List<Album> returnThease = new List<Album>();

            ////connect to the mysql server

            //MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();



            ////define the sql statement to fetch all albums

            //MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUMS", connection);

            //using (MySqlDataReader reader = command.ExecuteReader())
            //{
            //    while (reader.Read())

            //    {
            //        Album a = new Album
            //        {
            //            ID = reader.GetInt32(0),
            //            AlbumName = reader.GetString(1),
            //            ArtistName = reader.GetString(2),
            //            Year = reader.GetInt32(3),
            //            ImageURL = reader.GetString(4),
            //            Description = reader.GetString(5)

            //        };

            //        returnThease.Add(a);

            //    }
            //}

            //connection.Close();



            using (var context = new AppDbContext())
            {
                // Fetch all albums from the database
                List<AlbumFW> returnThease = context.albums.ToList(); // This will retrieve all records from the 'albums' table

                // Optionally, print out the albums to check the results
                foreach (AlbumFW album in returnThease)
                {
                    Console.WriteLine($"Album Name: {album.AlbumName}, Artist: {album.ArtistName}, Year: {album.Year}");
                }
                return returnThease;
            }

          

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

        internal void AddOneAlbum(AlbumFW album)
        {
            Console.WriteLine("adding album ");
            using (var context = new AppDbContext())
            {
                var album2 = new AlbumFW
                {
                    AlbumName = album.AlbumName,
                    ArtistName = album.ArtistName,
                    Year = album.Year,
                    ImageURL = album.ImageURL,
                    Description = album.Description
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

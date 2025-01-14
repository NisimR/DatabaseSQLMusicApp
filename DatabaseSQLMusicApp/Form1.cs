namespace DatabaseSQLMusicApp
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            Album a1 = new Album

            {
                ID = 1,
                AlbumName = "My first album",
                ArtistName="Nisim Rachum",
                Year = 2022,
                ImageURL="Nothing yet",
                Description = "Nothung special"
            };

            Album a2 = new Album

            {
                ID = 2,
                AlbumName = "My second album",
                ArtistName = "Nisim Rachum",
                Year = 2022,
                ImageURL = "Nothing yet",
                Description = "Nothung special"
            };

            albumsDAO.albums.Add(a1);
            albumsDAO.albums.Add (a2);

            albumBindingSource.DataSource = albumsDAO.albums;

            dataGridView1.DataSource = albumBindingSource; 
        }
    }
}

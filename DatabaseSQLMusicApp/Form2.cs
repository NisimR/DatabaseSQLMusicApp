using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSQLMusicApp
{
    public partial class Form2 : Form
    {
        BindingSource albumBindingSource = new BindingSource();

        public Form2()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO_Framework albumsDAO = new AlbumsDAO_Framework();


            albumBindingSource.DataSource = albumsDAO.GetAllAlbums();

            dataGridView1.DataSource = albumBindingSource;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO_Framework albumsDAO = new AlbumsDAO_Framework();


            albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);

            dataGridView1.DataSource = albumBindingSource;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Clicked");

            DataGridView dataGridView = (DataGridView)sender;

            //get the row number clicked

            int rowClicked = dataGridView.CurrentRow.Index;

            //MessageBox.Show("You clicked row" + rowClicked);

            String imageURL = dataGridView.Rows[rowClicked].
                Cells[4].Value.ToString();

            pictureBox1.Load(imageURL);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_add_toDB(object sender, EventArgs e)
        {
            //add a new item to the database

            AlbumFW album = new AlbumFW
            {
                AlbumName = txt_albumName.Text,
                ArtistName = txt_albumArtist.Text,
                Year = Int32.Parse(txt_albumYear.Text),
                ImageURL = txt_ImageURL.Text,
                Description = txt_description.Text,
            };

            AlbumsDAO_Framework albumsDAO = new AlbumsDAO_Framework();
             albumsDAO.AddOneAlbum(album);
            MessageBox.Show( " Framework use");
        }

        private void txt_AlbumArtist_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_AlbumYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

    }
}

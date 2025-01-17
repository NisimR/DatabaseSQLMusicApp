using System.Windows.Forms;

namespace DatabaseSQLMusicApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {

            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button333 = new Button();
            txt_description = new TextBox();
            txt_ImageURL = new TextBox();
            txt_albumYear = new TextBox();
            txt_albumArtist = new TextBox();
            txt_albumName = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(747, 109);
            button1.Name = "button1";
            button1.Size = new Size(227, 58);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(747, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(1695, 523);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(2254, 114);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1486, 120);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(737, 47);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2512, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(557, 523);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button333);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(txt_ImageURL);
            groupBox1.Controls.Add(txt_albumYear);
            groupBox1.Controls.Add(txt_albumArtist);
            groupBox1.Controls.Add(txt_albumName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(88, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 523);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album222";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button333.Location = new Point(373, 398);
            button333.Name = "button3";
            button333.Size = new Size(188, 58);
            button333.TabIndex = 10;
            button333.Text = "Add222";
            button333.UseVisualStyleBackColor = true;
            //button333.Click += button_add_toDB;
            //button333.Click -= button3_Click;

            button333.Click += new EventHandler(button_add_toDB);

            // 
            // txt_description
            // 
            txt_description.Location = new Point(238, 299);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(323, 47);
            txt_description.TabIndex = 9;
            // 
            // txt_ImageURL
            // 
            txt_ImageURL.Location = new Point(239, 240);
            txt_ImageURL.Name = "txt_ImageURL";
            txt_ImageURL.Size = new Size(322, 47);
            txt_ImageURL.TabIndex = 8;
            // 
            // txt_albumYear
            // 
            txt_albumYear.Location = new Point(239, 180);
            txt_albumYear.Name = "txt_albumYear";
            txt_albumYear.Size = new Size(323, 47);
            txt_albumYear.TabIndex = 7;
            txt_albumYear.TextChanged += txt_AlbumYear_TextChanged;
            // 
            // txt_albumArtist
            // 
            txt_albumArtist.Location = new Point(239, 120);
            txt_albumArtist.Name = "txt_albumArtist";
            txt_albumArtist.Size = new Size(323, 47);
            txt_albumArtist.TabIndex = 6;
            txt_albumArtist.TextChanged += txt_AlbumArtist_TextChanged;
            // 
            // txt_albumName
            // 
            txt_albumName.Location = new Point(239, 60);
            txt_albumName.Name = "txt_albumName";
            txt_albumName.Size = new Size(323, 47);
            txt_albumName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 66);
            label1.Name = "label1";
            label1.Size = new Size(192, 41);
            label1.TabIndex = 0;
            label1.Text = "Album Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 302);
            label5.Name = "label5";
            label5.Size = new Size(169, 41);
            label5.TabIndex = 4;
            label5.Text = "Description";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 231);
            label4.Name = "label4";
            label4.Size = new Size(154, 41);
            label4.TabIndex = 3;
            label4.Text = "ImageURL";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 180);
            label3.Name = "label3";
            label3.Size = new Size(73, 41);
            label3.TabIndex = 2;
            label3.Text = "Year";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 126);
            label2.Name = "label2";
            label2.Size = new Size(87, 41);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            label2.Click += label2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(698, 825);
            button4.Name = "button4";
            button4.Size = new Size(188, 58);
            button4.TabIndex = 6;
            button4.Text = "GoToForm2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3164, 1010);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "DB Framework";
            Text = "DB Framework";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

            //button1 = new Button();
            //dataGridView1 = new DataGridView();
            //button2 = new Button();
            //textBox1 = new TextBox();
            //pictureBox1 = new PictureBox();
            //groupBox1 = new GroupBox();
            //button3 = new Button();
            //txt_description = new TextBox();
            //txt_ImageURL = new TextBox();
            //txt_albumYear = new TextBox();
            //txt_albumArtist = new TextBox();
            //txt_albumName = new TextBox();
            //label1 = new Label();
            //label5 = new Label();
            //label4 = new Label();
            //label3 = new Label();
            //label2 = new Label();

            //((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            //groupBox1.SuspendLayout();
            //SuspendLayout();

            //// Setup controls (the same as in your original example, corrected for consistency)
            //button1.Location = new Point(747, 109);
            //button1.Name = "button1";
            //button1.Size = new Size(227, 58);
            //button1.TabIndex = 0;
            //button1.Text = "Load Albums";
            //button1.UseVisualStyleBackColor = true;
            //button1.Click += button1_Click;

            //// Add remaining control initializations as in your original code...

            //((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            //groupBox1.ResumeLayout(false);
            //groupBox1.PerformLayout();
            //ResumeLayout(false);
            //PerformLayout();
        }

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_albumArtist;
        private TextBox txt_albumName;
        private TextBox txt_ImageURL;
        private TextBox txt_albumYear;
        private Button button333;
        private TextBox txt_description;
        private Button button4;

        //private Button button1;
        //private Button button2;
        //private Button button3;
        //private DataGridView dataGridView1;
        //private PictureBox pictureBox1;
        //private TextBox textBox1;
        //private GroupBox groupBox1;
        //private TextBox txt_albumName;
        //private TextBox txt_albumArtist;
        //private TextBox txt_albumYear;
        //private TextBox txt_ImageURL;
        //private TextBox txt_description;
        //private Label label1;
        //private Label label2;
        //private Label label3;
        //private Label label4;
        //private Label label5;

       
    }
}

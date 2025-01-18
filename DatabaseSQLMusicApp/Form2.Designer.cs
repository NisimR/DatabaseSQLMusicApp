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
            button1.Location = new Point(308, 40);
            button1.Margin = new Padding(1, 1, 1, 1);
            button1.Name = "button1";
            button1.Size = new Size(93, 21);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(308, 79);
            dataGridView1.Margin = new Padding(1, 1, 1, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(698, 191);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(928, 42);
            button2.Margin = new Padding(1, 1, 1, 1);
            button2.Name = "button2";
            button2.Size = new Size(77, 21);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(612, 44);
            textBox1.Margin = new Padding(1, 1, 1, 1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 20);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1034, 79);
            pictureBox1.Margin = new Padding(1, 1, 1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 191);
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
            groupBox1.Location = new Point(36, 79);
            groupBox1.Margin = new Padding(1, 1, 1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 1, 1, 1);
            groupBox1.Size = new Size(243, 191);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album222";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button333
            // 
            button333.Location = new Point(154, 146);
            button333.Margin = new Padding(1, 1, 1, 1);
            button333.Name = "button333";
            button333.Size = new Size(77, 21);
            button333.TabIndex = 10;
            button333.Text = "Add222";
            button333.UseVisualStyleBackColor = true;
            button333.Click += button_add_toDB;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(98, 109);
            txt_description.Margin = new Padding(1, 1, 1, 1);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(135, 23);
            txt_description.TabIndex = 9;
            // 
            // txt_ImageURL
            // 
            txt_ImageURL.Location = new Point(98, 88);
            txt_ImageURL.Margin = new Padding(1, 1, 1, 1);
            txt_ImageURL.Name = "txt_ImageURL";
            txt_ImageURL.Size = new Size(135, 23);
            txt_ImageURL.TabIndex = 8;
            // 
            // txt_albumYear
            // 
            txt_albumYear.Location = new Point(98, 66);
            txt_albumYear.Margin = new Padding(1, 1, 1, 1);
            txt_albumYear.Name = "txt_albumYear";
            txt_albumYear.Size = new Size(135, 23);
            txt_albumYear.TabIndex = 7;
            txt_albumYear.TextChanged += txt_AlbumYear_TextChanged;
            // 
            // txt_albumArtist
            // 
            txt_albumArtist.Location = new Point(98, 44);
            txt_albumArtist.Margin = new Padding(1, 1, 1, 1);
            txt_albumArtist.Name = "txt_albumArtist";
            txt_albumArtist.Size = new Size(135, 23);
            txt_albumArtist.TabIndex = 6;
            txt_albumArtist.TextChanged += txt_AlbumArtist_TextChanged;
            // 
            // txt_albumName
            // 
            txt_albumName.Location = new Point(98, 22);
            txt_albumName.Margin = new Padding(1, 1, 1, 1);
            txt_albumName.Name = "txt_albumName";
            txt_albumName.Size = new Size(135, 23);
            txt_albumName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 24);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Album Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 110);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Description";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 85);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "ImageURL";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 66);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Year";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 46);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            label2.Click += label2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(287, 302);
            button4.Margin = new Padding(1, 1, 1, 1);
            button4.Name = "button4";
            button4.Size = new Size(200, 47);
            button4.TabIndex = 6;
            button4.Text = "DB Classic";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 370);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Form2";
            Text = "DB Framework";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AssignmentC_2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void đọcGhiFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = " Vui lòng chọn đúng File để mở";
            openFileDialog.Filter = "Tệp tin văn bản (*.txt)|*.txt| tất cả các tệp tin(*.*)|*.*";
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            textBox_File.Text = File.ReadAllText(path);
            MessageBox.Show("Đọc thành công");

        }

        private void đọcGhiẢnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string textdata = textBox_File.Text;
            saveFileDialog.Filter = "tệp tin văn bản (*.txt)|*.txt";
            saveFileDialog.ShowDialog();
            string filepath = saveFileDialog.FileName;
            DialogResult result = MessageBox.Show("BẠN CÓ MUỐN LƯU TRỮ VÀO FILE HAY KO", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                File.WriteAllText(filepath, textdata);
                MessageBox.Show("Lưu thành công");
            }
            else MessageBox.Show("Tiếp tục nhập");

        }
        private void showCSDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CSDL csdl = new CSDL();
            csdl.TopLevel = false;
            csdl.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(csdl);
            csdl.Show();
            pictureBox1.Controls.Clear();
        }

        private void đọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Files|*.jpg;*.jpeg;*.png;...";
            dialog.Title = "Please select an image file to encrypt.";
            dialog.ShowDialog();
            var path = dialog.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = path;

        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\your_username\Desktop\your_file.txt";

            // Đọc file
            string[] lines = File.ReadAllLines(path);

            // Sửa đổi nội dung
            lines[2] = "Đây là dòng được sửa đổi";

            // Ghi đè file
            File.WriteAllLines(path, lines);
        }
    }
}

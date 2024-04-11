using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentC_2
{
    public partial class CSDL : Form
    {
        public CSDL()
        {
            InitializeComponent();

        }
        public void LoadData()
        {
            Data db = new Data();
            db.OpenConnection();
            string query = "SELECT * FROM Students";
            SqlCommand command = db.CreateCommand(query);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            db.CloseConnection();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Data db = new Data();
            db.OpenConnection();
            string query = "INSERT INTO Students (FullName, Major, Gender) VALUES (@fullname, @major, @gender)";
            SqlCommand command = db.CreateCommand(query);
            command.Parameters.AddWithValue("@fullname", textBox2_ten.Text);
            command.Parameters.AddWithValue("@major", textBox1_nganh.Text);
            command.Parameters.AddWithValue("@gender", checkBox1.Checked ? 1 : 0);
            command.ExecuteNonQuery();

            db.CloseConnection();

            LoadData();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần sửa!");
                return;
            }
            int id = (int)dataGridView1.SelectedRows[0].Cells["StudentID"].Value; 
            Data db = new Data();
            db.OpenConnection();

            string query = "UPDATE Students SET FullName = @fullname, Major = @major, Gender = @gender WHERE StudentID = @id";
            SqlCommand command = db.CreateCommand(query);

            command.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["StudentID"].Value);
            command.Parameters.AddWithValue("@fullname", textBox2_ten.Text);
            command.Parameters.AddWithValue("@major", textBox1_nganh.Text);
            command.Parameters.AddWithValue("@gender", checkBox1.Checked ? 1 : 0);

            command.ExecuteNonQuery();

            db.CloseConnection();

            LoadData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells["StudentID"].Value;
            Data db = new Data();
            db.OpenConnection();
            string query = "DELETE FROM Students WHERE StudentID = @id";
            SqlCommand command = db.CreateCommand(query);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            db.CloseConnection();
            LoadData();
            MessageBox.Show("Xóa bản ghi thành công!");


        }
    }
}

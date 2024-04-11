namespace AssignmentC_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_pas.Text;
            if (username == "admin" && password.Length > 5)
            {
                if (radioButton1.Checked)
                {
                    MessageBox.Show(" Đăng nhập thành công ");
                    this.Hide();
                    new Main().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cần xác nhận bạn là người ");
                }
               

            }
            else
            {
                MessageBox.Show("Dữ liệu sai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_pas.Focus();
            }
        }
    }
}

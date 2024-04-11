namespace AssignmentC_2
{
    partial class CSDL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBox1_nganh = new TextBox();
            textBox2_ten = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button_load = new Button();
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(526, 179);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1_nganh
            // 
            textBox1_nganh.Location = new Point(353, 62);
            textBox1_nganh.Name = "textBox1_nganh";
            textBox1_nganh.Size = new Size(215, 27);
            textBox1_nganh.TabIndex = 1;
            // 
            // textBox2_ten
            // 
            textBox2_ten.Location = new Point(33, 62);
            textBox2_ten.Name = "textBox2_ten";
            textBox2_ten.Size = new Size(215, 27);
            textBox2_ten.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 23);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Ngành";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 127);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 5;
            label3.Text = "Giới tính";
            // 
            // button2
            // 
            button2.Location = new Point(42, 266);
            button2.Name = "button2";
            button2.Size = new Size(221, 54);
            button2.TabIndex = 8;
            button2.Text = "Xóa Sinh viên";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(42, 188);
            button4.Name = "button4";
            button4.Size = new Size(221, 54);
            button4.TabIndex = 8;
            button4.Text = "Xửa sinh viên";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button_load);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button4);
            groupBox1.Location = new Point(9, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 342);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // button1
            // 
            button1.Location = new Point(42, 109);
            button1.Name = "button1";
            button1.Size = new Size(221, 48);
            button1.TabIndex = 9;
            button1.Text = "Thêm Sinh Viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_load
            // 
            button_load.Location = new Point(42, 29);
            button_load.Name = "button_load";
            button_load.Size = new Size(221, 54);
            button_load.TabIndex = 8;
            button_load.Text = "Load";
            button_load.UseVisualStyleBackColor = true;
            button_load.Click += button3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(textBox2_ten);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(textBox1_nganh);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(314, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(594, 341);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(277, 126);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(168, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Tích nếu bạn là nam ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // CSDL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 358);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CSDL";
            Text = "CSDL";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1_nganh;
        private TextBox textBox2_ten;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button_load;
        private Button button1;
        private CheckBox checkBox1;
    }
}
namespace AssignmentC_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_username = new TextBox();
            textBox_pas = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            radioButton1 = new RadioButton();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(244, 49);
            textBox_username.Name = "textBox_username";
            textBox_username.PlaceholderText = "Mời nhập tên của bạn";
            textBox_username.Size = new Size(395, 27);
            textBox_username.TabIndex = 0;
            textBox_username.KeyDown += textBox_username_KeyDown;
            // 
            // textBox_pas
            // 
            textBox_pas.Location = new Point(244, 140);
            textBox_pas.Name = "textBox_pas";
            textBox_pas.PasswordChar = '*';
            textBox_pas.PlaceholderText = "Mời nhập mật khẩu";
            textBox_pas.Size = new Size(395, 27);
            textBox_pas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(129, 48);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(141, 142);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 3;
            label2.Text = "Pasword";
            // 
            // button1
            // 
            button1.Location = new Point(169, 280);
            button1.Name = "button1";
            button1.Size = new Size(153, 65);
            button1.TabIndex = 4;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(323, 212);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(185, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tôi không phải là robot";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(473, 280);
            button2.Name = "button2";
            button2.Size = new Size(153, 65);
            button2.TabIndex = 6;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 391);
            Controls.Add(button2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_pas);
            Controls.Add(textBox_username);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_username;
        private TextBox textBox_pas;
        private Label label1;
        private Label label2;
        private Button button1;
        private RadioButton radioButton1;
        private Button button2;
    }
}

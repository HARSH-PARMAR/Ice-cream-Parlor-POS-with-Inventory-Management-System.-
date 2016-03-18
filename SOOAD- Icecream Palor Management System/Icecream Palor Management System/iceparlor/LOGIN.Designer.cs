namespace iceparlor
{
    partial class LOGIN
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mobile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Signup = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pass = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.mobileNo = new System.Windows.Forms.Label();
            this.Signup.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.Location = new System.Drawing.Point(48, 88);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(66, 13);
            this.mobile.TabIndex = 2;
            this.mobile.Text = "MOBILE NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(132, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Login as manager";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "SIGNUP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "LOGIN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Signup
            // 
            this.Signup.Controls.Add(this.richTextBox1);
            this.Signup.Controls.Add(this.button3);
            this.Signup.Controls.Add(this.radioButton2);
            this.Signup.Controls.Add(this.radioButton1);
            this.Signup.Controls.Add(this.pass);
            this.Signup.Controls.Add(this.textBox3);
            this.Signup.Controls.Add(this.label7);
            this.Signup.Controls.Add(this.password);
            this.Signup.Controls.Add(this.mobileNo);
            this.Signup.Location = new System.Drawing.Point(271, 26);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(289, 377);
            this.Signup.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(130, 102);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(131, 73);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "SIGNUP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(147, 201);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "EMPLOYEE";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 204);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MANAGER";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(132, 63);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(129, 20);
            this.pass.TabIndex = 12;
            this.pass.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "ADDRESS";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(24, 68);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 13);
            this.password.TabIndex = 3;
            this.password.Text = "PASSWORD";
            // 
            // mobileNo
            // 
            this.mobileNo.AutoSize = true;
            this.mobileNo.Location = new System.Drawing.Point(24, 32);
            this.mobileNo.Name = "mobileNo";
            this.mobileNo.Size = new System.Drawing.Size(66, 13);
            this.mobileNo.TabIndex = 2;
            this.mobileNo.Text = "MOBILE NO";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 446);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Signup.ResumeLayout(false);
            this.Signup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label mobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Signup;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label mobileNo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


namespace PersonalTracking
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
            this.Login = new System.Windows.Forms.Button();
            this.Exit_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNo = new System.Windows.Forms.TextBox();
            this.Pasword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login.Location = new System.Drawing.Point(289, 219);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(136, 57);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Exit_bttn
            // 
            this.Exit_bttn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit_bttn.Location = new System.Drawing.Point(101, 219);
            this.Exit_bttn.Name = "Exit_bttn";
            this.Exit_bttn.Size = new System.Drawing.Size(136, 57);
            this.Exit_bttn.TabIndex = 1;
            this.Exit_bttn.Text = "Exit";
            this.Exit_bttn.UseVisualStyleBackColor = true;
            this.Exit_bttn.Click += new System.EventHandler(this.Exit_bttn_clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserNO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserNo
            // 
            this.UserNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserNo.Location = new System.Drawing.Point(231, 56);
            this.UserNo.Name = "UserNo";
            this.UserNo.Size = new System.Drawing.Size(194, 39);
            this.UserNo.TabIndex = 3;
            this.UserNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.UserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserNo_KeyPress);
            // 
            // Pasword
            // 
            this.Pasword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pasword.Location = new System.Drawing.Point(231, 130);
            this.Pasword.Name = "Pasword";
            this.Pasword.Size = new System.Drawing.Size(194, 39);
            this.Pasword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(502, 345);
            this.Controls.Add(this.Pasword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_bttn);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Login;
        private Button Exit_bttn;
        private Label label1;
        private TextBox UserNo;
        private TextBox Pasword;
        private Label label2;
    }
}
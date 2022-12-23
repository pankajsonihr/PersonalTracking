namespace PersonalTracking
{
    partial class FrmMain
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
            this.Employee_btn = new System.Windows.Forms.Button();
            this.Tasks_btn = new System.Windows.Forms.Button();
            this.Department_btn = new System.Windows.Forms.Button();
            this.Permission_btn = new System.Windows.Forms.Button();
            this.Position_btn = new System.Windows.Forms.Button();
            this.Salary_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Employee_btn
            // 
            this.Employee_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Employee_btn.Location = new System.Drawing.Point(32, 41);
            this.Employee_btn.Name = "Employee_btn";
            this.Employee_btn.Size = new System.Drawing.Size(181, 91);
            this.Employee_btn.TabIndex = 0;
            this.Employee_btn.Text = "Employee";
            this.Employee_btn.UseVisualStyleBackColor = true;
            this.Employee_btn.Click += new System.EventHandler(this.Employee_btn_Click);
            // 
            // Tasks_btn
            // 
            this.Tasks_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tasks_btn.Location = new System.Drawing.Point(254, 41);
            this.Tasks_btn.Name = "Tasks_btn";
            this.Tasks_btn.Size = new System.Drawing.Size(181, 91);
            this.Tasks_btn.TabIndex = 1;
            this.Tasks_btn.Text = "Tasks";
            this.Tasks_btn.UseVisualStyleBackColor = true;
            this.Tasks_btn.Click += new System.EventHandler(this.Tasks_btn_Click);
            // 
            // Department_btn
            // 
            this.Department_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Department_btn.Location = new System.Drawing.Point(254, 177);
            this.Department_btn.Name = "Department_btn";
            this.Department_btn.Size = new System.Drawing.Size(181, 91);
            this.Department_btn.TabIndex = 4;
            this.Department_btn.Text = "Department";
            this.Department_btn.UseVisualStyleBackColor = true;
            this.Department_btn.Click += new System.EventHandler(this.Department_btn_Click);
            // 
            // Permission_btn
            // 
            this.Permission_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Permission_btn.Location = new System.Drawing.Point(32, 177);
            this.Permission_btn.Name = "Permission_btn";
            this.Permission_btn.Size = new System.Drawing.Size(181, 91);
            this.Permission_btn.TabIndex = 3;
            this.Permission_btn.Text = "Permission";
            this.Permission_btn.UseVisualStyleBackColor = true;
            this.Permission_btn.Click += new System.EventHandler(this.Permission_btn_Click);
            // 
            // Position_btn
            // 
            this.Position_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Position_btn.Location = new System.Drawing.Point(510, 177);
            this.Position_btn.Name = "Position_btn";
            this.Position_btn.Size = new System.Drawing.Size(181, 91);
            this.Position_btn.TabIndex = 5;
            this.Position_btn.Text = "Position";
            this.Position_btn.UseVisualStyleBackColor = true;
            this.Position_btn.Click += new System.EventHandler(this.Position_btn_Click);
            // 
            // Salary_btn
            // 
            this.Salary_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Salary_btn.Location = new System.Drawing.Point(510, 41);
            this.Salary_btn.Name = "Salary_btn";
            this.Salary_btn.Size = new System.Drawing.Size(181, 91);
            this.Salary_btn.TabIndex = 2;
            this.Salary_btn.Text = "Salary";
            this.Salary_btn.UseVisualStyleBackColor = true;
            this.Salary_btn.Click += new System.EventHandler(this.Salary_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit_btn.Location = new System.Drawing.Point(254, 302);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(181, 91);
            this.Exit_btn.TabIndex = 7;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logout_btn.Location = new System.Drawing.Point(32, 302);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(181, 91);
            this.Logout_btn.TabIndex = 6;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 427);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Position_btn);
            this.Controls.Add(this.Salary_btn);
            this.Controls.Add(this.Department_btn);
            this.Controls.Add(this.Permission_btn);
            this.Controls.Add(this.Tasks_btn);
            this.Controls.Add(this.Employee_btn);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Employee_btn;
        private Button Tasks_btn;
        private Button Department_btn;
        private Button Permission_btn;
        private Button Position_btn;
        private Button Salary_btn;
        private Button Exit_btn;
        private Button Logout_btn;
    }
}
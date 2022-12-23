namespace PersonalTracking
{
    partial class FrmPermissionList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textDayAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Search_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioDelivery = new System.Windows.Forms.RadioButton();
            this.radioStart = new System.Windows.Forms.RadioButton();
            this.dateFinish = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.textSurName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_UserNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Disapprove_btn = new System.Windows.Forms.Button();
            this.Approve_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.New_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 302);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textDayAmount);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.Search_btn);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.dateFinish);
            this.panel4.Controls.Add(this.dateStart);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(459, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(765, 302);
            this.panel4.TabIndex = 1;
            // 
            // textDayAmount
            // 
            this.textDayAmount.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.textDayAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textDayAmount.Location = new System.Drawing.Point(253, 211);
            this.textDayAmount.Name = "textDayAmount";
            this.textDayAmount.Size = new System.Drawing.Size(212, 39);
            this.textDayAmount.TabIndex = 28;
            this.textDayAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDayAmount_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(45, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 32);
            this.label9.TabIndex = 29;
            this.label9.Text = "Day Amount";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Search_btn.Location = new System.Drawing.Point(564, 174);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(124, 51);
            this.Search_btn.TabIndex = 23;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDelivery);
            this.groupBox1.Controls.Add(this.radioStart);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(558, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 128);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // radioDelivery
            // 
            this.radioDelivery.AutoSize = true;
            this.radioDelivery.Location = new System.Drawing.Point(6, 66);
            this.radioDelivery.Name = "radioDelivery";
            this.radioDelivery.Size = new System.Drawing.Size(168, 32);
            this.radioDelivery.TabIndex = 1;
            this.radioDelivery.TabStop = true;
            this.radioDelivery.Text = "Delivery Date";
            this.radioDelivery.UseVisualStyleBackColor = true;
            // 
            // radioStart
            // 
            this.radioStart.AutoSize = true;
            this.radioStart.Location = new System.Drawing.Point(6, 28);
            this.radioStart.Name = "radioStart";
            this.radioStart.Size = new System.Drawing.Size(135, 32);
            this.radioStart.TabIndex = 0;
            this.radioStart.TabStop = true;
            this.radioStart.Text = "Start Date";
            this.radioStart.UseVisualStyleBackColor = true;
            // 
            // dateFinish
            // 
            this.dateFinish.Location = new System.Drawing.Point(253, 150);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.Size = new System.Drawing.Size(212, 31);
            this.dateFinish.TabIndex = 22;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(253, 92);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(212, 31);
            this.dateStart.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(123, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 32);
            this.label8.TabIndex = 26;
            this.label8.Text = "Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(123, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 32);
            this.label7.TabIndex = 25;
            this.label7.Text = "Finish";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(123, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "Permission Date";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbPosition);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cmbDepartment);
            this.panel3.Controls.Add(this.textSurName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textbox_UserNo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 302);
            this.panel3.TabIndex = 0;
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(215, 166);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(194, 40);
            this.cmbPosition.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Position";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(215, 224);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(194, 40);
            this.cmbDepartment.TabIndex = 23;
            // 
            // textSurName
            // 
            this.textSurName.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.textSurName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textSurName.Location = new System.Drawing.Point(215, 121);
            this.textSurName.Name = "textSurName";
            this.textSurName.Size = new System.Drawing.Size(194, 39);
            this.textSurName.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "SurName";
            // 
            // textName
            // 
            this.textName.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.textName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textName.Location = new System.Drawing.Point(215, 76);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(194, 39);
            this.textName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name";
            // 
            // textbox_UserNo
            // 
            this.textbox_UserNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textbox_UserNo.Location = new System.Drawing.Point(215, 31);
            this.textbox_UserNo.Name = "textbox_UserNo";
            this.textbox_UserNo.Size = new System.Drawing.Size(194, 39);
            this.textbox_UserNo.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "UserNO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Disapprove_btn);
            this.panel2.Controls.Add(this.Approve_btn);
            this.panel2.Controls.Add(this.Close_btn);
            this.panel2.Controls.Add(this.Update_btn);
            this.panel2.Controls.Add(this.Delete_btn);
            this.panel2.Controls.Add(this.New_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 686);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 139);
            this.panel2.TabIndex = 1;
            // 
            // Disapprove_btn
            // 
            this.Disapprove_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Disapprove_btn.Location = new System.Drawing.Point(188, 41);
            this.Disapprove_btn.Name = "Disapprove_btn";
            this.Disapprove_btn.Size = new System.Drawing.Size(173, 54);
            this.Disapprove_btn.TabIndex = 10;
            this.Disapprove_btn.Text = "Disapprove";
            this.Disapprove_btn.UseVisualStyleBackColor = true;
            // 
            // Approve_btn
            // 
            this.Approve_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Approve_btn.Location = new System.Drawing.Point(54, 41);
            this.Approve_btn.Name = "Approve_btn";
            this.Approve_btn.Size = new System.Drawing.Size(128, 54);
            this.Approve_btn.TabIndex = 5;
            this.Approve_btn.Text = "Approve";
            this.Approve_btn.UseVisualStyleBackColor = true;
            // 
            // Close_btn
            // 
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Close_btn.Location = new System.Drawing.Point(769, 41);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(128, 54);
            this.Close_btn.TabIndex = 9;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            // 
            // Update_btn
            // 
            this.Update_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update_btn.Location = new System.Drawing.Point(501, 41);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(128, 54);
            this.Update_btn.TabIndex = 7;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_btn.Location = new System.Drawing.Point(635, 41);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(128, 54);
            this.Delete_btn.TabIndex = 8;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            // 
            // New_btn
            // 
            this.New_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.New_btn.Location = new System.Drawing.Point(367, 41);
            this.New_btn.Name = "New_btn";
            this.New_btn.Size = new System.Drawing.Size(128, 54);
            this.New_btn.TabIndex = 6;
            this.New_btn.Text = "New";
            this.New_btn.UseVisualStyleBackColor = true;
            this.New_btn.Click += new System.EventHandler(this.New_btn_Click);
            // 
            // FrmPermissionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 825);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPermissionList";
            this.Text = "FrmPermissionList";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Disapprove_btn;
        private Button Approve_btn;
        private Button Close_btn;
        private Button Update_btn;
        private Button Delete_btn;
        private Button New_btn;
        private Panel panel3;
        private ComboBox cmbPosition;
        private Label label4;
        private Label label5;
        private ComboBox cmbDepartment;
        private TextBox textSurName;
        private Label label3;
        private TextBox textName;
        private Label label2;
        private TextBox textbox_UserNo;
        private Label label1;
        private Panel panel4;
        private Button Search_btn;
        private GroupBox groupBox1;
        private RadioButton radioDelivery;
        private RadioButton radioStart;
        private DateTimePicker dateFinish;
        private DateTimePicker dateStart;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textDayAmount;
        private Label label9;
    }
}
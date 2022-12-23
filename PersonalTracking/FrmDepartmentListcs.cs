﻿using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FrmDepartmentListcs : Form
    {
        List<DEPARTMENT> list = new List<DEPARTMENT>();
        public FrmDepartmentListcs()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            list=BLL.Department.GetDepartment();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void FrmDepartmentListcs_Load(object sender, EventArgs e)
        {
            list = BLL.Department.GetDepartment();
            dataGridView1.DataSource= list;
            dataGridView1.Columns[0].Visible= false;
            dataGridView1.Columns[1].HeaderText = "Department Name";
        }
    }
}

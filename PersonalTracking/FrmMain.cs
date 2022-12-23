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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Employee_btn_Click(object sender, EventArgs e)
        {
            FrmEmployeeList frm= new FrmEmployeeList();
            this.Hide();
            frm.ShowDialog();
            this.Visible= true;
        }

        private void Tasks_btn_Click(object sender, EventArgs e)
        {
            FrmTaskList frm= new FrmTaskList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void Salary_btn_Click(object sender, EventArgs e)
        {
            FrmSalaryList frm = new FrmSalaryList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void Permission_btn_Click(object sender, EventArgs e)
        {
            FrmPermissionList frm = new FrmPermissionList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void Department_btn_Click(object sender, EventArgs e)
        {
            FrmDepartmentListcs frm = new FrmDepartmentListcs();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void Position_btn_Click(object sender, EventArgs e)
        {
            FrmPositionList frm = new FrmPositionList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}

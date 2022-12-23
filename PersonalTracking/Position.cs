using BLL;
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
    public partial class Position : Form
    {
        List<DEPARTMENT> departmentList = new List<DEPARTMENT>();
        public Position()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Position_Load(object sender, EventArgs e)
        {
            departmentList = Department.GetDepartment();
            cmbDepartment.DataSource=departmentList;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember= "ID";
            cmbDepartment.SelectedIndex = -1;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the position Name");
            }
            else if (cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a department");
            }
            else
            {
                POSITION position= new POSITION();
                position.PositionName= cmbDepartment.Text;
                position.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                BLL.Position.AddPosition(position);
                MessageBox.Show("Position was added");
                textBox1.Clear();
                cmbDepartment.SelectedIndex = -1;
            }
            
        }
    }
}

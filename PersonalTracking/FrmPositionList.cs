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
    public partial class FrmPositionList : Form
    {
        public FrmPositionList()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            Position frm = new Position();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            Position frm = new Position();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}

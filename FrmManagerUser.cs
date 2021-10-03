using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicWinform.Entities;

namespace BasicWinform
{
    public partial class FrmManagerUser : Form
    {
        public FrmManagerUser()
        {
            InitializeComponent();
            var ls = Person.GetList();
            personBindingSource.DataSource = ls;
            gridSV.DataSource = personBindingSource;

        }
        public Person selectedPerson
        {
            get
            {
                var p = personBindingSource.Current as Person;
                return p;
            }
        }

        private void gridSV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(selectedPerson != null)
            {
                var f = new User(selectedPerson.Id);
                f.Show();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if(selectedPerson != null)
            {
                var result = MessageBox.Show("Bạn có muốn xóa sinh viên này không", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    personBindingSource.RemoveCurrent();
                }    
            }    
        }
    }
}

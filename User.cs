using BasicWinform.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWinform
{
    public partial class User : Form
    {
        Person person;
        public User(string idPerson = "1")
        {
            InitializeComponent();
            person = Person.Get(idPerson);
            if (person != null)
            {
                //Cách 1
                txtHoTen.Text = $"{person.LastName} {person.FirstName}";
                //Cách 2
                txtHoTen.Text = person.FullName;
                dtpNgaySinh.Value = person.DOB;
                if (person.Sex == EGioiTinh.Nam)
                    rdNam.Checked = true;
                else if (person.Sex == EGioiTinh.Nu)
                    rdNu.Checked = true;
                else
                    rdKhac.Checked = true;

                txtQueQuan.Text = person.HomeTown;
            }
            var ds = History.GetList();
            historyBindingSource.DataSource = ds;
            gridSinhVien.DataSource = historyBindingSource;
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void gridSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtQueQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void picAvt_Click(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(setColor.ShowDialog() == DialogResult.OK)
            { 
            this.BackColor = setColor.Color;
            }
        }
    }
}

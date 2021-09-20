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
    public partial class frmUser : Form
    {
        Person person;
        public frmUser(string idPerson = "1")
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
        }
    }
}

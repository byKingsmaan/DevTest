using DevTesr.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevTesr.BLL;
using DevTesr.DAL;
using System.Web;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DevTesr.PL
{
    public partial class frmEmployee : Form
    {
        EmployeeDAL ObjectEmployeeDAL;


        static bool ValidateRFC(string rfc)
        {
            // 3 o 4 letras mayúsculas(de la A a la Z o la letra Ñ) o el carácter '&'.
            // 6 dígitos.
            //letra mayúscula de la A a la V(excluyendo la letra W) o un dígito del 1 al 9.
            //letra mayúscula de la A a la Z o un dígito del 1 al 9.
            //un dígito.
            string xpression = @"^[A-Z&Ñ]{3,4}[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])[A-Z0-9]{2}[0-9A]$";
            Regex regex = new Regex(xpression);
            return regex.IsMatch(rfc);
        }
        public frmEmployee()
        {

            ObjectEmployeeDAL = new EmployeeDAL();
            InitializeComponent();
            //dataGridQuery.DataSource = ObjectEmployeeDAL.ShowData().Tables[0];
        }
        private EmployeeBLL EmployeeInfo()
        {
            EmployeeBLL ObjectEmployeeBLL = new EmployeeBLL();
            int id_employee = 0; int.TryParse(txt_id_employee.Text, out id_employee);
            ObjectEmployeeBLL.ID = id_employee;
            ObjectEmployeeBLL.Name = txt_name_employee.Text;
            ObjectEmployeeBLL.LastName = txt_last_name_employee.Text;
            ObjectEmployeeBLL.RFC = txt_rfc_employee.Text;
            //DateTime born_date; DateTime.TryParse(txt_born_date_employee.Text, out born_date);
            ObjectEmployeeBLL.BornDate = datetime_borndate.Value;
            //int status_employee = 0; int.TryParse(txt_status_employee.Text, out status_employee);
            //ObjectEmployeeBLL.Status = status_employee;
            ObjectEmployeeBLL.Status = cmbx_status.SelectedIndex;

            return ObjectEmployeeBLL;

        }

        public void button1_Click(object sender, EventArgs e)
        {
            String RFC = txt_rfc_employee.Text;
            RFC = RFC.ToUpper();

            if (txt_name_employee.Text == "" || txt_last_name_employee.Text == "" || txt_rfc_employee.Text == "" || cmbx_status.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Complete all the fields");
            }
            else if (txt_rfc_employee.Text.Length < 12 || txt_rfc_employee.Text.Length > 13)
            {
                MessageBox.Show("The RFC it could be 12 or 13 characters");
            }
            else if (ValidateRFC(RFC) == false)
            {
                MessageBox.Show("RFC incorrect");
            }
            else if (ObjectEmployeeDAL.SearchRFC(EmployeeInfo()) == true)
            {
                MessageBox.Show("The RFC is already registered");
            }
            else
            {
                ObjectEmployeeDAL.Add(EmployeeInfo());
                MessageBox.Show("Registered");
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_employee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_last_name_employee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Query_data_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Please confirm" + "\n" + "Add query by name?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                ObjectEmployeeDAL.SearchByBornDateplusName(EmployeeInfo());
            }
            else

            {
                ObjectEmployeeDAL.SearchByBornDate(EmployeeInfo());
            }
        }
    }
}

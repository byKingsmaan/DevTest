using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevTesr.BLL;

namespace DevTesr.DAL
{
    internal class EmployeeDAL
    {
        ConectionDAL conn;

        public EmployeeDAL()
        {
            conn = new ConectionDAL();
        }
        public bool Add(EmployeeBLL ObjectEmployeeBLL)
        {
            return conn.ExeCmdABC("INSERT INTO employees VALUES('" + ObjectEmployeeBLL.Name + "','" + ObjectEmployeeBLL.LastName + "','" + ObjectEmployeeBLL.RFC + "', '" + ObjectEmployeeBLL.BornDate + "', '" + ObjectEmployeeBLL.Status + "')");
        }
        public bool SearchRFC(EmployeeBLL ObjectEmployeeBLL)
        {
            return conn.ExeCmdQueryRFC("SELECT * FROM Employees WHERE rfc_employee='" + ObjectEmployeeBLL.RFC + "';");
        }
        public bool SearchByBornDateplusName(EmployeeBLL ObjectEmployeeBLL)
        {
            return conn.ExeCmdQueryByBornDateplusName("  SELECT * FROM Employees WHERE name_employee='" + ObjectEmployeeBLL.Name + "' AND borndate_employee<='" + ObjectEmployeeBLL.BornDate + "';");
        }
        public bool SearchByBornDate(EmployeeBLL ObjectEmployeeBLL)
        {
            return conn.ExeCmdQueryByBornDate("  SELECT * FROM Employees WHERE borndate_employee <= '"+ObjectEmployeeBLL.BornDate + "' ;");
        }
        public DataSet ShowData()
        {
            SqlCommand query = new SqlCommand(" SELECT * FROM Employees WHERE borndate_employee= ( SELECT MAX(borndate_employee) FROM Employees );");
            return conn.ExeCmdQueryDatabyBornMaxDate(query);
        }
    }
}

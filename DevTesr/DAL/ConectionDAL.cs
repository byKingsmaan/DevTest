using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DevTesr.DAL
{
    class ConectionDAL
    {
        private String ConnString = "Data Source=DESKTOP-HNAFM6S;Initial Catalog=dbDevTest;Integrated Security =True";
        SqlConnection Conn;

        public SqlConnection OnlineConn()
        {
            this.Conn = new SqlConnection(ConnString);
            return this.Conn;
        }


        public bool ExeCmdABC(string ConnString){
            try {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = ConnString;
                cmd.Connection = this.OnlineConn();
                Conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())

                cmd.ExecuteNonQuery();
                Conn.Close();

                return true;

            }
            catch 
            {
                return false;
            }
        }
        
        public bool ExeCmdQueryRFC(string ConnString)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = ConnString;
                cmd.Connection = this.OnlineConn();
                Conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        
                        //Existen datos
                        return true;

                    }
                    else
                    {
                        //No hay datos
                        return false;
                    }
                }

                cmd.ExecuteNonQuery();
                Conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                //Error de consulta
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return false;
            }
        }
        public bool ExeCmdQueryByBornDate(string ConnString)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = ConnString;
                cmd.Connection = this.OnlineConn();
                Conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string mensaje = $"id_employee: {reader.GetInt32(0)}, Name: {reader.GetString(1)}, Last Name: {reader.GetString(2)}";
                            MessageBox.Show(mensaje);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
 
                        MessageBox.Show(ConnString);
                    }

                }

                cmd.ExecuteNonQuery();
                Conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                //Error de consulta
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return false;
            }
        }
        public bool ExeCmdQueryByBornDateplusName(string ConnString)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = ConnString;
                cmd.Connection = this.OnlineConn();
                Conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {

                            string mensaje = $"id_employee: {reader.GetInt32(0)}, Name: {reader.GetString(1)}, Last Name: {reader.GetString(2)}";
                            MessageBox.Show(mensaje);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
                        
                    }

                }

                cmd.ExecuteNonQuery();
                Conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                //Error de consulta
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return false;
            }
        }
        public DataSet ExeCmdQueryDatabyBornMaxDate(SqlCommand comando)
        {

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd = comando;
                    cmd.CommandText = ConnString;
                    cmd.Connection = OnlineConn();
                    cmd.ExecuteNonQuery();
                    Conn.Open();
                    adapter.Fill(ds);

                
                Conn.Close();
                    return ds;
                }
                catch
                {
                    return ds;
                }
        }


    }
        

       
    
}

using System.Data;
using System.Data.SqlClient;
using System.IO;

 
public static class Database
{
    static System.Data.SqlClient.SqlConnection Cn = new System.Data.SqlClient.SqlConnection();

        public static void Apridatabase(string StringaConnessione)
        {
            Cn.ConnectionString = StringaConnessione;
            Cn.Open();
        }
    public static System.Data.DataTable Leggitabella(string Sql,string Nome)
    {
    
           try
            {
                using (SqlCommand _cmd = new SqlCommand(Sql, Cn))
                {
                    DataTable customerTable = new DataTable(Nome);

                    SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                    //   _con.Open();
                    _dap.Fill(customerTable);
                    //   _con.Close();

                    return customerTable;

                }
            }
            catch
            {
                return null;
            }

         
        }

}

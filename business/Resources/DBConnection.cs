using Microsoft.Data.SqlClient;
using System.Data;

namespace business.Resources
{
    public class DBConnection
    {
        public static string connection_string = "data source=.;initial catalog=business;trusted_connection=true;TrustServerCertificate=True";
       
        // Listar tabla
        public static DataTable ListAll(string store_name, List<Parameter> parameters = null)
        {
            SqlConnection sqlConnection = new SqlConnection(connection_string);
            try
            {
                System.Diagnostics.Debug.WriteLine("\n\nInicia el Proceso");
                System.Diagnostics.Debug.WriteLine(sqlConnection);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(store_name, sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                if (parameters != null ) {
                    foreach (var parameter in parameters)
                    {
                        sqlCommand.Parameters.AddWithValue(parameter.name, parameter.value);
                    }
                }

                DataTable dataTable= new DataTable();
                SqlDataAdapter sqlDataAdapter= new SqlDataAdapter(sqlCommand);  
                sqlDataAdapter.Fill(dataTable);
                System.Diagnostics.Debug.WriteLine(dataTable);
                return dataTable;
                System.Diagnostics.Debug.WriteLine("\n\nExito");
            } catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("\n\nFallo");
                System.Diagnostics.Debug.WriteLine(ex);
                return null;
            }
            finally { sqlConnection.Close(); }
        }

    }
}

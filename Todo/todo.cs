// internal class Program
// {
//     private readonly string _link = @"link/to/the/database";
//     private readonly SqlConnection _con = new SqlConnection(_link);
//
//     using(SqlConnection _con = new SqlConnection(connectionString))
//     {
//         string queryStatement = "SELECT TOP 5 * FROM dbo.Customers ORDER BY CustomerID";
//
//         using(SqlCommand _cmd = new SqlCommand(queryStatement, _con))
//         {
//             DataTable customerTable = new DataTable("Top5Customers");
//       
//             SqlDataAdapter _dap = new SqlDataAdapter(_cmd);
//
//             _con.Open();
//             _dap.Fill(customerTable);
//             _con.Close();
//
//         }
//     }
// }

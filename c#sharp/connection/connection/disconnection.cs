using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedArch
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlDataAdapter da;
        static void Main(string[] args)
        {
            try
            {
                //setting up the connection with the server
                con = new SqlConnection("data source=ICS-LAP-7459\\SQLEXPRESS;initial catalog=sql;" +
                "Integrated Security=True");
                //execution of sql commands using dataadapter class object
                da = new SqlDataAdapter("Select * from Employee", con);

                con.Open();
                //creating a dataset object that can hold datatables, DataRelations,Data Constraints

                DataSet ds = new DataSet();
                //filling the output of the query into the dataset by identifying a datatable  with a name
                da.Fill(ds, "InfiniteEmployee");
                //associating the newly created datatable object as one of the element
                //in the dataset container
                DataTable dt = ds.Tables["InfiniteEmployee"];

                //iterate the datatble using datarows and datacolumns object
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(row[col]);
                        Console.Write(" ");
                    }
                    Console.WriteLine(" ");
                }
                //inserting a row using datasets and dataadapter
                SqlCommandBuilder scb = new SqlCommandBuilder(da);
                da.Fill(ds);
                DataRow row1 = ds.Tables["InfiniteEmployee"].NewRow();
                row1["Empid"] = 13;
                row1["Empname"] = "suresh";
                row1["Salary"] = 14500;
                row1["Gender"] = "Male";
                row1["DeptId"] = 4;
                row1["Phone"] = "133434";
                ds.Tables["InfiniteEmployee"].Rows.Add(row1);
                da.UpdateCommand = scb.GetUpdateCommand();
                da.Update(ds, "InfiniteEmployee");
                Console.WriteLine("-------------------");
                //ensuring that t=we are pointed to the correct datatable
                dt = ds.Tables["InfiniteEmployee"];

                foreach (DataRow rows in dt.Rows)
                {
                    foreach (DataColumn cols in dt.Columns)
                    {
                        Console.Write(rows[cols]);
                        Console.Write(" ");
                    }
                    Console.WriteLine(" ");
                }


            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
            Console.Read();
        }
    }
}
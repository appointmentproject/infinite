
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace testonado.net
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=ICS-LAP-2643;initial catalog=test;" + "Integrated Security=True");
            con.Open();
            return con;
        }
        public static void InsertEmployee()
        {
            con = getConnection();



            Console.WriteLine("Please enter empname,empsal,emptype");
            string empname = Console.ReadLine();
            float empsal = float.Parse(Console.ReadLine());
            char emptype = Convert.ToChar(Console.ReadLine());
            cmd = new SqlCommand("insert into code_Employee values(@empname,@empsal,@emptype)", con);
            cmd.Parameters.AddWithValue("@empname", empname);
            cmd.Parameters.AddWithValue("@empsal", empsal);
            cmd.Parameters.AddWithValue("@emptype", emptype);
            Console.ReadLine();
            int records = cmd.ExecuteNonQuery();
            if (records > 0)
            {
                Console.WriteLine("Inserted successfully..");
            }
            else
                Console.WriteLine("Something went wrong..");
        }



        static void Main(string[] args)
        {

            InsertEmployee();

            Console.Read();
        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient;


namespace connections
{
    class Program
    {

        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        //function that establishes connection with the database server and returns
        // an object of SqlConnection type
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=ICS-LAP-7459\\SQLEXPRESS;initial catalog=sql;" +
                "Integrated Security=True");
            con.Open();
            return con;
        }
        public static void StoredProcCall()
        {
            con = getConnection();
            cmd = new SqlCommand("InsertEmployee", con); //name of the procedure
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();
            Console.Read();
            while (dr.Read())
            {
                Console.WriteLine("Employee Id: " + dr[0]);
                Console.WriteLine("Name :" + dr[1]);
                Console.WriteLine("Salary :" + dr[2]);
                Console.WriteLine("Employee type :" + dr[3]);

            }


        }
        static void Main(string[] args)
        {
            StoredProcCall();
            Console.ReadLine();
        }
    }
}
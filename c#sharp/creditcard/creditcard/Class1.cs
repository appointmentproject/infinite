using System;
using System.Data;
using System.Data.SqlClient;


namespace Day1_ADO_Basic
{
    class ConnectedArch
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        //function that establishes connection with the database server and returns
        // an object of SqlConnection type
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source='ICS-LAP-7459';initial catalog=sql;" +
                "Integrated Security=True");
            con.Open();
            return con;
        }
        public static void SelectEmployees()
        {
            con = getConnection();
            try
            {
                //cmd = new SqlCommand("select * from employee", con); 
                //or as below
                cmd = new SqlCommand("select * from employee");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3] + " " + dr[4] + " " + dr[5]);
                    //Console.WriteLine("Employee Id :" + dr[0]);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Error in the Server...");
            }
        }

        public static void InsertEmployee()
        {
            con = getConnection();
            //giving static hard coded values as below will result in errors on successive execution
            // cmd = new SqlCommand("insert into employee values(300,'ADO',16000,'Others',5,'999999')",con);

            Console.WriteLine("Please enter Empid,Name,salary,Gender,Deptid,Phone");
            int eid = Convert.ToInt32(Console.ReadLine());
            string ename = Console.ReadLine();
            float esal = float.Parse(Console.ReadLine());
            string egender = Console.ReadLine();
            int edid = Convert.ToInt32(Console.ReadLine());
            string ephone = Console.ReadLine();
            cmd = new SqlCommand("insert into employee values(@empid,@empname,@empsal,@empgen,@empdid,@empph)", con);
            //command object has property known as parameters - a collection object
            //to the parameters collection, we have to add the parameters for insert
            cmd.Parameters.AddWithValue("@empid", eid);
            cmd.Parameters.AddWithValue("@empname", ename);
            cmd.Parameters.AddWithValue("@empsal", esal);
            cmd.Parameters.AddWithValue("@empgen", egender);
            cmd.Parameters.AddWithValue("@empdid", edid);
            cmd.Parameters.AddWithValue("@empph", ephone);

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
            SelectEmployees();
            Console.Read();
        }
    }
}
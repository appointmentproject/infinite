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
            con = new SqlConnection("data source=ICS-LAP-7459;initial catalog=sql;" +
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
            finally
            {
                con.Close();
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
        //execute scalar eg
        public static void ScalarEg()
        {
            con = getConnection();
            // cmd = new SqlCommand("select deptid from Employee where empid=4");
            cmd = new SqlCommand("Select count(empid) from employee");
            cmd.Connection = con;
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("There are {0}, no.of employees", count);
        }

        public static void DeleteEmployee()
        {
            con = getConnection();
            Console.WriteLine("Enter the employee code to delete:");
            int ecode = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from Employee where Empid=@eid", con);
            cmd1.Parameters.AddWithValue("@eid", ecode);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you Sure to delete this Employee? Y/N :");
            string status = Console.ReadLine();
            if (status == "y" || status == "Y")
            {
                cmd = new SqlCommand("delete from Employee where empid=@eid", con);
                cmd.Parameters.AddWithValue("@eid", ecode);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Record Deleted Successfully...");
                }
                else
                    Console.WriteLine("Contact DBA..");
            }
            else
            {
                Console.WriteLine("You Opted not to delete the Employee");
            }
        }

        public static void updateEmployee()
        {
            con = getConnection();
            Console.WriteLine("Enter the employee code to update:");
            int ecode = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from Employee where Empid=@eid", con);
            cmd1.Parameters.AddWithValue("@eid", ecode);
        }
        static void Main(string[] args)
        {
            //ScalarEg();
            //DeleteEmployee();
            //InsertEmployee();
            updateEmployee();
            // SelectEmployees();
            Console.Read();
        }
    }
}
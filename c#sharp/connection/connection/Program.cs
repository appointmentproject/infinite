using System;
using System.Data;
using System.Data.SqlClient;


namespace Day1_ADO_Basic
{
    class Connected
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
        public static void SelectEmployees()
        {
            con = getConnection();
            try
            {
                //cmd = new SqlCommand("select * from employee", con); 
                //or as below
                cmd = new SqlCommand("select * from Employee");
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
            //cmd = new SqlCommand("insert into employee values(300,'ADO',16000,'Others',5,'999999')",con);

            Console.WriteLine("Please enter Empid,Name,salary,Gender,Deptid,Phone");
            int Empid = Convert.ToInt32(Console.ReadLine());
            string Empname = Console.ReadLine();
            float Salary = float.Parse(Console.ReadLine());
            string Gender = Console.ReadLine();
            int DeptId = Convert.ToInt32(Console.ReadLine());
            string Phone = Console.ReadLine();
            cmd = new SqlCommand("insert into Employee values(@empid,@empname,@empsal,@empgen,@empdid,@empph)", con);
            //command object has property known as parameters - a collection object
            //to the parameters collection, we have to add the parameters for insert
            cmd.Parameters.AddWithValue("@empid", Empid);
            cmd.Parameters.AddWithValue("@empname", Empname);
            cmd.Parameters.AddWithValue("@empsal", Salary);
            cmd.Parameters.AddWithValue("@empgen", Gender);
            cmd.Parameters.AddWithValue("@empdid", DeptId);
            cmd.Parameters.AddWithValue("@empph", Phone);
            Console.ReadLine();
            int records = cmd.ExecuteNonQuery();
            if (records > 0)
            {
                Console.WriteLine("Inserted successfully..");
            }
            else
                Console.WriteLine("Something went wrong..");
        }
        public static void DeleteEmployee()
        {
            con = getConnection();
            Console.WriteLine("Enter the employee code to delete:");
            int ecode = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from Employee where empid=@Empid", con);
            cmd1.Parameters.AddWithValue("@Empid", ecode);
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
                cmd = new SqlCommand("delete from Employee where empid=@Empid", con);
                cmd.Parameters.AddWithValue("@Empid", ecode);
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
            SqlCommand cmd1 = new SqlCommand("Select * from Employee where Empid=@Empid", con);
            cmd1.Parameters.AddWithValue("@Empid", ecode);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            cmd = new SqlCommand("update Employee where Empid=@Empid ", con);
            cmd.Parameters.AddWithValue("@Salary", ecode);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Console.WriteLine("Record updated Successfully...");
            }
            else
                Console.WriteLine("Contact DBA..");
           }

        public static void StoredProcCall()
        {
            con = getConnection();
            cmd = new SqlCommand("fewEmployee", con); //name of the procedure
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Employee Id: " + dr[0]);
                Console.WriteLine("Name :" + dr[1]);
                Console.WriteLine("Salary :" + dr[2]);
                Console.WriteLine("Gender :" + dr[3]);
                Console.WriteLine("Dept id :" + dr[4]);
                Console.WriteLine("Phone :" + dr[5]);
            }
        }
        public static void StoredProc_withParameter()
        {
            con = getConnection();
            Console.WriteLine("Enter Employee Id :");
            int eid = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("getemployeebyid @empid", con);
            // cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", eid);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Employee Id: " + dr[0]);
                Console.WriteLine("Name :" + dr[1]);
                Console.WriteLine("Salary :" + dr[2]);
                Console.WriteLine("Gender :" + dr[3]);
                Console.WriteLine("Dept id :" + dr[4]);
                Console.WriteLine("Phone :" + dr[5]);
            }

        }


        public static void functions()
        {
            con = getConnection();
            Console.WriteLine("Enter Employee Id :");
            int did = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("inlinetablefunc1 @did", con);
           //cmd.CommandType = CommandType.Functions;
            cmd.Parameters.AddWithValue("@did", did);

            SqlDataReader dr = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();
            while (dr.Read())
            {
                Console.WriteLine("Employee Id: " + dr[0]);
                Console.WriteLine("Name :" + dr[1]);
                Console.WriteLine("Salary :" + dr[2]);
                Console.WriteLine("Dept id :" + dr[3]);
                
            }
        }

        public static void Stored_Proc_With_Output()
        {
            con = getConnection();
            Console.WriteLine("enter id :");
            int Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name :");
            string Empname = Console.ReadLine();
            Console.WriteLine("enter Salary :");
            int Salary =Convert.ToInt32(Console.ReadLine());
  
            cmd = new SqlCommand();
            cmd.CommandText = "getEmployeeSalary";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            //one way of adding parameters to the procedure
            SqlParameter param1 = new SqlParameter
            {
                ParameterName = "@Empname",
                SqlDbType = SqlDbType.NVarChar,
                Value = Empname,
                Direction = ParameterDirection.Input
            };
            cmd.Parameters.Add(param1);

            //other way to add parameter to the procedure
            // cmd.Parameters.AddWithValue("@smail", smail);
            SqlParameter param2 = new SqlParameter
            {
                ParameterName = "@Empid",
                SqlDbType = SqlDbType.Int,
                Value = Empid,
                Direction = ParameterDirection.Input,
            };
            cmd.Parameters.Add(param2);
            //now add output parameter to the procedure
            SqlParameter paramout = new SqlParameter
            {
                ParameterName = "@Salary",
                SqlDbType = SqlDbType.Float,
                Value=Salary,
                Direction = ParameterDirection.Output,
            };
            cmd.Parameters.Add(paramout);
            cmd.ExecuteNonQuery();
           
        }

        static void Main(string[] args)
            {
            //ScalarEg();
            //DeleteEmployee();
            //InsertEmployee();
            //  SelectEmployees();
             StoredProcCall();
            //StoredProc_withParameter();
            // Stored_Proc_With_Output();
            // updateEmployee();
            //functions();
            Console.Read();
        }
    }
}
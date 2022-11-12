using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DisconnectedArch
{
    class DataRelationships
    {
        static void Main()
        {
            //Creating an in-memory cache to store data
            DataSet dsEmployement = new DataSet("Employement");

            //first datatable of the Dataset 
            DataTable dtEmployees = new DataTable("Employees");

            //Columns for the DataTable
            DataColumn[] dcEmployees = new DataColumn[4];
            dcEmployees[0] = new DataColumn("EmpId", System.Type.GetType("System.Int32"));
            dcEmployees[1] = new DataColumn("EmpName", System.Type.GetType("System.String"));
            dcEmployees[2] = new DataColumn("Department", System.Type.GetType("System.String"));
            dcEmployees[3] = new DataColumn("EmplStatusId", System.Type.GetType("System.Int32"));

            //Add the above columns to the DataTable
            dtEmployees.Columns.Add(dcEmployees[0]);
            dtEmployees.Columns.Add(dcEmployees[1]);
            dtEmployees.Columns.Add(dcEmployees[2]);
            dtEmployees.Columns.Add(dcEmployees[3]);

            //Rows for the DataTable
            DataRow drEmplRecord = dtEmployees.NewRow();
            drEmplRecord["EmpId"] = "1";
            drEmplRecord["EmpName"] = "Nikitha";
            drEmplRecord["Department"] = "IT";
            drEmplRecord["EmplStatusID"] = "1";

            //add the above Row to the Data Table
            dtEmployees.Rows.Add(drEmplRecord);

            drEmplRecord = dtEmployees.NewRow();
            drEmplRecord["EmpId"] = "2";
            drEmplRecord["EmpName"] = "Mahesh";
            drEmplRecord["Department"] = "Finance";
            drEmplRecord["EmplStatusID"] = "3";

            //add the above Row to the Data Table
            dtEmployees.Rows.Add(drEmplRecord);

            drEmplRecord = dtEmployees.NewRow();
            drEmplRecord["EmpId"] = "3";
            drEmplRecord["EmpName"] = "Ravi";
            drEmplRecord["Department"] = "Accounting";
            drEmplRecord["EmplStatusID"] = "1";

            //add the above Row to the Data Table
            dtEmployees.Rows.Add(drEmplRecord);

            drEmplRecord = dtEmployees.NewRow();
            drEmplRecord["EmpId"] = "4";
            drEmplRecord["EmpName"] = "Krithika";
            drEmplRecord["Department"] = "Accounting";
            drEmplRecord["EmplStatusID"] = "2";

            //add the above Row to the Data Table
            dtEmployees.Rows.Add(drEmplRecord);


            drEmplRecord = dtEmployees.NewRow();
            drEmplRecord["EmpId"] = "5";
            drEmplRecord["EmpName"] = "Suraj";
            drEmplRecord["Department"] = "Operations";
            drEmplRecord["EmplStatusID"] = "4";

            //add the above Row to the Data Table
            dtEmployees.Rows.Add(drEmplRecord);

            drEmplRecord = dtEmployees.NewRow();
            drEmplRecord["EmpId"] = "6";
            drEmplRecord["EmpName"] = "Simi";
            drEmplRecord["Department"] = "Operations";
            drEmplRecord["EmplStatusID"] = "2";

            //add the above Row to the Data Table
            dtEmployees.Rows.Add(drEmplRecord);

            //creating another DataTable in the same Dataset
            DataTable dtEmplStatus = new DataTable("EmployeeStatus");

            DataColumn[] dcStatus = new DataColumn[2];
            dcStatus[0] = new DataColumn("EmplStatusID", System.Type.GetType("System.Int32"));
            dtEmplStatus.Columns.Add(dcStatus[0]);
            dcStatus[1] = new DataColumn("EmplStatus", System.Type.GetType("System.String"));
            dtEmplStatus.Columns.Add(dcStatus[1]);

            //Datarows for the second Datatable

            DataRow drStatus = dtEmplStatus.NewRow();
            drStatus["EmplStatusID"] = "1";
            drStatus["EmplStatus"] = "Full Time";

            dtEmplStatus.Rows.Add(drStatus);

            drStatus = dtEmplStatus.NewRow();
            drStatus["EmplStatusID"] = "2";
            drStatus["EmplStatus"] = "Part Time";

            dtEmplStatus.Rows.Add(drStatus);

            drStatus = dtEmplStatus.NewRow();
            drStatus["EmplStatusID"] = "3";
            drStatus["EmplStatus"] = "Contract";

            dtEmplStatus.Rows.Add(drStatus);

            drStatus = dtEmplStatus.NewRow();
            drStatus["EmplStatusID"] = "4";
            drStatus["EmplStatus"] = "Intern";

            dtEmplStatus.Rows.Add(drStatus);

            //add both the tables to the Dataset
            dsEmployement.Tables.Add(dtEmployees);
            dsEmployement.Tables.Add(dtEmplStatus);

            //Setting Primary and Foreign keys between the columns of the Datatables
            DataColumn colParent =
                dsEmployement.Tables["EmployeeStatus"].Columns["EmplStatusID"];

            DataColumn colChild =
                dsEmployement.Tables["Employees"].Columns["EmplStatusID"];

            //Setting Relationships between the 2 datatables

            DataRelation EmplRel =
                new DataRelation("EmployeeStatusRelation", colParent, colChild);

            //add the reltionship to the dataset
            dsEmployement.Relations.Add(EmplRel);
            Console.WriteLine("==========+=============");
            Console.WriteLine("Staus ID     |  Employement Status");
            Console.WriteLine("----------------------");

            foreach (DataRow row in dsEmployement.Tables["EmployeeStatus"].Rows)
                Console.WriteLine(" {0}  |  {1}", row["EmplStatusID"], row["EmplStatus"]);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Empl ID\t |Emp Name\t  | Department\t  | Empl Status");
            Console.WriteLine("-----------------------------------");
            foreach (DataRow row in dsEmployement.Tables["Employees"].Rows)
            {
                int irow = int.Parse(row["EmplStatusID"].ToString());

                DataRow currRecord = dsEmployement.Tables["EmployeeStatus"].Rows[irow - 1];
                Console.WriteLine("{0}\t  | {1}\t   |{2}\t\t |{3}", row["EmpId"], row["EmpName"],
                    row["Department"], currRecord["EmplStatus"]);
            }
            Console.WriteLine("===========================================");
            Console.Read();
        }
    }
}

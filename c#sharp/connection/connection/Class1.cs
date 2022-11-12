using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DisconnectedArch
{
    class XmlOperations
    {
        static void Main()
        {
            //  XMLWriter();
            // XMLReader();
            //  XMLSchemaWriter();
            XMLSchemaReader();
            Console.Read();
        }

        //writing data to an xml file from dataset
        static void XMLWriter()
        {
            try
            {
                //create a dataset, namespace and a student table with name and address
                DataSet ds = new DataSet("DSStudent");
                ds.Namespace = "studentnamespace";
                DataTable stdtable = new DataTable("Student");

                //add columns to the student table
                DataColumn col1 = new DataColumn("Name");
                DataColumn col2 = new DataColumn("Address");

                //adding the columns to the datatable
                stdtable.Columns.Add(col1);
                stdtable.Columns.Add(col2);

                //adding the datatable to the dataset
                ds.Tables.Add(stdtable);

                //add 1st student details to the datatable
                DataRow stdrow = stdtable.NewRow();
                stdrow["Name"] = "Harini";
                stdrow["Address"] = "Hyderabad";

                //add the newly created row to the datatable
                stdtable.Rows.Add(stdrow);

                //add 2nd std details
                stdrow = stdtable.NewRow();
                stdrow["Name"] = "Ramakrishna";
                stdrow["Address"] = "Bangalore";

                //add the newly created row to the datatable
                stdtable.Rows.Add(stdrow);

                //add 3rd std details
                stdrow = stdtable.NewRow();
                stdrow["Name"] = "Namitha";
                stdrow["Address"] = "Kolkatta";

                //add the newly created row to the datatable
                stdtable.Rows.Add(stdrow);

                //add 4th std details
                stdrow = stdtable.NewRow();
                stdrow["Name"] = "Banurekha";
                stdrow["Address"] = "Cochin";

                //add the newly created row to the datatable
                stdtable.Rows.Add(stdrow);
                //accept all the changes 
                ds.AcceptChanges();

                //create a stream writer and save the data in the xml file
                StreamWriter writer = new StreamWriter("student.xml");
                ds.WriteXml(writer);

                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception :{0}", e.ToString());
            }
            return;
        }

        //reading from xml file into datasets
        static void XMLReader()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("student.xml");

            foreach (DataTable tbl in ds.Tables)
            {
                Console.WriteLine(tbl);
                for (int i = 0; i < tbl.Columns.Count; i++)
                    Console.Write("\t\t" + tbl.Columns[i].ColumnName); //to print the column names as heading
                Console.WriteLine();
                foreach (var row in tbl.AsEnumerable())
                {
                    for (int i = 0; i < tbl.Columns.Count; i++)
                    {
                        Console.Write("\t\t" + row[i]);
                    }
                    Console.WriteLine();
                }
            }
        }

        static void XMLSchemaWriter()
        {
            try
            {
                //create a dataset, namespace and a student table with name and address
                DataSet ds = new DataSet("DSStudent");
                ds.Namespace = "studentnamespace";
                DataTable stdtable = new DataTable("Student");

                //add columns to the student table
                DataColumn col1 = new DataColumn("Name");
                DataColumn col2 = new DataColumn("Address");

                //adding the columns to the datatable
                stdtable.Columns.Add(col1);
                stdtable.Columns.Add(col2);

                //adding the datatable to the dataset
                ds.Tables.Add(stdtable);

                //add 1st student details to the datatable
                DataRow stdrow = stdtable.NewRow();
                stdrow["Name"] = "Harini";
                stdrow["Address"] = "Hyderabad";

                //add the newly created row to the datatable
                stdtable.Rows.Add(stdrow);

                //add 2nd std details
                stdrow = stdtable.NewRow();
                stdrow["Name"] = "Ramakrishna";
                stdrow["Address"] = "Bangalore";

                //add the newly created row to the datatable
                stdtable.Rows.Add(stdrow);

                //add 3rd std details
                stdrow = stdtable.NewRow();
                stdrow["Name"] = "Namitha";
                stdrow["Address"] = "Kolkatta";

                //add the newly created row to the datatable
                stdtable.Rows.Add(stdrow);

                //add 4th std details
                stdrow = stdtable.NewRow();
                stdrow["Name"] = "Banurekha";
                stdrow["Address"] = "Cochin";

                //add the newly created row to the datatable
                stdtable.Rows.Add(stdrow);
                //accept all the changes 
                ds.AcceptChanges();

                //create a stream writer and save the data in the xml file
                XmlTextWriter writer = new XmlTextWriter("studentschema.xsd", Encoding.UTF8);
                ds.WriteXmlSchema(writer);

                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception :{0}", e.ToString());
            }
            return;
        }

        static void XMLSchemaReader()
        {
            DataSet ds = new DataSet("New Dataset");
            XmlTextReader reader = new XmlTextReader("student.xml");
            ds.ReadXmlSchema(reader);
            reader.Close();
            XmlTextWriter tw = new XmlTextWriter(Console.Out);
            ds.WriteXmlSchema(tw);
            //  Console.ReadLine()
        }
    }
}
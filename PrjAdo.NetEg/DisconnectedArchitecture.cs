using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace PrjAdo.NetEg
{


    class DAL {

        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection GetSqlConnection() {

            con = new SqlConnection(
                    "Data Source = DESKTOP-RC7B0LD\\; Initial Catalog = Northwind; Integrated Security = true");

            con.Open();
            return con;

        }

        public void DisplayRegion() {

            try
            {

                con = GetSqlConnection();

                SqlDataAdapter da;
                da = new SqlDataAdapter("select * from Region", con);
                DataSet ds = new DataSet();//Collection of Tables
                                           //putting the table inside dataset
                da.Fill(ds, "NWREGION");
                //reading the table info from Dataset
                DataTable dt;
                dt = ds.Tables["NWREGION"];
                foreach (DataRow row in dt.Rows)
                {

                    foreach (DataColumn col in dt.Columns)
                    {

                        Console.WriteLine(row[col]);
                        Console.Write("   ");

                    }
                    Console.WriteLine("  ");

                }

                //addind one more table to dataset :shipper
                /*  Console.WriteLine("-------------");
                  Console.WriteLine("-------Shipper table----------");
                  da = new SqlDataAdapter("select * from Shippers", con);
                  da.Fill(ds, "NWSHIPPER");

                  DataTable dt1 = ds.Tables["NWSHIPPER"];
                  foreach (DataRow row in dt1.Rows) {
                      foreach (DataColumn col in dt1.Columns) {

                          Console.WriteLine(row[col]);
                          Console.Write(" ");

                      }
                      Console.WriteLine(" ");

                  }
                */
                // Inserting new Row in region table in dataset
                //insert , update delete operation

                SqlCommandBuilder scb = new SqlCommandBuilder(da);
                da.Fill(ds);
                //Inserting or Adding  a new Row
                //Creating a new Row in NWREGION in dataset
                DataRow row1 = ds.Tables["NWREGION"].NewRow();
                row1["RegionID"] = 14;
                row1["RegionDescription"] = "AAAAAAAAA";
                // Adding Row to datatable in dataset
                ds.Tables["NWREGION"].Rows.Add(row1);
                da.Update(ds, "NWREGION");
                Console.WriteLine("-------------");
                dt = ds.Tables["NWREGION"];
                foreach (DataRow dataRow in dt.Rows)
                {

                    foreach (DataColumn dataColumn in dt.Columns)
                    {

                        Console.Write(dataRow[dataColumn]);
                        Console.Write("  ");


                    }

                    Console.WriteLine("  ");




                }


            }
            catch (Exception e) {

                Console.WriteLine(e);
            
            }
            finally{

                Console.WriteLine();
            }
        }    

    
    
    }





    class DisconnectedArchitecture
    {
        static void Main() {

            DAL d = new DAL();
            d.DisplayRegion();
        
        }
    }
}

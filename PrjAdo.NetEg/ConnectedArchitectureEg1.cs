﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace PrjAdo.NetEg
{
    class Shipper { 
        
        public int ShipperId { get; set; }
        public string Companyname { get; set; }

        public string Phone { get; set; }

        #region  GetShipper


        public void GetShipper() {

            Console.WriteLine("Enter the ShipperName or CompanyName");
            Companyname = Console.ReadLine();
            Console.WriteLine("Enter The Phone Number");
            Phone = Console.ReadLine();

        
        }
        #endregion

        public void LooseShipper() {

            Console.WriteLine("Enter the Shippername or CompanyName");
            Companyname = Console.ReadLine();
        }

        public void EditShipper() {

            Console.WriteLine("Enter the Shipper Id");
            ShipperId = Convert.ToInt32(Console.ReadLine());
            
            GetShipper();
        
        }

    }
    class ConnectedArchitectureEg1
    {
        static void Main()
        {
            //2. create sqlConection object
            SqlConnection con = null;
            // creating command object
            SqlCommand cmd = null;

            try
            {

                //3.Windows Authentication
                con = new SqlConnection(
                 "Data Source = DESKTOP-RC7B0LD\\; Initial Catalog = Northwind; Integrated Security = true");

                con.Open();
                // Creating object of shipper Class

                Shipper shipper = new Shipper();
                // Calling getshipper method
                //insertion
                shipper.GetShipper();
                cmd = new SqlCommand("insert into Shippers(CompanyName,Phone) values(@cname,@phone)", con);
                cmd.Parameters.AddWithValue("@cname", shipper.Companyname);
                cmd.Parameters.AddWithValue("@phone", shipper.Phone);
                int i = cmd.ExecuteNonQuery();// returns int
                Console.WriteLine("No of Rows Affected:{0}", i);

                // Deletion

                // Calling Loose Shipper Method
                /* shipper.LooseShipper();
                 cmd = new SqlCommand("delete from Shippers where CompanyName=@cname", con);
                 cmd.Parameters.AddWithValue("@cname", shipper.Companyname);
                 int i = cmd.ExecuteNonQuery(); // return int
                 Console.WriteLine("No of Rows deleted :{0}", i);
                 cmd.Parameters.Clear();
                */

                // Select
               /*  SqlDataReader dr;
                 cmd = new SqlCommand("select * from Shippers", con);
                 dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
                    Console.WriteLine(dr["CompanyName"] + " " + dr["Phone"]);

                }*/
                    //Update
                  /*  #region ShipperUpdate
                    shipper.EditShipper();
                    cmd = new SqlCommand("update Shippers set CompanyName=@cname Phone =@phone where ShipperID=@id ", con);
                    cmd.Parameters.AddWithValue("@id", shipper.ShipperId);
                    cmd.Parameters.AddWithValue("@cname", shipper.Companyname);
                    cmd.Parameters.AddWithValue("@phone", shipper.Phone);

                    int a = cmd.ExecuteNonQuery();
                    Console.WriteLine("No of rows updated is {0}", a);
                    #endregion
                    //Scalar VAlue
                    /*  cmd = new SqlCommand("select count (ShipperId) from Shippers", con);
                      Console.WriteLine("Total shipper:{0}", Convert.ToInt32(cmd.ExecuteScalar())); */
                  
                

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            finally {

                con.Close();
            
            }

        }
    }
}

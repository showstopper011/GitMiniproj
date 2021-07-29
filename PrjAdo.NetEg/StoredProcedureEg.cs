using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PrjAdo.NetEg
{

    class DataAccessLayer {

        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection GetConnection() {

            con = new SqlConnection(
                "Data Source = DESKTOP-RC7B0LD\\; Initial Catalog = Northwind; Integrated Security = true");

            con.Open();
            return con;
        
        }

        internal void CallTenMostExpensiveProduct()
        {
            try
            {

                con = GetConnection();
                //procedure name in sqlserver
                cmd = new SqlCommand("Ten Most Expensive Products", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Console.WriteLine(dr[0] + " " + dr[1]);

                }
            }

            catch (Exception e)
            {

                Console.WriteLine(e);



            }

        }

        internal void CallCustOrdersOrders(string cid)
        {
            try
            {

                con=GetConnection();
                cmd = new SqlCommand("CustOrdersOrders", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", cid);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Console.WriteLine(dr["OrderID"] + "  " + dr["OrderDate"] + " " + dr["ShippedDate"]);
                }

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
    class StoredProcedureEg
    {

        static void Main() {

           /* DataAccessLayer spobject = new DataAccessLayer();
            spobject.CallTenMostExpensiveProduct();

            Console.WriteLine("Enter the CustomerId");
            string cid = Console.ReadLine();
            spobject.CallCustOrdersOrders(cid);

            */
       
            }


    }
}

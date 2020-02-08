using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProductDetails
{
    class Program
    {
        static SqlConnection sqlCon;
        static SqlCommand sqlCmd;
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataSet ds;

         static string conString, qryString;


        static void Main(string[] args)
        {


            conString = "data source=BLT10131\\SQLEXPRESS2014;Initial Catalog=NorthWind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            qryString = "Select ProductName from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            da = new SqlDataAdapter();
            while (dr.Read())
            {
                //cmbCountries.Items.Add(dr["ProductName"]);
                Console.WriteLine("ProductName:{0}", dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
            LINQToDataSets();
        }
        public static void LINQToDataSets()
        {
            qryString = "Select CustomerID,CompanyName,ContactName,Address,Country from Customers";
            using (sqlCon = new SqlConnection(conString))
            {
                sqlCmd = new SqlCommand(qryString, sqlCon);
                da = new SqlDataAdapter(sqlCmd);
                ds = new DataSet();
                da.Fill(ds, "CustomersInfo");
                DataTable dtCustomers = ds.Tables["CustomersInfo"];
                var specificCustomers = from customer in dtCustomers.AsEnumerable()
                                        where customer.Field<string>("Country") == "UK"
                                        select new
                                        {
                                            custID = customer["CustomerID"],
                                            CompanyName = customer["CompanyName"],
                                            ContactName = customer["ContactName"],
                                            address = customer["Address"],
                                            country = customer["Country"]

                                        };
                foreach (var customer in specificCustomers)
                {
                    Console.WriteLine("\n\nCustomerID:{0}", customer.custID);
                    Console.WriteLine("Name:{0}", customer.ContactName);
                    Console.WriteLine("CompanyName:{0}", customer.CompanyName);
                    Console.WriteLine("Address:{0}", customer.address);
                    Console.WriteLine("Country:{0}", customer.country);
                }




            }
        }

    }
}


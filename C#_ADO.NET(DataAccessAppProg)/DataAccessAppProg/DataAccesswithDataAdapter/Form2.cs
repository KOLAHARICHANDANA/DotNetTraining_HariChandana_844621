using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DataAccesswithDataAdapter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter da;            
        SqlDataReader dr;
        DataSet ds;
        string conString, qryString;

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {


          
            qryString = "Select * from Customers where Country = '" + cmbCountries.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);

            ds = new DataSet();


            da = new SqlDataAdapter(sqlCmd);
            //ds.Clear();
            da.Fill(ds, "CustomerInfo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CustomerInfo";


            //sqlCon.Open();

            //cmbCountries.Text = "Countries:" + sqlCmd.ExecuteScalar().ToString();
            //sqlCon.Close();


        }

        private void btnCustomersAndOrders_Click(object sender, EventArgs e)
        {
            qryString = "Select c.CustomerID,c.companyName,c.contactName,c.Address,c.Country,o.OrderID,o.OrderID,o.OrderDate,o.ShippedDate from Customers c JOIN Orders o ON o.CustomerID=c.CustomerID";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            da.Fill(ds, "CustomersOrdersInfo");
            
                dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CustomersOrdersInfo";
        }

        private void btnProdCategories_Click(object sender, EventArgs e)
        {
            
            qryString = "select p.ProductID,p.ProductName, p.UnitPrice,p.QuantityPerUnit,c.CategoryID,c.CategoryName from Products p JOIN Categories c ON p.ProductID=c.CategoryID";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
         
            da.Fill(ds, "ProductsCategoriesInfo");

            dataGridView1.DataSource = ds;

            dataGridView1.DataMember = "ProductsCategoriesInfo";

           
        }

        private void btnTotalOrders_Click(object sender, EventArgs e)
        {
         qryString= "Select COUNT(OrderID) from Orders";
            //sqlCon.Open();
            //sqlCmd = new SqlCommand(qryString, sqlCon);
            //MessageBox.Show("Total Orders Placed:" +sqlCmd.ExecuteScalar().ToString(), "Total Orders");
            //sqlCon.Close();


            
            using (sqlCon = new SqlConnection(conString))//alternative way of writing the code with 'using' statement
            {
                sqlCon.Open();
                sqlCmd = new SqlCommand(qryString, sqlCon);
                MessageBox.Show("Total Orders Placed:" + sqlCmd.ExecuteScalar().ToString(), "Total Orders");

            }
    }

        private void btnLINQDS_Click(object sender, EventArgs e)
        {
            qryString = "Select ProductID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products";
            using (sqlCon = new SqlConnection(conString))
            {
                sqlCmd = new SqlCommand(qryString, sqlCon);
                sqlCon.Open();
                da = new SqlDataAdapter(sqlCmd);
                ds.Clear();
                da.Fill(ds, "ProductsInfo");
                DataTable dt = ds.Tables["ProductsInfo"];
                var products = from product in dt.AsEnumerable()
                               where product.Field<decimal>("UnitPrice") >= 50
                               select new
                               {
                                   ProdID = product["ProductID"],
                                   ProdName = product["ProductName"],
                                   Price = product["UnitPrice"],

                                   Quantity = product["QuantityPerUnit"]
                               };
                foreach(var product in products)
                {
                    MessageBox.Show("ProductID= " + product.ProdID +  "Name=" + product.ProdName + "Price= " + product.Price+ "Quantity="+product.Quantity,"Products with Price<50.00");
                }

                sqlCon.Close();                
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10131\\SQLEXPRESS2014;Initial Catalog=NorthWind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            qryString = "Select country from Customers";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while(dr.Read())
            {
                cmbCountries.Items.Add(dr["Country"]);

            }
            dr.Close();
            sqlCon.Close();
            ds = new DataSet();


        }
    }
}

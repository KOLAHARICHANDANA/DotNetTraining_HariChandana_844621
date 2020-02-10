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


namespace DataAccessAppProg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        string conString, qryString;


        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10131\\SQLEXPRESS2014;Initial Catalog=NorthWind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            qryString = "Select distinct Country from Customers";

            sqlCmd= new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCustomers.Items.Add(dr["Country"]);
            }
            //cmbCustomers.Text = "All Customers";

            dr.Close();
            sqlCon.Close();
           
        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlCon.Open();
            qryString = "Select ContactName from Customers Where Country = '" + cmbCustomers.Text + " ' ";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            //sqlCon.Open();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["ContactName"]);
            }
            dr.Close();
           
            sqlCon.Close();
        }
    }
}

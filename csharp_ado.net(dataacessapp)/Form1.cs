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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        string conString, qryString;

        private void lsbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10131\\SQLEXPRESS2014;Initial Catalog=NorthWind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            qryString = "Select ProductName from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                cmbProducts.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
            cmbProducts.Text = "All Products";          



        }




        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select unitPrice from Products Where ProductName = '" + cmbProducts.Text + " ' ";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            lblPrice.Text = "Unit Price:" + sqlCmd.ExecuteScalar().ToString();
            sqlCon.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            qryString = "select ProductName from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while(dr.Read())
            {
                lsbProducts.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
        }
    }
}

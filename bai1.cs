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

namespace NGUYENLEKHATU_BAITAPVENHA02
{

    public partial class Form1 : Form
    {

        // tạo 2 biến cục bộ
        string strCon = @"Data Source=KAYTLYNNGUYEN;Initial Catalog=BAITAPVENHA2;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {

            
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                try
                {
                    sqlConnection.Open();
                    string query = "SELECT TENSP FROM SANPHAM";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listBox1.Items.Add(reader["TENSP"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát? ","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            { 
                this.Close();
            }
        }
    }
}

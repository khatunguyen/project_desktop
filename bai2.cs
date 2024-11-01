using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGUYENLEKHATU_BAITAPVENHA02
{
    public partial class Bai2 : Form
    {
        // tạo 2 biến cục bộ
        string strCon = @"Data Source=KAYTLYNNGUYEN;Initial Catalog=BAITAPVENHA2;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection sqlConnection = new SqlConnection() ;
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
    {
                using (SqlConnection sqlConnection = new SqlConnection(strCon))
                {
                    sqlConnection.Open();

                    string query = "SELECT TENSP FROM SANPHAM";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    SqlDataReader reader = command.ExecuteReader();

                    comboBox1.Items.Clear(); // Xóa các mục hiện có trong ComboBox

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["TENSP"].ToString());
                    }
                }
            }
    catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}


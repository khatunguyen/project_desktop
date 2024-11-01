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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NGUYENLEKHATU_BAITAPVENHA02
{
    public partial class Bai3 : Form
    {
        // tạo 2 biến cục bộ
        string strCon = @"Data Source=KAYTLYNNGUYEN;Initial Catalog=BAITAPVENHA2;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection sqlConnection = new SqlConnection();
        public Bai3()
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

                    string query = "SELECT * FROM SANPHAM"; // lấy hết dữ liệu trong bảng sản phẩm
                    SqlCommand command = new SqlCommand(query, sqlConnection); //truy vấn
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(command); // chuyển dữ liệu về
                    DataTable dt = new DataTable(); //tạo 1 kho ảo để lưu trữ dữ liệu
                    adapter.Fill(dt);
                    sqlConnection.Close();
                    dataGridView1.DataSource = dt; // đổ dữ liệu vào Data Source
                 }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

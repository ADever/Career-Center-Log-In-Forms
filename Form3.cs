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



namespace WindowsFormsAttempt4
{
   
    public partial class Form3 : Form
    {

        public static string keyName = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {

            keyName = name.Text;

            SqlConnection con = new SqlConnection("Data Source=localhost; initial Catalog = usrinfo; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("select count(*) from usrinfo where name = '"+name.Text+"' and socialNum = '"+socialNum.Text+"'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Form u = new Form5();
                u.Show();
                this.Hide();
            } else if (dt.Rows[0][0].ToString() == "0")
            {
                MessageBox.Show("Invalid information");
            }

        }

        private void socialNum_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

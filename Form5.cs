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
    public partial class Form5 : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlConnection connection2;
        private SqlCommand command2;
        private DateTime myDate = DateTime.Now.Date;
        //DBAccess objDbAccess = new DBAccess();

        public Form5()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(" Data Source=localhost; initial Catalog = usrinfo; Integrated Security = true; pooling = false");
            connection2 = new SqlConnection(" Data Source=localhost; initial Catalog = usrinfo; Integrated Security = true; pooling = false");
            connection.Open();
            connection2.Open();
            command = new SqlCommand("UPDATE usrinfo SET testInt = @a1 WHERE name = @name", connection);
            command2 = new SqlCommand("UPDATE usrinfo SET date = @a2 WHERE name = @name", connection2);
            command.Parameters.AddWithValue("a1", testTry.Text);
            command.Parameters.AddWithValue("name", Form3.keyName);
            command2.Parameters.AddWithValue("a2", myDate);
            command2.Parameters.AddWithValue("name", Form3.keyName);
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();



            /*
             int row = objDbAccess.executeQuery(updateCommand);
             if (row == 1)
             {
                 MessageBox.Show("Info updated well");
             } else
             {
                 MessageBox.Show("error, try again");
             }
             */
        }
    }
}
    

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
namespace Buangjug_FinalProject
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }
        public Form2() { } 
        private void addButton_Click(object sender, EventArgs e)
        {
            if (idTextbox.Text != "")
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Mark\\OneDrive\\Documents\\johoys Documents\\CSharp\\Finals\\Buangjug_FinalProject\\Buangjug_FinalProject\\Database1.mdf;Integrated Security=True;Connect Timeout=30");
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into [Table] values ('"+int.Parse(idTextbox.Text)+ "','"+lnTextbox.Text+ "','"+fnTextbox.Text+ "','"+emailTextbox.Text+ "','"+courseTextbox.Text+ "','"+float.Parse(gpaTextbox.Text)+"')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                DialogResult dialogResult = MessageBox.Show("Added New Student Successfully.", MessageBoxButtons.OK.ToString());
                if (dialogResult == DialogResult.OK) { this.Close(); }
                sqlConnection.Close();
                form1.dataGridViewAdd();
            }
            else
            {
                MessageBox.Show("Student ID Field is Empty!");
            }
        }
        private void addButton_MouseEnter(object sender, EventArgs e)
        {
            addButton.BackColor = Color.DarkSalmon;
        }
        private void addButton_MouseHover(object sender, EventArgs e)
        {
            addButton.BackColor = Color.LightGreen;
        }
        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            addButton.BackColor = Color.DarkSalmon;
        }
    }
}

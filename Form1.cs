using ImageResizer.Plugins.Basic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buangjug_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelShadow.BackColor = Color.FromArgb(20, Color.Black);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] buttons = new Button[] { addBtn, displayBtn, updateBtn, deleteBtn };
            foreach (Button btn in buttons) {
                btn.MouseEnter += new System.EventHandler(addBtn_MouseEnter);
                btn.MouseHover += new System.EventHandler(addBtn_MouseHover);
                btn.MouseLeave += new System.EventHandler(addBtn_MouseLeave);
            }
            dataGridViewAdd();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Mark\\OneDrive\\Documents\\johoys Documents\\CSharp\\Finals\\Buangjug_FinalProject\\Buangjug_FinalProject\\Database1.mdf;Integrated Security=True;Connect Timeout=30");
        public void dataGridViewAdd() { //to add data in data grid view
            SqlCommand sqlCommand = new SqlCommand("select * from [Table]",sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }
        private void addBtn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DarkSalmon;
        }
        private void addBtn_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.Black;
        }
        private void addBtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DarkSalmon;
            btn.ForeColor = Color.White;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2(this);
            newForm2.Show();
        }
        private void displayBtn_Click(object sender, EventArgs e)
        {
            Form3 displayForm3 = new Form3(this);
            displayForm3.Show();
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            Form4 updateForm4 = new Form4(this);
            updateForm4.Show();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Form5 deleteForm5 = new Form5(this);
            deleteForm5.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
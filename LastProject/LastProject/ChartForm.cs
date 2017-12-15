using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace LastProject
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\MSE\\Semister-1\\All Assignment\\Agile\\MidTerm\\compl.accdb");
        private void ChartForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'complDataSet.Form' table. You can move, or remove it, as needed.
            this.formTableAdapter.Fill(this.complDataSet.Form);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text; 
            cmd.CommandText = "insert into Form values('" + textBox1.Text + "','"+ comboBox1.Text +"','"+textBox2.Text +"','" + textBox3.Text +"')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("data has been saved");
        }
    }
}

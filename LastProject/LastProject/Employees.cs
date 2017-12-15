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
    public partial class Employees : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\MSE\\Semister-1\\All Assignment\\Agile\\MidTerm\\compl.accdb");
        public Employees()
        {
            InitializeComponent();
        }

        private void Btn2_Click(object sender, EventArgs e)

        {
            Panel2.Hide();
            Panel3.Show();
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            Panel1.Hide();
            Panel2.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Panel3.Hide();
            Panel4.Show();
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
            //----exaptional handling for avoiding database error ceonnection---------
        {
            
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Form values('" + Txtco.Text + "','" + Txtdep.Text + "','" + Txtemp.Text + "','" + Txtgra.Text + "','" + Txtsta.Text + "','" + Txtempty.Text + "','" + Txtdest.Text + "','" + Txtem.Text + "','" + picker1.Value + "','" + Txtgov.Text + "','" + Cmbo1.Text + "','" + pick2.Value + "','" + Txtadd.Text + "','" + Txtph.Text + "','" + Txtcity.Text + "','" + Txtstaste.Text + "','" + Txt11.Text + "','" + Txt22.Text + "','" + Tx33.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("data has been saved");
            {
                Home ho = new Home();

            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees em = new Employees();
            em.Hide();
            Home ho = new Home();
            ho.Show();
        }
    }
}

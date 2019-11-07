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

namespace ConectarSQL
{
    public partial class Form1 : Form
    {
        DataSet dts;
        string query = "Select * from planets";
       private string nomtaula;

        public Form1()
        {
            InitializeComponent();
        }

        /*    private SqlConnection conn;
            private string cnx;*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Class1 bd = new Conexion.Class1();
            dts = bd.PortarTaula("Planets");
            dataGridView1.DataSource = dts.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                   txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                   txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                   txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                   txt4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                   txt5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                   txt6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                   txt7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                   txt8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                   txt9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                   txt10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                   txt11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                   txt12.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                label2.Text = dataGridView1.Columns[0].HeaderText;
                label3.Text = dataGridView1.Columns[1].HeaderText;
                label4.Text = dataGridView1.Columns[2].HeaderText;
                label5.Text = dataGridView1.Columns[3].HeaderText;
                label6.Text = dataGridView1.Columns[4].HeaderText;
                label7.Text = dataGridView1.Columns[5].HeaderText;
                label8.Text = dataGridView1.Columns[6].HeaderText;
                label9.Text = dataGridView1.Columns[7].HeaderText;
                label10.Text = dataGridView1.Columns[8].HeaderText;
                label11.Text = dataGridView1.Columns[9].HeaderText;
                label12.Text = dataGridView1.Columns[10].HeaderText;
                label13.Text = dataGridView1.Columns[11].HeaderText;

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
            }
            catch { }

        }

        private void Tancar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar(object sender, EventArgs e)
        {          
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                label1.Width = this.Width;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                label1.Width = this.Width;
            }
        }

        private void Actualitzar(object sender, EventArgs e)
        {
            Conexion.Class1 bd = new Conexion.Class1();
            bd.Actualitzar(query, dts);
        }

        private void PortarTaula(object sender, EventArgs e)
        {
            Entrar();
        }

        private void Entrar()
        {
            Conexion.Class1 bd = new Conexion.Class1();
            dts = bd.PortarTaula(textBox1.Text);
            try {
                dataGridView1.DataSource = dts.Tables[0];
            }
            catch { }
        }
    
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Entrar();
            }
        }

        
    }
}


/* SqlConnection conn;
                string cnx;
                cnx = ("Server=s2x4.database.windows.net;Database=s2x4;User Id=s2x4;Password = 123456aA; ");
                conn = new SqlConnection(cnx);
                SqlDataAdapter adapter;
                String query;
                query = "select * from users";
                adapter = new SqlDataAdapter(query, conn);
                conn.Open();

                DataSet dts = new DataSet();
                adapter.Fill(dts);
                conn.Close();
            dataGridView1.DataSource = dts.Tables[0];
            */
//conn.Open();
//    adapter = new SqlDataAdapter(query, conn);
//    SqlCommandBuilder cmdBuilder;
//    cmdBuilder = new SqlCommandBuilder(adapter);
//     if (dts.Tables[0].HasChanges())
//         {
//              result = adapter.Update(dts.Tables[0]);
//          }


//conn.Close();
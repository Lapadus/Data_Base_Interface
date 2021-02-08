using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Data.SqlClient;


namespace Oracle_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();
                MessageBox.Show("Conexiunea cu baza de date este on");
                //cnn.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este tabelul FUNCTIILOR \n";

                sql = "Select * from functii";

                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

               while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + " " + dataReader.GetValue(2) + " " + dataReader.GetValue(3) + "\n";

                }
           
           MessageBox.Show(Output);
                

                OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM functii", cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;
     //cnn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este tabelul PROIECTELOR \n";

                sql = "Select * from proiecte";

                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + " " + dataReader.GetValue(2) + " " + dataReader.GetValue(3) + "\n";

                }
                MessageBox.Show(Output);
                //cnn.Close();

                OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM proiecte", cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este tabelul ANGAJATILOR \n";

                sql = "Select * from angajati";

                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + " " + dataReader.GetValue(2) + " " + dataReader.GetValue(3) + dataReader.GetValue(4) + " " + dataReader.GetValue(5) + " " + dataReader.GetValue(6) + " " + dataReader.GetValue(7) + " " + dataReader.GetValue(8)  + "\n";

                }
                MessageBox.Show(Output);
                //cnn.Close();

                OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM angajati", cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este tabelul ELEVILOR \n";

                sql = "Select * from elevi";

                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + " " + dataReader.GetValue(2) + " " + dataReader.GetValue(3) + " " + dataReader.GetValue(4) + " " + dataReader.GetValue(5) + "\n";

                }
                MessageBox.Show(Output);
                //cnn.Close();

                OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM elevi", cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este tabelul LISTA_PARTICIPANTI \n";

                sql = "Select * from lista_participanti";

                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + "\n";

                }
                MessageBox.Show(Output);
                //cnn.Close();

                OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM lista_participanti", cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este tabelul DISCIPLINELOR \n";

                sql = "Select * from discipline";

                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + " " + dataReader.GetValue(2) + "\n";

                }
                MessageBox.Show(Output);
                //cnn.Close();

                OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM discipline", cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este tabelul ORAR_ELEVI \n";

                sql = "Select * from orar_elevi";

                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + "\n";

                }
                MessageBox.Show(Output);
                //cnn.Close();

                OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM orar_elevi", cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;       
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este tabelul SALI_INVATARE \n";

                sql = "Select * from sali_invatare";

                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + " " + dataReader.GetValue(2) + " " + dataReader.GetValue(3) + "\n";

                }
                MessageBox.Show(Output);
                //cnn.Close();

                OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM sali_invatare", cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();


                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este tabelul ORAR_SALI \n";

                sql = "Select * from orar_sali";

                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + "\n";

                }
                MessageBox.Show(Output);

                OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM orar_sali", cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;
                //cnn.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este tabelul ECHIPAMENTELOR \n";

                sql = "Select * from echipamente";

                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + " " + dataReader.GetValue(2) + " " + dataReader.GetValue(3) + "\n";

                }
                MessageBox.Show(Output);
                //cnn.Close();

                OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM echipamente", cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;          
            }
        }
      
        private void button12_Click(object sender, EventArgs e)
        {
           
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este tabelul LISTA_ORGANIZARE \n";

                sql = "Select * from lista_organizare";

                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + "\n";

                }
                MessageBox.Show(Output);
                //cnn.Close();

                OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM lista_organizare", cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //int rowIndex = dgv1.CurrentCell.RowIndex;
           // dgv1.Rows.RemoveAt(rowIndex);
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_stergere.Text;
            
            
                string query = "delete from functii where cod_functie= " + cod;
                OracleConnection cnn = new OracleConnection(connectionString);
                OracleCommand cmd = new OracleCommand(query, cnn);
                OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM functii", cnn);           
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;
        
            try
                {
                    cnn.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Informatia aferenta codului " + cod + " a fost stearsa");
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Alegeti un cod din tabelul Functii pentru a sterge");
                }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
           "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
           + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_angajat.Text;         

            string query = "delete from angajati where cod_angajat= " + cod;
                OracleConnection cnn = new OracleConnection(connectionString);
                OracleCommand cmd = new OracleCommand(query, cnn);
                OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM angajati", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
                {
                    cnn.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Informatia aferenta codului " + cod + " a fost stearsa");
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Alegeti un cod din tabelul Angajati pentru a sterge");
                }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
          "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
          + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_elev.Text;


            string query = "delete from elevi where cod_elev= " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM elevi", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Informatia aferenta codului " + cod + " a fost stearsa");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti un cod din tabelul Angajati pentru a sterge");
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
          "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
          + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_disciplina.Text;


            string query = "delete from discipline where cod_disciplina= " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM discipline", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Informatia aferenta codului " + cod + " a fost stearsa");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti un cod din tabelul Discipline pentru a sterge");
            }
        }
     
        private void button17_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
          "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
          + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_proiect.Text;


            string query = "delete from proiecte where cod_proiect= " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM proiecte", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Informatia aferenta codului " + cod + " a fost stearsa");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti un cod din tabelul Proiecte pentru a sterge");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
        "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
        + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_inv.Text;


            string query = "delete from sali_invatare where cod_sala= " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM sali_invatare", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                 MessageBox.Show("Informatia aferenta codului " + cod + " a fost stearsa");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti un cod din tabelul Sali_Invatare pentru a sterge");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
        "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
        + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_echipament.Text;


            string query = "delete from echipamente where cod_echipament= " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM echipamente", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Informatia aferenta codului " + cod + " a fost stearsa");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti un cod din tabelul Echipamente pentru a sterge");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
        "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
        + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_lista_participanti.Text;
            string cod2 = cod2_lista_participanti.Text;

            string query = "delete from lista_participanti where cod_elev= " + cod ;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM lista_participanti", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Informatia aferenta codului " + cod + " a fost stearsa");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti un cod din tabelul Lista_Participanti pentru a sterge");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
       "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
       + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_orar_sali.Text;
            string cod2 = cod2_orar_sali.Text;

            string query = "delete from orar_sali where cod_sala= " + cod + " and cod_disciplina=  " + cod2;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM orar_sali", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Informatia aferenta codului " + cod + " si codului " + cod2 +" a fost stearsa");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti un cod din tabelul Orar_Sali pentru a sterge");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
            + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_lista_organizare.Text;
            string cod2 = cod2_lista_organizare.Text;

            string query = "delete from lista_organizare where cod_echipament= " + cod + " and cod_sala=  " + cod2;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM lista_organizare", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Informatia aferenta codului " + cod + " si codului " + cod2 + " a fost stearsa");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti un cod din tabelul Lista_Organizare pentru a sterge");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
       "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
       + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_orar_elev.Text;
            string cod2 = cod2_orar_elev.Text;

            string query = "delete from orar_elevi where cod_elev= " + cod + " and cod_disciplina=  " + cod2;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM orar_elevi", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Informatia aferenta codului " + cod + " si codului " + cod2 + " a fost stearsa");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti un cod din tabelul Orar_Elevi pentru a sterge");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
         "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
         + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_functie.Text;
            string cod2 = nume_functie.Text;
            string cod3 = salariu_minim.Text;
            string cod4 = salariu_maxim.Text;

            string query = "update functii set nume_functie= " + cod2 + ", salariu_min= " + cod3 + ", salariu_max= " + cod4 + "where cod_functie = " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM functii", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Proiectul cu codul " + cod + " a fost updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
         "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
         + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_proiect_update.Text;
            string cod2 = nume_proiect.Text;
            string cod3 = data_inceput.Text;
            string cod4 = data_sfarsit.Text;

            string query = "update proiecte set nume_proiect= " + cod2 + ",data_inceput= " + cod3 + ", data_sfarsit= " + cod4 + "where cod_proiect = " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM proiecte", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Proiectul cu codul " + cod + " a fost updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
       "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
       + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_angajat_update.Text;
            string cod2 = nume_angajat.Text;
            string cod3 = prenume_angajat.Text;
            string cod4 = email_angajat.Text;
            string cod5 = telefon_angajat.Text;
            string cod6 = data_angajare.Text;
            string cod7 = salariu_angajat.Text;
            string cod8 = proiect.Text;
            string cod9 = functie.Text;

            string query = "update angajati set nume= " + cod2 + ",prenume= " + cod3 + ", email= " + cod4 + ", telefon= " + cod5 + ", data_angajare= " + cod6 + ", salariu= " + cod7 + ", cod_proiect= " + cod8 + ", cod_functie= " + cod9 + "where cod_angajat = " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM angajati", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Angajatul cu codul " + cod + " a fost updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti codul angajatului pe care doriti sa il modificati din tabelul Angajati");
                MessageBox.Show(ex.Message);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
    "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
    + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_elev_update.Text;
            string cod2 = nume_elev.Text;
            string cod3 = prenume_elev.Text;
            string cod4 = email_elev.Text;
            string cod5 = clasa_elev.Text;
            string cod6 = specializare_elev.Text;        

            string query = "update elevi set nume= " + cod2 + ",prenume= " + cod3 + ", email= " + cod4 + ", clasa= " + cod5 + ", specializare= " + cod6 + "where cod_elev = " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM elevi", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Elevul cu codul " + cod + " a fost updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti codul elevului pe care doriti sa il modificati din tabelul Elevi");
                MessageBox.Show(ex.Message);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
    "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
    + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_lista_participanti_elev.Text;
            string cod2 = cod_lista_participanti_proiect.Text;

            string query = "update lista_participanti set cod_proiect= " + cod2 + "where cod_elev = " + cod ;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM lista_participanti", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Elevul cu codul " + cod + " a fost updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti codul elevului pe care doriti sa il modificati din tabelul Elevi");
                MessageBox.Show(ex.Message);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
    "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
    + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_disciplina_update.Text;
            string cod2 = nume_disciplina.Text;
            string cod3 = nr_ore.Text;
            
            string query = "update discipline set nume= " + cod2 + ",nr_ore= " + cod3 +  "where cod_disciplina = " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM discipline", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Disciplina cu codul " + cod + " a fost updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti codul disciplineii pe care doriti sa il modificati din tabelul Discipline");
                MessageBox.Show(ex.Message);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
    "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
    + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_orar_elevi_elev.Text;
            string cod2 = cod_orar_elevi_disciplina.Text;
         

            string query = "update orar_elevi set cod_disciplina= " + cod2 +  "where cod_elev = " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM orar_elevi", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Elevul cu codul " + cod + " a fost updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti codul elevului pe care doriti sa il modificati din tabelul Elevi");
                MessageBox.Show(ex.Message);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
    "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
    + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_orar_sali_sala.Text;
            string cod2 = cod_orar_sali_disciplina.Text;


            string query = "update orar_sali set cod_disciplina= " + cod2 + "where cod_sala = " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM orar_sali", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Sala cu codul " + cod + " a fost updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti codul salii pe care doriti sa 0 modificati din tabelul Orar_Sali");
                MessageBox.Show(ex.Message);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
    "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
    + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_echipament_update.Text;
            string cod2 = nume_echipament.Text;
            string cod3 = nr_disponibile.Text;
            string cod4 = producator.Text;
      
            string query = "update echipamente set nume= " + cod2 + ", nr_disponibile= " + cod3 + ", producator= " + cod4 + "where cod_echipament = " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM echipamente", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Echipamentul cu codul " + cod + " a fost updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti codul echipamentului pe care doriti sa il modificati din tabelul Echipamentei");
                MessageBox.Show(ex.Message);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
    "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
    + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_sala_update.Text;
            string cod2 = nume_sala_invatare.Text;
            string cod3 = etaj_sala_invatare.Text;
            string cod4 = nr_locuri_sala_invatare.Text;

            string query = "update sali_invatare set nume= " + cod2 + ", etaj= " + cod3 + ", nr_locuri= " + cod4 + "where cod_sala = " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM sali_invatare", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Sala cu codul " + cod + " a fost updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti codul salii pe care doriti sa o modificati din tabelul Sali_Invatare");
                MessageBox.Show(ex.Message);
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
    "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
    + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_lista_organizare_echipament.Text;
            string cod2 = cod_lista_organizare_sala.Text;
            
            string query = "update lista_organizare set cod_sala= " + cod2 + "where cod_echipament = " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM lista_organizare", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Echipamentul cu codul " + cod + " a fost updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti codul echipamentului pe care doriti sa o modificati din tabelul Lista_Organizare");
                MessageBox.Show(ex.Message);
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este rezultatul cererii \n";

                sql = "select  nume_proiect, count(cod_elev) " +
                    "from lista_participanti " +
                    "join proiecte using (cod_proiect) " +
                    "group by nume_proiect " +
                    "having nume_proiect like '%t%' ";
                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

               OracleDataAdapter cn = new OracleDataAdapter(sql, cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;

            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este rezultatul cererii \n";

                sql = "select  ev.nume as Nume_Elev, dis.nume as Nume_Disciplina, sal.nume as Nume_Sala " + 
                        "from elevi ev " +
                        "join orar_elevi using (cod_elev) " +
                        "join discipline dis using (cod_disciplina) " +
                        "join orar_sali using (cod_disciplina) " +
                        "join sali_invatare sal using (cod_sala) " +
                        "where sal.etaj = 0 " +
                        "and ev.clasa like '%D' " +
                        "and lower(ev.specializare) = 'stiinte ale naturii' " + 
                        "and dis.nr_ore > 10";
                
                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                OracleDataAdapter cn = new OracleDataAdapter(sql, cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;

            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql, Output = "\n Acesta este rezultatul cererii \n";

                sql = "select * from vizualizare_complexa ";
                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                OracleDataAdapter cn = new OracleDataAdapter(sql, cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;

            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            using (OracleConnection cnn = new OracleConnection(connectionString))
            {
                cnn.Open();

                OracleCommand command;
                OracleDataReader dataReader;
                String sql;

                sql = "select * from vizualizare_compusa ";
                command = new OracleCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                OracleDataAdapter cn = new OracleDataAdapter(sql, cnn);
                DataTable dtbl = new DataTable();
                cn.Fill(dtbl);
                dgv1.DataSource = dtbl;

            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
          "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
          + "(SERVICE_NAME = XE)));" + "User Id=c##raluca;Password=raluca;";
            string cod = cod_viz_compusa.Text;


            string query = "delete from vizualizare_compusa where cod_elev= " + cod;
            OracleConnection cnn = new OracleConnection(connectionString);
            OracleCommand cmd = new OracleCommand(query, cnn);
            OracleDataReader myReader;

            OracleDataAdapter cn = new OracleDataAdapter("SELECT * FROM vizualizare_compusa", cnn);
            DataTable dtbl = new DataTable();
            cn.Fill(dtbl);
            dgv1.DataSource = dtbl;

            try
            {
                cnn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Informatia aferenta codului " + cod + " a fost stearsa");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alegeti un cod din tabelul vizualizare_compusa pentru a sterge");
            }
        }     
    }
    
}

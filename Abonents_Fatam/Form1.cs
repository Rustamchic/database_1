using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace Abonents_Fatam
{
    public partial class Form1 : Form
    {
        private string connstring = String.Format("Server={0};Port={1};"
            + "User id={2};Password={3};Database={4}", "localhost", 5432, "postgres",
            "Rustic03", "fatam");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        public int AbonentID = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAbonents();
        }
        private void GetAbonents()
        {
            conn = new NpgsqlConnection(connstring);
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from abonents", conn);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            GridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO abonents VALUES (default, @surname, @name, @otch, @passport, @address, @phone_number, @device, @license, @testing_line)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@otch", txtOtch.Text);
                cmd.Parameters.AddWithValue("@passport", txtPassport.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone_number", txtPhone.Text);
                cmd.Parameters.AddWithValue("@device", txtDevice.Text);
                cmd.Parameters.AddWithValue("@license", txtLicense.Text);
                cmd.Parameters.AddWithValue("@testing_line", txtTest.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                ResetFormControls();
                MessageBox.Show("New MAI's abonent has been successfully saved into database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAbonents();
          
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(AbonentID > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM abonents WHERE AbonentID = @ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.AbonentID);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("MAI's abonent has been successfully deleted from database", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAbonents();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please! Select a MAI's abonent to delete information", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(AbonentID > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE abonents SET surname = @surname,name = @name,otch =  @otch, passport = @passport,address = @address,phone_number= @phone_number,device = @device,license= @license,testing_line = @testing_line WHERE AbonentID = @ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@otch", txtOtch.Text);
                cmd.Parameters.AddWithValue("@passport", txtPassport.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone_number", txtPhone.Text);
                cmd.Parameters.AddWithValue("@device", txtDevice.Text);
                cmd.Parameters.AddWithValue("@license", txtLicense.Text);
                cmd.Parameters.AddWithValue("@testing_line", txtTest.Text);
                cmd.Parameters.AddWithValue("@ID", this.AbonentID);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
               
                MessageBox.Show("MAI's abonent has been successfully updated into database", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAbonents();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please! Select a MAI's abonent to update information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            AbonentID = 0;
            txtSurname.Clear();
            txtName.Clear();
            txtOtch.Clear();
            txtPassport.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtDevice.Clear();
            txtLicense.Clear();
            txtTest.Clear();
            txtSurname.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsValid()
        {
            if(txtSurname.Text == String.Empty)
            {
                MessageBox.Show("Abonent's surname is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void txtPassport_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AbonentID = Convert.ToInt32(GridView.SelectedRows[0].Cells[0].Value);
            txtSurname.Text = GridView.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = GridView.SelectedRows[0].Cells[2].Value.ToString();
            txtOtch.Text = GridView.SelectedRows[0].Cells[3].Value.ToString();
            txtPassport.Text = GridView.SelectedRows[0].Cells[4].Value.ToString();
            txtAddress.Text = GridView.SelectedRows[0].Cells[5].Value.ToString();
            txtPhone.Text = GridView.SelectedRows[0].Cells[6].Value.ToString();
            txtDevice.Text = GridView.SelectedRows[0].Cells[7].Value.ToString();
            txtLicense.Text = GridView.SelectedRows[0].Cells[8].Value.ToString();
            txtTest.Text = GridView.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM abonents WHERE surname = @surname", conn);
            cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            GridView.DataSource = dt;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM abonents WHERE name = @name", conn);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            GridView.DataSource = dt;
        }

        private void find_otch_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM abonents WHERE otch = @otch ", conn);
            cmd.Parameters.AddWithValue("@otch", txtOtch.Text);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            GridView.DataSource = dt;
        }

        private void find_passport_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM abonents WHERE passport = @passport ", conn);
            cmd.Parameters.AddWithValue("@passport", txtPassport.Text);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            GridView.DataSource = dt;
        }

        private void find_address_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM abonents WHERE address = @address ", conn);
            cmd.Parameters.AddWithValue("@passport", txtAddress.Text);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            GridView.DataSource = dt;
        }

        private void Show_all_Click(object sender, EventArgs e)
        {
            GetAbonents();
        }

        private void find_phone_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM abonents WHERE phone_number = @phone_number", conn);
            cmd.Parameters.AddWithValue("@phone_number", txtPhone.Text);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            GridView.DataSource = dt;
        }

        private void find_device_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM abonents WHERE device = @device", conn);
            cmd.Parameters.AddWithValue("@device", txtDevice.Text);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            GridView.DataSource = dt;
        }

        private void find_license_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM abonents WHERE license = @license", conn);
            cmd.Parameters.AddWithValue("@license", txtLicense.Text);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            GridView.DataSource = dt;
        }

        private void find_line_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM abonents WHERE testing_line = @testing_line", conn);
            cmd.Parameters.AddWithValue("@testing_line", txtTest.Text);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            GridView.DataSource = dt;
        }
    }
}
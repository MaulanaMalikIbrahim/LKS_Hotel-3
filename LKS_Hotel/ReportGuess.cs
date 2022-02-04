﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Hotel
{
    public partial class ReportGuess : Form
    {
        SqlConnection connection = new SqlConnection(Utils.conn);
        SqlCommand command;
        public ReportGuess()
        {
            InitializeComponent();
            lbladmin.Text = Session.name;
            lbltime.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy");
        }

        private void panelreser_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            this.Hide();
            reservation.ShowDialog();
        }

        private void panelci_Click(object sender, EventArgs e)
        {
            CheckIn ch = new CheckIn();
            this.Hide();
            ch.ShowDialog();
        }

        private void panelreq_Click(object sender, EventArgs e)
        {
            ReqItems req = new ReqItems();
            this.Hide();
            req.ShowDialog();
        }

        private void panelcheck_Click(object sender, EventArgs e)
        {
            CheckOut check = new CheckOut();
            this.Hide();
            check.ShowDialog();
        }

        private void panelchart_Click(object sender, EventArgs e)
        {
            ReportChart report = new ReportChart();
            this.Hide();
            report.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MainLogin master = new MainLogin();
                this.Hide();
                master.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ReportGuess report = new ReportGuess();
            this.Hide();
            report.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
                MessageBox.Show("Check In date time must be less than check out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string sql = "select * from rep where checkInDatetime >= '" + Convert.ToDateTime(dateTimePicker1.Value) + "' and checkoutDatetime <= '" + dateTimePicker2.Value + "'";
                dataGridView1.DataSource = Command.GetData(sql);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount > 0)
            {
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                dt.Columns.Add("")
            }
        }
    }
}

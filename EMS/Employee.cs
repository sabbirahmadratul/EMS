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

namespace EMS
{
  public partial class Employee : Form
  {
    public Employee()
    {
      InitializeComponent();
    }

    SqlConnection Con = new SqlConnection(@"Data Source=LENOVO-G5080\SQLEXPRESS;Integrated Security=True");

    private void addButton_Click(object sender, EventArgs e)
    {
      if(empIdTextBox.Text == "" || empNameTextBox.Text == "" || empAddressTextBox.Text == "" || empPhoneTextBox.Text == "")
      {
        MessageBox.Show("Missing Information.");
      }
      else
      {
        try
        {
          Con.Open();
          string query = "insert into EmployeeTable values('" + empIdTextBox.Text + "', '" + empNameTextBox.Text + "', '" + empAddressTextBox.Text + "', '" + empPosComboBox.SelectedItem.ToString() + "', '" + empDOBPicker.Value.Date + "', '" + empPhoneTextBox.Text + "', '" + empEduComboBox.SelectedItem.ToString() + "', '" + empGenComboBox.SelectedItem.ToString() + "');";

          SqlCommand cmd = new SqlCommand(query, Con);
          cmd.ExecuteNonQuery();
          MessageBox.Show("Employee added succesfully.");

          Con.Close();
          populate();
        }
        catch(Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
    }

    private void label2_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void populate()
    {
      Con.Open();
      string query = "select * from EmployeeTable";

      SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, Con);
      SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
      var ds = new DataSet();
      sqlDataAdapter.Fill(ds);
      empDGV.DataSource = ds.Tables[0];
      Con.Close();
    }

    private void Employee_Load(object sender, EventArgs e)
    {
      populate();
    }
  }
}

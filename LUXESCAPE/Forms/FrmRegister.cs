namespace LUXESCAPE.Forms;

using Microsoft.Data.SqlClient;
using System;


public partial class FrmRegister : Form
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\YOUSSEF\DOCUMENTS\DBEL3AMED.MDF");
    SqlCommand cm = new SqlCommand();
    public FrmRegister()
    {
        InitializeComponent();
    }
    private void pictureBoxClose_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        lblError.Text = "";

        if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtPhone.Text) ||
            string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            lblError.Text = "All fields are required.";
            return;

        }
        else
        {
            try
            {
                if (txtPassword.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Password did not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string role = "Customer";

                    // لو الإيميل ده يبقى Manager
                    if (txtEmail.Text.Trim().ToLower() == "admin@gmail.com")
                    {
                        role = "Manager";
                    }

                    cm = new SqlCommand(
                        "INSERT INTO Users(FullName, Email, PhoneNumber, PasswordHash, Role) " +
                        "VALUES(@FullName,@Email,@PhoneNumber,@PasswordHash,@Role)",
                        con);


                    cm.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cm.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                    cm.Parameters.AddWithValue("@PasswordHash", txtPassword.Text);
                    cm.Parameters.AddWithValue("@Role", role);
                    con.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully! Please log in.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBack_Click(sender, e);
                    con.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();

            }
        }

       

        // TODO: Hash the password, then INSERT into Users table.
        // string hash = HashPassword(txtPassword.Text);
        // DatabaseHelper.RegisterUser(txtFullName.Text, txtEmail.Text, txtPhone.Text, hash);

        
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        
        new FrmLogin().Show();
        this.Close();
    }

    private void lblPassword_Click(object sender, EventArgs e)
    {

    }

    private void txtFullName_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtPassword_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtPhone_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtEmail_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtConfirm_TextChanged(object sender, EventArgs e)
    {

    }

    private void pnlForm_Paint(object sender, PaintEventArgs e)
    {

    }

    private void lblConfirm_Click(object sender, EventArgs e)
    {

    }

    private void lblPhone_Click(object sender, EventArgs e)
    {

    }

    private void lblEmail_Click(object sender, EventArgs e)
    {

    }

    private void lblFullName_Click(object sender, EventArgs e)
    {

    }

    private void lblError_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtEmail_TextChanged_1(object sender, EventArgs e)
    {

    }
}

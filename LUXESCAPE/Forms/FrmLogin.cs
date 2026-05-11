using Microsoft.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace LUXESCAPE.Forms;


public partial class FrmLogin : Form
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\YOUSSEF\DOCUMENTS\DBEL3AMED.MDF");
    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;
    public FrmLogin()
    {
        InitializeComponent();
    }

    // ── Event Handlers ────────────────────────────────────────────

    private void btnLogin_Click(object sender, EventArgs e)
    {
        lblError.Text = "";

        string email = txtEmail.Text.Trim();
        string password = txtPassword.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            lblError.Text = "Please enter both email and password.";
            return;
        }
        else
        {
            try
            {
                cm = new SqlCommand(
                    "SELECT * FROM Users WHERE Email=@Email AND PasswordHash=@PasswordHash",
                    con);

                cm.Parameters.AddWithValue("@Email", txtEmail.Text);

                cm.Parameters.AddWithValue("@PasswordHash", txtPassword.Text);

                con.Open();

                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    int userId = Convert.ToInt32(dr["UserID"]);

                    string role = dr["Role"].ToString();

                    MessageBox.Show(
                        "Welcome " + dr["FullName"].ToString(),
                        "ACCESS GRANTED",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    con.Close();

                    // Manager
                    if (role == "Manager")
                    {
                        new FrmManagerDashboard().Show();
                        this.Hide();
                    }

                    // Customer
                    else
                    {
                        new FrmCustomerDashboard(userId).Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Invalid username or password!",
                        "ACCESS DENIED",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }  
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        new FrmRegister().Show();
        this.Hide();
    }



    private void txtEmail_TextChanged(object sender, EventArgs e) { }

    private void FrmLogin_Load(object sender, EventArgs e)
    {

    }
}

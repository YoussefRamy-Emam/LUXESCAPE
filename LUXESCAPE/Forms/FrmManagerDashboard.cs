namespace LUXESCAPE.Forms;

using Microsoft.Data.SqlClient;
using System.Data;
public partial class FrmManagerDashboard : Form
{
    SqlConnection con = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename=C:\USERS\YOUSSEF\DOCUMENTS\DBEL3AMED.MDF;
      Integrated Security=True");

    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;

    public FrmManagerDashboard()
    {
        InitializeComponent();
    }

    private void FrmManagerDashboard_Load(object sender, EventArgs e)
    {
        LoadActivities();
    }

    // ── Navigation ────────────────────────────────────────────────

    private void ShowPanel(Panel target, string title)
    {
        pnlManageActs.Visible = false;
        pnlReports.Visible = false;
        target.Visible = true;
        lblPageTitle.Text = title;
    }

    private void btnManageActs_Click(object sender, EventArgs e) =>
        ShowPanel(pnlManageActs, "Manage Activities");

    private void btnReports_Click(object sender, EventArgs e)
    {
        ShowPanel(pnlReports, "Reports & Analytics");
        LoadReports();
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Logout?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
        {
            new FrmLogin().Show();
            this.Close();
        }
    }

    // ── Activity CRUD ─────────────────────────────────────────────

    private void LoadActivities()
    {

        lvActivities.Items.Clear();

        try
        {
            cm = new SqlCommand(
                "SELECT * FROM Activities ORDER BY DateTime",
                con);

            con.Open();

            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item =
                    new ListViewItem(dr["ActivityID"].ToString());

                item.SubItems.Add(
                    dr["Title"].ToString());

                item.SubItems.Add(
                    Convert.ToDateTime(dr["DateTime"])
                    .ToString("yyyy-MM-dd HH:mm"));

                item.SubItems.Add(
                    dr["Price"].ToString());

                item.SubItems.Add(
                    dr["SeatsAvailable"].ToString());

                string status =
                    Convert.ToBoolean(dr["IsActive"])
                    ? "Active"
                    : "Inactive";

                item.SubItems.Add(status);

                item.ForeColor =
                    status == "Active"
                    ? Color.White
                    : Color.Gray;

                lvActivities.Items.Add(item);
            }

            dr.Close();
            con.Close();
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


    private void lvActivities_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvActivities.SelectedItems.Count == 0) return;
        var sel = lvActivities.SelectedItems[0];
        txtFTitle.Text = sel.SubItems[1].Text;
        txtFDate.Text = sel.SubItems[2].Text;
        txtFPrice.Text = sel.SubItems[3].Text;
        txtFSeats.Text = sel.SubItems[4].Text;
        txtFDesc.Text = sel.SubItems[5].Text;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateForm()) return;

        try
        {
            cm = new SqlCommand(
                "INSERT INTO Activities " +
                "(Title, Description, DateTime, Price, SeatsAvailable, IsActive) " +
                "VALUES(@Title, @Description, @DateTime, @Price, @Seats, @IsActive)",
                con);

            cm.Parameters.AddWithValue("@Title", txtFTitle.Text);

            cm.Parameters.AddWithValue("@Description",
                txtFDesc.Text);

            cm.Parameters.AddWithValue("@DateTime",
                Convert.ToDateTime(txtFDate.Text));

            cm.Parameters.AddWithValue("@Price",
                decimal.Parse(txtFPrice.Text));

            cm.Parameters.AddWithValue("@Seats",
                int.Parse(txtFSeats.Text));

            cm.Parameters.AddWithValue("@IsActive", true);

            con.Open();

            cm.ExecuteNonQuery();

            con.Close();

            MessageBox.Show(
                "Activity added successfully.");

            ClearForm();

            LoadActivities();
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

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (lvActivities.SelectedItems.Count == 0)
        {
            MessageBox.Show("Select activity first.");
            return;
        }

        try
        {
            int id = int.Parse(
                lvActivities.SelectedItems[0].SubItems[0].Text);

            cm = new SqlCommand(
                "UPDATE Activities SET " +
                "Title=@Title, " +
                "Description=@Description, " +
                "DateTime=@DateTime, " +
                "Price=@Price, " +
                "SeatsAvailable=@Seats " +
                "WHERE ActivityID=@ID",
                con);

            cm.Parameters.AddWithValue("@Title", txtFTitle.Text);

            cm.Parameters.AddWithValue("@Description",
                txtFDesc.Text);

            cm.Parameters.AddWithValue("@DateTime",
                Convert.ToDateTime(txtFDate.Text));

            cm.Parameters.AddWithValue("@Price",
                decimal.Parse(txtFPrice.Text));

            cm.Parameters.AddWithValue("@Seats",
                int.Parse(txtFSeats.Text));

            cm.Parameters.AddWithValue("@ID", id);

            con.Open();

            cm.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Updated successfully.");

            LoadActivities();
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


    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (lvActivities.SelectedItems.Count == 0)
        {
            MessageBox.Show("Select activity first.");
            return;
        }

        if (MessageBox.Show(
            "Delete this activity?",
            "Confirm",
            MessageBoxButtons.YesNo)
            != DialogResult.Yes)
        {
            return;
        }

        try
        {
            int id = int.Parse(
                lvActivities.SelectedItems[0].SubItems[0].Text);

            cm = new SqlCommand(
                "DELETE FROM Activities WHERE ActivityID=@ID",
                con);

            cm.Parameters.AddWithValue("@ID", id);

            con.Open();

            cm.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Deleted successfully.");

            ClearForm();

            LoadActivities();
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

    private void btnClearForm_Click(object sender, EventArgs e) => ClearForm();

    private void ClearForm()
    {
        txtFTitle.Clear(); txtFDate.Clear();
        txtFPrice.Clear(); txtFSeats.Clear(); txtFDesc.Clear();
        lvActivities.SelectedItems.Clear();
    }

    private bool ValidateForm()
    {
        if (string.IsNullOrWhiteSpace(txtFTitle.Text) ||
            string.IsNullOrWhiteSpace(txtFDate.Text) ||
            string.IsNullOrWhiteSpace(txtFPrice.Text) ||
            string.IsNullOrWhiteSpace(txtFSeats.Text))
        {
            MessageBox.Show("Title, Date, Price and Seats are required.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    // ── Reports ───────────────────────────────────────────────────

    private void LoadReports()
    {
        // TODO: SELECT SUM(Amount) FROM Payments → lblRevValue
        // TODO: SELECT COUNT(*) FROM Bookings   → lblBookValue
        // TODO: SELECT u.FullName, a.Title, f.Rating, f.Comments
        //       FROM Feedback f JOIN Users u ON ... JOIN Activities a ON ...

        // Design-time values:
        lblRevValue.Text = "EGP 28,450";
        lblBookValue.Text = "37";

        lvFeedback.Items.Clear();
        var rows = new[]
        {
            new[] { "Sara Ali",       "Nile Dinner Cruise",  "5", "Absolutely magical experience!" },
            new[] { "Ahmed Hassan",   "Desert Safari Sinai", "4", "Great adventure, very well organized." },
            new[] { "Nour Mohamed",   "Nile Dinner Cruise",  "5", "Best evening in Cairo. Highly recommend!" },
        };
        foreach (var r in rows)
        {
            var item = new ListViewItem(r[0]);
            item.SubItems.Add(r[1]);
            item.SubItems.Add(r[2]);
            item.SubItems.Add(r[3]);
            item.ForeColor = Color.White;
            lvFeedback.Items.Add(item);
        }
    }

    private void btnRefresh_Click(object sender, EventArgs e) => LoadReports();

    private void lvFeedback_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

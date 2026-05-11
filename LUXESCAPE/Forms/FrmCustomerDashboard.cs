using Microsoft.Data.SqlClient;
using System.Data;

namespace LUXESCAPE.Forms;

public partial class FrmCustomerDashboard : Form
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\YOUSSEF\DOCUMENTS\DBEL3AMED.MDF");
    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;

    private int _userId;
    public FrmCustomerDashboard(int userId)
    {
        InitializeComponent();
        _userId = userId;
        LoadActivities();
    }

    // ── Navigation ────────────────────────────────────────────────

    private void ShowPanel(Panel target, string title)
    {
        pnlActivities.Visible = false;
        pnlMyBookings.Visible = false;
        pnlFeedbackForm.Visible = false;
        target.Visible = true;
        lblPageTitle.Text = title;
    }

    private void btnActivities_Click(object sender, EventArgs e) =>
        ShowPanel(pnlActivities, "Browse Activities");

    private void btnMyBookings_Click(object sender, EventArgs e)
    {
        ShowPanel(pnlMyBookings, "My Bookings");
        LoadMyBookings();
    }

    private void btnFeedback_Click(object sender, EventArgs e)
    {
        ShowPanel(pnlFeedbackForm, "Leave Feedback");
        PopulateFeedbackCombo();
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            new FrmLogin().Show();
            this.Close();
        }
    }

    // ── Activities ────────────────────────────────────────────────

    private void LoadActivities(string filter = "")
    {
        lvActivities.Items.Clear();

        cm = new SqlCommand("SELECT * FROM Activities", con);
        con.Open();
        dr = cm.ExecuteReader();
        lvActivities.Columns.Clear();

        lvActivities.Columns.Add("ID", 0);
        lvActivities.Columns.Add("Title", 150);
        lvActivities.Columns.Add("Description", 150);
        lvActivities.Columns.Add("Date", 150);
        lvActivities.Columns.Add("Price", 100);
        lvActivities.Columns.Add("Seats", 100);
        while (dr.Read())
        {
            ListViewItem item = new ListViewItem(dr["ActivityID"].ToString());
            item.SubItems.Add(dr["Title"].ToString());
            item.SubItems.Add(dr["Description"].ToString());
            item.SubItems.Add(dr["DateTime"].ToString());
            item.SubItems.Add(dr["Price"].ToString());
            item.SubItems.Add(dr["SeatsAvailable"].ToString());

            lvActivities.Items.Add(item);
        }
        dr.Close();
        con.Close();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        lvActivities.Items.Clear();

        try
        {
            cm = new SqlCommand(
                "SELECT * FROM Activities WHERE Title LIKE @search",
                con);

            cm.Parameters.AddWithValue(
                "@search",
                "%" + txtSearch.Text.Trim() + "%");

            con.Open();

            dr = cm.ExecuteReader();
            lvActivities.Columns.Clear();

            lvActivities.Columns.Add("ID", 0);
            lvActivities.Columns.Add("Title", 150);
            lvActivities.Columns.Add("Description", 150);
            lvActivities.Columns.Add("Date", 150);
            lvActivities.Columns.Add("Price", 100);
            lvActivities.Columns.Add("Seats", 100);
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["ActivityID"].ToString());
                item.SubItems.Add(dr["Title"].ToString());
                item.SubItems.Add(dr["Description"].ToString());
                item.SubItems.Add(dr["DateTime"].ToString());
                item.SubItems.Add(dr["Price"].ToString());
                item.SubItems.Add(dr["SeatsAvailable"].ToString());

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

    private void btnBook_Click(object sender, EventArgs e)
    {
        if (lvActivities.SelectedItems.Count == 0)
        {
            MessageBox.Show("Please select an activity to book.", "No Selection",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string activityName =
    lvActivities.SelectedItems[0].SubItems[1].Text;

        string activityPrice =
            lvActivities.SelectedItems[0].SubItems[4].Text;

        int activityId = int.Parse(
    lvActivities.SelectedItems[0].SubItems[0].Text);

        // Open payment form
        FrmPayment frmPayment =
            new FrmPayment(_userId, activityId, activityName, activityPrice);

        frmPayment.ShowDialog();

        LoadMyBookings();
    }

    // ── My Bookings ───────────────────────────────────────────────

    private void LoadMyBookings()
    {
        lvMyBookings.Items.Clear();

        try
        {
            cm = new SqlCommand(
                "SELECT b.BookingID, a.Title, a.DateTime, " +
                "b.Status, p.TransactionID " +
                "FROM Bookings b " +
                "JOIN Activities a ON b.ActivityID = a.ActivityID " +
                "JOIN Payments p ON b.BookingID = p.BookingID " +
                "WHERE b.UserID = @UserID",
                con);

            cm.Parameters.AddWithValue("@UserID", _userId);

            con.Open();

            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(
                    dr["BookingID"].ToString());

                item.SubItems.Add(
                    dr["Title"].ToString());

                item.SubItems.Add(
                    Convert.ToDateTime(dr["DateTime"])
                    .ToString("yyyy-MM-dd HH:mm"));

                item.SubItems.Add(
                    dr["Status"].ToString());

                item.SubItems.Add(
                    dr["TransactionID"].ToString());

                if (dr["Status"].ToString() == "Confirmed")
                {
                    item.ForeColor = Color.LightGreen;
                }
                else
                {
                    item.ForeColor = Color.Gold;
                }

                lvMyBookings.Items.Add(item);
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

    // ── Feedback ──────────────────────────────────────────────────

    private void PopulateFeedbackCombo()
    {
        cmbFbActivity.Items.Clear();

        try
        {
            cm = new SqlCommand(
                "SELECT DISTINCT a.ActivityID, a.Title " +
                "FROM Bookings b " +
                "JOIN Activities a ON b.ActivityID = a.ActivityID " +
                "WHERE b.UserID = @UserID AND b.Status = 'Confirmed'",
                con);

            cm.Parameters.AddWithValue("@UserID", _userId);

            con.Open();

            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                cmbFbActivity.Items.Add(
                    new ComboBoxItem(
                        dr["Title"].ToString(),
                        dr["ActivityID"].ToString()));
            }

            dr.Close();
            con.Close();

            if (cmbFbActivity.Items.Count > 0)
            {
                cmbFbActivity.SelectedIndex = 0;
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

    private void btnSubmitFb_Click(object sender, EventArgs e)
    {
        if (cmbFbActivity.SelectedItem == null || string.IsNullOrWhiteSpace(txtComments.Text))
        {
            MessageBox.Show("Please select an activity and write a comment.", "Incomplete",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            ComboBoxItem selectedActivity =
                (ComboBoxItem)cmbFbActivity.SelectedItem;

            int activityId =
                int.Parse(selectedActivity.Value);

            cm = new SqlCommand(
                "INSERT INTO Feedback(UserID, ActivityID, Rating, Comments) " +
                "VALUES(@UserID, @ActivityID, @Rating, @Comments)",
                con);

            cm.Parameters.AddWithValue("@UserID", _userId);

            cm.Parameters.AddWithValue("@ActivityID", activityId);

            cm.Parameters.AddWithValue("@Rating",
                (int)nudRating.Value);

            cm.Parameters.AddWithValue("@Comments",
                txtComments.Text);

            con.Open();

            cm.ExecuteNonQuery();

            con.Close();

            MessageBox.Show(
                "Thank you for your feedback!",
                "Feedback Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtComments.Clear();

            nudRating.Value = 5;
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


    public class ComboBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ComboBoxItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
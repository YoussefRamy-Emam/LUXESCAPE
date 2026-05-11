using Microsoft.Data.SqlClient;

namespace LUXESCAPE.Forms;


public partial class FrmPayment : Form
{
    private readonly string _activityName;
    private int _userId;
    private int _activityId;
    public FrmPayment(
    int userId,
    int activityId,
    string activityName,
    string activityPrice)
    {
        InitializeComponent();
        _activityName       = activityName;
        lblActivityVal.Text = activityName;
        lblPriceVal.Text = activityPrice;
        _userId = userId;
        _activityId = activityId;
    }

    private async void btnPay_Click(object sender, EventArgs e)
    {
        lblError.Text = "";

        if (string.IsNullOrWhiteSpace(txtCardName.Text)   ||
            string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
            string.IsNullOrWhiteSpace(txtExpiry.Text)     ||
            string.IsNullOrWhiteSpace(txtCVV.Text))
        {
            lblError.Text = "Please fill in all payment fields.";
            return;
        }

        // Show processing UI
        btnPay.Enabled        = false;
        progressBar.Visible   = true;
        lblProcessing.Visible = true;

        // TODO: Replace with real payment gateway call (e.g. Stripe, Paymob).
        // On success → write Booking + Payment rows to DB, generate TransactionID.
        // On failure → show error, re-enable btnPay.
        //
        // Simulated delay:
        await Task.Delay(250);

        string transactionId = $"TXN-{Guid.NewGuid().ToString("N")[..6].ToUpper()}";

        // TODO: INSERT Booking and Payment records here.

        try
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;
          AttachDbFilename=C:\USERS\YOUSSEF\DOCUMENTS\DBEL3AMED.MDF;
          Integrated Security=True");

            con.Open();

            // 1) Insert Booking
            SqlCommand cmBooking = new SqlCommand(
                "INSERT INTO Bookings(UserID, ActivityID, Status) " +
                "OUTPUT INSERTED.BookingID " +
                "VALUES(@UserID, @ActivityID, @Status)",
                con);

            cmBooking.Parameters.AddWithValue("@UserID", _userId);
            cmBooking.Parameters.AddWithValue("@ActivityID", _activityId);
            cmBooking.Parameters.AddWithValue("@Status", "Confirmed");

            int bookingId = (int)cmBooking.ExecuteScalar();

            // 2) Insert Payment
            SqlCommand cmPayment = new SqlCommand(
                "INSERT INTO Payments(BookingID, Amount, TransactionID, Status) " +
                "VALUES(@BookingID, @Amount, @TransactionID, @Status)",
                con);

            cmPayment.Parameters.AddWithValue("@BookingID", bookingId);

            // remove EGP if موجودة
            decimal amount = decimal.Parse(
                lblPriceVal.Text.Replace("EGP", "").Trim());

            cmPayment.Parameters.AddWithValue("@Amount", amount);

            cmPayment.Parameters.AddWithValue(
                "@TransactionID",
                transactionId);

            cmPayment.Parameters.AddWithValue(
                "@Status",
                "Success");

            cmPayment.ExecuteNonQuery();

            con.Close();
            progressBar.Visible = false;
            lblProcessing.Visible = false;

            MessageBox.Show(
                "Payment completed successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        catch (Exception ex)
        {
            btnPay.Enabled = true;

            progressBar.Visible = false;
            lblProcessing.Visible = false;

            MessageBox.Show(ex.Message);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}

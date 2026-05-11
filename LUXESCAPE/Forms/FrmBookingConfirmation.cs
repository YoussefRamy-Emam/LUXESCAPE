namespace LUXESCAPE.Forms;

/// <summary>
/// Booking Confirmation screen shown after successful payment.
/// Displays the unique Transaction ID and a summary.
/// </summary>
public partial class FrmBookingConfirmation : Form
{
    public FrmBookingConfirmation(string activityName, string transactionId)
    {
        InitializeComponent();
        lblActivity.Text = activityName;
        lblTxnValue.Text = transactionId;
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();
}

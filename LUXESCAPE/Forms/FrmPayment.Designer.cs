namespace LUXESCAPE.Forms;

partial class FrmPayment
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    int lx = 20, gap = 58;

    void AddRow(Label lbl, TextBox txt, string labelText, string placeholder, int top, bool small = false)
    {
        lbl.Text = labelText;
        lbl.Font = new Font("Segoe UI", 9F);
        lbl.ForeColor = Color.Silver;
        lbl.Location = new Point(lx, top);
        lbl.AutoSize = true;

        txt.Location = new Point(lx, top + 22);
        txt.Size = small ? new Size(150, 28) : new Size(400, 28);
        txt.BackColor = Color.FromArgb(40, 40, 65);
        txt.ForeColor = Color.White;
        txt.BorderStyle = BorderStyle.FixedSingle;
        txt.Font = new Font("Segoe UI", 10F);
        txt.PlaceholderText = placeholder;
    }

    private void InitializeComponent()
    {
        this.pnlHeader      = new Panel();
        this.lblTitle       = new Label();
        this.pnlBody        = new Panel();
        this.lblActivityLbl = new Label();
        this.lblActivityVal = new Label();
        this.lblPriceLbl    = new Label();
        this.lblPriceVal    = new Label();
        this.lblSep         = new Label();
        this.lblCardName    = new Label();
        this.txtCardName    = new TextBox();
        this.lblCardNumber  = new Label();
        this.txtCardNumber  = new TextBox();
        this.lblExpiry      = new Label();
        this.txtExpiry      = new TextBox();
        this.lblCVV         = new Label();
        this.txtCVV         = new TextBox();
        this.lblError       = new Label();
        this.btnPay         = new Button();
        this.btnCancel      = new Button();
        this.progressBar    = new ProgressBar();
        this.lblProcessing  = new Label();

        // Header
        this.pnlHeader.BackColor = Color.FromArgb(30, 30, 50);
        this.pnlHeader.Bounds    = new Rectangle(0, 0, 500, 70);
        this.pnlHeader.Controls.Add(this.lblTitle);

        this.lblTitle.Text      = "🔒  Secure Payment";
        this.lblTitle.Font      = new Font("Segoe UI", 16F, FontStyle.Bold);
        this.lblTitle.ForeColor = Color.FromArgb(212, 175, 55);
        this.lblTitle.AutoSize  = true;
        this.lblTitle.Location  = new Point(145, 18);

        // Body
        this.pnlBody.BackColor = Color.FromArgb(28, 28, 45);
        this.pnlBody.Bounds    = new Rectangle(30, 85, 440, 430);

        

        // Booking summary
        this.lblActivityLbl.Text      = "Activity";
        this.lblActivityLbl.Font      = new Font("Segoe UI", 9F);
        this.lblActivityLbl.ForeColor = Color.Silver;
        this.lblActivityLbl.Location  = new Point(lx, 15);
        this.lblActivityLbl.AutoSize  = true;

        this.lblActivityVal.Text      = "—";
        this.lblActivityVal.Font      = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.lblActivityVal.ForeColor = Color.White;
        this.lblActivityVal.Location  = new Point(lx, 34);
        this.lblActivityVal.AutoSize  = true;

        this.lblPriceLbl.Text      = "Total Amount";
        this.lblPriceLbl.Font      = new Font("Segoe UI", 9F);
        this.lblPriceLbl.ForeColor = Color.Silver;
        this.lblPriceLbl.Location  = new Point(300, 15);
        this.lblPriceLbl.AutoSize  = true;

        this.lblPriceVal.Text      = "EGP —";
        this.lblPriceVal.Font      = new Font("Segoe UI", 14F, FontStyle.Bold);
        this.lblPriceVal.ForeColor = Color.FromArgb(212, 175, 55);
        this.lblPriceVal.Location  = new Point(298, 34);
        this.lblPriceVal.AutoSize  = true;

        this.lblSep.BorderStyle = BorderStyle.Fixed3D;
        this.lblSep.Location    = new Point(lx, 65);
        this.lblSep.Size        = new Size(400, 2);
        this.lblSep.BackColor   = Color.FromArgb(60, 60, 90);

        AddRow(lblCardName,   txtCardName,   "Cardholder Name",   "Full name on card",       75);
        AddRow(lblCardNumber, txtCardNumber, "Card Number",        "1234 5678 9012 3456",     75 + gap);
        AddRow(lblExpiry,     txtExpiry,     "Expiry Date (MM/YY)","MM/YY",                   75 + gap * 2, true);
        AddRow(lblCVV,        txtCVV,        "CVV",                "•••",                     75 + gap * 2, true);
        this.txtCVV.Location = new Point(200, 75 + gap * 2 + 22);
        this.txtCVV.PasswordChar = '●';

        this.lblError.Text      = "";
        this.lblError.ForeColor = Color.Tomato;
        this.lblError.Font      = new Font("Segoe UI", 8.5F);
        this.lblError.Location  = new Point(lx, 75 + gap * 3 + 18);
        this.lblError.Size      = new Size(400, 18);

        this.progressBar.Location = new Point(lx, 75 + gap * 3 + 40);
        this.progressBar.Size     = new Size(400, 12);
        this.progressBar.Style    = ProgressBarStyle.Marquee;
        this.progressBar.Visible  = false;

        this.lblProcessing.Text      = "Processing payment…";
        this.lblProcessing.Font      = new Font("Segoe UI", 9F, FontStyle.Italic);
        this.lblProcessing.ForeColor = Color.Silver;
        this.lblProcessing.Location  = new Point(lx, 75 + gap * 3 + 58);
        this.lblProcessing.AutoSize  = true;
        this.lblProcessing.Visible   = false;

        this.btnPay.Text                      = "PAY NOW";
        this.btnPay.Location                  = new Point(220, 75 + gap * 3 + 80);
        this.btnPay.Size                      = new Size(200, 40);
        this.btnPay.BackColor                 = Color.FromArgb(212, 175, 55);
        this.btnPay.ForeColor                 = Color.FromArgb(18, 18, 30);
        this.btnPay.FlatStyle                 = FlatStyle.Flat;
        this.btnPay.FlatAppearance.BorderSize = 0;
        this.btnPay.Font                      = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.btnPay.Cursor                    = Cursors.Hand;
        this.btnPay.Click                    += new EventHandler(this.btnPay_Click);

        this.btnCancel.Text                      = "Cancel";
        this.btnCancel.Location                  = new Point(lx, 75 + gap * 3 + 80);
        this.btnCancel.Size                      = new Size(100, 40);
        this.btnCancel.BackColor                 = Color.Transparent;
        this.btnCancel.ForeColor                 = Color.Silver;
        this.btnCancel.FlatStyle                 = FlatStyle.Flat;
        this.btnCancel.FlatAppearance.BorderColor = Color.Gray;
        this.btnCancel.Font                      = new Font("Segoe UI", 9F);
        this.btnCancel.Cursor                    = Cursors.Hand;
        this.btnCancel.Click                    += new EventHandler(this.btnCancel_Click);

        this.pnlBody.Controls.AddRange(new Control[]
        {
            lblActivityLbl, lblActivityVal, lblPriceLbl, lblPriceVal, lblSep,
            lblCardName,   txtCardName,
            lblCardNumber, txtCardNumber,
            lblExpiry,     txtExpiry,
            lblCVV,        txtCVV,
            lblError, progressBar, lblProcessing, btnPay, btnCancel
        });

        // Form
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode       = AutoScaleMode.Font;
        this.ClientSize          = new Size(500, 540);
        this.Controls.Add(this.pnlBody);
        this.Controls.Add(this.pnlHeader);
        this.FormBorderStyle     = FormBorderStyle.FixedDialog;
        this.MaximizeBox         = false;
        this.Name                = "FrmPayment";
        this.StartPosition       = FormStartPosition.CenterParent;
        this.Text                = "LUXESCAPE – Secure Payment";
        this.BackColor           = Color.FromArgb(18, 18, 30);
    }

    private Panel       pnlHeader, pnlBody;
    private Label       lblTitle;
    private Label       lblActivityLbl, lblActivityVal, lblPriceLbl, lblPriceVal, lblSep;
    private Label       lblCardName, lblCardNumber, lblExpiry, lblCVV;
    private TextBox     txtCardName, txtCardNumber, txtExpiry, txtCVV;
    private Label       lblError, lblProcessing;
    private Button      btnPay, btnCancel;
    private ProgressBar progressBar;
}

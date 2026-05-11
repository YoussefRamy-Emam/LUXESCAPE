namespace LUXESCAPE.Forms;

partial class FrmBookingConfirmation
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlMain = new Panel();
        lblCheck = new Label();
        lblSuccess = new Label();
        lblActivity = new Label();
        lblTxnLabel = new Label();
        lblTxnValue = new Label();
        lblEmail = new Label();
        btnClose = new Button();
        pnlMain.SuspendLayout();
        SuspendLayout();
        // 
        // pnlMain
        // 
        pnlMain.BackColor = Color.FromArgb(22, 22, 40);
        pnlMain.Controls.Add(lblCheck);
        pnlMain.Controls.Add(lblSuccess);
        pnlMain.Controls.Add(lblActivity);
        pnlMain.Controls.Add(lblTxnLabel);
        pnlMain.Controls.Add(lblTxnValue);
        pnlMain.Controls.Add(lblEmail);
        pnlMain.Controls.Add(btnClose);
        pnlMain.Dock = DockStyle.Fill;
        pnlMain.Location = new Point(0, 0);
        pnlMain.Margin = new Padding(3, 4, 3, 4);
        pnlMain.Name = "pnlMain";
        pnlMain.Size = new Size(526, 560);
        pnlMain.TabIndex = 0;
        // 
        // lblCheck
        // 
        lblCheck.AutoSize = true;
        lblCheck.Font = new Font("Segoe UI", 52F, FontStyle.Bold);
        lblCheck.ForeColor = Color.FromArgb(80, 200, 120);
        lblCheck.Location = new Point(194, 19);
        lblCheck.Name = "lblCheck";
        lblCheck.Size = new Size(115, 116);
        lblCheck.TabIndex = 0;
        lblCheck.Text = "✓";
        // 
        // lblSuccess
        // 
        lblSuccess.AutoSize = true;
        lblSuccess.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblSuccess.ForeColor = Color.White;
        lblSuccess.Location = new Point(71, 149);
        lblSuccess.Name = "lblSuccess";
        lblSuccess.Size = new Size(345, 46);
        lblSuccess.TabIndex = 1;
        lblSuccess.Text = "Booking Confirmed!";
        // 
        // lblActivity
        // 
        lblActivity.AutoSize = true;
        lblActivity.Font = new Font("Segoe UI", 13F);
        lblActivity.ForeColor = Color.Silver;
        lblActivity.Location = new Point(91, 220);
        lblActivity.Name = "lblActivity";
        lblActivity.Size = new Size(0, 30);
        lblActivity.TabIndex = 2;
        // 
        // lblTxnLabel
        // 
        lblTxnLabel.AutoSize = true;
        lblTxnLabel.Font = new Font("Segoe UI", 9F);
        lblTxnLabel.ForeColor = Color.Gray;
        lblTxnLabel.Location = new Point(206, 243);
        lblTxnLabel.Name = "lblTxnLabel";
        lblTxnLabel.Size = new Size(103, 20);
        lblTxnLabel.TabIndex = 3;
        lblTxnLabel.Text = "Transaction ID";
        // 
        // lblTxnValue
        // 
        lblTxnValue.AutoSize = true;
        lblTxnValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTxnValue.ForeColor = Color.FromArgb(212, 175, 55);
        lblTxnValue.Location = new Point(171, 323);
        lblTxnValue.Name = "lblTxnValue";
        lblTxnValue.Size = new Size(0, 28);
        lblTxnValue.TabIndex = 4;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
        lblEmail.ForeColor = Color.Gray;
        lblEmail.Location = new Point(119, 388);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(286, 20);
        lblEmail.TabIndex = 5;
        lblEmail.Text = "A confirmation has been sent to your email.";
        // 
        // btnClose
        // 
        btnClose.BackColor = Color.FromArgb(212, 175, 55);
        btnClose.Cursor = Cursors.Hand;
        btnClose.FlatAppearance.BorderSize = 0;
        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnClose.ForeColor = Color.FromArgb(18, 18, 30);
        btnClose.Location = new Point(171, 453);
        btnClose.Margin = new Padding(3, 4, 3, 4);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(183, 56);
        btnClose.TabIndex = 6;
        btnClose.Text = "DONE";
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Click += btnClose_Click;
        // 
        // FrmBookingConfirmation
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(22, 22, 40);
        ClientSize = new Size(526, 560);
        Controls.Add(pnlMain);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "FrmBookingConfirmation";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Booking Confirmed";
        pnlMain.ResumeLayout(false);
        pnlMain.PerformLayout();
        ResumeLayout(false);
    }

    private Panel  pnlMain;
    private Label  lblCheck, lblSuccess, lblActivity, lblTxnLabel, lblTxnValue, lblEmail;
    private Button btnClose;
}

namespace LUXESCAPE.Forms;

partial class FrmLogin
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
        pnlForm = new Panel();
        lblError = new Label();
        lblForgot = new LinkLabel();
        btnRegister = new Button();
        btnLogin = new Button();
        txtPassword = new TextBox();
        lblPassword = new Label();
        txtEmail = new TextBox();
        lblEmail = new Label();
        pnlHeader = new Panel();
        lblSubtitle = new Label();
        lblTitle = new Label();
        pnlMain.SuspendLayout();
        pnlForm.SuspendLayout();
        pnlHeader.SuspendLayout();
        SuspendLayout();
        // 
        // pnlMain
        // 
        pnlMain.BackColor = Color.FromArgb(18, 18, 30);
        pnlMain.Controls.Add(pnlForm);
        pnlMain.Controls.Add(pnlHeader);
        pnlMain.Dock = DockStyle.Fill;
        pnlMain.Location = new Point(0, 0);
        pnlMain.Margin = new Padding(3, 4, 3, 4);
        pnlMain.Name = "pnlMain";
        pnlMain.Size = new Size(549, 667);
        pnlMain.TabIndex = 0;
        // 
        // pnlForm
        // 
        pnlForm.BackColor = Color.FromArgb(28, 28, 45);
        pnlForm.Controls.Add(lblError);
        pnlForm.Controls.Add(lblForgot);
        pnlForm.Controls.Add(btnRegister);
        pnlForm.Controls.Add(btnLogin);
        pnlForm.Controls.Add(txtPassword);
        pnlForm.Controls.Add(lblPassword);
        pnlForm.Controls.Add(txtEmail);
        pnlForm.Controls.Add(lblEmail);
        pnlForm.Location = new Point(91, 187);
        pnlForm.Margin = new Padding(3, 4, 3, 4);
        pnlForm.Name = "pnlForm";
        pnlForm.Size = new Size(366, 427);
        pnlForm.TabIndex = 0;
        // 
        // lblError
        // 
        lblError.Font = new Font("Segoe UI", 8.5F);
        lblError.ForeColor = Color.Tomato;
        lblError.Location = new Point(23, 193);
        lblError.Name = "lblError";
        lblError.Size = new Size(320, 24);
        lblError.TabIndex = 0;
        // 
        // lblForgot
        // 
        lblForgot.ActiveLinkColor = Color.White;
        lblForgot.AutoSize = true;
        lblForgot.Font = new Font("Segoe UI", 9F);
        lblForgot.LinkColor = Color.Silver;
        lblForgot.Location = new Point(109, 360);
        lblForgot.Name = "lblForgot";
        lblForgot.Size = new Size(127, 20);
        lblForgot.TabIndex = 1;
        lblForgot.TabStop = true;
        lblForgot.Text = "Forgot password?";
        // 
        // btnRegister
        // 
        btnRegister.BackColor = Color.Transparent;
        btnRegister.Cursor = Cursors.Hand;
        btnRegister.FlatAppearance.BorderColor = Color.FromArgb(212, 175, 55);
        btnRegister.FlatStyle = FlatStyle.Flat;
        btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnRegister.ForeColor = Color.FromArgb(212, 175, 55);
        btnRegister.Location = new Point(23, 291);
        btnRegister.Margin = new Padding(3, 4, 3, 4);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(320, 51);
        btnRegister.TabIndex = 2;
        btnRegister.Text = "CREATE ACCOUNT";
        btnRegister.UseVisualStyleBackColor = false;
        btnRegister.Click += btnRegister_Click;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.FromArgb(212, 175, 55);
        btnLogin.Cursor = Cursors.Hand;
        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnLogin.ForeColor = Color.FromArgb(18, 18, 30);
        btnLogin.Location = new Point(23, 227);
        btnLogin.Margin = new Padding(3, 4, 3, 4);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(320, 51);
        btnLogin.TabIndex = 3;
        btnLogin.Text = "LOGIN";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // txtPassword
        // 
        txtPassword.BackColor = Color.FromArgb(40, 40, 65);
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.Font = new Font("Segoe UI", 10F);
        txtPassword.ForeColor = Color.White;
        txtPassword.Location = new Point(23, 143);
        txtPassword.Margin = new Padding(3, 4, 3, 4);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '●';
        txtPassword.PlaceholderText = "Enter your password";
        txtPassword.Size = new Size(320, 30);
        txtPassword.TabIndex = 4;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Font = new Font("Segoe UI", 9F);
        lblPassword.ForeColor = Color.Silver;
        lblPassword.Location = new Point(23, 113);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(70, 20);
        lblPassword.TabIndex = 5;
        lblPassword.Text = "Password";
        // 
        // txtEmail
        // 
        txtEmail.BackColor = Color.FromArgb(40, 40, 65);
        txtEmail.BorderStyle = BorderStyle.FixedSingle;
        txtEmail.Font = new Font("Segoe UI", 10F);
        txtEmail.ForeColor = Color.White;
        txtEmail.Location = new Point(23, 51);
        txtEmail.Margin = new Padding(3, 4, 3, 4);
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "Enter your email";
        txtEmail.Size = new Size(320, 30);
        txtEmail.TabIndex = 6;
        txtEmail.TextChanged += txtEmail_TextChanged;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new Font("Segoe UI", 9F);
        lblEmail.ForeColor = Color.Silver;
        lblEmail.Location = new Point(23, 27);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(103, 20);
        lblEmail.TabIndex = 7;
        lblEmail.Text = "Email Address";
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(30, 30, 50);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Margin = new Padding(3, 4, 3, 4);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(549, 160);
        pnlHeader.TabIndex = 1;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 10F);
        lblSubtitle.ForeColor = Color.Silver;
        lblSubtitle.Location = new Point(160, 100);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(265, 23);
        lblSubtitle.TabIndex = 0;
        lblSubtitle.Text = "Premium Activity Booking System";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(212, 175, 55);
        lblTitle.Location = new Point(149, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(282, 62);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "LUXESCAPE";
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(18, 18, 30);
        ClientSize = new Size(549, 667);
        Controls.Add(pnlMain);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "LUXESCAPE – Login";
        Load += FrmLogin_Load;
        pnlMain.ResumeLayout(false);
        pnlForm.ResumeLayout(false);
        pnlForm.PerformLayout();
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        ResumeLayout(false);
    }

    // Controls
    private Panel pnlMain;
    private Panel pnlHeader;
    private Panel pnlForm;
    private Label lblTitle;
    private Label lblSubtitle;
    private Label lblEmail;
    private TextBox txtEmail;
    private Label lblPassword;
    private TextBox txtPassword;
    private Button btnLogin;
    private Button btnRegister;
    private LinkLabel lblForgot;
    private Label lblError;
}

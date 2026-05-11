namespace LUXESCAPE.Forms;

partial class FrmRegister
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    int lx = 20, ty = 15, gap = 60;

    void AddField(Label lbl, TextBox txt, string labelText, string placeholder, int top, bool isPwd = false)
    {
        lbl.Text = labelText;
        lbl.Font = new Font("Segoe UI", 9F);
        lbl.ForeColor = Color.Silver;
        lbl.Location = new Point(lx, top);
        lbl.AutoSize = true;

        txt.Location = new Point(lx, top + 22);
        txt.Size = new Size(320, 28);
        txt.BackColor = Color.FromArgb(40, 40, 65);
        txt.ForeColor = Color.White;
        txt.BorderStyle = BorderStyle.FixedSingle;
        txt.Font = new Font("Segoe UI", 10F);
        txt.PlaceholderText = placeholder;
        if (isPwd) txt.PasswordChar = '●';
    }

    private void InitializeComponent()
    {
        pnlHeader = new Panel();
        this.lblTitle = new Label();
        this.lblSub = new Label();
        pnlForm = new Panel();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        btnRegister = new Button();
        btnBack = new Button();
        txtEmail = new TextBox();
        txtFullName = new TextBox();
        lblError = new Label();
        txtPassword = new TextBox();
        txtPhone = new TextBox();
        txtConfirm = new TextBox();
        pnlHeader.SuspendLayout();
        pnlForm.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(30, 30, 50);
        pnlHeader.Controls.Add(this.lblTitle);
        pnlHeader.Controls.Add(this.lblSub);
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Margin = new Padding(3, 4, 3, 4);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(549, 120);
        pnlHeader.TabIndex = 1;
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
        this.lblTitle.ForeColor = Color.FromArgb(212, 175, 55);
        this.lblTitle.Location = new Point(177, 16);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new Size(224, 50);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "LUXESCAPE";
        // 
        // lblSub
        // 
        this.lblSub.AutoSize = true;
        this.lblSub.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        this.lblSub.ForeColor = Color.Silver;
        this.lblSub.Location = new Point(192, 73);
        this.lblSub.Name = "lblSub";
        this.lblSub.Size = new Size(167, 23);
        this.lblSub.TabIndex = 1;
        this.lblSub.Text = "Create Your Account";
        // 
        // pnlForm
        // 
        pnlForm.BackColor = Color.FromArgb(28, 28, 45);
        pnlForm.Controls.Add(txtConfirm);
        pnlForm.Controls.Add(txtPhone);
        pnlForm.Controls.Add(txtPassword);
        pnlForm.Controls.Add(lblError);
        pnlForm.Controls.Add(txtFullName);
        pnlForm.Controls.Add(txtEmail);
        pnlForm.Controls.Add(label5);
        pnlForm.Controls.Add(label4);
        pnlForm.Controls.Add(label3);
        pnlForm.Controls.Add(label2);
        pnlForm.Controls.Add(label1);
        pnlForm.Controls.Add(btnRegister);
        pnlForm.Controls.Add(btnBack);
        pnlForm.Location = new Point(69, 140);
        pnlForm.Margin = new Padding(3, 4, 3, 4);
        pnlForm.Name = "pnlForm";
        pnlForm.Size = new Size(411, 547);
        pnlForm.TabIndex = 0;
        pnlForm.Paint += pnlForm_Paint;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.ForeColor = Color.WhiteSmoke;
        label5.Location = new Point(23, 301);
        label5.Name = "label5";
        label5.Size = new Size(127, 20);
        label5.TabIndex = 17;
        label5.Text = "Confirm Password";
        label5.Click += label5_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = Color.WhiteSmoke;
        label4.Location = new Point(24, 223);
        label4.Name = "label4";
        label4.Size = new Size(70, 20);
        label4.TabIndex = 16;
        label4.Text = "Password";
        label4.Click += label4_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = Color.WhiteSmoke;
        label3.Location = new Point(24, 153);
        label3.Name = "label3";
        label3.Size = new Size(108, 20);
        label3.TabIndex = 15;
        label3.Text = "Phone Number";
        label3.Click += label3_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = Color.WhiteSmoke;
        label2.Location = new Point(24, 83);
        label2.Name = "label2";
        label2.Size = new Size(103, 20);
        label2.TabIndex = 14;
        label2.Text = "Email Address";
        label2.Click += label2_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = Color.WhiteSmoke;
        label1.Location = new Point(24, 16);
        label1.Name = "label1";
        label1.Size = new Size(76, 20);
        label1.TabIndex = 13;
        label1.Text = "Full Name";
        // 
        // btnRegister
        // 
        btnRegister.BackColor = Color.FromArgb(212, 175, 55);
        btnRegister.Cursor = Cursors.Hand;
        btnRegister.FlatAppearance.BorderSize = 0;
        btnRegister.FlatStyle = FlatStyle.Flat;
        btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        btnRegister.ForeColor = Color.FromArgb(18, 18, 30);
        btnRegister.Location = new Point(20, 403);
        btnRegister.Margin = new Padding(3, 4, 3, 4);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(366, 51);
        btnRegister.TabIndex = 11;
        btnRegister.Text = "CREATE ACCOUNT";
        btnRegister.UseVisualStyleBackColor = false;
        btnRegister.Click += btnRegister_Click;
        // 
        // btnBack
        // 
        btnBack.BackColor = Color.Transparent;
        btnBack.Cursor = Cursors.Hand;
        btnBack.FlatAppearance.BorderSize = 0;
        btnBack.FlatStyle = FlatStyle.Flat;
        btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        btnBack.ForeColor = Color.Silver;
        btnBack.Location = new Point(20, 462);
        btnBack.Margin = new Padding(3, 4, 3, 4);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(366, 40);
        btnBack.TabIndex = 12;
        btnBack.Text = "← BACK TO LOGIN";
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += btnBack_Click;
        // 
        // txtEmail
        // 
        txtEmail.BackColor = Color.FromArgb(40, 40, 65);
        txtEmail.BorderStyle = BorderStyle.FixedSingle;
        txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtEmail.ForeColor = Color.White;
        txtEmail.Location = new Point(24, 107);
        txtEmail.Margin = new Padding(3, 4, 3, 4);
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "Enter your email";
        txtEmail.Size = new Size(362, 30);
        txtEmail.TabIndex = 18;
        txtEmail.TextChanged += txtEmail_TextChanged_1;
        // 
        // txtFullName
        // 
        txtFullName.BackColor = Color.FromArgb(40, 40, 65);
        txtFullName.BorderStyle = BorderStyle.FixedSingle;
        txtFullName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtFullName.ForeColor = Color.White;
        txtFullName.Location = new Point(20, 40);
        txtFullName.Margin = new Padding(3, 4, 3, 4);
        txtFullName.Name = "txtFullName";
        txtFullName.PlaceholderText = "Enter your FullName";
        txtFullName.Size = new Size(362, 30);
        txtFullName.TabIndex = 19;
        // 
        // lblError
        // 
        lblError.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblError.ForeColor = Color.Tomato;
        lblError.Location = new Point(23, 375);
        lblError.Name = "lblError";
        lblError.Size = new Size(359, 24);
        lblError.TabIndex = 20;
        // 
        // txtPassword
        // 
        txtPassword.BackColor = Color.FromArgb(40, 40, 65);
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtPassword.ForeColor = Color.White;
        txtPassword.Location = new Point(20, 247);
        txtPassword.Margin = new Padding(3, 4, 3, 4);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '●';
        txtPassword.PlaceholderText = "Enter your password";
        txtPassword.Size = new Size(362, 30);
        txtPassword.TabIndex = 21;
        // 
        // txtPhone
        // 
        txtPhone.BackColor = Color.FromArgb(40, 40, 65);
        txtPhone.BorderStyle = BorderStyle.FixedSingle;
        txtPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtPhone.ForeColor = Color.White;
        txtPhone.Location = new Point(24, 177);
        txtPhone.Margin = new Padding(3, 4, 3, 4);
        txtPhone.Name = "txtPhone";
        txtPhone.PlaceholderText = "Enter your number";
        txtPhone.Size = new Size(362, 30);
        txtPhone.TabIndex = 22;
        // 
        // txtConfirm
        // 
        txtConfirm.BackColor = Color.FromArgb(40, 40, 65);
        txtConfirm.BorderStyle = BorderStyle.FixedSingle;
        txtConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtConfirm.ForeColor = Color.White;
        txtConfirm.Location = new Point(24, 325);
        txtConfirm.Margin = new Padding(3, 4, 3, 4);
        txtConfirm.Name = "txtConfirm";
        txtConfirm.PasswordChar = '●';
        txtConfirm.PlaceholderText = "Enter your confirm password";
        txtConfirm.Size = new Size(362, 30);
        txtConfirm.TabIndex = 23;
        // 
        // FrmRegister
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(18, 18, 30);
        ClientSize = new Size(549, 727);
        Controls.Add(pnlForm);
        Controls.Add(pnlHeader);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "FrmRegister";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "LUXESCAPE – Register";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlForm.ResumeLayout(false);
        pnlForm.PerformLayout();
        ResumeLayout(false);
    }

    private Panel   pnlHeader, pnlForm;
    private Button  btnRegister, btnBack;
    private Label label2;
    private Label label1;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox txtEmail;
    private TextBox txtFullName;
    private Label lblError;
    private TextBox txtPassword;
    private TextBox txtConfirm;
    private TextBox txtPhone;
    private Label lblTitle;
    private Label lblSub;
}

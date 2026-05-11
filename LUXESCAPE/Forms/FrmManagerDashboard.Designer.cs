namespace LUXESCAPE.Forms;

partial class FrmManagerDashboard
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private int flx , fty , fgap , btnY;

    void KpiCard(Label lbl, Label val, string title, int x)
    {
        lbl.Text = title;
        lbl.Font = new Font("Segoe UI", 9F);
        lbl.ForeColor = Color.Silver;
        lbl.Location = new Point(x, 15);
        lbl.AutoSize = true;

        val.Text = "—";
        val.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        val.ForeColor = Color.FromArgb(212, 175, 55);
        val.Location = new Point(x, 35);
        val.AutoSize = true;
    }

    void CrudBtn(Button b, string txt, Color bg, Color fg, int x, EventHandler h)
    {
        b.Text = txt;
        b.Location = new Point(x, btnY);
        b.Size = new Size(118, 34);
        b.BackColor = bg;
        b.ForeColor = fg;
        b.FlatStyle = FlatStyle.Flat;
        b.FlatAppearance.BorderSize = 0;
        b.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        b.Cursor = Cursors.Hand;
        b.Click += h;
    }

    void FormField(Label lbl, TextBox txt, string labelText, string ph, int top, bool multi = false)
    {
        lbl.Text = labelText;
        lbl.Font = new Font("Segoe UI", 8.5F);
        lbl.ForeColor = Color.Silver;
        lbl.Location = new Point(flx, top);
        lbl.AutoSize = true;

        txt.Location = new Point(flx, top + 18);
        txt.Size = multi ? new Size(255, 60) : new Size(255, 26);
        txt.BackColor = Color.FromArgb(40, 40, 65);
        txt.ForeColor = Color.White;
        txt.BorderStyle = BorderStyle.FixedSingle;
        txt.Font = new Font("Segoe UI", 9.5F);
        txt.PlaceholderText = ph;
        if (multi) { txt.Multiline = true; txt.ScrollBars = ScrollBars.Vertical; }
    }

    void SideBtn(Button b, string txt, int top, EventHandler h)
    {
        b.Text = txt;
        b.Location = new Point(0, top);
        b.Size = new Size(200, 48);
        b.BackColor = Color.Transparent;
        b.ForeColor = Color.Silver;
        b.FlatStyle = FlatStyle.Flat;
        b.FlatAppearance.BorderSize = 0;
        b.Font = new Font("Segoe UI", 10F);
        b.TextAlign = ContentAlignment.MiddleLeft;
        b.Padding = new Padding(20, 0, 0, 0);
        b.Cursor = Cursors.Hand;
        b.Click += h;
    }

    private void InitializeComponent()
    {
        pnlSidebar = new Panel();
        lblLogo = new Label();
        btnManageActs = new Button();
        btnReports = new Button();
        btnLogout = new Button();
        pnlContent = new Panel();
        pnlReports = new Panel();
        lblRevTitle = new Label();
        lblRevValue = new Label();
        lblBookTitle = new Label();
        lblBookValue = new Label();
        btnRefresh = new Button();
        lblFbTitle = new Label();
        lvFeedback = new ListView();
        colFbUser = new ColumnHeader();
        colFbAct = new ColumnHeader();
        colFbRating = new ColumnHeader();
        colFbComment = new ColumnHeader();
        pnlManageActs = new Panel();
        lvActivities = new ListView();
        colId = new ColumnHeader();
        colTitle = new ColumnHeader();
        colDate = new ColumnHeader();
        colPrice = new ColumnHeader();
        colSeats = new ColumnHeader();
        colStatus = new ColumnHeader();
        pnlActForm = new Panel();
        lblFormTitle = new Label();
        lblFTitle = new Label();
        txtFTitle = new TextBox();
        lblFDate = new Label();
        txtFDate = new TextBox();
        lblFPrice = new Label();
        txtFPrice = new TextBox();
        lblFSeats = new Label();
        txtFSeats = new TextBox();
        lblFDesc = new Label();
        txtFDesc = new TextBox();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClearForm = new Button();
        pnlTopBar = new Panel();
        lblPageTitle = new Label();
        lblManagerTag = new Label();
        pnlSidebar.SuspendLayout();
        pnlContent.SuspendLayout();
        pnlReports.SuspendLayout();
        pnlManageActs.SuspendLayout();
        pnlActForm.SuspendLayout();
        pnlTopBar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = Color.FromArgb(22, 22, 40);
        pnlSidebar.Controls.Add(lblLogo);
        pnlSidebar.Controls.Add(btnManageActs);
        pnlSidebar.Controls.Add(btnReports);
        pnlSidebar.Controls.Add(btnLogout);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 0);
        pnlSidebar.Margin = new Padding(3, 4, 3, 4);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new Size(229, 933);
        pnlSidebar.TabIndex = 1;
        // 
        // lblLogo
        // 
        lblLogo.AutoSize = true;
        lblLogo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblLogo.ForeColor = Color.FromArgb(212, 175, 55);
        lblLogo.Location = new Point(23, 33);
        lblLogo.Name = "lblLogo";
        lblLogo.Size = new Size(145, 32);
        lblLogo.TabIndex = 0;
        lblLogo.Text = "LUXESCAPE";
        // 
        // btnManageActs
        // 
        btnManageActs.Location = new Point(0, 0);
        btnManageActs.Margin = new Padding(3, 4, 3, 4);
        btnManageActs.Name = "btnManageActs";
        btnManageActs.Size = new Size(86, 31);
        btnManageActs.TabIndex = 1;
        // 
        // btnReports
        // 
        btnReports.Location = new Point(0, 0);
        btnReports.Margin = new Padding(3, 4, 3, 4);
        btnReports.Name = "btnReports";
        btnReports.Size = new Size(86, 31);
        btnReports.TabIndex = 2;
        // 
        // btnLogout
        // 
        btnLogout.ForeColor = Color.Tomato;
        btnLogout.Location = new Point(0, 0);
        btnLogout.Margin = new Padding(3, 4, 3, 4);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(86, 31);
        btnLogout.TabIndex = 3;
        // 
        // pnlContent
        // 
        pnlContent.BackColor = Color.FromArgb(18, 18, 30);
        pnlContent.Controls.Add(pnlReports);
        pnlContent.Controls.Add(pnlManageActs);
        pnlContent.Controls.Add(pnlTopBar);
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Location = new Point(229, 0);
        pnlContent.Margin = new Padding(3, 4, 3, 4);
        pnlContent.Name = "pnlContent";
        pnlContent.Size = new Size(982, 933);
        pnlContent.TabIndex = 0;
        // 
        // pnlReports
        // 
        pnlReports.BackColor = Color.Transparent;
        pnlReports.Controls.Add(lblRevTitle);
        pnlReports.Controls.Add(lblRevValue);
        pnlReports.Controls.Add(lblBookTitle);
        pnlReports.Controls.Add(lblBookValue);
        pnlReports.Controls.Add(btnRefresh);
        pnlReports.Controls.Add(lblFbTitle);
        pnlReports.Controls.Add(lvFeedback);
        pnlReports.Location = new Point(0, 73);
        pnlReports.Margin = new Padding(3, 4, 3, 4);
        pnlReports.Name = "pnlReports";
        pnlReports.Size = new Size(983, 827);
        pnlReports.TabIndex = 0;
        pnlReports.Visible = false;
        // 
        // lblRevTitle
        // 
        lblRevTitle.Location = new Point(0, 0);
        lblRevTitle.Name = "lblRevTitle";
        lblRevTitle.Size = new Size(114, 31);
        lblRevTitle.TabIndex = 0;
        // 
        // lblRevValue
        // 
        lblRevValue.Location = new Point(0, 0);
        lblRevValue.Name = "lblRevValue";
        lblRevValue.Size = new Size(114, 31);
        lblRevValue.TabIndex = 1;
        // 
        // lblBookTitle
        // 
        lblBookTitle.Location = new Point(0, 0);
        lblBookTitle.Name = "lblBookTitle";
        lblBookTitle.Size = new Size(114, 31);
        lblBookTitle.TabIndex = 2;
        // 
        // lblBookValue
        // 
        lblBookValue.Location = new Point(0, 0);
        lblBookValue.Name = "lblBookValue";
        lblBookValue.Size = new Size(114, 31);
        lblBookValue.TabIndex = 3;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.FromArgb(212, 175, 55);
        btnRefresh.Cursor = Cursors.Hand;
        btnRefresh.FlatAppearance.BorderSize = 0;
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnRefresh.ForeColor = Color.FromArgb(18, 18, 30);
        btnRefresh.Location = new Point(800, 47);
        btnRefresh.Margin = new Padding(3, 4, 3, 4);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(126, 43);
        btnRefresh.TabIndex = 4;
        btnRefresh.Text = "🔄 Refresh";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // lblFbTitle
        // 
        lblFbTitle.AutoSize = true;
        lblFbTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblFbTitle.ForeColor = Color.White;
        lblFbTitle.Location = new Point(23, 120);
        lblFbTitle.Name = "lblFbTitle";
        lblFbTitle.Size = new Size(152, 25);
        lblFbTitle.TabIndex = 5;
        lblFbTitle.Text = "Guest Feedback";
        // 
        // lvFeedback
        // 
        lvFeedback.BackColor = Color.FromArgb(28, 28, 45);
        lvFeedback.BorderStyle = BorderStyle.None;
        lvFeedback.Columns.AddRange(new ColumnHeader[] { colFbUser, colFbAct, colFbRating, colFbComment });
        lvFeedback.Font = new Font("Segoe UI", 9.5F);
        lvFeedback.ForeColor = Color.White;
        lvFeedback.FullRowSelect = true;
        lvFeedback.Location = new Point(23, 153);
        lvFeedback.Margin = new Padding(3, 4, 3, 4);
        lvFeedback.Name = "lvFeedback";
        lvFeedback.Size = new Size(937, 613);
        lvFeedback.TabIndex = 6;
        lvFeedback.UseCompatibleStateImageBehavior = false;
        lvFeedback.View = View.Details;
        lvFeedback.SelectedIndexChanged += lvFeedback_SelectedIndexChanged;
        // 
        // colFbUser
        // 
        colFbUser.Text = "Customer";
        colFbUser.Width = 160;
        // 
        // colFbAct
        // 
        colFbAct.Text = "Activity";
        colFbAct.Width = 220;
        // 
        // colFbRating
        // 
        colFbRating.Text = "Rating";
        colFbRating.Width = 70;
        // 
        // colFbComment
        // 
        colFbComment.Text = "Comments";
        colFbComment.Width = 360;
        // 
        // pnlManageActs
        // 
        pnlManageActs.BackColor = Color.Transparent;
        pnlManageActs.Controls.Add(lvActivities);
        pnlManageActs.Controls.Add(pnlActForm);
        pnlManageActs.Location = new Point(0, 73);
        pnlManageActs.Margin = new Padding(3, 4, 3, 4);
        pnlManageActs.Name = "pnlManageActs";
        pnlManageActs.Size = new Size(983, 827);
        pnlManageActs.TabIndex = 1;
        // 
        // lvActivities
        // 
        lvActivities.BackColor = Color.FromArgb(28, 28, 45);
        lvActivities.BorderStyle = BorderStyle.None;
        lvActivities.Columns.AddRange(new ColumnHeader[] { colId, colTitle, colDate, colPrice, colSeats, colStatus });
        lvActivities.Font = new Font("Segoe UI", 9F);
        lvActivities.ForeColor = Color.White;
        lvActivities.FullRowSelect = true;
        lvActivities.Location = new Point(23, 13);
        lvActivities.Margin = new Padding(3, 4, 3, 4);
        lvActivities.MultiSelect = false;
        lvActivities.Name = "lvActivities";
        lvActivities.Size = new Size(606, 773);
        lvActivities.TabIndex = 0;
        lvActivities.UseCompatibleStateImageBehavior = false;
        lvActivities.View = View.Details;
        lvActivities.SelectedIndexChanged += lvActivities_SelectedIndexChanged;
        // 
        // colId
        // 
        colId.Text = "ID";
        colId.Width = 50;
        // 
        // colTitle
        // 
        colTitle.Text = "Title";
        colTitle.Width = 180;
        // 
        // colDate
        // 
        colDate.Text = "Date";
        colDate.Width = 130;
        // 
        // colPrice
        // 
        colPrice.Text = "Price";
        colPrice.Width = 80;
        // 
        // colSeats
        // 
        colSeats.Text = "Seats";
        colSeats.Width = 55;
        // 
        // colStatus
        // 
        colStatus.Text = "Status";
        colStatus.Width = 70;
        // 
        // pnlActForm
        // 
        pnlActForm.BackColor = Color.FromArgb(28, 28, 45);
        pnlActForm.Controls.Add(lblFormTitle);
        pnlActForm.Controls.Add(lblFTitle);
        pnlActForm.Controls.Add(txtFTitle);
        pnlActForm.Controls.Add(lblFDate);
        pnlActForm.Controls.Add(txtFDate);
        pnlActForm.Controls.Add(lblFPrice);
        pnlActForm.Controls.Add(txtFPrice);
        pnlActForm.Controls.Add(lblFSeats);
        pnlActForm.Controls.Add(txtFSeats);
        pnlActForm.Controls.Add(lblFDesc);
        pnlActForm.Controls.Add(txtFDesc);
        pnlActForm.Controls.Add(btnAdd);
        pnlActForm.Controls.Add(btnUpdate);
        pnlActForm.Controls.Add(btnDelete);
        pnlActForm.Controls.Add(btnClearForm);
        pnlActForm.Location = new Point(646, 13);
        pnlActForm.Margin = new Padding(3, 4, 3, 4);
        pnlActForm.Name = "pnlActForm";
        pnlActForm.Size = new Size(326, 773);
        pnlActForm.TabIndex = 1;
        // 
        // lblFormTitle
        // 
        lblFormTitle.AutoSize = true;
        lblFormTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblFormTitle.ForeColor = Color.FromArgb(212, 175, 55);
        lblFormTitle.Location = new Point(17, 20);
        lblFormTitle.Name = "lblFormTitle";
        lblFormTitle.Size = new Size(142, 25);
        lblFormTitle.TabIndex = 0;
        lblFormTitle.Text = "Activity Details";
        // 
        // lblFTitle
        // 
        lblFTitle.Location = new Point(0, 0);
        lblFTitle.Name = "lblFTitle";
        lblFTitle.Size = new Size(114, 31);
        lblFTitle.TabIndex = 1;
        // 
        // txtFTitle
        // 
        txtFTitle.Location = new Point(0, 0);
        txtFTitle.Margin = new Padding(3, 4, 3, 4);
        txtFTitle.Name = "txtFTitle";
        txtFTitle.Size = new Size(114, 27);
        txtFTitle.TabIndex = 2;
        // 
        // lblFDate
        // 
        lblFDate.Location = new Point(0, 0);
        lblFDate.Name = "lblFDate";
        lblFDate.Size = new Size(114, 31);
        lblFDate.TabIndex = 3;
        // 
        // txtFDate
        // 
        txtFDate.Location = new Point(0, 0);
        txtFDate.Margin = new Padding(3, 4, 3, 4);
        txtFDate.Name = "txtFDate";
        txtFDate.Size = new Size(114, 27);
        txtFDate.TabIndex = 4;
        // 
        // lblFPrice
        // 
        lblFPrice.Location = new Point(0, 0);
        lblFPrice.Name = "lblFPrice";
        lblFPrice.Size = new Size(114, 31);
        lblFPrice.TabIndex = 5;
        // 
        // txtFPrice
        // 
        txtFPrice.Location = new Point(0, 0);
        txtFPrice.Margin = new Padding(3, 4, 3, 4);
        txtFPrice.Name = "txtFPrice";
        txtFPrice.Size = new Size(114, 27);
        txtFPrice.TabIndex = 6;
        // 
        // lblFSeats
        // 
        lblFSeats.Location = new Point(0, 0);
        lblFSeats.Name = "lblFSeats";
        lblFSeats.Size = new Size(114, 31);
        lblFSeats.TabIndex = 7;
        // 
        // txtFSeats
        // 
        txtFSeats.Location = new Point(0, 0);
        txtFSeats.Margin = new Padding(3, 4, 3, 4);
        txtFSeats.Name = "txtFSeats";
        txtFSeats.Size = new Size(114, 27);
        txtFSeats.TabIndex = 8;
        // 
        // lblFDesc
        // 
        lblFDesc.Location = new Point(0, 0);
        lblFDesc.Name = "lblFDesc";
        lblFDesc.Size = new Size(114, 31);
        lblFDesc.TabIndex = 9;
        // 
        // txtFDesc
        // 
        txtFDesc.Location = new Point(0, 0);
        txtFDesc.Margin = new Padding(3, 4, 3, 4);
        txtFDesc.Name = "txtFDesc";
        txtFDesc.Size = new Size(114, 27);
        txtFDesc.TabIndex = 10;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(0, 0);
        btnAdd.Margin = new Padding(3, 4, 3, 4);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(86, 31);
        btnAdd.TabIndex = 11;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(0, 0);
        btnUpdate.Margin = new Padding(3, 4, 3, 4);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(86, 31);
        btnUpdate.TabIndex = 12;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(17, 67);
        btnDelete.Margin = new Padding(3, 4, 3, 4);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(86, 31);
        btnDelete.TabIndex = 13;
        // 
        // btnClearForm
        // 
        btnClearForm.Location = new Point(17, 67);
        btnClearForm.Margin = new Padding(3, 4, 3, 4);
        btnClearForm.Name = "btnClearForm";
        btnClearForm.Size = new Size(86, 31);
        btnClearForm.TabIndex = 14;
        // 
        // pnlTopBar
        // 
        pnlTopBar.BackColor = Color.FromArgb(30, 30, 50);
        pnlTopBar.Controls.Add(lblPageTitle);
        pnlTopBar.Controls.Add(lblManagerTag);
        pnlTopBar.Dock = DockStyle.Top;
        pnlTopBar.Location = new Point(0, 0);
        pnlTopBar.Margin = new Padding(3, 4, 3, 4);
        pnlTopBar.Name = "pnlTopBar";
        pnlTopBar.Size = new Size(982, 73);
        pnlTopBar.TabIndex = 2;
        // 
        // lblPageTitle
        // 
        lblPageTitle.AutoSize = true;
        lblPageTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblPageTitle.ForeColor = Color.White;
        lblPageTitle.Location = new Point(23, 19);
        lblPageTitle.Name = "lblPageTitle";
        lblPageTitle.Size = new Size(218, 32);
        lblPageTitle.TabIndex = 0;
        lblPageTitle.Text = "Manage Activities";
        // 
        // lblManagerTag
        // 
        lblManagerTag.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblManagerTag.AutoSize = true;
        lblManagerTag.Font = new Font("Segoe UI", 9F);
        lblManagerTag.ForeColor = Color.FromArgb(212, 175, 55);
        lblManagerTag.Location = new Point(1576, 24);
        lblManagerTag.Name = "lblManagerTag";
        lblManagerTag.Size = new Size(92, 20);
        lblManagerTag.TabIndex = 1;
        lblManagerTag.Text = "🛡  Manager";
        // 
        // FrmManagerDashboard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(18, 18, 30);
        ClientSize = new Size(1211, 933);
        Controls.Add(pnlContent);
        Controls.Add(pnlSidebar);
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(1209, 918);
        Name = "FrmManagerDashboard";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "LUXESCAPE – Manager Dashboard";
        WindowState = FormWindowState.Maximized;
        Load += FrmManagerDashboard_Load;
        // ================= SIDEBAR BUTTONS =================

        SideBtn(btnManageActs, "📋 Manage Activities", 120, btnManageActs_Click);
        SideBtn(btnReports, "📊 Reports", 170, btnReports_Click);
        SideBtn(btnLogout, "🚪 Logout", 760, btnLogout_Click);

        btnLogout.ForeColor = Color.Tomato;


        // ================= FORM LAYOUT =================

        flx = 18;
        fty = 70;
        fgap = 75;

        FormField(lblFTitle, txtFTitle,
            "Title", "Enter activity title", fty);

        FormField(lblFDate, txtFDate,
            "Date & Time", "2026-06-10 09:00", fty + fgap);

        FormField(lblFPrice, txtFPrice,
            "Price", "1200", fty + (fgap * 2));

        FormField(lblFSeats, txtFSeats,
            "Seats", "20", fty + (fgap * 3));

        FormField(lblFDesc, txtFDesc,
            "Description", "Write activity details...",
            fty + (fgap * 4), true);


        // ================= CRUD BUTTONS =================

        btnY = 610;

        btnAdd.Size = new Size(170, 38);
        btnUpdate.Size = new Size(170, 38);
        btnDelete.Size = new Size(170, 38);
        btnClearForm.Size = new Size(170, 38);

        btnDelete.Location = new Point(18, 660);
        btnClearForm.Location = new Point(210, 660);

        CrudBtn(
            btnAdd,
            "➕ Add",
            Color.FromArgb(212, 175, 55),
            Color.Black,
            18,
            btnAdd_Click);

        CrudBtn(
            btnUpdate,
            "✏ Update",
            Color.DodgerBlue,
            Color.White,
            210,
            btnUpdate_Click);

        CrudBtn(
            btnDelete,
            "🗑 Delete",
            Color.IndianRed,
            Color.White,
            18,
            btnDelete_Click);

        CrudBtn(
            btnClearForm,
            "🧹 Clear",
            Color.Gray,
            Color.White,
            210,
            btnClearForm_Click);


        // ================= LISTVIEW SIZE =================

        lvActivities.Size = new Size(700, 773);

        pnlActForm.Location = new Point(800, 13);
        pnlActForm.Size = new Size(500, 773);


        // ================= STYLE =================

        txtFDesc.Height = 90;

        lvActivities.GridLines = false;
        lvActivities.HideSelection = false;

        lvFeedback.GridLines = false;
        lvFeedback.HideSelection = false;

        lblManagerTag.Location = new Point(820, 24);
        pnlSidebar.ResumeLayout(false);
        pnlSidebar.PerformLayout();
        pnlContent.ResumeLayout(false);
        pnlReports.ResumeLayout(false);
        pnlReports.PerformLayout();
        pnlManageActs.ResumeLayout(false);
        pnlActForm.ResumeLayout(false);
        pnlActForm.PerformLayout();
        pnlTopBar.ResumeLayout(false);
        pnlTopBar.PerformLayout();
        ResumeLayout(false);
    }

    private Panel    pnlSidebar, pnlContent, pnlTopBar;
    private Panel    pnlManageActs, pnlActForm, pnlReports;
    private Label    lblLogo, lblPageTitle, lblManagerTag;
    private Button   btnManageActs, btnReports, btnLogout;
    private ListView lvActivities;
    private ColumnHeader colId, colTitle, colDate, colPrice, colSeats, colStatus;
    private Panel    pnlActFormContainer;
    private Label    lblFormTitle;
    private Label    lblFTitle, lblFDate, lblFPrice, lblFSeats, lblFDesc;
    private TextBox  txtFTitle, txtFDate, txtFPrice, txtFSeats, txtFDesc;
    private Button   btnAdd, btnUpdate, btnDelete, btnClearForm;
    private Label    lblRevTitle, lblRevValue, lblBookTitle, lblBookValue, lblFbTitle;
    private ListView lvFeedback;
    private ColumnHeader colFbUser, colFbAct, colFbRating, colFbComment;
    private Button   btnRefresh;
}

namespace LUXESCAPE.Forms;

partial class FrmCustomerDashboard
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }
    void SideBtn(Button b, string txt, int top, EventHandler handler)
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
        b.Click += handler;
    }

    private void InitializeComponent()
    {
        this.pnlSidebar    = new Panel();
        this.lblLogo       = new Label();
        this.btnActivities = new Button();
        this.btnMyBookings = new Button();
        this.btnFeedback   = new Button();
        this.btnLogout     = new Button();
        this.pnlContent    = new Panel();
        this.pnlTopBar     = new Panel();
        this.lblPageTitle  = new Label();
        this.lblWelcome    = new Label();

        // Placeholder panels for each section
        this.pnlActivities = new Panel();
        this.pnlMyBookings = new Panel();
        this.pnlFeedbackForm = new Panel();

        // Activity list controls
        this.lblActSearch   = new Label();
        this.txtSearch      = new TextBox();
        this.btnSearch      = new Button();
        this.lvActivities   = new ListView();
        this.colActName     = new ColumnHeader();
        this.colActDate     = new ColumnHeader();
        this.colActPrice    = new ColumnHeader();
        this.colActSeats    = new ColumnHeader();
        this.btnBook        = new Button();

        // My Bookings controls
        this.lvMyBookings   = new ListView();
        this.colBkgId       = new ColumnHeader();
        this.colBkgActivity = new ColumnHeader();
        this.colBkgDate     = new ColumnHeader();
        this.colBkgStatus   = new ColumnHeader();
        this.colBkgTxn      = new ColumnHeader();

        // Feedback controls
        this.lblFbActivity  = new Label();
        this.cmbFbActivity  = new ComboBox();
        this.lblRating      = new Label();
        this.nudRating      = new NumericUpDown();
        this.lblComments    = new Label();
        this.txtComments    = new TextBox();
        this.btnSubmitFb    = new Button();

        // ── Sidebar ───────────────────────────────────────────────
        this.pnlSidebar.BackColor = Color.FromArgb(22, 22, 40);
        this.pnlSidebar.Dock      = DockStyle.Left;
        this.pnlSidebar.Width     = 200;

        this.lblLogo.Text      = "LUXESCAPE";
        this.lblLogo.Font      = new Font("Segoe UI", 14F, FontStyle.Bold);
        this.lblLogo.ForeColor = Color.FromArgb(212, 175, 55);
        this.lblLogo.Location  = new Point(20, 25);
        this.lblLogo.AutoSize  = true;

        

        SideBtn(btnActivities, "🗓  Browse Activities",  100, btnActivities_Click);
        SideBtn(btnMyBookings, "📋  My Bookings",        150, btnMyBookings_Click);
        SideBtn(btnFeedback,   "💬  Leave Feedback",     200, btnFeedback_Click);
        SideBtn(btnLogout,     "🔒  Logout",             600, btnLogout_Click);
        btnLogout.ForeColor = Color.Tomato;

        this.pnlSidebar.Controls.AddRange(new Control[]
            { lblLogo, btnActivities, btnMyBookings, btnFeedback, btnLogout });

        // ── Top Bar ───────────────────────────────────────────────
        this.pnlTopBar.BackColor = Color.FromArgb(30, 30, 50);
        this.pnlTopBar.Dock      = DockStyle.Top;
        this.pnlTopBar.Height    = 55;

        this.lblPageTitle.Text      = "Browse Activities";
        this.lblPageTitle.Font      = new Font("Segoe UI", 14F, FontStyle.Bold);
        this.lblPageTitle.ForeColor = Color.White;
        this.lblPageTitle.Location  = new Point(20, 14);
        this.lblPageTitle.AutoSize  = true;

        this.lblWelcome.Text      = "Welcome back!";
        this.lblWelcome.Font      = new Font("Segoe UI", 9F);
        this.lblWelcome.ForeColor = Color.Silver;
        this.lblWelcome.Anchor    = AnchorStyles.Top | AnchorStyles.Right;
        this.lblWelcome.Location  = new Point(700, 18);
        this.lblWelcome.AutoSize  = true;

        this.pnlTopBar.Controls.AddRange(new Control[] { lblPageTitle, lblWelcome });

        // ── Content ───────────────────────────────────────────────
        this.pnlContent.BackColor = Color.FromArgb(18, 18, 30);
        this.pnlContent.Dock      = DockStyle.Fill;
        this.pnlContent.Controls.Add(this.pnlFeedbackForm);
        this.pnlContent.Controls.Add(this.pnlMyBookings);
        this.pnlContent.Controls.Add(this.pnlActivities);
        this.pnlContent.Controls.Add(this.pnlTopBar);

        // ── Activities Panel ─────────────────────────────────────
        this.pnlActivities.BackColor = Color.Transparent;
        this.pnlActivities.Bounds    = new Rectangle(0, 55, 860, 600);

        this.lblActSearch.Text      = "Search Activities:";
        this.lblActSearch.Font      = new Font("Segoe UI", 9F);
        this.lblActSearch.ForeColor = Color.Silver;
        this.lblActSearch.Location  = new Point(20, 20);
        this.lblActSearch.AutoSize  = true;

        this.txtSearch.Location        = new Point(20, 42);
        this.txtSearch.Size            = new Size(300, 28);
        this.txtSearch.BackColor       = Color.FromArgb(40, 40, 65);
        this.txtSearch.ForeColor       = Color.White;
        this.txtSearch.BorderStyle     = BorderStyle.FixedSingle;
        this.txtSearch.Font            = new Font("Segoe UI", 10F);
        this.txtSearch.PlaceholderText = "Activity name or date…";

        this.btnSearch.Text                      = "🔍 Search";
        this.btnSearch.Location                  = new Point(328, 42);
        this.btnSearch.Size                      = new Size(100, 28);
        this.btnSearch.BackColor                 = Color.FromArgb(212, 175, 55);
        this.btnSearch.ForeColor                 = Color.FromArgb(18, 18, 30);
        this.btnSearch.FlatStyle                 = FlatStyle.Flat;
        this.btnSearch.FlatAppearance.BorderSize = 0;
        this.btnSearch.Font                      = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.btnSearch.Cursor                    = Cursors.Hand;
        this.btnSearch.Click                    += new EventHandler(this.btnSearch_Click);

        this.lvActivities.View               = View.Details;
        this.lvActivities.FullRowSelect      = true;
        this.lvActivities.GridLines          = false;
        this.lvActivities.BackColor          = Color.FromArgb(28, 28, 45);
        this.lvActivities.ForeColor          = Color.White;
        this.lvActivities.Location           = new Point(20, 82);
        this.lvActivities.Size               = new Size(820, 440);
        this.lvActivities.Font               = new Font("Segoe UI", 10F);
        this.lvActivities.HeaderStyle        = ColumnHeaderStyle.Nonclickable;
        this.lvActivities.BorderStyle        = BorderStyle.None;
        this.colActName.Text  = "Activity Name";  this.colActName.Width  = 280;
        this.colActDate.Text  = "Date & Time";    this.colActDate.Width  = 180;
        this.colActPrice.Text = "Price (EGP)";    this.colActPrice.Width = 120;
        this.colActSeats.Text = "Seats Left";     this.colActSeats.Width = 120;
        this.lvActivities.Columns.AddRange(new ColumnHeader [] { colActName, colActDate, colActPrice, colActSeats });

        this.btnBook.Text                      = "BOOK SELECTED ACTIVITY";
        this.btnBook.Location                  = new Point(620, 535);
        this.btnBook.Size                      = new Size(220, 38);
        this.btnBook.BackColor                 = Color.FromArgb(212, 175, 55);
        this.btnBook.ForeColor                 = Color.FromArgb(18, 18, 30);
        this.btnBook.FlatStyle                 = FlatStyle.Flat;
        this.btnBook.FlatAppearance.BorderSize = 0;
        this.btnBook.Font                      = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnBook.Cursor                    = Cursors.Hand;
        this.btnBook.Click                    += new EventHandler(this.btnBook_Click);

        this.pnlActivities.Controls.AddRange(new Control[]
            { lblActSearch, txtSearch, btnSearch, lvActivities, btnBook });

        // ── My Bookings Panel ─────────────────────────────────────
        this.pnlMyBookings.BackColor = Color.Transparent;
        this.pnlMyBookings.Bounds    = new Rectangle(0, 55, 860, 600);
        this.pnlMyBookings.Visible   = false;

        this.lvMyBookings.View          = View.Details;
        this.lvMyBookings.FullRowSelect = true;
        this.lvMyBookings.BackColor     = Color.FromArgb(28, 28, 45);
        this.lvMyBookings.ForeColor     = Color.White;
        this.lvMyBookings.Location      = new Point(20, 20);
        this.lvMyBookings.Size          = new Size(820, 500);
        this.lvMyBookings.Font          = new Font("Segoe UI", 10F);
        this.lvMyBookings.BorderStyle   = BorderStyle.None;
        this.colBkgId.Text       = "Booking ID";   this.colBkgId.Width       = 100;
        this.colBkgActivity.Text = "Activity";      this.colBkgActivity.Width = 260;
        this.colBkgDate.Text     = "Date";          this.colBkgDate.Width     = 160;
        this.colBkgStatus.Text   = "Status";        this.colBkgStatus.Width   = 120;
        this.colBkgTxn.Text      = "Transaction ID";this.colBkgTxn.Width      = 180;
        this.lvMyBookings.Columns.AddRange(new ColumnHeader [] { colBkgId, colBkgActivity, colBkgDate, colBkgStatus, colBkgTxn });
        this.pnlMyBookings.Controls.Add(lvMyBookings);

        // ── Feedback Panel ────────────────────────────────────────
        this.pnlFeedbackForm.BackColor = Color.Transparent;
        this.pnlFeedbackForm.Bounds    = new Rectangle(0, 55, 860, 600);
        this.pnlFeedbackForm.Visible   = false;

        this.lblFbActivity.Text      = "Select Activity";
        this.lblFbActivity.Font      = new Font("Segoe UI", 9F);
        this.lblFbActivity.ForeColor = Color.Silver;
        this.lblFbActivity.Location  = new Point(20, 20);
        this.lblFbActivity.AutoSize  = true;

        this.cmbFbActivity.Location      = new Point(20, 42);
        this.cmbFbActivity.Size          = new Size(400, 28);
        this.cmbFbActivity.BackColor     = Color.FromArgb(40, 40, 65);
        this.cmbFbActivity.ForeColor     = Color.White;
        this.cmbFbActivity.FlatStyle     = FlatStyle.Flat;
        this.cmbFbActivity.Font          = new Font("Segoe UI", 10F);
        this.cmbFbActivity.DropDownStyle = ComboBoxStyle.DropDownList;

        this.lblRating.Text      = "Overall Rating (1–5)";
        this.lblRating.Font      = new Font("Segoe UI", 9F);
        this.lblRating.ForeColor = Color.Silver;
        this.lblRating.Location  = new Point(20, 85);
        this.lblRating.AutoSize  = true;

        this.nudRating.Location  = new Point(20, 107);
        this.nudRating.Size      = new Size(80, 28);
        this.nudRating.Minimum   = 1;
        this.nudRating.Maximum   = 5;
        this.nudRating.Value     = 5;
        this.nudRating.BackColor = Color.FromArgb(40, 40, 65);
        this.nudRating.ForeColor = Color.White;
        this.nudRating.Font      = new Font("Segoe UI", 12F, FontStyle.Bold);

        this.lblComments.Text      = "Detailed Comments";
        this.lblComments.Font      = new Font("Segoe UI", 9F);
        this.lblComments.ForeColor = Color.Silver;
        this.lblComments.Location  = new Point(20, 150);
        this.lblComments.AutoSize  = true;

        this.txtComments.Location    = new Point(20, 172);
        this.txtComments.Size        = new Size(820, 160);
        this.txtComments.Multiline   = true;
        this.txtComments.BackColor   = Color.FromArgb(40, 40, 65);
        this.txtComments.ForeColor   = Color.White;
        this.txtComments.BorderStyle = BorderStyle.FixedSingle;
        this.txtComments.Font        = new Font("Segoe UI", 10F);
        this.txtComments.ScrollBars  = ScrollBars.Vertical;

        this.btnSubmitFb.Text                      = "SUBMIT FEEDBACK";
        this.btnSubmitFb.Location                  = new Point(20, 345);
        this.btnSubmitFb.Size                      = new Size(200, 40);
        this.btnSubmitFb.BackColor                 = Color.FromArgb(212, 175, 55);
        this.btnSubmitFb.ForeColor                 = Color.FromArgb(18, 18, 30);
        this.btnSubmitFb.FlatStyle                 = FlatStyle.Flat;
        this.btnSubmitFb.FlatAppearance.BorderSize = 0;
        this.btnSubmitFb.Font                      = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnSubmitFb.Cursor                    = Cursors.Hand;
        this.btnSubmitFb.Click                    += new EventHandler(this.btnSubmitFb_Click);

        this.pnlFeedbackForm.Controls.AddRange(new Control[]
            { lblFbActivity, cmbFbActivity, lblRating, nudRating, lblComments, txtComments, btnSubmitFb });

        // ── Form ──────────────────────────────────────────────────
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode       = AutoScaleMode.Font;
        this.ClientSize          = new Size(1060, 660);
        this.Controls.Add(this.pnlContent);
        this.Controls.Add(this.pnlSidebar);
        this.FormBorderStyle     = FormBorderStyle.Sizable;
        this.MinimumSize         = new Size(1060, 660);
        this.Name                = "FrmCustomerDashboard";
        this.StartPosition       = FormStartPosition.CenterScreen;
        this.Text                = "LUXESCAPE – Customer Portal";
        this.BackColor           = Color.FromArgb(18, 18, 30);
        this.WindowState         = FormWindowState.Maximized;
    }

    private Panel    pnlSidebar, pnlContent, pnlTopBar;
    private Panel    pnlActivities, pnlMyBookings, pnlFeedbackForm;
    private Label    lblLogo, lblPageTitle, lblWelcome;
    private Button   btnActivities, btnMyBookings, btnFeedback, btnLogout;
    private Label    lblActSearch;
    private TextBox  txtSearch;
    private Button   btnSearch, btnBook;
    private ListView lvActivities;
    private ColumnHeader colActName, colActDate, colActPrice, colActSeats;
    private ListView lvMyBookings;
    private ColumnHeader colBkgId, colBkgActivity, colBkgDate, colBkgStatus, colBkgTxn;
    private Label    lblFbActivity, lblRating, lblComments;
    private ComboBox cmbFbActivity;
    private NumericUpDown nudRating;
    private TextBox  txtComments;
    private Button   btnSubmitFb;
}

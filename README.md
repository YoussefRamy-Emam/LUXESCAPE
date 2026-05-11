# LUXESCAPE – Desktop Activity Booking System
**CS341 Final Lab Project | Spring 2026 | Misr University for Science and Technology**

---

## Project Structure

```
LUXESCAPE/
├── LUXESCAPE.sln                  ← Open this in Visual Studio
├── LUXESCAPE_Database.sql         ← Run this in SQL Server first
└── LUXESCAPE/
    ├── LUXESCAPE.csproj
    ├── Program.cs                 ← Entry point → FrmLogin
    ├── DatabaseHelper.cs          ← SQL Server connection (update conn string)
    └── Forms/
        ├── FrmLogin               ← Login screen (Customer & Manager)
        ├── FrmRegister            ← Customer registration
        ├── FrmCustomerDashboard   ← Browse activities, My Bookings, Feedback
        ├── FrmPayment             ← Secure payment gateway screen
        ├── FrmBookingConfirmation ← Post-payment confirmation + Transaction ID
        └── FrmManagerDashboard    ← CRUD activities + Reports & Analytics
```

---

## Setup Instructions

### 1. Database
1. Open **SQL Server Management Studio**
2. Run `LUXESCAPE_Database.sql` to create the database and seed data
3. Note your SQL Server instance name (e.g. `localhost\SQLEXPRESS`)

### 2. Connection String
Open `DatabaseHelper.cs` and update the connection string:
```csharp
"Server=YOUR_SERVER;Database=LUXESCAPE_DB;Trusted_Connection=True;TrustServerCertificate=True;"
```

### 3. NuGet Package
The project requires `Microsoft.Data.SqlClient`. Visual Studio will restore it
automatically when you build. If not, run in Package Manager Console:
```
Install-Package Microsoft.Data.SqlClient
```

### 4. Run
Press **F5** in Visual Studio. The app starts at `FrmLogin`.
- Login with `manager@...` email → goes to Manager Dashboard
- Any other email → goes to Customer Dashboard

---

## TODO markers for your implementation
Every method that needs a real DB call is marked with `// TODO:` comments.
Search the solution for `TODO` (Ctrl+Shift+F) to find all integration points.

Key areas:
| Form | TODO |
|------|------|
| `FrmLogin` | Query Users table, validate credentials, get Role |
| `FrmRegister` | Hash password, INSERT into Users |
| `FrmCustomerDashboard` | Load activities from DB, load bookings |
| `FrmPayment` | Call real payment gateway, INSERT Booking + Payment |
| `FrmManagerDashboard` | Full CRUD on Activities, load KPIs and Feedback |

---

## System Design Mapping
| UML Artifact | Implementation |
|---|---|
| Use Case: Customer Login | `FrmLogin.btnLogin_Click` |
| Use Case: Register | `FrmRegister` |
| Use Case: View Activities | `FrmCustomerDashboard.LoadActivities()` |
| Use Case: Book (incl. Payment) | `FrmCustomerDashboard.btnBook_Click` → `FrmPayment` |
| Use Case: Confirmation (Fork & Join) | `FrmPayment.btnPay_Click` → parallel DB + email |
| Use Case: Feedback | `FrmCustomerDashboard.btnSubmitFb_Click` |
| Use Case: Manage Activities | `FrmManagerDashboard` CRUD methods |
| Use Case: View Reports | `FrmManagerDashboard.LoadReports()` |
| Class: User / Admin (inheritance) | `Users` table `Role` column |
| Composition: Booking ↔ Payment | `Payments.BookingID` FK |
| Association: User → Feedback (1:N) | `Feedback.UserID` FK |

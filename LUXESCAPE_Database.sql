-- ============================================================
-- LUXESCAPE Database Schema
-- SQL Server 2019
-- CS341 Final Lab Project – Spring 2026
-- ============================================================

CREATE DATABASE LUXESCAPE_DB;
GO

USE LUXESCAPE_DB;
GO

-- Users (base entity; Admin inherits via Role flag)
CREATE TABLE Users (
    UserID       INT            IDENTITY(1,1) PRIMARY KEY,
    FullName     NVARCHAR(100)  NOT NULL,
    Email        NVARCHAR(150)  NOT NULL UNIQUE,
    PhoneNumber  NVARCHAR(20),
    PasswordHash NVARCHAR(256)  NOT NULL,
    Role         NVARCHAR(20)   NOT NULL DEFAULT 'Customer',  -- 'Customer' | 'Manager'
    CreatedAt    DATETIME       NOT NULL DEFAULT GETDATE()
);

-- Activities
CREATE TABLE Activities (
    ActivityID       INT            IDENTITY(1,1) PRIMARY KEY,
    Title            NVARCHAR(200)  NOT NULL,
    Description      NVARCHAR(MAX),
    DateTime         DATETIME       NOT NULL,
    Price            DECIMAL(10,2)  NOT NULL,
    SeatsAvailable   INT            NOT NULL,
    IsActive         BIT            NOT NULL DEFAULT 1,
    CreatedAt        DATETIME       NOT NULL DEFAULT GETDATE()
);

-- Bookings
CREATE TABLE Bookings (
    BookingID    INT            IDENTITY(1,1) PRIMARY KEY,
    UserID       INT            NOT NULL REFERENCES Users(UserID),
    ActivityID   INT            NOT NULL REFERENCES Activities(ActivityID),
    Status       NVARCHAR(20)   NOT NULL DEFAULT 'Pending',   -- 'Pending' | 'Confirmed' | 'Cancelled'
    BookedAt     DATETIME       NOT NULL DEFAULT GETDATE()
);

-- Payments  (Composition: Booking cannot exist without Payment record)
CREATE TABLE Payments (
    PaymentID     INT            IDENTITY(1,1) PRIMARY KEY,
    BookingID     INT            NOT NULL REFERENCES Bookings(BookingID),
    Amount        DECIMAL(10,2)  NOT NULL,
    TransactionID NVARCHAR(50)   NOT NULL UNIQUE,
    PaidAt        DATETIME       NOT NULL DEFAULT GETDATE(),
    Status        NVARCHAR(20)   NOT NULL DEFAULT 'Success'   -- 'Success' | 'Failed'
);

-- Feedback  (One-to-Many: User → many Feedback rows)
CREATE TABLE Feedback (
    FeedbackID   INT            IDENTITY(1,1) PRIMARY KEY,
    UserID       INT            NOT NULL REFERENCES Users(UserID),
    ActivityID   INT            NOT NULL REFERENCES Activities(ActivityID),
    Rating       TINYINT        NOT NULL CHECK (Rating BETWEEN 1 AND 5),
    Comments     NVARCHAR(MAX),
    SubmittedAt  DATETIME       NOT NULL DEFAULT GETDATE()
);

-- ── Sample seed data ─────────────────────────────────────────
-- (Passwords shown as plaintext for development; hash before production)

INSERT INTO Users (FullName, Email, PhoneNumber, PasswordHash, Role) VALUES
('Admin Manager',  'manager@luxescape.com', '01001234567', 'HASH_ME', 'Manager'),
('Omar Gamal',     'omar@example.com',      '01112233445', 'HASH_ME', 'Customer'),
('Sara Ali',       'sara@example.com',      '01098765432', 'HASH_ME', 'Customer');

INSERT INTO Activities (Title, Description, DateTime, Price, SeatsAvailable) VALUES
('Desert Safari at Sinai',    'Full-day desert adventure with 4x4 jeeps.', '2026-06-10 09:00', 1200.00, 14),
('Nile Dinner Cruise',        'Three-hour cruise with live entertainment.', '2026-06-12 19:30',  850.00, 30),
('Pyramid Sound & Light Show','Immersive history experience at Giza.',      '2026-06-15 20:00',  650.00, 50),
('Snorkeling – Red Sea',      'Guided snorkeling tour in Sharm.',           '2026-06-18 08:00', 1500.00,  8),
('Hot Air Balloon – Luxor',   'Sunrise balloon flight over Luxor temples.',  '2026-06-20 06:00', 2200.00,  6);
GO

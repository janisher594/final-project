/* MS Access SQL - create tables for Public Market Stall Rental */
CREATE TABLE Vendors (
    VendorID AUTOINCREMENT PRIMARY KEY,
    VendorName TEXT(100),
    ContactNo TEXT(30),
    Address TEXT(150),
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);

CREATE TABLE Stalls (
    StallID AUTOINCREMENT PRIMARY KEY,
    StallNo TEXT(10),
    Location TEXT(100),
    RentRate CURRENCY,
    Status TEXT(20),
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);

CREATE TABLE Rentals (
    RentalID AUTOINCREMENT PRIMARY KEY,
    VendorID LONG,
    StallID LONG,
    StartDate DATETIME,
    EndDate DATETIME,
    AmountPaid CURRENCY,
    ORNo TEXT(20),
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);

/* Create simple indexes */
CREATE INDEX IDX_Vendors_Name ON Vendors (VendorName);
CREATE INDEX IDX_Stalls_No ON Stalls (StallNo);
CREATE INDEX IDX_Rentals_Vendor_Start ON Rentals (VendorID, StartDate);

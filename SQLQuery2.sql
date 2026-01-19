CREATE TABLE Medicine
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    mId NVARCHAR(50),
    mName NVARCHAR(100),
    mCompanyName NVARCHAR(100),
    mNumber NVARCHAR(50),
    mDate  NVARCHAR(50),
    eDate  NVARCHAR(50),
    quantity INT,
    pricePerUnit DECIMAL(10,2)
);

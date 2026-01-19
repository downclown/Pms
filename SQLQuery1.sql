CREATE TABLE UserAccounts
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    fullname VARCHAR(100) NOT NULL,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    phoneNumber VARCHAR(20),
    email VARCHAR(100) UNIQUE,
    usertype NVARCHAR(20) NOT NULL
);


--UserAccounts

select * from UserAccounts


CREATE DATABASE UserInfoBD;
GO

USE UserInfoBD;
GO

CREATE TABLE Role (
    RoleID INT PRIMARY KEY IDENTITY(1,1),
    RoleName NVARCHAR(50) NOT NULL
);

CREATE TABLE [User] (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(50) NOT NULL,
    RoleID INT,
    CONSTRAINT FK_User_Role FOREIGN KEY (RoleID)
        REFERENCES Role (RoleID)
);

CREATE TABLE Address (
    AddressID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT,
    Street NVARCHAR(50) NOT NULL,
    City NVARCHAR(30) NOT NULL,
    ZipCode NVARCHAR(20) NOT NULL,
    CONSTRAINT FK_Address_User FOREIGN KEY (UserID)
        REFERENCES [User] (UserID)
);

INSERT INTO Role (RoleName) VALUES 
('SuperAdmin'),
('Admin'), 
('User'), 
('Guest');

INSERT INTO [User] (UserName, Email, RoleID) VALUES 
('Alex', 'alex@example.com', 1),
('Bob', 'bob@example.com', 2),
('Cuan', 'cuan@example.com', 3),
('Dilan', 'cuan@example.com', 4);

INSERT INTO Address (UserID, Street, City, ZipCode) VALUES 
(1, 'Main St', 'GitTown', '220050'),
(2, 'Origin St', 'GitCity', '220051'),
(3, 'Branch St', 'GitCountry', '220052'),
(4, 'Commit St', 'Othertown', '220053');


USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'Roadrunner Rentals')
BEGIN
    ALTER DATABASE [Roadrunner Rentals]
    SET SINGLE_USER
    WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [Roadrunner Rentals];
END
GO

CREATE DATABASE [Roadrunner Rentals];
GO

USE [Roadrunner Rentals];
GO

CREATE TABLE Vehicle_Class(
    Vehicle_Class_ID int IDENTITY(1,1) PRIMARY KEY,
    ClassName varchar(15),
    Description varchar(100)
);


CREATE TABLE Client(
    Client_ID int IDENTITY(1,1) PRIMARY KEY,
    Client_ID_Number char(13),
    LastName varchar(25),
    FirstName varchar(25),
    CellNumber char(10),
    Email varchar(25),
    HasDriversLicense bit
);


CREATE TABLE Users(
    User_ID int IDENTITY(1,1) PRIMARY KEY,
    Username varchar(25),
    Lastname varchar(25),
    FirstName varchar(25),
    Cellnumber char(10)
);


CREATE TABLE Vehicle(
    Vehicle_ID int IDENTITY(1,1) PRIMARY KEY,
    Vehicle_Class_ID int FOREIGN KEY REFERENCES Vehicle_Class(Vehicle_Class_ID),
    Vehicle_Name varchar(25),
    Year date,
    NumberOfSeats int,
    CostPerDay money,
    LicenseNumber char(10),
    InUse bit
);

CREATE TABLE RentalOrder(
    Order_ID int IDENTITY(1,1) PRIMARY KEY,
    Client_ID int FOREIGN KEY REFERENCES Client(Client_ID),
    User_ID int FOREIGN KEY REFERENCES Users(User_ID),
    Vehicle_ID int FOREIGN KEY REFERENCES Vehicle(Vehicle_ID),
    Time time,
    OrderCost money,
    TimeRented int,
    Paid bit,
    VehicleReturned bit,
    Date date
);


INSERT INTO Vehicle_Class (ClassName, Description)
VALUES
('Economy', 'Small and fuel-efficient cars'),
('Compact', 'Compact size cars with good mileage'),
('Midsize', 'Midsize cars with comfortable seating'),
('Fullsize', 'Fullsize cars with spacious interiors'),
('SUV', 'Sport Utility Vehicles'),
('Luxury', 'Luxury vehicles with high-end features'),
('Convertible', 'Cars with retractable roofs'),
('Truck', 'Large vehicles for transporting goods'),
('Van', 'Multi-purpose vehicles with large seating capacity'),
('Electric', 'Electric-powered vehicles');


INSERT INTO Client (Client_ID_Number, LastName, FirstName, CellNumber, Email, HasDriversLicense)
VALUES
('1234567890123', 'Smith', 'John', '0111234567', 'john.smith@example.com', 1),
('2345678901234', 'Doe', 'Jane', '0122345678', 'jane.doe@example.com', 1),
('3456789012345', 'Brown', 'Charlie', '0121345678', 'charlie.brown@example.com', 1),
('4567890123456', 'Johnson', 'Emily', '0122456789', 'emily.johnson@example.com', 1),
('5678901234567', 'Taylor', 'Chris', '071678901', 'chris.taylor@example.com', 1),
('6789012345678', 'Lee', 'Anna', '0606789012', 'anna.lee@example.com', 1),
('7890123456789', 'Will', 'Michael', '0727890123', 'michael.will@example.com', 1),
('8901234567890', 'Moore', 'Jessica', '0828901234', 'jessica.moore@example.com', 1),
('9012345678901', 'White', 'David', '0839012345', 'david.white@example.com', 1),
('0123456789012', 'Davis', 'Sarah', '0601123456', 'sarah.davis@example.com', 1);


INSERT INTO Users (Username, Lastname, FirstName, Cellnumber)
VALUES
('admin', 'Admin', 'System', '0110000000'),
('jdoe', 'Doe', 'John', '0121111111'),
('asmith', 'Smith', 'Anna', '0212222222'),
('ebrown', 'Brown', 'Emily', '0183333333'),
('cjones', 'Jones', 'Chris', '0014444444'),
('ajohnson', 'Johnson', 'Andrew', '0605555555'),
('swilson', 'Wilson', 'Samantha', '0726666666'),
('pmiller', 'Miller', 'Paul', '0977777777'),
('klee', 'Lee', 'Kim', '0918888888'),
('lmorris', 'Morris', 'Liam', '0129999999');


INSERT INTO Vehicle (Vehicle_Class_ID, Vehicle_Name, Year, NumberOfSeats, CostPerDay, LicenseNumber, InUse)
VALUES
(1, 'Yaris', '2021-01-01', 5, 1000.00, 'ABC1234567',0),
(2, 'Civic', '2020-01-01', 5, 1500.00, 'XYZ1234567',0),
(3, 'Fusion', '2019-01-01', 5, 1200.00, 'LMN1234567',0),
(4, 'Impala', '2018-01-01', 5, 1300.00, 'QRS1234567',0),
(5, 'Explorer', '2021-01-01', 7, 1000.00, 'DEF1234567',1),
(6, 'EClass', '2020-01-01', 5, 1600.00, 'TUV1234567',0),
(7, 'MX5', '2019-01-01', 2, 1300.00, 'GHI1234567',1),
(8, 'F150', '2022-01-01', 5, 1200.00, 'JKL1234567',0),
(9, 'Odyssey', '2020-01-01', 8, 1250.00, 'OPQ1234567',0),
(10, 'Model3', '2022-01-01', 5, 2000.00, 'RST1234567',0);

INSERT INTO RentalOrder (Client_ID, User_ID, Vehicle_ID, Time, OrderCost, TimeRented, Paid, VehicleReturned, Date)
VALUES
(1, 2, 1, '10:00:00', (SELECT CostPerDay FROM Vehicle WHERE Vehicle_ID = 1) * 3, 3, 1, 1, '2024-08-01'),
(2, 3, 2, '11:00:00', (SELECT CostPerDay FROM Vehicle WHERE Vehicle_ID = 2) * 2, 2, 1, 1, '2024-08-02'),
(3, 4, 3, '12:00:00', (SELECT CostPerDay FROM Vehicle WHERE Vehicle_ID = 3) * 3, 3, 1, 1, '2024-08-03'),
(4, 5, 4, '13:00:00', (SELECT CostPerDay FROM Vehicle WHERE Vehicle_ID = 4) * 4, 4, 1, 1, '2024-08-04'),
(5, 6, 5, '14:00:00', (SELECT CostPerDay FROM Vehicle WHERE Vehicle_ID = 5) * 4, 4, 1, 0, '2024-08-05'),
(6, 7, 6, '15:00:00', (SELECT CostPerDay FROM Vehicle WHERE Vehicle_ID = 6) * 5, 5, 1, 1, '2024-08-06'),
(7, 8, 7, '16:00:00', (SELECT CostPerDay FROM Vehicle WHERE Vehicle_ID = 7) * 2, 2, 1, 0, '2024-08-07'),
(8, 9, 8, '17:00:00', (SELECT CostPerDay FROM Vehicle WHERE Vehicle_ID = 8) * 2, 2, 1, 1, '2024-08-08'),
(9, 10, 9, '18:00:00', (SELECT CostPerDay FROM Vehicle WHERE Vehicle_ID = 9) * 3, 3, 1, 1, '2024-08-09'),
(10, 1, 10, '19:00:00', (SELECT CostPerDay FROM Vehicle WHERE Vehicle_ID = 10) * 4, 4, 1, 1, '2024-08-10');
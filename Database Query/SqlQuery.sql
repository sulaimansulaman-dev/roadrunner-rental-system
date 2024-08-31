CREATE TABLE Vehicle_Class(
    Vehicle_Class_ID int IDENTITY(1,1) PRIMARY KEY,
    ClassName varchar(15),
    Description varchar(50),
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
    Cellnumber char(10),
    );

CREATE TABLE Vehicle(
    Vehicle_ID int IDENTITY(1,1) PRIMARY KEY,
    Vehicle_Class_ID int FOREIGN KEY REFERENCES Vehicle_Class(Vehicle_Class_ID),
    Year date,
    NumberOfSeats int,
    CostPerDay money,
    LicenseNumber char(10),
    ImageOfVehicle image
    );

CREATE TABLE RentalOrder(
    Order_ID int IDENTITY(1,1) PRIMARY KEY,
    Client_ID int FOREIGN KEY REFERENCES Client(Client_ID),
    User_ID int FOREIGN KEY REFERENCES Users(User_ID),
    Vehicle_ID int FOREIGN KEY REFERENCES Vehicle(Vehicle_ID),
    Time time,
    OrderCost money,
    TimeRented datetime,
    Paid bit,
    VehicleReturned bit,
    Date date
    );
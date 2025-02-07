--Create Clients Table:
CREATE TABLE Clients
(
    ClientName VARCHAR(50),
    ClientPassword VARCHAR(50),
    Role VARCHAR(50),
    Feedback VARCHAR(255)
);
--Create Admins Table:
CREATE TABLE Admins
(
    AdminName VARCHAR(50),
    AdminPassword VARCHAR(50),
    Role VARCHAR(50)
);
--Create Staff Table:
CREATE TABLE Staff
(
    StaffName VARCHAR(50),
    StaffID VARCHAR(50),
    StaffDesignation VARCHAR(50),
    StaffSalary float
);
--Create Flights Table:
CREATE TABLE Flights
(
    FlightID VARCHAR(50),
    FlightName VARCHAR(50),
    Source VARCHAR(50),
    Destination VARCHAR(50),
    TravelDate VARCHAR(50),
    TakeoffTime VARCHAR(50),
    Price float,
    Seats float,
Discount float
);
--Create ReservedFlights Table:
CREATE TABLE ReservedFlights
(
    FlightID VARCHAR(50),
    ClientName VARCHAR(50)
);
CREATE TABLE MembershipCard (
    CardNumber VARCHAR(20),
    MemberName VARCHAR(100),
    MembershipTier VARCHAR(20)
);
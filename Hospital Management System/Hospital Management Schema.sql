
--Create table Department
create table Department
(
DepartmentID VARCHAR(50) Primary Key,
DepartmentName VARCHAR(50)
);

--Department Log Table
create Table DepartmentLog
(
LogID INT IDENTITY(1,1) PRIMARY KEY,
DepartmentID VARCHAR(50),
DepartmentName VARCHAR(50),
OperationType VARCHAR(50),            
OperationTime DATETIME DEFAULT GETDATE(),  
ModifiedBy VARCHAR(100) DEFAULT SUSER_NAME() 
);

--Trigger For Department Table Logging
GO
CREATE TRIGGER DepartmentLogging
ON Department
AFTER INSERT,UPDATE,DELETE
AS BEGIN
if EXISTS(SELECT 1 FROM inserted) AND NOT EXISTS(SELECT 1 FROM deleted)
	BEGIN
	INSERT INTO DepartmentLog(DepartmentID,DepartmentName,OperationType)
	SELECT i.DepartmentID,i.DepartmentName,'INSERT' FROM inserted i;
	END
if EXISTS(SELECT 1 FROM inserted) AND EXISTS(SELECT 1 FROM deleted)
	BEGIN
	INSERT INTO DepartmentLog(DepartmentID,DepartmentName,OperationType)
	SELECT i.DepartmentID,i.DepartmentName,'UPDATE' FROM inserted i
	INNER JOIN deleted d ON i.DepartmentID=d.DepartmentID;
	END
if EXISTS(SELECT 1 FROM deleted) AND NOT EXISTS(SELECT 1 FROM inserted)
	BEGIN
	INSERT INTO DepartmentLog(DepartmentID,DepartmentName,OperationType)
	SELECT d.DepartmentID,d.DepartmentName,'DELETE' FROM deleted d;
	END
END;


--Create table Room
create table Room
(
RoomID VARCHAR(50) PRIMARY KEY,
DepartmentID VARCHAR(50),
FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID),
TotalBeds INT,
AvailableBeds INT
);


--Create Table Room Log
CREATE TABLE RoomLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    RoomID VARCHAR(50),
    DepartmentID VARCHAR(50),
    TotalBeds INT,
    AvailableBeds INT,
    OperationType VARCHAR(50),
    OperationTime DATETIME DEFAULT GETDATE(),
    ModifiedBy VARCHAR(100) DEFAULT SUSER_NAME()
);

--Trigger For Room Table Logging
GO
CREATE TRIGGER RoomLogging
ON Room
AFTER INSERT, UPDATE, DELETE
AS BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO RoomLog (RoomID, DepartmentID, TotalBeds, AvailableBeds, OperationType)
        SELECT i.RoomID, i.DepartmentID, i.TotalBeds, i.AvailableBeds, 'INSERT' FROM inserted i;
    END
    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO RoomLog (RoomID, DepartmentID, TotalBeds, AvailableBeds, OperationType)
        SELECT i.RoomID, i.DepartmentID, i.TotalBeds, i.AvailableBeds, 'UPDATE' FROM inserted i;
    END
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO RoomLog (RoomID, DepartmentID, TotalBeds, AvailableBeds, OperationType)
        SELECT d.RoomID, d.DepartmentID, d.TotalBeds, d.AvailableBeds, 'DELETE' FROM deleted d;
    END
END;


--Create table Admin
create table Admin
(
AdminID VARCHAR(50) PRIMARY KEY,
LoginPassword VARCHAR(50),
AdminName VARCHAR(50),
PhoneNumber VARCHAR(50),
Email VARCHAR(50)
);

--Log Table for Admin
CREATE TABLE AdminLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    AdminID VARCHAR(50),
    AdminName VARCHAR(50),
    PhoneNumber VARCHAR(50),
    Email VARCHAR(50),
    OperationType VARCHAR(50),
    OperationTime DATETIME DEFAULT GETDATE(),
    ModifiedBy VARCHAR(100) DEFAULT SUSER_NAME()
);

--Trigger For Admin Table Logging
GO
CREATE TRIGGER AdminLogging
ON Admin
AFTER INSERT, UPDATE, DELETE
AS BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO AdminLog (AdminID, AdminName, PhoneNumber, Email, OperationType)
        SELECT i.AdminID, i.AdminName, i.PhoneNumber, i.Email, 'INSERT' FROM inserted i;
    END
    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO AdminLog (AdminID, AdminName, PhoneNumber, Email, OperationType)
        SELECT i.AdminID, i.AdminName, i.PhoneNumber, i.Email, 'UPDATE' FROM inserted i;
    END
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO AdminLog (AdminID, AdminName, PhoneNumber, Email, OperationType)
        SELECT d.AdminID, d.AdminName, d.PhoneNumber, d.Email, 'DELETE' FROM deleted d;
    END
END;



--Create table Nurse
create table Nurse
(
NurseID VARCHAR(50) PRIMARY KEY,
NurseName VARCHAR(50),
DepartmentID VARCHAR(50),
FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID),
PhoneNumber VARCHAR(50),
Salary FLOAT
);

--Log Table for Nurse
CREATE TABLE NurseLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    NurseID VARCHAR(50),
    NurseName VARCHAR(50),
    DepartmentID VARCHAR(50),
    PhoneNumber VARCHAR(50),
    Salary FLOAT,
    OperationType VARCHAR(50),
    OperationTime DATETIME DEFAULT GETDATE(),
    ModifiedBy VARCHAR(100) DEFAULT SUSER_NAME()
);

--Trigger For Nurse Table Logging
GO
CREATE TRIGGER NurseLogging
ON Nurse
AFTER INSERT, UPDATE, DELETE
AS BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO NurseLog (NurseID, NurseName, DepartmentID, PhoneNumber, Salary, OperationType)
        SELECT i.NurseID, i.NurseName, i.DepartmentID, i.PhoneNumber, i.Salary, 'INSERT' FROM inserted i;
    END
    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO NurseLog (NurseID, NurseName, DepartmentID, PhoneNumber, Salary, OperationType)
        SELECT i.NurseID, i.NurseName, i.DepartmentID, i.PhoneNumber, i.Salary, 'UPDATE' FROM inserted i;
    END
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO NurseLog (NurseID, NurseName, DepartmentID, PhoneNumber, Salary, OperationType)
        SELECT d.NurseID, d.NurseName, d.DepartmentID, d.PhoneNumber, d.Salary, 'DELETE' FROM deleted d;
    END
END;


--Create Table Patient
create table Patient
(
PatientID VARCHAR(50) PRIMARY KEY,
LoginPassword VARCHAR(50),
PatientName VARCHAR(50),
DOB DATE,
Gender VARCHAR(50),
PhoneNumber VARCHAR(50)
);

--Log Table For Patient
CREATE TABLE PatientLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
	PatientID VARCHAR(50),
	LoginPassword VARCHAR(50),
    PatientName VARCHAR(50),
    DOB DATE,
	Gender VARCHAR(50),
	PhoneNumber VARCHAR(50),
    OperationType VARCHAR(50),
    OperationTime DATETIME DEFAULT GETDATE(),
    ModifiedBy VARCHAR(100) DEFAULT SUSER_NAME()
);

--Trigger For Patient Table Logging
GO
CREATE TRIGGER PatientLogging
ON Patient
AFTER INSERT, UPDATE, DELETE
AS BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO PatientLog (PatientID, LoginPassword,PatientName, DOB, Gender, PhoneNumber, OperationType)
        SELECT i.PatientID,i.LoginPassword, i.PatientName, i.DOB, i.Gender, i.PhoneNumber, 'INSERT' FROM inserted i;
    END
    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO PatientLog (PatientID,LoginPassword, PatientName, DOB, Gender, PhoneNumber, OperationType)
        SELECT i.PatientID,i.LoginPassword, i.PatientName, i.DOB, i.Gender, i.PhoneNumber, 'UPDATE' FROM inserted i;
    END
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO PatientLog (PatientID,i.LoginPassword, PatientName, DOB, Gender, PhoneNumber, OperationType)
        SELECT d.PatientID,d.LoginPassword, d.PatientName, d.DOB, d.Gender, d.PhoneNumber, 'DELETE' FROM deleted d;
    END
END;




--Create Table Doctor
create table Doctor
(
DoctorID VARCHAR(50) PRIMARY KEY,
LoginPassword VARCHAR(50),
DoctorName VARCHAR(50),
Specialization VARCHAR(50),
Email VARCHAR(50),
PhoneNumber VARCHAR(50),
Salary FLOAT
);

--Log table For Doctor
CREATE TABLE DoctorLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    DoctorID VARCHAR(50),
    DoctorName VARCHAR(50),
    Specialization VARCHAR(100),
    PhoneNumber VARCHAR(50),
    Salary FLOAT,
    OperationType VARCHAR(50),
    OperationTime DATETIME DEFAULT GETDATE(),
    ModifiedBy VARCHAR(100) DEFAULT SUSER_NAME()
);

--Trigger for logging Doctor table
GO
CREATE TRIGGER DoctorLogging
ON Doctor
AFTER INSERT, UPDATE, DELETE
AS BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO DoctorLog (DoctorID, DoctorName, Specialization, PhoneNumber, Salary, OperationType)
        SELECT i.DoctorID, i.DoctorName, i.Specialization, i.PhoneNumber, i.Salary, 'INSERT' FROM inserted i;
    END
    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO DoctorLog (DoctorID, DoctorName, Specialization, PhoneNumber, Salary, OperationType)
        SELECT i.DoctorID, i.DoctorName, i.Specialization, i.PhoneNumber, i.Salary, 'UPDATE' FROM inserted i;
    END
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO DoctorLog (DoctorID, DoctorName, Specialization, PhoneNumber, Salary, OperationType)
        SELECT d.DoctorID, d.DoctorName, d.Specialization, d.PhoneNumber, d.Salary, 'DELETE' FROM deleted d;
    END
END;



--Create Table Appointment
create table Appointment
(
AppointmentID VARCHAR(50) PRIMARY KEY,
PatientID VARCHAR(50),
FOREIGN KEY (PatientID) REFERENCES Patient(PatientID),
DoctorID VARCHAR(50),
FOREIGN KEY (DoctorID) REFERENCES Doctor(DoctorID),
AppointmentDate Date,
AppointmentTime Time
);

--Log Table for Appointment
CREATE TABLE AppointmentLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    AppointmentID VARCHAR(50),
    PatientID VARCHAR(50),
    DoctorID VARCHAR(50),
    AppointmentDate DATETIME,
    AppointmentTime TIME,
    OperationType VARCHAR(50),
    OperationTime DATETIME DEFAULT GETDATE(),
    ModifiedBy VARCHAR(100) DEFAULT SUSER_NAME()
);

--Trigger for logging of Appointment Table
GO
CREATE TRIGGER AppointmentLogging
ON Appointment
AFTER INSERT, UPDATE, DELETE
AS BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO AppointmentLog (AppointmentID, PatientID, DoctorID, AppointmentDate, AppointmentTime, OperationType)
        SELECT i.AppointmentID, i.PatientID, i.DoctorID, i.AppointmentDate, i.AppointmentTime, 'INSERT' FROM inserted i;
    END
    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO AppointmentLog (AppointmentID, PatientID, DoctorID, AppointmentDate, AppointmentTime, OperationType)
        SELECT i.AppointmentID, i.PatientID, i.DoctorID, i.AppointmentDate, i.AppointmentTime, 'UPDATE' FROM inserted i;
    END
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO AppointmentLog (AppointmentID, PatientID, DoctorID, AppointmentDate, AppointmentTime, OperationType)
        SELECT d.AppointmentID, d.PatientID, d.DoctorID, d.AppointmentDate, d.AppointmentTime, 'DELETE' FROM deleted d;
    END
END;


--Create Table Prescription
create table Prescription
(
PrescriptionID VARCHAR(50) PRIMARY KEY,
PatientID VARCHAR(50),
FOREIGN KEY (PatientID) REFERENCES Patient(PatientID),
DoctorID VARCHAR(50),
FOREIGN KEY (DoctorID) REFERENCES Doctor(DoctorID),
Dosage VARCHAR(150),
Medicine VARCHAR(150),
DoctorRemarks VARCHAR(250)
);


--Log table for prescription
CREATE TABLE PrescriptionLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    PrescriptionID VARCHAR(50),
    PatientID VARCHAR(50),
    DoctorID VARCHAR(50),
    Dosage VARCHAR(150),
    Medicine VARCHAR(150),
    DoctorRemarks VARCHAR(250),
    OperationType VARCHAR(50),
    OperationTime DATETIME DEFAULT GETDATE(),
    ModifiedBy VARCHAR(100) DEFAULT SUSER_NAME()
);


--Trigger For Logging Prescription
GO
CREATE TRIGGER PrescriptionLogging
ON Prescription
AFTER INSERT, UPDATE, DELETE
AS BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO PrescriptionLog (PrescriptionID, PatientID, DoctorID, Dosage, Medicine, DoctorRemarks, OperationType)
        SELECT i.PrescriptionID, i.PatientID, i.DoctorID, i.Dosage, i.Medicine, i.DoctorRemarks, 'INSERT'
        FROM inserted i;
    END

    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO PrescriptionLog (PrescriptionID, PatientID, DoctorID, Dosage, Medicine, DoctorRemarks, OperationType)
        SELECT i.PrescriptionID, i.PatientID, i.DoctorID, i.Dosage, i.Medicine, i.DoctorRemarks, 'UPDATE'
        FROM inserted i;
    END

    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO PrescriptionLog (PrescriptionID, PatientID, DoctorID, Dosage, Medicine, DoctorRemarks, OperationType)
        SELECT d.PrescriptionID, d.PatientID, d.DoctorID, d.Dosage, d.Medicine, d.DoctorRemarks, 'DELETE'
        FROM deleted d;
    END
END;


--Create PatientRoom Booking
create table PatientRoomBooking
(
RoomID VARCHAR(50),
FOREIGN KEY (RoomID) REFERENCES Room(RoomID),
PatientID VARCHAR(50),
FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
);

--Log Table For Patient Room Booking
CREATE TABLE PatientRoomBookingLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    RoomID VARCHAR(50),
    PatientID VARCHAR(50),
    OperationType VARCHAR(50),
    OperationTime DATETIME DEFAULT GETDATE(),
    ModifiedBy VARCHAR(100) DEFAULT SUSER_NAME()
);

--Trigger for Patient-RoomBooking Logging
GO
CREATE TRIGGER PatientRoomBookingLogging
ON PatientRoomBooking
AFTER INSERT, UPDATE, DELETE
AS BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO PatientRoomBookingLog (RoomID, PatientID, OperationType)
        SELECT i.RoomID, i.PatientID, 'INSERT' FROM inserted i;
    END

    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO PatientRoomBookingLog (RoomID, PatientID, OperationType)
        SELECT i.RoomID, i.PatientID, 'UPDATE' FROM inserted i;
    END

    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO PatientRoomBookingLog (RoomID, PatientID, OperationType)
        SELECT d.RoomID, d.PatientID, 'DELETE' FROM deleted d;
    END
END;


--Create Table DoctorSchedule
CREATE TABLE DoctorSchedule (
    ScheduleID VARCHAR(50) PRIMARY KEY,
    DoctorID VARCHAR(50),
    FOREIGN KEY (DoctorID) REFERENCES Doctor(DoctorID),
    AvailableDate DATE,
    StartTime TIME,
    EndTime TIME,
    Status VARCHAR(50) CHECK (Status IN ('Available', 'Booked'))
);

--DoctorSchedule Log Table
CREATE TABLE DoctorScheduleLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY, 
    ScheduleID VARCHAR(50),               
    DoctorID VARCHAR(50),
    AvailableDate DATE,
    StartTime TIME,
    EndTime TIME,
    Status VARCHAR(50),
    OperationType VARCHAR(50),            
    OperationTime DATETIME DEFAULT GETDATE(),  
    ModifiedBy VARCHAR(100) DEFAULT SUSER_NAME()  
);

--Trigger for backup and logging of DoctorSchedule Table
GO
create trigger DoctorScheduleLogging
ON DoctorSchedule
AFTER INSERT,UPDATE,DELETE
AS BEGIN
IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
BEGIN
INSERT INTO DoctorScheduleLog(ScheduleID,DoctorID,AvailableDate,StartTime,EndTime,Status,OperationType)
SELECT i.ScheduleID,i.DoctorID,i.AvailableDate,i.StartTime,i.EndTime,i.Status,'INSERT' FROM inserted i;
END
IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
BEGIN
INSERT INTO DoctorScheduleLog(ScheduleID,DoctorID,AvailableDate,StartTime,EndTime,Status,OperationType)
SELECT i.ScheduleID,i.DoctorID,i.AvailableDate,i.StartTime,i.EndTime,i.Status,'UPDATE' FROM inserted i
INNER JOIN deleted d on i.ScheduleID=d.ScheduleID;
END
IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
BEGIN
INSERT INTO DoctorScheduleLog(ScheduleID,DoctorID,AvailableDate,StartTime,EndTime,Status,OperationType)
SELECT d.ScheduleID,d.DoctorID,d.AvailableDate,d.StartTime,d.EndTime,d.Status,'DELETED' FROM deleted d;
END
END;

GO
CREATE TRIGGER  RestrictDeleteOnDoctorSchedule
ON DoctorSchedule AFTER DELETE AS
BEGIN
	IF EXISTS(
	SELECT 1 FROM deleted where DATEDIFF(DAY,GETDATE(),AvailableDate)<2
	)
	BEGIN
		ROLLBACK Transaction;
	RAISERROR('Cannot delete a schedule which is less than two days to come', 16, 1);
    END
END;


--Trigger For Automatically deleting past Doctor Schedules
GO
CREATE Trigger deletepastschedule
ON DoctorSchedule
AFTER INSERT,UPDATE
AS BEGIN
DELETE FROM DoctorSchedule
where AvailableDate<GetDATE() and
EndTime<CONVERT(TIME,GETDATE())
END;

--Testing
--Department Testing
INSERT INTO Department (DepartmentID, DepartmentName) 
VALUES ('DPT001', 'Cardiology');

UPDATE Department 
SET DepartmentName = 'Neurology' 
WHERE DepartmentID = 'DPT001';

DELETE FROM Department 
WHERE DepartmentID = 'DPT001';

select * FROM DepartmentLog

--Room Testing
INSERT INTO Room (RoomID, DepartmentID, TotalBeds, AvailableBeds) VALUES ('R001', 'DPT001', 20, 10);
UPDATE Room SET AvailableBeds = 8 WHERE RoomID = 'R001';
DELETE FROM Room WHERE RoomID = 'R001';
SELECT * FROM RoomLog;

--Admin Testing
INSERT INTO Admin (AdminID, LoginPassword, AdminName, PhoneNumber, Email) VALUES ('A001', 'pass123', 'John Doe', '1234567890', 'admin@example.com');
UPDATE Admin SET PhoneNumber = '0987654321' WHERE AdminID = 'A001';
DELETE FROM Admin WHERE AdminID = 'A001';
SELECT * FROM AdminLog;

--Nurse Testing
INSERT INTO Nurse (NurseID, NurseName, DepartmentID, PhoneNumber, Salary) VALUES ('N001', 'Alice Brown', 'DPT001', '9876543210', 50000);
UPDATE Nurse SET Salary = 52000 WHERE NurseID = 'N001';
DELETE FROM Nurse WHERE NurseID = 'N001';
SELECT * FROM NurseLog;

--Patient Testing
INSERT INTO Patient (PatientID, LoginPassword, PatientName, DOB, Gender, PhoneNumber) 
VALUES ('P004', 'pass123', 'Jane Doe', '1990-05-20', 'Female', '1234567890');

UPDATE Patient SET PhoneNumber = '0987654321' WHERE PatientID = 'P004';

DELETE FROM Patient WHERE PatientID = 'P004';

SELECT * FROM PatientLog;

--Doctor Testing
INSERT INTO Doctor (DoctorID, DoctorName, Specialization, PhoneNumber, Salary) 
VALUES ('D001', 'Dr. Smith', 'Cardiology', '1234567890', 100000);

UPDATE Doctor SET Salary = 110000 WHERE DoctorID = 'D001';

DELETE FROM Doctor WHERE DoctorID = 'D001';

SELECT * FROM DoctorLog;

--Appointment Testing
INSERT INTO Appointment (AppointmentID, PatientID, DoctorID, AppointmentDate, AppointmentTime) 
VALUES ('A001', 'P002', 'D001', '2024-02-07','10:00:00');

UPDATE Appointment SET AppointmentDate = '2025-02-07' WHERE AppointmentID = 'A001';

DELETE FROM Appointment WHERE AppointmentID = 'A001';

SELECT * FROM AppointmentLog;

--Prescription Testing
INSERT INTO Prescription (PrescriptionID, PatientID, DoctorID, Dosage, Medicine, DoctorRemarks) 
VALUES ('PR001', 'P002', 'D001', '1 tablet twice a day', 'Paracetamol', 'Take after meal');

UPDATE Prescription SET Dosage = '1 tablet once a day' WHERE PrescriptionID = 'PR001';

DELETE FROM Prescription WHERE PrescriptionID = 'PR001';

SELECT * FROM PrescriptionLog;

--PatientRoomBooking Testing
INSERT INTO PatientRoomBooking (RoomID, PatientID) 
VALUES ('R001', 'P002');

UPDATE PatientRoomBooking SET RoomID = 'R001' WHERE PatientID = 'P002';

DELETE FROM PatientRoomBooking WHERE PatientID = 'P002';

SELECT * FROM PatientRoomBookingLog;


--Doctor Schedule Testing

INSERT INTO DoctorSchedule (ScheduleID, DoctorID, AvailableDate, StartTime, EndTime, Status)
VALUES ('SCH003', 'DOC123', '2025-02-10', '10:00:00', '11:00:00', 'Available');

UPDATE DoctorSchedule
SET Status = 'Booked'
WHERE ScheduleID = 'SCH003';

DELETE FROM DoctorSchedule
WHERE ScheduleID = 'SCH003';

select * from DoctorScheduleLog

--Checking my Restrict Delete Trigger
INSERT INTO DoctorSchedule (ScheduleID, DoctorID, AvailableDate, StartTime, EndTime, Status)
VALUES ('SCH0067', 'DOC123', '2025-02-16', '10:00:00', '11:00:00', 'Available');
	
DELETE FROM DoctorSchedule
WHERE ScheduleID = 'SCH0056';
use "Skylines Hospital"
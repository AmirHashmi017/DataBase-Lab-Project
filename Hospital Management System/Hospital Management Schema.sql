
--Create table Department
create table Department
(
DepartmentID VARCHAR(50) Primary Key,
DepartmentName VARCHAR(50)
);

--Create table Room
create table Room
(
RoomID VARCHAR(50) PRIMARY KEY,
DepartmentID VARCHAR(50),
FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID),
TotalBeds INT,
AvailableBeds INT
);

--Create table Admin
create table Admin
(
AdminID VARCHAR(50) PRIMARY KEY,
LoginPassword VARCHAR(50),
AdminName VARCHAR(50),
PhoneNumber VARCHAR(50),
Email VARCHAR(50)
);

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

--Create Table Prescription
create table Prescription
(
PrescriptionID VARCHAR(50) PRIMARY KEY,
PatientID VARCHAR(50),
FOREIGN KEY (PatientID) REFERENCES Patient(PatientID),
DoctorID VARCHAR(50),
FOREIGN KEY (DoctorID) REFERENCES Doctor(DoctorID),
Dosage VARCHAR(50),
Medicine VARCHAR(50),
DoctorRemarks VARCHAR(50)
);

--Create PatientRoom Booking
create table PatientRoomBooking
(
RoomID VARCHAR(50),
FOREIGN KEY (RoomID) REFERENCES Room(RoomID),
PatientID VARCHAR(50),
FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
);

--Create Table DoctorSchedule
CREATE TABLE DoctorSchedule (
    ScheduleID VARCHAR(50) PRIMARY KEY,
    DoctorID VARCHAR(50),
    FOREIGN KEY (DoctorID) REFERENCES Doctor(DoctorID),
    AvailableDate DATE,
    StartTime TIME,
    EndTime TIME,
    Status VARCHAR(50) CHECK (Status IN ('Available', 'Booked','Expired'))
);


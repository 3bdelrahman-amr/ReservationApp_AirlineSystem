



use airliness;


------------------------- plane table----------------------------------------------------
create TABLE plane(
Snumber int
,Model varchar(50)
,Fcap int
,Ecap int
,Status varchar(50)
,primary key(Snumber)

);
------------------------------------------------------------------------------------------------
create table Airport
(
NoPlanes int,
LocationCountry varchar(50) not null,
AirportCode int not null,
AirportName varchar(50),
primary key (AirportCode),
)


---------------------Flight Table----------------------------------
create table Flight
(
Flightno int,
Primary key (Flightno),
NoPassengers int,
DestCode int,
SourceCode int,
NoStaff int,
Fstatus varchar(50),
foreign key (DestCode) references Airport,
foreign key (SourceCode) references Airport,
)
----------------------Client Table------------------------------------------
create table Client
(
ClientID int identity(100,1),
Primary key (ClientID),
Email varchar(50),
Pass varchar(50),
Fname varchar(50),
Lname varchar(50),
Age int,
Gender char(1),
Address varchar(50),
Nationality varchar(50),
BanStatus bit
)
-------------------Review Table---------------------------------------------
create table Review
(
ID int identity(1,1),
Comment varchar(1000),
ClientID int,
Flightno int,
Rate int,
Primary key (ID),
foreign key (ClientID) references Client,
foreign key (Flightno) references Flight,
)
--------------------Flight Crew Table--------------------------------------
create table FlightCrew
(
CrewID int,
primary key(CrewID),

Pass varchar(50),
Fname varchar(50),
Lname varchar(50),
Address varchar(50),

Role varchar(50),
)
--------------------Books Relation Table--------------------------------------
create table Books
(
Client_id int,
Flight_number int,
Fare varchar(50),
Primary key (Client_id,Flight_number),
foreign key (Client_id) references Client,
foreign key (Flight_number) references Flight,
)
-----------------------Employee Table------------------------------------------
create table Employee
(
EmpID int,
primary key(EmpID),

Pass varchar(50),
Fname varchar(50),
Lname varchar(50),
Address varchar(50),
WeeklyHours int,
)
------------------------Branch Table-------------------------------------------
create table Branch
(
BranchID int,
primary key(BranchID),
Blocation varchar(50),
EmployeeNo int,
)
-----------------------------Works_In Relation---------------------------------------
create table Works_in
(
EID int,
Bno int,
primary key (EID,Bno),
foreign key (EID) references Employee,
foreign key (Bno) references Branch,
)
------------------------Serves_On Relation-------------------------------------------
create table Serves_On
(
CrewID int,
FlightID int,
primary key (CrewID,FlightID),
foreign key (CrewID) references FlightCrew,
foreign key (FlightID) references Flight,
)
----------------------------------------------------------------------------------------



insert into Airport
values
(5,'egypt',12,'egypt'),
(5,'america',13,'america'),
(6,'china',14,'china')

insert into Flight
values
(1,5,'12','13',5,'pending'),
(2,6,'14','12',6,'done')
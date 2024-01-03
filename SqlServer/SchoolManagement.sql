Create database SE358_SchoolManagement
Go

Use SE358_SchoolManagement
Go

Create Table Roles
(
	RoleID int primary key,
	RoleName varchar(10)
)
Go

Create Table Users
(
	Username varchar(20) primary key,
	Password varchar(20),
	Email varchar(30),
	FulName varchar(25),
	RoleID int,
	InfoID int
)
Go

Create Table Information
(
	InfoID int IDENTITY(1,1) primary key,
	Image nvarchar(max),
	PhoneNumber varchar(12),
	Address varchar(30),
	Gender varchar(7) check (Gender in ('Male', 'Female')),
	FatherName varchar(25),
	FatherOccupation varchar(25),
	FatherPhoneNumber varchar(25),
	MotherName varchar(25),
	MotherOccupation varchar(25),
	MotherPhoneNumber varchar(25),
	DateOfBirth Date,

)

Create Table Classes
(
	ClassID int IDENTITY(1,1) primary key,
	ClassName varchar(7),
	Grade varchar(5),
	SchoolYear int,
	StatusClass varchar(12) check (StatusClass in ('Ended', 'In Progress')),
	TeacherID varchar(20),
)
Go

Create Table Students
(
	StudentID int IDENTITY(1,1) primary key,
	FulName varchar(25),
	InfoID int,
	ClassID int
)
Go

Create Table Tuitions
(
	TuitionID int IDENTITY(1,1) primary key,
	Fee int,
	StatusTuition varchar(10) check (StatusTuition in ('Paid', 'Unpaid')),
	TuitionOfMonth varchar(10),
	StudentID int
)

Create Table Subjects
(
	SubjectID int IDENTITY(1,1) primary key,
	SubjectName varchar(10),
	Leader varchar(20)
)
Go

Create Table Exams
(
	ExamID int IDENTITY(1,1) primary key,
	SubmitTime Date,
	TypeExam varchar(15) check (TypeExam in ('Exam 15min', 'Exam 45min', 'Exam Semester')),
	DocumentID int,
	ClassID int,
	SubjectID int
)

Create Table Documents
(
	DocumentID int IDENTITY(1,1) primary key,
	FilePath nvarchar(max),
	UploadDate Date
)
Go

Create Table Scores
(
	ScoreID int IDENTITY(1,1) primary key,
	ScoreOfExam float,
	ExamID int,
	StudentID int 
)
Go


ALTER TABLE Users ADD CONSTRAINT FK_Users_Role FOREIGN KEY (RoleID) REFERENCES Roles(RoleID);
ALTER TABLE Users ADD CONSTRAINT FK_Users_Information FOREIGN KEY (InfoID) REFERENCES Information(InfoID);
ALTER TABLE Classes ADD CONSTRAINT FK_Classes_Users FOREIGN KEY (TeacherID) REFERENCES Users(Username);
ALTER TABLE Students ADD CONSTRAINT FK_Students_Classes_ClassID FOREIGN KEY (ClassID) REFERENCES Classes(ClassID);
ALTER TABLE Students ADD CONSTRAINT FK_Students_Classes_InfoID FOREIGN KEY (InfoID) REFERENCES Information(InfoID);
ALTER TABLE Tuitions ADD CONSTRAINT FK_Tuitions_Students FOREIGN KEY (StudentID) REFERENCES Students(StudentID);
ALTER TABLE Exams ADD CONSTRAINT FK_Exams_Classes FOREIGN KEY (ClassID) REFERENCES Classes(ClassID);
ALTER TABLE Exams ADD CONSTRAINT FK_Exams_Documents FOREIGN KEY (DocumentID) REFERENCES Documents(DocumentID);
ALTER TABLE Exams ADD CONSTRAINT FK_Exams_Subjects FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID);
ALTER TABLE Scores ADD CONSTRAINT FK_Scores_Exams FOREIGN KEY (ExamID) REFERENCES Exams(ExamID);
ALTER TABLE Scores ADD CONSTRAINT FK_Scores_Students FOREIGN KEY (StudentID) REFERENCES Students(StudentID);
ALTER TABLE Subjects ADD CONSTRAINT FK_Subjects_Users FOREIGN KEY (Leader) REFERENCES Users(Username);

Insert into Roles values (1 , 'Principal');
Insert into Roles values (2 , 'Teacher');
Insert into Roles values (3 , 'Cashier');

Insert into Information (PhoneNumber) values (1);
Insert into Information (PhoneNumber) values (2);
Insert into Information (PhoneNumber) values (3);
Insert into Information (PhoneNumber) values (4);

Insert into Users (Username, Password, FulName, RoleID, InfoID) values ('principal', 'principal', N'Phạm Duy Thông', 1, 1);
Insert into Users (Username, Password, FulName, RoleID, InfoID) values ('teacher', 'teacher', N'Võ Hữu', 2, 2);
Insert into Users (Username, Password, FulName, RoleID, InfoID) values ('cashier', 'cashier', N'Nguyễn Hoàng Minh Quân' , 3, 3);
Insert into Users (Username, Password, FulName, RoleID, InfoID) values ('nhlinh', 'nhlinh', N'Nguyễn Hoàng Linh', 2, 4);

Insert into Subjects (SubjectName, Leader) values ('Math', 'nhlinh');
Insert into Subjects (SubjectName, Leader) values ('Physics', 'nhlinh')
Insert into Subjects (SubjectName, Leader) values ('Chemistry', 'nhlinh')
Insert into Subjects (SubjectName, Leader) values ('English', 'nhlinh')
Insert into Subjects (SubjectName, Leader) values ('Literature', 'nhlinh')
Insert into Subjects (SubjectName, Leader) values ('Biology', 'nhlinh')
Insert into Subjects (SubjectName, Leader) values ('Geography', 'nhlinh')
Insert into Subjects (SubjectName, Leader) values ('History', 'nhlinh')
Insert into Subjects (SubjectName, Leader) values ('PE', 'nhlinh')
Insert into Subjects (SubjectName, Leader) values ('IT', 'nhlinh')


-- Drop database SE358_SchoolManagement





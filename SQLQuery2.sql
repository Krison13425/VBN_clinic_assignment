Create Table Admin
(UserID nvarchar(50) not null Primary Key,
UserName nvarchar(50),
Password Integer,
Usertype nvarchar(50),);
Insert into Admin values
('A01', 'Tan' ,'1234' , 'Admin'),
('D01', 'Lim' ,'5678' , 'Doctor'),
('N01', 'Wong' ,'9012' , 'Doctor');




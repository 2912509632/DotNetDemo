create database Student
go

use Student
go

create table Info
(
ID int primary key identity(10000,1),
Name varchar(50) ,
Sex varchar(2) ,
Age int 
)
go

insert into Info values('Jiuone','ÄÐ',21)
insert into Info values('NineCMS','Å®',22)
insert into Info values('NineCode','ÄÐ',23)
insert into Info values('DreamCMS','Å®',24)
insert into Info values('Typecho','ÄÐ',25)
insert into Info values('WordPress','Å®',26)
insert into Info values('Emlog','ÄÐ',27)

select * from Info
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

insert into Info values('Jiuone','��',21)
insert into Info values('NineCMS','Ů',22)
insert into Info values('NineCode','��',23)
insert into Info values('DreamCMS','Ů',24)
insert into Info values('Typecho','��',25)
insert into Info values('WordPress','Ů',26)
insert into Info values('Emlog','��',27)

select * from Info
use  master
go

if exists(select * from sys.databases where name='LINQ')
	drop database LINQ
go

create database LINQ
go


use LINQ
go

create table Test
(
ID int primary key identity(1000,1),
Name varchar(20) not	 null,
Sex char(2) null,
Time datetime not null default(getdate())
)

insert into Test values('����','��',default)
insert into Test values('����','Ů',default)
insert into Test values('����','��',default)
insert into Test values('Ǯ��','Ů',default)
insert into Test values('����','Ů',default)
insert into Test values('���','Ů',default)
insert into Test values('�ܾ�','��',default)
insert into Test values('��ʮ','��',default)
insert into Test values('����','��',default)

select * from Test
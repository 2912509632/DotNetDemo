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

insert into Test values('张三','男',default)
insert into Test values('李四','女',default)
insert into Test values('王五','男',default)
insert into Test values('钱六','女',default)
insert into Test values('赵七','女',default)
insert into Test values('孙八','女',default)
insert into Test values('周九','男',default)
insert into Test values('吴十','男',default)
insert into Test values('王二','男',default)

select * from Test
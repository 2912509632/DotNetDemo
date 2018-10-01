-- 创建数据库结构SQL脚本


--创建数据库（便于测试）
--检测重名
use master
go
if exists(select * from sys.databases where name='EFDemo')
	drop database EFDemo
go
--创建数据库
create database EFDemo
go

--切换数据库
use EFDemo
go



--创建用户表
create table Users
(
--用户编号
UNum int primary key identity(10000,1),
--用户名称
UName nvarchar(20) unique not null,
--用户密码//加密后
UPass nvarchar(300) not null
)
go

--创建分类表
create table Category
(
--分类编号
CID int primary key identity(100,1),
--分类名称
CName nvarchar(30) not null
)
go

--创建文章表
create table Article
(
--文章编号
AID int primary key identity(10000,1),
--文章标题
ATitle nvarchar(100) not null,
--文章内容
AText text not null,
--发布时间
ATime datetime default(getDate()),
--所属分类
CID int references Category(CID)
)
go

--创建文件表
create table Media
(
--文件编号
MID int primary key identity(10000,1),
--文件名称
MName nvarchar(100) not null,
--文件地址
MUrl nvarchar(200) unique not null,
--上传时间
MTime datetime default(getDate()),
--操作用户
UNum int references Users(UNum)
)
go



-- �������ݿ�ṹSQL�ű�


--�������ݿ⣨���ڲ��ԣ�
--�������
use master
go
if exists(select * from sys.databases where name='EFDemo')
	drop database EFDemo
go
--�������ݿ�
create database EFDemo
go

--�л����ݿ�
use EFDemo
go



--�����û���
create table Users
(
--�û����
UNum int primary key identity(10000,1),
--�û�����
UName nvarchar(20) unique not null,
--�û�����//���ܺ�
UPass nvarchar(300) not null
)
go

--���������
create table Category
(
--������
CID int primary key identity(100,1),
--��������
CName nvarchar(30) not null
)
go

--�������±�
create table Article
(
--���±��
AID int primary key identity(10000,1),
--���±���
ATitle nvarchar(100) not null,
--��������
AText text not null,
--����ʱ��
ATime datetime default(getDate()),
--��������
CID int references Category(CID)
)
go

--�����ļ���
create table Media
(
--�ļ����
MID int primary key identity(10000,1),
--�ļ�����
MName nvarchar(100) not null,
--�ļ���ַ
MUrl nvarchar(200) unique not null,
--�ϴ�ʱ��
MTime datetime default(getDate()),
--�����û�
UNum int references Users(UNum)
)
go



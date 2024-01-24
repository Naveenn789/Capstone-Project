create database Blogspot

use Blogspot

create table AdminInfo
(EmailId nvarchar(50) primary key,
Password nvarchar(50))

insert into AdminInfo values('sam@gmail.com','Sam@123')

create table EmpInfo
(EmailId nvarchar(50) primary key,
Name nvarchar(50),
DatOfJoining datetime,
PassCode int )

insert into EmpInfo values('sai@gmail.com','Sai','12/12/2021',12345)

create table BlogInfo
(BlogId int,
Title nvarchar(50) primary key,
Subject nvarchar(50),
DateOfCreation datetime,
BlogUrl nvarchar(50),
EmpEmailId nvarchar(50) references  EmpInfo(EmailId))

insert into BlogInfo values (1,'Corona','Virus','03/31/2020','corona','sai@gmail.com')

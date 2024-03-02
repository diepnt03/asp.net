use master
go
if DB_ID('mydata') is not null
	drop database mydata
go
create database mydata
go
use mydata
go
create table tblDept(
deptid int primary key identity,
deptname nvarchar(25)
)
insert into tblDept values('Hanh chinh')
insert into tblDept values('Ke toan')
insert into tblDept values('Tong hop')
go
create table tblEmployee(
eid int primary key identity,
name nvarchar(30) not null,
age int,
addr nvarchar(30) not null,
salary int not null,
image nvarchar(50),
deptid int foreign key references tblDept(deptid))
go
insert into tblEmployee values('Tran Lan Anh',32,'Ha noi',3500,'a1.jpg',1)
insert into tblEmployee values('Nguyen Thi Huong',30,'Ha noi',5000,'a2.jpg',2)
insert into tblEmployee values('Pham Van Ha',30,'Hai phong',4000,'a3.jpg',1)
insert into tblEmployee values('Nguyen Hong Linh',35,'Thai binh',5500,'a4.jpg',3)
insert into tblEmployee values('Tran Van Hung',32,'Hai phong',5000,'a5.jpg',1)
insert into tblEmployee values('Le Hai Yen',28,'Thai binh',3000,'a6.jpg',1)
insert into tblEmployee values('Pham My Ha',26,'Hai phong',3000,'a7.jpg',2)
insert into tblEmployee values('Le Phuong Thuy',24,'Hai phong',2000,'a8.jpg',3)
insert into tblEmployee values('Hoang Van Long',24,'Ha noi',2500,'a9.jpg',2)
insert into tblEmployee values('Ha Cong Tu',40,'Thai binh',4500,'a10.jpg',2)
go
--drop table tblEmployee
-- select * from tblEmployee where addr='Hai phong' and salary>3000
select * from tblEmployee where deptid=1
select * from tblEmployee where deptid=2
select * from tblEmployee where deptid=3
create database PayRoll_Service_01

create table employee_payroll
(
EmployeeId int Identity,
EmployeeName varchar(255),
Address varchar (255),
PhoneNumber varchar(255),
Department varchar(255),
Gender char(1),
BasicPay float ,
Deductions float,
TaxablePay float,
NetPey float,
 Tax float,
 StartDate Date,
 City varchar(255),
 Country varchar(255),
 )

 select * from  employee_payroll
 select * from  Salary
 create table Salary
 (
 EmpId int,
 EmpName varchar(255),
 Salary int,
 SalaryMonth varchar(20),
 SalaryId int Identity
 )
 insert into Salary (EmpId,Salary,SalaryMonth) values(1,'Brush',12000,'Jan')

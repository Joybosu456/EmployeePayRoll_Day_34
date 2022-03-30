create procedure  sqlUpdateEmployeeSalary
(
@id int,
@month varchar(2),
@salary int,
@EmpId int
)
as
begin
update Salary 
set Salary=@salary
Where SalaryId=@id and SalaryMonth=@month and EmpId=@EmpId;

select e.EmployeId,e.EmployeeName,s.Salary,s.SalaryMonth,s.SalaryId
from employee_payroll e inner join Salary s
on e.EmployeeId=s.EmpId where s.SalaryId=@id;
End
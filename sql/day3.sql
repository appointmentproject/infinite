use sql

select * from Employee
--sorting of data on a specific column/s
--order by is the clause for sorting
--only the output is sirted and not the physical data
--multiple column sorting is possible
--by default sorting is ascending(can make it desc)
--sorting on a columns which are not a part of the select statement
select * from employee order by Empname
select Empid, Empname 'EmployeeName', Salary from  Employee order by Employeename
select Empid, Empname, DeptId from Employee order by Salary desc
select Empname,Salary from Employee order by Salary desc

select Empname, Salary from Employee order by Empname,Salary desc
select Empname,Gender,Salary from Employee order by Gender,Salary desc
select Empname, DeptId, Salary from Employee order by DeptId desc,Salary 

--group by clause
--have to group on all columns in the select clause excluding aggregates
--can group on multiple columns
--cannoty group on a column that is not a part of the select clause
--cannot group by on an alias column

--find the total salary per department
select DeptId,sum(Salary) as TotalSalary,count(Empname) from Employee
group by DeptId,Gender        --

select DeptId as Departmentid, Gender, sum(Salary) as TotalSalary from Employee
group by Gender,DeptId

--no of male and female employees working in the organization
select gender,count(*) from employee group by gender
select distinct(gender),count(gender) from employee group by gender

-- no of male and female staff in each dept
select gender,deptid as DeptId,count(gender) as 'Total Employees' from employee group by deptid,gender

--display all the departments where total salary is greater than 25000
select deptid as Departmentid, sum(salary) as TotalSalary  from employee
group by DeptId
having sum(salary)>25000

--display dept wise max salary where max salary is > 12300
select deptid,max(salary) as 'Max Salary' from employee group by deptid 
having max(salary)>12300
order by deptid desc

--to filter few records before forming a group, use where clause
select deptid,max(salary) as 'Max Salary' from employee 
where deptid is not null
group by deptid 
having max(salary)between 12350 and 12500
order by deptid desc
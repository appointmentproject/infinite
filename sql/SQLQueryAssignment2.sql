create database Assignment2

use Assignment2


create table Department
(Deptno int primary key,
Dname varchar(25) ,
Loc varchar(30))

select * from Department

insert into Department values(10,'Accounting','NewYork'),(20,'Research','Dallas'),(30,'Sales','Chicago'),(40,'Operations','Boston')

create table Employee
(empno int primary key,
ename varchar(20),
job varchar(30),
mrgid int ,
hiredate date ,
sal float,
comm float,
Deptno int foreign key references Department(Deptno))

select * from Employee

insert into Employee values
(7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES' ,'MANAGER',7839,'02-APR-81',2975,null,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30),
(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null, 10),
(7788,'SCOTT','ANALYST ',7566,'19-APR-87',3000, null, 20),
(7839,'KING','PRESIDENT',null,'17-NOV-81',5000, null, 10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500, 0 ,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100, null,20),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950, null,  30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20),
(7934 ,'MILLER','CLERK',7782,'23-JAN-82',1300, null,10)

-----1. List all employees whose name begins with 'A'. 
select ename from Employee where ename like 'A%'

-----2. Select all those employees who don't have a manager.
select * from Employee where job!='MANAGER'
---------------or-----------------------
select ename,job from Employee where job!='MANAGER'

-----3. List employee name, number and salary for those employees who earn in the range 1200 to 1400.
select empno,ename,sal from Employee where sal between 1200 and 1400

-----4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.
select ename,sal as 'before salary',(sal*10) as 'after salary' from Employee where deptno=20

-----5. Find the number of CLERKS employed. Give it a descriptive heading.
select count (*) job from Employee where job ='CLERK'

-----6. Find the average salary for each job type and the number of people employed in each job

select job, avg(sal) as 'average salary',count(Empno) as 'no of emp' FROM Employee group by job

---- 7. List the employees with the lowest and highest salary. 
select min(sal) as 'lowest salary',max(sal) as 'highest salary' from Employee 

-----8. List full details of departments that don't have any employees. 
select Deptno from Employee order by Deptno

-----9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select ename,sal from Employee where job ='ANALYST' and Deptno =20 and sal >1200 order by ename asc

-----10. For each department, list its name and number together with the total salary paid to employees in that department.
select Deptno,sum(sal) as 'total salary' from Employee group by Deptno

---- 11. Find out salary of both MILLER and SMITH.
select ename,sal from Employee where ename='SMITH'or ename='MILLER'

-----12. Find out the names of the employees whose name begin with ‘A’ or ‘M’.
 select ename from employee where ename like 'A%' or ename like 'M%' order by ename

---- 13. Compute yearly salary of SMITH. 
select ename,sal,(sal*12) 'yearly salary' from employee where ename='SMITH'

-----14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select ename,sal from Employee where not sal between 1500 and 2850


 
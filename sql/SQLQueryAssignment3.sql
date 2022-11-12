 use Assignment2
 
 select * from Employee
----1. Retrieve a list of MANAGERS. 
select * from Employee E join Department D 
on E.deptno = D.deptno
where job ='MANAGER'

----2. Find out the names and salaries of all employees earning more than 1000 per month. 
select ename,sal from Employee where sal>1000

----3. Display the names and salaries of all employees except JAMES.
select ename,sal from Employee where ename!='JAMES'
----4. Find out the details of employees whose names begin with ‘S’.
select ename from Employee where ename like 's%'

----5. Find out the names of all employees that have ‘A’ anywhere in their name. 
select ename from Employee where ename like '%a%'

----6. Find out the names of all employees that have ‘L’ as their third character in their name. 
select ename from Employee where ename like '__l%'

----7. Compute daily salary of JONES. 
select ename,(sal/30) as 'daily salary' from Employee where ename ='JONES'

----8. Calculate the total monthly salary of all employees. 
 select sum(sal) from Employee

----9. Print the average annual salary .
select avg(sal*12) as 'annual salary' from Employee

----10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select ename,job,sal,Deptno from Employee where job!='SALESMAN' and Deptno=30

----11. List unique departments of the EMP table. 
select distinct(dname),ename from employee E JOIN department D
on E.deptno = D.deptno

----12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename,sal from Employee where sal>1500 and Deptno in(10,30)

----13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select ename,job,sal from Employee where job in('MANAGER' , 'ANALYST') and sal not in(1000,3000,5000)

----14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 
select ename,sal,comm as 'Before increase',(comm*10) as 'After increase' from employee where comm>sal

----15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 
select ename from Employee where ename like '%l%l%' and Deptno=30 or mrgid=7782

----16. Display the names of employees with experience of over 30 years and under 40 yrs. Count the total number of employees. 
select ename, hiredate ,count(*) total,datediff(year, hiredate, getdate()) as experience from employee 
where datediff(year, hiredate, getdate()) between 30 and 40 group by ename,hiredate

----17. Retrieve the names of departments in ascending order and their employees in descending order. 
select dname,ename from employee E join department D
on E.deptno = D.deptno
order by E.ename desc, D.dname asc

----18. Find out experience of MILLER.
select ename, datediff(year, hiredate, getdate()) as experience from employee where ename = 'MILLER'
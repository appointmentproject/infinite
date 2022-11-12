create database sql

use sql
 
 create table Department
(DeptId int primary key,
DeptName varchar(20),Budget float)                    

select * from Department

insert into Department values(2,'Operations',200000),(4,'Sales',400000),(3,'Admin',50000)

insert into Department values(1,'IT',30000),(5,'emp',32000)
create table Employee
(Empid int primary key,
Empname varchar(30),
Salary float,
Gender char(7),
DeptId int foreign key references Department(DeptId))


select * from Employee

insert into Employee values(1,'Aishwarya',12000,'Female',null,12345),(2,'Tejaswi',12200,'Female',1,23456),
(3,'Sampreeth',12300,'Male',1,34567),(4,'Harish',12000,'Male',2,45678),
(5,'Varsha',12100,'Female',3,56789)

alter table Employee
add Phone varchar(15) unique 

alter table Employee
drop column Phone

insert into Employee values(6,'Brahmaji',12000,'Male',4,4343434)

alter table Employee
drop constraint UQ__Employee__5C7E359EC49A250C

alter table Employee
drop constraint unqphone     --(user defined constraint name)


alter table Employee
add constraint unqphone unique(Phone)

delete from employee

--to update values of a row/s in table
update Employee set Phone='0007'
where Empid=6

--check constraints
alter table Employee
add constraint chksal check(Salary >=12000)

--default constraints ( default values for a column when we dont supply one)
alter table Department
add City varchar(25) default 'Bangalore'  -- or add acolumn first and then add constraint as below

alter table Department 
add constraint defcity Default 'Bangalore' for City

alter table Department
drop constraint defcity

alter table Department
drop column City

--inserting a record to check default values
insert into Department(Deptid,DeptName)
values(6,'Accounts')

--Disabling check constraint
alter table Employee nocheck constraint chksal
--enabling check constraint
alter table Employee check constraint chksal

--select options

--restriction
select  * from Employee where gender='Female'

--projection
select Empname, Salary from Employee

--projection and restriction
select Empname,salary from Employee where gender='Female'

--select top few records
select top 3 * from Employee
select top 3 Salary from Employee

--select top percentage of records
select top 20 percent * from Employee

--alias names for columns 
select empid as 'Employee Number',empname 'Employee Name' from Employee

--to delete a table permanently, lets create a dummy table and drop it
create table dummy(dummyid int, dummyname varchar(10))
insert into dummy values(1,'Dummy1'),(2,'Dummy2')
select * from dummy
drop table dummy
select * from dummy    --- invalid object message is thrown

truncate table dummy   
delete from dummy


--Arithmetic operators in select
select Salary as 'Old Salary', Salary+1000 as 'New Salary' from Employee
select Salary, (Salary*12) 'Annual Salary' from Employee

--Relational Operators in select
select * from employee where salary >12000
select * from employee where salary >=12000
select * from employee where salary=12000
select * from employee where deptid!=1

--logical operators in select
select * from employee where salary>=11000 and salary<=12100
select * from employee where salary>12000 or deptid=4

--between operators in select
select * from employee where salary between 11000 and 12100

--in operator in select
select * from employee where deptid = 1 or deptid=2

select * from employee where deptid in(1,2)

--not operators in select
select * from employee where deptid not in(1,2)
select * from employee where not salary between 11000 and 12100
select * from Employee where Salary not between 11000 and 13000

--nulls in select
select * from employee where deptid is null
select * from employee where deptid is not null


--wildcards using like operator
/*  
% - zero,one or more characters substitution
_ - exactly one character
[] - range characters
^  - negation */
select Empname from Employee where empname like 's%' -- names that start with s followed by 0,1 or more characters
select Empname from Employee where empname like 'An%' -- names that start with an followed by any characters or no characters

select Empname from Employee where empname like 'A[in]%'-- names that start with A followed by either i or n followed by any characters or no characters
select Empname from Employee where empname like '_a%' -- names that can have any one character followed by a , then by any or none charcaters
select Empname from Employee where empname like '%i%' -- names that have any or none characters, but definitely should have i in them, then followed by any or none chrs

select empname from employee where empname like '%i' --names that have i in them in any place
select empname from employee where empname like '__r%' -- names that have r as their 3rd character 

--names that start with either a,s,v nut should end with a
select empname from employee where empname like '[asv]%a'

--names that end with a but does not have either a or s as their start character
select empname from employee where empname like '[^as]%a'

select empname from employee where empname like '_[^as]%a'


--Aggregate functions in select
select max(salary) from employee
select min(salary) from employee
select count(empid) from employee
select count(deptid) from employee  -- count ignores null values
select count(empname) from employee 

select count(*)deptid from employee  --count * includes null values
select avg(salary) from employee

select deptid from employee

select distinct(deptid) from employee  -- gets only unique values and avoids duplicates

--Note :
--Functions cannot be used in the RHS of the where clause

select * from employee where salary>avg(salary)

--to create  a table with an identity column
sp_help employee  -- no identity column defined

create table dummy
(dummyid int identity(1,2),
dummyname varchar(20),
dummyage int)

insert into dummy values('Dummy4',12),('Dummy2',14),('Dummy3',15)
select * from dummy

delete from dummy where dummyid=5

sp_help dummy

--to create composite primary key
create table sample
(eid int ,
pid int ,
duration int
primary key(eid,pid))

insert into sample values(1,100,600),(1,200,450),(2,100,500)
select * from sample
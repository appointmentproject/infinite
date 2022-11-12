create database Ass4



create table FIRSTNORMALFORM(
clientno varchar(4),
cname varchar(20),
Propertyno varchar(4),
Paddress varchar(50),
rentstart date,
rentfinsh date,
rent float,
ownerno varchar(4),
oname varchar(15)
)
select * from FIRSTNORMALFORM

insert into FIRSTNORMALFORM values('CR76','john kay','PG4','6 lawrence st glasgow','1-jul-00','31-aug-01',350,'CO40','tina murphy'),
('CR76','john kay','PG16','5 novar Dr,Glasgow','1-sep-02','01-sep-02',450,'CO93','tony shaw'),
('CR56','Aline stewart ','PG4','6 lawrence st glasgow','1-jul-99','10-jun-00',350,'CO40','tina murphy'),
('CR56','Aline stewart ','PG36','2 Manor Rd glasgow','10-oct-00','01-dec-01',370,'CO93','tony shaw'),
('CR56','Aline stewart','PG16','5 novar Dr,Glasgow','1-nov-02','01-aug-03',450,'CO93','tony shaw')

----------------------------2nf-----------------------------


create table Clients
(clientno varchar(4),
cname varchar(20),)

select * from Clients

insert into Clients values('CR76','john kay'),
('CR56','Aline stewart')

create table Owners
(ownerno varchar(4),
oname varchar(15))

select * from Owners


insert into Owners values('CO40','tina murphy'),
('CO93','tony shaw')


create table Rental
(clientno varchar(4),
Propertyno varchar(4),
rentstart date,
rentfinsh date,)

select * from Rental


insert into Rental values('CR76','PG4','1-jul-00','31-aug-01'),
('CR76','PG16','1-sep-02','01-sep-03'),
('CR56','PG4','1-jul-99','10-jun-00'),
('CR56','PG36','10-oct-00','01-dec-01'),
('CR56','PG16','1-nov-02','01-aug-03')

create table Propertyowner
(Propertyno varchar(4),
Paddress varchar(50),
rent float,
ownerno varchar(4),)


select * from Propertyowner

insert into Propertyowner values('PG4','6 lawrence st glasgow',350,'CO40'),
('PG16','5 novar Dr,Glasgow',450,'CO93'),
('PG36','2 Manor Rd glasgow',370,'CO93')



------------Assignment4-----------------


--1. Write a T-SQL Program to find the factorial of a given number.

declare @n int,@fact int
set @n=5
set @fact=1
begin
while(@n>1)
   begin
    set @fact=@fact*@n
    set @n=@n-1
 end
print @fact
end








--2. Create a stored procedure to generate multiplication tables up to a given number.

create or alter procedure multi1 (@n int, @i int)
 as
declare @f int
begin
   while(@i<=10)
   begin
      set @f=@n*@i
     print CAST(@n as varchar(max))+ '*' +CAST(@i as varchar(max))+ '=' +CAST(@f as varchar(max))
	 set @i=@i+1
   end
end

  execute multi1 9,1







--3. Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" et


create table holidays
(holidaydate date,holiday_name varchar(30))
select * from holidays
insert into holidays values('15-aug-2022','independence day'),
('5-oct-2022','Dussehra'),('2-oct-2022','gandhi jayanthi'),('24-oct-2022','diwali')




create or alter trigger holidays
on Employee1
instead of insert
as

 declare @holiday int
 begin
 --check for valid specialization id
 select * from inserted
 select @holiday=holidaydate from holidays 

 if (@holiday=holidaydate )
 begin
 raiserror('Due to Independence day you cannot manipulate data',16,1)
 end




create table Employee1
(empno int primary key,
ename varchar(20),
job varchar(30),
mrgid int ,
holidaydate date ,
sal float,
comm float)

select * from Employee1

insert into Employee1 values
(7369,'SMITH','CLERK',7902,'17-DEC-80',800,null),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500),
(7566,'JONES' ,'MANAGER',7839,'02-APR-81',2975,null),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null),
(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null),
(7788,'SCOTT','ANALYST ',7566,'19-APR-87',3000, null),
(7839,'KING','PRESIDENT',null,'17-NOV-81',5000, null),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500, 0),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100, null),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950, null),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null),
(7934 ,'MILLER','CLERK',7782,'23-JAN-82',1300, null)



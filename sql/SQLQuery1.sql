
--------------------------------------------------------------------------------------------


Create  table Code_Employee(empno int IDENTITY(1001,1) primary key,
   empname varchar(35) not null,
  empsal numeric(10,2) check (empsal >=25000),
  emptype char(1) check (emptype like 'F'  or emptype like 'P') )

select * from code_Employee

insert into Code_Employee values('siva',32000,'f'),('raja',25000,'p'),('teja',35000,'f'),('suresh',27000,'p')



----------------------------------------------

create or alter procedure InsertEmployee
@empname varchar(100),
@empsal int,
@emptype char(1)
AS
begin
declare @Insertedid int = 0



INSERT INTO  code_Employee(  
empname,   
empsal,    
emptype )
VALUES(@empname, @empsal, @emptype)
SELECT @Insertedid = @@IDENTITY



SELECT * FROM code_Employee WHERE empno = @Insertedid
end
exec InsertEmployee'rajesh','35000','p'




use Assignment2

select * from Employee

------a)HRA  as 10% Of sal----------
create or alter procedure getEmployee_HRA(@name varchar(30), @sal float output)
  as
  begin
   select @sal=sal from employee where ename=@name
   set @sal=(@sal*10)
  end

   declare @hrasal float
  execute getEmployee_HRA 'SMITH', @hrasal output
  print @hrasal


------b) DA as  20% of sal------------
create or alter procedure getEmployee_DA(@name varchar(30), @sal float output)
  as
  begin
   select @sal=sal from employee where ename=@name
   set @sal=(@sal*20)
  end

   declare @dasal float
  execute getEmployee_DA 'SMITH', @dasal output
  print @dasal


----- c) PF as 8% of sal-----------
create or alter procedure getEmployee_PF(@name varchar(30), @sal float output)
  as
  begin
   select @sal=sal from employee where ename=@name
   set @sal=(@sal*8)
  end

   declare @pfsal float
  execute getEmployee_PF 'SMITH', @pfsal output
  print @pfsal


-------d) IT as 5% of sal----------
create or alter procedure getEmployee_IT(@name varchar(30), @sal float output)
  as
  begin
   select @sal=sal from employee where ename=@name
   set @sal=(@sal*5)
  end

   declare @itsal float
  execute getEmployee_IT 'SMITH', @itsal output
  print @itsal


 ------e) Deductions as sum of PF and IT

 create or alter procedure getEmployee_DED(@name varchar(30), @sal float output)
  as
  begin
  declare @pfsal float,@itsal float
   select @sal=sal from employee where ename=@name
   set @sal=@pfsal+@itsal
  end

   declare @dedsal float
  execute getEmployee_DED 'SMITH', @dedsal output
  print @dedsal


--------f) Gross Salary as sum of SAL,HRA,DA---------

create or alter procedure getEmployee_GROSS(@name varchar(30), @sal float output)
  as
  begin
  declare @hrasal float,@dasal float
   select @sal=sal from employee where ename=@name
   set @sal=@sal+@hrasal+@dasal
  end

   declare @grosssal float
  execute getEmployee_GROSS 'SMITH', @grosssal output
  print @grosssal


--------g)Net salary as  Gross salary- Deduction------
create or alter procedure getEmployee_NET(@name varchar(30), @sal float output)
  as
  begin
  declare @grossal float,@dedsal float
   select @sal=sal from employee where ename=@name
   set @sal=@grossal-@dedsal
  end

   declare @netsal float
  execute getEmployee_NET 'SMITH', @netsal output
  print @netsal

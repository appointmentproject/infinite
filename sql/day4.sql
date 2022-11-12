select * from employee
select * from dummy
select * from department

-- 1st Transactions -- except delete employee, all will be rolled back

begin transaction

 delete from employee where empid=12   -- has to be comitted
 select * from employee
 save tran s1
 update employee 
 set deptid=1 where empid=1
 insert into dummy values('Transactiondummy',2)
 select * from dummy
 save tran s2
 update Department set city='Chennai' where deptid=3
 select * from department
 rollback tran s1
 commit


--2 nd transaction -- last update department alone will be rolled back

--Transactions
begin transaction 
 insert into employee values(12,'Harshini',12600,'Female',4,2222222)
 select * from employee
 save tran s1
 update employee 
 set deptid=1 where empid=1
 insert into dummy values('Transactiondummy',2)
 select * from dummy
 save tran s2
 update Department set city='Chennai' where deptid=3
 select * from department
 rollback tran s2
 commit

--3rd transaction  -- all statements will be rolled back

begin transaction 
 insert into employee values(13,'Harshini',12600,'Female',4,2122222)
 select * from employee
 save tran s1
 update employee 
 set deptid=2 where empid=1
 insert into dummy values('Tdummy',25)
 select * from dummy
 save tran s2
 update Department set city='Chennai' where deptid=3
 select * from department
 rollback   


--rank()
 create table StdMarks(
 stdname varchar(30),
 subjects varchar(20), 
 marks int)

 insert into stdmarks values('Shreedhar','Maths',80),('Shreedhar','Science',70),('Shreedhar','English',60),
 ('Ramya','Maths',75),('Ramya','Science',85),('Ramya','English',60),
 ('Haritha','Maths',70),('Haritha','Science',70),('Haritha','English',80)

 select * from StdMarks

 --query with row_number()
 select stdname,subjects,marks,ROW_NUMBER()over(order by marks desc) Ranking from stdmarks

 --query with rank()
  select stdname,subjects,marks,Rank()over(order by marks desc) Ranking from stdmarks

  --query with dense_rank()
 select stdname,subjects,marks,dense_Rank()over(order by marks desc) Ranking from stdmarks

 --query using rank() with partition
 --subject wise
  select stdname,subjects,marks,Rank()over(partition by subjects order by marks desc) Ranking from stdmarks

  select stdname,subjects,marks,dense_Rank()over(partition by subjects order by marks desc) Ranking from stdmarks

  --student wise 
  select stdname,subjects,marks,Rank()over(partition by stdname order by marks desc) Ranking from stdmarks



------------------------------------------------Procedures------------------------------
  --eg 1  all employees
  create or alter procedure proc1
  as
  begin
   select * from employee
  end

  sp_helptext proc1

  --to execute the above procedure
  execute proc1  -- or

  exec proc1
  --drop procedure proc1

  --eg 2 few employees
  create or alter procedure FewEmployee
  as
  begin
   select * from employee where deptid in(1,3)
  end

  exec FewEmployee
  --eg 3 procedure with input parameter

  create or alter procedure getEmployeebyId @eid int
  as
  begin
  select * from employee where empid=@eid
  end

  exec getEmployeebyId 3

  --eg 4
  --procedure with output parameter
  create or alter procedure getEmployeeSalary (@name varchar(30), @sal float output)
  as
  begin
   select @sal=salary from employee where empname=@name
   set @sal=@sal+500
  end

  --executing the above procedure using method 1
  declare @retsal float
  execute getEmployeeSalary 'Varsha', @retsal output
  print @retsal
  set @retsal=@retsal-500
  print @retsal

  --executing the above procedure using method 2/ changing the order
  declare @sal1 float
  execute getEmployeeSalary @sal = @sal1 output,@name='Varsha'
  print @sal1

  --procedure with return type
  --eg 1
  create or alter procedure getMarks(@name varchar(20),@sub varchar(20))
  as
  begin
  return (select marks from stdmarks where stdname=@name and subjects=@sub)
  end

  --to execute the above proc
  declare @marks int
  execute @marks=getMarks 'Niranjan','Maths'
  print @marks

 --eg 2
 create or alter procedure getno_ofemployees(@did int)
 as
 begin
 return (select count(*)empid from employee where deptid=@did)
 end

 declare @totemp int
 exec @totemp=getno_ofemployees 2
 print @totemp

 --eg 3 return values other than integer
 create or alter procedure getno_ofemployees_new(@did int)
 as
 begin
return select deptname from department where DeptId=@did
 end

 declare @name varchar(20)
 exec @name=getno_ofemployees_new 3
 print @name




 ---------------------------stored procedure with exception handling and transaction management

create table Products
(ProductId int primary key,
ProdName varchar(50),
Price int,
QtyAvailable int)

--populate some records
insert into Products values(100,'Laptops',54000,100),
(101,'Desktops',32000,50),
(102,'Tablet',21000,75),
(103,'Mobile',25000,50)

create table ProductSales(ProductSalesId int primary key,
ProductId int references Products(ProductId),
QtySold int)

create or alter procedure spSellProduct 
@productid int, @QtyToSell int
as 
begin
 --first we need to check the stock availability for the product that we want to sell
 declare @stockavailable int
 select @stockavailable=QtyAvailable from Products where productid = @productid
  --we need to throw an error when the stock is less than the qty to sell
  --RaiseError is a system function that takes 3 parameters as below
  --Raiserror('Error Message', ErrorSeverity, Errorstate)
   if(@stockavailable < @QtyToSell)
   begin
    Raiserror('Not Enough Stock',16,21)
   end
   --if stock is more then 
  else
   begin
    --we need to start a transaction
	begin transaction
	  -- first update the qtyavailable in products table
	  update Products set QtyAvailable=(QtyAvailable-@QtyToSell)
	  where ProductId=@productid
	  --next we need to insert one record of the sale made in Productsales table
	  --in order to insert productsalesid automatically we can use a logic as below
	  declare @maxid int
	  select @maxid=case
	   when max(productsalesid) is null then 0
	   else max(productsalesid)
	   end
	   from ProductSales
	   --increment @maxid by 1, so that we dont get a primary key violation
	   set @maxid=@maxid+1
	   --now we can insert a record into productsales table
	   insert into ProductSales values(@maxid,@productid,@QtyToSell)
	   --the @@Error returns a non-zero value if there is an error, otherwise 0
	   if(@@ERROR <> 0)
	   begin
	    Rollback transaction
		print 'Rolling back the transaction..'
	   end
	   else
	    begin
	     Commit Transaction
	     print ' Comitted the transaction'
		end
 end
end


-- execute the above proc
select * from products
select * from ProductSales
exec spSellProduct 101,20

select max(productsalesid) from ProductSales

--eg 2 error handling in a procedure
create or alter procedure Errhandler1
as
begin
  begin try
    select Empname + Salary from employee where empid=5
  end try
  begin catch
    print 'cannot concatenate varchar with float'
  end catch
end

create or alter procedure Errhandler1
as
begin
  begin try
    select Empname + Salary from employee where empid=5
  end try
  begin catch
    --print 'cannot concatenate varchar with float'
	--Raiserror(15600,11,1,'invalid Operation in procedure')
	raiserror(15600,11,2)
	--throw 51000,'Problem',15
  end catch
end



--can execute a procedure without the exec/execute command as below
errhandler1

--To add a user defined message 

exec sp_addmessage 51000,12,'MyErrorMessage'

--to view all the errors

select * from sys.messages where message_id=15600


 ------------------------functions------------------------------
 --functions
 --eg scalar function
 create function Add2nos(@a int, @b int)
 returns int
 as
 begin
  return @a+@b
 end

 --to execute the above function
 --use 2 part qualification
 select dbo.Add2nos(5,10) Total--or
 print dbo.Add2nos(20,20) 

 print 'The Sum of 2 nos :' + cast(dbo.Add2nos(20,20)as varchar(max))

 --eg 2
 create or alter function display()
 returns varchar(max)
 as
 begin
 return 'Hello and Welcome to the concpets of Sql Functions.'
 end

 select dbo.display()

 --eg 3
 --find the area of a rectangle
 create or alter function Rect_Area(@len int,@bread int)
 returns int
 as
 begin
 declare @area int
 set @area=@len * @bread
 return @area
 end

 select dbo.Rect_Area(5,6) as 'Rectangles Area'

 --eg 4
 --given a dept id, get the name of the dept
 create or alter function getDept(@id int)
 returns varchar(max)
 as
 begin
 return (select deptname from Department where deptid=@id)
 end

 select dbo.getDept(3)

 --inline table valued functions
 create or alter function inlinetablefunc1(@did int)
 returns table
 as
  return (select Empid,Empname,Salary,deptid from employee  
         where deptid=@did)

select * from inlinetablefunc1(2)

--multi statement table valued function
create or alter function GetEmployeeByname(@did int)
returns   -- returns data captured in a temporary table structure
@EmpByName table(
EmployeeNo int,
Ename varchar(30),
Esalary float,
EPhone varchar(15)
)
as
begin
     insert into @EmpByName select Empid,Empname,Salary,Phone from Employee where deptid=@did
   --check if data from employee table that matched the deptid, is inserted successfully into the temp table
     if @@ROWCOUNT=0
     begin
       insert into @EmpByName values(0,'No Employees in dept',0,null)
     end
return
end

select * from GetEmployeeByname(0)


//select Empid,Empname,Salary,Phone from Employee where deptid=6


 create or alter procedure proc1
@empname varchar(20),@empsal float,@emptype varchar(1)
  as
  begin
  @insertempno int =0
   insert into  Code_Employee values(@empname,@empsal,@emptype)

  end
  declare @insertempno int = 0
  select * from Code_Employee where empno=@insertempno
exec proc1 'rajesh',22000,'p'
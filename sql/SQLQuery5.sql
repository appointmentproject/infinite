

select * from Product
select * from ProductSales

create table Product
(ProductId int primary key,
ProdName varchar(50),
Price int,
QtyAvailable int)

--populate some records
insert into Product values(100,'Laptops',54000,110),
(101,'Desktops',32000,60),
(102,'Tablet',21000,75),
(103,'Mobile',25000,50)

create table ProductSales(ProductSalesId int primary key,
ProductId int references Product(ProductId),
QtySold int)



sp_help tbl_Book

select * from tbl_Book

insert into tbl_Book values('CShrap programing'),('Introduction to Dot.Net'),('SQL Programing made Easy')


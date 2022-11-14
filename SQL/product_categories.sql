use ShopDB;

set ANSI_WARNINGS OFF;

insert into Product(Name) values('Salt');
insert into Product(Name) values('Pepper');
insert into Product(Name) values('Viniger');
insert into Product(Name) values('Basil');

insert into Category(Name) values('Spices1');
insert into Category(Name) values('Spices2');
insert into Category(Name) values('Spices3');

insert into ProductCategory(ProductId, CategoryId) values(1, 1);
insert into ProductCategory(ProductId, CategoryId) values(1, 2);
insert into ProductCategory(ProductId, CategoryId) values(2, 1);
insert into ProductCategory(ProductId, CategoryId) values(2, 3);
insert into ProductCategory(ProductId, CategoryId) values(3, 2);
insert into ProductCategory(ProductId, CategoryId) values(3, 3);

set ANSI_WARNINGS ON;

select * from Category;
select * from Product;

select Product.Name as 'ProductName', Category.Name as 'CategoryName'
from Product
left join ProductCategory on ProductId = Product.Id
left join Category on CategoryId = Category.Id;
create database ShopDB;

use ShopDB;

-- drop table Product;
-- drop table Category;
-- drop table ProductCategory;

create table Product
(
    Id bigint identity(1,1),
    Name nvarchar(300)
);

alter table Product add constraint PK_Product_Id primary key clustered (Id);

create table Category
(
    Id bigint identity(1,1),
    Name nvarchar(300)
);

alter table Category add constraint PK_Category_Id primary key clustered (Id);

create table ProductCategory
(
    ProductId bigint not null,
    CategoryId bigint not null
);

alter table ProductCategory add constraint FK_ProductCategory_Product foreign key (ProductId) references Product (Id);

alter table ProductCategory add constraint FK_ProductCategory_Category foreign key (CategoryId) references Category (Id);

alter table ProductCategory add constraint PK_ProductCategory_Id primary key clustered (ProductId asc, CategoryId asc);
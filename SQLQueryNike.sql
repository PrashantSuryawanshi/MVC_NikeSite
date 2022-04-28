create table Users
(
UserId int identity(1,1) primary key,
Email varchar(40),
Password varchar (40),
UserName varchar(40),
RoleId int,
)
alter table Users
add constraint FK_RoleId foreign key(RoleId) references Roles(RoleId);
insert into Users values ('admin@admin','Admin','Admin',2)
insert into Users values ('surya@gmail','1234','User',1)



select* from Inventry
create table Inventry
(
ProductId int identity(1,1) primary key,
ProductName varchar (60),
CategoryId int,
ProductPrice decimal(10,2),
)
alter table Users
add constraint FK_CategoryId foreign key(CategoryId) references Category(CategoryId);
select * from Inventry
insert into Inventry values ('Shirt',1,2500.00)
insert into Inventry values ('Jacket',2,8499.00)
insert into Inventry values ('Sneakers',3,10000.00)

drop table Inventry

create table Category
(
CategoryId int identity primary key,
CategoryName varchar (60)
)

insert into Category values ('Formal')
insert into Category values ('Causual')
insert into Category values ('Sport')

select * from Category
create table Roles
(
RoleId int primary key,
RoleName varchar (60)
)
TRUNCATE TABLE Category
select*from Category
select* from Roles
insert into Roles values(1,'Users')
insert into roles values (2,'Admin')
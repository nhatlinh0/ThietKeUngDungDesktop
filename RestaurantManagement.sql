create database RestaurantManagement 
go
use RestaurantManagement
go 

drop table Category
drop table Food
create table Category 
(Id int primary key,
Name nvarchar(30),
Type int 
)
set identity_insert Food off

create table Food 
(ID int primary key,
Name nvarchar(30),
Unit nvarchar(10),
FoodCategoryID int references Category(Id),
Price int,
Notes nvarchar(100)
)

create TABLE [dbo].[Bills](
	[ID] [int] primary key NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[TableID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Discount] [float] NULL,
	[Tax] [float] NULL,
	[Status] [bit] NOT NULL,
	[CheckoutDate] [smalldatetime] NULL,
	[Account] [nvarchar](100) NOT NULL,
)

create TABLE [dbo].[BillDetails](
	[ID] [int] primary key NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[FoodID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
)

CREATE TABLE [dbo].[Account](
	[AccountName] [nvarchar](100) primary key NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[FullName] [nvarchar](1000) NOT NULL,
	[Email] [nvarchar](1000) NULL,
	[Tell] [nvarchar](200) NULL,
	[DateCreated] [smalldatetime] NULL,
)

create TABLE [dbo].[Role](
	[ID] [int] primary key NOT NULL,
	[RoleName] [nvarchar](1000) NOT NULL,
	[Path] [nvarchar](3000) NULL,
	[Notes] [nvarchar](3000) NULL,
)

CREATE TABLE [dbo].[RoleAccount](
	[RoleID] [int] primary key NOT NULL,
	[AccountName] [nvarchar](100) NOT NULL,
	[Actived] [bit] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
)

create TABLE [dbo].[Table](
	[ID] [int] primary key NOT NULL,
	[Name] [nvarchar](1000) NULL,
	[Status] [int] NOT NULL,
	[Capacity] [int] NULL,
)

insert into Category values (1,N'Khai vị',1)
insert into Category values (2,N'Hải sản',1)
insert into Category values (3,N'Gà',1)
insert into Category values (4,N'Cơm',1)
insert into Category values (5,N'Thịt',1)
insert into Category values (6,N'Rau',1)
insert into Category values (7,N'Canh',1)
insert into Category values (8,N'Lẩu',1)
insert into Category values (9,N'Bia',0)
insert into Category values (10,N'Nước ngọt',0)
insert into Category values (11,N'Cà phê',0)
insert into Category values (12,N'Cà phê',0)
select * from Category


insert into Food values (1,N'Mực chiên xù',N'Dĩa',1,20000,'')
insert into Food values (2,N'Gà luộc',N'Dĩa',3,35000,'')
insert into Food values (3,N'Cơm chiên hải sản',N'Dĩa',4,40000,'')
insert into Food values (4,N'Ếch thui rơm',N'Dĩa',2,70000,'')
insert into Food values (5,N'Sò lông nướng',N'Dĩa',2,80000,'')
insert into Food values (6,N'Càng cua hấp',N'Dĩa',2,100000,'')
insert into Food values (7,N'Thịt bò Kobe',N'Dĩa',5,100000,'')
insert into Food values (8,N'Cải thìa xào tỏi',N'Dĩa',6,30000,'')
insert into Food values (9,N'Canh cải thịt băm',N'Tô',7,10000,'')
insert into Food values (10,N'Lẩu gà lá é',N'Nồi',8,110000,'')
insert into Food values (11,N'Bia Heineken',N'Lon',9,5000,'')
insert into Food values (12,N'Bia 333',N'Lon',9,5000,'')
insert into Food values (13,N'Bia Tiger',N'Lon',9,5000,'')
insert into Food values (14,N'Coca cola',N'Lon',10,10000,'')
insert into Food values (15,N'7up',N'Lon',10,9000,'')
insert into Food values (16,N'test',N'test',2,30000,'') 
insert into Food values (17,N'test1',N'test1',2,30000,'')
insert into Food values (18,N'test2',N'test2',2,30000,'')
insert into Food values (19,N'Tôm hấp bia',N'Dĩa',2,100000,'')
insert into Food values (20,N'Mực nướng tỏi ớt',N'Dĩa',2,90000,'') 
select * from Food

create proc usp_ThemMonAn 
@ID int, @Name nvarchar(30), @Unit nvarchar(10), @FCID int, @Price int 
as
begin
	if exists(select * from Food where ID = @ID)
		update Food set ID = @ID, Name = @Name, Unit = @Unit, FoodCategoryID = @FCID, Price = @Price, Notes = '' where ID = @ID
	 else 
		begin
			insert into Food values (@ID, @Name, @Unit, @FCID, @Price, '') 
		end
end

INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'lgcong', N'legiacong', N'Lê Gia Công', N'conglg@dlu.edu.vn', NULL, NULL)
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'pttnga', N'phanthithanhnga', N'Phan Thị Thanh Nga', N'ngaptt@dlu.edu.vn', NULL, CAST(N'2020-06-04T00:00:00' AS SmallDateTime))
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'tdquy', N'thaiduyquy', N'Thái Duy Quý', N'quytd@dlu.edu.vn', NULL, NULL)
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'ttplinh', N'tranthiphuonglinh', N'Trần Thị Phương Linh', N'linhttp@dlu.edu.vn', NULL, NULL)
select * from Account

INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (1, 1, 3, 2)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (2, 1, 4, 1)
select * from BillDetails

INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (1, N'Hóa đơn thanh toán', 5, 150000, 0.05, 0, 1, NULL, N'tdquy')
select * from Bills	

select Bills.ID, Bills.[Name], Bills.TableID, Amount, Discount, Tax, Bills.[Status], CheckoutDate, Account from Bills, [Table] where Bills.TableID = [Table].ID


select *, Amount as SoTienChuaGiamGia, (Amount * Discount) as TongSoTienGiamGia, (Amount) - (Amount * Discount) as ThucThu 
from Bills 

INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (1, N'Adminstrator', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (2, N'Kế toán', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (3, N'Nhân viên thanh toán', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (4, N'Nhân viên phục vụ', NULL, NULL)
select * from Role

INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'lgcong', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (2, N'pttnga', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'tdquy', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (4, N'ttplinh', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (5, N'lgcong', 0, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (6, N'pttnga', 0, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (7, N'tdquy', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (8, N'ttplinh', 1, NULL)
select * from RoleAccount

INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1, N'01', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (2, N'02', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (4, N'03', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (5, N'04', 0, 6)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (6, N'05', 0, 8)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (8, N'06', 0, 8)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1002, N'07', 0, 8)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1003, N'08', 0, 12)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1004, N'09', 0, 12)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1005, N'10', 0, 15)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1006, N'VIP.1', 0, 20)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1007, N'VIP.2', 0, 20)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1008, N'VIP.3', 0, 10)
select * from [Table]
create database HotelManagement
go
use HotelManagement
go

set ansi_nulls on 
set quoted_identifier on

create table KhachHang 
(ID int identity(1,1) primary key,
[Name] nvarchar(1000),
PhoneNumber char(11),
CCCD char(20)
)
go

create table LoaiPhong 
(ID int identity(1,1) primary key,
LoaiPhong char(10) 
)
go

create table Phong 
(ID int identity(1,1) primary key,
[Status] nvarchar(10),
IDLoaiPhong int,
GiaTien int, 
Tang int
)
go

create table HoaDon 
(ID int identity(1,1) primary key,
TongTienPhong float,
TrangThai int
)
go
drop table HoaDon

create table DatPhong 
(IDHoaDon int,
IDKhachHang int,
IDPhong int,
NgayDatPhong datetime,
NgayNhanPhong datetime,
NgayTraPhong datetime,
SoLuongNguoi int,
)
go
 drop table DatPhong

 create trigger NgayDatPhong
 on DatPhong for insert, update
 as
 if update(NgayDatPhong) or update(NgayNhanPhong)
	if exists(select * from inserted i where i.NgayDatPhong > i.NgayNhanPhong)
	begin
		rollback tran
	end

create trigger NgayNhanPhong
 on DatPhong for insert, update
 as
 if update(NgayNhanPhong) or update(NgayTraPhong)
	if exists(select * from inserted i where i.NgayNhanPhong > i.NgayTraPhong)
	begin
		rollback tran
	end

create trigger NgayTraPhong
 on DatPhong for insert, update
 as
 if update(NgayDatPhong) or update(NgayTraPhong)
	if exists(select * from inserted i where i.NgayDatPhong > i.NgayTraPhong)
	begin
		rollback tran
	end

 set identity_insert [dbo].[KhachHang] on
insert into [dbo].[KhachHang] ([ID],[Name],[PhoneNumber],[CCCD]) values (1,N'Nguyễn Nhật Linh','0232146334','068244919577') 
insert into [dbo].[KhachHang] ([ID],[Name],[PhoneNumber],[CCCD]) values (2,N'Lê Viết Đăng Quang','0481959393','046516337200') 
insert into [dbo].[KhachHang] ([ID],[Name],[PhoneNumber],[CCCD]) values (3,N'Tăng Thế Ngọc Song','0824851456','0264523118433') 
insert into [dbo].[KhachHang] ([ID],[Name],[PhoneNumber],[CCCD]) values (4,N'Lại Phú Khôi Nguyên','0849149214','0564071398413') 
 set identity_insert [dbo].[KhachHang] off
 drop table KhachHang

 set identity_insert [dbo].[LoaiPhong] on
 insert into [dbo].[LoaiPhong] ([ID],[LoaiPhong]) values (1,'Single')
 insert into [dbo].[LoaiPhong] ([ID],[LoaiPhong]) values (2,'Double')
 insert into [dbo].[LoaiPhong] ([ID],[LoaiPhong]) values (3,'Triple')
 insert into [dbo].[LoaiPhong] ([ID],[LoaiPhong]) values (4,'Quad')
 set identity_insert [dbo].[LoaiPhong] off

 set identity_insert [dbo].[Phong] on
 insert into [dbo].[Phong] ([ID],[Status],[IDLoaiPhong],[GiaTien],[Tang]) values (1, N'Trống', 1,250000,1) 
 insert into [dbo].[Phong] ([ID],[Status],[IDLoaiPhong],[GiaTien],[Tang]) values (2, N'Trống', 3,750000,1) 
 insert into [dbo].[Phong] ([ID],[Status],[IDLoaiPhong],[GiaTien],[Tang]) values (3, N'Đã đặt', 4,1000000,1) 
 insert into [dbo].[Phong] ([ID],[Status],[IDLoaiPhong],[GiaTien],[Tang]) values (4, N'Trống', 4,1000000,2) 
  insert into [dbo].[Phong] ([ID],[Status],[IDLoaiPhong],[GiaTien],[Tang]) values (5, N'Đang dùng', 2,500000,2) 
 set identity_insert [dbo].[Phong] off
 drop table Phong

 set identity_insert [dbo].[HoaDon] on
 insert into [dbo].[HoaDon] ([ID],[TongTienPhong],[TrangThai]) values 
 (1,0,0)
  insert into [dbo].[HoaDon] ([ID],[TongTienPhong],[TrangThai]) values 
 (2,0,0)
  insert into [dbo].[HoaDon] ([ID],[TongTienPhong],[TrangThai]) values 
 (3,0,1)
  insert into [dbo].[HoaDon] ([ID],[TongTienPhong],[TrangThai]) values 
 (4,0,1)
 set identity_insert [dbo].[HoaDon] off
 drop table HoaDon

 set dateformat dmy
 insert into [dbo].[DatPhong] ([IDHoaDon],[IDKhachHang],[IDPhong],[NgayDatPhong],[NgayNhanPhong],[NgayTraPhong],[SoLuongNguoi]) values
 (1,2,3,'12/03/2020','15/03/2020','22/03/2020',1)
  insert into [dbo].[DatPhong] ([IDHoaDon],[IDKhachHang],[IDPhong],[NgayDatPhong],[NgayNhanPhong],[NgayTraPhong],[SoLuongNguoi]) values
 (2,1,4,'24/8/2019','24/8/2019','26/8/2019',4)
  insert into [dbo].[DatPhong] ([IDHoaDon],[IDKhachHang],[IDPhong],[NgayDatPhong],[NgayNhanPhong],[NgayTraPhong],[SoLuongNguoi]) values
 (3,4,2,'02/12/2020','05/12/2020','08/12/2020',2)
  insert into [dbo].[DatPhong] ([IDHoaDon],[IDKhachHang],[IDPhong],[NgayDatPhong],[NgayNhanPhong],[NgayTraPhong],[SoLuongNguoi]) values
 (4,3,1,'20/05/2023','22/05/2023','25/5/2023',3)
 insert into [dbo].[DatPhong] ([IDHoaDon],[IDKhachHang],[IDPhong],[NgayDatPhong],[NgayNhanPhong],[NgayTraPhong],[SoLuongNguoi]) values
 (3,3,5,'20/05/2023','22/05/2023','25/5/2023',3)

 select * from Phong 
 select * from LoaiPhong
 select * from KhachHang
 select * from DatPhong
 select * from HoaDon

 update [DatPhong] set [NgayDatPhong] = '20/12/2020', [NgayNhanPhong]= '23/12/2020', [NgayTraPhong]='30/12/2023' where IDPhong=1

 select D.ID from Phong A, LoaiPhong B, DatPhong C, KhachHang D
 where A.IDLoaiPhong = B.ID and C.IDPhong = A.ID and C.IDKhachHang = D.ID 
 
select * from Phong, LoaiPhong where Phong.IDLoaiPhong = LoaiPhong.ID and LoaiPhong.ID = 2

select Phong.ID, LoaiPhong.LoaiPhong, KhachHang.[Name], KhachHang.PhoneNumber, KhachHang.CCCD, NgayDatPhong, NgayNhanPhong, NgayTraPhong, TrangThai, SoLuongPhong, GiaTien
from Phong, KhachHang, LoaiPhong, DatPhong , HoaDon
where Phong.ID = DatPhong.IDPhong and KhachHang.ID = DatPhong.IDKhachHang and Phong.IDLoaiPhong = LoaiPhong.ID and DatPhong.IDHoaDon = HoaDon.ID 

select HoaDon.ID from Phong, HoaDon, DatPhong 
where Phong.ID = DatPhong.IDPhong and HoaDon.ID = DatPhong.IDHoaDon

create proc InsertKhachHang 
@id int OUTPUT,
@name nvarchar(100),
@sdt char(10),
@cccd char(12)
as
begin
	insert into KhachHang values (@name,@sdt,@cccd)
	select @id = SCOPE_IDENTITY();
end

select Phong.ID, KhachHang.[Name], KhachHang.CCCD, DatPhong.NgayTraPhong  from Phong, LoaiPhong, KhachHang, DatPhong, HoaDon 
                where Phong.ID = DatPhong.IDPhong and Phong.IDLoaiPhong = LoaiPhong.ID and KhachHang.ID = DatPhong.IDKhachHang and HoaDon.ID = DatPhong.IDHoaDon 
                and KhachHang.[Name] = N'sad' and Phong.ID = 1 and KhachHang.CCCD = '123' and DatPhong.NgayNhanPhong = '30/05/2023' and DatPhong.NgayTraPhong = '30/05/2023'
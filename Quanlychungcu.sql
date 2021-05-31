create database qlchungcu
use qlchungcu

create table khu
(
	makhu int primary key,
	tenkhu nvarchar(50) not null
)
go

create table hogiadinh
(
	maho int primary key,
	tenchuho nvarchar(50),
	sothanhvien int,
)
go

create table canho
(
	macanho int primary key,
	makhu int foreign key (makhu) references khu(makhu),
	maho int foreign key (maho) references hogiadinh(maho),
	loaicanho nvarchar(100) not null,
)
go


create table chucvu
(
	machucvu int primary key,
	tenchucvu nvarchar(100) not null,
)
go

create table nhanvien
(
	manhanvien int primary key,
	machucvu int foreign key (machucvu) references chucvu(machucvu),
	tennhanvien nvarchar(100) not null,
	gioitinh bit not null, -- 1-nam, 0-nu
	cmnd varchar(20) not null,
	sdt varchar(20) not null,
	ngaysinh date not null,
)
go

create table taikhoan
(
	tendangnhap nvarchar(100) primary key,
	manhanvien int foreign key (manhanvien) references nhanvien(manhanvien),
	matkhau nvarchar(100) not null,
	dangnhaplancuoi datetime,
)
go

create table dichvu
(
	madichvu int primary key,
	tendichvu nvarchar(100) not null,
	gia float not null default 0,
)
go

create table hoadondichvu
(
	mahoadon int primary key,
	macanho int foreign key (macanho) references canho(macanho),
	manhanvien int foreign key (manhanvien) references nhanvien(manhanvien),
	tongtien float not null default 0,
	dathanhtoan bit not null, -- 1-da thanh toan, 0-chua thanh toan
	ngaylap date,
)
go

create table chitiethoadon
(
	mahoadon int foreign key (mahoadon) references hoadondichvu(mahoadon) not null,
	madichvu int foreign key (madichvu) references dichvu(madichvu) not null,
	soluong int not null default 0,
	primary key(mahoadon,madichvu)
)
go

create table hopdong
(
	mahopdong int primary key,
	manhanvien int foreign key (manhanvien) references nhanvien(manhanvien),
	macanho int foreign key (macanho) references canho(macanho),
	maho int foreign key (maho) references hogiadinh(maho),
	tenhopdong nvarchar(100) not null,
	giatien float not null default 0,
	thoihan int not null,
	ngayki date not null,
	dahuy bit not null, -- 1-da huy,0- chua huy
	davao bit not null,
	thoigianconlai int,
)
go

create table chitietcanho
(
	mavatdung int primary key,
	macanho int foreign key (macanho) references canho(macanho),
	vatdung nvarchar(100) not null,
	soluong int not null,
	dongia float not null
)
go



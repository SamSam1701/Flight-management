create database if not exists ql_ban_ve_may_bay;
use ql_ban_ve_may_bay;
drop database ql_ban_ve_may_bay;

create table admin
(
	ma_admin int auto_increment,
    username varchar(30) not null,
    password varchar(30) not null,
    ho_ten nvarchar(50),
    email varchar(100) not null,
    
    constraint pk_admin primary key(ma_admin)
);


create table nhan_vien
(
	ma_nv int auto_increment,
    username varchar(30) not null,
    password varchar(30) not null,
    ho_ten nvarchar(50),
    email varchar(100) not null,
    
    constraint pk_nhan_vien primary key(ma_nv)
);

select * from  nhan_vien;


create table khach_hang
(
	ma_kh int auto_increment,
    cmnd varchar(20) not null,
    sdt varchar(10) not null,
    username varchar(30) not null,
    password varchar(30) not null,
    ho_ten nvarchar(50),
    
    constraint pk_khach_hang primary key(ma_kh)
);


create table hoa_don
(
	ma_hd int auto_increment,
    tong_tien decimal not null,
    trang_thai_thanh_toan int not null,
    ma_kh int,
    
    constraint pk_hoa_don primary key(ma_hd)
);


create table ve_chuyen_bay
(
	ma_vcb int auto_increment,
    gia_ve decimal not null,
    trang_thai int not null,
    ma_hd int,
    ma_hanh_khach int,
    ma_loai_ve int,
    ma_cb int,
    
    constraint pk_ve_chuyen_bay primary key(ma_vcb)
);



create table hanh_khach
(
	ma_hanh_khach int auto_increment,
    ho_ten nvarchar(50),
    cmnd varchar(20) not null,
    sdt varchar(10) not null,
    
    constraint pk_hanh_khach primary key(ma_hanh_khach)
);


create table loai_ve
(
	ma_loai_ve int auto_increment,
    gia_ve decimal not null,
    loai_hang int not null,
    ma_sb_den int,
    ma_sb_di int,
    
    constraint pk_loai_ve primary key(ma_loai_ve)
);



create table chuyen_bay
(
	ma_cb int auto_increment,
    ngay_gio datetime,
    thoi_gian_bay time,
    so_ghe_hang_1 int not null,
    so_ghe_hang_2 int not null,
    ma_sb_di int,
    ma_sb_den int,
    
     constraint pk_chuyen_bay primary key(ma_cb)
);




create table san_bay
(
	ma_sb int auto_increment,
    ten_san_bay nvarchar(50),
    dia_chi text,
    
    constraint pk_san_bay primary key(ma_sb)
);



create table chuyen_bay_tram_trung_chuyen
(
	ma_cb int,
    ma_sb int,
    thoi_gian_dung time,
    ghi_chu text,
    
    constraint pk_chuyen_bay_tram_trung_chuyen primary key(ma_cb, ma_sb)
);




create table quy_dinh
(
	ma_qd  int auto_increment,
    ten_quy_dinh nvarchar(50) not null,
    kieu_du_lieu varchar(20) not null,
    gia_tri varchar(20) not null,
    trang_thai int not null,
    
    constraint pk_quy_dinh primary key(ma_qd)
);


alter table hoa_don
add constraint fk_hoa_don foreign key(ma_kh) references khach_hang(ma_kh);

alter table ve_chuyen_bay
add constraint fk_ve_chuyen_bay_hoa_don foreign key(ma_hd) references hoa_don(ma_hd),
add constraint fk_ve_chuyen_bay_hanh_khach foreign key(ma_hanh_khach) references hanh_khach(ma_hanh_khach),
add constraint fk_ve_chuyen_bay_loai_ve foreign key(ma_loai_ve) references loai_ve(ma_loai_ve),
add constraint fk_ve_chuyen_bay_chuyen_bay foreign key(ma_cb) references chuyen_bay(ma_cb);

alter table loai_ve
add constraint fk_loai_ve_san_bay_den foreign key(ma_sb_den) references san_bay(ma_sb),
add constraint fk_loai_ve_san_bay_di foreign key(ma_sb_di) references san_bay(ma_sb);

alter table chuyen_bay
add constraint fk_chuyen_bay_san_bay_di foreign key(ma_sb_di) references san_bay(ma_sb),
add constraint fk_chuyen_bay_san_bay_den foreign key(ma_sb_den) references san_bay(ma_sb);


alter table chuyen_bay_tram_trung_chuyen
add constraint fk_chuyen_bay_tram_trung_chuyen_chuyen_bay foreign key(ma_cb)  references chuyen_bay(ma_cb),
add constraint fk_chuyen_bay_tram_trung_chuyen_san_bay foreign key(ma_sb) references san_bay(ma_sb);


insert into admin(ma_admin,username,password,ho_ten, email) values(null,'sam1701','sam17012001','Nguyễn Phước Sâm','phuocsamqt2001@gmail.com');
insert into admin(ma_admin,username,password,ho_ten, email) values(null,'admin1','ad1234','Nguyễn Văn A','nguyenvana@gmail.com');
insert into admin(ma_admin,username,password,ho_ten, email) values(null,'admin2','ad123456','Nguyễn Văn B','vanb2000@gmail.com');

select * from admin ;

insert into nhan_vien(ma_nv, username, password, ho_ten, email) values(5, 'anhdinh','anhdinh11','Nguyễn Thị Anh Đình','anhdinh@gmail.com');
insert into nhan_vien(ma_nv, username, password, ho_ten, email) values(null, 'hiendi','hiendi11','Lê Hiên Di','vothituyetphuong11@gmail.com');
insert into nhan_vien(ma_nv, username, password, ho_ten, email) values(null, 'hientran','hientran11','Trần Thị Hiền','hientran@gmail.com');
insert into nhan_vien(ma_nv, username, password, ho_ten, email) values(null, 'lephong','lephong11','Nguyễn Lê Phong','lephong@gmail.com');


insert into khach_hang(ma_kh, cmnd, sdt, username, password, ho_ten) values (10, '197406322','0983452134','quephuong','quephuong11','Chung Thị Quế Phương');
insert into khach_hang(ma_kh, cmnd, sdt, username, password, ho_ten) values (null, '197406323','0958762121','thuyhang','thuyhang11','Trần Thị Thúy Hằng');
insert into khach_hang(ma_kh, cmnd, sdt, username, password, ho_ten) values (null, '197406324','0169763836','trongtin','trongtin11','Lê Trọng Tín');
insert into khach_hang(ma_kh, cmnd, sdt, username, password, ho_ten) values (null, '197406326','0981234657','tronguy11','quephuong11','Lê Trọng Uy');



insert into hoa_don(ma_hd, tong_tien, trang_thai_thanh_toan, ma_kh) values (null, 2000000, 0, 10);
insert into hoa_don(ma_hd, tong_tien, trang_thai_thanh_toan, ma_kh) values (null, 2600000, 1, 11);
insert into hoa_don(ma_hd, tong_tien, trang_thai_thanh_toan, ma_kh) values (null, 1239000, 1, 12);
insert into hoa_don(ma_hd, tong_tien, trang_thai_thanh_toan, ma_kh) values (null, 1500000, 0, 13);



insert into ve_chuyen_bay(ma_vcb, gia_ve, trang_thai, ma_hd, ma_hanh_khach, ma_loai_ve, ma_cb) values (20, 2000000, 0,1,10,1,1);
insert into ve_chuyen_bay(ma_vcb, gia_ve, trang_thai, ma_hd, ma_hanh_khach, ma_loai_ve, ma_cb) values (null, 2600000, 1,2,11,2,2);
insert into ve_chuyen_bay(ma_vcb, gia_ve, trang_thai, ma_hd, ma_hanh_khach, ma_loai_ve, ma_cb) values (null, 1239000, 1,3,12,3,3);
insert into ve_chuyen_bay(ma_vcb, gia_ve, trang_thai, ma_hd, ma_hanh_khach, ma_loai_ve, ma_cb) values (null, 1500000, 0,4,13,4,4);


insert into hanh_khach(ma_hanh_khach, ho_ten, cmnd, sdt) values (10, 'Chung Thị Quế Phương','197406322','0983452134');
insert into hanh_khach(ma_hanh_khach, ho_ten, cmnd, sdt) values (null, 'Trần Thị Thúy Hằng','197406323','0958762121');
insert into hanh_khach(ma_hanh_khach, ho_ten, cmnd, sdt) values (null, 'Lê Trọng Tín','197406324','0169763836');
insert into hanh_khach(ma_hanh_khach, ho_ten, cmnd, sdt) values (null, 'Lê Trọng Uy','197406326','0981234657');



insert into loai_ve (ma_loai_ve, gia_ve, loai_hang, ma_sb_den, ma_sb_di) values (null,2000000, 1, 2,1);
insert into loai_ve (ma_loai_ve, gia_ve, loai_hang, ma_sb_den, ma_sb_di) values (null,2600000, 2, 1,2);
insert into loai_ve (ma_loai_ve, gia_ve, loai_hang, ma_sb_den, ma_sb_di) values (null,1239000, 1, 2,3);
insert into loai_ve (ma_loai_ve, gia_ve, loai_hang, ma_sb_den, ma_sb_di) values (null,1500000, 2, 3,2);


insert into chuyen_bay (ma_cb, ngay_gio, thoi_gian_bay, so_ghe_hang_1, so_ghe_hang_2, ma_sb_di, ma_sb_den) values (null,'2022-06-20 12:00:00','02:10:00',137,137,1,2);
insert into chuyen_bay (ma_cb, ngay_gio, thoi_gian_bay, so_ghe_hang_1, so_ghe_hang_2, ma_sb_di, ma_sb_den) values (null,'2022-07-01 01:15:00','02:10:00',137,137,2,1);
insert into chuyen_bay (ma_cb, ngay_gio, thoi_gian_bay, so_ghe_hang_1, so_ghe_hang_2, ma_sb_di, ma_sb_den) values (null,'2022-06-31 15:00:00','01:00:00',137,137,1,4);
insert into chuyen_bay (ma_cb, ngay_gio, thoi_gian_bay, so_ghe_hang_1, so_ghe_hang_2, ma_sb_di, ma_sb_den) values (null,'2022-06-31 15:00:00','01:10:00',137,137,1,3);


insert into san_bay (ma_sb, ten_san_bay, dia_chi) values (null, "Tân Sơn Nhất", "Trường Sơn, Phường 2, Tân Bình, Thành phố Hồ Chí Minh");
insert into san_bay (ma_sb, ten_san_bay, dia_chi) values (null, "Nội Bài", "Phú Minh, Sóc Sơn, Hà Nội");
insert into san_bay (ma_sb, ten_san_bay, dia_chi) values (null, "Phú Bài", "Cầu Phú Bài, Khu 8, Hương Thủy, Thừa Thiên Huế");
insert into san_bay (ma_sb, ten_san_bay, dia_chi) values (null, "Đà Nẵng", "3642+5WH, Nguyễn Văn Linh, Hòa Thuận Tây, Hải Châu, Đà Nẵng 550000");


insert into chuyen_bay_tram_trung_chuyen(ma_cb, ma_sb, thoi_gian_dung, ghi_chu) values (1,3,'00:05:00',null);
insert into chuyen_bay_tram_trung_chuyen(ma_cb, ma_sb, thoi_gian_dung, ghi_chu) values (2,3,'00:10:00',null);
insert into chuyen_bay_tram_trung_chuyen(ma_cb, ma_sb, thoi_gian_dung, ghi_chu) values (3,3,'00:05:00',null);
insert into chuyen_bay_tram_trung_chuyen(ma_cb, ma_sb, thoi_gian_dung, ghi_chu) values (4,3,'00:05:00',null);


insert into quy_dinh (ma_qd, ten_quy_dinh, kieu_du_lieu, gia_tri, trang_thai) values (null, "Quy định 1", "dữ liệu 1", "giá trị 1", 0);
insert into quy_dinh (ma_qd, ten_quy_dinh, kieu_du_lieu, gia_tri, trang_thai) values (null, "Quy định 2", "dữ liệu 2", "giá trị 2", 1);
insert into quy_dinh (ma_qd, ten_quy_dinh, kieu_du_lieu, gia_tri, trang_thai) values (null, "Quy định 3", "dữ liệu 3", "giá trị 3", 1);
insert into quy_dinh (ma_qd, ten_quy_dinh, kieu_du_lieu, gia_tri, trang_thai) values (null, "Quy định 4", "dữ liệu 4", "giá trị 4", 0);


select * from nhan_vien;

select * from admin
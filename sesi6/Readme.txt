a. Buat Database baru dengan nama staf
create database db_staff;

b. Buat Table data_staff dengan desain spt dibawah ini :
	nik		int
	nama		varchar(50)
	alamat	varchar(200)
	handphone	varchar(15)
use db_staff;
create table data_staff(
nik int,
nama varchar(50),
alamat varchar(200),
handphone varchar(15));

c. Masukkan data ke dalam table data_staff sesuai dengan table diatas
d. Masukkan lebih dari 1 data ke dalam table data masih dalam table diatas.
insert into data_staff (nik,nama,alamat,handphone)  values 
(123,'farhan','jakarta','0822994565'),(321,'rifqi','bandung','0822996514');

e. Tambahkan kolom baru pada table data_staff yaitu joindate sekaligus masukan 1 data kedalam table 
data_staff
alter table data_staff add joindate int;

f. Tampilkan 2 data SQL kalian sekarang 
select top 2 * from data_staff;

g. Tampilkan 3 data SQL kalian sekarang 
select top 3 * from data_staff;

h. Buat Table baru staffoutsource dengan isi yang sama seperti data_staf
create table staff_outsource(
nik int,
nama varchar(50),
alamat varchar(200),
handphone varchar(15),
joindate int);

i. Masukkan 10 data baru ke table staffoutsource
insert into staff_outsource  
values (645,'rey','jakarta','0813654898',2022),
(645,'rey','jakarta','0813654898',2022),
(645,'rey','jakarta','0813654898',2022),
(645,'rey','jakarta','0813654898',2022),
(645,'rey','jakarta','0813654898',2022),
(646,'reyn','surabaya','0831649764',2021),
(647,'rio','kalimantan','0811659714',2020),
(648,'rani','papua','0813131313',2019),
(649,'rey','padang','0813656565',2018),
(650,'mons','jayakarta','0815151515',2017); 

j. Tampilkan data pada 2 Table yang sudah kalian buat dengan joindate yang sama
select * from data_staff
join staff_outsource
on data_staff.joindate=staff_outsource.joindate;

k. Tampilkan seluruh data sebelah kanan yang sama pada table staff_outsource
select * from data_staff a right join staff_outsource b on a.joindate = b.joindate;

l. Tampilkan seluruh data staff sebelah kiri yang punya nilai tidak sama akan bernilai null
select * from data_staff a left join staff_outsource b on a.joindate = b.joindate;

m. Tampilkan seluruh data antara 2 tabel baik itu tidak punya kesamaan dan bernilai null.
select * from data_staff a full join staff_outsource b on a.joindate = b.joindate;

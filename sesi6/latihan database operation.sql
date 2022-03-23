a
create database db_staff;


b
use db_staff;
create table data_staff(
nik int,
nama varchar(50),
alamat varchar(200),
handphone varchar(15))

c - d
insert into data_staff (nik,nama,alamat,handphone)  values 
(123,'farhan','jakarta','0822994565'),(321,'rifqi','bandung','0822996514');

select * from data_staff;

e

alter table data_staff add joindate int;

f
select top 2 * from data_staff;

insert into data_staff values (213,'udin','jakarta','0813654898',2017); 

g
select top 3 * from data_staff;

h
create table staff_outsource(
nik int,
nama varchar(50),
alamat varchar(200),
handphone varchar(15),
joindate int);

select * from staff_outsource;

i

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

select * from staff_outsource;

j

select * from data_staff
join staff_outsource
on data_staff.joindate=staff_outsource.joindate;

k

select * from data_staff a right join staff_outsource b on a.joindate = b.joindate;

l

select * from data_staff a left join staff_outsource b on a.joindate = b.joindate;

m

select * from data_staff a full join staff_outsource b on a.joindate = b.joindate;

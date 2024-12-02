create sequence users_id start 1;
create table karyawan(
	id_karyawan character(6) default 'Kr-'||nextval('users_id') primary key,
	nama varchar(30),
	id_dep character varying references departemen(id_dep),
	id_jabatan int references jabatan(id_jabatan),
	salary numeric
);
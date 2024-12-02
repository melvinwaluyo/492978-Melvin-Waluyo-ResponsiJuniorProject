create or replace function kr_select()
returns table
(
    _id_karyawan character,
    _nama character varying,
    _id_dep character varying,
    _nama_dep character varying,
    _salary numeric,
    _nama_jabatan character varying
)
language plpgsql
as
'
begin
    return query
    select 
        karyawan.id_karyawan, 
        karyawan.nama, 
        departemen.id_dep, 
        departemen.nama_dep,
		jabatan.salary,
		jabatan.nama_jabatan
    from 
        departemen 
    join 
        karyawan on karyawan.id_dep = departemen.id_dep
    join
        jabatan on karyawan.id_jabatan = jabatan.id_jabatan;
end
'
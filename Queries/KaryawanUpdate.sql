create or replace function kr_update
(
    _id_karyawan character varying,
    _nama character varying,
    _id_dep character varying,
    _id_jabatan int,
    _salary numeric
)
returns int AS
$$
begin
    -- Update karyawan table
    update karyawan
    set 
        nama = _nama,
        id_dep = _id_dep,
        id_jabatan = _id_jabatan
    where id_karyawan = _id_karyawan;

    -- Update jabatan table
    update jabatan
    set 
        salary = _salary
    where id_jabatan = _id_jabatan;

    if found then
        return 1;
    else
        return 0;
    end if;
end
$$
language plpgsql;
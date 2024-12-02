create or replace function kr_insert
(
    _nama character varying,
    _id_dep character varying,
    _id_jabatan int,
    _salary numeric
)
returns int AS
$$
begin
    -- Insert into karyawan table
    insert into public.karyawan
    (
        nama,
        id_dep,
        id_jabatan
    )
    values
    (
        _nama,
        _id_dep,
        _id_jabatan
    );

    -- Insert into jabatan table
    insert into public.jabatan
    (
        id_jabatan,
        salary
    )
    values
    (
        _id_jabatan,
        _salary
    )
    on conflict (id_jabatan) do update
    set salary = excluded.salary;

    return 1;
end
$$
language plpgsql;
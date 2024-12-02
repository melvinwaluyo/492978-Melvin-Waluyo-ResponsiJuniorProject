create or replace function kr_delete (_id_karyawan character varying)
RETURNS int AS

'
begin
	delete from public.karyawan
	WHERE id_karyawan=_id_karyawan;
	if found then
		return 1;
	else
		return 0;
	end if;
end
'
language plpgsql
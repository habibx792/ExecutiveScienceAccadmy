--=modifiaction in db
--del this due to reddant
--ALTER TABLE StudentTb
--DROP COLUMN address;
use accadmyDb;
ALTER TABLE StudentTb
DROP COLUMN mark_of_identification;

select * from StudentTb;
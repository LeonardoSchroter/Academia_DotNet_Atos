
create database atosEntity2

use atosEntity2

create login AtosEntity2 with password='AtosEntity2';
create user AtosEntity2 from login AtosEntity2;
exec sp_addrolemember 'DB_DATAREADER', 'AtosEntity2';
exec sp_addrolemember 'DB_DATAWRITER', 'AtosEntity2';
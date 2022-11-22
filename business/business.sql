create database business
use business;

create table clients (
	id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	name varchar(60) NOT NULL,
	age int,
	email varchar(70),
	gender varchar(1),
	phone_number varchar(10),
	place_birth varchar (255),
	birth_date date
);


insert into clients(name, age, gender, phone_number, place_birth, birth_date, email) values ('Ivan Ali Rodriguez Vasquez', 30, 'H', '9531075019', 'Ciudad Ixtepec, Oaxaca', '1992-09-17', 'arodriguez@gmail.com');
insert into clients(name, age, gender, phone_number, place_birth, birth_date, email) values ('Fatima Yazmin Rodriguez Vasquez', 27, 'M', '9561008113', 'Ciudad Ixtepec, Oaxaca', '1995-06-10', 'frodriguez@gmail.com');
insert into clients(name, age, gender, phone_number, place_birth, birth_date, email) values ('Diana Grisell Rodriguez Vasquez', 23, 'H', '4811865554', 'Ciudad Ixtepec, Oaxaca', '1999-05-11', 'drodriguez@gmail.com');
insert into clients(name, age, gender, phone_number, place_birth, birth_date, email) values ('Marco Antonio Rodriguez Zamora', 59, 'H', '6740557507', 'Ciudad de Mexico, Mexico', '1965-05-13', 'mrodriguez@gmail.com');
insert into clients(name, age, gender, phone_number, place_birth, birth_date, email) values ('Soledad Vasquez Hernandez', 58, 'M', '7817629074', 'Ciudad Ixtepec, Oaxaca', '1964-09-17', 'svasquez@gmail.com');
insert into clients(name, age, gender, phone_number, place_birth, birth_date, email) values ('Elia Hernandez Castellanos', 67, 'M', '8575120517', 'Ciudad Ixtepec, Oaxaca', '1955-05-15', 'ehernandez@gmail.com');
insert into clients(name, age, gender, phone_number, place_birth, birth_date, email) values ('Vicente Vasquez Echazarreta', 70, 'H', '5881641368', 'Ciudad Ixtepec, Oaxaca', '1952-02-08', 'vvasquez@gmail.com');
insert into clients(name, age, gender, phone_number, place_birth, birth_date, email) values ('Rafael Vasquez Hernandez', 38, 'H', '7680687065', 'Ciudad Ixtepec, Oaxaca', '1984-05-18', 'rvasquez@gmail.com');
insert into clients(name, age, gender, phone_number, place_birth, birth_date, email) values ('William Nolasco de la Cruz', 30, 'H', '3186237972', 'Ciudad Ixtepec, Oaxaca', '1992-07-22', 'wnolasco@gmail.com');
insert into clients(name, age, gender, phone_number, place_birth, birth_date, email) values ('Dulce Margarita Hernandez Castro', 26, 'M', '5340576494', 'Laollaga, Oaxaca', '1996-07-10', 'dhernandez@gmail.com');

CREATE PROCEDURE client_list AS
SELECT * FROM clients

EXEC client_list

select * from clients


drop table clients

select
    'data source=' + @@servername +
    ';initial catalog=' + db_name() +
    case type_desc
        when 'WINDOWS_LOGIN' 
            then ';trusted_connection=true'
        else
            ';user id=' + suser_name() + ';password=<<YourPassword>>'
    end
    as ConnectionString
from sys.server_principals
where name = suser_name()
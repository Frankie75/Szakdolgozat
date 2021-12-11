--create table uf_torzs (

--uf_id						int primary key identity,
--unev						varchar(40),
--tel							varchar(20),
--iranyitoszam				int,
--helyseg						varchar(15),
--cim							varchar(30),
--email						varchar(30),
--);

create table gk_torzs (

gk_id						int primary key identity,
gyarto						varchar(15),
tipus						varchar(15),
szin						varchar(15),
alvazszam					varchar(30),
rendszam					varchar(15),
muszaki_datum				datetime,
dokumentumok				bit,
elsosegely					bit,
potkerek					bit,
elakadasjelzo				bit,
antenna						bit,
radio						bit,
izzokeszlet					bit,
emelo						bit,
navigacio					bit,
melleny						bit,
egyeb						varchar(255)
);

--create table szerzodesek (

--szerzodes_id				int identity,
--uf_id						int,
--gk_id						int,
--kiadas_datum				datetime,
--visszavet_datum				datetime,
--kaucio						int,
--lejarat_datum				datetime,
--napidij						int,
--serules_leiras_kiadas		varchar(255),
--serules_leiras_visszavet	varchar(255),
--serules_abra_kiadas			tinyint,
--serules_abra_visszavet		tinyint,
--uzemanyagszint_kiadas		tinyint,
--uzemanyagszint_visszavet	tinyint,
--kilometer_kiadas			int,
--kilometer_visszavet			int,
--primary key (szerzodes_id),
--foreign key (uf_id) references uf_torzs,
--foreign key (gk_id) references gk_torzs
--);
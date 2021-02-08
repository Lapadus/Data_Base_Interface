drop table lista_organizare;
drop table echipamente;
drop table orar_sali;
drop table sali_invatare;
drop table orar_elevi;
drop table discipline;
drop table lista_participanti;
drop table elevi;
drop table angajati;
drop table proiecte;
drop table functii;

--*************TABEL 1-FUNCTII********************************************************

create table functii (
cod_functie number(4) constraint pk_functii primary key,
nume_functie varchar2(30) constraint vf_functie not null,
salariu_min number(4),
salariu_max number(4),
constraint valid_salariu check(salariu_min<nvl(salariu_max, salariu_min+1)));

insert into functii
values (1, 'profesor', 3200, 3700);
commit;

insert into functii
values (2, 'contabil', 3000, 3500);
commit;

insert into functii
values (3, 'secretar', 2700, 3000);
commit;

insert into functii
values (4, 'director', 5000, 5500);
commit;

insert into functii
values (5, 'informatician', 4000, 4500);
commit;

insert into functii
values (6, 'bibliotecar', 1500, 1700);
commit;

insert into functii
values (7, 'laborant', 2000, 2500);
commit;

insert into functii
values (8, 'medic', 3500, 4000);
commit;

insert into functii
values (9, 'personal_auxiliar', 1000, 1500);
commit;
--**************TABEL 2-PROIECTE*********************************************************

create table proiecte(
cod_proiect varchar(20) constraint pk_proiecte primary key,
nume_proiect varchar(40) constraint vf_nume_proiect not null constraint vf_unic_nume unique,
data_inceput date constraint vf_data_inceput not null,
data_sfarsit date constraint vf_data_sfarsit not null,
constraint vf_data check(data_inceput<nvl(data_sfarsit, data_inceput+1)));

insert into proiecte(cod_proiect, nume_proiect, data_inceput, data_sfarsit)
values('Eco', 'Planeta_eco', '13-FEB-2021', '14-FEB-2021');
commit;

insert into proiecte(cod_proiect, nume_proiect, data_inceput, data_sfarsit)
values('Travel', 'Erasmus', '15-FEB-2021', '16-FEB-2021');
commit;

insert into proiecte(cod_proiect, nume_proiect, data_inceput, data_sfarsit)
values('Sport', 'Promenada_Inimilor', '17-FEB-2021', '18-FEB-2021');
commit;

insert into proiecte(cod_proiect, nume_proiect, data_inceput, data_sfarsit)
values('Arta', 'Arta_n_dar', '19-FEB-2021', '20-FEB-2021');
commit;

insert into proiecte(cod_proiect, nume_proiect, data_inceput, data_sfarsit)
values('Natura', 'Orientare_Turistica', '21-FEB-2021', '22-FEB-2021');
commit;

--**********TABEL 3-ANGAJATI************************************************************

create table angajati(
cod_angajat number(4) constraint pk_angajat primary key,
nume varchar(30) constraint nume_not_null not null,
prenume varchar(30) constraint prenume_not_null not null,
email varchar(50) constraint email_not_null not null constraint angajat_email_unic unique,
telefon varchar(10) constraint tel_not_null not null constraint tel_unic unique,
data_angajare date constraint data_not_null not null,
salariu number(4) constraint salariu_not_null not null,
cod_proiect varchar(20) constraint fk_proiecte references proiecte(cod_proiect) on delete cascade,
cod_functie number(4) constraint fk_functii references functii(cod_functie) on delete cascade constraint functie_not_null not null );

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                     cod_proiect, cod_functie)
values(10, 'Albu', 'Iulia', 'albu.iulia@bd.ro', '0725197655', '2-JAN-2010', 3200, 'Eco', 1);
commit;

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                      cod_functie)
values(11, 'Ionescu', 'Ana', 'ionescu.ana@bd.ro', '0775482294', '10-SEP-2011', 2800, 3);
commit;

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                     cod_proiect, cod_functie)
    values(12, 'Popescu', 'Maria', 'popescu.maria@bd.ro', '0724865510', '20-AUG-2015', 3800, 'Travel', 1);
commit;

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                     cod_functie)
values(13, 'Barna', 'Ion', 'barna.ion@bd.ro', '0742987311', '15-FEB-2006', 4200, 5);
commit;

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                     cod_proiect, cod_functie)
values(14, 'Arghezi', 'Rares', 'argezi.rares@bd.ro', '0798427100', '30-MAY-2015', 3100, 'Arta', 2);
commit;

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                     cod_proiect, cod_functie)
values(15, 'Ecobescu', 'Tudor', 'ecobescu.tudor@bd.ro', '0745726411', '13-OCT-2004', 5200, 'Travel', 1);
commit;

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                     cod_proiect, cod_functie)
values(16, 'Banica', 'Daria', 'banica.daria@bd.ro', '0722004977', '9-DEC-1999', 3400, 'Sport', 1);
commit;

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                     cod_functie)
values(17, 'Checiu', 'Simona', 'checiu.simona@bd.ro', '0774813340', '23-MAR-2010', 1650, 6);
commit;

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                      cod_functie)
values(18, 'Elian', 'Robert', 'elian.robert@bd.ro', '0777003105', '17-APR-2017', 3200, 2);
commit;

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                     cod_functie)
values(19, 'Mares', 'Raluca', 'mares.raluca@bd.ro', '0771664855', '7-JUL-2000', 2700, 3);
commit;

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                     cod_functie)
values(20, 'Avram', 'Vlad', 'avram.vlad@bd.ro', '0709994833', '12-NOV-2015', 2200, 7);
commit;

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                     cod_proiect, cod_functie)
values(21, 'Stoian', 'Mihai', 'stoian.mihai@bd.ro', '0799703411', '10-DEC-1985', 4000, 'Sport', 8);
commit;

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                      cod_functie)
values(22, 'Lapus', 'Mara', 'lapus.mara@bd.ro', '0774992241', '19-JAN-2010', 2300, 7);
commit;

insert into angajati(cod_angajat, nume, prenume, email, telefon, data_angajare, salariu,
                      cod_functie)
values(23, 'Dobre', 'Katia', 'dobre.katia@bd.ro', '0729741322', '17-DEC-2012', 1500, 9);
commit;

--****************TABEL 4-ELEVI*******************************************************************

create table elevi(
cod_elev number(4) constraint pk_elev primary key,
nume varchar(30) constraint elev_nume_not_null not null,
prenume varchar(30) constraint elev_prenume_not_null not null,
email varchar(30) constraint elev_email_not_null not null constraint email_unic unique,
clasa varchar(4) constraint clasa_not_null not null ,
specializare varchar(30) constraint specializare_not_null not null);

insert into elevi (cod_elev, nume, prenume, email, clasa, specializare)
values(30, 'Borta', 'Horia', 'borta.horia@elev.ro', '10A', 'filologie');
commit;

insert into elevi (cod_elev, nume, prenume, email, clasa, specializare)
values(31, 'Dumitru', 'Vasile', 'dumitru.vasile@elev.ro', '12B', 'matematica-informatica');
commit;

insert into elevi (cod_elev, nume, prenume, email, clasa, specializare)
values(32, 'Stan', 'Camelia', 'stan.camelia@elev.ro', '11C', 'matematica-informatica');
commit;

insert into elevi (cod_elev, nume, prenume, email, clasa, specializare)
values(33, 'Banciu', 'Mirona', 'banciu.mirona@elev.ro', '9D', 'stiinte ale naturii');
commit;

insert into elevi (cod_elev, nume, prenume, email, clasa, specializare)
values(34, 'Bibescu', 'Bianca', 'bibescu.bianca@elev.ro', '12A', 'economie');
commit;

insert into elevi (cod_elev, nume, prenume, email, clasa, specializare)
values(35, 'Miron', 'Stefania', 'miron.stefania@elev.ro', '11D', 'filologie');
commit;

insert into elevi (cod_elev, nume, prenume, email, clasa, specializare)
values(36, 'Ichim', 'Ion', 'ichim.ion@elev.ro', '9B', 'stiinte ale naturii');
commit;

insert into elevi (cod_elev, nume, prenume, email, clasa, specializare)
values(37, 'Iacob', 'Radu', 'iacob.radu@elev.ro', '12C', 'filologie');
commit;

insert into elevi (cod_elev, nume, prenume, email, clasa, specializare)
values(38, 'Ifrim', 'Razvan', 'ifrim.razvan@elev.ro', '9E', 'matematica-informatica');
commit;

insert into elevi (cod_elev, nume, prenume, email, clasa, specializare)
values(39, 'Tabacu', 'Angela', 'tabacu.angela@elev.ro', '10F', 'stiinte ale naturii');
commit;

--****************Tabel 5- Lista participanti****************************************************************

create table lista_participanti(
cod_elev number(4)constraint fk_elevi_lista references elevi(cod_elev) on delete cascade,
cod_proiect varchar(20) constraint fk_proiecte_lista references proiecte(cod_proiect) on delete cascade,
constraint ck_lista_participanti primary key(cod_elev, cod_proiect));

insert into lista_participanti(cod_elev, cod_proiect)
values(30, 'Eco');
commit;

insert into lista_participanti(cod_elev, cod_proiect)
values(30, 'Travel');
commit;

insert into lista_participanti(cod_elev, cod_proiect)
values(31, 'Sport');
commit;

insert into lista_participanti(cod_elev, cod_proiect)
values(32, 'Arta');
commit;

insert into lista_participanti(cod_elev, cod_proiect)
values(33, 'Travel');
commit;

insert into lista_participanti(cod_elev, cod_proiect)
values(34, 'Sport');
commit;

insert into lista_participanti(cod_elev, cod_proiect)
values(34, 'Arta');
commit;

insert into lista_participanti(cod_elev, cod_proiect)
values(35, 'Natura');
commit;

insert into lista_participanti(cod_elev, cod_proiect)
values(35, 'Sport');
commit;

insert into lista_participanti(cod_elev, cod_proiect)
values(36, 'Travel');
commit;

insert into lista_participanti(cod_elev, cod_proiect)
values(37, 'Natura');
commit;

insert into lista_participanti(cod_elev, cod_proiect)
values(38, 'Arta');
commit;

insert into lista_participanti(cod_elev, cod_proiect)
values(39, 'Arta');
commit;

--**********************TABEL 6-DISCIPLINE**************************************************************

create table discipline(
cod_disciplina number(3) constraint pk_disciplina primary key, 
nume varchar(20) constraint disciplina_nume_not_null not null,
nr_ore number(2));

insert into discipline(cod_disciplina, nume, nr_ore)
values (40, 'Matematica', 20);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (41, 'Romana', 30);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (42, 'Istorie', 10);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (43, 'Geografie', 10);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (44, 'Engleza', 40);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (45, 'Franceza', 30);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (46, 'Religie', 15);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (47, 'Biologie', 20);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (48, 'Fizica', 30);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (49, 'Chimie', 20);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (50, 'Ed Fizica', 10);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (51, 'Economie', 5);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (52,'Informatica', 30);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (53, 'Muica', 20);
commit;

insert into discipline(cod_disciplina, nume, nr_ore)
values (54, 'Desen', 10);
commit;

--**********************TABEL 7-ORAR_ELEVI**************************************************************

create table orar_elevi(
cod_elev number(4) constraint fk_elev_orar references elevi(cod_elev) on delete cascade,
cod_disciplina number(3) constraint fk_disciplina_orar references discipline(cod_disciplina) on delete cascade,
constraint ck_orar_elevi primary key(cod_elev, cod_disciplina));

insert into orar_elevi(cod_elev, cod_disciplina)
values (30, 42);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (30, 41);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (31, 40);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (31, 48);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (32, 48);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (32, 40);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (33, 49);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (34, 51);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (35, 42);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (36, 47);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (37, 41);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (38, 40);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (39, 48);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (38, 48);
commit;

insert into orar_elevi(cod_elev, cod_disciplina)
values (39, 49);
commit;

--**********************TABEL 8-SALI_INVATARE**************************************************************

create table sali_invatare(
cod_sala number(3) constraint pk_sali_invatare primary key,
nume varchar(40) constraint nume_sala_not_null not null,
etaj number(1) constraint etaj_not_null not null constraint etaj_pozitiv check(etaj>=0),
nr_locuri number(2) constraint nr_locuri_not_null not null constraint locuri_pozitiv check(nr_locuri>0));

insert into sali_invatare(cod_sala, nume, etaj, nr_locuri)
values(60, 'laborator_informatica', 0, 30);
commit;

insert into sali_invatare(cod_sala, nume, etaj, nr_locuri)
values(61, 'laborator_chimie', 0, 30);
commit;

insert into sali_invatare(cod_sala, nume, etaj, nr_locuri)
values(62, 'laborator_fizica', 0, 30);
commit;

insert into sali_invatare(cod_sala, nume, etaj, nr_locuri)
values(63, 'laborator_biologie', 0, 35);
commit;

insert into sali_invatare(cod_sala, nume, etaj, nr_locuri)
values(64, 'sala_sport', 0, 45);
commit;

insert into sali_invatare(cod_sala, nume, etaj, nr_locuri)
values(65, 'sala_clasa', 1, 30);
commit;

insert into sali_invatare(cod_sala, nume, etaj, nr_locuri)
values(66, 'sala_limbi_straine', 1, 35);
commit;

insert into sali_invatare(cod_sala, nume, etaj, nr_locuri)
values(67, 'sala_arte', 1, 30);
commit;

--**********************TABEL 9-ORAR_SALI**************************************************************

create table orar_sali(
cod_sala number(2) constraint fk_sala_orar_sali references sali_invatare(cod_sala) on delete cascade,
cod_disciplina number(3) constraint fk_disciplina_sali references discipline(cod_disciplina) on delete cascade,
constraint ck_orar_sali primary key(cod_sala, cod_disciplina));

insert into orar_sali(cod_sala, cod_disciplina)
values(60, 52);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(61, 49);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(62, 48);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(63, 47);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(64, 50);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(65, 40);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(65, 41);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(65, 42);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(65, 43);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(65, 46);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(66, 44);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(66, 45);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(65, 51);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(67, 53);
commit;

insert into orar_sali(cod_sala, cod_disciplina)
values(67, 54);
commit;

--**********************TABEL 10-ECHIPAMENTE**************************************************************

create table echipamente(
cod_echipament number(3) constraint pk_echipament primary key, 
nume varchar(20) constraint nume_echipament_not_null not null,
nr_disponibile int constraint nr_disponibile_not_null not null constraint disp_pozitiv check(nr_disponibile>=0), 
producator varchar(20));

insert into echipamente(cod_echipament, nume, nr_disponibile, producator)
values(70, 'scaun', 200, 'Ikea');
commit;

insert into echipamente(cod_echipament, nume, nr_disponibile, producator)
values(71, 'banca', 2000, 'Kika');
commit;

insert into echipamente(cod_echipament, nume, nr_disponibile)
values(72, 'tabla', 30);
commit;

insert into echipamente(cod_echipament, nume, nr_disponibile)
values(73, 'dulap', 100);
commit;

insert into echipamente(cod_echipament, nume, nr_disponibile, producator)
values(74, 'calculator', 1000, 'Dell');
commit;

insert into echipamente(cod_echipament, nume, nr_disponibile, producator)
values(75, 'ustensile_chimie', 500, 'Chemistry');
commit;

insert into echipamente(cod_echipament, nume, nr_disponibile, producator)
values(76, 'ustensle_fizica', 700, 'Volt');
commit;

insert into echipamente(cod_echipament, nume, nr_disponibile, producator)
values(77, 'pian', 5, 'Yamaha');
commit;

insert into echipamente(cod_echipament, nume, nr_disponibile, producator)
values(78, 'chitara', 125, 'Yamaha');
commit;

insert into echipamente(cod_echipament, nume, nr_disponibile, producator)
values(79, 'casetofon', 10, 'Sony');
commit;

insert into echipamente(cod_echipament, nume, nr_disponibile, producator)
values(80, 'video-proiector', 200, 'Sony');
commit;

--**********************TABEL 11-LISTA_ORGANIZARE**************************************************************

create table lista_organizare(
cod_echipament number(3) constraint fk_echipament_org references echipamente(cod_echipament),
cod_sala number(3) constraint fk_echipament_sala references sali_invatare(cod_sala),
constraint ck_lista_organizare primary key(cod_echipament, cod_sala));

insert into lista_organizare(cod_echipament, cod_sala)
values (70, 65);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (70, 66);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (70, 62);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (70, 61);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (71, 61);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (71, 62);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (71, 63);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (72, 61);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (72, 60);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (74, 60);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (75, 61);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (76, 62);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (77, 67);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (78, 67);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (79, 67);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (80, 63);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (80, 65);
commit;

insert into lista_organizare(cod_echipament, cod_sala)
values (80, 66);
commit;

select cod_disciplina
from orar_elevi;
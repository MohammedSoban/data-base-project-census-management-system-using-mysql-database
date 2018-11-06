create database CENSUS_DB;

use CENSUS_DB;

CREATE TABLE LOGIN(USERNAME VARCHAR(50),PASS varchar(50));

INSERT INTO LOGIN VALUES('soban96','Soban123.'),('syedfarna','dante@farna'),('aftab','aftab123');

select *from dataEntry;

create table dataEntry(CNIC varchar(300) primary key unique,FirstName varchar(300),LastName varchar(300),FullName varchar(300),DOByear varchar(300),DOBmonth varchar(300),DOBday varchar(300),Age varchar(300),Address varchar(300),Area varchar(300),District varchar(300),city varchar(300),ZipCode varchar(300),Province varchar(300), FeMale_or_Male varchar(300),FatherName varchar(300),MotherName varchar(300),FatherNIC varchar(300),NumberOfSibling varchar(300),qualification varchar(300),income varchar(300),NameOfOrginization varchar(300),NumberOfChildren varchar(300));


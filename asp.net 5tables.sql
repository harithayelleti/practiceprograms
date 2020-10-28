create table student(

student_id int not null Primary Key,
first_name varchar(max),
last_name varchar(max),
location varchar(100),
)

insert into student values(101,'haritha','yelleti','vizag')
insert into student values(102,'Roopa','Pallisetti','Pune')
insert into student values(103,'sruthi','kupili','vizag')
insert into student values(104,'teja','yelleti','hyd')
create table employee(

emp_id int not null Primary Key,
first_name varchar(max),
last_name varchar(max),
location varchar(100),
)

insert into employee values(11,'teekshu','yelleti','vizag')
insert into employee values(12,'Kavya','vegi','Pune')
insert into employee values(13,'yamini','Patro','skm')
insert into employee values(14,'sowji','siri','hyd')



create table IndianCricketTeam(

Jerseyno int not null Primary Key,
first_name varchar(max),
last_name varchar(max),
Noofcenturies int not null
)

insert into IndianCricketTeam values(111,'Kohili','virat',80)
insert into IndianCricketTeam values(112,'Dhoni','Mahendra singh',100)
insert into IndianCricketTeam values(113,'Rohit','sharma',75)
insert into IndianCricketTeam values(114,'suresh','raina',60)

create table BanKTable(

employye_id int not null Primary Key,
emp_fullname varchar(max),
Department varchar(max),
)

insert into BanKTable values(1,'harithayelleti','Transaction')
insert into BanKTable values(2,'saigandepalli','Manager')
insert into BanKTable values(3,'Vamsiyelleti','assManager')
insert into BanKTable values(4,'prithviyelleti','Accountant')


create table IndianRailwaySystem(

Train_no int not null Primary Key,
Train_name varchar(max),
boarding varchar(max),
Destination varchar(max),
arrivaltime time
)

insert into IndianRailwaySystem values(12100,'Kohili','delhi','mumbai',8.00)
insert into IndianRailwaySystem values(12201,'Dhoni','chennai','mumabai',9.00)
insert into IndianRailwaySystem values(12308,'Rohit','banglore','mumabai',7.5)
insert into IndianRailwaySystem values(12409,'suresh','chennai','mumabai',9.00)
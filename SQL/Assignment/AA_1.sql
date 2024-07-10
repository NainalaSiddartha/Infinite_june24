--creating database---

create database assignment;

--using database----
use assignment;

---clients table---
create table clients(client_id decimal(4) primary key,cname varchar(40) not null,
address varchar(30),email varchar(30) unique,phone decimal(10),
bussiness varchar(20) not null);


--employees table--
create table employees(empno decimal(4) primary key,ename varchar(20) not null,
job varchar(15),salary decimal(7),deptno decimal(2) foreign key
references departments(deptno));

alter table employees
add constraint chk_sal check(salary>0);

---departments table--
create table departments(deptno decimal(2) primary key,dname varchar(15) not null,
loc varchar(20));


----projects table--
create table projects(project_id decimal(3) primary key,descr varchar(30) not null,
start_date date,planned_end_date date,actual_end_date date,budget decimal(10),
client_id decimal(4) foreign key references clients(client_id));


alter table projects 
add constraint plan_d check(actual_end_date>planned_end_date);


---empprojectstasks table---
 create table EmpProjectsTasks(project_id decimal(3) ,empno decimal(4), start_date date,end_date date,
 task varchar(25) not null,status varchar(15) not null,
 constraint ept_pk primary key(project_id,empno),
 constraint ept_fk1 foreign key(project_id) references projects(project_id),
 constraint ept_fk2 foreign key(empno) references employees(empno)
 )

 ---inserting into clients table ---

 insert into clients values(1001,'acme utilities','noida','contact@acmeutil.com',9567880032,'Manufacturing');
 
insert into clients values(1002, 'Trackon Consultants', 'Mumbai', 'consult@trackon.com', 8734210090, 'Consultant'),

(1003, 'MoneySaver Distributors','Kolkata' ,'save@moneysaver.com' ,7799886655, 'Reseller'),
(1004 ,'Lawful Corp' ,'Chennai', 'justice@lawful.com', 9210342219, 'Professional');


----inserting data into departments----
insert into departments values

(10, 'Design', 'Pune'),

(20, 'Development', 'Pune'),

(30 ,'Testing', 'Mumbai'),

(40, 'Document' ,'Mumbai');


--------inserting data into employees table------

insert into employees values
(7001 ,'Sandeep', 'Analyst', 25000 ,10),
(7002 ,'Rajesh' ,'Designer' ,30000 ,10),

(7003 ,'Madhav' ,'Developer', 40000 ,20),

(7004 ,'Manoj', 'Developer' ,40000, 20),

(7005, 'Abhay' ,'Designer', 35000 ,10),

(7006, 'Uma', 'Tester' ,30000, 30),

(7007, 'Gita' ,'Tech. Writer' ,30000 ,40),

(7008, 'Priya', 'Tester' ,35000, 30),

(7009 ,'Nutan', 'Developer', 45000 ,20),

(7010, 'Smita', 'Analyst' ,20000 ,10),

(7011, 'Anand' ,'Project Mgr' ,65000 ,10);

-----inserting into projects table---
insert into projects values

(401, 'Inventory', '01-Apr-11', '01-Oct-11', '31-Oct-11' ,150000 ,1001),

(402 ,'Accounting', '01-Aug-11' ,'01-Jan-12',null, 500000 ,1002),

(403, 'Payroll' ,'01-Oct-11', '31-Dec-11', null, 75000, 1003),

(404, 'Contact Mgmt', '01-Nov-11' ,'31-Dec-11',null, 50000, 1004);


---inserting into employee projects tasks table-------

insert into empProjectsTasks values

(401, 7001 ,'01-Apr-11' ,'20-Apr-11', 'System Analysis', 'Completed'),

(401, 7002 ,'21-Apr-11', '30-May-11', 'System Design', 'Completed'),

(401, 7003, '01-Jun-11', '15-Jul-11', 'Coding', 'Completed'),

(401 ,7004 ,'18-Jul-11', '01-Sep-11', 'Coding', 'Completed'),

(401, 7006 ,'03-Sep-11', '15-Sep-11', 'Testing', 'Completed'),

(401, 7009, '18-Sep-11', '05-Oct-11', 'Code Change' ,'Completed'),

(401 ,7008, '06-Oct-11', '16-Oct-11', 'Testing', 'Completed'),

(401, 7007 ,'06-Oct-11', '22-Oct-11', 'Documentation' ,'Completed'),

(401 ,7011, '22-Oct-11', '31-Oct-11', 'Sign off', 'Completed'),

(402, 7010, '01-Aug-11', '20-Aug-11', 'System Analysis', 'Completed'),

(402, 7002, '22-Aug-11', '30-Sep-11', 'System Design' ,'Completed'),

(402, 7004 ,'01-Oct-11',null, 'Coding', 'In Progress');


------dispalying the data in all tables---
select * from employees;
select * from departments;
select * from clients;
select * from projects;
select * from EmpProjectsTasks;
Create database Project_India

create table India
(
	State_Id int primary key,
	State_name varchar(20) not null unique
)

Create table District
(
	District_id int primary key,
	District_name varchar(20) not null unique,
	State_Id int foreign key references India (State_Id)
)

create table Category
(
	Category_id int primary key,
	Category_name varchar(20) not null unique,
)

create table Dates
(
	Date_id int primary key,
	DD_MM_YY int not null unique,
)

create table Vegitables_Prices
(
	Vegitable_name varchar(20) primary key,
	Vegitable_price int not null,
	Date_id int foreign key references Dates(Date_id)
)

create table Frutes_Prices
(
	Frute_name varchar(20) primary key,
	Frute_price int not null,
	Date_id int foreign key references Dates(Date_id)
)

create table Flowers_Prices
(
	Flower_name varchar(20) primary key,
	Flower_price int not null,
	Date_id int foreign key references Dates(Date_id)
)

insert into India (State_Id, State_Id) values( 01, 'Karnataka');

insert into District (District_id, District_id, State_Id) values 
			(1, 'Bagalkot', 1), (2, 'Bengalore', 1), (3, 'Belagavi', 1), (4, 'Ballari', 1), (5, 'Bidar', 1),
			(6, 'Bijapur', 1), (7, 'Chamarajnagar', 1), (8, 'Chikballapur', 1), (9, 'Chikkmagaluru', 1), (10, 'Chitradurga', 1),
			(11, 'Dakshin Kannada', 1), (12, 'Davanagere', 1), (13, 'Dharwad', 1), (14, 'Gadag', 1), (15, 'Kalaburgi', 1), 
			(16, 'Hassan', 1), (17, 'Haveri', 1), (18, 'Kodagu', 1), (19, 'Kolar', 1), (20, 'Koppal', 1), 
			(21, 'Mandya', 1), (22, 'Mysuru', 1), (23, 'Raichur', 1), (24, 'Ramanagar', 1), (25, 'Shivamogga', 1), 
			(26, 'Tumakuru', 1), (27, 'Udapi', 1), (28, 'Uttar kannada', 1), (29, 'Yadgir', 1);

alter table Category drop column District_id;








select * from India;
select * from District;
select * from Category;


create table students(
  student_ID integer, 
  first_name varchar(20),
  last_name varchar(20), 
  street_address varchar(100), 
  city varchar(20),
  state varchar(2),
  zip_code varchar(5),
  phone_number varchar(10),
  email_address varchar(40)
)

create table create table enrollment(
	student_ID integer, 
  	class_ID integer,
  	fees integer,
  	status text, 
  	proficieny text
)

CREATE TABLE Locations(
	location_ID integer, 
  address1 text,
  address2 text,
  city varchar(20),
	state varchar(2),
	zip_code varchar(5)
)

CREATE TABLE Classes(
	  class_ID integer, 
  	instructor_ID integer,
  	location_ID integer,
  	age_range text,
  	martial_art text, 
  	day text, 
  	time real, 
  	max_students integer, 
  	monthly_fee integer
)

create table instructor(
  instructor_ID integer, 
  first_name varchar(20),
  last_name varchar(20), 
  street_address varchar(100), 
  city varchar(20),
  state varchar(2),
  zip_code varchar(5),
  phone_number varchar(10),
  email_address varchar(40)
)

USE Comboios;

CREATE TABLE Passenger(
	pid			char(10)	NOT NULL	PRIMARY KEY,
	firstName	varchar(50)	NOT NULL,
	lastName	varchar(50)	NOT NULL,
	CC			char(9)		NOT NULL,
	phone		char(9)		NOT NULL,
);

CREATE TABLE Driver(
	did			char(10)	NOT NULL	PRIMARY KEY,
	firstName	varchar(50)	NOT NULL,
	lastName	varchar(50)	NOT NULL,
	CC			char(9)		NOT NULL,
	phone		char(9)		NOT NULL,
);

CREATE TABLE Station(
	[sid]		char(10)		NOT NULL	PRIMARY KEY,
	[name]		varchar(100)	NOT NULL,
	[location]	varchar(100)	NOT NULL,
);

CREATE TABLE Train(
	tid			char(10)		NOT NULL	PRIMARY KEY,
	[name]		varchar(100)	NOT NULL,
	capacity	int				NOT NULL,
);

CREATE TABLE TrainDriver(
	tid			char(10)		NOT NULL	FOREIGN KEY REFERENCES Train(tid),
	did			char(10)		NOT NULL	FOREIGN KEY REFERENCES Driver(did),
	[date]		datetime		NOT NULL,
);

CREATE TABLE Track(
	trid		char(10)		NOT NULL	PRIMARY KEY,
	[name]		varchar(100)	NOT NULL,
);


CREATE TABLE TrackStation(
	[sid]		char(10)		NOT NULL	FOREIGN KEY REFERENCES Station([sid]),
	trid		char(10)		NOT NULL	FOREIGN KEY REFERENCES Track(trid),
);

CREATE TABLE [Route](
	rid			char(10)		NOT NULL	PRIMARY KEY,
	[name]		varchar(100)	NOT NULL,
);

CREATE TABLE TrainRoute(
	tid			char(10)		NOT NULL	FOREIGN KEY REFERENCES Train(tid),
	rid			char(10)		NOT NULL	FOREIGN KEY REFERENCES [Route](rid),
	[date]		datetime		NOT NULL,
);

CREATE TABLE TrainSchedule(
	tid				char(10)		NOT NULL	FOREIGN KEY REFERENCES Train(tid),
	tsid			char(10)		NOT NULL	PRIMARY KEY,
	[sid]			char(10)		NOT NULL	FOREIGN KEY REFERENCES Station([sid]),
	[date]			datetime		NOT NULL,
	arrivalTime		varchar(100)	NOT NULL,
	departureTime	varchar(100)	NOT NULL,
);

CREATE TABLE Employee(
	eid			char(10)		NOT NULL	PRIMARY KEY,
	firstName	varchar(50)		NOT NULL,
	lastName	varchar(50)		NOT NULL,
	CC			char(9)			NOT NULL,
	phone		char(9)			NOT NULL,
	username	varchar(100)	NOT NULL,
	[password]	varchar(100)	NOT NULL,
	[role]		char			NOT NULL,
	[image]		bigint			NOT NULL,
	imageName	varchar			NOT NULL
);

CREATE TABLE Ticket(
	tiid				char(10)		NOT NULL	PRIMARY KEY,
	[sid]				char(10)		NOT NULL	FOREIGN KEY REFERENCES Station([sid]),
	pid					char(10)		NOT NULL	FOREIGN KEY REFERENCES Passenger(pid),
	eid					char(10)		NOT NULL	FOREIGN KEY REFERENCES Employee(eid),
	[date]				datetime		NOT NULL,
	destinationStation	varchar(100)	NOT NULL,
	coach				varchar(100)	NOT NULL,
	seatNO				int				NOT NULL,
);



use master;
GO
drop database LinhasFerreas6;
create database LinhasFerreas6;
GO
use LinhasFerreas6;
GO
---CONCERTANDO ERRROS!!!

CREATE TABLE Person(
	idper varchar(40)  PRIMARY KEY NOT NULL, 
	firstname varchar(40) NOT NULL,
	lastname varchar(40) NOT NULL,
	CC varchar(40) NOT NULL, 
	phone varchar(40) NOT NULL,
	--age INT NOT NULL
)

CREATE TABLE Passenger(
	pid varchar(40) NOT NULL PRIMARY KEY,
	discount varchar(50) NOT NULL,
	idper varchar(40) NOT NULL FOREIGN KEY REFERENCES Person(idper),

);
CREATE TABLE Driver(
	did varchar(40) NOT NULL PRIMARY KEY,
	CC varchar(50) NOT NULL,
	idper varchar(40) NOT NULL FOREIGN KEY REFERENCES Person(idper),
);

CREATE TABLE [Route](
	rid varchar(40) NOT NULL PRIMARY KEY,
	[name] varchar(50) NOT NULL,
);

CREATE TABLE Station(
	[sid] varchar(40) NOT NULL PRIMARY KEY,
	[name] varchar(50) NOT NULL,
	[location] varchar(50) NOT NULL,
	rid varchar(40) NOT NULL FOREIGN KEY REFERENCES [Route](rid),
);

CREATE TABLE Horario(
	idHora varchar(40) NOT NULL PRIMARY KEY,
	horaChegada varchar(50) NOT NULL, 
	horaPartida varchar(50) NOT NULL,
	dia date NOT NULL
	
)

CREATE TABLE Track(
	trid varchar(40) NOT NULL PRIMARY KEY,
	[name] varchar(50) NOT NULL,
);

CREATE TABLE Train(
	trainid varchar(40) NOT NULL PRIMARY KEY,
	[name] varchar(50) NOT NULL,
	capacity int NOT NULL,
	did varchar(40) NOT NULL FOREIGN KEY REFERENCES Driver(did),
	trid varchar(40) NOT NULL FOREIGN KEY REFERENCES Track(trid),
);


CREATE TABLE Employee(
	eid varchar(40) NOT NULL PRIMARY KEY,
	[username] varchar(50) NOT NULL,
	[password] varchar(50) NOT NULL,
	[role] varchar(50) NOT NULL,
	imagem varchar(50) NOT NULL,
	idper varchar(40) NOT NULL FOREIGN KEY REFERENCES Person(idper),
);
CREATE TABLE Ticket(
	tid varchar(40) NOT NULL PRIMARY KEY,
	[sid] varchar(40) NOT NULL FOREIGN KEY REFERENCES Station([sid]),
	pid varchar(40) NOT NULL FOREIGN KEY REFERENCES Passenger(pid),
	eid varchar(40) NOT NULL FOREIGN KEY REFERENCES Employee(eid),
	trainid varchar(40) NOT NULL FOREIGN KEY REFERENCES Train(trainid),
	[date] DATE NOT NULL,
	destinationStation varchar(50) NOT NULL,
	carriage int NOT NULL,
	seatNO int NOT NULL,
)

CREATE TABLE EmployeeTicket(
	eid varchar(40) NOT NULL FOREIGN KEY REFERENCES Employee(eid),
	tid varchar(40) NOT NULL FOREIGN KEY REFERENCES Ticket(tid),
)


CREATE TABLE EmployeeStation(
	eid varchar(40) NOT NULL FOREIGN KEY REFERENCES Employee(eid),
	[sid] varchar(40) NOT NULL FOREIGN KEY REFERENCES Station([sid]),
)

CREATE TABLE HorarioStation(
	idHora varchar(40) NOT NULL FOREIGN KEY REFERENCES Horario(idHora), 
	[sid] varchar(40) NOT NULL FOREIGN KEY REFERENCES Station([sid]),
)

CREATE TABLE HorarioTrack(
	idHora varchar(40) NOT NULL FOREIGN KEY REFERENCES Horario(idHora), 
	trid varchar(40) NOT NULL FOREIGN KEY REFERENCES Track(trid),
)
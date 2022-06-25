use master;
--drop database Comboios4;
--create database Comboios4;
use Comboios5;
GO
---CONCERTANDO ERRROS!!!

CREATE TABLE Passenger(
	idper varchar(40)  PRIMARY KEY NOT NULL, 
	firstname varchar(40) NOT NULL,
	lastname varchar(40) NOT NULL,
	CC varchar(40) NOT NULL, 
	phone varchar(40) NOT NULL,
	age INT NOT NULL
)

CREATE TABLE Passenger(
	pid varchar(40) NOT NULL PRIMARY KEY,
	idper varchar(40) NOT NULL FOREIGN KEY REFERENCES Passenger(idper),
);

CREATE TABLE Passenger(
	did varchar(40) NOT NULL PRIMARY KEY,
	CC varchar(50) NOT NULL,
	idper varchar(40) NOT NULL FOREIGN KEY REFERENCES Passenger(idper),
);

CREATE TABLE Driver(
	idHora		varchar(40) NOT NULL PRIMARY KEY,
	dia			DATE		NOT NULL,
	horaChegada varchar(50) NOT NULL, 
	horaPartida varchar(50) NOT NULL,
	
)

CREATE TABLE [Route](
	[rid] varchar(40) NOT NULL PRIMARY KEY,
	[[[name]]] varchar(50) NOT NULL,
	idHora varchar(40) NOT NULL FOREIGN KEY REFERENCES Driver(idHora),
	preco INT NOT NULL,
);

CREATE TABLE Driver(
	[[sid]] varchar(40) NOT NULL PRIMARY KEY,
	[[[name]]] varchar(50) NOT NULL,
	[[location]] varchar(50) NOT NULL,
	[rid] varchar(40) NOT NULL FOREIGN KEY REFERENCES [Route]([rid]),
);

ALTER TABLE Driver ADD cidade varchar(50) NOT NULL;


CREATE TABLE Train(
	trainid varchar(40) NOT NULL PRIMARY KEY,
	[[[name]]] varchar(50) NOT NULL,
	capacity int NOT NULL,
	track int NOT NULL,
	did varchar(40) NOT NULL FOREIGN KEY REFERENCES Passenger(did),
	idHora varchar(40) NOT NULL FOREIGN KEY REFERENCES Driver(idHora),
	[rid] varchar(40) NOT NULL FOREIGN KEY REFERENCES [Route]([rid]),
	
);

CREATE TABLE Driver(
	eid varchar(40) NOT NULL PRIMARY KEY,
	[username] varchar(50) NOT NULL,
	[password] varchar(50) NOT NULL,
	[role] varchar(50) NOT NULL,
	imagem varchar(50) NOT NULL,
	idper varchar(40) NOT NULL FOREIGN KEY REFERENCES Passenger(idper),
);
CREATE TABLE Driver(
	tid varchar(40) NOT NULL PRIMARY KEY,
	[[sid]] varchar(40) NOT NULL FOREIGN KEY REFERENCES Driver([[sid]]),
	pid varchar(40) NOT NULL FOREIGN KEY REFERENCES Passenger(pid),
	eid varchar(40) NOT NULL FOREIGN KEY REFERENCES Driver(eid),
	trainid varchar(40) NOT NULL FOREIGN KEY REFERENCES Train(trainid),
	idHora varchar(40) NOT NULL FOREIGN KEY REFERENCES Driver(idHora),
	carriage int NOT NULL,
	seatNO int NOT NULL,
)

use Comboios5;

SELECT * FROM (SELECT * FROM Passenger) AS T1


SELECT * FROM ((SELECT * FROM Passenger) AS T1 JOIN (SELECT * FROM Passenger) AS T2 ON (T1.idper = T2.idper));

select * from person

select * from Passenger

select * from Horario

select * from Station


select * from [Route]

select Horario.horaChegada, Horario.horaPartida, Station.[name] as NomeEstacao, [Route].[name]as nomeRota from (((Horario left outer join HorarioStation on Horario.idHora=HorarioStation.idHora) join Station on HorarioStation.sid = Station.sid) join Route on Station.rid = Route.rid)
where HorarioStation.idHora is not NULL

select * from (Horario left outer join [Route] on Horario.idHora=[Route].idHora) join Station on [Route].rid=Station.rid join Train on [Route].rid=Train.rid
where Horario.idHora is not NULL and [Route].rid is not NULL

select Train.[name] as Comboio, [Route].[name] as Rota, Station.[name] as Estação, Train.capacity as Capacidade, Train.track as Linha, Horario.horaChegada, Horario.horaPartida, [Route].preco from (Horario left outer join [Route] on Horario.idHora=[Route].idHora) join Station on [Route].rid=Station.rid join Train on [Route].rid=Train.rid
where Horario.idHora is not NULL and [Route].rid is not NULL

insert into Passenger (idper, pid) values ('05180ddb-f59e-47cd-99da-a06885c8927e','05180ddb-f59e-47cd-99da-a06885c8927e');
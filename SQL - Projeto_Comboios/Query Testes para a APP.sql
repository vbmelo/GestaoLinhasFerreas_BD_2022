use Comboios5;
select Train.[name] as Comboio, Train.capacity as Capacidade, Train.track as Linha, Station.[name] as Estação, [Route].[name] as Rota, [Route].preco, Horario.horaChegada, Horario.horaPartida from (Horario left outer join [Route] on Horario.idHora=[Route].idHora) join Station on [Route].rid=Station.rid join Train on [Route].rid=Train.rid where Horario.idHora is not NULL and [Route].rid is not NULL


select * from ticket

select * from train

select * from Station

select distinct [name] from Station

select Horario.horaPartida as Partida, Horario.horaChegada as Chegada from (Horario join [Route] on Horario.idHora=[Route].idHora)


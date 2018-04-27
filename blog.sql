--create database FinalBlog

create table noticias
(
	noticiaId int primary key identity(1,1),
	noticiaTitulo varchar(250) not null,
	noticiaDescripcion varchar(max) not null,
	noticiaFechaCreacion datetime not null,
	noticiaUrlFoto varchar(250),
	noticiaFechaActualizacion datetime,
	usuarioCreador varchar(100)
)

create table comentariosNoticia
(
	comentarioNoticiaId int primary key identity(1,1),
	comentarioNociticaDescipcion varchar(max),
	comentarioNoiticiaFechaCreacion datetime not null,
	comentarioNoticiaNombreUsuario varchar(250),
	comentarioNoticiaEmailUsuario varchar(250),
	noticiaId int,
	foreign key(noticiaId) references noticias(noticiaId)
)
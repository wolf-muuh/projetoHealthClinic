--DDL

CREATE DATABASE Health_Clinic;

USE Health_Clinic;

CREATE TABLE TipoUsuario
(
	IdTipoUsuario INT PRIMARY KEY IDENTITY,
	TipoUsuario varchar(20) not null unique
)

create table Clinica
(
	IdClinica int primary key identity,
	CNPJ varchar(14) not null unique,
	NomeFantasia varchar(200) not null,
	RazaoSocial varchar(200) not null unique,
	HorarioFuncionamento time not null,
	Endereco varchar(200) not null
)

create table Usuario
(
	IdUsuario int primary key identity,
	IdTipoUsuario int foreign key references TipoUsuario(IdTipoUsuario) not null,
	NomeUsuario VARCHAR(200) not null,
	Email VARCHAR(200) not null unique,
	Senha VARCHAR(200) not null unique
)

create table Administrador
(
	IdAdministrador int primary key identity,
	IdClinica int foreign key references Clinica(IdClinica) not null unique,
	NomeAdmin varchar(50) not null unique,
	Senha varchar(20) not null,
)

create table Medico
(
	IdMedico int primary key identity,
	IdClinica int foreign key references Clinica(IdClinica) not null,
	NomeMedico varchar(50) not null,
	CRM char(6) not null unique,
	Especializacao varchar(100) not null
)

create table Paciente
(
	IdPaciente int primary key identity,
	NomePaciente varchar(50) not null,
	Idade int not null,
	Telefone varchar(9) not null unique,
)

create table Consulta
(
	IdConsulta int primary key identity,
	IdPaciente int foreign key references Paciente(IdPaciente) not null unique,
	IdMedico int foreign key references Medico(IdMedico) not null unique,
	DataConsulta date not null,
	HoraConsulta time not null
)

create table FeedBack
(
	IdFeedBack int primary key identity,
	IdPaciente int foreign key references Paciente(IdPaciente) not null unique,
	IdConsulta int foreign key references Consulta(IdConsulta) not null unique,
	Exibe bit not null,
	Descricao varchar(100) not null
)


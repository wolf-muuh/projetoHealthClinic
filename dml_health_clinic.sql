-- dml

--insert into TipoUsuario(TipoUsuario) 
--values('administrador' ), ('médico'), ( 'paciente')

--insert into Clinica(CNPJ, NomeFantasia, RazaoSocial, HorarioFuncionamento, Endereco)
--values ('56892478952364', 'Health Clinic', 'Health Clinic', '10:00:00', 'Rua Pereira Estéfano 187, Vila da Saúde, São Paulo - Sp ')

--insert into Usuario (IdTipoUsuario, NomeUsuario, Email, Senha)
--values (2, 'Carolina Pereira', 'carolpereira@hotmail.com', 'D$Luqi')
--values(1, 'Murilo Alves Zapiello', 'murilo.zapiello@gmail.com', 'MyOrdinaryLife'), (2, 'Beatriz Alves Zapiello', 'beatriz.zapiello@gmail.com', 'PostaNosStories'), (3, 'Lucinea Alves Zapiello', 'lu.zapiello@gmail.com', 'ChamytoFreestyle'), (3, 'Gabriel Luiz Zapiello', 'zapiello@gmail.com', 'SyphonFilter')

--insert into  Administrador (IdClinica, NomeAdmin, Senha)
--values(1, 'Murilo Alves Zapiello', 'MyOrdinaryLife')

--insert into Medico (IdClinica, NomeMedico, CRM, Especializacao)
--values(1, 'Dra. Carolina Pereira', '4565-9', 'Médica Geral')
--values(1, 'Dra. Beatriz Alves Zapiello', '1152-5', 'Neurocirurgiã'), (1, 'Dr. Euclides Silva Teixeira', '5478-6', 'Oncologista')

insert into Paciente (NomePaciente, Idade, Telefone)
values('Lucinea Alves Zapiello', 43, '4553-5165'), ('Gabriel Luiz Zapiello', 46, '5145-3696')

insert into Consulta(IdPaciente, IdMedico, DataConsulta, HoraConsulta)
values(1, 3, '15/08/2023', '16:50:00'), (2, 1, '15/08/2023','17:10:00')

insert into FeedBack (IdPaciente, IdConsulta, Exibe, Descricao)
values(1, 1, 1, 'Médica muito atencioso e profissional'), (2, 2, 1, 'não vim fazer consulta vim ver minha filha trabalhando')

select * from TipoUsuario
select * from Clinica
select * from Usuario
select * from Administrador
select * from Medico
select * from Paciente
select * from Consulta
select * from FeedBack
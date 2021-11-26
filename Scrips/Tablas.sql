Use ManaGLPS



create table Pacientes(
Identificacion int primary key not null,
Nombre VARCHAR(MAX) not null,
Apellido VARCHAR(MAX) not null,
Edad int not null,
Telefono int not null,
Estado VARCHAR(MAX) not null
);

create table HistoriasMedicas(
Codigo int primary key Identity(1,1) not null,
Titulo VARCHAR(MAX) not null,
FechaCreacion DateTime not null,
UltimaEdicion DateTime not null,
FechaFinalizada DateTime not null,
Estado VARCHAR(MAX) not null,
CodigoPacientes int foreign key references Pacientes
);

create table  ConsultasMedicas(
Codigo int primary key Identity(1,1) not null,
Estado VARCHAR(MAX) not null,
FaseTratamiento int not null,
FechaCreada DateTime not null,
CodigoHistoriaMedica int foreign key references HistoriasMedicas
);

create table ValoracionesMultidiciplinar(
Codigo int primary key Identity(1,1) not null,
InformeIndividual VARCHAR(MAX) not null,
InformeGrupal VARCHAR(MAX) not null,
CodigoConsultaMedica int foreign key references ConsultasMedicas
);

create table Medicaciones(
Codigo int primary key Identity(1,1) not null,
Prescripcion VARCHAR(MAX) not null,
Rehabilitacion VARCHAR(MAX) not null, 
CodigoConsultaMedica int foreign key references ConsultasMedicas
);

create table Diagnosticos(
Codigo int primary key Identity(1,1) not null,
ObservacionesExtra VARCHAR(MAX)not null,
CodigoConsultaMedica int foreign key references ConsultasMedicas
);



create table ValoracionesIngreso(
Codigo int primary key Identity(1,1) not null, 
Deportiva VARCHAR(MAX) not null,
DiagnosticoRemision VARCHAR(MAX) not null,
ImagenDiagnostica VARCHAR(MAX) not null,
CodigoConsultaMedica int foreign key references ConsultasMedicas
);

create table CIE(
Codigo VARCHAR(200) primary key not null,
Descripcion VARCHAR(MAX) not null, 
CodigoDiagnostico int foreign key references Diagnosticos
);

create table CategoriaEvaluaciones(
Codigo int primary key Identity(1,1) not null,
EscalaDolor int not null,
Localizacion VARCHAR(MAX) not null,
FrecuenciaAumento int not null,
FrecuenciaDisminucion int not null,
CodigoValoracionMultiDiciplinar int foreign key references ValoracionesMultidiciplinar
);

create table Lesiones(
Codigo int primary key Identity(1,1) not null,
Caracteristica VARCHAR(MAX) not null,
Antecedentes VARCHAR(MAX) not null,
CodigoValoracionIngreso int foreign key references ValoracionesIngreso 
);

create table Usuarios(
Codigo int primary key Identity(1,1) not null,
Correo VARCHAR(MAX),
NombreUsuario VARCHAR(MAX),
Rol VARCHAR(MAX),
Contraseña VARCHAR(MAX)
);



use ManaGLPS
select *from HistoriasMedicas;
select *from ConsultasMedicas;
select *from ValoracionesMultidiciplinar;
select *from Medicaciones;
select *from Diagnosticos;
select *from ValoracionesIngreso;
select *from CategoriaEvaluaciones;
select *from CIE;
select *from Lesiones;

use ManaGLPS
select DISTINCT ConsultasMedicas.Estado,ConsultasMedicas.FaseTratamiento,
ConsultasMedicas.FechaCreada,ValoracionesMultidiciplinar.InformeIndividual,
ValoracionesMultidiciplinar.InformeGrupal,CategoriaEvaluaciones.EscalaDolor,
CategoriaEvaluaciones.Localizacion,CategoriaEvaluaciones.FrecuenciaAumento,
CategoriaEvaluaciones.FrecuenciaDisminucion,Medicaciones.Prescripcion,Medicaciones.Rehabilitacion,Diagnosticos.ObservacionesExtra,ValoracionesIngreso.Deportiva,ValoracionesIngreso.DiagnosticoRemision,ValoracionesIngreso.ImagenDiagnostica,Lesiones.Caracteristica,Lesiones.Antecedentes from ConsultasMedicas
join ValoracionesMultidiciplinar on ConsultasMedicas.Codigo = ValoracionesMultidiciplinar.CodigoConsultaMedica 
join Medicaciones on ConsultasMedicas.Codigo = Medicaciones.CodigoConsultaMedica
join Diagnosticos on ConsultasMedicas.Codigo = Diagnosticos.CodigoConsultaMedica
join ValoracionesIngreso on ConsultasMedicas.Codigo = ValoracionesIngreso.CodigoConsultaMedica
join CategoriaEvaluaciones on ValoracionesMultidiciplinar.Codigo = CategoriaEvaluaciones.CodigoValoracionMultiDiciplinar
join CIE on Diagnosticos.Codigo = CIE.CodigoDiagnostico
join Lesiones on ValoracionesIngreso.Codigo = Lesiones.CodigoValoracionIngreso
where ConsultasMedicas.CodigoHistoriaMedica = 1 and ConsultasMedicas.Codigo = 2



use ManaGLPS
select CIE.Codigo,CIE.Descripcion from Diagnosticos join CIE on Diagnosticos.Codigo = CIE.CodigoDiagnostico  where Diagnosticos.CodigoConsultaMedica = 1 


/*drop table ConsultasMedicas;
drop table ValoracionesIngreso;
drop table ValoracionesMultidiciplinar;
drop table CategoriaEvaluaciones;
drop table Lesiones;
drop table Medicaciones;
drop table CIE;
drop table Diagnosticos;
drop table Temporalidades;*/



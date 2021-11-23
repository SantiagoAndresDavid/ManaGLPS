Use ManaGLPS

drop table ConsultasMedicas;
drop table HistoriasMedicas;
drop table Pacientes;
drop table ValoracionesIngreso;
drop table ValoracionesMultidiciplinar;
drop table CategoriaEvaluaciones;
drop table Lesiones;
drop table Medicaciones;
drop table CIE;
drop table Diagnosticos;
drop table Temporalidades;


create table Medicaciones(
Codigo int primary key Identity(1,1) not null,
Prescripcion VARCHAR(MAX) not null,
Rehabilitacion VARCHAR(MAX) not null 
);

create table Temporalidades(
Codigo int primary key Identity(1,1) not null,
FechaCreada DateTime not null,
UltimaModificacion DateTime not null
);

create table Diagnosticos(
Codigo int primary key Identity(1,1) not null,
ObservacionesExtra VARCHAR(MAX)not null,
);

create table CIE(
Codigo int primary key not null,
Descripcion VARCHAR(MAX) not null, 
CodigoDiagnostico int foreign key references Diagnosticos 
);

create table CategoriaEvaluaciones(
Codigo int primary key Identity(1,1) not null,
EscalaDolor int not null,
Localizacion VARCHAR(MAX) not null,
FrecuenciaAumento int not null,
FrecuenciaDisminucion int not null
);

create table Lesiones(
Codigo int primary key Identity(1,1) not null,
Caracteristica VARCHAR(MAX) not null,
Antecedentes VARCHAR(MAX) not null
);

create table ValoracionesMultidiciplinar(
Codigo int primary key Identity(1,1) not null,
InformeIndividual VARCHAR(MAX) not null,
InformeGrupal VARCHAR(MAX) not null,
CodigoCategoriaEvaluacion int foreign key references CategoriaEvaluaciones
);

create table ValoracionesIngreso(
Codigo int primary key Identity(1,1) not null, 
Deportiva VARCHAR(MAX) not null,
DiagnosticoRemision VARCHAR(MAX) not null,
ImagenDiagnostica VARCHAR(MAX) not null,
CodigoLesion int foreign key references Lesiones
);

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
CodigoDiagnostico int foreign key references Diagnosticos,
CodigoTemporalidade int foreign key references Temporalidades,
CodigoMedicacione int foreign key references  Medicaciones,
CodigoValorancioneMiltidiciplinar int foreign key references ValoracionesMultidiciplinar,
CodigoValoracionIngreso int foreign key references ValoracionesIngreso,
CodigoHistoria int foreign key references HistoriasMedicas
);

create table Usuarios(
Codigo int primary key Identity(1,1) not null,
Correo VARCHAR(MAX),
NombreUsuario VARCHAR(MAX),
Rol VARCHAR(MAX),
Contraseña VARCHAR(MAX)
);




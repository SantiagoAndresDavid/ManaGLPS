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
Prescripcion Text not null,
Rehabilitacion Text not null 
);

create table Temporalidades(
Codigo int primary key Identity(1,1) not null,
FechaCreada DateTime not null,
UltimaModificacion DateTime not null
);

create table Diagnosticos(
Codigo int primary key Identity(1,1) not null,
ObservacionesExtra Text not null,
);

create table CIE(
Codigo int primary key not null,
Descripcion Text not null, 
CodigoDiagnostico int foreign key references Diagnosticos 
);

create table CategoriaEvaluaciones(
Codigo int primary key Identity(1,1) not null,
EscalaDolor int not null,
Localizacion Text not null,
FrecuenciaAumento int not null,
FrecuenciaDisminucion int not null
);

create table Lesiones(
Codigo int primary key Identity(1,1) not null,
Caracteristica Text not null,
Antecedentes Text not null
);

create table ValoracionesMultidiciplinar(
Codigo int primary key Identity(1,1) not null,
InformeIndividual Text not null,
InformeGrupal Text not null,
CodigoCategoriaEvaluacion int foreign key references CategoriaEvaluaciones
);

create table ValoracionesIngreso(
Codigo int primary key Identity(1,1) not null, 
Deportiva Text not null,
DiagnosticoRemision Text not null,
ImagenDiagnostica Text not null,
CodigoLesion int foreign key references Lesiones
);

create table Pacientes(
Identificacion int primary key Identity(1,1) not null,
Nombre Text not null,
Apellido Text not null,
Edad int not null,
Telefono int not null,
Estado Text not null
);

create table HistoriasMedicas(
Codigo int primary key Identity(1,1) not null,
Titulo varchar(200) not null,
FechaCreacion DateTime not null,
UltimaEdicion DateTime not null,
FechaFinalizada DateTime not null,
CodigoPacientes int foreign key references Pacientes
);

create table  ConsultasMedicas(
Codigo int primary key Identity(1,1) not null,
Estado Text not null,
FaseTratamiento int not null,
CodigoDiagnostico int foreign key references Diagnosticos,
CodigoTemporalidade int foreign key references Temporalidades,
CodigoMedicacione int foreign key references  Medicaciones,
CodigoValorancioneMiltidiciplinar int foreign key references ValoracionesMultidiciplinar,
CodigoValoracionIngreso int foreign key references ValoracionesIngreso,
CodigoHistoria int foreign key references HistoriasMedicas
);

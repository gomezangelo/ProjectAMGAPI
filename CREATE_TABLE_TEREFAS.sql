CREATE TABLE Trefas(
	Tarefas_ID int NOT NULL,
    Nome varchar(50) NOT NULL,
    Descricao varchar(50) NOT NULL,
    Status int NOT NULL DEFAULT 0,
	PRIMARY KEY (Tarefas_ID)
);
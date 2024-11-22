CREATE TABLE Usuarios(
	UserAccountID int NOT NULL,
    LoginID varchar(50) NOT NULL,
    Password varchar(50) NOT NULL,
    UserType int NOT NULL DEFAULT 0,
	PRIMARY KEY (UserAccountID)
);
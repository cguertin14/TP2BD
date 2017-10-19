create table Entreprises
(
	NUMENT INT IDENTITY(0,1),
	NOMENT VARCHAR(40),
	ADRESSEENT VARCHAR(120),
	TELENT VARCHAR(20),
	CONTACTENT VARCHAR(25),
	CONSTRAINT PKENT PRIMARY KEY (NUMENT)
);

create table Moniteurs
(
	NUMTR INT IDENTITY(0,1),
	NOMTR VARCHAR(12),
	PRENOMMONIT VARCHAR(12),
	COURRIEL VARCHAR(30),
	NUMENT INT,
	CONSTRAINT FKNUMENT1 FOREIGN KEY (NUMENT)  REFERENCES ENTREPRISES(NUMENT),
	CONSTRAINT PKMTR PRIMARY KEY (NUMTR)
);

create table SUPERVISEURS
(
	NUMSVR INT IDENTITY(0,1),
	NOMSVR VARCHAR(12),
	PRENOMSVR VARCHAR(12),
	COURRIEL VARCHAR(30),
	CONSTRAINT PKSUP PRIMARY KEY (NUMSVR)
);

create table STAGIAIRES
(
	NUMAD INT IDENTITY(0,1),
	NOMSTAGI VARCHAR(12),
	PRENOMSTAGI VARCHAR(12),
	COURRIEL VARCHAR(30),
	NUMSVR INT,
	CONSTRAINT FKNUMSVR FOREIGN KEY (NUMSVR)  REFERENCES SUPERVISEURS(NUMSVR),
	CONSTRAINT PKSTAGIAIRE PRIMARY KEY (NUMAD)
);

create table Stages
(
	NUMSTAGE INT IDENTITY(0,1),
	DESCRIPTION VARCHAR(120),
	TYPESTG VARCHAR(10),
	LANGAGES VARCHAR(120),
	PLATEFORME VARCHAR(25),
	NUMENT INT,
	NUMTR INT,
	NUMAD INT,
	CONSTRAINT FKNUMENT2 FOREIGN KEY (NUMENT)  REFERENCES ENTREPRISES(NUMENT),
	CONSTRAINT FKNUMTR  FOREIGN KEY (NUMTR)   REFERENCES MONITEURS(NUMTR),
	CONSTRAINT FKNUMAD  FOREIGN KEY (NUMAD)   REFERENCES STAGIAIRES(NUMAD),
	CONSTRAINT PKSTAGE  PRIMARY KEY (NUMSTAGE)
);
USE [CharlesGuertinStageBd]
CREATE TABLE ENTREPRISES
(
	NUMENT INT IDENTITY(1,1),
	NOMENT VARCHAR(255),
	ADRESSEENT VARCHAR(255),
	TELENT VARCHAR(255),
	CONTACTENT VARCHAR(255),
	CONSTRAINT PKENT PRIMARY KEY (NUMENT)
);

CREATE TABLE MONITEURS
(
	NUMTR INT IDENTITY(1,1) NOT NULL,
	NOMTR VARCHAR(255),
	PRENOMTR VARCHAR(255),
	COURRIEL VARCHAR(255),
	NUMENT INT NOT NULL,
	CONSTRAINT FKNUMENT1 FOREIGN KEY (NUMENT) REFERENCES ENTREPRISES(NUMENT) ON DELETE CASCADE,
	CONSTRAINT PKMTR PRIMARY KEY (NUMTR)
);

CREATE TABLE SUPERVISEURS
(
	NUMSVR INT IDENTITY(1,1),
	NOMSVR VARCHAR(255),
	PRENOMSVR VARCHAR(255),
	COURRIEL VARCHAR(255),
	CONSTRAINT PKSUP PRIMARY KEY (NUMSVR)
);

CREATE TABLE STAGIAIRES
(
	NUMAD INT IDENTITY(1,1),
	NOMSTG VARCHAR(255),
	PRENOMSTG VARCHAR(255),
	COURRIEL VARCHAR(255),
	NUMSVR INT NOT NULL,
	CONSTRAINT FKNUMSVR FOREIGN KEY (NUMSVR)  REFERENCES SUPERVISEURS(NUMSVR),
	CONSTRAINT PKSTAGIAIRE PRIMARY KEY (NUMAD)
);

CREATE TABLE STAGES
(
	NUMSTAGE INT IDENTITY(1,1),
	DESCRIPTION TEXT,
	TYPESTG VARCHAR(255),
	LANGAGES VARCHAR(255),
	PLATEFORME VARCHAR(255),
	NUMENT INT NOT NULL,
	NUMTR INT NOT NULL,
	NUMAD INT NOT NULL,
	CONSTRAINT FKNUMENT2 FOREIGN KEY (NUMENT)  REFERENCES ENTREPRISES(NUMENT) ON DELETE CASCADE,
	CONSTRAINT FKNUMTR   FOREIGN KEY (NUMTR)   REFERENCES MONITEURS(NUMTR),
	CONSTRAINT FKNUMAD   FOREIGN KEY (NUMAD)   REFERENCES STAGIAIRES(NUMAD),
	CONSTRAINT PKSTAGE  PRIMARY KEY (NUMSTAGE)
);

/* 

QUESTION 3 c) 

Pour impl�menter la relation de composition dans ma base de donn�es, j'ai fait des 'FOREIGN KEY' dans les tables
n�cessaires pour faire des liens comme par exemple 'one to many' ou 'many to many' ou n'importe quel autre lien.

Les avantages que ces liens m'apportent:
	1- Je peux acc�der facilement � mes donn�es,
	2- Mes donn�es sont li�es et tr�s s�curis�es,
	3- Il est facile de se retrouver dans ma base de donn�es.

Les inconv�nients que ces liens m'apportent:
	1- Plus de validation de donn�es � faire lors d'insertions de donn�es,
	2- Le temps de d�veloppement peut �tre plus long pour des grosses relations du genre 'many to many',
	3- etc.
				
*/
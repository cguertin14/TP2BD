/* QUESTION 4 - INSERTIONS DANS LA BASE DE DONNÉES */


-- Insertions Entreprises
INSERT INTO ENTREPRISES (NOMENT,ADRESSEENT,TELENT,CONTACTENT) VALUES('LetsWork','Collège Lionel-Groulx','514-965-4141','Contact');
INSERT INTO ENTREPRISES (NOMENT,ADRESSEENT,TELENT,CONTACTENT) VALUES('Hydro-Québec','Rue Sainte-Catherine, Montréal','514-980-0976','Contact Hydro');
INSERT INTO ENTREPRISES (NOMENT,ADRESSEENT,TELENT,CONTACTENT) VALUES('Desjardins','Rue Sainte-Catherine, Montréal','514-238-2325','Contact Desjardins');

-- Insertions Moniteurs
INSERT INTO MONITEURS (NOMTR,PRENOMTR,COURRIEL,NUMENT) VALUES('Deschamps','Martin','martindeschamps@letswork.com',1);
INSERT INTO MONITEURS (NOMTR,PRENOMTR,COURRIEL,NUMENT) VALUES('Blais','Gabriel','gabriel.blais@hq.com',2);
INSERT INTO MONITEURS (NOMTR,PRENOMTR,COURRIEL,NUMENT) VALUES('Moderie','Nathalie','nathalie.moderie@desjardins.com',3);

-- Insertions Superviseurs
INSERT INTO SUPERVISEURS VALUES('Jean','Francois','frankygino@letsgo.ca');
INSERT INTO SUPERVISEURS VALUES('Forest','Etienne','collationorganisee@memer.ca');
INSERT INTO SUPERVISEURS VALUES('Yacoub','Saliha','datasouss@.ca');

-- Insertions Stagiaires
INSERT INTO STAGIAIRES (NOMSTG,PRENOMSTG,COURRIEL,NUMSVR) VALUES('Lachance','Ludovic','ludolachance@prikassprank.com',1);
INSERT INTO STAGIAIRES (NOMSTG,PRENOMSTG,COURRIEL,NUMSVR) VALUES('Guertin','Charles','charlesguertin@tropcool.com',2);
INSERT INTO STAGIAIRES (NOMSTG,PRENOMSTG,COURRIEL,NUMSVR) VALUES('Archambault','Alexandre','alexarchambault@trovrai.com',3);

-- Insertions Stages
INSERT INTO STAGES VALUES('Le stage chez LetsWork amènera l"étudiant à se dépasser et à atteindre de nouveaux sommets','Dev Web','PHP,Javascript,CSS,HTML,etc.','Laravel 5.4',1,1,1);
INSERT INTO STAGES VALUES('Le stage chez Hydro-Québec amènera l"étudiant à se dépasser et à atteindre de nouveaux sommets','Dev Web','PHP,Javascript,CSS,HTML,etc.','YII,DXHTML',2,2,2);
INSERT INTO STAGES VALUES('Le stage chez Desjardins amènera l"étudiant à se dépasser et à atteindre de nouveaux sommets','Dev Mobile','Java,XML,C#,etc.','Android',3,3,3);
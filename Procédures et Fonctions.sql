/* QUESTIONS 5 ET 6 */

/* 
	ProcÚdure pour ajouter un stage
*/
USE [CharlesGuertinStageBd]
GO
CREATE PROCEDURE ADDSTAGE
(
	@PDESCRIPTION TEXT,
	@PTYPESTG VARCHAR(255),
	@PLANGAGES VARCHAR(255),
	@PPLATEFORMES VARCHAR(255),
	@PNUMENT INT,
	@PNUMTR INT,
	@PNUMAD INT
)
AS
	INSERT INTO STAGES VALUES(@PDESCRIPTION,@PTYPESTG,@PLANGAGES,@PPLATEFORMES,@PNUMENT,@PNUMTR,@PNUMAD);
GO


/*
	ProcÚdure pour modifier la description d'un stage
*/
GO
CREATE PROCEDURE UPDATEDESCRIPTION
(
	@PNUMAD INT,
	@PDESCRIPTION TEXT
)
AS
	UPDATE STAGES set DESCRIPTION = @PDESCRIPTION WHERE NUMAD = @PNUMAD;
GO


/*
	ProcÚdure pour supprimer un stage
*/
GO
CREATE PROCEDURE DELETESTAGE
(
	@PNUMAD INT
)
AS
	DELETE FROM STAGES WHERE NUMSTAGE = @PNUMAD;
GO


/*
	ProcÚdure pour lister les stages selon l'entreprise
*/
GO
CREATE PROCEDURE GETSTAGESFROMENTREPRISE
(
	@PNOMENT VARCHAR(255)
)
AS
	SELECT * FROM STAGES
	INNER JOIN ENTREPRISES on STAGES.NUMENT = ENTREPRISES.NUMENT
	WHERE ENTREPRISES.NOMENT = @PNOMENT;
GO


/*
	Fonction pour get le nombres de stages d'une entreprise
*/
GO
CREATE FUNCTION GETNBSTAGESBYENTREPRISE(@PNUMENT INT) 
RETURNS INT
AS BEGIN
    DECLARE @NBSTAGES INT

    SELECT @NBSTAGES = COUNT(*) from STAGES
    INNER JOIN ENTREPRISES on STAGES.NUMENT = ENTREPRISES.NUMENT
	WHERE ENTREPRISES.NUMENT = @PNUMENT;
   
	RETURN @NBSTAGES
END
GO


/*
	Fonction pour lister les Útudiants avec leurs stages
*/
GO
CREATE FUNCTION GETETUDIANTS
() RETURNS TABLE
AS
return
(
	SELECT NOMSTG,PRENOMSTG,DESCRIPTION,NOMENT,NOMTR,NOMSVR from STAGIAIRES
	INNER JOIN SUPERVISEURS on STAGIAIRES.NUMSVR = SUPERVISEURS.NUMSVR
	INNER JOIN STAGES on STAGIAIRES.NUMAD = STAGES.NUMAD
	INNER JOIN MONITEURS on STAGES.NUMTR = MONITEURS.NUMTR
	INNER JOIN ENTREPRISES on STAGES.NUMENT = ENTREPRISES.NUMENT
);
GO
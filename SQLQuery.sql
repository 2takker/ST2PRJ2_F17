﻿--CREATE TABLE Sundhedspersonale (
--bruger_id NVARCHAR(50) NOT NULL,
--kodeord NVARCHAR(MAX) NOT NULL,
--CONSTRAINT pk_Sundhedspersonale PRIMARY KEY CLUSTERED(bruger_id))	

--INSERT INTO Sundhedspersonale(bruger_id, kodeord) VALUES('ACD', '123ekg456')
--INSERT INTO Sundhedspersonale(bruger_id, kodeord) VALUES('TEST', '123ekg456')

--SELECT * FROM Sundhedspersonale

--SELECT * FROM Sundhedspersonale WHERE bruger_id ='ACD'

--CREATE TABLE PatientData (
--CPR NVARCHAR(10) NOT NULL,
--Fornavn NVARCHAR(MAX) NULL,
--Efternavn NVARCHAR(MAX) NULL,
--CONSTRAINT pk_PatientData PRIMARY KEY CLUSTERED(CPR))

--SELECT * FROM PatientData

--INSERT INTO PatientData(CPR, Fornavn, Efternavn) VALUES('1212901414', 'Svend Henning', 'Svendsen')

--SELECT * FROM PatientData

--CREATE TABLE EKGMAALING(
--ekgmaaleid BIGINT IDENTITY(1,1) NOT NULL,
--dato DATETIME NOT NULL,
--antalmaalinger INT NOT NULL,
--sfp_maaltagermedarbjnr NVARCHAR(MAX) NULL,
--sfp_mt_kommentar NTEXT NULL,
--sfp_ansvrmedarbejnr NVARCHAR(50) NOT NULL,
--sfp_ans_org NVARCHAR(MAX) NOT NULL,
--sfp_anskommentar NVARCHAR(MAX) NULL,
--borger_cprnr NVARCHAR(10) NOT NULL,
--CONSTRAINT pk_EKGMAALING PRIMARY KEY CLUSTERED (ekgmaaleid),
--CONSTRAINT fk_EKGMAALING FOREIGN KEY (borger_cprnr)
--REFERENCES PatientData (CPR)
--ON UPDATE CASCADE
--)

--CREATE TABLE EKGDATA (
--ekgdataid INT IDENTITY(1,1) NOT NULL,
--raa_data VARBINARY NOT NULL,
--samplerate_hz FLOAT NOT NULL,
--interval_sec BIGINT NOT NULL,
--data_format NVARCHAR(MAX) NOT NULL,
--bin_eller_tekst CHAR(1) NOT NULL,
--maaleformat_type NVARCHAR(MAX) NOT NULL,
--start_tid DATETIME NOT NULL,
--ekgmaaleid BIGINT NULL,
--CONSTRAINT pk_EKGDATA PRIMARY KEY CLUSTERED(ekgdataid),
--CONSTRAINT fk_EKGDATA FOREIGN KEY (ekgmaaleid)
--REFERENCES EKGMAALING (ekgmaaleid)
--ON UPDATE CASCADE
--)

--SELECT * FROM EKGDATA

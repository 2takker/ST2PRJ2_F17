--CREATE TABLE Sundhedspersonale (
--bruger_id NVARCHAR(50) NOT NULL,
--kodeord NVARCHAR(MAX) NOT NULL,
--CONSTRAINT pk_Sundhedspersonale PRIMARY KEY CLUSTERED(bruger_id))	

--INSERT INTO Sundhedspersonale(bruger_id, kodeord) VALUES('ACD', '123ekg456')
--INSERT INTO Sundhedspersonale(bruger_id, kodeord) VALUES('TEST', '123ekg456')

--SELECT * FROM Sundhedspersonale

SELECT * FROM Sundhedspersonale WHERE bruger_id ='ACD'

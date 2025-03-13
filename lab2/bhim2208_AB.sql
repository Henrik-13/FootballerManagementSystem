USE master
GO

IF EXISTS(SELECT * FROM sys.databases WHERE name='bhim2208')
	DROP DATABASE bhim2208_AB

SET DATEFORMAT YMD

CREATE DATABASE bhim2208_AB;
GO

USE bhim2208_AB
GO


CREATE TABLE Ertekek (
	EID INT IDENTITY(1,1) CONSTRAINT PK_Ertekek PRIMARY KEY,
	Idopont DATE,
	Ertek INT
);

INSERT INTO Ertekek VALUES ('2022-08-01', 50000000),	--1
						   ('2023-06-01', 70000000),	--2
						   ('2024-03-01', 86000000),	--3
						   ('2020-07-01', 122000000),	--4
						   ('2021-09-01', 96000000),	--5
						   ('2021-03-01', 56000000),	--6
						   ('2022-12-01', 110000000),	--6
						   ('2024-02-01', 180000000),	--7
						   ('2020-04-01', 80000000),	--8
						   ('2021-05-01', 150000000),	--9
						   ('2023-12-01', 180000000),	--10
						   ('2020-06-01', 180000000),	--11
						   ('2022-08-01', 160000000),	--12
						   ('2020-01-01', 112000000),	--13
						   ('2022-05-01', 50000000),	--14
						   ('2024-01-01', 48000000),	--15
				 		   ('2020-08-01', 100000000),	--16
						   ('2022-10-01', 70000000),	--17
						   ('2020-11-01', 12000000),	--18
						   ('2022-02-01', 58000000),	--19
						   ('2024-01-01', 30000000)		--20

CREATE TABLE Orszagok (
	OID INT IDENTITY(1,1) CONSTRAINT PK_Orszagok PRIMARY KEY,
	OrszagNev VARCHAR(30)
);

INSERT INTO Orszagok VALUES ('Anglia'),			--1
							('Spanyolorszag'),	--2
							('Nemetorszag'),	--3
							('Franciaorszag'),	--4
							('Dania'),			--5
							('Magyarorszag'),	--6
							('Olaszorszag'),	--7
							('Argentina'),		--8
							('Portugalia'),		--9
							('Brazilia')		--10

CREATE TABLE Focistak (
	FID INT IDENTITY(1,1) CONSTRAINT PK_Focistak PRIMARY KEY,
	FNev VARCHAR(50),
	OID INT,
	Osszgolok INT,
	Osszgolpasszok INT,
	Eletkor INT,
	AktualisErtek INT,
	EID INT,
	CONSTRAINT FK_Focistak_EID FOREIGN KEY (EID) REFERENCES Ertekek(EID), 
	CONSTRAINT FK_Focistak_OID FOREIGN KEY (OID) REFERENCES Orszagok(OID)
);

INSERT INTO Focistak VALUES ('Erling Haaland', 5, 216, 51, 23, 180000000, 1),
							('Jude Bellingham', 1, 48, 36, 20, 180000000, 2),
							('Kylian Mbappe', 4, 324, 110, 25, 180000000, 3),
							('Lionel Messi', 8, 826, 395, 36, 35000000, 4),
							('Cristiano Ronaldo', 9, 890, 253, 38, 15000000, 5),
							('Vinicius Jr', 10, 173, 103, 23, 150000000, 6),
							('Rodrygo', 10, 86, 92, 23, 100000000, 7),
							('Pedri', 2, 48, 73, 21, 90000000, 8),
							('Gavi', 2, 26, 40, 19, 90000000, 9),
							('Harry Kane', 1, 568, 174, 30, 110000000, 10),
							('Szoboszlai Dominik', 6, 142, 162, 23, 75000000, 11),
							('Rodri', 2, 67, 81, 27, 110000000, 12),
							('Saka', 1, 100, 138, 22, 130000000, 13),
							('Lautaro Martinez', 8, 253, 48, 26, 110000000, 14),
							('Musiala', 3, 78, 136, 21, 110000000, 15),
							('Barella', 7, 84, 179, 27, 75000000, 16),
							('Camavinga', 4, 67, 122, 21, 90000000, 17),
							('Alvarez', 8, 197, 106, 24, 90000000, 18),
							('Leao', 9, 187, 178, 24, 90000000, 19),
							('Sane', 3, 198, 190, 28, 80000000, 20)

CREATE TABLE Trofeak (
	TID INT IDENTITY(1,1) CONSTRAINT PK_Trofeak PRIMARY KEY,
	TNev VARCHAR(30)
);

INSERT INTO Trofeak VALUES ('Champions League'),
						   ('World Cup'),
						   ('Euro'),
						   ('Copa America'),
						   ('Premier League'),
						   ('La Liga'),
						   ('Bundesliga'),
						   ('Seria A'),
						   ('Ligue 1'),
						   ('Europa League'),
						   ('Conference League')

CREATE TABLE Posztok (
	PID INT IDENTITY(1,1) CONSTRAINT PK_Posztok PRIMARY KEY,
	PNev VARCHAR(30)
);

INSERT INTO Posztok VALUES ('Kapus'),
						   ('Kozephatved'),
						   ('Balhatved'),
						   ('Jobbhatved'),
						   ('Kozeppalyas'),
						   ('Bal szelso'),
						   ('Jobb szelso'),
						   ('Csatar')

CREATE TABLE Ligak (
	LID INT IDENTITY(1,1) CONSTRAINT PK_Ligak PRIMARY KEY,
	LNev VARCHAR(30),
	OID INT,
	CONSTRAINT FK_Ligak_OID FOREIGN KEY (OID) REFERENCES Orszagok(OID)
);

INSERT INTO Ligak VALUES ('Premier League', 1),
						 ('La Liga', 2),
						 ('Bundesliga', 3),
						 ('Serie A', 7),
						 ('Ligue 1', 4)

CREATE TABLE Klubok (
	KID INT IDENTITY(1,1) CONSTRAINT PK_Klubok PRIMARY KEY,
	Jatekosszam INT,
	EID INT,
	FID INT,
	CONSTRAINT FK_Klubok_EID FOREIGN KEY (EID) REFERENCES Ertekek(EID),
	CONSTRAINT FK_Klubok_FID FOREIGN KEY (FID) REFERENCES Focistak(FID)
);

--INSERT INTO Klubok VALUES

CREATE TABLE Megkap (
	FID INT,
	TID INT,
	CONSTRAINT FK_Megkap_FID FOREIGN KEY (FID) REFERENCES Focistak(FID),
	CONSTRAINT FK_Megkap_TID FOREIGN KEY (TID) REFERENCES Trofeak(TID),
	CONSTRAINT PK_Megkap_MID PRIMARY KEY (FID, TID)
);

CREATE TABLE Jatszik (
	FID INT,
	PID INT,
	CONSTRAINT FK_Jatszik_FID FOREIGN KEY (FID) REFERENCES Focistak(FID),
	CONSTRAINT FK_Jatszik_PID FOREIGN KEY (PID) REFERENCES Posztok(PID),
	CONSTRAINT PK_Jatszik_JID PRIMARY KEY (FID, PID)
);

CREATE TABLE Resztvesz (
	LID INT,
	KID INT,
	Ev INT,
	Helyezes INT,
	CONSTRAINT FK_Resztvesz_LID FOREIGN KEY (LID) REFERENCES Ligak(LID),
	CONSTRAINT FK_Resztvesz_KID FOREIGN KEY (KID) REFERENCES Klubok(KID),
	CONSTRAINT PK_Resztvesz_RID PRIMARY KEY (LID, KID)
);

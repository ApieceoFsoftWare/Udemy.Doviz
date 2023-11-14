-- Bu SQL i s�ras� ile database i�inde execute (F5) etmen gerekiyor... Sonras�nda yine proje i�indeki 
-- TSQL klas�r�nde bulunan important.sql i �al��t�rman gerekiyor :D 

CREATE DATABASE UdemyDoviz
go
CREATE TABLE ParaBirimi
(
	ID			Uniqueidentifier primary key,
	Code		nvarchar(8),
	Tanim		nvarchar(70),
	UyariLimit	decimal			-- Buradaki de�er belirli bir aral���n �st�nde ise paray� �ekmemizi s�yleyecek!
)
go
CREATE TABLE Kur
(
 ID					Uniqueidentifier primary key,
 ParaBirimiID		Uniqueidentifier primary key,
 Satis				decimal,
 Alis				decimal,
 Degisim			decimal,
 d_oran				decimal,
 d_yon				nvarchar(70),
 OlusturmaTarihi	datetime
)
go
CREATE TABLE KurGecmis
(
	ID					Uniqueidentifier primary key,
	KurID				Uniqueidentifier primary key,
	ParaBirimiID		Uniqueidentifier primary key,
	Satis				decimal,
	Alis				decimal,
	Degisim				decimal,
	d_oran				decimal,
	d_yon				nvarchar(70),
	OlusturmaTarihi		datetime
)

CREATE PROC KurKayitEkle
(
	 @ID				Uniqueidentifier,
	 @ParaBirimiID		Uniqueidentifier,
	 @Satis				decimal,
	 @Alis				decimal,
	 @Degisim			decimal,
	 @d_oran			decimal,
	 @d_yon				nvarchar,
	 @OlusturmaTarihi	datetime
)
as
begin
	if((SELECT Count(*) FROM Kur WHERE ParaBirimiID = @ParaBirimiID) > 0)
		begin
			-- Kur tablosundaki mevcut de�erleri KurGecmis tablosuna aktarmam�z gerekiyor.
			INSERT INTO KurGecmis (ID, KurID, ParaBirimiID, Satis, Alis, Degisim, d_oran, d_yon, OlusturmaTarihi)
			SELECT	NEWID(), ID, ParaBirimiID, Satis, Alis, Degisim, d_oran, d_yon, OlusturmaTarihi
			FROM Kur WHERE ParaBirimiID = @ParaBirimiID

			-- Kur tablosundaki de�erlerimizi g�ncelleyelim...

			UPDATE Kur SET
			Satis = @Satis, 
			Alis = @Alis
			WHERE ParaBirimiID = @ParaBirimiID

		end
	else
		begin
			INSERT INTO Kur(ID, ParaBirimiID, Satis, Alis, Degisim, d_oran, d_yon, OlusturmaTarihi)
			VALUES (@ID, @ParaBirimiID, @Satis, @Alis, @Degisim, @d_oran, @d_yon, @OlusturmaTarihi)
		end
end
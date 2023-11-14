-- Bu SQL i sýrasý ile database içinde execute (F5) etmen gerekiyor... Sonrasýnda yine proje içindeki 
-- TSQL klasöründe bulunan important.sql i çalýþtýrman gerekiyor :D 

CREATE DATABASE UdemyDoviz
go
CREATE TABLE ParaBirimi
(
	ID			Uniqueidentifier primary key,
	Code		nvarchar(8),
	Tanim		nvarchar(70),
	UyariLimit	decimal			-- Buradaki deðer belirli bir aralýðýn üstünde ise parayý çekmemizi söyleyecek!
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
			-- Kur tablosundaki mevcut deðerleri KurGecmis tablosuna aktarmamýz gerekiyor.
			INSERT INTO KurGecmis (ID, KurID, ParaBirimiID, Satis, Alis, Degisim, d_oran, d_yon, OlusturmaTarihi)
			SELECT	NEWID(), ID, ParaBirimiID, Satis, Alis, Degisim, d_oran, d_yon, OlusturmaTarihi
			FROM Kur WHERE ParaBirimiID = @ParaBirimiID

			-- Kur tablosundaki deðerlerimizi güncelleyelim...

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
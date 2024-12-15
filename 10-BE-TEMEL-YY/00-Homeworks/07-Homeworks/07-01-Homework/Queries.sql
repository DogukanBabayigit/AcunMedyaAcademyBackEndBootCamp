--1
--SELECT KitapAdi, Yazar, YayinYili
--FROM Kitaplar;
--2
--SELECT KitapAdi, Yazar, YayinYili
--FROM Kitaplar
--WHERE YayinYili > 1943;
--3
--SELECT Ogrenciler.Ad AS OgrenciAdi, Ogrenciler.Soyad AS OgrenciSoyadi, Kitaplar.KitapAdi
--FROM OduncAlmalar
--JOIN Ogrenciler ON OduncAlmalar.OgrenciID = Ogrenciler.OgrenciID
--JOIN Kitaplar ON OduncAlmalar.KitapID = Kitaplar.KitapID;
--4
--SELECT KitapAdi, SayfaSayisi
--FROM Kitaplar
--ORDER BY SayfaSayisi DESC
--LIMIT 5;
--5
--SELECT KitapAdi
--FROM Kitaplar
--WHERE Yazar = 'Oðuz Atay';
--6
--SELECT Ogrenciler.Ad AS OgrenciAdi, Ogrenciler.Soyad AS OgrenciSoyadi, Dergiler.DergiAdi, Dergiler.Yayýnci
--FROM OduncAlmalar
--JOIN Ogrenciler ON OduncAlmalar.OgrenciID = Ogrenciler.OgrenciID
--JOIN Dergiler ON OduncAlmalar.DergiID = Dergiler.DergiID;
--7
--SELECT Ogrenciler.Ad, Ogrenciler.Soyad
--FROM Ogrenciler
--LEFT JOIN OduncAlmalar ON Ogrenciler.OgrenciID = OduncAlmalar.OgrenciID
--WHERE OduncAlmalar.OgrenciID IS NULL;
--8
--SELECT 'Kitap' AS MateryalTürü, KitapID AS MateryalID, COUNT(*) AS OduncSayisi
--FROM OduncAlmalar
--WHERE KitapID IS NOT NULL
--GROUP BY KitapID

--UNION ALL

--SELECT 'Dergi' AS MateryalTürü, DergiID AS MateryalID, COUNT(*) AS OduncSayisi
--FROM OduncAlmalar
--WHERE DergiID IS NOT NULL
--GROUP BY DergiID

--UNION ALL

--SELECT 'DVD' AS MateryalTürü, DVDID AS MateryalID, COUNT(*) AS OduncSayisi
--FROM OduncAlmalar
--WHERE DVDID IS NOT NULL
--GROUP BY DVDID;
--9
--SELECT KitapAdi, YayýnYýlý
--FROM Kitaplar
--ORDER BY YayýnYýlý ASC
--LIMIT 3;
--10
SELECT Kitaplar.KitapAdi AS MateryalAdi
FROM OduncAlmalar
JOIN Ogrenciler ON OduncAlmalar.OgrenciID = Ogrenciler.OgrenciID
JOIN Kitaplar ON OduncAlmalar.KitapID = Kitaplar.KitapID
WHERE Ogrenciler.Ad = 'Ahmet' AND Ogrenciler.Soyad = 'Yýlmaz'

UNION ALL

SELECT Dergiler.DergiAdi AS MateryalAdi
FROM OduncAlmalar
JOIN Ogrenciler ON OduncAlmalar.OgrenciID = Ogrenciler.OgrenciID
JOIN Dergiler ON OduncAlmalar.DergiID = Dergiler.DergiID
WHERE Ogrenciler.Ad = 'Ahmet' AND Ogrenciler.Soyad = 'Yýlmaz'

UNION ALL

SELECT DVDler.DVDAdi AS MateryalAdi
FROM OduncAlmalar
JOIN Ogrenciler ON OduncAlmalar.OgrenciID = Ogrenciler.OgrenciID
JOIN DVDler ON OduncAlmalar.DVDID = DVDler.DVDID
WHERE Ogrenciler.Ad = 'Ahmet' AND Ogrenciler.Soyad = 'Yýlmaz';





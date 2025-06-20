-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 11 Haz 2021, 18:19:57
-- Sunucu sürümü: 10.4.19-MariaDB
-- PHP Sürümü: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `ybsdb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kayitkisibilgileri`
--

CREATE TABLE `kayitkisibilgileri` (
  `adsoyad` varchar(20) NOT NULL,
  `tckimlik` int(20) NOT NULL,
  `adres` varchar(50) NOT NULL,
  `telefon` int(11) NOT NULL,
  `email` text NOT NULL,
  `odalar` int(11) NOT NULL,
  `tutar` int(11) NOT NULL,
  `odemeturu` text NOT NULL,
  `giristarihi` text NOT NULL,
  `cikistarihi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `kayitkisibilgileri`
--

INSERT INTO `kayitkisibilgileri` (`adsoyad`, `tckimlik`, `adres`, `telefon`, `email`, `odalar`, `tutar`, `odemeturu`, `giristarihi`, `cikistarihi`) VALUES
('Şevket Erdem Kan', 2147483647, 'İstanbul/Esenler Birlik mahallesi 793 sokak no 12 ', 2147483647, 'erdemkan2134@gmail.com', 21, 4900, 'Nakit', '11.06.2021 19:10:11', '25.06.2021 19:10:11'),
('Aykut Kocaman', 1111111111, 'Ümraniye', 11111111, 'ayktkcm@gmail.com', 6, 1575, 'Kredi Kartı', '11.06.2021 19:14:07', '20.06.2021 19:14:07'),
('Sergen Yalçın', 1111111111, 'Beşiktaş', 11111111, 'ayktkcm@gmail.com', 18, 1575, 'Kredi Kartı', '11.06.2021 19:14:07', '20.06.2021 19:14:07'),
('Kadriye Gül', 1111111111, 'Ankara Keçiören', 11111111, 'ayktkcm@gmail.com', 20, 1575, 'Kredi Kartı', '11.06.2021 19:14:07', '20.06.2021 19:14:07'),
('Rüveyda Yücel', 1111111111, 'Ümraniye', 11111111, '11111111', 12, 1600, 'Nakit', '11.06.2021 19:15:55', '18.06.2021 19:15:55'),
('Nurgül Kozalak', 11111111, 'Bursa', 1111111, 'nurglkzl@gmail.com', 4, 2400, 'Nakit', '11.06.2021 19:17:44', '27.06.2021 19:17:44'),
('Aytaç Yiğit', 11111111, 'Bursa', 1111111, 'aytcygt@gmail.com', 10, 2400, 'Nakit', '11.06.2021 19:17:44', '27.06.2021 19:17:44');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `odavedurumu`
--

CREATE TABLE `odavedurumu` (
  `oda` int(6) NOT NULL,
  `durumu` varchar(4) NOT NULL,
  `yataksayisi` int(10) NOT NULL,
  `günlükücret` int(11) NOT NULL,
  `kati` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `odavedurumu`
--

INSERT INTO `odavedurumu` (`oda`, `durumu`, `yataksayisi`, `günlükücret`, `kati`) VALUES
(1, 'BOŞ', 2, 150, 1),
(2, 'BOŞ', 2, 150, 1),
(3, 'BOŞ', 2, 150, 1),
(4, 'DOLU', 2, 150, 1),
(5, 'BOŞ', 2, 150, 1),
(6, 'DOLU', 2, 175, 1),
(7, 'BOŞ', 2, 175, 1),
(8, 'BOŞ', 2, 175, 1),
(9, 'BOŞ', 2, 175, 1),
(10, 'DOLU', 2, 175, 1),
(11, 'BOŞ', 2, 200, 2),
(12, 'DOLU', 2, 200, 2),
(13, 'BOŞ', 2, 200, 2),
(14, 'BOŞ', 2, 200, 2),
(15, 'BOŞ', 2, 200, 2),
(16, 'BOŞ', 2, 250, 1),
(17, 'BOŞ', 2, 250, 2),
(18, 'DOLU', 2, 250, 2),
(19, 'BOŞ', 2, 250, 2),
(20, 'DOLU', 2, 250, 2),
(21, 'DOLU', 2, 350, 2);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

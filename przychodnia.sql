-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 20 Lut 2018, 23:51
-- Wersja serwera: 10.1.28-MariaDB
-- Wersja PHP: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `przychodnia`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `grafik`
--

CREATE TABLE `grafik` (
  `Id_grafiku` int(11) NOT NULL,
  `Id_lekarza` int(11) NOT NULL,
  `Dzien_od` datetime NOT NULL COMMENT '15 minut na wizyte',
  `Id_pacjenta` int(11) DEFAULT NULL COMMENT 'jesli null to wolne',
  `Opis` varchar(5000) COLLATE utf8_polish_ci NOT NULL COMMENT 'max 5000 znakow',
  `Id_oddzialu` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `grafik`
--

INSERT INTO `grafik` (`Id_grafiku`, `Id_lekarza`, `Dzien_od`, `Id_pacjenta`, `Opis`, `Id_oddzialu`) VALUES
(69, 1, '2018-02-08 01:00:00', 0, '', 8),
(70, 2, '2018-02-08 01:00:00', 0, '', 9),
(71, 2, '2018-02-08 01:45:00', 0, '', 0),
(75, 1, '2018-02-09 02:00:00', 0, '', 8),
(76, 1, '2018-02-09 01:30:00', 0, '', 0),
(77, 1, '2018-02-19 02:30:00', NULL, '', 12),
(78, 1, '2018-02-19 02:15:00', NULL, '', 12),
(80, 1, '2018-02-19 01:45:00', 10, '', 12),
(81, 1, '2018-02-19 01:30:00', NULL, '', 12),
(82, 1, '2018-02-19 01:15:00', 8, '   \n\n   DATA WIZYTY: 20-02-18 23:44\n\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Sed finibus turpis sit amet risus gravida, a scelerisque velit ornare. Curabitur convallis nisl non fringilla ultricies. In hac habitasse platea dictumst. Morbi placerat placerat porta. Praesent rutrum quis tellus vel vehicula. Fusce eu elit ultrices, venenatis lacus sit amet, ultricies mauris. Etiam cursus felis ut sem efficitur, et faucibus nibh malesuada. Morbi finibus at ipsum ac fermentum. Nam quis eros quam. In eget nibh ut neque tempor dictum.', 12),
(83, 1, '2018-02-19 01:00:00', NULL, '', 12),
(84, 1, '2018-02-19 00:45:00', NULL, '', 12),
(85, 2, '2018-02-19 06:15:00', NULL, '', 9),
(86, 2, '2018-02-19 06:00:00', NULL, '', 9),
(87, 2, '2018-02-19 05:45:00', NULL, '', 9),
(88, 2, '2018-02-19 05:30:00', NULL, '', 9),
(89, 2, '2018-02-19 05:15:00', NULL, '', 9),
(90, 2, '2018-02-19 05:00:00', NULL, '', 9),
(91, 2, '2018-02-19 04:45:00', NULL, '', 9),
(92, 2, '2018-02-19 04:30:00', NULL, '', 9),
(93, 1, '2018-02-20 23:15:00', NULL, '', 11),
(94, 1, '2018-02-20 23:45:00', NULL, '', NULL),
(95, 2, '2018-02-21 02:15:00', NULL, '', NULL),
(96, 1, '2018-02-21 21:30:00', NULL, '', 11),
(97, 2, '2018-02-21 03:45:00', 9, '   \n\n   DATA WIZYTY: 20-02-18 23:49\n\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Sed finibus turpis sit amet risus gravida, a scelerisque velit ornare. Curabitur convallis nisl non fringilla ultricies. In hac habitasse platea dictumst. Morbi placerat placerat porta. Praesent rutrum quis tellus vel vehicula. Fusce eu elit ultrices, venenatis lacus sit amet, ultricies mauris. Etiam cursus felis ut sem efficitur, et faucibus nibh malesuada. Morbi finibus at ipsum ac fermentum. Nam quis eros quam. In eget nibh ut neque tempor dictum.\n', 15);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `lekarze`
--

CREATE TABLE `lekarze` (
  `Id_lekarza` int(11) NOT NULL,
  `Imie` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `Nazwisko` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `Data_urodzenia` date NOT NULL,
  `Adres` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `Id_miasta` int(11) NOT NULL,
  `Telefon` varchar(50) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `lekarze`
--

INSERT INTO `lekarze` (`Id_lekarza`, `Imie`, `Nazwisko`, `Data_urodzenia`, `Adres`, `Id_miasta`, `Telefon`) VALUES
(1, 'Adam', 'Lekarz1', '2018-02-01', 'ul.Miodowa 25 71-706', 1, '546565656'),
(2, 'Paweł', 'Kaczmarczyk', '2018-02-14', 'asdasdasd', 2, 'jakiś');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `miasta`
--

CREATE TABLE `miasta` (
  `Id_miasta` int(11) NOT NULL,
  `Nazwa` varchar(50) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `miasta`
--

INSERT INTO `miasta` (`Id_miasta`, `Nazwa`) VALUES
(1, 'Kołobrzeg'),
(2, 'Ruda Śląska'),
(3, 'Gliwice'),
(4, 'Tychy');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `oddzialy`
--

CREATE TABLE `oddzialy` (
  `Id_oddzialu` int(11) NOT NULL,
  `Id_specjalizacji` int(11) NOT NULL,
  `Id_lekarza` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `oddzialy`
--

INSERT INTO `oddzialy` (`Id_oddzialu`, `Id_specjalizacji`, `Id_lekarza`) VALUES
(9, 2, 2),
(11, 4, 1),
(15, 3, 2),
(16, 1, 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `odwolane`
--

CREATE TABLE `odwolane` (
  `Id_odwolania` int(11) NOT NULL,
  `Id_pacjenta` int(11) NOT NULL,
  `Lekarz` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `Specjalizacja` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `Dzien_od` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `odwolane`
--

INSERT INTO `odwolane` (`Id_odwolania`, `Id_pacjenta`, `Lekarz`, `Specjalizacja`, `Dzien_od`) VALUES
(3, 8, 'Adam Lekarz', 'Urogol', '2018-02-09 02:00:00'),
(4, 9, 'Adam Lekarz', 'Brak specjalizacji', '2018-02-09 01:30:00'),
(5, 9, 'Adam Lekarz', 'Urogol', '2018-02-19 01:15:00');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pacjenci`
--

CREATE TABLE `pacjenci` (
  `Id_pacjenta` int(11) NOT NULL,
  `Pesel` char(12) COLLATE utf8_polish_ci NOT NULL,
  `Imie` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `Nazwisko` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_polish_ci NOT NULL,
  `Data_urodzenia` date NOT NULL,
  `Adres` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `Id_miasta` int(11) NOT NULL,
  `Telefon` varchar(15) COLLATE utf8_polish_ci NOT NULL,
  `Plec` char(1) COLLATE utf8_polish_ci NOT NULL COMMENT 'M albo K',
  `Id_lekarza` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `pacjenci`
--

INSERT INTO `pacjenci` (`Id_pacjenta`, `Pesel`, `Imie`, `Nazwisko`, `Data_urodzenia`, `Adres`, `Id_miasta`, `Telefon`, `Plec`, `Id_lekarza`) VALUES
(8, '93061312131', 'Piotr', 'Zuber', '2018-02-07', 'Miodowa 12', 1, '123123123', 'M', 2),
(9, '805112312', 'Jaroslaw', 'Jakubiecz', '2018-02-12', 'Szynowa 80/51', 4, '123123123', 'M', 1),
(10, '88885', 'Kazmira', 'Adamska', '2018-02-18', '', 1, '', 'K', 2),
(11, '12345', 'Adam', 'Kowalski', '1995-06-17', 'Ruda Slaska ul ks.Niedzieli 14', 4, '', 'M', 2),
(12, '99999555555', 'TEST Imie', 'TEST Nazwisko', '2018-02-20', 'TEST Adres', 2, '111', 'M', 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `recepty`
--

CREATE TABLE `recepty` (
  `Id_recepty` int(11) NOT NULL,
  `Id_lekarza` int(11) NOT NULL,
  `Id_pacjenta` int(11) NOT NULL,
  `Tresc` varchar(500) COLLATE utf8_polish_ci NOT NULL,
  `Data_waznosci` date NOT NULL,
  `Id_grafiku` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `recepty`
--

INSERT INTO `recepty` (`Id_recepty`, `Id_lekarza`, `Id_pacjenta`, `Tresc`, `Data_waznosci`, `Id_grafiku`) VALUES
(4, 1, 8, 'Fusce in tellus non odio pulvinar lobortis. Aliquam erat volutpat. Sed vestibulum orci nisl, quis imperdiet nunc lobortis vitae. Donec laoreet neque et ipsum condimentum ultrices. Nam dictum diam quis convallis viverra. Aenean id pellentesque velit. Sed fermentum purus id tortor sagittis lobortis. Quisque quis massa ante. Duis interdum consequat purus, nec semper turpis interdum et. Suspendisse ultrices, libero sed euismod finibus, nulla ligula venenatis orci, sed facilisis sem leo non ante. Cra', '2018-02-20', 69),
(5, 2, 9, 'Donec ullamcorper lacus at pretium sodales. Sed at mauris ante. Phasellus euismod finibus velit, nec facilisis mauris facilisis vel. Nulla lectus massa, dapibus at urna eu, sagittis pellentesque orci. Etiam aliquam laoreet convallis. Aenean faucibus leo in dapibus gravida. Etiam ac luctus ipsum.', '2018-02-20', 70),
(6, 2, 9, 'Donec eleifend, velit eu gravida ullamcorper, leo orci bibendum ipsum, et placerat libero mi at eros. Vestibulum lacinia imperdiet lorem sit amet convallis. Vivamus in lectus vestibulum, laoreet nisi nec, tempus ante. Vivamus ac est eu dui elementum varius auctor non lorem. Maecenas efficitur ante a fringilla accumsan. Sed ultricies felis et enim dignissim placerat quis a ex. Aenean auctor sem et magna aliquam, sit amet iaculis turpis congue. Vestibulum ante ipsum primis in faucibus orci luctus ', '2018-02-20', 70);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `specjalizacja`
--

CREATE TABLE `specjalizacja` (
  `Id_specjalizacji` int(11) NOT NULL,
  `Nazwa` varchar(50) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `specjalizacja`
--

INSERT INTO `specjalizacja` (`Id_specjalizacji`, `Nazwa`) VALUES
(1, 'Urolog'),
(2, 'Psychiatra'),
(3, 'Pediatra'),
(4, 'Neurolog');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indexes for table `grafik`
--
ALTER TABLE `grafik`
  ADD PRIMARY KEY (`Id_grafiku`),
  ADD KEY `Oddzial` (`Id_oddzialu`),
  ADD KEY `lekaro` (`Id_lekarza`),
  ADD KEY `Pacjenciii` (`Id_pacjenta`);

--
-- Indexes for table `lekarze`
--
ALTER TABLE `lekarze`
  ADD PRIMARY KEY (`Id_lekarza`),
  ADD KEY `Miasta` (`Id_miasta`);

--
-- Indexes for table `miasta`
--
ALTER TABLE `miasta`
  ADD PRIMARY KEY (`Id_miasta`);

--
-- Indexes for table `oddzialy`
--
ALTER TABLE `oddzialy`
  ADD PRIMARY KEY (`Id_oddzialu`),
  ADD KEY `Specjalizacja` (`Id_specjalizacji`),
  ADD KEY `Lekarz` (`Id_lekarza`);

--
-- Indexes for table `odwolane`
--
ALTER TABLE `odwolane`
  ADD PRIMARY KEY (`Id_odwolania`),
  ADD KEY `Pacjento` (`Id_pacjenta`);

--
-- Indexes for table `pacjenci`
--
ALTER TABLE `pacjenci`
  ADD PRIMARY KEY (`Id_pacjenta`),
  ADD KEY `Lekarz prowadzaca` (`Id_lekarza`),
  ADD KEY `Miastaa` (`Id_miasta`);

--
-- Indexes for table `recepty`
--
ALTER TABLE `recepty`
  ADD PRIMARY KEY (`Id_recepty`),
  ADD KEY `grafik` (`Id_grafiku`),
  ADD KEY `Lekarzz` (`Id_lekarza`),
  ADD KEY `Pancjent` (`Id_pacjenta`);

--
-- Indexes for table `specjalizacja`
--
ALTER TABLE `specjalizacja`
  ADD PRIMARY KEY (`Id_specjalizacji`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `grafik`
--
ALTER TABLE `grafik`
  MODIFY `Id_grafiku` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=98;

--
-- AUTO_INCREMENT dla tabeli `lekarze`
--
ALTER TABLE `lekarze`
  MODIFY `Id_lekarza` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT dla tabeli `miasta`
--
ALTER TABLE `miasta`
  MODIFY `Id_miasta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT dla tabeli `oddzialy`
--
ALTER TABLE `oddzialy`
  MODIFY `Id_oddzialu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT dla tabeli `odwolane`
--
ALTER TABLE `odwolane`
  MODIFY `Id_odwolania` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT dla tabeli `pacjenci`
--
ALTER TABLE `pacjenci`
  MODIFY `Id_pacjenta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT dla tabeli `recepty`
--
ALTER TABLE `recepty`
  MODIFY `Id_recepty` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT dla tabeli `specjalizacja`
--
ALTER TABLE `specjalizacja`
  MODIFY `Id_specjalizacji` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `grafik`
--
ALTER TABLE `grafik`
  ADD CONSTRAINT `lekaro` FOREIGN KEY (`Id_lekarza`) REFERENCES `lekarze` (`Id_lekarza`);

--
-- Ograniczenia dla tabeli `lekarze`
--
ALTER TABLE `lekarze`
  ADD CONSTRAINT `Miasta` FOREIGN KEY (`Id_miasta`) REFERENCES `miasta` (`Id_miasta`);

--
-- Ograniczenia dla tabeli `oddzialy`
--
ALTER TABLE `oddzialy`
  ADD CONSTRAINT `Specjalizacja` FOREIGN KEY (`Id_specjalizacji`) REFERENCES `specjalizacja` (`Id_specjalizacji`);

--
-- Ograniczenia dla tabeli `odwolane`
--
ALTER TABLE `odwolane`
  ADD CONSTRAINT `Pacjento` FOREIGN KEY (`Id_pacjenta`) REFERENCES `pacjenci` (`Id_pacjenta`);

--
-- Ograniczenia dla tabeli `pacjenci`
--
ALTER TABLE `pacjenci`
  ADD CONSTRAINT `Miastaa` FOREIGN KEY (`Id_miasta`) REFERENCES `miasta` (`Id_miasta`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ograniczenia dla tabeli `recepty`
--
ALTER TABLE `recepty`
  ADD CONSTRAINT `Lekarzz` FOREIGN KEY (`Id_lekarza`) REFERENCES `lekarze` (`Id_lekarza`),
  ADD CONSTRAINT `Pancjent` FOREIGN KEY (`Id_pacjenta`) REFERENCES `pacjenci` (`Id_pacjenta`),
  ADD CONSTRAINT `grafik` FOREIGN KEY (`Id_grafiku`) REFERENCES `grafik` (`Id_grafiku`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 19, 2018 at 05:23 PM
-- Server version: 10.1.28-MariaDB
-- PHP Version: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `przychodnia`
--

-- --------------------------------------------------------

--
-- Table structure for table `grafik`
--

CREATE TABLE `grafik` (
  `Id_grafiku` int(11) NOT NULL,
  `Id_lekarza` int(11) NOT NULL,
  `Dzien_od` datetime NOT NULL COMMENT '15 minut na wizyte',
  `Id_pacjenta` int(11) DEFAULT NULL COMMENT 'jesli null to wolne',
  `Opis` varchar(500) COLLATE utf8_polish_ci NOT NULL COMMENT 'max 500 znakow',
  `Id_oddzialu` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `grafik`
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
(82, 1, '2018-02-19 01:15:00', 8, '   \n\n   DATA WIZYTY: 18-02-18 19:32\n\n   \n\n   DATA WIZYTY: 18-02-18 19:25\n\nsaddasasdasdddddddd', 12),
(83, 1, '2018-02-19 01:00:00', NULL, '', 12),
(84, 1, '2018-02-19 00:45:00', NULL, '', 12),
(85, 2, '2018-02-19 06:15:00', NULL, '', 9),
(86, 2, '2018-02-19 06:00:00', NULL, '', 9),
(87, 2, '2018-02-19 05:45:00', NULL, '', 9),
(88, 2, '2018-02-19 05:30:00', NULL, '', 9),
(89, 2, '2018-02-19 05:15:00', NULL, '', 9),
(90, 2, '2018-02-19 05:00:00', NULL, '', 9),
(91, 2, '2018-02-19 04:45:00', NULL, '', 9),
(92, 2, '2018-02-19 04:30:00', NULL, '', 9);

-- --------------------------------------------------------

--
-- Table structure for table `lekarze`
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
-- Dumping data for table `lekarze`
--

INSERT INTO `lekarze` (`Id_lekarza`, `Imie`, `Nazwisko`, `Data_urodzenia`, `Adres`, `Id_miasta`, `Telefon`) VALUES
(1, 'Adam', 'Lekarz', '2018-02-01', 'ul.Miodowa 25 71-706', 1, '546565656'),
(2, 'Paweł', 'Kaczmarczyk', '2018-02-14', 'asdasdasd', 2, 'jakiś');

-- --------------------------------------------------------

--
-- Table structure for table `miasta`
--

CREATE TABLE `miasta` (
  `Id_miasta` int(11) NOT NULL,
  `Nazwa` varchar(50) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `miasta`
--

INSERT INTO `miasta` (`Id_miasta`, `Nazwa`) VALUES
(1, 'Kołobrzeg'),
(2, 'Ruda Śląska'),
(3, 'Gliwice');

-- --------------------------------------------------------

--
-- Table structure for table `oddzialy`
--

CREATE TABLE `oddzialy` (
  `Id_oddzialu` int(11) NOT NULL,
  `Id_specjalizacji` int(11) NOT NULL,
  `Id_lekarza` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `oddzialy`
--

INSERT INTO `oddzialy` (`Id_oddzialu`, `Id_specjalizacji`, `Id_lekarza`) VALUES
(9, 2, 2),
(11, 4, 1),
(15, 3, 2);

-- --------------------------------------------------------

--
-- Table structure for table `odwolane`
--

CREATE TABLE `odwolane` (
  `Id_odwolania` int(11) NOT NULL,
  `Id_pacjenta` int(11) NOT NULL,
  `Lekarz` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `Specjalizacja` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `Dzien_od` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `odwolane`
--

INSERT INTO `odwolane` (`Id_odwolania`, `Id_pacjenta`, `Lekarz`, `Specjalizacja`, `Dzien_od`) VALUES
(3, 8, 'Adam Lekarz', 'Urogol', '2018-02-09 02:00:00'),
(4, 9, 'Adam Lekarz', 'Brak specjalizacji', '2018-02-09 01:30:00'),
(5, 9, 'Adam Lekarz', 'Urogol', '2018-02-19 01:15:00');

-- --------------------------------------------------------

--
-- Table structure for table `pacjenci`
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
-- Dumping data for table `pacjenci`
--

INSERT INTO `pacjenci` (`Id_pacjenta`, `Pesel`, `Imie`, `Nazwisko`, `Data_urodzenia`, `Adres`, `Id_miasta`, `Telefon`, `Plec`, `Id_lekarza`) VALUES
(8, '11', 's', 's', '2018-02-07', '1', 1, '11', 'M', 1),
(9, '123', '123', '231', '2018-02-12', '123', 2, '123', 'M', 6),
(10, '', '', '', '2018-02-18', '', 1, '', 'M', 1);

-- --------------------------------------------------------

--
-- Table structure for table `recepty`
--

CREATE TABLE `recepty` (
  `Id_recepty` int(11) NOT NULL,
  `Id_lekarza` int(11) NOT NULL,
  `Id_pacjenta` int(11) NOT NULL,
  `Tresc` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `Data_waznosci` date NOT NULL,
  `Id_grafiku` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `recepty`
--

INSERT INTO `recepty` (`Id_recepty`, `Id_lekarza`, `Id_pacjenta`, `Tresc`, `Data_waznosci`, `Id_grafiku`) VALUES
(2, 1, 8, 'dsaaaaaaaaaaaaa', '2018-02-18', 69);

-- --------------------------------------------------------

--
-- Table structure for table `specjalizacja`
--

CREATE TABLE `specjalizacja` (
  `Id_specjalizacji` int(11) NOT NULL,
  `Nazwa` varchar(50) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `specjalizacja`
--

INSERT INTO `specjalizacja` (`Id_specjalizacji`, `Nazwa`) VALUES
(1, 'Urogol'),
(2, 'Psychiatra'),
(3, 'Pediatra'),
(4, 'Neurolog');

--
-- Indexes for dumped tables
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
-- AUTO_INCREMENT for table `grafik`
--
ALTER TABLE `grafik`
  MODIFY `Id_grafiku` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=93;

--
-- AUTO_INCREMENT for table `lekarze`
--
ALTER TABLE `lekarze`
  MODIFY `Id_lekarza` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `miasta`
--
ALTER TABLE `miasta`
  MODIFY `Id_miasta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `oddzialy`
--
ALTER TABLE `oddzialy`
  MODIFY `Id_oddzialu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `odwolane`
--
ALTER TABLE `odwolane`
  MODIFY `Id_odwolania` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `pacjenci`
--
ALTER TABLE `pacjenci`
  MODIFY `Id_pacjenta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `recepty`
--
ALTER TABLE `recepty`
  MODIFY `Id_recepty` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `specjalizacja`
--
ALTER TABLE `specjalizacja`
  MODIFY `Id_specjalizacji` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `grafik`
--
ALTER TABLE `grafik`
  ADD CONSTRAINT `lekaro` FOREIGN KEY (`Id_lekarza`) REFERENCES `lekarze` (`Id_lekarza`);

--
-- Constraints for table `lekarze`
--
ALTER TABLE `lekarze`
  ADD CONSTRAINT `Miasta` FOREIGN KEY (`Id_miasta`) REFERENCES `miasta` (`Id_miasta`);

--
-- Constraints for table `oddzialy`
--
ALTER TABLE `oddzialy`
  ADD CONSTRAINT `Specjalizacja` FOREIGN KEY (`Id_specjalizacji`) REFERENCES `specjalizacja` (`Id_specjalizacji`);

--
-- Constraints for table `odwolane`
--
ALTER TABLE `odwolane`
  ADD CONSTRAINT `Pacjento` FOREIGN KEY (`Id_pacjenta`) REFERENCES `pacjenci` (`Id_pacjenta`);

--
-- Constraints for table `pacjenci`
--
ALTER TABLE `pacjenci`
  ADD CONSTRAINT `Miastaa` FOREIGN KEY (`Id_miasta`) REFERENCES `miasta` (`Id_miasta`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `recepty`
--
ALTER TABLE `recepty`
  ADD CONSTRAINT `Lekarzz` FOREIGN KEY (`Id_lekarza`) REFERENCES `lekarze` (`Id_lekarza`),
  ADD CONSTRAINT `Pancjent` FOREIGN KEY (`Id_pacjenta`) REFERENCES `pacjenci` (`Id_pacjenta`),
  ADD CONSTRAINT `grafik` FOREIGN KEY (`Id_grafiku`) REFERENCES `grafik` (`Id_grafiku`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

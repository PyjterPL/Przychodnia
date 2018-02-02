-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 02, 2018 at 05:50 PM
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
  `Id_pacjenta` int(11) NOT NULL COMMENT 'jesli null to wolne',
  `Opis` varchar(500) COLLATE utf8_polish_ci NOT NULL COMMENT 'max 500 znakow',
  `Id_oddzialu` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

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
(1, 'Adam', 'Kowalski', '2018-02-05', 'ul.Miodowa 12', 2, '12312312'),
(2, 'Jan', 'Wiśniewski', '2016-07-20', 'Wiśniowa', 1, '+28 123 45 45');

-- --------------------------------------------------------

--
-- Table structure for table `miasta`
--

CREATE TABLE `miasta` (
  `Id_miasta` int(11) NOT NULL,
  `Nazwa` varchar(50) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `oddzialy`
--

CREATE TABLE `oddzialy` (
  `Id_oddzialu` int(11) NOT NULL,
  `Id_specjalizacji` int(11) NOT NULL,
  `Id_lekarza` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `odwolane`
--

CREATE TABLE `odwolane` (
  `Id_odwolania` int(11) NOT NULL,
  `Id_grafiku` int(11) NOT NULL,
  `Id_pacjenta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

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
  `Id_grafiku` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `specjalizacja`
--

CREATE TABLE `specjalizacja` (
  `Id_specjalizacji` int(11) NOT NULL,
  `Nazwa` varchar(50) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `grafik`
--
ALTER TABLE `grafik`
  ADD PRIMARY KEY (`Id_grafiku`);

--
-- Indexes for table `lekarze`
--
ALTER TABLE `lekarze`
  ADD PRIMARY KEY (`Id_lekarza`);

--
-- Indexes for table `miasta`
--
ALTER TABLE `miasta`
  ADD PRIMARY KEY (`Id_miasta`);

--
-- Indexes for table `oddzialy`
--
ALTER TABLE `oddzialy`
  ADD PRIMARY KEY (`Id_oddzialu`);

--
-- Indexes for table `odwolane`
--
ALTER TABLE `odwolane`
  ADD PRIMARY KEY (`Id_odwolania`);

--
-- Indexes for table `pacjenci`
--
ALTER TABLE `pacjenci`
  ADD PRIMARY KEY (`Id_pacjenta`);

--
-- Indexes for table `recepty`
--
ALTER TABLE `recepty`
  ADD PRIMARY KEY (`Id_recepty`);

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
  MODIFY `Id_grafiku` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `lekarze`
--
ALTER TABLE `lekarze`
  MODIFY `Id_lekarza` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `miasta`
--
ALTER TABLE `miasta`
  MODIFY `Id_miasta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `oddzialy`
--
ALTER TABLE `oddzialy`
  MODIFY `Id_oddzialu` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `odwolane`
--
ALTER TABLE `odwolane`
  MODIFY `Id_odwolania` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pacjenci`
--
ALTER TABLE `pacjenci`
  MODIFY `Id_pacjenta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `recepty`
--
ALTER TABLE `recepty`
  MODIFY `Id_recepty` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `specjalizacja`
--
ALTER TABLE `specjalizacja`
  MODIFY `Id_specjalizacji` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

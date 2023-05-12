-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 11, 2023 at 08:16 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hoteldatabase`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `aID` varchar(3) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `DoB` varchar(20) NOT NULL,
  `Gender` char(1) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `ID` int(3) NOT NULL,
  `aProfilePic` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`aID`, `Name`, `DoB`, `Gender`, `Phone`, `Email`, `ID`, `aProfilePic`) VALUES
('A01', 'Alexia Putellas', '31-07-95', 'F', '050656252', 'palexia@fcb.com', 1, '');

-- --------------------------------------------------------

--
-- Table structure for table `bill`
--

CREATE TABLE `bill` (
  `bID` varchar(5) NOT NULL,
  `bDate` varchar(30) NOT NULL,
  `bAmount` int(255) NOT NULL,
  `bFine` int(255) NOT NULL,
  `totalAmount` int(255) NOT NULL,
  `bkID` varchar(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bill`
--

INSERT INTO `bill` (`bID`, `bDate`, `bAmount`, `bFine`, `totalAmount`, `bkID`) VALUES
('B01', '06-05-23', 1500, 500, 2000, 'BK01'),
('B02', '04-05-23', 1000, 0, 1000, 'BK02'),
('B03', '03-05-23', 500, 0, 500, 'BK03'),
('B04', '03-05-23', 700, 0, 700, 'BK04'),
('B05', '03-05-23', 700, 0, 700, 'BK05'),
('B06', '04-05-23', 1700, 0, 1700, 'BK06'),
('B07', '04-05-23', 1700, 1700, 3400, 'BK07'),
('B08', '04-05-23', 4000, 2000, 6000, 'BK08'),
('B09', '02-05-23', 2000, 0, 2000, 'BK09'),
('B10', '05-05-23', 6000, 0, 6000, 'BK10'),
('B11', '07-05-23', 500, 500, 1000, 'BK11'),
('B12', '07-05-23', 500, 0, 500, 'BK12'),
('B13', '07-05-23', 500, 500, 1000, 'BK13'),
('B14', '07-05-23', 700, 0, 700, 'BK14'),
('B15', '07-05-23', 700, 0, 700, 'BK15'),
('B16', '07-05-23', 850, 0, 850, 'BK16'),
('B17', '07-05-23', 850, 850, 1700, 'BK17'),
('B18', '07-05-23', 2000, 2000, 4000, 'BK18'),
('B19', '07-05-23', 2000, 0, 2000, 'BK19'),
('B20', '07-05-23', 2000, 0, 2000, 'BK20');

-- --------------------------------------------------------

--
-- Table structure for table `bookingdetails`
--

CREATE TABLE `bookingdetails` (
  `bkID` varchar(4) NOT NULL,
  `bkDate` varchar(20) NOT NULL,
  `checkOutDate` varchar(20) NOT NULL,
  `bkDuration` int(5) NOT NULL,
  `rID` varchar(3) NOT NULL,
  `rcID` varchar(4) NOT NULL,
  `mID` varchar(3) NOT NULL,
  `gID` varchar(3) NOT NULL,
  `bID` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bookingdetails`
--

INSERT INTO `bookingdetails` (`bkID`, `bkDate`, `checkOutDate`, `bkDuration`, `rID`, `rcID`, `mID`, `gID`, `bID`) VALUES
('BK01', '02-05-23', '05-05-23', 3, 'R01', 'RC01', 'M01', 'G01', 'B01'),
('BK02', '02-05-23', '04-05-23', 2, 'R02', 'RC02', 'M01', 'G04', 'B02'),
('BK03', '02-05-23', '03-05-23', 1, 'R03', 'RC03', 'M01', 'G03', 'B03'),
('BK04', '02-05-23', '03-05-23', 1, 'R04', 'RC04', 'M02', 'G02', 'B04'),
('BK05', '02-05-23', '03-05-23', 1, 'R05', 'RC05', 'M02', 'G05', 'B05'),
('BK06', '02-05-23', '04-05-23', 2, 'R06', 'RC01', 'M01', 'G06', 'B06'),
('BK07', '02-05-23', '04-05-23', 2, 'R07', 'RC02', 'M01', 'G07', 'B07'),
('BK08', '02-05-23', '04-05-23', 2, 'R08', 'RC03', 'M01', 'G08', 'B08'),
('BK09', '02-05-23', '02-05-23', 1, 'R09', 'RC04', 'M02', 'G09', 'B09'),
('BK10', '02-05-23', '05-05-23', 3, 'R10', 'RC05', 'M02', 'G14', 'B10'),
('BK11', '06-05-23', '07-05-23', 1, 'R01', 'RC01', 'M01', 'G11', 'B11'),
('BK12', '06-05-23', '07-05-23', 1, 'R02', 'RC02', 'M01', 'G01', 'B12'),
('BK13', '06-05-23', '07-05-23', 1, 'R03', 'RC03', 'M01', 'G02', 'B13'),
('BK14', '06-05-23', '07-05-23', 1, 'R04', 'RC04', 'M02', 'G10', 'B14'),
('BK15', '06-05-23', '07-05-23', 1, 'R05', 'RC05', 'M02', 'G04', 'B15'),
('BK16', '06-05-23', '07-05-23', 1, 'R06', 'RC01', 'M01', 'G06', 'B16'),
('BK17', '06-05-23', '07-05-23', 1, 'R07', 'RC02', 'M01', 'G12', 'B17'),
('BK18', '06-05-23', '07-05-23', 1, 'R08', 'RC03', 'M01', 'G13', 'B18'),
('BK19', '06-05-23', '07-05-23', 1, 'R09', 'RC04', 'M02', 'G14', 'B19'),
('BK20', '06-05-23', '07-05-23', 1, 'R10', 'RC05', 'M02', 'G07', 'B20'),
('BK21', '08-05-23', '10-05-23', 2, 'R10', 'RC01', 'M01', 'G11', 'B21'),
('BK22', '08-05-23', '10-05-23', 2, 'R06', 'RC01', 'M01', 'G04', 'B22');

-- --------------------------------------------------------

--
-- Table structure for table `guest`
--

CREATE TABLE `guest` (
  `gID` varchar(3) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `DoB` varchar(20) NOT NULL,
  `Gender` char(1) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `NumberOfVisits` int(5) NOT NULL,
  `gProfilePic` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `guest`
--

INSERT INTO `guest` (`gID`, `Name`, `DoB`, `Gender`, `Phone`, `Email`, `NumberOfVisits`, `gProfilePic`) VALUES
('G01', 'Robert Lewandowski', '21-08-88', 'M', '0555161707', 'rlewandowski@fcb.com', 2, ''),
('G02', 'Pablo gavi', '12-05-00', 'M', '0501576568', 'pgavi@fcb.com', 2, ''),
('G03', 'Frido Rolfo ', '23-04-99', 'F', '0552143073', 'frolfo@fcb.com', 2, ''),
('G04', 'Pedri Gonzalez', '16-08-89', 'M', '0509124269', 'gpedri@fcb.com', 3, ''),
('G05', 'Ronald Araujo', '30-06-78', 'M', '050548624', 'raraujo@fcb.com', 3, ''),
('G06', 'Sergio Busquets ', '19-10-84', 'M', '055969584', 'sbusquets@fcb.com', 3, ''),
('G07', 'Keira Walsh ', '13-12-78', 'F', '050215948', 'wkeira@fcb.com', 2, ''),
('G08', 'Jules Kounde', '25-07-81', 'M', '050232584', 'jkounde@fcb.com', 1, ''),
('G09', 'Caroline Hansen', '01-11-01', 'F', '050252194', 'hcaroline@fcb.com', 1, ''),
('G10', 'Ferran Torres ', '16-06-88', 'M', '055251958', 'tferran@fcb.com', 1, ''),
('G11', 'Pablo Torre ', '09-05-96', 'M', '055218954', 'tpablo@fcb.com', 2, ''),
('G12', 'Sergi Roberto ', '10-07-81', 'M', '050595487', 'sroberto@fcb.com', 1, ''),
('G13', 'Alejandro Balde ', '14-09-87', 'M', '050251365', 'abalde@fcb.com', 1, ''),
('G14', 'Frenkie De Jong', '12-11-70', 'F', '050898548', 'djfrenkie@fcb.com', 3, '');

-- --------------------------------------------------------

--
-- Table structure for table `managers`
--

CREATE TABLE `managers` (
  `mID` varchar(3) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `DoB` varchar(20) NOT NULL,
  `Gender` char(1) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `ID` int(3) NOT NULL,
  `mProfilePic` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `managers`
--

INSERT INTO `managers` (`mID`, `Name`, `DoB`, `Gender`, `Phone`, `Email`, `ID`, `mProfilePic`) VALUES
('M01', 'Lionel Messi', '12-09-99', 'M', '055252165', 'lmessi@fcb.com', 2, ''),
('M02', 'Maria Leon', '22-06-98', 'F', '050425152', 'mleon@fcb.com', 3, '');

-- --------------------------------------------------------

--
-- Table structure for table `receptionists`
--

CREATE TABLE `receptionists` (
  `rcID` varchar(4) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `DoB` varchar(20) NOT NULL,
  `Gender` char(1) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `ID` int(3) NOT NULL,
  `rProfilePic` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `receptionists`
--

INSERT INTO `receptionists` (`rcID`, `Name`, `DoB`, `Gender`, `Phone`, `Email`, `ID`, `rProfilePic`) VALUES
('RC01', 'Pep Guardiola', '15-10-00', 'M', '055121454', 'gpep@fcb.com', 4, ''),
('RC02', 'Carles Puyol', '05-05-01', 'M', '050585464', 'pcarles@fcb.com', 5, ''),
('RC03', 'Luis Suarez ', '06-06-99', 'M', '055032659', 'lsuarez@fcb.com', 6, ''),
('RC04', 'Ingrid Engen', '17-08-98', 'F', '055020154', 'iengen@fcb.com', 7, ''),
('RC05', 'Ter Stegan', '09-05-01', 'M', '055254985', 'ster@fcb.com', 8, ''),
('RC06', 'Andreas Iniesta', '01-01-95', 'M', '0555454658', 'ainiesta1995@fcb.com', 9, '');

-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

CREATE TABLE `rooms` (
  `rID` varchar(3) NOT NULL,
  `rType` varchar(10) NOT NULL,
  `rPrice` float NOT NULL,
  `rStatus` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`rID`, `rType`, `rPrice`, `rStatus`) VALUES
('R01', 'junior', 500, 1),
('R02', 'junior', 500, 1),
('R03', 'junior', 500, 1),
('R04', 'two', 700, 1),
('R05', 'two', 700, 1),
('R06', 'three', 850, 0),
('R07', 'three', 850, 1),
('R08', 'royal', 2000, 1),
('R09', 'royal', 2000, 1),
('R10', 'royal', 2000, 0);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `ID` int(3) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(10) NOT NULL,
  `Role` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `Username`, `Password`, `Role`) VALUES
(1, 'palexia1999', '12345678', 'Admin'),
(2, 'lmessi1999', '12345678', 'Manager'),
(3, 'mleon1998', '12345678', 'Manager'),
(4, 'gpep2000', '12345678', 'Receptionist'),
(5, 'pcarles2001', '12345678', 'Receptionist'),
(6, 'lsuarez1999', '12345678', 'Receptionist'),
(7, 'iengen1998', '12345678', 'Receptionist'),
(8, 'ster2001', '12345678', 'Receptionist'),
(9, 'ainiesta1995', '12345678', 'Receptionist');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD UNIQUE KEY `ID` (`ID`),
  ADD KEY `ID_2` (`ID`);

--
-- Indexes for table `bill`
--
ALTER TABLE `bill`
  ADD PRIMARY KEY (`bID`),
  ADD KEY `bkID` (`bkID`);

--
-- Indexes for table `bookingdetails`
--
ALTER TABLE `bookingdetails`
  ADD PRIMARY KEY (`bkID`),
  ADD KEY `rID` (`rID`,`rcID`,`mID`,`gID`),
  ADD KEY `gID` (`gID`),
  ADD KEY `mID` (`mID`),
  ADD KEY `rcID` (`rcID`);

--
-- Indexes for table `guest`
--
ALTER TABLE `guest`
  ADD PRIMARY KEY (`gID`);

--
-- Indexes for table `managers`
--
ALTER TABLE `managers`
  ADD UNIQUE KEY `ID_2` (`ID`),
  ADD KEY `ID` (`ID`);

--
-- Indexes for table `receptionists`
--
ALTER TABLE `receptionists`
  ADD PRIMARY KEY (`rcID`),
  ADD KEY `ID_2` (`ID`);

--
-- Indexes for table `rooms`
--
ALTER TABLE `rooms`
  ADD PRIMARY KEY (`rID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

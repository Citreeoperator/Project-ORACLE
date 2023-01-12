-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 08, 2023 at 02:03 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_mdrrmoopsys`
--

-- --------------------------------------------------------

--
-- Table structure for table `contact_directory`
--

CREATE TABLE `contact_directory` (
  `contactid` int(50) NOT NULL,
  `type` varchar(250) NOT NULL,
  `agencybrgy` varchar(250) NOT NULL,
  `person` varchar(250) NOT NULL,
  `freq` varchar(250) NOT NULL,
  `position` varchar(250) NOT NULL,
  `remarks` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `contact_directory`
--

INSERT INTO `contact_directory` (`contactid`, `type`, `agencybrgy`, `person`, `freq`, `position`, `remarks`) VALUES
(1, 'Radio Frequency', 'Zone 7 Poblacion', 'Brgy. Kagawad', '148.450mhz', 'Brgy. Kagawad', 'Taga sitio Tabing Loob'),
(2, 'Telephone Number', 'BFP', 'staff', '165', 'n/a', 'Fire Station'),
(5, 'Telephone Number', 'PNP', 'Policemen', '166', 'General', 'Police Officer'),
(6, 'Cellphone Number', 'MDRRMO', 'Radio Operator', '09089832111', 'Radio Operator', 'not available'),
(7, 'Radio Frequency', 'MDRRMO', 'Aldwin Cervantes', '147.150mhz', 'Radio Operator', 'nothing follows'),
(8, 'Telephone Number', 'MDRRMO', 'Aldwin Cervantes', '119', 'Communication Office', 'GTS Provider'),
(9, 'Radio Frequency', 'MDRRMO', 'John Phillip Lasheras', '155.150mhz', 'Radio Technician', '+4 / Tone: 100.5');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `empid` varchar(50) NOT NULL,
  `lastname` varchar(250) NOT NULL,
  `firstname` varchar(250) NOT NULL,
  `mi` varchar(250) NOT NULL,
  `gender` varchar(250) NOT NULL,
  `address` varchar(250) NOT NULL,
  `birthdate` varchar(250) NOT NULL,
  `birthplace` varchar(250) NOT NULL,
  `contactno` varchar(250) NOT NULL,
  `contactname` varchar(250) NOT NULL,
  `relationship` varchar(250) NOT NULL,
  `contactaddress` varchar(250) NOT NULL,
  `noofcontact` varchar(250) NOT NULL,
  `remarks` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`empid`, `lastname`, `firstname`, `mi`, `gender`, `address`, `birthdate`, `birthplace`, `contactno`, `contactname`, `relationship`, `contactaddress`, `noofcontact`, `remarks`) VALUES
('ATIM-HE-MDRRMO-004', 'Lasheras', 'John Phillip', 'V', 'Male', 'Atimonan, Quezon', '08/27/1985', 'Quezon City', '835-116', 'Marissa Lasheras', 'Wife', 'Zone 2 Pob. Atimonan Quezon', '09307951439', 'nasa bicol sila');

-- --------------------------------------------------------

--
-- Table structure for table `imt`
--

CREATE TABLE `imt` (
  `imtid` int(11) NOT NULL,
  `activity` varchar(250) NOT NULL,
  `date` varchar(250) NOT NULL,
  `location` varchar(250) NOT NULL,
  `remarks` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `imt`
--

INSERT INTO `imt` (`imtid`, `activity`, `date`, `location`, `remarks`) VALUES
(1, 'Atimonans Day', '02/04/2022', 'Atimonan, Quezon', 'Activity on Baypark'),
(3, 'Atimonan Tagultol Festival', '08/1 -2/2023', 'Atimonan Area', 'Parades and Many Events with Concert'),
(4, 'Oplan SUMVAC', '03/23-28/2023', 'Atimonan, Quezon', 'Along Maharlika Hi-way ');

-- --------------------------------------------------------

--
-- Table structure for table `incident_report`
--

CREATE TABLE `incident_report` (
  `irid` int(50) NOT NULL,
  `date` varchar(250) NOT NULL,
  `time` varchar(250) NOT NULL,
  `nature` varchar(250) NOT NULL,
  `place` varchar(250) NOT NULL,
  `victimno` varchar(250) NOT NULL,
  `injuryno` varchar(250) NOT NULL,
  `casualtyno` varchar(250) NOT NULL,
  `hospital` varchar(250) NOT NULL,
  `collision` varchar(250) NOT NULL,
  `vehicle` varchar(250) NOT NULL,
  `reporter` varchar(250) NOT NULL,
  `contact` varchar(250) NOT NULL,
  `patientinfo` varchar(250) NOT NULL,
  `vehicleinfo` varchar(250) NOT NULL,
  `responder` varchar(250) NOT NULL,
  `remarks` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `incident_report`
--

INSERT INTO `incident_report` (`irid`, `date`, `time`, `nature`, `place`, `victimno`, `injuryno`, `casualtyno`, `hospital`, `collision`, `vehicle`, `reporter`, `contact`, `patientinfo`, `vehicleinfo`, `responder`, `remarks`) VALUES
(1, '10/10/2010', '0855H', 'Road Crash (self-accident)', 'Brgy. Sta. Catalina', '1', '1', '0', 'DMMDH', 'No', 'Motorcycle', 'Anonymous', '316-1425', 'Sherwin Aldoso / 34 / Male / Unisan, Quezon', 'Honda Wave 125', 'BFP, MDRRMO, PNP, Volunteer', 'N/A'),
(2, '01/07/2023', '1630H', 'Road Crash', 'San Isidro ', '10', '2', '0', 'DMMDH', 'Yes', 'Motor vs. Truck', 'tanod coco', '147.150mhz', 'Dolphi / 99 / male / Cam. Norte', 'Van / White / CDE-999', 'MDRRMO, BFP, PNP', 'No unusual happenings');

-- --------------------------------------------------------

--
-- Table structure for table `regular_schedule`
--

CREATE TABLE `regular_schedule` (
  `rsid` int(50) NOT NULL,
  `date` varchar(250) NOT NULL,
  `name` varchar(250) NOT NULL,
  `patientcase` varchar(250) NOT NULL,
  `age` varchar(250) NOT NULL,
  `gender` varchar(250) NOT NULL,
  `contactname` varchar(250) NOT NULL,
  `relationship` varchar(250) NOT NULL,
  `contactno` varchar(250) NOT NULL,
  `origin` varchar(250) NOT NULL,
  `destination` varchar(250) NOT NULL,
  `driver` varchar(250) NOT NULL,
  `refer` varchar(250) NOT NULL,
  `request` varchar(250) NOT NULL,
  `dispatch` varchar(250) NOT NULL,
  `remarks` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `regular_schedule`
--

INSERT INTO `regular_schedule` (`rsid`, `date`, `name`, `patientcase`, `age`, `gender`, `contactname`, `relationship`, `contactno`, `origin`, `destination`, `driver`, `refer`, `request`, `dispatch`, `remarks`) VALUES
(1, '10/10/2010', 'Christine Jacob Olfaria', 'Fracture', '15', 'Female', 'Justine Jacob', 'Son', '09203564778', 'Atimonan, Quezon', 'Lipa City', 'Mario Roldan', 'Kuya Mars', 'Brandy', 'Aldwin', 'see attach docs');

-- --------------------------------------------------------

--
-- Table structure for table `tb_login`
--

CREATE TABLE `tb_login` (
  `username` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_login`
--

INSERT INTO `tb_login` (`username`, `password`) VALUES
('admin', '10121'),
('user', 'user');

-- --------------------------------------------------------

--
-- Table structure for table `transfer_request`
--

CREATE TABLE `transfer_request` (
  `trid` int(20) NOT NULL,
  `date` varchar(50) NOT NULL,
  `name` varchar(250) NOT NULL,
  `patientcase` varchar(250) NOT NULL,
  `age` varchar(250) NOT NULL,
  `gender` varchar(250) NOT NULL,
  `contactname` varchar(250) NOT NULL,
  `relationship` varchar(250) NOT NULL,
  `contactno` varchar(250) NOT NULL,
  `origin` varchar(250) NOT NULL,
  `destination` varchar(250) NOT NULL,
  `driver` varchar(250) NOT NULL,
  `refer` varchar(250) NOT NULL,
  `request` varchar(250) NOT NULL,
  `dispatch` varchar(250) NOT NULL,
  `remarks` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transfer_request`
--

INSERT INTO `transfer_request` (`trid`, `date`, `name`, `patientcase`, `age`, `gender`, `contactname`, `relationship`, `contactno`, `origin`, `destination`, `driver`, `refer`, `request`, `dispatch`, `remarks`) VALUES
(1, '01/01/2023', 'Coco Martin', 'HIV Positive', '30', 'Male', 'Yvette Campomanes', 'GF kong swabe', '09123456789', 'DMMDH', 'QMC', 'Rosendo Amador Jr.', 'Dr. Kwak-Kwak', 'PB Zone 5', 'Gwapo', 'Supot na may kasamang Luag'),
(2, '12/12/2002', 'Daniel Padilla', 'Droga', '45', 'Male', 'sdasdasd', 'sdasd', 'sdasdasd', 'asdas', 'asdas', 'Mario Roldan', 'sdasd', 'asdasd', 'sdasdas', 'asdasdas'),
(3, '10/07/1999', 'Melma Lasquety', 'Robbery', '23', 'Female', 'Rosauro Lasquety', 'Lolo', '0123456789', 'DMMDH', 'BJMP', 'STAN', 'Dr. Cervantes', 'PB of Zone 5', 'Sir Pogi', 'need ng 10 oxygen'),
(5, '02/23/1995', 'Eric Tayag', 'Flu', '14', 'Male', 'Jeric Zapanta', 'Bother in Law', '316-4155', 'DMMDH', 'QMC', 'Mario Roldan', 'Dr. Pasamba', 'Kgwd. Santander / Zone 6 Pob.', 'Ate mo Melma', 'kelangan ng oxygen mga 20'),
(6, '08/27/1985', 'Phillip Lasheras', 'Pogi mo', '18', 'Male', 'Jamie Beslumbre', 'Mother', '09112234456678', 'DMMDH', 'QMC', 'Danilo Verastigue', 'Dr. Argulla', 'Kap. Ramci Vargas', 'Aldwin Cervantes', 'Uhuging bata yan, kaya nadapa'),
(17, '12/12/2012', 'Sandra Garcia', 'Severe Fever', '43', 'Female', 'Erwin Anda', 'Father in Law', '09134567895', 'Atimonan, Quezon', 'Lucena City', 'Danilo Verastigue', 'Dr. Olivia Umali', 'Kap. Sharon Tuazon', 'Aldwin Cervantes', 'take medicine 3x a day'),
(20, '12/31/2022', 'Shella Gregana', 'Third party', '37', 'Female', 'Melissa Gregana', 'Kapatid', '9999999999', 'Lucban', 'Mauban', 'Danilo Verastigue', 'Dr. Escalante', 'Kgwd. Lolita Amador', 'Phillp Lasheras', 'None'),
(21, '04/08/2009', 'Kiko Canales', 'Drugs', '41', 'Male', 'Ginalyn Canales', 'Wife', '14725836900', 'Balubad', 'Zone 3', 'STAN Rescue Jaguar', 'Dr. Aris', 'Kgwd. Lozano', 'Mike', 'None'),
(22, '06/16/2006', 'Joey Pauli', 'Homicide with Robbery', '38', 'Male', 'Nelson Luna', 'kapitbahay', '9789785461212', 'Angeles', 'Tagbakin', 'Rosendo Amador Jr.', 'Mark Jason Vila', 'Ryan', 'Jenkee', 'N/A'),
(23, '07/27/2222', 'Vic Sotto', 'Rape', '67', 'Male', 'Channel 7', 'Borther', 'Channel 7', 'GMA', 'ABSCBN', 'Mario Roldan', 'Joey Marquez', 'Jimmy Santos', 'Allan K', 'Eat Bulaga'),
(28, '02/14/2023', 'Melqui', 'Riding with no Tandem', '99', 'Male', 'Erlinda Amparo', 'Katulong', '11111', 'palengke', 'balagtas', 'STAN', 'katrina halili', 'maui taylor', 'dolphi', 'none');

-- --------------------------------------------------------

--
-- Table structure for table `volunteer`
--

CREATE TABLE `volunteer` (
  `volunteerid` varchar(50) NOT NULL,
  `lastname` varchar(250) NOT NULL,
  `firstname` varchar(250) NOT NULL,
  `mi` varchar(250) NOT NULL,
  `gender` varchar(250) NOT NULL,
  `address` varchar(250) NOT NULL,
  `birthdate` varchar(250) NOT NULL,
  `birthplace` varchar(250) NOT NULL,
  `contactno` varchar(250) NOT NULL,
  `contactname` varchar(250) NOT NULL,
  `relationship` varchar(250) NOT NULL,
  `contactaddress` varchar(250) NOT NULL,
  `noofcontact` varchar(250) NOT NULL,
  `remarks` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `volunteer`
--

INSERT INTO `volunteer` (`volunteerid`, `lastname`, `firstname`, `mi`, `gender`, `address`, `birthdate`, `birthplace`, `contactno`, `contactname`, `relationship`, `contactaddress`, `noofcontact`, `remarks`) VALUES
('001', 'Dapula', 'Casshean', 'G', 'Male', 'Caridad Ibaba A.Q.', '02/02/2012', 'Atimonan, Quezon', '5645647321', 'Albert Dapula', 'Father', 'Same as Above', '1325564564', 'ML Pro Player\r\n');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `contact_directory`
--
ALTER TABLE `contact_directory`
  ADD PRIMARY KEY (`contactid`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`empid`);

--
-- Indexes for table `imt`
--
ALTER TABLE `imt`
  ADD PRIMARY KEY (`imtid`);

--
-- Indexes for table `incident_report`
--
ALTER TABLE `incident_report`
  ADD PRIMARY KEY (`irid`);

--
-- Indexes for table `regular_schedule`
--
ALTER TABLE `regular_schedule`
  ADD PRIMARY KEY (`rsid`);

--
-- Indexes for table `transfer_request`
--
ALTER TABLE `transfer_request`
  ADD PRIMARY KEY (`trid`);

--
-- Indexes for table `volunteer`
--
ALTER TABLE `volunteer`
  ADD PRIMARY KEY (`volunteerid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `contact_directory`
--
ALTER TABLE `contact_directory`
  MODIFY `contactid` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `imt`
--
ALTER TABLE `imt`
  MODIFY `imtid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `incident_report`
--
ALTER TABLE `incident_report`
  MODIFY `irid` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `regular_schedule`
--
ALTER TABLE `regular_schedule`
  MODIFY `rsid` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `transfer_request`
--
ALTER TABLE `transfer_request`
  MODIFY `trid` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

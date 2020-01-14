SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;

--
-- Database: `FROTCOM`
--

-- --------------------------------------------------------

--
-- Table structure for table `Customer`
--

CREATE TABLE `Customer` (
  `CustomerID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `GPS`
--

CREATE TABLE `GPS` (
  `GPSID` int(11) NOT NULL,
  `Latitude` double NOT NULL,
  `Longitude` double NOT NULL,
  `SensorsID` int(11) NOT NULL,
  `Timestamp` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Sensors`
--

CREATE TABLE `Sensors` (
  `SensorID` int(11) NOT NULL,
  `Speed` double NOT NULL,
  `Heading` varchar(5) NOT NULL,
  `IgnitionStatus` tinyint(1) NOT NULL,
  `Temperature` double DEFAULT NULL,
  `DoorStatus` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Vehicle`
--

CREATE TABLE `Vehicle` (
  `VehicleID` int(11) NOT NULL,
  `GPSID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes
--

--
-- Indexes for table `Customer`
--
ALTER TABLE `Customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `GPS`
--
ALTER TABLE `GPS`
  ADD PRIMARY KEY (`GPSID`),
  ADD KEY `GPSSensor` (`SensorsID`);

--
-- Indexes for table `Sensors`
--
ALTER TABLE `Sensors`
  ADD PRIMARY KEY (`SensorID`);

--
-- Indexes for table `Vehicle`
--
ALTER TABLE `Vehicle`
  ADD PRIMARY KEY (`VehicleID`),
  ADD KEY `VehicleCustomer` (`CustomerID`);

--
-- AUTO_INCREMENT
--

--
-- AUTO_INCREMENT for table `Customer`
--
ALTER TABLE `Customer`
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `Sensors`
--
ALTER TABLE `Sensors`
  MODIFY `SensorID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `Vehicle`
--
ALTER TABLE `Vehicle`
  MODIFY `VehicleID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints
--

--
-- Constraints for table `GPS`
--
ALTER TABLE `GPS`
  ADD CONSTRAINT `GPSSensor` FOREIGN KEY (`SensorsID`) REFERENCES `Sensors` (`SensorID`) ON UPDATE CASCADE;

--
-- Constraints for table `Vehicle`
--
ALTER TABLE `Vehicle`
  ADD CONSTRAINT `VehicleCustomer` FOREIGN KEY (`CustomerID`) REFERENCES `Customer` (`CustomerID`) ON UPDATE CASCADE;
COMMIT;

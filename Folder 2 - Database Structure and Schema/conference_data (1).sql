-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 09, 2023 at 01:48 AM
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
-- Database: `conference_data`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendees_info`
--

CREATE TABLE `attendees_info` (
  `AttendeeID` int(11) NOT NULL,
  `typeAttendees` varchar(55) NOT NULL,
  `orgName` varchar(55) NOT NULL,
  `affiliation` varchar(55) NOT NULL,
  `contactnum` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `attendees_info`
--

INSERT INTO `attendees_info` (`AttendeeID`, `typeAttendees`, `orgName`, `affiliation`, `contactnum`) VALUES
(1, 'Students', 'College of Informatics and Computing Sciences', '09266281272', 'cics@gmail.com'),
(2, 'Officers', 'Junior Philippine Computer Society', '09123172618', 'jpcs@gmail.com'),
(3, 'Barangay Officials', 'Municipality of Calamba', '09457823896', 'calamba@gmail.com'),
(4, 'Officers', 'Tech Innovators Society', '0998235281232', 'techis@gmail.com'),
(5, 'Researchers', 'Batangas State University', '09489123561', 'bsu@gmail.com'),
(6, 'Government Representatives', 'Municipality of Lipa City ', '09125372819', 'lipacity@gmail.com'),
(7, 'Educators', 'Batangas State University', '09976546884', 'bsu@gmail.com'),
(8, 'Entrepreneurs', 'Batangas Entrepreneurs Association', '09876543210', 'batangasentrepreneurs@gmail.com'),
(9, 'Developers', 'Code Masters Guild', '09765432109', 'codemasters@gmail.com'),
(10, 'IT Professionals', 'Information Technology Association of the Philippines', '09123456789', 'itap@gmail.com'),
(11, 'Government Representatives', 'Government Office for Innovation', ' 09152684523', 'govrep@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `register_info`
--

CREATE TABLE `register_info` (
  `User_ID` int(11) NOT NULL,
  `Lname` varchar(255) NOT NULL,
  `Fname` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `emailadd` varchar(255) NOT NULL,
  `contactnum` varchar(11) NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `register_info`
--

INSERT INTO `register_info` (`User_ID`, `Lname`, `Fname`, `address`, `emailadd`, `contactnum`, `username`, `password`) VALUES
(1, 'Virtucio', 'Glycel', 'Lalayat, San Jose Batangas', 'glycel.virtucio@gmail.com', '09171234567', 'glycel_virtucio', '123'),
(2, 'Paragas', 'Kylla', 'Lawa, Calamba Laguna		', 'kylla.paragas@gmail.com', '09987654321', 'kylla_paragas', '456'),
(3, 'Atienza', 'Reziel', '123 Main Street, Barangay San Juan, Makati City, Metro Manila		', 'reziel.atienza@gmail.com', '09205557890', 'reziel_atienza', '789'),
(4, 'Macapagal', 'Rick', 'Block 45, Lot 8, Phase 2, Villa Antonio Subdivision, Bacoor, Cavite		', 'rick.macapagal@gmail.com', '09323210987', 'rick_macapagal', '1011'),
(5, 'Jose', 'Princess', 'Purok 4, Brgy. Dalakit, Tagbilaran City, Bohol', 'princess.jose@gmail.com', '09778885544', 'princess_jose', '1213'),
(6, 'Mendoza', 'Janelle', 'Alitagtag, Batangas', 'janelleM@gmail.com', '09075642135', 'janelle_mendoza', '1415');

-- --------------------------------------------------------

--
-- Table structure for table `schedules_info`
--

CREATE TABLE `schedules_info` (
  `scheduleID` int(11) NOT NULL,
  `User_ID` int(11) DEFAULT 0,
  `SessionID` int(11) DEFAULT 0,
  `session_name` varchar(255) NOT NULL,
  `venueName` text NOT NULL,
  `conferenceStatus` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `schedules_info`
--

INSERT INTO `schedules_info` (`scheduleID`, `User_ID`, `SessionID`, `session_name`, `venueName`, `conferenceStatus`) VALUES
(1, 1, 1, 'Navigating Future Horizons: A Student\'s Odyssey in Informatics', ' Multimedia Room ', 'Done'),
(2, 1, 2, 'Tech Leadership Unveiled: Insights from JPCS Officers', ' Multimedia Room ', 'Pending'),
(3, 2, 3, 'Empowering Communities: Insights from the Municipality of San Jose', 'Municipality of Calamba Barangay Hall', 'Pending'),
(4, 2, 4, 'Innovation Hub: A Glimpse into the Tech Innovators Society', ' Multimedia Room ', 'Pending'),
(5, 3, 5, 'Frontiers of Knowledge: Research Insights from Batangas State University', ' Multimedia Room ', 'Pending'),
(6, 3, 6, 'Strategic Governance: Perspectives from the Municipality of Lipa City', 'Lipa City Municipal Hall', 'Pending'),
(7, 4, 7, 'Elevating Education: Insights from Batangas State University Educators', 'Batangas State University Main Campus', 'Done'),
(8, 4, 8, 'Business Innovation Summit', 'Batangas Entrepreneurs Association Office', 'Done'),
(9, 5, 9, 'Code Fest 2023', 'Code Masters Guild Tech Hub', 'Pending'),
(10, 5, 10, 'IT Symposium: Navigating the Digital Landscape', 'Information Technology Association of the Philippines Convention Center', 'Pending'),
(11, 6, 11, 'International Innovation Summit for Government Transformation', 'Innovation Hub Conference Center', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `sessions_info`
--

CREATE TABLE `sessions_info` (
  `SessionID` int(11) NOT NULL,
  `title` text NOT NULL,
  `description` text NOT NULL,
  `dateAndtime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sessions_info`
--

INSERT INTO `sessions_info` (`SessionID`, `title`, `description`, `dateAndtime`) VALUES
(1, 'Navigating Future Horizons: A Student\'s Odyssey in Informatics', 'Dive into the dynamic world of informatics and computing sciences with the College of Informatics and Computing Sciences. This session is tailored for students eager to explore the latest trends, opportunities, and career pathways in the ever-evolving tech landscape. Engage in interactive discussions, gain insights from industry experts, and discover the keys to success in the digital age.', '2023-11-30 11:59:49'),
(2, 'Tech Leadership Unveiled: Insights from JPCS Officers', 'Dive into the dynamic world of informatics and computing sciences with the College of Informatics and Computing Sciences. This session is tailored for students eager to explore the latest trends, opportunities, and career pathways in the ever-evolving tech landscape. Engage in interactive discussions, gain insights from industry experts, and discover the keys to success in the digital age.', '2023-11-26 14:31:51'),
(3, 'Empowering Communities: Insights from the Municipality of Calamba', 'Explore the role of local governance in community empowerment with representatives from the Municipality of San Jose. Barangay officials will share their initiatives, challenges, and success stories in fostering development and well-being at the grassroots level. Gain a deeper understanding of the vital connection between local governance and community flourishing.', '2023-11-27 14:57:07'),
(4, 'Innovation Hub: A Glimpse into the Tech Innovators Society', 'Embark on a journey through the realm of technology innovation with the Tech Innovators Society. This session, led by officers of the society, unveils the secrets behind fostering a culture of creativity, problem-solving, and groundbreaking ideas. Whether you\'re an entrepreneur, developer, or tech enthusiast, discover the keys to driving innovation in the ever-evolving tech landscape.', '2023-11-28 15:02:32'),
(5, 'Frontiers of Knowledge: Research Insights from Batangas State University', 'Join researchers from Batangas State University for an enriching session on the latest advancements in various fields. From cutting-edge technology to groundbreaking discoveries, this session provides a platform for researchers to share insights, exchange ideas, and inspire the pursuit of knowledge. Uncover the frontiers of research and innovation at Batangas State University.', '2024-01-18 15:07:24'),
(6, 'Strategic Governance: Perspectives from the Municipality of Lipa City', 'Gain a deeper understanding of strategic governance with representatives from the Municipality of Lipa City. Government representatives will share insights into policy-making, community engagement, and sustainable development. Whether you\'re a policymaker, civic leader, or community advocate, this session offers valuable perspectives on effective governance for positive societal impact.', '2023-12-17 15:11:05'),
(7, 'Elevating Education: Insights from Batangas State University Educators', 'Delve into the world of academia with educators from Batangas State University. This session explores innovative teaching methodologies, challenges in education, and the evolving role of educators in shaping the next generation. Whether you\'re a fellow educator or a student, join us for an insightful discussion on the transformative power of education.', '2024-02-26 15:14:37'),
(8, 'Business Innovation Summit', 'Join us at the Business Innovation Summit, organized in collaboration with the Batangas Entrepreneurs Association. This event is tailored for Entrepreneurs looking to explore innovative strategies, network with industry experts, and gain insights into the latest trends in business development.', '2023-12-29 15:19:20'),
(9, 'Code Fest 2023', 'Code Masters Guild invites Developers from all over to participate in Code Fest 2023! This event is a celebration of coding excellence, providing a platform for developers to showcase their skills, learn from peers, and engage in discussions about the latest advancements in the world of programming.', '2024-01-05 15:28:11'),
(10, 'IT Symposium: Navigating the Digital Landscape', 'The Information Technology Association of the Philippines (ITAP) presents the IT Symposium, a gathering of IT Professionals to delve into discussions on navigating the ever-evolving digital landscape. Join us for insightful sessions, collaborative networking, and the opportunity to stay at the forefront of technological advancements.', '2024-02-14 15:33:09'),
(11, 'International Innovation Summit for Government Transformation', 'Join us for a thought-provoking Government Leadership Forum designed Exclusively for government representatives. This forum is a unique opportunity for leaders in public service to engage in a meaningful dialogue on innovation and transformation. Explore gorundbreaking stratgeies, share success stories, and collaborate with peers to drive positive change in governance.', '2023-12-15 19:41:30');

-- --------------------------------------------------------

--
-- Table structure for table `speakers_info`
--

CREATE TABLE `speakers_info` (
  `SpeakerID` int(11) NOT NULL,
  `LNspeaker` varchar(55) NOT NULL,
  `FNspeaker` varchar(55) NOT NULL,
  `Contactspeaker` text NOT NULL,
  `Emailspeaker` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `speakers_info`
--

INSERT INTO `speakers_info` (`SpeakerID`, `LNspeaker`, `FNspeaker`, `Contactspeaker`, `Emailspeaker`) VALUES
(1, 'Chen', 'Sophia', '09333334455', 'chen_12@gmail.com'),
(2, 'Dabis', 'Olivia', '09349991122', 'dabis.olivia@gmail.com'),
(3, 'Williams', 'Daniel', '09765553322', 'daniel_80@gmail.com'),
(4, 'Johnson', 'Emily', '09974445566', 'emily123@gmail.com'),
(5, 'Brown', 'Isabella', '09052228899', 'isabella.brown@gmail.com'),
(6, 'Smith', 'John', '09181112233', 'john_smith@gmail.com'),
(7, 'Nguyen', 'Marcus', '09566667788', 'marcus@gmail.com'),
(8, 'Rodriguez', 'Miguel', '09218887766', 'miguel34@gmail.com'),
(9, 'Santos', 'Rafael', '09237776655', 'rafael45@gmail.com'),
(10, 'Patel', 'Zoe', '09651113344', 'zoepatel@gmail.com'),
(11, 'Barro', 'Andrew', '09652732114', 'andrewbarro@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `sponsor_info`
--

CREATE TABLE `sponsor_info` (
  `sponsorID` int(11) NOT NULL,
  `LastName` varchar(55) NOT NULL,
  `FirstName` varchar(55) NOT NULL,
  `emailAddress` text NOT NULL,
  `contactnum` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sponsor_info`
--

INSERT INTO `sponsor_info` (`sponsorID`, `LastName`, `FirstName`, `emailAddress`, `contactnum`) VALUES
(1, 'Rodriguez', 'Sofia', 'Email Address :', '987 123 4567'),
(2, 'Chang', 'Kevin', 'Email Address :', '09152345678'),
(3, 'Patel', 'Aisha', 'Email Address :', '09263456789'),
(4, 'Nguyen', 'Quan', 'Email Address :', '09384567890'),
(5, 'Garcia', 'Mateo', 'Email Address :', '09175678901'),
(6, 'Kim', 'Ji-Yeon', 'Email Address :', '09206789012'),
(7, 'Almeida', 'Ricardo', 'Email Address :', '09327890123'),
(8, 'Smith', 'Emma', 'Email Address :', '09458901234'),
(9, 'Das', 'Ananya', 'Email Address :', '09509012345'),
(10, 'O\'Connor', 'Liam', 'Email Address :', '09640123456'),
(11, 'O\'Connor ', 'Liam', 'Email Address :', '09640123456');

-- --------------------------------------------------------

--
-- Table structure for table `venue_info`
--

CREATE TABLE `venue_info` (
  `venueName` varchar(55) NOT NULL,
  `location` text NOT NULL,
  `capacity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `venue_info`
--

INSERT INTO `venue_info` (`venueName`, `location`, `capacity`) VALUES
(' Multimedia Room ', 'Batngas State University Lipa Campus', 50),
(' Multimedia Room ', 'Batngas State University Lipa Campus', 20),
('Municipality of Calamba Barangay Hall', 'Calamba Laguna', 15),
(' Multimedia Room ', 'Batangas State University Lipa Campus', 15),
(' Multimedia Room ', 'Batangas State University Lipa Campus', 50),
('Lipa City Municipal Hall', 'Lipa City, Batangas', 20),
('Batangas State University Main Campus', 'Batangas City, Batangas', 100),
('Batangas Entrepreneurs Association Office', 'Batangas City, Batangas', 45),
('Code Masters Guild Tech Hub', 'Taguig City, Metro Manila', 30),
('Information Technology Association of the Philippines C', 'Pasig City, Metro Manila', 60),
('Innovation Hub Conference Center', '123 Tech Avenue, Cityville, Country', 120);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendees_info`
--
ALTER TABLE `attendees_info`
  ADD PRIMARY KEY (`AttendeeID`);

--
-- Indexes for table `register_info`
--
ALTER TABLE `register_info`
  ADD PRIMARY KEY (`User_ID`),
  ADD UNIQUE KEY `contactnum` (`contactnum`);

--
-- Indexes for table `schedules_info`
--
ALTER TABLE `schedules_info`
  ADD PRIMARY KEY (`scheduleID`),
  ADD KEY `SessionID` (`SessionID`),
  ADD KEY `User_ID` (`User_ID`);

--
-- Indexes for table `sessions_info`
--
ALTER TABLE `sessions_info`
  ADD PRIMARY KEY (`SessionID`);

--
-- Indexes for table `speakers_info`
--
ALTER TABLE `speakers_info`
  ADD PRIMARY KEY (`SpeakerID`),
  ADD UNIQUE KEY `Emailspeaker` (`Emailspeaker`);

--
-- Indexes for table `sponsor_info`
--
ALTER TABLE `sponsor_info`
  ADD PRIMARY KEY (`sponsorID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendees_info`
--
ALTER TABLE `attendees_info`
  MODIFY `AttendeeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `register_info`
--
ALTER TABLE `register_info`
  MODIFY `User_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `schedules_info`
--
ALTER TABLE `schedules_info`
  MODIFY `scheduleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `sessions_info`
--
ALTER TABLE `sessions_info`
  MODIFY `SessionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `speakers_info`
--
ALTER TABLE `speakers_info`
  MODIFY `SpeakerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `sponsor_info`
--
ALTER TABLE `sponsor_info`
  MODIFY `sponsorID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `schedules_info`
--
ALTER TABLE `schedules_info`
  ADD CONSTRAINT `schedules_info_ibfk_2` FOREIGN KEY (`SessionID`) REFERENCES `sessions_info` (`SessionID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `schedules_info_ibfk_3` FOREIGN KEY (`User_ID`) REFERENCES `register_info` (`User_ID`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

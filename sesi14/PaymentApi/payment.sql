-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: sql6.freemysqlhosting.net
-- Generation Time: Mar 31, 2022 at 06:38 AM
-- Server version: 5.5.62-0ubuntu0.14.04.1
-- PHP Version: 7.0.33-0ubuntu0.16.04.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sql6482495`
--

-- --------------------------------------------------------

--
-- Table structure for table `AspNetRoleClaims`
--

CREATE TABLE `AspNetRoleClaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(767) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetRoles`
--

CREATE TABLE `AspNetRoles` (
  `Id` varchar(767) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserClaims`
--

CREATE TABLE `AspNetUserClaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(767) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserLogins`
--

CREATE TABLE `AspNetUserLogins` (
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
  `ProviderDisplayName` text,
  `UserId` varchar(767) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserRoles`
--

CREATE TABLE `AspNetUserRoles` (
  `UserId` varchar(767) NOT NULL,
  `RoleId` varchar(767) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUsers`
--

CREATE TABLE `AspNetUsers` (
  `Id` varchar(767) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` text,
  `SecurityStamp` text,
  `ConcurrencyStamp` text,
  `PhoneNumber` text,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `AspNetUsers`
--

INSERT INTO `AspNetUsers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('22a6600e-039d-4b8f-9512-bb6350f4d191', 'FarhanEkaFajri', 'FARHANEKAFAJRI', 'farhanekafajri@example.com', 'FARHANEKAFAJRI@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAEAxzj5z6Zaw2iQoVk0praqTJHMNcepECQ2rK1Up67sBvaZlc++Itm0yhnP1zhvi5Jw==', 'GFOBF6TV4AZKACO23DN2GRQXSQ747VGU', '1fde68b8-e398-47c5-b96f-174b77d33abb', NULL, 0, 0, NULL, 1, 0),
('280a9378-9de8-4254-ad27-78d4abd76b83', 'string', 'STRING', 'user@example.com', 'USER@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAECYmWXB0gD2SALDJIg7Ux/ZN1KeM08C1kzuT66mlhiL+vVOEs7+NsvAK840xyBsneA==', 'YYW3EGI3AQS6YBMLDEL26OVNRKQWP3XV', '0ea0ad0c-5371-484b-9236-241453ef7531', NULL, 0, 0, NULL, 1, 0),
('32edd639-bdad-47e9-8475-c34357de23b8', 'farhans', 'FARHANS', 'farhans@example.com', 'FARHANS@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAEAjApyiJC5eEkszc+kh/mq6vN/7To7jDko0kG0avDHawE9+jaX9VI1902P6+00PBfQ==', '6BB7ZOLWDDLAC42SILFT36IOI67M4Z4C', '04000b0b-6a11-4c60-8df9-93fdf5efe6da', NULL, 0, 0, NULL, 1, 0),
('a9ef13a0-0083-41ad-85be-deb7085ff687', 'a', 'A', 'a@example.com', 'A@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAEBDrMXak4a0TH/5gGLm7+ZTpf3hrpb/ZWI20G9MvHln1NRoaAqOO+GRGhSHIresjgw==', '2MLYXJAGICBYJ4GGT55U7C7NR3VCOAFV', '8a7bcfd2-81c6-4d51-a93f-18c71bf445f3', NULL, 0, 0, NULL, 1, 0),
('f6ced6d7-2f3b-4db6-853b-85260889f0bd', 'Farhan', 'FARHAN', 'Farhan@example.com', 'FARHAN@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAED2liglvakwmGL98jueri8wCA2316ncsjelUsOolanixlhaBuT6yg/RTgqrNmxfcow==', '75T4IM63WBY2RHD4E5VNGBQKBXLNW2EB', '01594f60-3ab9-439b-8175-9303c8ff75ee', NULL, 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserTokens`
--

CREATE TABLE `AspNetUserTokens` (
  `UserId` varchar(767) NOT NULL,
  `LoginProvider` varchar(128) NOT NULL,
  `Name` varchar(128) NOT NULL,
  `Value` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Items`
--

CREATE TABLE `Items` (
  `Id` int(11) NOT NULL,
  `cardOwnerName` text,
  `cardNumber` text,
  `expirationDate` text,
  `securityCode` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Items`
--

INSERT INTO `Items` (`Id`, `cardOwnerName`, `cardNumber`, `expirationDate`, `securityCode`) VALUES
(1, 'Andi', '223456', '2030', 'satu'),
(2, 'Anda', '323456', '2030', 'dua'),
(3, 'Andu', '123456', '2030', 'tiga');

-- --------------------------------------------------------

--
-- Table structure for table `RefreshTokens`
--

CREATE TABLE `RefreshTokens` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(767) DEFAULT NULL,
  `Token` text,
  `JwtId` text,
  `IsUsed` tinyint(1) NOT NULL,
  `IsRevorked` tinyint(1) NOT NULL,
  `AddedDate` datetime NOT NULL,
  `ExpiryDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `RefreshTokens`
--

INSERT INTO `RefreshTokens` (`Id`, `UserId`, `Token`, `JwtId`, `IsUsed`, `IsRevorked`, `AddedDate`, `ExpiryDate`) VALUES
(1, '280a9378-9de8-4254-ad27-78d4abd76b83', 'ORVJ74FUG4G9ONABRYA8TIJRPI61S0PYUF72680bc8e-2600-4059-96ae-6b4929d2866a', '9b51e333-bead-4bee-9f67-728bd0d26155', 0, 0, '2022-03-30 09:03:04', '2022-09-30 09:03:04'),
(2, '280a9378-9de8-4254-ad27-78d4abd76b83', 'M0K63OL4T3M0L1GZCTORUCN76NN19ICLJ0X25a2784a-dc9d-4126-b5e1-b396edbedab2', '292203de-4427-4b76-aa4e-d5bd88e17dc3', 0, 0, '2022-03-30 09:38:39', '2022-09-30 09:38:39'),
(3, 'f6ced6d7-2f3b-4db6-853b-85260889f0bd', 'D36CQM1RIXDHDCOYGLPT4CW9I6AOD9G00P90ce1d0f9-5805-4061-9d69-b29cf384e6b8', 'a0f321a9-4329-479c-ba11-8636a6690388', 0, 0, '2022-03-30 09:40:27', '2022-09-30 09:40:27'),
(4, '280a9378-9de8-4254-ad27-78d4abd76b83', 'LE4RNRJWGAZVP1V4HJRBMWNUFUYPNJ0N8VZ67ed7fc8-3863-4892-9cbf-d042b1b1aeda', 'bf394347-720a-490f-ba84-47edc6ec9e57', 0, 0, '2022-03-30 22:57:16', '2022-09-30 22:57:16'),
(5, '280a9378-9de8-4254-ad27-78d4abd76b83', 'S4PH8YHT67MVAZA0L8LOQSGWI3C67BCW48Lb7c4280e-cef7-41b7-830a-42af97364bd2', 'ed6dd716-ba55-4085-91a5-a66a315a2378', 0, 0, '2022-03-30 23:08:51', '2022-09-30 23:08:51'),
(6, 'a9ef13a0-0083-41ad-85be-deb7085ff687', '7AZXZF4NNSAPTA1YWVBJCABHHCN9CN2T17Gbd425f64-525a-4b49-8910-14ecb126b960', '6b24e628-2f13-4f66-9325-637e2b813207', 0, 0, '2022-03-31 01:40:19', '2022-09-30 01:40:19'),
(7, 'a9ef13a0-0083-41ad-85be-deb7085ff687', '2EYZWN67FYF45HTGWP1YBKQFAVT3OZRCXTJ2d62c187-e785-4bf2-8fc0-3d0c5403e52f', '76300b41-bcf4-4527-b713-07dd6f603749', 0, 0, '2022-03-31 01:41:07', '2022-09-30 01:41:07'),
(8, 'a9ef13a0-0083-41ad-85be-deb7085ff687', 'YWQR17ENR5XXHWZUY0ATSN2LH8T2VB1VJ5N2036e376-7676-40cc-b746-d0e5974d3661', '950090f2-cb6d-4c14-8be7-648e78100e14', 0, 0, '2022-03-31 01:47:19', '2022-09-30 01:47:19'),
(9, '22a6600e-039d-4b8f-9512-bb6350f4d191', 'MD8INFEX4WTFX51RGA78JRKH92LHKCBFJWT8b9cd64f-ee24-4977-9d3f-69ec7a2c92e8', 'e69e34f8-a930-4341-98fa-4f33e6253272', 0, 0, '2022-03-31 02:28:06', '2022-09-30 02:28:06'),
(10, '22a6600e-039d-4b8f-9512-bb6350f4d191', 'N9JIT9PBQOY4G4O8IPRRX9002BXL6DH8GR4390d95c9-3b1c-4f93-a7f7-7359edb73663', '5d70429f-3e0b-451f-903c-99dad8485dcb', 0, 0, '2022-03-31 02:29:49', '2022-09-30 02:29:49'),
(11, '280a9378-9de8-4254-ad27-78d4abd76b83', '78SERTKCV7916YPGT1U81QN4KDO043NTFQX5749ecb2-af70-43da-8208-20be5973914d', '366a883d-4a5f-4785-ad65-d68172437a31', 0, 0, '2022-03-31 03:25:48', '2022-09-30 03:25:48'),
(12, '22a6600e-039d-4b8f-9512-bb6350f4d191', 'T2BJ5JMOUMJW4OI46OXGOLL9NOP2HBLEZKZ33d8a6e0-ac7f-429b-b0fa-bf7fb9b4948a', '101c4817-6f5e-4b20-a3b0-ebfa1fb6d414', 0, 0, '2022-03-31 04:26:28', '2022-09-30 04:26:28'),
(13, '22a6600e-039d-4b8f-9512-bb6350f4d191', 'U54MJ2WV9JMJNIQGZL3AZ5C2P6XNLKWF0O0c184b93e-7ae7-44f7-9d4e-1f36ade335e8', '58f059c2-6975-4bec-89c4-93bc8e4b80a1', 0, 0, '2022-03-31 05:56:14', '2022-09-30 05:56:14'),
(14, '32edd639-bdad-47e9-8475-c34357de23b8', 'GBFG5TV6I0CGLHTUDFGJC180IT8JWDH0AAC3cf2e20b-a5a9-4d3f-a5f5-a853c731669d', '8343433a-ca96-45ed-bca7-7c57dfffb931', 0, 0, '2022-03-31 05:57:12', '2022-09-30 05:57:12');

-- --------------------------------------------------------

--
-- Table structure for table `__EFMigrationsHistory`
--

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `__EFMigrationsHistory`
--

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`) VALUES
('20220330064925_initial migrations', '5.0.15'),
('20220330074706_initial migrations online', '5.0.15');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indexes for table `AspNetRoles`
--
ALTER TABLE `AspNetRoles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indexes for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indexes for table `AspNetUserLogins`
--
ALTER TABLE `AspNetUserLogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indexes for table `AspNetUserRoles`
--
ALTER TABLE `AspNetUserRoles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indexes for table `AspNetUsers`
--
ALTER TABLE `AspNetUsers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indexes for table `AspNetUserTokens`
--
ALTER TABLE `AspNetUserTokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indexes for table `Items`
--
ALTER TABLE `Items`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_RefreshTokens_UserId` (`UserId`);

--
-- Indexes for table `__EFMigrationsHistory`
--
ALTER TABLE `__EFMigrationsHistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `Items`
--
ALTER TABLE `Items`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserLogins`
--
ALTER TABLE `AspNetUserLogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserRoles`
--
ALTER TABLE `AspNetUserRoles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserTokens`
--
ALTER TABLE `AspNetUserTokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  ADD CONSTRAINT `FK_RefreshTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

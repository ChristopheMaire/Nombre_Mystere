-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  mar. 19 déc. 2017 à 10:35
-- Version du serveur :  5.7.17
-- Version de PHP :  7.1.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bddnbmystere`
--

-- --------------------------------------------------------

--
-- Structure de la table `joueur`
--

CREATE TABLE `joueur` (
  `nom` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `mdp` varchar(15) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `nbcoup` int(5) NOT NULL,
  `nbpartie` int(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `joueur`
--

INSERT INTO `joueur` (`nom`, `mdp`, `nbcoup`, `nbpartie`) VALUES
('Christophe', 'Maire', 6, 2),
('Bob', 'bob1', 0, 0),
('Jean', 'jean', 7, 1),
('Paul', 'paul', 0, 0),
('Pierre', 'pierre', 0, 0),
('toto', 'toto', 4, 1),
('totou', 'totou', 0, 0),
('Dodo', 'popo', 7, 1);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 08-04-2025 a las 01:26:24
-- Versión del servidor: 5.7.36
-- Versión de PHP: 8.1.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bdpersonal`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbingresos`
--

CREATE TABLE `tbingresos` (
  `ID` int(11) NOT NULL,
  `DNI` char(8) DEFAULT NULL,
  `FECHA` date NOT NULL,
  `HORA` time NOT NULL,
  `TARDANZA` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Volcado de datos para la tabla `tbingresos`
--

INSERT INTO `tbingresos` (`ID`, `DNI`, `FECHA`, `HORA`, `TARDANZA`) VALUES
(1, '73332754', '2025-04-06', '00:46:28', '00:00:00'),
(2, '24262728', '2025-04-06', '00:46:50', '00:00:00'),
(3, '12345678', '2025-04-06', '00:47:59', '00:00:00'),
(4, '87654321', '2025-04-06', '00:51:09', '00:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbpersonal`
--

CREATE TABLE `tbpersonal` (
  `DNI` char(8) NOT NULL,
  `NOMBRE` varchar(100) NOT NULL,
  `APELLIDO` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbpersonal`
--

INSERT INTO `tbpersonal` (`DNI`, `NOMBRE`, `APELLIDO`) VALUES
('12345678', 'Copilot', 'Microsoft'),
('24262728', 'Juan', 'Gomez'),
('73332754', 'Joao', 'Urteaga'),
('87654321', 'ChatGPT', 'OpenIA');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbingresos`
--
ALTER TABLE `tbingresos`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `DNI` (`DNI`);

--
-- Indices de la tabla `tbpersonal`
--
ALTER TABLE `tbpersonal`
  ADD PRIMARY KEY (`DNI`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbingresos`
--
ALTER TABLE `tbingresos`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbingresos`
--
ALTER TABLE `tbingresos`
  ADD CONSTRAINT `tbingresos_ibfk_1` FOREIGN KEY (`DNI`) REFERENCES `tbpersonal` (`DNI`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

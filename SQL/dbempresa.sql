-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 04-04-2025 a las 03:48:24
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
-- Base de datos: `dbempresa`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbproductos`
--

CREATE TABLE `tbproductos` (
  `ID` int(11) NOT NULL,
  `NOMBRE` varchar(30) DEFAULT NULL,
  `STOCK` int(11) DEFAULT NULL,
  `PCOMPRA` decimal(10,2) DEFAULT NULL,
  `PVENTA` decimal(10,2) DEFAULT NULL,
  `CATEGORIA` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbproductos`
--

INSERT INTO `tbproductos` (`ID`, `NOMBRE`, `STOCK`, `PCOMPRA`, `PVENTA`, `CATEGORIA`) VALUES
(1, 'CUADERNO A4', 100, '10.50', '12.50', '1'),
(2, 'GOMA', 30, '3.50', '6.50', '1'),
(3, 'TIJERA', 20, '10.00', '13.00', '1'),
(4, 'BORRADOR', 40, '4.00', '5.00', '1'),
(5, 'PLUMON', 50, '6.00', '8.00', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbusuarios`
--

CREATE TABLE `tbusuarios` (
  `ID` int(11) NOT NULL,
  `USUARIO` varchar(50) DEFAULT NULL,
  `CLAVE` varchar(50) DEFAULT NULL,
  `ESTADO` char(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbusuarios`
--

INSERT INTO `tbusuarios` (`ID`, `USUARIO`, `CLAVE`, `ESTADO`) VALUES
(1, 'uwu', '123', '0'),
(2, 'Joao', '123', '0'),
(3, 'JOAOTIX', '123', '0');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbproductos`
--
ALTER TABLE `tbproductos`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `tbusuarios`
--
ALTER TABLE `tbusuarios`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbusuarios`
--
ALTER TABLE `tbusuarios`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

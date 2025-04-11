-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 11-04-2025 a las 15:27:55
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
-- Base de datos: `bdplaya`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `boleta_cab`
--

CREATE TABLE `boleta_cab` (
  `id_boleta` int(11) NOT NULL,
  `id_ticket` int(11) NOT NULL,
  `id_serie` int(11) NOT NULL,
  `fecha_emision` datetime NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `numero_boleta` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `boleta_det`
--

CREATE TABLE `boleta_det` (
  `id_detalle` int(11) NOT NULL,
  `id_boleta` int(11) NOT NULL,
  `dni_cliente` varchar(15) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio_unitario` decimal(10,2) DEFAULT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL,
  `igv` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `boleta_serie`
--

CREATE TABLE `boleta_serie` (
  `id_serie` int(11) NOT NULL,
  `serie` varchar(5) NOT NULL,
  `cantidad_emitida` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `boleta_serie`
--

INSERT INTO `boleta_serie` (`id_serie`, `serie`, `cantidad_emitida`) VALUES
(1, 'B001', 0),
(2, 'F001', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `dni` varchar(15) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tickets`
--

CREATE TABLE `tickets` (
  `id_ticket` int(11) NOT NULL,
  `placa` varchar(15) NOT NULL,
  `fecha_ingreso` date NOT NULL,
  `fecha_salida` date DEFAULT NULL,
  `hora_ingreso` time NOT NULL,
  `hora_salida` time DEFAULT NULL,
  `minutos` time DEFAULT NULL,
  `pagado` tinyint(1) DEFAULT '0',
  `dni_clientes` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Volcado de datos para la tabla `tickets`
--

INSERT INTO `tickets` (`id_ticket`, `placa`, `fecha_ingreso`, `fecha_salida`, `hora_ingreso`, `hora_salida`, `minutos`, `pagado`, `dni_clientes`) VALUES
(8, '67', '2025-04-11', '2025-04-11', '10:21:03', '10:23:24', '00:02:21', 2, '25152');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id_user` int(11) NOT NULL,
  `user` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id_user`, `user`, `password`) VALUES
(1, 'Joao', '123'),
(4, 'Admi', '123');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `boleta_cab`
--
ALTER TABLE `boleta_cab`
  ADD PRIMARY KEY (`id_boleta`),
  ADD KEY `id_ticket` (`id_ticket`),
  ADD KEY `id_serie` (`id_serie`);

--
-- Indices de la tabla `boleta_det`
--
ALTER TABLE `boleta_det`
  ADD PRIMARY KEY (`id_detalle`),
  ADD KEY `id_boleta` (`id_boleta`),
  ADD KEY `dni_cliente` (`dni_cliente`);

--
-- Indices de la tabla `boleta_serie`
--
ALTER TABLE `boleta_serie`
  ADD PRIMARY KEY (`id_serie`),
  ADD UNIQUE KEY `serie` (`serie`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`dni`);

--
-- Indices de la tabla `tickets`
--
ALTER TABLE `tickets`
  ADD PRIMARY KEY (`id_ticket`),
  ADD KEY `fk_dni_clientes` (`dni_clientes`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_user`),
  ADD UNIQUE KEY `user` (`user`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `boleta_cab`
--
ALTER TABLE `boleta_cab`
  MODIFY `id_boleta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `boleta_det`
--
ALTER TABLE `boleta_det`
  MODIFY `id_detalle` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `boleta_serie`
--
ALTER TABLE `boleta_serie`
  MODIFY `id_serie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tickets`
--
ALTER TABLE `tickets`
  MODIFY `id_ticket` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `boleta_cab`
--
ALTER TABLE `boleta_cab`
  ADD CONSTRAINT `boleta_cab_ibfk_1` FOREIGN KEY (`id_ticket`) REFERENCES `tickets` (`id_ticket`),
  ADD CONSTRAINT `boleta_cab_ibfk_2` FOREIGN KEY (`id_serie`) REFERENCES `boleta_serie` (`id_serie`);

--
-- Filtros para la tabla `boleta_det`
--
ALTER TABLE `boleta_det`
  ADD CONSTRAINT `boleta_det_ibfk_1` FOREIGN KEY (`id_boleta`) REFERENCES `boleta_cab` (`id_boleta`),
  ADD CONSTRAINT `boleta_det_ibfk_2` FOREIGN KEY (`dni_cliente`) REFERENCES `clientes` (`dni`);

--
-- Filtros para la tabla `tickets`
--
ALTER TABLE `tickets`
  ADD CONSTRAINT `fk_dni_clientes` FOREIGN KEY (`dni_clientes`) REFERENCES `clientes` (`dni`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

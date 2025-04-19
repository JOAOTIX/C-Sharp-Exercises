-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 19-04-2025 a las 02:19:21
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
-- Base de datos: `bdpizzeria`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `boleta_cab`
--

CREATE TABLE `boleta_cab` (
  `NumBol` varchar(10) NOT NULL,
  `Fecha` datetime NOT NULL,
  `DNIcli` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `Igv` decimal(10,2) NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  `Estado` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `boleta_cab`
--

INSERT INTO `boleta_cab` (`NumBol`, `Fecha`, `DNIcli`, `Igv`, `Total`, `Estado`) VALUES
('B001-0004', '2025-03-30 00:00:00', '73332754', '9.72', '63.72', 1),
('B001-0005', '2025-03-30 00:00:00', '2324', '9.72', '63.72', 1),
('B001-0006', '2025-03-30 00:00:00', '2324', '9.72', '63.72', 1),
('B001-0007', '2025-03-30 00:00:00', '12345678', '9.00', '59.00', 1),
('B001-0008', '2025-03-30 00:00:00', '71737475', '45.00', '295.00', 1),
('B001-0009', '2025-03-30 00:00:00', '202526', '90.00', '590.00', 1),
('B001-0011', '2025-04-18 18:08:35', '2', '9.00', '59.00', 1),
('B001-0012', '2025-04-18 18:10:08', '20', '45.00', '295.00', 1),
('B001-0013', '2025-04-18 19:08:32', '12', '360.00', '2360.00', 1),
('B001-0014', '2025-04-18 20:27:30', '2323230', '7.20', '47.20', 0),
('F001-0002', '2025-03-30 00:00:00', '2122', '4.50', '29.50', 1),
('F001-0003', '2025-03-30 00:00:00', '2025', '7.20', '47.20', 1),
('F001-0005', '2025-04-18 18:09:19', '10', '18.00', '118.00', 1),
('F001-0006', '2025-04-18 18:10:15', '1010', '90.00', '590.00', 1),
('F001-0007', '2025-04-18 19:18:51', '2', '3600.00', '23600.00', 0),
('F001-0008', '2025-04-18 19:31:45', '232323232', '4432431.60', '29057051.60', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `boleta_det`
--

CREATE TABLE `boleta_det` (
  `NumBol` varchar(10) NOT NULL,
  `CodProd` int(10) NOT NULL,
  `Cant` int(11) NOT NULL,
  `Punt` decimal(10,2) NOT NULL,
  `Importe` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `boleta_det`
--

INSERT INTO `boleta_det` (`NumBol`, `CodProd`, `Cant`, `Punt`, `Importe`) VALUES
('B001-0004', 4, 2, '27.00', '54.00'),
('B001-0005', 4, 2, '27.00', '54.00'),
('B001-0006', 4, 2, '27.00', '54.00'),
('B001-0007', 3, 2, '25.00', '50.00'),
('B001-0008', 3, 10, '25.00', '250.00'),
('B001-0009', 3, 20, '25.00', '500.00'),
('B001-0011', 3, 2, '25.00', '50.00'),
('B001-0012', 3, 10, '25.00', '250.00'),
('B001-0013', 1, 100, '20.00', '2000.00'),
('B001-0014', 1, 2, '20.00', '40.00'),
('F001-0002', 3, 1, '25.00', '25.00'),
('F001-0003', 1, 2, '20.00', '40.00'),
('F001-0005', 1, 5, '20.00', '100.00'),
('F001-0006', 3, 20, '25.00', '500.00'),
('F001-0007', 1, 1000, '20.00', '20000.00'),
('F001-0008', 1, 1231231, '20.00', '24624620.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `customer`
--

CREATE TABLE `customer` (
  `customer_id` int(11) NOT NULL,
  `dni` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `name` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `last_name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci ROW_FORMAT=COMPACT;

--
-- Volcado de datos para la tabla `customer`
--

INSERT INTO `customer` (`customer_id`, `dni`, `name`, `last_name`) VALUES
(12, '73332754', 'JOAO', 'Urteaga Sanchez'),
(13, '2324', 'deku', 'Sanchez'),
(14, '12345678', 'Juan', 'Huaman'),
(15, '2122', 'ACEITE', 'Sanchez'),
(16, '71737475', 'Miguel ', 'Huaman Sanchez'),
(17, '202526', 'Jaimito', 'Perez'),
(18, '2025', 'Julian', 'Alvarez'),
(22, '2024', 'uwu', 'owo'),
(23, '2', 'a', 'e'),
(24, '10', 'aea', 'uwu'),
(25, '20', 'op', 'ap'),
(26, '1010', 'owo', 'uwu'),
(27, '12', 'Redes sociales', 'uwu'),
(28, '02', 'awa', 'ewe'),
(29, '232323232', 'asdasd', 'asdasdas'),
(30, '32323', 'dasdasd', 'asdasd'),
(31, '2323230', 'asda', 'asdas');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `orders`
--

CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT '1',
  `total` decimal(10,2) NOT NULL DEFAULT '0.00',
  `state` tinyint(4) NOT NULL DEFAULT '0',
  `customer_customer_id` int(11) NOT NULL,
  `pizza_pizza_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci ROW_FORMAT=COMPACT;

--
-- Volcado de datos para la tabla `orders`
--

INSERT INTO `orders` (`order_id`, `quantity`, `total`, `state`, `customer_customer_id`, `pizza_pizza_id`) VALUES
(1, 2, '54.00', 3, 12, 4),
(2, 2, '54.00', 3, 13, 4),
(3, 2, '50.00', 3, 14, 3),
(4, 1, '29.00', 3, 12, 5),
(5, 1, '25.00', 3, 15, 3),
(6, 10, '250.00', 3, 16, 3),
(7, 20, '500.00', 3, 17, 3),
(8, 2, '40.00', 3, 18, 1),
(9, 2, '40.00', 3, 22, 1),
(10, 2, '50.00', 3, 23, 3),
(11, 5, '100.00', 3, 24, 1),
(12, 10, '250.00', 3, 25, 3),
(13, 20, '500.00', 3, 26, 3),
(14, 100, '2000.00', 3, 27, 1),
(15, 1000, '20000.00', 3, 28, 1),
(16, 1231231, '24624620.00', 3, 29, 1),
(17, 2, '40.00', 1, 31, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pizza`
--

CREATE TABLE `pizza` (
  `pizza_id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `price` decimal(10,2) NOT NULL DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `pizza`
--

INSERT INTO `pizza` (`pizza_id`, `name`, `price`) VALUES
(1, 'Americana', '20.00'),
(2, 'Peperoni', '24.00'),
(3, 'Hawaina', '25.00'),
(4, 'Full meat', '27.00'),
(5, 'Gourmet', '29.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `serie`
--

CREATE TABLE `serie` (
  `serie_id` int(11) NOT NULL,
  `name` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `serie`
--

INSERT INTO `serie` (`serie_id`, `name`, `quantity`) VALUES
(1, 'B001', 13),
(2, 'F001', 7);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `username` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`user_id`, `username`, `password`) VALUES
(1, 'admi', '123'),
(2, '', ''),
(3, 'Joao', '123'),
(4, 'Tineo', '123'),
(5, 'uwu', '123');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `boleta_cab`
--
ALTER TABLE `boleta_cab`
  ADD PRIMARY KEY (`NumBol`),
  ADD KEY `fk_boleta_cab_cliente` (`DNIcli`);

--
-- Indices de la tabla `boleta_det`
--
ALTER TABLE `boleta_det`
  ADD PRIMARY KEY (`NumBol`) USING BTREE,
  ADD KEY `fk_orden_pizza` (`CodProd`);

--
-- Indices de la tabla `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`customer_id`),
  ADD UNIQUE KEY `dni` (`dni`),
  ADD UNIQUE KEY `unique_dni` (`dni`);

--
-- Indices de la tabla `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `fk_order_customer_idx` (`customer_customer_id`),
  ADD KEY `fk_order_pizza1_idx` (`pizza_pizza_id`);

--
-- Indices de la tabla `pizza`
--
ALTER TABLE `pizza`
  ADD PRIMARY KEY (`pizza_id`);

--
-- Indices de la tabla `serie`
--
ALTER TABLE `serie`
  ADD PRIMARY KEY (`serie_id`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indices de la tabla `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `customer`
--
ALTER TABLE `customer`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT de la tabla `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT de la tabla `pizza`
--
ALTER TABLE `pizza`
  MODIFY `pizza_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `serie`
--
ALTER TABLE `serie`
  MODIFY `serie_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `boleta_cab`
--
ALTER TABLE `boleta_cab`
  ADD CONSTRAINT `fk_boleta_cab_cliente` FOREIGN KEY (`DNIcli`) REFERENCES `customer` (`dni`);

--
-- Filtros para la tabla `boleta_det`
--
ALTER TABLE `boleta_det`
  ADD CONSTRAINT `boleta_det_ibfk_1` FOREIGN KEY (`NumBol`) REFERENCES `boleta_cab` (`NumBol`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_orden_pizza` FOREIGN KEY (`CodProd`) REFERENCES `pizza` (`pizza_id`);

--
-- Filtros para la tabla `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `fk_order_customer` FOREIGN KEY (`customer_customer_id`) REFERENCES `customer` (`customer_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_order_pizza1` FOREIGN KEY (`pizza_pizza_id`) REFERENCES `pizza` (`pizza_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

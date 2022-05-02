Create database 2dam;
USE 2dam;
GRANT ALL PRIVILEGES ON 2dam.* TO 'user';


CREATE TABLE `Alumnos` (
  `idAlumno` int(11) NOT NULL,
  `nombreAlumno` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `saldo` decimal(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `Alumnos`
--

INSERT INTO `Alumnos` (`idAlumno`, `nombreAlumno`, `saldo`) VALUES
(1, 'Juan Gomez Perez', '120.00'),
(2, 'Federico Mocca', '20.00'),
(3, 'Pablo Marmol', '1200.00'),
(4, 'Jose Mota', '200.00'),
(5, 'Pablo Esquilo', '10.00'),
(6, 'Jose Ramon Rojas', '200.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Cursos`
--

CREATE TABLE `Cursos` (
  `idCurso` int(11) NOT NULL,
  `nombreCurso` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `nombreProfesor` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `idioma` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  `costeMinuto` decimal(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `Cursos`
--

INSERT INTO `Cursos` (`idCurso`, `nombreCurso`, `nombreProfesor`, `idioma`, `costeMinuto`) VALUES
(1, 'Ingles nivel 1', 'Pacho Maturana', 'Ingles', '10.00'),
(2, 'Ingles nivel 2', 'Pacho Maturana', 'Ingles', '12.00'),
(3, 'Ingles nivel 3', 'Pacho Maturana', 'Ingles', '14.00'),
(4, 'Ingles nivel 4', 'Pacho Maturana', 'Ingles', '15.00'),
(5, 'Ingles nivel 5', 'Pacho Maturana', 'Ingles', '18.00'),
(6, 'Frances nivel 1', 'Alain Jota', 'Frances', '10.00'),
(7, 'Frances nivel 2', 'Alain Jota', 'Frances', '12.00'),
(8, 'Frances nivel 3', 'Alain Jota', 'Frances', '13.00'),
(9, 'Frances nivel 4', 'Alain Jota', 'Frances', '14.00'),
(10, 'Frances nivel 5', 'Alain Jota', 'Frances', '15.00'),
(11, 'Frances nivel 6', 'Alain Jota', 'Frances', '16.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Inscripciones`
--

CREATE TABLE `Inscripciones` (
  `idCurso` int(11) NOT NULL,
  `idAlumno` int(11) NOT NULL,
  `fechaAlta` date NOT NULL,
  `descuentoPorMinuto` int(2) NOT NULL,
  `minutosCurso` int(11) NOT NULL DEFAULT '10',
  `estado` varchar(10) COLLATE utf8_spanish_ci NOT NULL DEFAULT 'Abierta'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `Inscripciones`
--

INSERT INTO `Inscripciones` (`idCurso`, `idAlumno`, `fechaAlta`, `descuentoPorMinuto`, `minutosCurso`, `estado`) VALUES
(1, 1, '2021-06-19', 10, 10, 'Abierta'),
(1, 2, '2021-06-19', 15, 10, 'Abierta'),
(1, 3, '2021-06-19', 10, 10, 'Abierta'),
(1, 4, '2021-06-19', 10, 10, 'Abierta'),
(1, 5, '2021-06-19', 10, 10, 'Abierta'),
(1, 6, '2021-06-19', 10, 10, 'Abierta'),
(6, 1, '2021-06-19', 10, 10, 'Abierta'),
(6, 2, '2021-06-19', 10, 10, 'Abierta'),
(6, 3, '2021-06-19', 10, 10, 'Abierta');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `Alumnos`
--
ALTER TABLE `Alumnos`
  ADD PRIMARY KEY (`idAlumno`);

--
-- Indices de la tabla `Cursos`
--
ALTER TABLE `Cursos`
  ADD PRIMARY KEY (`idCurso`);

--
-- Indices de la tabla `Inscripciones`
--
ALTER TABLE `Inscripciones`
  ADD PRIMARY KEY (`idCurso`,`idAlumno`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `Alumnos`
--
ALTER TABLE `Alumnos`
  MODIFY `idAlumno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `Cursos`
--
ALTER TABLE `Cursos`
  MODIFY `idCurso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;
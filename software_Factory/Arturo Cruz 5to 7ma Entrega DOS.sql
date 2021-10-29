USE SoftwareFactory;
DELIMITER $$

-- Antes de hacer un Insert en Tarea, si la calificación del empleado es menor a la complejidad del requerimiento no se tiene que permitir el Insert y se tiene que mostrar la leyenda “Calificación insuficiente”.

DROP TRIGGER IF EXISTS befInsTarea $$
CREATE TRIGGER befInsTarea BEFORE INSERT ON tarea
FOR EACH ROW
BEGIN
		if(EXISTS(SELECT * 
				FROM experiencia
                JOIN requerimiento USING (idTecnologia) 
                WHERE calificacion < complejidad 
                AND cuil = new.cuil 
                AND idRequerimiento = new.idRequerimiento)) THEN
			SIGNAL SQLSTATE '45000'
			SET MESSAGE_TEXT = 'Calificacion insuficiente';
        END IF;
END $$

DELIMITER $$

-- Realizar un trigger para que al ingresar un usuario, le asigne por defecto experiencia en todas las tecnologías disponibles con calificación igual a CERO.

DROP TRIGGER IF EXISTS aftInsEmpleado $$
CREATE TRIGGER aftInsEmpleado AFTER INSERT ON empleado
FOR EACH ROW
BEGIN
		INSERT INTO softwarefactory.experiencia(cuil, idTecnologia, calificacion)
								SELECT new.cuil, idTecnologia, 0 
                                FROM softwarefactory.tecnologia;
END $$


DELIMITER $$

-- Procedimiento para dar de alta la tabla tarea

DROP PROCEDURE IF EXISTS altaTarea $$
CREATE PROCEDURE altaTarea (unIdRequerimiento INT, unCuil INT, unInicio DATE, unFin DATE)
BEGIN
		INSERT INTO tarea (idRequerimiento, cuil, inicio, fin)
						VALUES    (unIdRequerimiento, unCuil, unInicio, unFin);
END $$

DELIMITER $$

-- Procedimiento para dar de alta la tabla empleado

DROP PROCEDURE IF EXISTS altaEmpleado $$
CREATE PROCEDURE altaEmpleado (unCuil INT, unNombre VARCHAR(50), unApellido VARCHAR(50), unContratacion DATE)
BEGIN
		INSERT INTO empleado (cuil, nombre, apellido, contratacion)
						VALUES    (unCuil, unNombre, unApellido, unContratacion);
END $$


-- Insert en tarea para probar trigger befInsTarea
CALL altaTarea(1, 1000, '2021-10-06', '2021-12-01');


-- Insert en empleado para probar el trigger aftInsEmpleado
CALL altaEmpleado(1, 'Arturo', 'Cruz', '2021-01-02');


-- Consulta para ver si se asigno calificacion 0 a todas las tecnologias
SELECT *
FROM experiencia
WHERE cuil = 1;
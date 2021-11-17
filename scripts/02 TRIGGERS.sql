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
USE SoftwareFactory;
DROP USER IF EXISTS 'administrador'@'%';
DROP USER IF EXISTS 'pm'@'10.3.45.%';
DROP USER IF EXISTS 'empleado'@'10.3.45.%';

CREATE USER IF NOT EXISTS 'administrador'@'%';
CREATE USER IF NOT EXISTS 'pm'@'10.3.45.%';
CREATE USER IF NOT EXISTS 'empleado'@'10.3.45.%';

-- ADMINISTRADOR

GRANT SELECT ON softwarefactory.tarea TO 'administrador'@'%';
GRANT SELECT ON softwarefactory.experiencia TO 'administrador'@'%';
GRANT SELECT ON softwarefactory.requerimiento TO 'administrador'@'%';
GRANT SELECT, INSERT ON softwarefactory.tecnologia TO 'administrador'@'%';
GRANT SELECT, INSERT ON softwarefactory.cliente TO 'administrador'@'%';
GRANT SELECT, INSERT ON softwarefactory.empleado TO 'administrador'@'%';
GRANT SELECT, INSERT, UPDATE ON softwarefactory.proyecto TO 'administrador'@'%';

-- PM

GRANT SELECT ON softwarefactory.tecnologia TO 'pm'@'10.3.45.%';
GRANT SELECT ON softwarefactory.cliente TO 'pm'@'10.3.45.%';
GRANT SELECT ON softwarefactory.proyecto TO 'pm'@'10.3.45.%';
GRANT SELECT, INSERT ON softwarefactory.requerimiento TO 'pm'@'10.3.45.%';
GRANT SELECT, INSERT ON softwarefactory.empleado TO 'pm'@'10.3.45.%';
GRANT SELECT, INSERT, UPDATE (calificacion) ON softwarefactory.experiencia TO 'pm'@'10.3.45.%';
GRANT SELECT, INSERT, UPDATE (fin) ON softwarefactory.tarea TO 'pm'@'10.3.45.%';

-- EMPLEADO

GRANT SELECT ON softwarefactory.tecnologia TO 'empleado'@'10.3.45.%';
GRANT SELECT ON softwarefactory.cliente TO 'empleado'@'10.3.45.%';
GRANT SELECT ON softwarefactory.empleado TO 'empleado'@'10.3.45.%';
GRANT SELECT ON softwarefactory.tarea TO 'empleado'@'10.3.45.%';
GRANT SELECT ON softwarefactory.experiencia TO 'empleado'@'10.3.45.%';
GRANT SELECT ON softwarefactory.requerimiento TO 'empleado'@'10.3.45.%';
GRANT SELECT ON softwarefactory.proyecto TO 'empleado'@'10.3.45.%';
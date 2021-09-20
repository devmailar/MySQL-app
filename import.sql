CREATE TABLE `data` (
	`id` INT(11) NOT NULL AUTO_INCREMENT,
	`age` INT(11) NOT NULL DEFAULT '0',
	`name` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8mb4_general_ci',
	`author` VARCHAR(50) NULL DEFAULT NULL COLLATE 'utf8mb4_general_ci',
	`admin` VARCHAR(50) NOT NULL DEFAULT 'false' COLLATE 'utf8mb4_general_ci',
	PRIMARY KEY (`id`) USING BTREE
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
AUTO_INCREMENT=21
;

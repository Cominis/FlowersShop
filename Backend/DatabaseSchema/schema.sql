-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
-- -----------------------------------------------------
-- Schema psk
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema psk
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `psk` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `psk`.`Feedback`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `psk`.`Feedback` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `feedback_text` VARCHAR(45) NULL,
  `rating` INT NOT NULL,
  `User_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Feedback_User_idx` (`User_id` ASC) VISIBLE,
  CONSTRAINT `fk_Feedback_User`
    FOREIGN KEY (`User_id`)
    REFERENCES `mydb`.`User` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`User`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`User` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(90) NOT NULL,
  `last_name` VARCHAR(90) NOT NULL,
  `user_name` VARCHAR(90) NOT NULL,
  `password` VARCHAR(90) NOT NULL,
  `bio` VARCHAR(255) NULL,
  `profile_picture_url` VARCHAR(255) NULL,
  `rating` FLOAT NULL,
  `Feedback_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_User_Feedback1_idx` (`Feedback_id` ASC) VISIBLE,
  CONSTRAINT `fk_User_Feedback1`
    FOREIGN KEY (`Feedback_id`)
    REFERENCES `psk`.`Feedback` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Plant`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Plant` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(90) NOT NULL,
  `description` VARCHAR(255) NULL,
  `category` VARCHAR(45) NULL,
  `subcategory` VARCHAR(45) NULL,
  `quantity` INT NOT NULL,
  `price` FLOAT NOT NULL,
  `Location` VARCHAR(45) NOT NULL,
  `status` VARCHAR(45) NOT NULL,
  `User_id` INT NOT NULL,
  PRIMARY KEY (`id`, `User_id`),
  INDEX `fk_Plant_User_idx` (`User_id` ASC) VISIBLE,
  CONSTRAINT `fk_Plant_User`
    FOREIGN KEY (`User_id`)
    REFERENCES `mydb`.`User` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`PlantPhoto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`PlantPhoto` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `image_url` VARCHAR(255) NOT NULL,
  `Plant_id` INT NOT NULL,
  `Plant_User_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_PlantPhoto_Plant1_idx` (`Plant_id` ASC, `Plant_User_id` ASC) VISIBLE,
  CONSTRAINT `fk_PlantPhoto_Plant1`
    FOREIGN KEY (`Plant_id` , `Plant_User_id`)
    REFERENCES `mydb`.`Plant` (`id` , `User_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`chat`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`chat` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `status` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`message`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`message` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `message_datetime` DATETIME NOT NULL,
  `message_text` VARCHAR(45) NOT NULL,
  `User_id` INT NOT NULL,
  `chat_id` INT NOT NULL,
  PRIMARY KEY (`id`, `User_id`, `chat_id`),
  INDEX `fk_message_User1_idx` (`User_id` ASC) VISIBLE,
  INDEX `fk_message_chat1_idx` (`chat_id` ASC) VISIBLE,
  CONSTRAINT `fk_message_User1`
    FOREIGN KEY (`User_id`)
    REFERENCES `mydb`.`User` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_message_chat1`
    FOREIGN KEY (`chat_id`)
    REFERENCES `mydb`.`chat` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `psk` ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

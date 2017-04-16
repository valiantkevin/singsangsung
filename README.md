# singsangsung

This is a Graphical User Interface class project made by three Duta Wacana Christian University students, Juan Christian Tjandra, Gabriella Amelia Prasetyo, and Kevin Valiant. The application is intended for karaoke rental use.

## Structure

#### FormLogin.vb
* frLogin
* lbUsername
* lbPassword
* tbUsername
* tbPassword
* btLogin - Compare tbUsername and tbPassword value to database. If it's good, continue to FormMain. 
* btExit - Exit.

### FormMain.vb
* frMain
* MenuStrip1
1. Username
..* Change Password
..* Logout
2. Administrator
.*	Report - User with administrator privilege can check daily or monthly report.
.* Settings - The plan is user can choose how many room there are, of which class, and adjust price.
* SplitContainer1 - The left container contains n btRoom from 1 to n. When btRoomi is clicked, the right container shows the room information.
* btRoomi - Button color shows room information :
.* Green if the room is occupied and has more than 15 minutes left.
.* Yellow if the room is occupied and has less than 15 minutes left.
.* Red if the room has no time left and the customer(s) has yet to pay.
.* Some other colors for unoccupied room, yet to be cleaned room, and unusable room.
* pnRoomInfo
.* lbRoomNumber
.* lbRoomClass
.* lbRoomPrice
.* lbRoomCapacity
* lbTimeLeft
* pnRoomOrder
.* lbCustomerName
.* tbCustomerName
.* lbAddTime
.* cbAddTime
.* btOrderRoom
* pnFnB
.* cbPortion
.* tbFnBCode
* btPayment : Open payment confirmation form.

### FormPayment
* lbPaymentID
* lbCustomer
* lbRoomNumber
* lbRoomClass
* lbRoomPrice
* lbTime
* lbRoomTotal

## Database
#### Create Table
```
CREATE TABLE `singsangsung`.`fnb` ( `fnb_id` VARCHAR(5) NOT NULL , `fnb_name` VARCHAR(32) NOT NULL , `fnb_price` INT NOT NULL , PRIMARY KEY (`fnb_id`)) ENGINE = InnoDB;
```
```
CREATE TABLE `singsangsung`.`room_class` ( `class_id` VARCHAR(4) NOT NULL , `class_price` INT NOT NULL , PRIMARY KEY (`class_id`)) ENGINE = InnoDB;
```
```
CREATE TABLE `singsangsung`.`transaction` ( `transaction_id` INT NOT NULL , `employee_id` VARCHAR(8) NOT NULL , `coupon_id` VARCHAR(16) NOT NULL , `transaction_time` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP , PRIMARY KEY (`transaction_id`, `employee_id`)) ENGINE = InnoDB
```
```
CREATE TABLE `singsangsung`.`fnb_ol` ( `fnb_id` VARCHAR(5) NOT NULL , `transaction_id` INT NOT NULL , `num_of_items` INT NOT NULL , PRIMARY KEY (`fnb_id`, `transaction_id`)) ENGINE = InnoDB;
```
```
CREATE TABLE `singsangsung`.`room` ( `room_id` VARCHAR(4) NOT NULL , `class_id` VARCHAR(4) NOT NULL , PRIMARY KEY (`room_id`, `class_id`)) ENGINE = InnoDB;
```
```
CREATE TABLE `singsangsung`.`room_ol` ( `room_id` VARCHAR(4) NOT NULL , `transaction_id` INT NOT NULL , `time_length` INT NOT NULL , PRIMARY KEY (`room_id`, `transaction_id`)) ENGINE = InnoDB;
```
```
CREATE TABLE `singsangsung`.`employee` ( `employee_id` VARCHAR(8) NOT NULL , `employee_name` VARCHAR(100) NOT NULL , `employee_password` VARCHAR(64) NOT NULL , `is_admin` BOOLEAN NOT NULL DEFAULT FALSE , PRIMARY KEY (`employee_id`)) ENGINE = InnoDB;
```

#### Alter Table
```
ALTER TABLE `transaction` ADD FOREIGN KEY (`employee_id`) REFERENCES `singsangsung`.`employee`(`employee_id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
```
```
ALTER TABLE `room` ADD FOREIGN KEY (`class_id`) REFERENCES `singsangsung`.`room_class`(`class_id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
```
```
ALTER TABLE `room_ol` ADD FOREIGN KEY (`room_id`) REFERENCES `singsangsung`.`room`(`room_id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
```
```
ALTER TABLE `room_ol` ADD FOREIGN KEY (`transaction_id`) REFERENCES `singsangsung`.`transaction`(`transaction_id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
```
```
ALTER TABLE `fnb_ol` ADD FOREIGN KEY (`fnb_id`) REFERENCES `singsangsung`.`fnb`(`fnb_id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
```
```
ALTER TABLE `fnb_ol` ADD FOREIGN KEY (`transaction_id`) REFERENCES `singsangsung`.`transaction`(`transaction_id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
```
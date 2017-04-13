# singsangsung

This is a Graphical User Interface class project made by three Duta Wacana Christian University students, Juan Christian Tjandra, Gabriella Amelia Prasetyo, and Kevin Valiant. The application intended for karaoke rental use.

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

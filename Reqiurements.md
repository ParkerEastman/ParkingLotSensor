# Parking Lot Accountability - Requirements
#
Parker Eastman
#
#
### Hardware
	1.When a car passes the "in" beam, the microcontroller will increment its counter by one to keep track of cars in the loat
	2. When a car passes the "out" beam, the microcontroller will decrement its counter by one to keep track of cars in the lot
	3. When the counter is changed, a post request will be made including the count, a timestamp, and the LotID to update the number of cars in the lot

	
### As a user...
	1.  I will log in with a username and password to manage my profile and view available lots
	2.  I will be able to select an edit page to edit my personal information
	3.  On the edit page, I will be able to change my name/email/location
	4.  I will be able to select local lots to view the closest lots to me
	5.  I will be able to select each individual lot to view all pertinent data of that lot, such as name, location, occupancy, available spots
	6.  When I am finished with the application, I will select logout to terminate my current session
	
### As an admin-user...
	1.  I will log in with a username and password to manage my profile and view available lots
	2.  I will be able to select an edit page to edit my personal information
	3.  I will select "My lots" to view the lots that I manage
	4.  On "My lots" page, I will be able to select one of my lots to edit
	5.  On "My lots edit" page, I will be able to change the name, occupancy and location of my parking lot
	6.  On the edit page, I will be able to change my name/email/location
	7.  I will be able to select local lots to view the closest lots to me
	8.  I will be able to select each individual lot to view all pertinent data of that lot, such as name, location, occupancy, available spots
	9.  When I am finished with the application, I will select logout to terminate my current session
	
### As a DB Admin...
	1. I will only store hashed password values to maintain security
	2. I will seperate backend data into two tables, Lot and User, to accomodate one to many relations
	3. In the User table, I will maintain username, hashed password, Lat, and Long to maintain pertinent user data
	4. In the Lot table, I will maintain LotID, OwnerUID, LotName, Lat, Long, Website, NumOfSpaces, NumOfOccupants, and a DateTime representing the last microcontroller update to maintain data about each lot
	5. In the User table, UserID will be the primary key, to provide a unique reference for each record
	6. In the Lot table, LotID will be the primary key, to provide a unique reference for each record
	7. In the Lot table, UserID will be the foreign key, to allow a query to reference pertinent data in the User table
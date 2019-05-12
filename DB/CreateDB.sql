create database GarageDB

use GarageDB

create table Lot(
	LotID int,	OwnerID int,
	LotName nvarchar(64),
	Lat float,
	Long float,
	Website nvarchar(128),
	NumOfSpaces int,
	NumOfOccupants int,
	Updated datetime)


			insert into Lot (LotID, OwnerID, LotName, Lat, Long, Website, NumOfSpaces, NumOfOccupants, Updated)
		values (0000001, 5749, 'Steve''s parking lot', 00, 00, 'www.stevesparkinglot.com', 150, 50, GETDATE());

		insert into Lot (LotID, OwnerID, LotName, Lat, Long, Website, NumOfSpaces, NumOfOccupants, Updated)
		values (0000002, 5750, 'Tony''s Car lot', 00, 00, 'www.TonysCarLot.com', 75, 20, GETDATE());

		insert into Lot (LotID, OwnerID, LotName, Lat, Long, Website, NumOfSpaces, NumOfOccupants, Updated)
		values (0000003, 5751, 'Garage barrage', 00, 00, 'www.GarageBarrage.net', 300, 105, GETDATE());

		insert into Lot (LotID, OwnerID, LotName, Lat, Long, Website, NumOfSpaces, NumOfOccupants, Updated)
		values (0000004, 5751, 'Small Town Lots', 00, 00, 'www.SmallTownLots.org', 30, 12, GETDATE());




create table Client(
	UserID int,
	PasswordVal nvarchar(128),  --make hashed value
	FirstName nvarchar(32),
	LastName nvarchar(32),
	Email nvarchar(64))


	insert into Client (UserID, PasswordVal, FirstName, LastName, Email)
	values(5749, 'P@ssword', 'Steve', 'Parker', 'SteveParker@company.com')

	insert into Client (UserID, PasswordVal, FirstName, LastName, Email)
	values(5750, '12345', 'Tony', 'Spamoni', 'TonysLot@Tony.com')

	insert into Client (UserID, PasswordVal, FirstName, LastName, Email)
	values(5751, 'S3cret$$$', 'Michael', 'Carr', 'MCMikah@somewhere.net')






select * from Lot as L
	join Client
	on L.OwnerID = UserID




select * from Lot
-- Запит, який використовується для отримання персони за її
-- електронною поштою та паролем. Використовується при вході
-- у застосунок
SELECT 
	ID, 
	FullName, 
	Phone, 
	Role 
FROM 
	Person 
WHERE 
	Email = @email 
	AND 
	Password = @password;

-- Запит на отримання кількості персон за електронною поштою та телефоном.
-- Використовується при реєстрації користувача , щоб запобігти появі
-- двом поштам. Це можна вважати аналогом помилки, яку видає сама БД, коли
-- пошта є первинним ключем і хтось зареєструвався зі вже існуючою поштою.
SELECT 
	COUNT(*) 
FROM 
	Person 
WHERE 
	Email = @email 
	AND 
	Phone = @phone;

-- Запит на отримання всіх створених користувачем посилок, включаючи скасовані.
-- Використовується майже у кожних формах (вікнах) застосунку (клієнта, кур'єра та адміністратора).
SELECT 
	* 
FROM
	Parcel 
WHERE 
	clientID = @clientID;

-- Запит на отримання повного імені користувача за його ID.
-- Використовується для відображення інформації про посилку,
-- яка в собі має лише ID клієнта та кур'єра.
SELECT 
	fullName 
FROM 
	Person 
WHERE 
	ID = @id

-- Запит на отримання користувачів за наданою роллю.
-- Використовується для вікна адміністратора, 
-- щоб бачити окремо клієнтів та кур'єрів.
SELECT 
	* 
FROM 
	Person 
WHERE 
	Role = @role

-- Запит для оновлення статусу конкретної посилки і часу, 
-- коли цей статус був встановлений, тобто дата та час, 
-- коли запит був виконаний.
UPDATE 
	Parcel 
SET 
	statusID = @statusID,
	statusDateTime = GETDATE() 
WHERE 
	ID = @id;

-- Запит для оновлення прив'язаного кур'єра до посилки, тобто,
-- коли кур'єр прийняв це замовлення або відмовився.
UPDATE 
	Parcel 
SET 
	courierID = @courierID
WHERE 
	ID = @id;

-- Запит на оновлення одного з трьох дат, які є в посилки - дата, коли кур'єр прийняв це замовлення; 
-- дата, коли кур'єр забрав посилку; дата, коли посилка була доставлена
UPDATE 
	Parcel 
SET 
	-- {dateTimeName} = @{dateTimeName} - в коді замість "{dateTimeName}" буде одна з наведених вище дат
WHERE ID = @id;


-- Запит на створення запису посилки.
INSERT INTO Parcel 
(ClientID, CourierID, StatusID, StatusDateTime, SendingAddress, ArrivalAddress, RecieverFullName, RecieverPhone, AcceptDateTime, SendingDateTime, ArrivalDateTime, Weight, DeliveryPrice)
VALUES
(@ClientID, @CourierID, @StatusID, @StatusDateTime, @SendingAddress, @ArrivalAddress, @RecieverFullName, @RecieverPhone, @AcceptDateTime, @SendingDateTime, @ArrivalDateTime, @Weight, @DeliveryPrice);

-- Запит на створення запису персони
INSERT INTO Person 
(Email, Password, FullName, Phone, Role)
VALUES
(@Email, @Password, @FullName, @Phone, @Role);

-- Запит на створення запису транспорту
INSERT INTO Transport 
(courierID, transportType, transportNumber)
VALUES
(@courierID, @transportType, @transportNumber);

-- Запит на заповнення всієї таблиці "Статус посилки"
INSERT INTO ParcelStatus
(statusText)
VALUES
('Registered'),
('Waiting for pick up'),
('In transit'),
('Completed'),
('Canceled');

-- Запит на видалення посилки за її ID
DELETE FROM 
	Parcel 
WHERE 
	ID = @id;

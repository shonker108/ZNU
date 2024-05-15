CREATE TABLE Person (
  ID          int             NOT NULL     IDENTITY(1, 1), -- IDENTITY - це той самий auto increment починаючи з числа 1 і додаючи кожного разу 1
  Email       varchar(100)    NOT NULL,
  Password    varchar(100)    NOT NULL,
  FullName    nvarchar(100)	  NOT NULL,
  Phone       varchar(10)     NOT NULL,
  Role        varchar(20)     NOT NULL,

  PRIMARY KEY (ID)
);

CREATE TABLE Transport (
  ID                int             NOT NULL    IDENTITY(1, 1),
  courierID         int             NOT NULL,
  transportType     nvarchar(50)    NOT NULL,    
  transportNumber   nvarchar(10)    NULL,		-- Нульове, якщо велосипед

  PRIMARY KEY (ID),
  FOREIGN KEY (courierID) REFERENCES Person (ID)
);

CREATE TABLE ParcelStatus (
	ID					int				NOT NULL	IDENTITY(0, 1),
	statusText			nvarchar(50)	NOT NULL,

	PRIMARY KEY (ID)
);

CREATE TABLE Parcel (
  ID                        int             NOT NULL    IDENTITY(1, 1),
  clientID                  int             NOT NULL,
  courierID                 int,						-- Можливе нульове, бо посилка не одразу буде прийнята кур'єром
  statusID					int				NOT NULL,
  statusDateTime			DATETIME		NOT NULL,
  sendingAddress            nvarchar(MAX)   NOT NULL,
  arrivalAddress            nvarchar(MAX)   NOT NULL,
  recieverFullName          nvarchar(100)   NOT NULL,
  recieverPhone             varchar(10)     NOT NULL,
  acceptDateTime            DATETIME,                   -- Можливе нульове, бо посилка не відразу буде прийнята кур'єром, якщо взагалі ніколи
  sendingDateTime           DATETIME,                   -- Можливе нульове, бо посилка буде не відразу в руках кур'єра
  arrivalDateTime           DATETIME,					-- Можливе нульове, бо посилка прибуде лише тоді, коли хоча-б буде прийнята кур'єром        
  weight                    float           NOT NULL,
  deliveryPrice             int             NOT NULL,

  PRIMARY KEY (ID),
  FOREIGN KEY (clientID) REFERENCES Person (ID),
  FOREIGN KEY (courierID) REFERENCES Person (ID),
  FOREIGN KEY (statusID) REFERENCES ParcelStatus (ID)
);


INSERT INTO ParcelStatus
(statusText)
VALUES
('Зареєстровано'),
('В очікуванні кур''єра'),
('В дорозі'),
('Доставлено'),
('Скасовано');

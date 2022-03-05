--Whiskey Table
CREATE TABLE Whiskey (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    [Name] VARCHAR(100) NOT NULL,
    Price MONEY,
    Proof INTEGER NOT NULL,
    StockQty INTEGER DEFAULT 0,
);

--Reservation Table
CREATE TABLE Reservation (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    [Name] VARCHAR(55) NOT NULL,
    [Type] INTEGER NOT NULL,
    GroupSize INTEGER NOT NULL,
    [Date] DATETIME2 NOT NULL,
    ClubMember BIT NOT NULL,
    WhiskeyId INTEGER,
    CONSTRAINT FK_Whiskey_Reservation FOREIGN KEY(WhiskeyId) REFERENCES Whiskey(Id)
);
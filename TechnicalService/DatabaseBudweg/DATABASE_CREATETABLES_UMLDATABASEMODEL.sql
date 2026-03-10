CREATE DATABASE Budweg;
GO 
USE Budweg;

CREATE TABLE STATION(
    StationId     INT IDENTITY(1,1),
    StationType   NVARCHAR(50),
    StationName   NVARCHAR(50),

    CONSTRAINT PK_STATION
        PRIMARY KEY (StationId)
);

CREATE TABLE SPAREPARTS(
    SparePartId     INT IDENTITY(1,1),
    SparePartType   NVARCHAR(50),
    SparePartAmount INT,
    StationId       INT,

    CONSTRAINT PK_SPAREPARTS
        PRIMARY KEY (SparePartId),

    CONSTRAINT FK_SPAREPARTS_STATION
        FOREIGN KEY (StationId)
        REFERENCES STATION(StationId)
);

CREATE TABLE BRAKECALIPER(
    CaliperId       INT IDENTITY(1,1),
    CaliperType     NVARCHAR(50),
    CaliperStatus   NVARCHAR(50),
    Barcode         NVARCHAR(50),
    CaliperNumber   NVARCHAR(50),
    OrderNumber     NVARCHAR(50),
    Note            NVARCHAR(255),
    StationId       INT,

    CONSTRAINT PK_BRAKECALIPER
        PRIMARY KEY (CaliperId),

    CONSTRAINT FK_BRAKECALIPER_STATION
        FOREIGN KEY (StationId)
        REFERENCES STATION(StationId)
);
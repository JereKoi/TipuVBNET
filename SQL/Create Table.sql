CREATE TABLE Tiput --Creates table and inside paranthesis comes columns 
( TipuID INT IDENTITY(1,1) PRIMARY KEY, -- automatic calculator, first chick = 1, second = 2 etc. No manual numbering needed. Primary key for this means every chick has unique ID with which each one is identified.
NIMI VARCHAR(50) NOT NULL, --Saves text (character tring) which can be max 50 characters, not null means tipu needs name, no nulls are allowed
HatchingDate DATE NOT NULL, --Saves date only, no nulls. format yyyy-mm-dd
Vari VARCHAR(30) --Color of tipu max 30 characters, is optional column since no not null included. Tipu can be saved to database even if color is not known.
);

CREATE TABLE TiputTracking ( LogID INT IDENTITY(1,1) PRIMARY KEY, --Each single log marking has its own automatic running number
TipuID INT FOREIGN KEY REFERENCES Tiput(TipuID), -- Foreign key is which links tracking to specific tipu. References Tiput(TipuID) tells database: this column gets fed a number that needs to be found in Tiput table. You cant add weight to tipu that does not exist.
TipuDate DATE DEFAULT GETDATE(), --This does automatically date. If code sends only weight, db checks clock and adds that days date to this column.
WeightInGrams DECIMAL(5,2), -- This saves decimal number. Numbers (5,2) mean, that numbers can be total 5 of which 2 are after decimal comma. For example (999,99 g). Fits perfectly to a tipu.
EatenFoodInGrams DECIMAL(5,2) -- Saves food that has been eaten that day in grams with same decimal logic as WeightInGrams
);


-- How works:
-- Tiput table:
-- rows: 1 | PII | 2026-07-04 | Yellow (Id 1 came automatically)

-- TiputTracking table:
-- 1 | 1 | 2026-07-05 | 45,50 | NULL

-- Database realize automatically that it is Pii-tipu because I gave it TipuID: 1. Also gave date as tomorrow automatically.

-- These two table structure is relational database (Like SQL Server) base and its called as One-to-Many (One tipu has many log entrys)
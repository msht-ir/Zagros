use Zagros
--SELECT 
--CntWater, ExpWater, ExpElec, ExpDoorPump, ExpGaurd, ExpElev1, ExpElev2, ExpRepair, ExpMisc, PeopleTotal, BookKeeper, Note, DateStart, DateEnd, DateCnt, IsActive
--FROM Periods
--SELECT 
--ID, Period_ID, Unit_ID, Owner, Resident, IsRent, People, WaterFrom, WaterTo, ChargeBill, Note
--FROM PeriodsUnits

SELECT
SUM (Area) AS sm
FROM PeriodsUnits INNER JOIN Units ON PeriodsUnits.Unit_ID = Units.ID
WHERE Period_ID = 10
GROUP BY Area, PeriodsUnits.ID, Period_ID, Unit_ID, Owner, Resident, IsRent, People, WaterFrom, WaterTo, ChargeBill, PeriodsUnits.Note, Area 
ORDER BY Period_ID, Unit_ID

--Sum of areas
SELECT Period_ID,  SUM(Area) AS TotalArea FROM PeriodsUnits INNER JOIN Units ON PeriodsUnits.Unit_ID = Units.ID WHERE Period_ID = 10 GROUP BY Period_ID ORDER BY Period_ID
SELECT SUM(Area) AS TotalArea FROM PeriodsUnits INNER JOIN Units ON PeriodsUnits.Unit_ID = Units.ID WHERE Period_ID = 10

SELECT 
PeriodsUnits.ID,     Period_ID,    Unit_ID,     Owner,     Resident,     IsRent,     People,     WaterFrom,     WaterTo,     ChargeBill, PeriodsUnits.Note,  Area
FROM PeriodsUnits INNER JOIN Units ON  PeriodsUnits.Unit_ID = Units.ID
WHERE     Period_ID = 26
ORDER BY     Period_ID, Unit_ID;

--name of owner and resident and area od units
SELECT PeriodsUnits.ID,     Period_ID,     Unit_ID, Owner, PersonsOwner.Name AS OwnerName, Resident, PersonsResident.Name AS ResidentName, IsRent, People, WaterFrom, WaterTo, ChargeBill, PeriodsUnits.Note, Area FROM PeriodsUnits INNER JOIN Units ON PeriodsUnits.Unit_ID = Units.ID LEFT JOIN Persons AS PersonsOwner ON PeriodsUnits.Owner = PersonsOwner.ID LEFT JOIN Persons AS PersonsResident ON PeriodsUnits.Resident = PersonsResident.ID WHERE Period_ID = 26 ORDER BY Period_ID, Unit_ID;

--ExpGuard
SELECT Period_ID,  SUM(Amount) AS ExGuard FROM Accs WHERE Period_ID = 14 AND Cat_ID=4 GROUP BY Period_ID


SELECT ISNULL (SUM(Amount) , 0) AS ExGuard  FROM Accs WHERE (Period_ID= 12 AND Cat_ID=4)

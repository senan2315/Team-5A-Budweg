## Relationel

SPAREPARTS(<ins>SparePartId</ins> SparePartType, SparePartAmount)

STATION(<ins>StationId</ins>, StationType, StationsName, *SparePartId*)

BRAKECALIBER(<ins>BrakeCaliberId</ins>, BrakeCaliberType, BrakeCaliberStatus, Barcode, CaliberNumber, OrderNumber, Note, *StationId*)
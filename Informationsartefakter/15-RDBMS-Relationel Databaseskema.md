## Relationel

SPAREPARTS(<ins>SparePartId</ins> SparePartType, SparePartAmount)


STATION(<ins>StationId</ins>, StationType, StationsName, *SparePartId*)


BRAKECALIPER(<ins>CaliperId</ins>, CaliperType, CaliperStatus, Barcode, CaliperNumber, OrderNumber, Note, *StationId*)

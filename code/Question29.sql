SELECT Vehicle.VehicleID , GPS.Timestamp, GPS.Latitude, GPS.Longitude , Sensors.Speed, Sensors.Heading, Sensors.IgnitionStatus, Sensors.Temperature, Sensors.DoorStatus
FROM Vehicle INNER JOIN GPS
ON Vehicle.GPSID = GPS.GPSID
INNER JOIN Sensors ON GPS.SensorsID = Sensors.SensorID;
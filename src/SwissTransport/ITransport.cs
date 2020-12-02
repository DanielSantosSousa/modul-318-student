namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        Stations GetStations(double xCoordinate, double yCoordinate);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStation);
        Connections GetConnections(string fromStation, string toStation, string date, string time);
    }
}
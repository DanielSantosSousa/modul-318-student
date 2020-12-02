using System;
using System.Diagnostics;
using SwissTransport;
using System.Windows.Forms;
using System.Device.Location;

namespace MyTransportApp
{
  class OeVApp
  {
    ITransport _transport = new Transport();
    private GeoCoordinateWatcher Watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
    public void FillDataGridViewWithConnections(DataGridView Verbindungen, string StationFrom, string StationTo, string SearchDate, string SearchTime)
    {
      var Connections = _transport.GetConnections(StationFrom, StationTo, SearchDate, SearchTime).ConnectionList;
      Verbindungen.Rows.Clear();
      for (var i = 0; i < 4; i++)
      {
        Verbindungen.Rows.Add(Connections[i].From.Departure, Connections[i].From.Platform, Connections[i].To.Arrival);
      }
    }

    public void FillConnectionsBoard(DataGridView Verbindungen, Station Station)
    {
      var Board = _transport.GetStationBoard(Station.Name, Station.Id);
      foreach (var Connection in Board.Entries)
      {
        Verbindungen.Rows.Add(Connection.Stop.Departure, Connection.Name, Connection.To, Connection.Category);
      }
    }
    public void ShowStationOnMap(string Station)
    {
      try
      {
        if (!String.IsNullOrEmpty(Station))
        {
          Cursor.Current = Cursors.WaitCursor;
          var currentLocation = _transport.GetStations(Station).StationList[0].Coordinate;
          //Searchquery zusammenstellen und Kommas im double durch Punkte ersetzen (In manchen Systemeinstellungen ist es Komma beim Double)
          string GoogleUrl = "https://www.google.ch/maps/?q=loc:" + currentLocation.XCoordinate.ToString().Replace(",", ".") + "+" + currentLocation.YCoordinate.ToString().Replace(",", ".");
          Process.Start(GoogleUrl);
        }
        else
        {
          throw  new Exception("Bitte eine gültige Station eingeben!");
        }
      } catch (Exception Exception)
      {
        MessageBox.Show("Es ist ein Fehler beim Anzeigen der Station aufgetreten!\n\n" + Exception.Message, "Fehler beim Anzeigen der Station", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    public void FillListBoxWithStationsCloseBy(ListBox List)
    {
      var Location = Watcher.Position.Location;

      var Latitude = Location.Latitude.ToString("0.000000");
      var Longitude = Location.Longitude.ToString("0.000000");

      var Stations = _transport.GetStations(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude)).StationList;
      List.Items.Clear();
      foreach (var Station in Stations)
      {
        List.Items.Add(Station.Name);
      }
    }
  }
}

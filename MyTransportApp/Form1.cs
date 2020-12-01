using System;
using System.Linq;
using System.Windows.Forms;
using SwissTransport;

namespace MyTransportApp {
  public partial class connectionSearch : Form {
    ITransport _transport = new Transport();
    public connectionSearch() {
      InitializeComponent();
    }

    private String LastStationSearch = "";

    private void btnSearch_Click(object sender, EventArgs e)
    {
      var stationFrom = _transport.GetStations(cbxFrom.Text).StationList.ElementAt(0);
      var stationTo = _transport.GetStations(cbxTo.Text).StationList.ElementAt(0);
      cbxFrom.Text = stationFrom.Name;
      cbxTo.Text = stationTo.Name;
      var connections = _transport.GetConnections(stationFrom.Name,stationTo.Name).ConnectionList;
      var rowCount = Verbindungen.Rows.Count;
      Verbindungen.Rows.Clear();
      for (var i = 0; i < 4; i++)
      {
        Verbindungen.Rows.Add(connections[i].From.Departure,connections[i].From.Platform,connections[i].To.Arrival);
      }
    }

    private void btnSearchConnection_Click(object sender, EventArgs e)
    {
      var station = _transport.GetStations(cbxStation.Text).StationList.ElementAt(0);
      cbxStation.Text = station.Name;
      var board = _transport.GetStationBoard(station.Name, station.Id);
      foreach (var Connection in board.Entries)
      {
        VerbindungenAbStation.Rows.Add(Connection.Stop.Departure, Connection.Name, Connection.To, Connection.Category);
      }
      
    }

    private void stationCbx_TextChanged(object sender, EventArgs e)
    {
      ComboBox SenderBox = (ComboBox) sender;
      string searchText = SenderBox.Text;
      if (searchText != LastStationSearch)
      {
        LastStationSearch = searchText;
        try
        {
          //Falls es unter 2 Zeichen sind, dann wird nichts vorgeschlagen um zu viele Serverabfragen zu verhindern
          if (searchText.Length < 2)
            return;
          Cursor.Current = Cursors.WaitCursor;
          SenderBox.Items.Clear();
          var stationList = _transport.GetStations(searchText).StationList;
          foreach (var station in stationList)
            if (station.Name != null)
              SenderBox.Items.Add(station.Name);
        }
        catch (Exception Exception)
        {
          MessageBox.Show("Es ist ein Fehler beim Füllen der ComboBox aufgetreten!\n\n" + Exception.Message,
            "Fehler in Combobox Auffüllen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
          Cursor.Current = Cursors.Default;
        }

        SenderBox.SelectionStart = SenderBox.Text.Length;
        SenderBox.SelectionLength = 0;
        SenderBox.Text = searchText;
      }
    }
  }
}

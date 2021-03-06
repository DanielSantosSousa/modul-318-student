﻿using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using SwissTransport;

namespace MyTransportApp {
  public partial class connectionSearch : Form {
    private ITransport _transport = new Transport();
    private OeVApp _OeVApp = new OeVApp();
    private string _LastStationSearch = "";
    public connectionSearch()
    {
      InitializeComponent();
    }


    private void btnSearch_Click(object sender, EventArgs e)
    {
      try
      {
        string SearchDate = dtpConnectionDate.Value.ToString("yyyy-MM-dd");
        string SearchTime = dtpConnectionTime.Value.ToString("HH:mm");
        var StationFrom = _transport.GetStations(cbxFrom.Text).StationList.ElementAt(0);
        var StationTo = _transport.GetStations(cbxTo.Text).StationList.ElementAt(0);
        cbxFrom.Text = StationFrom.Name;
        cbxTo.Text = StationTo.Name;
        _OeVApp.FillDataGridViewWithConnections(Verbindungen, StationFrom.Name, StationTo.Name, SearchDate, SearchTime);
      }
      catch (WebException)
      {
        MessageBox.Show("Verbindung Fehlgeschlagen, verifizieren sie ihre Internetverbindung", "Verbindungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      catch (ArgumentException)
      {
        MessageBox.Show("Bitte eine gültige Station eingeben", "Stations Fehler", MessageBoxButtons.OK,
          MessageBoxIcon.Warning);
      }
    }

    private void btnSearchConnection_Click(object sender, EventArgs e)
    {
      try
      {
        var Station = _transport.GetStations(cbxStation.Text).StationList.ElementAt(0);
      cbxStation.Text = Station.Name;
      _OeVApp.FillConnectionsBoard(VerbindungenAbStation, Station);
      } catch (Exception Exception)
      {
        MessageBox.Show("Bitte eine gültige Station eingeben", "Stations Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void cbxFrom_KeyUp(object sender, KeyEventArgs e)
    {
      ComboBox SenderBox = (ComboBox)sender;
      string SearchText = SenderBox.Text;
      if (SearchText != _LastStationSearch && e.KeyData != Keys.Up && e.KeyData != Keys.Down)
      {
        _LastStationSearch = SearchText;
        try
        {
          //Falls es unter 2 Zeichen sind, dann wird nichts vorgeschlagen um zu viele Serverabfragen zu verhindern
          if (SearchText.Length < 2)
            return;
          Cursor.Current = Cursors.WaitCursor;
          SenderBox.Items.Clear();
          var stationList = _transport.GetStations(SearchText).StationList;
          foreach (var Station in stationList)
            if (Station.Name != null)
              SenderBox.Items.Add(Station.Name);
        } catch (Exception Exception)
        {
          MessageBox.Show("Es ist ein Fehler beim Füllen der ComboBox aufgetreten!\n\n" + Exception.Message,
            "Fehler in Combobox Auffüllen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        } finally
        {
          Cursor.Current = Cursors.Default;
        }

        SenderBox.SelectionStart = SenderBox.Text.Length;
        SenderBox.SelectionLength = 0;
        SenderBox.Text = SearchText;
      }
    }

    private void btnShowOnMapFrom_Click(object sender, EventArgs e)
    {
      _OeVApp.ShowStationOnMap(cbxFrom.Text);
    }

    private void btnShowOnMapTo_Click(object sender, EventArgs e)
    {
      _OeVApp.ShowStationOnMap(cbxFrom.Text);
    }

    private void btnSearchStationsCloseBy_Click(object sender, EventArgs e)
    {
      _OeVApp.FillListBoxWithStationsCloseBy(lbxStationCloseBy);
    }

    private void btnShowStationCloseBy_Click(object sender, EventArgs e)
    {
      try
      {
        if (lbxStationCloseBy.SelectedItem != null)
          _OeVApp.ShowStationOnMap(lbxStationCloseBy.SelectedItem.ToString());
      }
      catch (Exception Exception)
      {
        MessageBox.Show("Bitte ein Element auswählen!\n","Fehlende Auswahl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void btnSwitch_Click(object sender, EventArgs e)
    {
      string Temp = cbxFrom.Text;
      cbxFrom.Text = cbxTo.Text;
      cbxTo.Text = Temp;
    }
  }
}

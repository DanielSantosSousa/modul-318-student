namespace MyTransportApp {
  partial class connectionSearch {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent() {
      this.StationsCloseBy = new System.Windows.Forms.TabControl();
      this.tabConnections = new System.Windows.Forms.TabPage();
      this.btnSwitch = new System.Windows.Forms.Button();
      this.btnShowOnMapTo = new System.Windows.Forms.Button();
      this.btnShowOnMapFrom = new System.Windows.Forms.Button();
      this.dtpConnectionTime = new System.Windows.Forms.DateTimePicker();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.dtpConnectionDate = new System.Windows.Forms.DateTimePicker();
      this.cbxTo = new System.Windows.Forms.ComboBox();
      this.cbxFrom = new System.Windows.Forms.ComboBox();
      this.Verbindungen = new System.Windows.Forms.DataGridView();
      this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Fahrzeug = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnSearch = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tabConnectionsFromStation = new System.Windows.Forms.TabPage();
      this.cbxStation = new System.Windows.Forms.ComboBox();
      this.VerbindungenAbStation = new System.Windows.Forms.DataGridView();
      this.VAS_Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.VAS_Fahrzeug = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Richtung = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label3 = new System.Windows.Forms.Label();
      this.btnSearchConnection = new System.Windows.Forms.Button();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.btnShowStationCloseBy = new System.Windows.Forms.Button();
      this.lbxStationCloseBy = new System.Windows.Forms.ListBox();
      this.btnSearchStationsCloseBy = new System.Windows.Forms.Button();
      this.StationsCloseBy.SuspendLayout();
      this.tabConnections.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Verbindungen)).BeginInit();
      this.tabConnectionsFromStation.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.VerbindungenAbStation)).BeginInit();
      this.tabPage1.SuspendLayout();
      this.SuspendLayout();
      // 
      // StationsCloseBy
      // 
      this.StationsCloseBy.Controls.Add(this.tabConnections);
      this.StationsCloseBy.Controls.Add(this.tabConnectionsFromStation);
      this.StationsCloseBy.Controls.Add(this.tabPage1);
      this.StationsCloseBy.Location = new System.Drawing.Point(9, 10);
      this.StationsCloseBy.Margin = new System.Windows.Forms.Padding(2);
      this.StationsCloseBy.Name = "StationsCloseBy";
      this.StationsCloseBy.SelectedIndex = 0;
      this.StationsCloseBy.Size = new System.Drawing.Size(586, 301);
      this.StationsCloseBy.TabIndex = 0;
      // 
      // tabConnections
      // 
      this.tabConnections.Controls.Add(this.btnSwitch);
      this.tabConnections.Controls.Add(this.btnShowOnMapTo);
      this.tabConnections.Controls.Add(this.btnShowOnMapFrom);
      this.tabConnections.Controls.Add(this.dtpConnectionTime);
      this.tabConnections.Controls.Add(this.label5);
      this.tabConnections.Controls.Add(this.label4);
      this.tabConnections.Controls.Add(this.dtpConnectionDate);
      this.tabConnections.Controls.Add(this.cbxTo);
      this.tabConnections.Controls.Add(this.cbxFrom);
      this.tabConnections.Controls.Add(this.Verbindungen);
      this.tabConnections.Controls.Add(this.btnSearch);
      this.tabConnections.Controls.Add(this.label2);
      this.tabConnections.Controls.Add(this.label1);
      this.tabConnections.Location = new System.Drawing.Point(4, 22);
      this.tabConnections.Margin = new System.Windows.Forms.Padding(2);
      this.tabConnections.Name = "tabConnections";
      this.tabConnections.Padding = new System.Windows.Forms.Padding(2);
      this.tabConnections.Size = new System.Drawing.Size(578, 275);
      this.tabConnections.TabIndex = 0;
      this.tabConnections.Text = "Verbindungen";
      this.tabConnections.UseVisualStyleBackColor = true;
      // 
      // btnSwitch
      // 
      this.btnSwitch.Location = new System.Drawing.Point(227, 14);
      this.btnSwitch.Name = "btnSwitch";
      this.btnSwitch.Size = new System.Drawing.Size(51, 47);
      this.btnSwitch.TabIndex = 1;
      this.btnSwitch.Text = "<---- ---->";
      this.btnSwitch.UseVisualStyleBackColor = true;
      this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
      // 
      // btnShowOnMapTo
      // 
      this.btnShowOnMapTo.Location = new System.Drawing.Point(319, 35);
      this.btnShowOnMapTo.Margin = new System.Windows.Forms.Padding(2);
      this.btnShowOnMapTo.Name = "btnShowOnMapTo";
      this.btnShowOnMapTo.Size = new System.Drawing.Size(169, 26);
      this.btnShowOnMapTo.TabIndex = 13;
      this.btnShowOnMapTo.Text = "In Karte Anzeigen";
      this.btnShowOnMapTo.UseVisualStyleBackColor = true;
      this.btnShowOnMapTo.Click += new System.EventHandler(this.btnShowOnMapTo_Click);
      // 
      // btnShowOnMapFrom
      // 
      this.btnShowOnMapFrom.Location = new System.Drawing.Point(52, 35);
      this.btnShowOnMapFrom.Margin = new System.Windows.Forms.Padding(2);
      this.btnShowOnMapFrom.Name = "btnShowOnMapFrom";
      this.btnShowOnMapFrom.Size = new System.Drawing.Size(168, 26);
      this.btnShowOnMapFrom.TabIndex = 12;
      this.btnShowOnMapFrom.Text = "In Karte Anzeigen";
      this.btnShowOnMapFrom.UseVisualStyleBackColor = true;
      this.btnShowOnMapFrom.Click += new System.EventHandler(this.btnShowOnMapFrom_Click);
      // 
      // dtpConnectionTime
      // 
      this.dtpConnectionTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dtpConnectionTime.Location = new System.Drawing.Point(292, 72);
      this.dtpConnectionTime.Name = "dtpConnectionTime";
      this.dtpConnectionTime.ShowUpDown = true;
      this.dtpConnectionTime.Size = new System.Drawing.Size(203, 20);
      this.dtpConnectionTime.TabIndex = 11;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(17, 77);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(25, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "Am:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(263, 77);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(23, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Ab:";
      // 
      // dtpConnectionDate
      // 
      this.dtpConnectionDate.Location = new System.Drawing.Point(47, 72);
      this.dtpConnectionDate.Name = "dtpConnectionDate";
      this.dtpConnectionDate.Size = new System.Drawing.Size(210, 20);
      this.dtpConnectionDate.TabIndex = 8;
      // 
      // cbxTo
      // 
      this.cbxTo.FormattingEnabled = true;
      this.cbxTo.Location = new System.Drawing.Point(319, 15);
      this.cbxTo.Name = "cbxTo";
      this.cbxTo.Size = new System.Drawing.Size(169, 21);
      this.cbxTo.TabIndex = 7;
      this.cbxTo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxFrom_KeyUp);
      // 
      // cbxFrom
      // 
      this.cbxFrom.FormattingEnabled = true;
      this.cbxFrom.Location = new System.Drawing.Point(52, 19);
      this.cbxFrom.Name = "cbxFrom";
      this.cbxFrom.Size = new System.Drawing.Size(169, 21);
      this.cbxFrom.TabIndex = 6;
      this.cbxFrom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxFrom_KeyUp);
      // 
      // Verbindungen
      // 
      this.Verbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Verbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Fahrzeug,
            this.Ankunft});
      this.Verbindungen.Location = new System.Drawing.Point(35, 97);
      this.Verbindungen.Margin = new System.Windows.Forms.Padding(2);
      this.Verbindungen.Name = "Verbindungen";
      this.Verbindungen.ReadOnly = true;
      this.Verbindungen.RowHeadersWidth = 51;
      this.Verbindungen.RowTemplate.Height = 24;
      this.Verbindungen.Size = new System.Drawing.Size(460, 165);
      this.Verbindungen.TabIndex = 5;
      // 
      // Abfahrt
      // 
      this.Abfahrt.HeaderText = "Abfahrt";
      this.Abfahrt.MinimumWidth = 6;
      this.Abfahrt.Name = "Abfahrt";
      this.Abfahrt.ReadOnly = true;
      this.Abfahrt.Width = 125;
      // 
      // Fahrzeug
      // 
      this.Fahrzeug.HeaderText = "Platform";
      this.Fahrzeug.MinimumWidth = 6;
      this.Fahrzeug.Name = "Fahrzeug";
      this.Fahrzeug.ReadOnly = true;
      this.Fahrzeug.Width = 125;
      // 
      // Ankunft
      // 
      this.Ankunft.HeaderText = "Ankunft";
      this.Ankunft.MinimumWidth = 6;
      this.Ankunft.Name = "Ankunft";
      this.Ankunft.ReadOnly = true;
      this.Ankunft.Width = 125;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(493, 16);
      this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(63, 25);
      this.btnSearch.TabIndex = 4;
      this.btnSearch.Text = "Suchen";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(278, 18);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Nach:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(17, 20);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Von:";
      // 
      // tabConnectionsFromStation
      // 
      this.tabConnectionsFromStation.Controls.Add(this.cbxStation);
      this.tabConnectionsFromStation.Controls.Add(this.VerbindungenAbStation);
      this.tabConnectionsFromStation.Controls.Add(this.label3);
      this.tabConnectionsFromStation.Controls.Add(this.btnSearchConnection);
      this.tabConnectionsFromStation.Location = new System.Drawing.Point(4, 22);
      this.tabConnectionsFromStation.Margin = new System.Windows.Forms.Padding(2);
      this.tabConnectionsFromStation.Name = "tabConnectionsFromStation";
      this.tabConnectionsFromStation.Padding = new System.Windows.Forms.Padding(2);
      this.tabConnectionsFromStation.Size = new System.Drawing.Size(578, 275);
      this.tabConnectionsFromStation.TabIndex = 1;
      this.tabConnectionsFromStation.Text = "Verbindungen ab Station";
      this.tabConnectionsFromStation.UseVisualStyleBackColor = true;
      // 
      // cbxStation
      // 
      this.cbxStation.FormattingEnabled = true;
      this.cbxStation.Location = new System.Drawing.Point(165, 14);
      this.cbxStation.Name = "cbxStation";
      this.cbxStation.Size = new System.Drawing.Size(231, 21);
      this.cbxStation.TabIndex = 7;
      this.cbxStation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxFrom_KeyUp);
      // 
      // VerbindungenAbStation
      // 
      this.VerbindungenAbStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.VerbindungenAbStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VAS_Abfahrt,
            this.VAS_Fahrzeug,
            this.Richtung});
      this.VerbindungenAbStation.Location = new System.Drawing.Point(85, 69);
      this.VerbindungenAbStation.Name = "VerbindungenAbStation";
      this.VerbindungenAbStation.ReadOnly = true;
      this.VerbindungenAbStation.RowHeadersWidth = 51;
      this.VerbindungenAbStation.Size = new System.Drawing.Size(423, 177);
      this.VerbindungenAbStation.TabIndex = 3;
      // 
      // VAS_Abfahrt
      // 
      this.VAS_Abfahrt.HeaderText = "Abfahrt";
      this.VAS_Abfahrt.MinimumWidth = 6;
      this.VAS_Abfahrt.Name = "VAS_Abfahrt";
      this.VAS_Abfahrt.ReadOnly = true;
      this.VAS_Abfahrt.Width = 125;
      // 
      // VAS_Fahrzeug
      // 
      this.VAS_Fahrzeug.HeaderText = "Fahrzeug";
      this.VAS_Fahrzeug.MinimumWidth = 6;
      this.VAS_Fahrzeug.Name = "VAS_Fahrzeug";
      this.VAS_Fahrzeug.ReadOnly = true;
      this.VAS_Fahrzeug.Width = 125;
      // 
      // Richtung
      // 
      this.Richtung.HeaderText = "Richtung";
      this.Richtung.MinimumWidth = 6;
      this.Richtung.Name = "Richtung";
      this.Richtung.ReadOnly = true;
      this.Richtung.Width = 125;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(22, 17);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(127, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Verbindungen ab Station:";
      // 
      // btnSearchConnection
      // 
      this.btnSearchConnection.Location = new System.Drawing.Point(417, 12);
      this.btnSearchConnection.Name = "btnSearchConnection";
      this.btnSearchConnection.Size = new System.Drawing.Size(77, 23);
      this.btnSearchConnection.TabIndex = 0;
      this.btnSearchConnection.Text = "Suchen";
      this.btnSearchConnection.UseVisualStyleBackColor = true;
      this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.btnShowStationCloseBy);
      this.tabPage1.Controls.Add(this.lbxStationCloseBy);
      this.tabPage1.Controls.Add(this.btnSearchStationsCloseBy);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
      this.tabPage1.Size = new System.Drawing.Size(578, 275);
      this.tabPage1.TabIndex = 2;
      this.tabPage1.Text = "Stationen in der Nähe";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // btnShowStationCloseBy
      // 
      this.btnShowStationCloseBy.Location = new System.Drawing.Point(280, 22);
      this.btnShowStationCloseBy.Margin = new System.Windows.Forms.Padding(2);
      this.btnShowStationCloseBy.Name = "btnShowStationCloseBy";
      this.btnShowStationCloseBy.Size = new System.Drawing.Size(86, 36);
      this.btnShowStationCloseBy.TabIndex = 13;
      this.btnShowStationCloseBy.Text = "In Karte Anzeigen";
      this.btnShowStationCloseBy.UseVisualStyleBackColor = true;
      this.btnShowStationCloseBy.Click += new System.EventHandler(this.btnShowStationCloseBy_Click);
      // 
      // lbxStationCloseBy
      // 
      this.lbxStationCloseBy.FormattingEnabled = true;
      this.lbxStationCloseBy.Location = new System.Drawing.Point(152, 71);
      this.lbxStationCloseBy.Margin = new System.Windows.Forms.Padding(2);
      this.lbxStationCloseBy.Name = "lbxStationCloseBy";
      this.lbxStationCloseBy.Size = new System.Drawing.Size(215, 186);
      this.lbxStationCloseBy.TabIndex = 6;
      // 
      // btnSearchStationsCloseBy
      // 
      this.btnSearchStationsCloseBy.Location = new System.Drawing.Point(152, 22);
      this.btnSearchStationsCloseBy.Name = "btnSearchStationsCloseBy";
      this.btnSearchStationsCloseBy.Size = new System.Drawing.Size(110, 36);
      this.btnSearchStationsCloseBy.TabIndex = 5;
      this.btnSearchStationsCloseBy.Text = "Suchen";
      this.btnSearchStationsCloseBy.UseVisualStyleBackColor = true;
      this.btnSearchStationsCloseBy.Click += new System.EventHandler(this.btnSearchStationsCloseBy_Click);
      // 
      // connectionSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(600, 331);
      this.Controls.Add(this.StationsCloseBy);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "connectionSearch";
      this.Text = "Form1";
      this.StationsCloseBy.ResumeLayout(false);
      this.tabConnections.ResumeLayout(false);
      this.tabConnections.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Verbindungen)).EndInit();
      this.tabConnectionsFromStation.ResumeLayout(false);
      this.tabConnectionsFromStation.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.VerbindungenAbStation)).EndInit();
      this.tabPage1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl StationsCloseBy;
    private System.Windows.Forms.TabPage tabConnections;
    private System.Windows.Forms.TabPage tabConnectionsFromStation;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.DataGridView Verbindungen;
    private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
    private System.Windows.Forms.DataGridViewTextBoxColumn Fahrzeug;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnSearchConnection;
    private System.Windows.Forms.DataGridView VerbindungenAbStation;
    private System.Windows.Forms.DataGridViewTextBoxColumn VAS_Abfahrt;
    private System.Windows.Forms.DataGridViewTextBoxColumn VAS_Fahrzeug;
    private System.Windows.Forms.DataGridViewTextBoxColumn Richtung;
    private System.Windows.Forms.ComboBox cbxTo;
    private System.Windows.Forms.ComboBox cbxFrom;
    private System.Windows.Forms.ComboBox cbxStation;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker dtpConnectionDate;
    private System.Windows.Forms.DateTimePicker dtpConnectionTime;
    private System.Windows.Forms.Button btnShowOnMapTo;
    private System.Windows.Forms.Button btnShowOnMapFrom;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Button btnSearchStationsCloseBy;
    private System.Windows.Forms.ListBox lbxStationCloseBy;
    private System.Windows.Forms.Button btnShowStationCloseBy;
    private System.Windows.Forms.Button btnSwitch;
  }
}


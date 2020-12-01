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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabConnections = new System.Windows.Forms.TabPage();
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
      this.dtpConnectionDate = new System.Windows.Forms.DateTimePicker();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.tabControl1.SuspendLayout();
      this.tabConnections.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Verbindungen)).BeginInit();
      this.tabConnectionsFromStation.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.VerbindungenAbStation)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabConnections);
      this.tabControl1.Controls.Add(this.tabConnectionsFromStation);
      this.tabControl1.Location = new System.Drawing.Point(9, 10);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(586, 301);
      this.tabControl1.TabIndex = 0;
      // 
      // tabConnections
      // 
      this.tabConnections.Controls.Add(this.textBox1);
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
      // cbxTo
      // 
      this.cbxTo.FormattingEnabled = true;
      this.cbxTo.Location = new System.Drawing.Point(265, 12);
      this.cbxTo.Name = "cbxTo";
      this.cbxTo.Size = new System.Drawing.Size(169, 21);
      this.cbxTo.TabIndex = 7;
      this.cbxTo.TextChanged += new System.EventHandler(this.stationCbx_TextChanged);
      // 
      // cbxFrom
      // 
      this.cbxFrom.FormattingEnabled = true;
      this.cbxFrom.Location = new System.Drawing.Point(50, 14);
      this.cbxFrom.Name = "cbxFrom";
      this.cbxFrom.Size = new System.Drawing.Size(169, 21);
      this.cbxFrom.TabIndex = 6;
      this.cbxFrom.TextChanged += new System.EventHandler(this.stationCbx_TextChanged);
      // 
      // Verbindungen
      // 
      this.Verbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Verbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Fahrzeug,
            this.Ankunft});
      this.Verbindungen.Location = new System.Drawing.Point(60, 64);
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
      this.btnSearch.Location = new System.Drawing.Point(442, 13);
      this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(56, 20);
      this.btnSearch.TabIndex = 4;
      this.btnSearch.Text = "Suchen";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(224, 15);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Nach:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 15);
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
      this.cbxStation.TextChanged += new System.EventHandler(this.stationCbx_TextChanged);
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
      this.VerbindungenAbStation.Size = new System.Drawing.Size(423, 177);
      this.VerbindungenAbStation.TabIndex = 3;
      // 
      // VAS_Abfahrt
      // 
      this.VAS_Abfahrt.HeaderText = "Abfahrt";
      this.VAS_Abfahrt.Name = "VAS_Abfahrt";
      // 
      // VAS_Fahrzeug
      // 
      this.VAS_Fahrzeug.HeaderText = "Fahrzeug";
      this.VAS_Fahrzeug.Name = "VAS_Fahrzeug";
      // 
      // Richtung
      // 
      this.Richtung.HeaderText = "Richtung";
      this.Richtung.Name = "Richtung";
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
      // dtpConnectionDate
      // 
      this.dtpConnectionDate.Location = new System.Drawing.Point(60, 39);
      this.dtpConnectionDate.Name = "dtpConnectionDate";
      this.dtpConnectionDate.Size = new System.Drawing.Size(200, 20);
      this.dtpConnectionDate.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(266, 45);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(23, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Ab:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(29, 45);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(25, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "Am:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(295, 38);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(181, 20);
      this.textBox1.TabIndex = 11;
      // 
      // connectionSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(600, 331);
      this.Controls.Add(this.tabControl1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "connectionSearch";
      this.Text = "Form1";
      this.tabControl1.ResumeLayout(false);
      this.tabConnections.ResumeLayout(false);
      this.tabConnections.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Verbindungen)).EndInit();
      this.tabConnectionsFromStation.ResumeLayout(false);
      this.tabConnectionsFromStation.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.VerbindungenAbStation)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
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
    private System.Windows.Forms.TextBox textBox1;
  }
}


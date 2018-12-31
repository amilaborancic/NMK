namespace Zadaca2
{
    partial class FormUprava
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Doktori");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tehnicari");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Zaposlenici", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Registrovani");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Preminuli");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Pacijenti", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Najposjecenija ordinacija");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Ostalo", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUprava));
            this.labelOdabirSadrzaja = new System.Windows.Forms.Label();
            this.treeViewZaposleni = new System.Windows.Forms.TreeView();
            this.menuStripUrava = new System.Windows.Forms.MenuStrip();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAnaliza = new System.Windows.Forms.GroupBox();
            this.chartAnaliza = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listViewStuff = new System.Windows.Forms.ListView();
            this.columnHeaderIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelAnaliza = new System.Windows.Forms.Label();
            this.menuStripUrava.SuspendLayout();
            this.groupBoxAnaliza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnaliza)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOdabirSadrzaja
            // 
            this.labelOdabirSadrzaja.AutoSize = true;
            this.labelOdabirSadrzaja.Location = new System.Drawing.Point(270, 57);
            this.labelOdabirSadrzaja.Name = "labelOdabirSadrzaja";
            this.labelOdabirSadrzaja.Size = new System.Drawing.Size(278, 14);
            this.labelOdabirSadrzaja.TabIndex = 0;
            this.labelOdabirSadrzaja.Text = "Dobro dosli! Odaberite sadrzaj koji zelite analizirati.";
            // 
            // treeViewZaposleni
            // 
            this.treeViewZaposleni.Location = new System.Drawing.Point(37, 116);
            this.treeViewZaposleni.Name = "treeViewZaposleni";
            treeNode1.Name = "Doktori";
            treeNode1.Text = "Doktori";
            treeNode2.Name = "Tehnicari";
            treeNode2.Text = "Tehnicari";
            treeNode3.Name = "Zaposlenici";
            treeNode3.Text = "Zaposlenici";
            treeNode4.Name = "Registrovani";
            treeNode4.Text = "Registrovani";
            treeNode5.Name = "Preminuli";
            treeNode5.Text = "Preminuli";
            treeNode6.Name = "Pacijenti";
            treeNode6.Text = "Pacijenti";
            treeNode7.Name = "NajposOrd";
            treeNode7.Text = "Najposjecenija ordinacija";
            treeNode8.Name = "NodeOstalo";
            treeNode8.Text = "Ostalo";
            this.treeViewZaposleni.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode8});
            this.treeViewZaposleni.Size = new System.Drawing.Size(201, 280);
            this.treeViewZaposleni.TabIndex = 1;
            this.treeViewZaposleni.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewZaposleni_NodeMouseClick);
            // 
            // menuStripUrava
            // 
            this.menuStripUrava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.menuStripUrava.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odjavaToolStripMenuItem});
            this.menuStripUrava.Location = new System.Drawing.Point(0, 0);
            this.menuStripUrava.Name = "menuStripUrava";
            this.menuStripUrava.Size = new System.Drawing.Size(892, 24);
            this.menuStripUrava.TabIndex = 3;
            this.menuStripUrava.Text = "menuStripUprava";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // groupBoxAnaliza
            // 
            this.groupBoxAnaliza.Controls.Add(this.chartAnaliza);
            this.groupBoxAnaliza.Controls.Add(this.listViewStuff);
            this.groupBoxAnaliza.Controls.Add(this.labelAnaliza);
            this.groupBoxAnaliza.Location = new System.Drawing.Point(336, 105);
            this.groupBoxAnaliza.Name = "groupBoxAnaliza";
            this.groupBoxAnaliza.Size = new System.Drawing.Size(487, 314);
            this.groupBoxAnaliza.TabIndex = 4;
            this.groupBoxAnaliza.TabStop = false;
            this.groupBoxAnaliza.Text = "Analiza";
            // 
            // chartAnaliza
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAnaliza.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAnaliza.Legends.Add(legend1);
            this.chartAnaliza.Location = new System.Drawing.Point(31, 52);
            this.chartAnaliza.Name = "chartAnaliza";
            this.chartAnaliza.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Posjecenost";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartAnaliza.Series.Add(series1);
            this.chartAnaliza.Size = new System.Drawing.Size(447, 239);
            this.chartAnaliza.TabIndex = 2;
            this.chartAnaliza.Visible = false;
            // 
            // listViewStuff
            // 
            this.listViewStuff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIme,
            this.columnHeaderPrezime});
            this.listViewStuff.GridLines = true;
            this.listViewStuff.Location = new System.Drawing.Point(31, 64);
            this.listViewStuff.Name = "listViewStuff";
            this.listViewStuff.Size = new System.Drawing.Size(423, 227);
            this.listViewStuff.TabIndex = 1;
            this.listViewStuff.UseCompatibleStateImageBehavior = false;
            this.listViewStuff.View = System.Windows.Forms.View.Details;
            this.listViewStuff.Visible = false;
            // 
            // columnHeaderIme
            // 
            this.columnHeaderIme.Text = "Ime";
            this.columnHeaderIme.Width = 191;
            // 
            // columnHeaderPrezime
            // 
            this.columnHeaderPrezime.Text = "Prezime";
            this.columnHeaderPrezime.Width = 235;
            // 
            // labelAnaliza
            // 
            this.labelAnaliza.AutoSize = true;
            this.labelAnaliza.Location = new System.Drawing.Point(28, 34);
            this.labelAnaliza.Name = "labelAnaliza";
            this.labelAnaliza.Size = new System.Drawing.Size(30, 14);
            this.labelAnaliza.TabIndex = 0;
            this.labelAnaliza.Text = "jdjdj";
            this.labelAnaliza.Visible = false;
            // 
            // FormUprava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(892, 442);
            this.Controls.Add(this.groupBoxAnaliza);
            this.Controls.Add(this.treeViewZaposleni);
            this.Controls.Add(this.labelOdabirSadrzaja);
            this.Controls.Add(this.menuStripUrava);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripUrava;
            this.Name = "FormUprava";
            this.Text = "FormUprava";
            this.menuStripUrava.ResumeLayout(false);
            this.menuStripUrava.PerformLayout();
            this.groupBoxAnaliza.ResumeLayout(false);
            this.groupBoxAnaliza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnaliza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOdabirSadrzaja;
        private System.Windows.Forms.TreeView treeViewZaposleni;
        private System.Windows.Forms.MenuStrip menuStripUrava;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxAnaliza;
        private System.Windows.Forms.ListView listViewStuff;
        private System.Windows.Forms.ColumnHeader columnHeaderIme;
        private System.Windows.Forms.ColumnHeader columnHeaderPrezime;
        private System.Windows.Forms.Label labelAnaliza;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnaliza;
    }
}
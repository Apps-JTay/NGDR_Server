namespace NGDR_Server
{
    partial class DR_Server
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
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel1 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel2 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel3 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionStringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultraStatusBar1 = new Infragistics.Win.UltraWinStatusBar.UltraStatusBar();
            this.lblDate = new Infragistics.Win.Misc.UltraLabel();
            this.dtApptDate = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.lblLocation = new Infragistics.Win.Misc.UltraLabel();
            this.cmbLocation = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.cbLimitEnc = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.lblLimitEnc = new Infragistics.Win.Misc.UltraLabel();
            this.uneEncCount = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.lblEnc = new Infragistics.Win.Misc.UltraLabel();
            this.cbSameProvider = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.btnCreate = new Infragistics.Win.Misc.UltraButton();
            this.btnUnzip = new Infragistics.Win.Misc.UltraButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraStatusBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtApptDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLimitEnc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneEncCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSameProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStringsToolStripMenuItem,
            this.fileSystemToolStripMenuItem,
            this.emailAddressesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // connectionStringsToolStripMenuItem
            // 
            this.connectionStringsToolStripMenuItem.Name = "connectionStringsToolStripMenuItem";
            this.connectionStringsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.connectionStringsToolStripMenuItem.Text = "Connection Strings";
            // 
            // fileSystemToolStripMenuItem
            // 
            this.fileSystemToolStripMenuItem.Name = "fileSystemToolStripMenuItem";
            this.fileSystemToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.fileSystemToolStripMenuItem.Text = "File System";
            // 
            // emailAddressesToolStripMenuItem
            // 
            this.emailAddressesToolStripMenuItem.Name = "emailAddressesToolStripMenuItem";
            this.emailAddressesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.emailAddressesToolStripMenuItem.Text = "Email Addresses";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ultraStatusBar1
            // 
            this.ultraStatusBar1.Location = new System.Drawing.Point(0, 252);
            this.ultraStatusBar1.Name = "ultraStatusBar1";
            ultraStatusPanel1.Text = "lblAppversion";
            ultraStatusPanel2.Text = "lblDB";
            ultraStatusPanel3.Text = "lblFVersion";
            this.ultraStatusBar1.Panels.AddRange(new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel[] {
            ultraStatusPanel1,
            ultraStatusPanel2,
            ultraStatusPanel3});
            this.ultraStatusBar1.Size = new System.Drawing.Size(800, 23);
            this.ultraStatusBar1.TabIndex = 1;
            this.ultraStatusBar1.Text = "ultraStatusBar1";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(22, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 23);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Appt Date";
            // 
            // dtApptDate
            // 
            this.dtApptDate.Location = new System.Drawing.Point(90, 43);
            this.dtApptDate.Name = "dtApptDate";
            this.dtApptDate.Size = new System.Drawing.Size(100, 21);
            this.dtApptDate.TabIndex = 3;
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(22, 77);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 23);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location";
            // 
            // cmbLocation
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbLocation.DisplayLayout.Appearance = appearance1;
            this.cmbLocation.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.cmbLocation.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.cmbLocation.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbLocation.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.cmbLocation.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbLocation.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.cmbLocation.DisplayLayout.MaxColScrollRegions = 1;
            this.cmbLocation.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbLocation.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbLocation.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.cmbLocation.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.cmbLocation.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLocation.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.cmbLocation.DisplayLayout.Override.CellAppearance = appearance8;
            this.cmbLocation.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.cmbLocation.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.cmbLocation.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.cmbLocation.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.cmbLocation.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.cmbLocation.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.cmbLocation.DisplayLayout.Override.RowAppearance = appearance11;
            this.cmbLocation.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbLocation.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.cmbLocation.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.cmbLocation.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.cmbLocation.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cmbLocation.Location = new System.Drawing.Point(90, 77);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(407, 22);
            this.cmbLocation.TabIndex = 5;
            // 
            // cbLimitEnc
            // 
            this.cbLimitEnc.Location = new System.Drawing.Point(22, 120);
            this.cbLimitEnc.Name = "cbLimitEnc";
            this.cbLimitEnc.Size = new System.Drawing.Size(120, 20);
            this.cbLimitEnc.TabIndex = 6;
            this.cbLimitEnc.Text = "Limit Encounters";
            // 
            // lblLimitEnc
            // 
            this.lblLimitEnc.Location = new System.Drawing.Point(129, 123);
            this.lblLimitEnc.Name = "lblLimitEnc";
            this.lblLimitEnc.Size = new System.Drawing.Size(163, 23);
            this.lblLimitEnc.TabIndex = 7;
            this.lblLimitEnc.Text = "Only bring documents from last";
            // 
            // uneEncCount
            // 
            this.uneEncCount.Location = new System.Drawing.Point(291, 118);
            this.uneEncCount.Name = "uneEncCount";
            this.uneEncCount.Size = new System.Drawing.Size(44, 21);
            this.uneEncCount.TabIndex = 8;
            // 
            // lblEnc
            // 
            this.lblEnc.Location = new System.Drawing.Point(341, 122);
            this.lblEnc.Name = "lblEnc";
            this.lblEnc.Size = new System.Drawing.Size(66, 23);
            this.lblEnc.TabIndex = 9;
            this.lblEnc.Text = "encounters";
            // 
            // cbSameProvider
            // 
            this.cbSameProvider.Location = new System.Drawing.Point(22, 147);
            this.cbSameProvider.Name = "cbSameProvider";
            this.cbSameProvider.Size = new System.Drawing.Size(621, 20);
            this.cbSameProvider.TabIndex = 10;
            this.cbSameProvider.Text = "Get ONLY Documents whose rendering provider is the same as the rendering provider" +
    " on the upcoming appointment";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(22, 185);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(101, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create Files";
            // 
            // btnUnzip
            // 
            this.btnUnzip.Location = new System.Drawing.Point(130, 185);
            this.btnUnzip.Name = "btnUnzip";
            this.btnUnzip.Size = new System.Drawing.Size(101, 23);
            this.btnUnzip.TabIndex = 12;
            this.btnUnzip.Text = "Unzip Images";
            // 
            // DR_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 275);
            this.Controls.Add(this.btnUnzip);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cbSameProvider);
            this.Controls.Add(this.lblEnc);
            this.Controls.Add(this.uneEncCount);
            this.Controls.Add(this.lblLimitEnc);
            this.Controls.Add(this.cbLimitEnc);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.dtApptDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.ultraStatusBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DR_Server";
            this.Text = "DR_Server";
            this.Load += new System.EventHandler(this.DR_Server_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraStatusBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtApptDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLimitEnc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneEncCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSameProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionStringsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private Infragistics.Win.UltraWinStatusBar.UltraStatusBar ultraStatusBar1;
        private Infragistics.Win.Misc.UltraLabel lblDate;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor dtApptDate;
        private Infragistics.Win.Misc.UltraLabel lblLocation;
        private Infragistics.Win.UltraWinGrid.UltraCombo cmbLocation;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor cbLimitEnc;
        private Infragistics.Win.Misc.UltraLabel lblLimitEnc;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneEncCount;
        private Infragistics.Win.Misc.UltraLabel lblEnc;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor cbSameProvider;
        private Infragistics.Win.Misc.UltraButton btnCreate;
        private Infragistics.Win.Misc.UltraButton btnUnzip;
    }
}


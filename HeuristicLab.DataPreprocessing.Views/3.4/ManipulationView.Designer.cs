﻿namespace HeuristicLab.DataPreprocessing.Views {
  partial class ManipulationView {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.lstMethods = new System.Windows.Forms.ListBox();
      this.btnApply = new System.Windows.Forms.Button();
      this.grpBoxData = new System.Windows.Forms.GroupBox();
      this.tabsData = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.label7 = new System.Windows.Forms.Label();
      this.tabDataDeleteColumnsInformation = new System.Windows.Forms.TabPage();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDeleteColumnsInfo = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tabDataDeleteColumnsVariance = new System.Windows.Forms.TabPage();
      this.txtDeleteColumnsVariance = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tabDataDeleteRowsInfo = new System.Windows.Forms.TabPage();
      this.label3 = new System.Windows.Forms.Label();
      this.txtDeleteRowsInfo = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.tabReplaceMissingValues = new System.Windows.Forms.TabPage();
      this.txtReplaceValue = new System.Windows.Forms.TextBox();
      this.cmbVariableNames = new System.Windows.Forms.ComboBox();
      this.cmbReplaceWith = new System.Windows.Forms.ComboBox();
      this.lblValueColon = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.tabDataShuffle = new System.Windows.Forms.TabPage();
      this.label6 = new System.Windows.Forms.Label();
      this.grpBoxPreview = new System.Windows.Forms.GroupBox();
      this.tabsPreview = new System.Windows.Forms.TabControl();
      this.tabPreviewInactive = new System.Windows.Forms.TabPage();
      this.lblPreviewInActive = new System.Windows.Forms.Label();
      this.tabPreviewDeleteColumnsInfo = new System.Windows.Forms.TabPage();
      this.lblPreviewColumnsInfo = new System.Windows.Forms.Label();
      this.tabPreviewDeleteColumnsVariance = new System.Windows.Forms.TabPage();
      this.label12 = new System.Windows.Forms.Label();
      this.lblPreviewColumnsVariance = new System.Windows.Forms.Label();
      this.tabPreviewDeleteRowsInfo = new System.Windows.Forms.TabPage();
      this.lblPreviewRowsInfo = new System.Windows.Forms.Label();
      this.tabPreviewReplaceMissingValues = new System.Windows.Forms.TabPage();
      this.lblPreviewReplaceMissingValues = new System.Windows.Forms.Label();
      this.tabPreviewShuffle = new System.Windows.Forms.TabPage();
      this.lblPreviewShuffle = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.grpBoxData.SuspendLayout();
      this.tabsData.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabDataDeleteColumnsInformation.SuspendLayout();
      this.tabDataDeleteColumnsVariance.SuspendLayout();
      this.tabDataDeleteRowsInfo.SuspendLayout();
      this.tabReplaceMissingValues.SuspendLayout();
      this.tabDataShuffle.SuspendLayout();
      this.grpBoxPreview.SuspendLayout();
      this.tabsPreview.SuspendLayout();
      this.tabPreviewInactive.SuspendLayout();
      this.tabPreviewDeleteColumnsInfo.SuspendLayout();
      this.tabPreviewDeleteColumnsVariance.SuspendLayout();
      this.tabPreviewDeleteRowsInfo.SuspendLayout();
      this.tabPreviewReplaceMissingValues.SuspendLayout();
      this.tabPreviewShuffle.SuspendLayout();
      this.SuspendLayout();
      // 
      // lstMethods
      // 
      this.lstMethods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstMethods.FormattingEnabled = true;
      this.lstMethods.Items.AddRange(new object[] {
            "Delete Columns with insufficient Information",
            "Delete Columns with insufficient Variance",
            "Delete Rows with insufficient Information",
            "Replace Missing Values",
            "Shuffle Data"});
      this.lstMethods.Location = new System.Drawing.Point(3, 3);
      this.lstMethods.Name = "lstMethods";
      this.lstMethods.Size = new System.Drawing.Size(733, 95);
      this.lstMethods.Sorted = true;
      this.lstMethods.TabIndex = 0;
      this.lstMethods.SelectedIndexChanged += new System.EventHandler(this.lstMethods_SelectedIndexChanged);
      // 
      // btnApply
      // 
      this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnApply.Enabled = false;
      this.btnApply.Location = new System.Drawing.Point(603, 500);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new System.Drawing.Size(129, 23);
      this.btnApply.TabIndex = 2;
      this.btnApply.Text = "Apply Manipulation";
      this.btnApply.UseVisualStyleBackColor = true;
      this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
      // 
      // grpBoxData
      // 
      this.grpBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpBoxData.Controls.Add(this.tabsData);
      this.grpBoxData.Location = new System.Drawing.Point(4, 105);
      this.grpBoxData.Name = "grpBoxData";
      this.grpBoxData.Size = new System.Drawing.Size(732, 189);
      this.grpBoxData.TabIndex = 3;
      this.grpBoxData.TabStop = false;
      this.grpBoxData.Text = "Properties";
      // 
      // tabsData
      // 
      this.tabsData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabsData.Controls.Add(this.tabPage1);
      this.tabsData.Controls.Add(this.tabDataDeleteColumnsInformation);
      this.tabsData.Controls.Add(this.tabDataDeleteColumnsVariance);
      this.tabsData.Controls.Add(this.tabDataDeleteRowsInfo);
      this.tabsData.Controls.Add(this.tabReplaceMissingValues);
      this.tabsData.Controls.Add(this.tabDataShuffle);
      this.tabsData.ItemSize = new System.Drawing.Size(58, 18);
      this.tabsData.Location = new System.Drawing.Point(6, 19);
      this.tabsData.Name = "tabsData";
      this.tabsData.SelectedIndex = 0;
      this.tabsData.Size = new System.Drawing.Size(719, 164);
      this.tabsData.TabIndex = 3;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.label7);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(711, 138);
      this.tabPage1.TabIndex = 5;
      this.tabPage1.Text = "tabDataInactive";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Enabled = false;
      this.label7.Location = new System.Drawing.Point(3, 3);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(259, 13);
      this.label7.TabIndex = 1;
      this.label7.Text = "Please select one of the manipulation methods above";
      // 
      // tabDataDeleteColumnsInformation
      // 
      this.tabDataDeleteColumnsInformation.Controls.Add(this.label2);
      this.tabDataDeleteColumnsInformation.Controls.Add(this.txtDeleteColumnsInfo);
      this.tabDataDeleteColumnsInformation.Controls.Add(this.label1);
      this.tabDataDeleteColumnsInformation.Location = new System.Drawing.Point(4, 22);
      this.tabDataDeleteColumnsInformation.Name = "tabDataDeleteColumnsInformation";
      this.tabDataDeleteColumnsInformation.Padding = new System.Windows.Forms.Padding(3);
      this.tabDataDeleteColumnsInformation.Size = new System.Drawing.Size(711, 138);
      this.tabDataDeleteColumnsInformation.TabIndex = 0;
      this.tabDataDeleteColumnsInformation.Text = "del columns info";
      this.tabDataDeleteColumnsInformation.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(204, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(89, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "% missing values.";
      // 
      // txtDeleteColumnsInfo
      // 
      this.txtDeleteColumnsInfo.Location = new System.Drawing.Point(164, 0);
      this.txtDeleteColumnsInfo.Name = "txtDeleteColumnsInfo";
      this.txtDeleteColumnsInfo.Size = new System.Drawing.Size(34, 20);
      this.txtDeleteColumnsInfo.TabIndex = 4;
      this.txtDeleteColumnsInfo.TextChanged += new System.EventHandler(this.txtDeleteColumnsInfo_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(155, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Delete columns with more than ";
      // 
      // tabDataDeleteColumnsVariance
      // 
      this.tabDataDeleteColumnsVariance.Controls.Add(this.txtDeleteColumnsVariance);
      this.tabDataDeleteColumnsVariance.Controls.Add(this.label4);
      this.tabDataDeleteColumnsVariance.Location = new System.Drawing.Point(4, 22);
      this.tabDataDeleteColumnsVariance.Name = "tabDataDeleteColumnsVariance";
      this.tabDataDeleteColumnsVariance.Padding = new System.Windows.Forms.Padding(3);
      this.tabDataDeleteColumnsVariance.Size = new System.Drawing.Size(711, 138);
      this.tabDataDeleteColumnsVariance.TabIndex = 1;
      this.tabDataDeleteColumnsVariance.Text = "del columns variance";
      this.tabDataDeleteColumnsVariance.UseVisualStyleBackColor = true;
      // 
      // txtDeleteColumnsVariance
      // 
      this.txtDeleteColumnsVariance.Location = new System.Drawing.Point(229, 0);
      this.txtDeleteColumnsVariance.Name = "txtDeleteColumnsVariance";
      this.txtDeleteColumnsVariance.Size = new System.Drawing.Size(135, 20);
      this.txtDeleteColumnsVariance.TabIndex = 4;
      this.txtDeleteColumnsVariance.TextChanged += new System.EventHandler(this.txtDeleteColumnsVariance_TextChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(220, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Delete columns with a variance smaller than  ";
      // 
      // tabDataDeleteRowsInfo
      // 
      this.tabDataDeleteRowsInfo.Controls.Add(this.label3);
      this.tabDataDeleteRowsInfo.Controls.Add(this.txtDeleteRowsInfo);
      this.tabDataDeleteRowsInfo.Controls.Add(this.label5);
      this.tabDataDeleteRowsInfo.Location = new System.Drawing.Point(4, 22);
      this.tabDataDeleteRowsInfo.Name = "tabDataDeleteRowsInfo";
      this.tabDataDeleteRowsInfo.Padding = new System.Windows.Forms.Padding(3);
      this.tabDataDeleteRowsInfo.Size = new System.Drawing.Size(711, 138);
      this.tabDataDeleteRowsInfo.TabIndex = 2;
      this.tabDataDeleteRowsInfo.Text = "del rows info";
      this.tabDataDeleteRowsInfo.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(189, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(89, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "% missing values.";
      // 
      // txtDeleteRowsInfo
      // 
      this.txtDeleteRowsInfo.Location = new System.Drawing.Point(147, 0);
      this.txtDeleteRowsInfo.Name = "txtDeleteRowsInfo";
      this.txtDeleteRowsInfo.Size = new System.Drawing.Size(34, 20);
      this.txtDeleteRowsInfo.TabIndex = 7;
      this.txtDeleteRowsInfo.TextChanged += new System.EventHandler(this.txtDeleteRowsInfo_TextChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 3);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(138, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "Delete rows with more than ";
      // 
      // tabReplaceMissingValues
      // 
      this.tabReplaceMissingValues.Controls.Add(this.txtReplaceValue);
      this.tabReplaceMissingValues.Controls.Add(this.cmbVariableNames);
      this.tabReplaceMissingValues.Controls.Add(this.cmbReplaceWith);
      this.tabReplaceMissingValues.Controls.Add(this.lblValueColon);
      this.tabReplaceMissingValues.Controls.Add(this.label8);
      this.tabReplaceMissingValues.Controls.Add(this.label10);
      this.tabReplaceMissingValues.Location = new System.Drawing.Point(4, 22);
      this.tabReplaceMissingValues.Name = "tabReplaceMissingValues";
      this.tabReplaceMissingValues.Padding = new System.Windows.Forms.Padding(3);
      this.tabReplaceMissingValues.Size = new System.Drawing.Size(711, 138);
      this.tabReplaceMissingValues.TabIndex = 6;
      this.tabReplaceMissingValues.Text = "repl missing vals";
      this.tabReplaceMissingValues.UseVisualStyleBackColor = true;
      // 
      // txtReplaceValue
      // 
      this.txtReplaceValue.Location = new System.Drawing.Point(173, 27);
      this.txtReplaceValue.Name = "txtReplaceValue";
      this.txtReplaceValue.Size = new System.Drawing.Size(100, 20);
      this.txtReplaceValue.TabIndex = 2;
      this.txtReplaceValue.TextChanged += new System.EventHandler(this.txtReplaceValue_TextChanged);
      // 
      // cmbVariableNames
      // 
      this.cmbVariableNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbVariableNames.FormattingEnabled = true;
      this.cmbVariableNames.Location = new System.Drawing.Point(142, 0);
      this.cmbVariableNames.Name = "cmbVariableNames";
      this.cmbVariableNames.Size = new System.Drawing.Size(121, 21);
      this.cmbVariableNames.TabIndex = 1;
      this.cmbVariableNames.SelectedIndexChanged += new System.EventHandler(this.cmbReplaceWith_SelectedIndexChanged);
      // 
      // cmbReplaceWith
      // 
      this.cmbReplaceWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbReplaceWith.FormattingEnabled = true;
      this.cmbReplaceWith.Items.AddRange(new object[] {
            "Value",
            "Average",
            "Median",
            "Most Common",
            "Random"});
      this.cmbReplaceWith.Location = new System.Drawing.Point(35, 27);
      this.cmbReplaceWith.Name = "cmbReplaceWith";
      this.cmbReplaceWith.Size = new System.Drawing.Size(121, 21);
      this.cmbReplaceWith.TabIndex = 1;
      this.cmbReplaceWith.SelectedIndexChanged += new System.EventHandler(this.cmbReplaceWith_SelectedIndexChanged);
      // 
      // lblValueColon
      // 
      this.lblValueColon.AutoSize = true;
      this.lblValueColon.Location = new System.Drawing.Point(157, 30);
      this.lblValueColon.Name = "lblValueColon";
      this.lblValueColon.Size = new System.Drawing.Size(10, 13);
      this.lblValueColon.TabIndex = 0;
      this.lblValueColon.Text = ":";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(3, 30);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(26, 13);
      this.label8.TabIndex = 0;
      this.label8.Text = "with";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(3, 3);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(133, 13);
      this.label10.TabIndex = 0;
      this.label10.Text = "Replace missing values for";
      // 
      // tabDataShuffle
      // 
      this.tabDataShuffle.Controls.Add(this.label6);
      this.tabDataShuffle.Location = new System.Drawing.Point(4, 22);
      this.tabDataShuffle.Name = "tabDataShuffle";
      this.tabDataShuffle.Padding = new System.Windows.Forms.Padding(3);
      this.tabDataShuffle.Size = new System.Drawing.Size(711, 138);
      this.tabDataShuffle.TabIndex = 4;
      this.tabDataShuffle.Text = "shuffle";
      this.tabDataShuffle.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Enabled = false;
      this.label6.Location = new System.Drawing.Point(3, 3);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(115, 13);
      this.label6.TabIndex = 0;
      this.label6.Text = "No properties available";
      // 
      // grpBoxPreview
      // 
      this.grpBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpBoxPreview.Controls.Add(this.tabsPreview);
      this.grpBoxPreview.Location = new System.Drawing.Point(4, 301);
      this.grpBoxPreview.Name = "grpBoxPreview";
      this.grpBoxPreview.Size = new System.Drawing.Size(732, 193);
      this.grpBoxPreview.TabIndex = 4;
      this.grpBoxPreview.TabStop = false;
      this.grpBoxPreview.Text = "Preview";
      // 
      // tabsPreview
      // 
      this.tabsPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabsPreview.Controls.Add(this.tabPreviewInactive);
      this.tabsPreview.Controls.Add(this.tabPreviewDeleteColumnsInfo);
      this.tabsPreview.Controls.Add(this.tabPreviewDeleteColumnsVariance);
      this.tabsPreview.Controls.Add(this.tabPreviewDeleteRowsInfo);
      this.tabsPreview.Controls.Add(this.tabPreviewReplaceMissingValues);
      this.tabsPreview.Controls.Add(this.tabPreviewShuffle);
      this.tabsPreview.ItemSize = new System.Drawing.Size(58, 18);
      this.tabsPreview.Location = new System.Drawing.Point(6, 19);
      this.tabsPreview.Name = "tabsPreview";
      this.tabsPreview.SelectedIndex = 0;
      this.tabsPreview.Size = new System.Drawing.Size(719, 168);
      this.tabsPreview.TabIndex = 3;
      // 
      // tabPreviewInactive
      // 
      this.tabPreviewInactive.Controls.Add(this.lblPreviewInActive);
      this.tabPreviewInactive.Location = new System.Drawing.Point(4, 22);
      this.tabPreviewInactive.Name = "tabPreviewInactive";
      this.tabPreviewInactive.Padding = new System.Windows.Forms.Padding(3);
      this.tabPreviewInactive.Size = new System.Drawing.Size(711, 142);
      this.tabPreviewInactive.TabIndex = 5;
      this.tabPreviewInactive.Text = "inactive";
      this.tabPreviewInactive.UseVisualStyleBackColor = true;
      // 
      // lblPreviewInActive
      // 
      this.lblPreviewInActive.AutoSize = true;
      this.lblPreviewInActive.Location = new System.Drawing.Point(3, 3);
      this.lblPreviewInActive.Name = "lblPreviewInActive";
      this.lblPreviewInActive.Size = new System.Drawing.Size(361, 39);
      this.lblPreviewInActive.TabIndex = 2;
      this.lblPreviewInActive.Text = "Filters are active and thus manipulations cannot be applied!\r\n\r\nPlease deactive t" +
    "he filter(s) first in order to be able to perform manipulations.";
      this.lblPreviewInActive.Visible = false;
      // 
      // tabPreviewDeleteColumnsInfo
      // 
      this.tabPreviewDeleteColumnsInfo.Controls.Add(this.lblPreviewColumnsInfo);
      this.tabPreviewDeleteColumnsInfo.Location = new System.Drawing.Point(4, 22);
      this.tabPreviewDeleteColumnsInfo.Name = "tabPreviewDeleteColumnsInfo";
      this.tabPreviewDeleteColumnsInfo.Padding = new System.Windows.Forms.Padding(3);
      this.tabPreviewDeleteColumnsInfo.Size = new System.Drawing.Size(711, 142);
      this.tabPreviewDeleteColumnsInfo.TabIndex = 0;
      this.tabPreviewDeleteColumnsInfo.Text = "del columns info";
      this.tabPreviewDeleteColumnsInfo.UseVisualStyleBackColor = true;
      // 
      // lblPreviewColumnsInfo
      // 
      this.lblPreviewColumnsInfo.AutoSize = true;
      this.lblPreviewColumnsInfo.Location = new System.Drawing.Point(3, 3);
      this.lblPreviewColumnsInfo.Name = "lblPreviewColumnsInfo";
      this.lblPreviewColumnsInfo.Size = new System.Drawing.Size(318, 13);
      this.lblPreviewColumnsInfo.TabIndex = 1;
      this.lblPreviewColumnsInfo.Text = "{0} columns with more than {1} % missing values would be deleted";
      // 
      // tabPreviewDeleteColumnsVariance
      // 
      this.tabPreviewDeleteColumnsVariance.Controls.Add(this.label12);
      this.tabPreviewDeleteColumnsVariance.Controls.Add(this.lblPreviewColumnsVariance);
      this.tabPreviewDeleteColumnsVariance.Location = new System.Drawing.Point(4, 22);
      this.tabPreviewDeleteColumnsVariance.Name = "tabPreviewDeleteColumnsVariance";
      this.tabPreviewDeleteColumnsVariance.Padding = new System.Windows.Forms.Padding(3);
      this.tabPreviewDeleteColumnsVariance.Size = new System.Drawing.Size(711, 142);
      this.tabPreviewDeleteColumnsVariance.TabIndex = 1;
      this.tabPreviewDeleteColumnsVariance.Text = "del columns variance";
      this.tabPreviewDeleteColumnsVariance.UseVisualStyleBackColor = true;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(6, 22);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(0, 13);
      this.label12.TabIndex = 2;
      // 
      // lblPreviewColumnsVariance
      // 
      this.lblPreviewColumnsVariance.AutoSize = true;
      this.lblPreviewColumnsVariance.Location = new System.Drawing.Point(3, 3);
      this.lblPreviewColumnsVariance.Name = "lblPreviewColumnsVariance";
      this.lblPreviewColumnsVariance.Size = new System.Drawing.Size(301, 13);
      this.lblPreviewColumnsVariance.TabIndex = 2;
      this.lblPreviewColumnsVariance.Text = "{0} columns with a variance smaller than {1} would be deleted.";
      // 
      // tabPreviewDeleteRowsInfo
      // 
      this.tabPreviewDeleteRowsInfo.Controls.Add(this.lblPreviewRowsInfo);
      this.tabPreviewDeleteRowsInfo.Location = new System.Drawing.Point(4, 22);
      this.tabPreviewDeleteRowsInfo.Name = "tabPreviewDeleteRowsInfo";
      this.tabPreviewDeleteRowsInfo.Padding = new System.Windows.Forms.Padding(3);
      this.tabPreviewDeleteRowsInfo.Size = new System.Drawing.Size(711, 142);
      this.tabPreviewDeleteRowsInfo.TabIndex = 2;
      this.tabPreviewDeleteRowsInfo.Text = "del rows info";
      this.tabPreviewDeleteRowsInfo.UseVisualStyleBackColor = true;
      // 
      // lblPreviewRowsInfo
      // 
      this.lblPreviewRowsInfo.AutoSize = true;
      this.lblPreviewRowsInfo.Location = new System.Drawing.Point(3, 3);
      this.lblPreviewRowsInfo.Name = "lblPreviewRowsInfo";
      this.lblPreviewRowsInfo.Size = new System.Drawing.Size(301, 13);
      this.lblPreviewRowsInfo.TabIndex = 2;
      this.lblPreviewRowsInfo.Text = "{0} rows with more than {1} % missing values would be deleted";
      // 
      // tabPreviewReplaceMissingValues
      // 
      this.tabPreviewReplaceMissingValues.Controls.Add(this.lblPreviewReplaceMissingValues);
      this.tabPreviewReplaceMissingValues.Location = new System.Drawing.Point(4, 22);
      this.tabPreviewReplaceMissingValues.Name = "tabPreviewReplaceMissingValues";
      this.tabPreviewReplaceMissingValues.Padding = new System.Windows.Forms.Padding(3);
      this.tabPreviewReplaceMissingValues.Size = new System.Drawing.Size(711, 142);
      this.tabPreviewReplaceMissingValues.TabIndex = 6;
      this.tabPreviewReplaceMissingValues.Text = "repl missing vals";
      this.tabPreviewReplaceMissingValues.UseVisualStyleBackColor = true;
      // 
      // lblPreviewReplaceMissingValues
      // 
      this.lblPreviewReplaceMissingValues.AutoSize = true;
      this.lblPreviewReplaceMissingValues.Location = new System.Drawing.Point(3, 3);
      this.lblPreviewReplaceMissingValues.Name = "lblPreviewReplaceMissingValues";
      this.lblPreviewReplaceMissingValues.Size = new System.Drawing.Size(343, 13);
      this.lblPreviewReplaceMissingValues.TabIndex = 3;
      this.lblPreviewReplaceMissingValues.Text = "{0} cells detected with missing values which would be replaced with {1}";
      // 
      // tabPreviewShuffle
      // 
      this.tabPreviewShuffle.Controls.Add(this.lblPreviewShuffle);
      this.tabPreviewShuffle.Location = new System.Drawing.Point(4, 22);
      this.tabPreviewShuffle.Name = "tabPreviewShuffle";
      this.tabPreviewShuffle.Padding = new System.Windows.Forms.Padding(3);
      this.tabPreviewShuffle.Size = new System.Drawing.Size(711, 142);
      this.tabPreviewShuffle.TabIndex = 4;
      this.tabPreviewShuffle.Text = "shuffle";
      this.tabPreviewShuffle.UseVisualStyleBackColor = true;
      // 
      // lblPreviewShuffle
      // 
      this.lblPreviewShuffle.AutoSize = true;
      this.lblPreviewShuffle.Location = new System.Drawing.Point(3, 3);
      this.lblPreviewShuffle.Name = "lblPreviewShuffle";
      this.lblPreviewShuffle.Size = new System.Drawing.Size(252, 13);
      this.lblPreviewShuffle.TabIndex = 0;
      this.lblPreviewShuffle.Text = "Data will be shuffled randomly - preview not possible";
      // 
      // label9
      // 
      this.label9.Location = new System.Drawing.Point(0, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(100, 23);
      this.label9.TabIndex = 0;
      // 
      // ManipulationView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnApply);
      this.Controls.Add(this.grpBoxPreview);
      this.Controls.Add(this.grpBoxData);
      this.Controls.Add(this.lstMethods);
      this.Name = "ManipulationView";
      this.Size = new System.Drawing.Size(739, 529);
      this.grpBoxData.ResumeLayout(false);
      this.tabsData.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabDataDeleteColumnsInformation.ResumeLayout(false);
      this.tabDataDeleteColumnsInformation.PerformLayout();
      this.tabDataDeleteColumnsVariance.ResumeLayout(false);
      this.tabDataDeleteColumnsVariance.PerformLayout();
      this.tabDataDeleteRowsInfo.ResumeLayout(false);
      this.tabDataDeleteRowsInfo.PerformLayout();
      this.tabReplaceMissingValues.ResumeLayout(false);
      this.tabReplaceMissingValues.PerformLayout();
      this.tabDataShuffle.ResumeLayout(false);
      this.tabDataShuffle.PerformLayout();
      this.grpBoxPreview.ResumeLayout(false);
      this.tabsPreview.ResumeLayout(false);
      this.tabPreviewInactive.ResumeLayout(false);
      this.tabPreviewInactive.PerformLayout();
      this.tabPreviewDeleteColumnsInfo.ResumeLayout(false);
      this.tabPreviewDeleteColumnsInfo.PerformLayout();
      this.tabPreviewDeleteColumnsVariance.ResumeLayout(false);
      this.tabPreviewDeleteColumnsVariance.PerformLayout();
      this.tabPreviewDeleteRowsInfo.ResumeLayout(false);
      this.tabPreviewDeleteRowsInfo.PerformLayout();
      this.tabPreviewReplaceMissingValues.ResumeLayout(false);
      this.tabPreviewReplaceMissingValues.PerformLayout();
      this.tabPreviewShuffle.ResumeLayout(false);
      this.tabPreviewShuffle.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lstMethods;
    private System.Windows.Forms.Button btnApply;
    private System.Windows.Forms.GroupBox grpBoxData;
    private System.Windows.Forms.GroupBox grpBoxPreview;
    private System.Windows.Forms.TabControl tabsPreview;
    private System.Windows.Forms.TabPage tabPreviewDeleteColumnsInfo;
    private System.Windows.Forms.TabPage tabPreviewDeleteColumnsVariance;
    private System.Windows.Forms.TabPage tabPreviewDeleteRowsInfo;
    private System.Windows.Forms.TabPage tabPreviewShuffle;
    private System.Windows.Forms.Label lblPreviewShuffle;
    private System.Windows.Forms.TabPage tabPreviewInactive;
    private System.Windows.Forms.Label lblPreviewColumnsInfo;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label lblPreviewColumnsVariance;
    private System.Windows.Forms.Label lblPreviewRowsInfo;
    private System.Windows.Forms.TabPage tabPreviewReplaceMissingValues;
    private System.Windows.Forms.Label lblPreviewReplaceMissingValues;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TabControl tabsData;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TabPage tabDataDeleteColumnsInformation;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtDeleteColumnsInfo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage tabDataDeleteColumnsVariance;
    private System.Windows.Forms.TextBox txtDeleteColumnsVariance;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TabPage tabDataDeleteRowsInfo;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtDeleteRowsInfo;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TabPage tabReplaceMissingValues;
    private System.Windows.Forms.TextBox txtReplaceValue;
    private System.Windows.Forms.ComboBox cmbReplaceWith;
    private System.Windows.Forms.Label lblValueColon;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TabPage tabDataShuffle;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox cmbVariableNames;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label lblPreviewInActive;
  }
}

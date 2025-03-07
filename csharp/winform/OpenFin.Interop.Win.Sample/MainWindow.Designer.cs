﻿
namespace OpenFin.Interop.Win.Sample
{
    partial class MainWindow
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.openFinStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.orderStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.receivedInstrument = new System.Windows.Forms.Label();
            this.contextGroupComboBox = new System.Windows.Forms.ComboBox();
            this.instrumentComboBox = new System.Windows.Forms.ComboBox();
            this.receivedContext = new System.Windows.Forms.Label();
            this.interopBrokerInput = new System.Windows.Forms.TextBox();
            this.submitContextButton = new System.Windows.Forms.Button();
            this.connectToBrokerButton = new System.Windows.Forms.Button();
            this.createBrokerButton = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFinStatusLabel,
            this.orderStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 518);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this.statusStrip.Size = new System.Drawing.Size(515, 32);
            this.statusStrip.TabIndex = 0;
            // 
            // openFinStatusLabel
            // 
            this.openFinStatusLabel.Name = "openFinStatusLabel";
            this.openFinStatusLabel.Size = new System.Drawing.Size(191, 25);
            this.openFinStatusLabel.Text = "OpenFin Disconnected";
            // 
            // orderStatusLabel
            // 
            this.orderStatusLabel.Name = "orderStatusLabel";
            this.orderStatusLabel.Size = new System.Drawing.Size(0, 25);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.42105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.57895F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.receivedInstrument, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.contextGroupComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.instrumentComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.receivedContext, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.interopBrokerInput, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 23);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 412);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instrument";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Context Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interop Broker";
            // 
            // receivedInstrument
            // 
            this.receivedInstrument.AutoSize = true;
            this.receivedInstrument.Location = new System.Drawing.Point(5, 246);
            this.receivedInstrument.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.receivedInstrument.Name = "receivedInstrument";
            this.receivedInstrument.Size = new System.Drawing.Size(172, 25);
            this.receivedInstrument.TabIndex = 3;
            this.receivedInstrument.Text = "Received Instrument";
            // 
            // contextGroupComboBox
            // 
            this.contextGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contextGroupComboBox.Enabled = false;
            this.contextGroupComboBox.FormattingEnabled = true;
            this.contextGroupComboBox.Items.AddRange(new object[] {
            "N/A"});
            this.contextGroupComboBox.Location = new System.Drawing.Point(235, 88);
            this.contextGroupComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.contextGroupComboBox.Name = "contextGroupComboBox";
            this.contextGroupComboBox.Size = new System.Drawing.Size(199, 33);
            this.contextGroupComboBox.TabIndex = 8;
            this.contextGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.contextGroupComboBox_SelectedIndexChanged);
            // 
            // instrumentComboBox
            // 
            this.instrumentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instrumentComboBox.FormattingEnabled = true;
            this.instrumentComboBox.Items.AddRange(new object[] {
            "AAPL",
            "CSCO",
            "IBM",
            "MSFT",
            "TSLA"
            });
            this.instrumentComboBox.Location = new System.Drawing.Point(235, 6);
            this.instrumentComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.instrumentComboBox.Name = "instrumentComboBox";
            this.instrumentComboBox.Size = new System.Drawing.Size(199, 33);
            this.instrumentComboBox.TabIndex = 11;
            // 
            // receivedContext
            // 
            this.receivedContext.AutoSize = true;
            this.receivedContext.Location = new System.Drawing.Point(235, 246);
            this.receivedContext.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.receivedContext.Name = "receivedContext";
            this.receivedContext.Size = new System.Drawing.Size(72, 25);
            this.receivedContext.TabIndex = 4;
            this.receivedContext.Text = "Not Set";
            // 
            // interopBrokerInput
            // 
            this.interopBrokerInput.Location = new System.Drawing.Point(233, 167);
            this.interopBrokerInput.Name = "interopBrokerInput";
            this.interopBrokerInput.PlaceholderText = "openfin-browser";
            this.interopBrokerInput.Size = new System.Drawing.Size(201, 31);
            this.interopBrokerInput.TabIndex = 12;
            this.interopBrokerInput.TextChanged += new System.EventHandler(this.interopBrokerInput_TextChanged);
            this.interopBrokerInput.Leave += new System.EventHandler(this.interopBrokerInput_Leave);
            // 
            // submitContextButton
            // 
            this.submitContextButton.Enabled = false;
            this.submitContextButton.Location = new System.Drawing.Point(337, 448);
            this.submitContextButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.submitContextButton.Name = "submitContextButton";
            this.submitContextButton.Size = new System.Drawing.Size(158, 44);
            this.submitContextButton.TabIndex = 2;
            this.submitContextButton.Text = "Submit Context";
            this.submitContextButton.UseVisualStyleBackColor = true;
            this.submitContextButton.Click += new System.EventHandler(this.submitContextButton_Click);
            // 
            // connectToBrokerButton
            // 
            this.connectToBrokerButton.Location = new System.Drawing.Point(20, 448);
            this.connectToBrokerButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.connectToBrokerButton.Name = "connectToBrokerButton";
            this.connectToBrokerButton.Size = new System.Drawing.Size(164, 44);
            this.connectToBrokerButton.TabIndex = 3;
            this.connectToBrokerButton.Text = "Connect To Broker";
            this.connectToBrokerButton.UseVisualStyleBackColor = true;
            this.connectToBrokerButton.Click += new System.EventHandler(this.connectToBrokerButton_Click);
            // 
            // createBrokerButton
            // 
            this.createBrokerButton.Enabled = false;
            this.createBrokerButton.Location = new System.Drawing.Point(192, 448);
            this.createBrokerButton.Name = "createBrokerButton";
            this.createBrokerButton.Size = new System.Drawing.Size(138, 44);
            this.createBrokerButton.TabIndex = 4;
            this.createBrokerButton.Text = "Create Broker";
            this.createBrokerButton.UseVisualStyleBackColor = true;
            this.createBrokerButton.Click += new System.EventHandler(this.createBrokerButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 550);
            this.Controls.Add(this.createBrokerButton);
            this.Controls.Add(this.connectToBrokerButton);
            this.Controls.Add(this.submitContextButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainWindow";
            this.Text = "Interop Instrument Example Tool";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel openFinStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel orderStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label receivedInstrument;
        private System.Windows.Forms.Label receivedContext;
        private System.Windows.Forms.ComboBox contextGroupComboBox;
        private System.Windows.Forms.Button submitContextButton;
        private System.Windows.Forms.Button connectToBrokerButton;
        private System.Windows.Forms.ComboBox instrumentComboBox;
        private System.Windows.Forms.TextBox interopBrokerInput;
        private System.Windows.Forms.Button createBrokerButton;
    }
}


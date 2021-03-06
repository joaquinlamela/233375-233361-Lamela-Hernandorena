﻿using System.Windows.Forms;

namespace UI
{
	partial class MainMenu
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnAddSentiment = new System.Windows.Forms.Button();
            this.btnAddEntity = new System.Windows.Forms.Button();
            this.btnAddPhrase = new System.Windows.Forms.Button();
            this.btnAddAlarm = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.btnAuthorReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddSentiment
            // 
            this.btnAddSentiment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSentiment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSentiment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddSentiment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddSentiment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddSentiment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSentiment.Location = new System.Drawing.Point(11, 345);
            this.btnAddSentiment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSentiment.Name = "btnAddSentiment";
            this.btnAddSentiment.Size = new System.Drawing.Size(284, 38);
            this.btnAddSentiment.TabIndex = 3;
            this.btnAddSentiment.UseVisualStyleBackColor = false;
            this.btnAddSentiment.Click += new System.EventHandler(this.btnAddSentiment_Click);
            // 
            // btnAddEntity
            // 
            this.btnAddEntity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddEntity.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEntity.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddEntity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddEntity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddEntity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEntity.Location = new System.Drawing.Point(12, 401);
            this.btnAddEntity.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEntity.Name = "btnAddEntity";
            this.btnAddEntity.Size = new System.Drawing.Size(284, 37);
            this.btnAddEntity.TabIndex = 4;
            this.btnAddEntity.UseVisualStyleBackColor = false;
            this.btnAddEntity.Click += new System.EventHandler(this.btnAddEntity_Click);
            // 
            // btnAddPhrase
            // 
            this.btnAddPhrase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPhrase.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPhrase.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddPhrase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddPhrase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddPhrase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPhrase.Location = new System.Drawing.Point(11, 461);
            this.btnAddPhrase.Name = "btnAddPhrase";
            this.btnAddPhrase.Size = new System.Drawing.Size(284, 35);
            this.btnAddPhrase.TabIndex = 5;
            this.btnAddPhrase.UseVisualStyleBackColor = false;
            this.btnAddPhrase.Click += new System.EventHandler(this.btnAddPhrase_Click);
            // 
            // btnAddAlarm
            // 
            this.btnAddAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAlarm.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAlarm.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddAlarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddAlarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAlarm.Location = new System.Drawing.Point(11, 519);
            this.btnAddAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAlarm.Name = "btnAddAlarm";
            this.btnAddAlarm.Size = new System.Drawing.Size(284, 38);
            this.btnAddAlarm.TabIndex = 6;
            this.btnAddAlarm.UseVisualStyleBackColor = false;
            this.btnAddAlarm.Click += new System.EventHandler(this.BtnAddAlarm_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMain.Location = new System.Drawing.Point(317, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(460, 638);
            this.panelMain.TabIndex = 6;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Location = new System.Drawing.Point(12, 575);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(284, 38);
            this.btnReport.TabIndex = 7;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(12, 38);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 52);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAuthors.BackColor = System.Drawing.Color.Transparent;
            this.btnAuthors.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAuthors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAuthors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuthors.Location = new System.Drawing.Point(11, 231);
            this.btnAuthors.Margin = new System.Windows.Forms.Padding(2);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(284, 35);
            this.btnAuthors.TabIndex = 1;
            this.btnAuthors.UseVisualStyleBackColor = false;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // btnAuthorReport
            // 
            this.btnAuthorReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAuthorReport.BackColor = System.Drawing.Color.Transparent;
            this.btnAuthorReport.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAuthorReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAuthorReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAuthorReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuthorReport.Location = new System.Drawing.Point(11, 289);
            this.btnAuthorReport.Name = "btnAuthorReport";
            this.btnAuthorReport.Size = new System.Drawing.Size(284, 37);
            this.btnAuthorReport.TabIndex = 2;
            this.btnAuthorReport.UseVisualStyleBackColor = false;
            this.btnAuthorReport.Click += new System.EventHandler(this.btnAuthorReport_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 638);
            this.Controls.Add(this.btnAuthorReport);
            this.Controls.Add(this.btnAuthors);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddSentiment);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnAddAlarm);
            this.Controls.Add(this.btnAddPhrase);
            this.Controls.Add(this.btnAddEntity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAddSentiment;
		private System.Windows.Forms.Button btnAddEntity;
		private System.Windows.Forms.Button btnAddPhrase;
		private System.Windows.Forms.Button btnAddAlarm;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button btnReport;
		private Button btnExit;
        private Button btnAuthors;
        private Button btnAuthorReport;
    }
}


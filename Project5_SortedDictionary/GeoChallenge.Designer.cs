////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Solution/Project:      Project 5 Associative Containers
//      File Name:             GeoChallenge.Designer.cs
//      Description:           Auto generate partial class for GeoChallenge winform designer   
//      Course:                Data Structures CSCI 2210-001 
//      Author:                Danelle Hennings, hennings@goldmail.etsu.edu
//      Created:               Tuesday April 19, 2016
//      Copyright:             Danelle Hennings, ETSU, 2016
//
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project5_SortedDictionary
{
    /// <summary>
    /// Auto generate partial class for GeoChallenge winform designer
    /// </summary>
    partial class GeoChallenge
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
            if (disposing && ( components != null ))
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoChallenge));
			this.lblSelectCap = new System.Windows.Forms.Label();
			this.lblWhatIs = new System.Windows.Forms.Label();
			this.capitalsListBox = new System.Windows.Forms.ListBox();
			this.countdown = new System.Windows.Forms.Timer(this.components);
			this.btnEndGame = new System.Windows.Forms.Button();
			this.btnNextQ = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.lblState = new System.Windows.Forms.Label();
			this.txtTimerCount = new System.Windows.Forms.RichTextBox();
			this.lblTimeLeft = new System.Windows.Forms.Label();
			this.lblNumCorrect = new System.Windows.Forms.Label();
			this.lblNumIncorrect = new System.Windows.Forms.Label();
			this.lblAttempts = new System.Windows.Forms.Label();
			this.lblCorrect = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblSelectCap
			// 
			this.lblSelectCap.AutoSize = true;
			this.lblSelectCap.BackColor = System.Drawing.Color.Transparent;
			this.lblSelectCap.CausesValidation = false;
			this.lblSelectCap.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSelectCap.Location = new System.Drawing.Point(402, 8);
			this.lblSelectCap.Name = "lblSelectCap";
			this.lblSelectCap.Size = new System.Drawing.Size(124, 17);
			this.lblSelectCap.TabIndex = 25;
			this.lblSelectCap.Text = "Select the Capital";
			// 
			// lblWhatIs
			// 
			this.lblWhatIs.AutoSize = true;
			this.lblWhatIs.BackColor = System.Drawing.Color.Transparent;
			this.lblWhatIs.CausesValidation = false;
			this.lblWhatIs.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
			this.lblWhatIs.Location = new System.Drawing.Point(29, 27);
			this.lblWhatIs.Name = "lblWhatIs";
			this.lblWhatIs.Size = new System.Drawing.Size(176, 20);
			this.lblWhatIs.TabIndex = 24;
			this.lblWhatIs.Text = "What is the capital of:";
			// 
			// capitalsListBox
			// 
			this.capitalsListBox.BackColor = System.Drawing.SystemColors.Control;
			this.capitalsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.capitalsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.capitalsListBox.FormattingEnabled = true;
			this.capitalsListBox.ItemHeight = 16;
			this.capitalsListBox.Location = new System.Drawing.Point(395, 25);
			this.capitalsListBox.Name = "capitalsListBox";
			this.capitalsListBox.Size = new System.Drawing.Size(131, 194);
			this.capitalsListBox.Sorted = true;
			this.capitalsListBox.TabIndex = 20;
			this.capitalsListBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.capitalsListBox_PreviewKeyDown);
			// 
			// countdown
			// 
			this.countdown.Interval = 1000;
			this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
			// 
			// btnEndGame
			// 
			this.btnEndGame.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnEndGame.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEndGame.Location = new System.Drawing.Point(32, 219);
			this.btnEndGame.Name = "btnEndGame";
			this.btnEndGame.Size = new System.Drawing.Size(100, 40);
			this.btnEndGame.TabIndex = 32;
			this.btnEndGame.Text = "Exit";
			this.btnEndGame.UseVisualStyleBackColor = true;
			this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
			// 
			// btnNextQ
			// 
			this.btnNextQ.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnNextQ.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNextQ.Location = new System.Drawing.Point(232, 219);
			this.btnNextQ.Name = "btnNextQ";
			this.btnNextQ.Size = new System.Drawing.Size(100, 40);
			this.btnNextQ.TabIndex = 33;
			this.btnNextQ.Text = "Continue";
			this.btnNextQ.UseVisualStyleBackColor = true;
			this.btnNextQ.Click += new System.EventHandler(this.btnNextQ_Click);
			// 
			// btnSubmit
			// 
			this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmit.Location = new System.Drawing.Point(414, 219);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(100, 40);
			this.btnSubmit.TabIndex = 34;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// lblState
			// 
			this.lblState.BackColor = System.Drawing.Color.Gainsboro;
			this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblState.CausesValidation = false;
			this.lblState.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblState.Location = new System.Drawing.Point(211, 23);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(168, 28);
			this.lblState.TabIndex = 35;
			// 
			// txtTimerCount
			// 
			this.txtTimerCount.CausesValidation = false;
			this.txtTimerCount.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtTimerCount.Enabled = false;
			this.txtTimerCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimerCount.ForeColor = System.Drawing.Color.Maroon;
			this.txtTimerCount.Location = new System.Drawing.Point(243, 85);
			this.txtTimerCount.Multiline = false;
			this.txtTimerCount.Name = "txtTimerCount";
			this.txtTimerCount.ReadOnly = true;
			this.txtTimerCount.Size = new System.Drawing.Size(45, 31);
			this.txtTimerCount.TabIndex = 36;
			this.txtTimerCount.TabStop = false;
			this.txtTimerCount.Text = " 15";
			// 
			// lblTimeLeft
			// 
			this.lblTimeLeft.AutoSize = true;
			this.lblTimeLeft.BackColor = System.Drawing.Color.Transparent;
			this.lblTimeLeft.CausesValidation = false;
			this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimeLeft.Location = new System.Drawing.Point(82, 89);
			this.lblTimeLeft.Name = "lblTimeLeft";
			this.lblTimeLeft.Size = new System.Drawing.Size(159, 19);
			this.lblTimeLeft.TabIndex = 37;
			this.lblTimeLeft.Text = "Time Left to Answer:";
			// 
			// lblNumCorrect
			// 
			this.lblNumCorrect.BackColor = System.Drawing.Color.Gainsboro;
			this.lblNumCorrect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblNumCorrect.CausesValidation = false;
			this.lblNumCorrect.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumCorrect.Location = new System.Drawing.Point(231, 167);
			this.lblNumCorrect.Name = "lblNumCorrect";
			this.lblNumCorrect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblNumCorrect.Size = new System.Drawing.Size(50, 19);
			this.lblNumCorrect.TabIndex = 41;
			this.lblNumCorrect.Text = "0        ";
			this.lblNumCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblNumIncorrect
			// 
			this.lblNumIncorrect.BackColor = System.Drawing.Color.Gainsboro;
			this.lblNumIncorrect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblNumIncorrect.CausesValidation = false;
			this.lblNumIncorrect.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumIncorrect.Location = new System.Drawing.Point(94, 167);
			this.lblNumIncorrect.Name = "lblNumIncorrect";
			this.lblNumIncorrect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblNumIncorrect.Size = new System.Drawing.Size(50, 19);
			this.lblNumIncorrect.TabIndex = 40;
			this.lblNumIncorrect.Text = "0        ";
			this.lblNumIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblAttempts
			// 
			this.lblAttempts.AutoSize = true;
			this.lblAttempts.BackColor = System.Drawing.Color.Transparent;
			this.lblAttempts.CausesValidation = false;
			this.lblAttempts.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAttempts.Location = new System.Drawing.Point(82, 140);
			this.lblAttempts.Name = "lblAttempts";
			this.lblAttempts.Size = new System.Drawing.Size(75, 19);
			this.lblAttempts.TabIndex = 39;
			this.lblAttempts.Text = "Incorrect";
			// 
			// lblCorrect
			// 
			this.lblCorrect.AutoSize = true;
			this.lblCorrect.BackColor = System.Drawing.Color.Transparent;
			this.lblCorrect.CausesValidation = false;
			this.lblCorrect.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCorrect.Location = new System.Drawing.Point(224, 140);
			this.lblCorrect.Name = "lblCorrect";
			this.lblCorrect.Size = new System.Drawing.Size(64, 19);
			this.lblCorrect.TabIndex = 38;
			this.lblCorrect.Text = "Correct";
			// 
			// GeoChallenge
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Project5_SortedDictionary.Properties.Resources.US_Mapx;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(545, 271);
			this.Controls.Add(this.lblNumCorrect);
			this.Controls.Add(this.lblNumIncorrect);
			this.Controls.Add(this.lblAttempts);
			this.Controls.Add(this.lblCorrect);
			this.Controls.Add(this.txtTimerCount);
			this.Controls.Add(this.lblTimeLeft);
			this.Controls.Add(this.lblState);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.btnNextQ);
			this.Controls.Add(this.btnEndGame);
			this.Controls.Add(this.lblSelectCap);
			this.Controls.Add(this.lblWhatIs);
			this.Controls.Add(this.capitalsListBox);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "GeoChallenge";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "U.S. Geography Challenge -- State Capital Matching";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeoChallenge_FormClosed);
			this.Load += new System.EventHandler(this.GeoChallenge_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelectCap;
        private System.Windows.Forms.Label lblWhatIs;
        private System.Windows.Forms.ListBox capitalsListBox;
        private System.Windows.Forms.Timer countdown;
		private System.Windows.Forms.Button btnEndGame;
		private System.Windows.Forms.Button btnNextQ;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.RichTextBox txtTimerCount;
		private System.Windows.Forms.Label lblTimeLeft;
		private System.Windows.Forms.Label lblNumCorrect;
		private System.Windows.Forms.Label lblNumIncorrect;
		private System.Windows.Forms.Label lblAttempts;
		private System.Windows.Forms.Label lblCorrect;
	}
}
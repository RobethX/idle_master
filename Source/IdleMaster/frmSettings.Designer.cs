﻿using System.ComponentModel;
using System.Windows.Forms;

namespace IdleMaster
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.chkShowUsername = new System.Windows.Forms.CheckBox();
            this.chkIgnoreClientStatus = new System.Windows.Forms.CheckBox();
            this.chkMinToTray = new System.Windows.Forms.CheckBox();
            this.grpPriority = new System.Windows.Forms.GroupBox();
            this.radIdleMostValue = new System.Windows.Forms.RadioButton();
            this.radIdleLeastDrops = new System.Windows.Forms.RadioButton();
            this.radIdleMostDrops = new System.Windows.Forms.RadioButton();
            this.radIdleDefault = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ttHints = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.grpIdlingQuantity = new System.Windows.Forms.GroupBox();
            this.chkOnlyIdlePlayed = new System.Windows.Forms.CheckBox();
            this.lblMaskID = new System.Windows.Forms.Label();
            this.txtMaskGameID = new System.Windows.Forms.TextBox();
            this.chkMaskGame = new System.Windows.Forms.CheckBox();
            this.radOneThenMany = new System.Windows.Forms.RadioButton();
            this.radManyThenOne = new System.Windows.Forms.RadioButton();
            this.radOneGameOnly = new System.Windows.Forms.RadioButton();
            this.grpGeneral.SuspendLayout();
            this.grpPriority.SuspendLayout();
            this.grpIdlingQuantity.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGeneral
            // 
            this.grpGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGeneral.Controls.Add(this.cboLanguage);
            this.grpGeneral.Controls.Add(this.lblLanguage);
            this.grpGeneral.Controls.Add(this.chkShowUsername);
            this.grpGeneral.Controls.Add(this.chkIgnoreClientStatus);
            this.grpGeneral.Controls.Add(this.chkMinToTray);
            this.grpGeneral.Location = new System.Drawing.Point(30, 29);
            this.grpGeneral.Margin = new System.Windows.Forms.Padding(7);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Padding = new System.Windows.Forms.Padding(7);
            this.grpGeneral.Size = new System.Drawing.Size(915, 236);
            this.grpGeneral.TabIndex = 0;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "English",
            "Chinese (Simplified, China)",
            "Chinese (Traditional, China)",
            "Czech",
            "Dutch",
            "Finnish",
            "French",
            "German",
            "Greek",
            "Hungarian",
            "Italian",
            "Japanese",
            "Korean",
            "Norwegian",
            "Polish",
            "Portuguese",
            "Portuguese (Brazil)",
            "Romanian",
            "Russian",
            "Spanish",
            "Swedish",
            "Thai",
            "Turkish",
            "Ukrainian"});
            this.cboLanguage.Location = new System.Drawing.Point(315, 170);
            this.cboLanguage.Margin = new System.Windows.Forms.Padding(7);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(438, 37);
            this.cboLanguage.TabIndex = 4;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(61, 176);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(224, 29);
            this.lblLanguage.TabIndex = 3;
            this.lblLanguage.Text = "Interface Language:";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkShowUsername
            // 
            this.chkShowUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowUsername.Location = new System.Drawing.Point(19, 123);
            this.chkShowUsername.Margin = new System.Windows.Forms.Padding(7);
            this.chkShowUsername.Name = "chkShowUsername";
            this.chkShowUsername.Size = new System.Drawing.Size(882, 42);
            this.chkShowUsername.TabIndex = 2;
            this.chkShowUsername.Text = "Show Steam username of signed on user";
            this.chkShowUsername.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreClientStatus
            // 
            this.chkIgnoreClientStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIgnoreClientStatus.Location = new System.Drawing.Point(19, 85);
            this.chkIgnoreClientStatus.Margin = new System.Windows.Forms.Padding(7);
            this.chkIgnoreClientStatus.Name = "chkIgnoreClientStatus";
            this.chkIgnoreClientStatus.Size = new System.Drawing.Size(882, 38);
            this.chkIgnoreClientStatus.TabIndex = 1;
            this.chkIgnoreClientStatus.Text = "Ignore Steam client status";
            this.chkIgnoreClientStatus.UseVisualStyleBackColor = true;
            // 
            // chkMinToTray
            // 
            this.chkMinToTray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMinToTray.Location = new System.Drawing.Point(19, 42);
            this.chkMinToTray.Margin = new System.Windows.Forms.Padding(7);
            this.chkMinToTray.Name = "chkMinToTray";
            this.chkMinToTray.Size = new System.Drawing.Size(882, 38);
            this.chkMinToTray.TabIndex = 0;
            this.chkMinToTray.Text = "Minimize Idle Master to system tray";
            this.chkMinToTray.UseVisualStyleBackColor = true;
            // 
            // grpPriority
            // 
            this.grpPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPriority.Controls.Add(this.radIdleMostValue);
            this.grpPriority.Controls.Add(this.radIdleLeastDrops);
            this.grpPriority.Controls.Add(this.radIdleMostDrops);
            this.grpPriority.Controls.Add(this.radIdleDefault);
            this.grpPriority.Location = new System.Drawing.Point(30, 587);
            this.grpPriority.Margin = new System.Windows.Forms.Padding(7);
            this.grpPriority.Name = "grpPriority";
            this.grpPriority.Padding = new System.Windows.Forms.Padding(7);
            this.grpPriority.Size = new System.Drawing.Size(915, 216);
            this.grpPriority.TabIndex = 1;
            this.grpPriority.TabStop = false;
            this.grpPriority.Text = "Idling Order";
            // 
            // radIdleMostValue
            // 
            this.radIdleMostValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radIdleMostValue.Location = new System.Drawing.Point(16, 78);
            this.radIdleMostValue.Margin = new System.Windows.Forms.Padding(7);
            this.radIdleMostValue.Name = "radIdleMostValue";
            this.radIdleMostValue.Size = new System.Drawing.Size(884, 38);
            this.radIdleMostValue.TabIndex = 3;
            this.radIdleMostValue.TabStop = true;
            this.radIdleMostValue.Text = "Prioritize games with the highest card values";
            this.radIdleMostValue.UseVisualStyleBackColor = true;
            // 
            // radIdleLeastDrops
            // 
            this.radIdleLeastDrops.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radIdleLeastDrops.Location = new System.Drawing.Point(16, 154);
            this.radIdleLeastDrops.Margin = new System.Windows.Forms.Padding(7);
            this.radIdleLeastDrops.Name = "radIdleLeastDrops";
            this.radIdleLeastDrops.Size = new System.Drawing.Size(884, 38);
            this.radIdleLeastDrops.TabIndex = 2;
            this.radIdleLeastDrops.Text = "Prioritize games with the lowest number of available drops";
            this.radIdleLeastDrops.UseVisualStyleBackColor = true;
            // 
            // radIdleMostDrops
            // 
            this.radIdleMostDrops.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radIdleMostDrops.Location = new System.Drawing.Point(16, 116);
            this.radIdleMostDrops.Margin = new System.Windows.Forms.Padding(7);
            this.radIdleMostDrops.Name = "radIdleMostDrops";
            this.radIdleMostDrops.Size = new System.Drawing.Size(884, 38);
            this.radIdleMostDrops.TabIndex = 1;
            this.radIdleMostDrops.Text = "Prioritize games with the highest number of available drops";
            this.radIdleMostDrops.UseVisualStyleBackColor = true;
            // 
            // radIdleDefault
            // 
            this.radIdleDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radIdleDefault.Checked = true;
            this.radIdleDefault.Location = new System.Drawing.Point(16, 40);
            this.radIdleDefault.Margin = new System.Windows.Forms.Padding(7);
            this.radIdleDefault.Name = "radIdleDefault";
            this.radIdleDefault.Size = new System.Drawing.Size(884, 38);
            this.radIdleDefault.TabIndex = 0;
            this.radIdleDefault.TabStop = true;
            this.radIdleDefault.Text = "Default (Alphabetical Order)";
            this.radIdleDefault.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(770, 824);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 51);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(581, 824);
            this.btnOK.Margin = new System.Windows.Forms.Padding(7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(175, 51);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&Accept";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdvanced.Image = global::IdleMaster.Properties.Resources.imgLock;
            this.btnAdvanced.Location = new System.Drawing.Point(28, 824);
            this.btnAdvanced.Margin = new System.Windows.Forms.Padding(7);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(58, 51);
            this.btnAdvanced.TabIndex = 4;
            this.ttHints.SetToolTip(this.btnAdvanced, "Display advanced authentication information");
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // grpIdlingQuantity
            // 
            this.grpIdlingQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpIdlingQuantity.Controls.Add(this.chkOnlyIdlePlayed);
            this.grpIdlingQuantity.Controls.Add(this.lblMaskID);
            this.grpIdlingQuantity.Controls.Add(this.txtMaskGameID);
            this.grpIdlingQuantity.Controls.Add(this.chkMaskGame);
            this.grpIdlingQuantity.Controls.Add(this.radOneThenMany);
            this.grpIdlingQuantity.Controls.Add(this.radManyThenOne);
            this.grpIdlingQuantity.Controls.Add(this.radOneGameOnly);
            this.grpIdlingQuantity.Location = new System.Drawing.Point(30, 277);
            this.grpIdlingQuantity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpIdlingQuantity.Name = "grpIdlingQuantity";
            this.grpIdlingQuantity.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpIdlingQuantity.Size = new System.Drawing.Size(915, 299);
            this.grpIdlingQuantity.TabIndex = 5;
            this.grpIdlingQuantity.TabStop = false;
            this.grpIdlingQuantity.Text = "Idling Behavior";
            // 
            // chkOnlyIdlePlayed
            // 
            this.chkOnlyIdlePlayed.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.chkOnlyIdlePlayed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOnlyIdlePlayed.Location = new System.Drawing.Point(16, 153);
            this.chkOnlyIdlePlayed.Margin = new System.Windows.Forms.Padding(7);
            this.chkOnlyIdlePlayed.Name = "chkOnlyIdlePlayed";
            this.chkOnlyIdlePlayed.Size = new System.Drawing.Size(882, 42);
            this.chkOnlyIdlePlayed.TabIndex = 8;
            this.chkOnlyIdlePlayed.Text = "Only idle games you\'ve played\r\n";
            this.chkOnlyIdlePlayed.UseVisualStyleBackColor = true;
            this.chkOnlyIdlePlayed.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblMaskID
            // 
            this.lblMaskID.AutoSize = true;
            this.lblMaskID.Location = new System.Drawing.Point(54, 240);
            this.lblMaskID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMaskID.Name = "lblMaskID";
            this.lblMaskID.Size = new System.Drawing.Size(243, 29);
            this.lblMaskID.TabIndex = 5;
            this.lblMaskID.Text = "Masking game appid:";
            this.lblMaskID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMaskID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaskGameID
            // 
            this.txtMaskGameID.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtMaskGameID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaskGameID.Enabled = false;
            this.txtMaskGameID.Location = new System.Drawing.Point(315, 237);
            this.txtMaskGameID.Margin = new System.Windows.Forms.Padding(7);
            this.txtMaskGameID.Name = "txtMaskGameID";
            this.txtMaskGameID.Size = new System.Drawing.Size(438, 35);
            this.txtMaskGameID.TabIndex = 7;
            // 
            // chkMaskGame
            // 
            this.chkMaskGame.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.chkMaskGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMaskGame.Location = new System.Drawing.Point(16, 191);
            this.chkMaskGame.Margin = new System.Windows.Forms.Padding(7);
            this.chkMaskGame.Name = "chkMaskGame";
            this.chkMaskGame.Size = new System.Drawing.Size(882, 42);
            this.chkMaskGame.TabIndex = 5;
            this.chkMaskGame.Text = "Hide idled games with a mask game\r\n";
            this.chkMaskGame.UseVisualStyleBackColor = true;
            this.chkMaskGame.CheckedChanged += new System.EventHandler(this.chkMaskGame_CheckStateChanged);
            // 
            // radOneThenMany
            // 
            this.radOneThenMany.AutoSize = true;
            this.radOneThenMany.Location = new System.Drawing.Point(16, 118);
            this.radOneThenMany.Margin = new System.Windows.Forms.Padding(7);
            this.radOneThenMany.Name = "radOneThenMany";
            this.radOneThenMany.Size = new System.Drawing.Size(758, 33);
            this.radOneThenMany.TabIndex = 6;
            this.radOneThenMany.TabStop = true;
            this.radOneThenMany.Text = "Idle games with more than 2 hours individually, then simultaneously";
            this.radOneThenMany.UseVisualStyleBackColor = true;
            // 
            // radManyThenOne
            // 
            this.radManyThenOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radManyThenOne.Location = new System.Drawing.Point(16, 78);
            this.radManyThenOne.Margin = new System.Windows.Forms.Padding(7);
            this.radManyThenOne.Name = "radManyThenOne";
            this.radManyThenOne.Size = new System.Drawing.Size(884, 38);
            this.radManyThenOne.TabIndex = 5;
            this.radManyThenOne.TabStop = true;
            this.radManyThenOne.Text = "Idle games simultaneously up to 2 hours, then individually";
            this.radManyThenOne.UseVisualStyleBackColor = true;
            // 
            // radOneGameOnly
            // 
            this.radOneGameOnly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radOneGameOnly.Checked = true;
            this.radOneGameOnly.Location = new System.Drawing.Point(16, 40);
            this.radOneGameOnly.Margin = new System.Windows.Forms.Padding(7);
            this.radOneGameOnly.Name = "radOneGameOnly";
            this.radOneGameOnly.Size = new System.Drawing.Size(884, 38);
            this.radOneGameOnly.TabIndex = 4;
            this.radOneGameOnly.TabStop = true;
            this.radOneGameOnly.Text = "Idle each game individually";
            this.radOneGameOnly.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(973, 902);
            this.Controls.Add(this.grpIdlingQuantity);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpPriority);
            this.Controls.Add(this.grpGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Idle Master Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpPriority.ResumeLayout(false);
            this.grpIdlingQuantity.ResumeLayout(false);
            this.grpIdlingQuantity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpGeneral;
        private CheckBox chkMinToTray;
        private GroupBox grpPriority;
        private RadioButton radIdleLeastDrops;
        private RadioButton radIdleMostDrops;
        private RadioButton radIdleDefault;
        private Button btnCancel;
        private Button btnOK;
        private RadioButton radIdleMostValue;
        private Button btnAdvanced;
        private ToolTip ttHints;
        private CheckBox chkIgnoreClientStatus;
        private CheckBox chkShowUsername;
        private CheckBox chkMaskGame;
        private CheckBox chkOnlyIdlePlayed;
        private TextBox txtMaskGameID;
    private GroupBox grpIdlingQuantity;
    private RadioButton radManyThenOne;
    private RadioButton radOneGameOnly;
    private ComboBox cboLanguage;
    private Label lblLanguage;
    private RadioButton radOneThenMany;
        private Label lblMaskID;
    }
}
namespace OoTMM_Item_Hints_Overhaul
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imgCoinYellow = new PictureBox();
            numCoinYellow = new NumericUpDown();
            lblXYellow = new Label();
            imgCoinRed = new PictureBox();
            numCoinRed = new NumericUpDown();
            lblXRed = new Label();
            imgCoinBlue = new PictureBox();
            numCoinBlue = new NumericUpDown();
            lblXBlue = new Label();
            label3 = new Label();
            lblHintsClick = new Label();
            imgCoinGreen = new PictureBox();
            numCoinGreen = new NumericUpDown();
            lblXGreen = new Label();
            imgCoinBig = new PictureBox();
            btnBack = new Button();
            lblCoinFound = new Label();
            lblCoinSpent = new Label();
            lblHint = new Label();
            lblHintNumber = new Label();
            btnHintNextRight = new Button();
            cmbSelection = new ComboBox();
            btnCoinSpend = new Button();
            lblSpoiler = new Label();
            btnSpoiler = new Button();
            lblFound = new Label();
            lblSpent = new Label();
            btnReset = new Button();
            btnHintNextLeft = new Button();
            ((System.ComponentModel.ISupportInitialize)imgCoinYellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCoinYellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCoinRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCoinRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCoinBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCoinBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCoinGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCoinGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCoinBig).BeginInit();
            SuspendLayout();
            // 
            // imgCoinYellow
            // 
            imgCoinYellow.BackgroundImage = (Image)resources.GetObject("imgCoinYellow.BackgroundImage");
            imgCoinYellow.Cursor = Cursors.Hand;
            imgCoinYellow.Location = new Point(169, 95);
            imgCoinYellow.Name = "imgCoinYellow";
            imgCoinYellow.Size = new Size(64, 64);
            imgCoinYellow.TabIndex = 25;
            imgCoinYellow.TabStop = false;
            imgCoinYellow.Click += imgCoinYellow_Click;
            // 
            // numCoinYellow
            // 
            numCoinYellow.BackColor = Color.FromArgb(125, 0, 205);
            numCoinYellow.BorderStyle = BorderStyle.None;
            numCoinYellow.Font = new Font("Hylia Serif Beta", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            numCoinYellow.ForeColor = SystemColors.ButtonFace;
            numCoinYellow.Location = new Point(251, 106);
            numCoinYellow.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numCoinYellow.Name = "numCoinYellow";
            numCoinYellow.ReadOnly = true;
            numCoinYellow.Size = new Size(62, 42);
            numCoinYellow.TabIndex = 2;
            numCoinYellow.TabStop = false;
            numCoinYellow.Tag = "";
            numCoinYellow.TextAlign = HorizontalAlignment.Center;
            numCoinYellow.ValueChanged += numCoinYellow_ValueChanged;
            numCoinYellow.Click += numCoinYellow_Click;
            numCoinYellow.Enter += numCoinYellow_Enter;
            // 
            // lblXYellow
            // 
            lblXYellow.AutoSize = true;
            lblXYellow.BackColor = Color.Transparent;
            lblXYellow.Font = new Font("Hylia Serif Beta", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            lblXYellow.ForeColor = SystemColors.ButtonFace;
            lblXYellow.Location = new Point(227, 105);
            lblXYellow.Name = "lblXYellow";
            lblXYellow.Size = new Size(35, 39);
            lblXYellow.TabIndex = 1;
            lblXYellow.Text = "x";
            // 
            // imgCoinRed
            // 
            imgCoinRed.BackgroundImage = (Image)resources.GetObject("imgCoinRed.BackgroundImage");
            imgCoinRed.Cursor = Cursors.Hand;
            imgCoinRed.Location = new Point(394, 95);
            imgCoinRed.Name = "imgCoinRed";
            imgCoinRed.Size = new Size(64, 64);
            imgCoinRed.TabIndex = 28;
            imgCoinRed.TabStop = false;
            imgCoinRed.Click += imgCoinRed_Click;
            // 
            // numCoinRed
            // 
            numCoinRed.BackColor = Color.FromArgb(125, 0, 205);
            numCoinRed.BorderStyle = BorderStyle.None;
            numCoinRed.Font = new Font("Hylia Serif Beta", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            numCoinRed.ForeColor = SystemColors.ButtonFace;
            numCoinRed.Location = new Point(476, 106);
            numCoinRed.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numCoinRed.Name = "numCoinRed";
            numCoinRed.ReadOnly = true;
            numCoinRed.Size = new Size(62, 42);
            numCoinRed.TabIndex = 27;
            numCoinRed.TabStop = false;
            numCoinRed.Tag = "";
            numCoinRed.TextAlign = HorizontalAlignment.Center;
            numCoinRed.ValueChanged += numCoinRed_ValueChanged;
            numCoinRed.Click += numCoinRed_Click;
            numCoinRed.Enter += numCoinRed_Enter;
            // 
            // lblXRed
            // 
            lblXRed.AutoSize = true;
            lblXRed.BackColor = Color.Transparent;
            lblXRed.Font = new Font("Hylia Serif Beta", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            lblXRed.ForeColor = SystemColors.ButtonFace;
            lblXRed.Location = new Point(452, 105);
            lblXRed.Name = "lblXRed";
            lblXRed.Size = new Size(35, 39);
            lblXRed.TabIndex = 26;
            lblXRed.Text = "x";
            // 
            // imgCoinBlue
            // 
            imgCoinBlue.BackgroundImage = (Image)resources.GetObject("imgCoinBlue.BackgroundImage");
            imgCoinBlue.Cursor = Cursors.Hand;
            imgCoinBlue.Location = new Point(169, 161);
            imgCoinBlue.Name = "imgCoinBlue";
            imgCoinBlue.Size = new Size(64, 64);
            imgCoinBlue.TabIndex = 31;
            imgCoinBlue.TabStop = false;
            imgCoinBlue.Click += imgCoinBlue_Click;
            // 
            // numCoinBlue
            // 
            numCoinBlue.BackColor = Color.FromArgb(125, 0, 205);
            numCoinBlue.BorderStyle = BorderStyle.None;
            numCoinBlue.Font = new Font("Hylia Serif Beta", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            numCoinBlue.ForeColor = SystemColors.ButtonFace;
            numCoinBlue.Location = new Point(251, 172);
            numCoinBlue.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numCoinBlue.Name = "numCoinBlue";
            numCoinBlue.ReadOnly = true;
            numCoinBlue.Size = new Size(62, 42);
            numCoinBlue.TabIndex = 30;
            numCoinBlue.TabStop = false;
            numCoinBlue.Tag = "";
            numCoinBlue.TextAlign = HorizontalAlignment.Center;
            numCoinBlue.ValueChanged += numCoinBlue_ValueChanged;
            numCoinBlue.Click += numCoinBlue_Click;
            numCoinBlue.Enter += numCoinBlue_Enter;
            // 
            // lblXBlue
            // 
            lblXBlue.AutoSize = true;
            lblXBlue.BackColor = Color.Transparent;
            lblXBlue.Font = new Font("Hylia Serif Beta", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            lblXBlue.ForeColor = SystemColors.ButtonFace;
            lblXBlue.Location = new Point(227, 171);
            lblXBlue.Name = "lblXBlue";
            lblXBlue.Size = new Size(35, 39);
            lblXBlue.TabIndex = 29;
            lblXBlue.Text = "x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Hylia Serif Beta", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(84, 12);
            label3.Name = "label3";
            label3.Size = new Size(566, 57);
            label3.TabIndex = 0;
            label3.Text = "OoTMM Coins for Hints ";
            // 
            // lblHintsClick
            // 
            lblHintsClick.AutoSize = true;
            lblHintsClick.BackColor = Color.Transparent;
            lblHintsClick.Font = new Font("Hylia Serif Beta", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            lblHintsClick.ForeColor = SystemColors.ActiveCaptionText;
            lblHintsClick.Location = new Point(154, 231);
            lblHintsClick.Name = "lblHintsClick";
            lblHintsClick.Size = new Size(417, 25);
            lblHintsClick.TabIndex = 32;
            lblHintsClick.Text = "Click a Coin to see what Hints it can give!";
            // 
            // imgCoinGreen
            // 
            imgCoinGreen.BackgroundImage = (Image)resources.GetObject("imgCoinGreen.BackgroundImage");
            imgCoinGreen.Cursor = Cursors.Hand;
            imgCoinGreen.Location = new Point(394, 161);
            imgCoinGreen.Name = "imgCoinGreen";
            imgCoinGreen.Size = new Size(64, 64);
            imgCoinGreen.TabIndex = 35;
            imgCoinGreen.TabStop = false;
            imgCoinGreen.Click += imgCoinGreen_Click;
            // 
            // numCoinGreen
            // 
            numCoinGreen.BackColor = Color.FromArgb(125, 0, 205);
            numCoinGreen.BorderStyle = BorderStyle.None;
            numCoinGreen.Font = new Font("Hylia Serif Beta", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            numCoinGreen.ForeColor = SystemColors.ButtonFace;
            numCoinGreen.Location = new Point(476, 172);
            numCoinGreen.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numCoinGreen.Name = "numCoinGreen";
            numCoinGreen.ReadOnly = true;
            numCoinGreen.Size = new Size(62, 42);
            numCoinGreen.TabIndex = 34;
            numCoinGreen.TabStop = false;
            numCoinGreen.Tag = "";
            numCoinGreen.TextAlign = HorizontalAlignment.Center;
            numCoinGreen.ValueChanged += numCoinGreen_ValueChanged;
            numCoinGreen.Click += numCoinGreen_Click;
            numCoinGreen.Enter += numCoinGreen_Enter;
            // 
            // lblXGreen
            // 
            lblXGreen.AutoSize = true;
            lblXGreen.BackColor = Color.Transparent;
            lblXGreen.Font = new Font("Hylia Serif Beta", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            lblXGreen.ForeColor = SystemColors.ButtonFace;
            lblXGreen.Location = new Point(452, 171);
            lblXGreen.Name = "lblXGreen";
            lblXGreen.Size = new Size(35, 39);
            lblXGreen.TabIndex = 33;
            lblXGreen.Text = "x";
            // 
            // imgCoinBig
            // 
            imgCoinBig.BackgroundImage = Properties.Resources.coin_yellow_big_purple;
            imgCoinBig.Enabled = false;
            imgCoinBig.Location = new Point(7, 100);
            imgCoinBig.Name = "imgCoinBig";
            imgCoinBig.Size = new Size(96, 96);
            imgCoinBig.TabIndex = 36;
            imgCoinBig.TabStop = false;
            imgCoinBig.Visible = false;
            // 
            // btnBack
            // 
            btnBack.Enabled = false;
            btnBack.Font = new Font("Hylia Serif Beta", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(626, 227);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(87, 32);
            btnBack.TabIndex = 37;
            btnBack.Text = "Back ▶";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Visible = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblCoinFound
            // 
            lblCoinFound.AutoSize = true;
            lblCoinFound.BackColor = Color.Transparent;
            lblCoinFound.Enabled = false;
            lblCoinFound.Font = new Font("Hylia Serif Beta", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            lblCoinFound.ForeColor = SystemColors.ButtonFace;
            lblCoinFound.Location = new Point(99, 109);
            lblCoinFound.Name = "lblCoinFound";
            lblCoinFound.Size = new Size(63, 39);
            lblCoinFound.TabIndex = 38;
            lblCoinFound.Text = "x 0";
            lblCoinFound.Visible = false;
            // 
            // lblCoinSpent
            // 
            lblCoinSpent.AutoSize = true;
            lblCoinSpent.BackColor = Color.Transparent;
            lblCoinSpent.Enabled = false;
            lblCoinSpent.Font = new Font("Hylia Serif Beta", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            lblCoinSpent.ForeColor = SystemColors.ButtonFace;
            lblCoinSpent.Location = new Point(99, 145);
            lblCoinSpent.Name = "lblCoinSpent";
            lblCoinSpent.Size = new Size(63, 39);
            lblCoinSpent.TabIndex = 39;
            lblCoinSpent.Text = "x 0";
            lblCoinSpent.Visible = false;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.BackColor = Color.Transparent;
            lblHint.BorderStyle = BorderStyle.Fixed3D;
            lblHint.Enabled = false;
            lblHint.Font = new Font("Hylia Serif Beta", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lblHint.ForeColor = Color.Silver;
            lblHint.Location = new Point(7, 196);
            lblHint.MaximumSize = new Size(705, 25);
            lblHint.MinimumSize = new Size(705, 25);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(705, 25);
            lblHint.TabIndex = 41;
            lblHint.Text = "Spend 1 Yellow Coin and select a location to see what it hides!";
            lblHint.TextAlign = ContentAlignment.MiddleCenter;
            lblHint.Visible = false;
            // 
            // lblHintNumber
            // 
            lblHintNumber.AutoSize = true;
            lblHintNumber.BackColor = Color.Transparent;
            lblHintNumber.Enabled = false;
            lblHintNumber.Font = new Font("Hylia Serif Beta", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblHintNumber.ForeColor = SystemColors.ButtonFace;
            lblHintNumber.Location = new Point(298, 227);
            lblHintNumber.MaximumSize = new Size(110, 30);
            lblHintNumber.MinimumSize = new Size(110, 30);
            lblHintNumber.Name = "lblHintNumber";
            lblHintNumber.Size = new Size(110, 30);
            lblHintNumber.TabIndex = 42;
            lblHintNumber.Text = "1 of 1";
            lblHintNumber.TextAlign = ContentAlignment.TopCenter;
            lblHintNumber.Visible = false;
            // 
            // btnHintNextRight
            // 
            btnHintNextRight.BackColor = Color.FromArgb(125, 0, 205);
            btnHintNextRight.Cursor = Cursors.Hand;
            btnHintNextRight.Enabled = false;
            btnHintNextRight.FlatStyle = FlatStyle.Popup;
            btnHintNextRight.Font = new Font("Hylia Serif Beta", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnHintNextRight.ForeColor = SystemColors.ButtonFace;
            btnHintNextRight.Location = new Point(409, 225);
            btnHintNextRight.Name = "btnHintNextRight";
            btnHintNextRight.Size = new Size(33, 32);
            btnHintNextRight.TabIndex = 43;
            btnHintNextRight.Text = "▶";
            btnHintNextRight.UseVisualStyleBackColor = false;
            btnHintNextRight.Visible = false;
            btnHintNextRight.Click += btnHintNextRight_Click;
            // 
            // cmbSelection
            // 
            cmbSelection.BackColor = Color.FromArgb(125, 0, 205);
            cmbSelection.Cursor = Cursors.Hand;
            cmbSelection.Enabled = false;
            cmbSelection.FlatStyle = FlatStyle.Popup;
            cmbSelection.Font = new Font("Hylia Serif Beta", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSelection.ForeColor = SystemColors.ButtonFace;
            cmbSelection.FormattingEnabled = true;
            cmbSelection.Location = new Point(301, 110);
            cmbSelection.Name = "cmbSelection";
            cmbSelection.Size = new Size(412, 23);
            cmbSelection.TabIndex = 45;
            cmbSelection.Text = "Select a Location...";
            cmbSelection.Visible = false;
            cmbSelection.SelectedIndexChanged += cmbSelection_SelectedIndexChanged;
            cmbSelection.DropDownClosed += cmbSelection_DropDownClosed;
            cmbSelection.SelectedValueChanged += cmbSelection_SelectedValueChanged;
            cmbSelection.TextChanged += cmbSelection_TextChanged;
            cmbSelection.Click += cmbSelection_Click;
            // 
            // btnCoinSpend
            // 
            btnCoinSpend.Enabled = false;
            btnCoinSpend.Font = new Font("Hylia Serif Beta", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnCoinSpend.Location = new Point(409, 147);
            btnCoinSpend.Name = "btnCoinSpend";
            btnCoinSpend.Size = new Size(216, 35);
            btnCoinSpend.TabIndex = 46;
            btnCoinSpend.Text = "Spend a Yellow Coin";
            btnCoinSpend.UseVisualStyleBackColor = true;
            btnCoinSpend.Visible = false;
            btnCoinSpend.Click += btnCoinSpend_Click;
            // 
            // lblSpoiler
            // 
            lblSpoiler.AutoSize = true;
            lblSpoiler.BackColor = Color.Transparent;
            lblSpoiler.Enabled = false;
            lblSpoiler.Font = new Font("Hylia Serif Beta", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpoiler.ForeColor = SystemColors.ButtonFace;
            lblSpoiler.Location = new Point(92, 81);
            lblSpoiler.Name = "lblSpoiler";
            lblSpoiler.Size = new Size(175, 19);
            lblSpoiler.TabIndex = 47;
            lblSpoiler.Text = "Spoiler Log File Path:";
            lblSpoiler.Visible = false;
            // 
            // btnSpoiler
            // 
            btnSpoiler.Enabled = false;
            btnSpoiler.Font = new Font("Hylia Serif Beta", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpoiler.Location = new Point(268, 76);
            btnSpoiler.Name = "btnSpoiler";
            btnSpoiler.Size = new Size(357, 27);
            btnSpoiler.TabIndex = 48;
            btnSpoiler.Text = "Select your OoTMM Spoiler Log";
            btnSpoiler.UseVisualStyleBackColor = true;
            btnSpoiler.Visible = false;
            btnSpoiler.Click += btnSpoiler_Click;
            // 
            // lblFound
            // 
            lblFound.AutoSize = true;
            lblFound.BackColor = Color.Transparent;
            lblFound.Enabled = false;
            lblFound.Font = new Font("Hylia Serif Beta", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            lblFound.ForeColor = SystemColors.ButtonFace;
            lblFound.Location = new Point(182, 109);
            lblFound.Name = "lblFound";
            lblFound.Size = new Size(108, 39);
            lblFound.TabIndex = 49;
            lblFound.Text = "Found";
            lblFound.Visible = false;
            // 
            // lblSpent
            // 
            lblSpent.AutoSize = true;
            lblSpent.BackColor = Color.Transparent;
            lblSpent.Enabled = false;
            lblSpent.Font = new Font("Hylia Serif Beta", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpent.ForeColor = SystemColors.ButtonFace;
            lblSpent.Location = new Point(182, 145);
            lblSpent.Name = "lblSpent";
            lblSpent.Size = new Size(102, 39);
            lblSpent.TabIndex = 50;
            lblSpent.Text = "Spent";
            lblSpent.Visible = false;
            // 
            // btnReset
            // 
            btnReset.Enabled = false;
            btnReset.Font = new Font("Hylia Serif Beta", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(7, 227);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 32);
            btnReset.TabIndex = 51;
            btnReset.Text = "Reset?";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Visible = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnHintNextLeft
            // 
            btnHintNextLeft.BackColor = Color.FromArgb(125, 0, 205);
            btnHintNextLeft.Cursor = Cursors.Hand;
            btnHintNextLeft.Enabled = false;
            btnHintNextLeft.FlatStyle = FlatStyle.Popup;
            btnHintNextLeft.Font = new Font("Hylia Serif Beta", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnHintNextLeft.ForeColor = SystemColors.ButtonFace;
            btnHintNextLeft.Location = new Point(262, 225);
            btnHintNextLeft.Name = "btnHintNextLeft";
            btnHintNextLeft.Size = new Size(33, 32);
            btnHintNextLeft.TabIndex = 52;
            btnHintNextLeft.Text = "◀";
            btnHintNextLeft.UseVisualStyleBackColor = false;
            btnHintNextLeft.Visible = false;
            btnHintNextLeft.Click += btnHintNextLeft_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OoTMM_Hint_Background;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(719, 261);
            Controls.Add(btnHintNextRight);
            Controls.Add(btnHintNextLeft);
            Controls.Add(btnReset);
            Controls.Add(lblSpent);
            Controls.Add(lblFound);
            Controls.Add(btnSpoiler);
            Controls.Add(lblSpoiler);
            Controls.Add(btnCoinSpend);
            Controls.Add(cmbSelection);
            Controls.Add(lblHintNumber);
            Controls.Add(lblHint);
            Controls.Add(lblCoinSpent);
            Controls.Add(lblCoinFound);
            Controls.Add(btnBack);
            Controls.Add(imgCoinBig);
            Controls.Add(imgCoinGreen);
            Controls.Add(numCoinGreen);
            Controls.Add(lblXGreen);
            Controls.Add(lblHintsClick);
            Controls.Add(imgCoinBlue);
            Controls.Add(numCoinBlue);
            Controls.Add(lblXBlue);
            Controls.Add(imgCoinRed);
            Controls.Add(numCoinRed);
            Controls.Add(lblXRed);
            Controls.Add(imgCoinYellow);
            Controls.Add(numCoinYellow);
            Controls.Add(lblXYellow);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "BrianMp16's OoTMM Item Hints Overhaul";
            ((System.ComponentModel.ISupportInitialize)imgCoinYellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCoinYellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCoinRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCoinRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCoinBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCoinBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCoinGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCoinGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCoinBig).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox imgCoinYellow;
        private NumericUpDown numCoinYellow;
        private Label lblXYellow;
        private PictureBox imgCoinRed;
        private NumericUpDown numCoinRed;
        private Label lblXRed;
        private PictureBox imgCoinBlue;
        private NumericUpDown numCoinBlue;
        private Label lblXBlue;
        private Label label3;
        private Label lblHintsClick;
        private PictureBox imgCoinGreen;
        private NumericUpDown numCoinGreen;
        private Label lblXGreen;
        private PictureBox imgCoinBig;
        private Button btnBack;
        private Label lblCoinFound;
        private Label lblCoinSpent;
        private Label label1;
        private Label lblHint;
        private Label lblHintNumber;
        private Button btnHintNextRight;
        private ComboBox cmbSelection;
        private Button btnCoinSpend;
        private Label lblSpoiler;
        private Button btnSpoiler;
        private Label lblFound;
        private Label lblSpent;
        private Button btnReset;
        private Button btnHintNextLeft;
    }
}
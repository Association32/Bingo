namespace Bingo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.infoPanel = new System.Windows.Forms.Panel();
            this.infoPanelLabel = new System.Windows.Forms.Label();
            this.nrTextBox = new System.Windows.Forms.TextBox();
            this.nrOkButton = new System.Windows.Forms.Button();
            this.choosenNrPanel = new System.Windows.Forms.Panel();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.chosenLabel3 = new System.Windows.Forms.Label();
            this.chosenLabel9 = new System.Windows.Forms.Label();
            this.chosenLabel2 = new System.Windows.Forms.Label();
            this.chosenLabel4 = new System.Windows.Forms.Label();
            this.chosenLabel1 = new System.Windows.Forms.Label();
            this.chosenLabel8 = new System.Windows.Forms.Label();
            this.chosenLabel0 = new System.Windows.Forms.Label();
            this.chosenLabel5 = new System.Windows.Forms.Label();
            this.chosenLabel7 = new System.Windows.Forms.Label();
            this.chosenLabel6 = new System.Windows.Forms.Label();
            this.bingoPanel = new System.Windows.Forms.Panel();
            this.randomButton = new System.Windows.Forms.Button();
            this.bingoLabel0 = new System.Windows.Forms.Label();
            this.bingoLabel6 = new System.Windows.Forms.Label();
            this.randomPanel = new System.Windows.Forms.Panel();
            this.randomLabel8 = new System.Windows.Forms.Label();
            this.randomLabel7 = new System.Windows.Forms.Label();
            this.randomLabel6 = new System.Windows.Forms.Label();
            this.randomLabel5 = new System.Windows.Forms.Label();
            this.randomLabel4 = new System.Windows.Forms.Label();
            this.randomLabel3 = new System.Windows.Forms.Label();
            this.randomLabel2 = new System.Windows.Forms.Label();
            this.randomLabel1 = new System.Windows.Forms.Label();
            this.bingoLabel1 = new System.Windows.Forms.Label();
            this.bingoLabel3 = new System.Windows.Forms.Label();
            this.bingoLabel5 = new System.Windows.Forms.Label();
            this.bingoLabel4 = new System.Windows.Forms.Label();
            this.bingoLabel2 = new System.Windows.Forms.Label();
            this.fillerPanel = new System.Windows.Forms.Panel();
            this.infoPanel.SuspendLayout();
            this.choosenNrPanel.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.bingoPanel.SuspendLayout();
            this.randomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Black;
            this.infoPanel.Controls.Add(this.infoPanelLabel);
            this.infoPanel.Location = new System.Drawing.Point(12, 12);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(633, 81);
            this.infoPanel.TabIndex = 0;
            // 
            // infoPanelLabel
            // 
            this.infoPanelLabel.AutoSize = true;
            this.infoPanelLabel.Font = new System.Drawing.Font("Century Gothic", 30.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPanelLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.infoPanelLabel.Location = new System.Drawing.Point(0, 25);
            this.infoPanelLabel.Name = "infoPanelLabel";
            this.infoPanelLabel.Size = new System.Drawing.Size(0, 50);
            this.infoPanelLabel.TabIndex = 0;
            // 
            // nrTextBox
            // 
            this.nrTextBox.Location = new System.Drawing.Point(3, 25);
            this.nrTextBox.Name = "nrTextBox";
            this.nrTextBox.Size = new System.Drawing.Size(44, 20);
            this.nrTextBox.TabIndex = 1;
            // 
            // nrOkButton
            // 
            this.nrOkButton.Location = new System.Drawing.Point(53, 25);
            this.nrOkButton.Name = "nrOkButton";
            this.nrOkButton.Size = new System.Drawing.Size(75, 23);
            this.nrOkButton.TabIndex = 2;
            this.nrOkButton.Text = "OK";
            this.nrOkButton.UseVisualStyleBackColor = true;
            this.nrOkButton.Click += new System.EventHandler(this.nrOkButton_Click);
            // 
            // choosenNrPanel
            // 
            this.choosenNrPanel.BackColor = System.Drawing.Color.Silver;
            this.choosenNrPanel.Controls.Add(this.resultPanel);
            this.choosenNrPanel.Controls.Add(this.instructionLabel);
            this.choosenNrPanel.Controls.Add(this.chosenLabel3);
            this.choosenNrPanel.Controls.Add(this.chosenLabel9);
            this.choosenNrPanel.Controls.Add(this.chosenLabel2);
            this.choosenNrPanel.Controls.Add(this.chosenLabel4);
            this.choosenNrPanel.Controls.Add(this.chosenLabel1);
            this.choosenNrPanel.Controls.Add(this.chosenLabel8);
            this.choosenNrPanel.Controls.Add(this.chosenLabel0);
            this.choosenNrPanel.Controls.Add(this.chosenLabel5);
            this.choosenNrPanel.Controls.Add(this.nrTextBox);
            this.choosenNrPanel.Controls.Add(this.chosenLabel7);
            this.choosenNrPanel.Controls.Add(this.nrOkButton);
            this.choosenNrPanel.Controls.Add(this.chosenLabel6);
            this.choosenNrPanel.Location = new System.Drawing.Point(12, 99);
            this.choosenNrPanel.Name = "choosenNrPanel";
            this.choosenNrPanel.Size = new System.Drawing.Size(632, 130);
            this.choosenNrPanel.TabIndex = 3;
            // 
            // resultPanel
            // 
            this.resultPanel.BackColor = System.Drawing.Color.Black;
            this.resultPanel.Controls.Add(this.resultLabel);
            this.resultPanel.Location = new System.Drawing.Point(146, 9);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(470, 39);
            this.resultPanel.TabIndex = 14;
            this.resultPanel.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.resultLabel.Location = new System.Drawing.Point(3, 10);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(64, 25);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "label1";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.BackColor = System.Drawing.Color.Silver;
            this.instructionLabel.Location = new System.Drawing.Point(3, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(137, 13);
            this.instructionLabel.TabIndex = 13;
            this.instructionLabel.Text = "Skriv in tal mellan 1 och 25.";
            // 
            // chosenLabel3
            // 
            this.chosenLabel3.AutoSize = true;
            this.chosenLabel3.BackColor = System.Drawing.Color.LightGray;
            this.chosenLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chosenLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chosenLabel3.Location = new System.Drawing.Point(196, 64);
            this.chosenLabel3.MaximumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel3.MinimumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel3.Name = "chosenLabel3";
            this.chosenLabel3.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.chosenLabel3.Size = new System.Drawing.Size(55, 55);
            this.chosenLabel3.TabIndex = 6;
            // 
            // chosenLabel9
            // 
            this.chosenLabel9.AutoSize = true;
            this.chosenLabel9.BackColor = System.Drawing.Color.LightGray;
            this.chosenLabel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chosenLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chosenLabel9.Location = new System.Drawing.Point(562, 64);
            this.chosenLabel9.MaximumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel9.MinimumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel9.Name = "chosenLabel9";
            this.chosenLabel9.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.chosenLabel9.Size = new System.Drawing.Size(55, 55);
            this.chosenLabel9.TabIndex = 12;
            // 
            // chosenLabel2
            // 
            this.chosenLabel2.AutoSize = true;
            this.chosenLabel2.BackColor = System.Drawing.Color.LightGray;
            this.chosenLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chosenLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chosenLabel2.Location = new System.Drawing.Point(135, 64);
            this.chosenLabel2.MaximumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel2.MinimumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel2.Name = "chosenLabel2";
            this.chosenLabel2.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.chosenLabel2.Size = new System.Drawing.Size(55, 55);
            this.chosenLabel2.TabIndex = 5;
            // 
            // chosenLabel4
            // 
            this.chosenLabel4.AutoSize = true;
            this.chosenLabel4.BackColor = System.Drawing.Color.LightGray;
            this.chosenLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chosenLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chosenLabel4.Location = new System.Drawing.Point(257, 64);
            this.chosenLabel4.MaximumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel4.MinimumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel4.Name = "chosenLabel4";
            this.chosenLabel4.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.chosenLabel4.Size = new System.Drawing.Size(55, 55);
            this.chosenLabel4.TabIndex = 7;
            // 
            // chosenLabel1
            // 
            this.chosenLabel1.AutoSize = true;
            this.chosenLabel1.BackColor = System.Drawing.Color.LightGray;
            this.chosenLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chosenLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chosenLabel1.Location = new System.Drawing.Point(74, 64);
            this.chosenLabel1.MaximumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel1.MinimumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel1.Name = "chosenLabel1";
            this.chosenLabel1.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.chosenLabel1.Size = new System.Drawing.Size(55, 55);
            this.chosenLabel1.TabIndex = 4;
            // 
            // chosenLabel8
            // 
            this.chosenLabel8.AutoSize = true;
            this.chosenLabel8.BackColor = System.Drawing.Color.LightGray;
            this.chosenLabel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chosenLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chosenLabel8.Location = new System.Drawing.Point(501, 64);
            this.chosenLabel8.MaximumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel8.MinimumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel8.Name = "chosenLabel8";
            this.chosenLabel8.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.chosenLabel8.Size = new System.Drawing.Size(55, 55);
            this.chosenLabel8.TabIndex = 11;
            // 
            // chosenLabel0
            // 
            this.chosenLabel0.AutoSize = true;
            this.chosenLabel0.BackColor = System.Drawing.Color.LightGray;
            this.chosenLabel0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chosenLabel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenLabel0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chosenLabel0.Location = new System.Drawing.Point(13, 64);
            this.chosenLabel0.MaximumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel0.MinimumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel0.Name = "chosenLabel0";
            this.chosenLabel0.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.chosenLabel0.Size = new System.Drawing.Size(55, 55);
            this.chosenLabel0.TabIndex = 3;
            // 
            // chosenLabel5
            // 
            this.chosenLabel5.AutoSize = true;
            this.chosenLabel5.BackColor = System.Drawing.Color.LightGray;
            this.chosenLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chosenLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chosenLabel5.Location = new System.Drawing.Point(318, 64);
            this.chosenLabel5.MaximumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel5.MinimumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel5.Name = "chosenLabel5";
            this.chosenLabel5.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.chosenLabel5.Size = new System.Drawing.Size(55, 55);
            this.chosenLabel5.TabIndex = 8;
            // 
            // chosenLabel7
            // 
            this.chosenLabel7.AutoSize = true;
            this.chosenLabel7.BackColor = System.Drawing.Color.LightGray;
            this.chosenLabel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chosenLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chosenLabel7.Location = new System.Drawing.Point(440, 64);
            this.chosenLabel7.MaximumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel7.MinimumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel7.Name = "chosenLabel7";
            this.chosenLabel7.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.chosenLabel7.Size = new System.Drawing.Size(55, 55);
            this.chosenLabel7.TabIndex = 10;
            // 
            // chosenLabel6
            // 
            this.chosenLabel6.AutoSize = true;
            this.chosenLabel6.BackColor = System.Drawing.Color.LightGray;
            this.chosenLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chosenLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chosenLabel6.Location = new System.Drawing.Point(379, 64);
            this.chosenLabel6.MaximumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel6.MinimumSize = new System.Drawing.Size(55, 55);
            this.chosenLabel6.Name = "chosenLabel6";
            this.chosenLabel6.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.chosenLabel6.Size = new System.Drawing.Size(55, 55);
            this.chosenLabel6.TabIndex = 9;
            // 
            // bingoPanel
            // 
            this.bingoPanel.BackColor = System.Drawing.Color.Silver;
            this.bingoPanel.Controls.Add(this.randomButton);
            this.bingoPanel.Controls.Add(this.bingoLabel0);
            this.bingoPanel.Controls.Add(this.bingoLabel6);
            this.bingoPanel.Controls.Add(this.randomPanel);
            this.bingoPanel.Controls.Add(this.bingoLabel1);
            this.bingoPanel.Controls.Add(this.bingoLabel3);
            this.bingoPanel.Controls.Add(this.bingoLabel5);
            this.bingoPanel.Controls.Add(this.bingoLabel4);
            this.bingoPanel.Controls.Add(this.bingoLabel2);
            this.bingoPanel.Location = new System.Drawing.Point(11, 371);
            this.bingoPanel.Name = "bingoPanel";
            this.bingoPanel.Size = new System.Drawing.Size(633, 130);
            this.bingoPanel.TabIndex = 4;
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(197, 19);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(75, 23);
            this.randomButton.TabIndex = 21;
            this.randomButton.Text = "OK";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // bingoLabel0
            // 
            this.bingoLabel0.AutoSize = true;
            this.bingoLabel0.BackColor = System.Drawing.Color.LightGray;
            this.bingoLabel0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bingoLabel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bingoLabel0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bingoLabel0.Location = new System.Drawing.Point(196, 64);
            this.bingoLabel0.MaximumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel0.MinimumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel0.Name = "bingoLabel0";
            this.bingoLabel0.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.bingoLabel0.Size = new System.Drawing.Size(55, 55);
            this.bingoLabel0.TabIndex = 14;
            // 
            // bingoLabel6
            // 
            this.bingoLabel6.AutoSize = true;
            this.bingoLabel6.BackColor = System.Drawing.Color.LightGray;
            this.bingoLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bingoLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bingoLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bingoLabel6.Location = new System.Drawing.Point(562, 64);
            this.bingoLabel6.MaximumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel6.MinimumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel6.Name = "bingoLabel6";
            this.bingoLabel6.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.bingoLabel6.Size = new System.Drawing.Size(55, 55);
            this.bingoLabel6.TabIndex = 20;
            // 
            // randomPanel
            // 
            this.randomPanel.Controls.Add(this.randomLabel8);
            this.randomPanel.Controls.Add(this.randomLabel7);
            this.randomPanel.Controls.Add(this.randomLabel6);
            this.randomPanel.Controls.Add(this.randomLabel5);
            this.randomPanel.Controls.Add(this.randomLabel4);
            this.randomPanel.Controls.Add(this.randomLabel3);
            this.randomPanel.Controls.Add(this.randomLabel2);
            this.randomPanel.Controls.Add(this.randomLabel1);
            this.randomPanel.Location = new System.Drawing.Point(13, 19);
            this.randomPanel.Name = "randomPanel";
            this.randomPanel.Size = new System.Drawing.Size(177, 100);
            this.randomPanel.TabIndex = 5;
            // 
            // randomLabel8
            // 
            this.randomLabel8.AutoSize = true;
            this.randomLabel8.Location = new System.Drawing.Point(122, 47);
            this.randomLabel8.Name = "randomLabel8";
            this.randomLabel8.Size = new System.Drawing.Size(19, 13);
            this.randomLabel8.TabIndex = 7;
            this.randomLabel8.Text = "19";
            // 
            // randomLabel7
            // 
            this.randomLabel7.AutoSize = true;
            this.randomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomLabel7.Location = new System.Drawing.Point(104, 20);
            this.randomLabel7.Name = "randomLabel7";
            this.randomLabel7.Size = new System.Drawing.Size(24, 17);
            this.randomLabel7.TabIndex = 6;
            this.randomLabel7.Text = "13";
            // 
            // randomLabel6
            // 
            this.randomLabel6.AutoSize = true;
            this.randomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomLabel6.Location = new System.Drawing.Point(67, 7);
            this.randomLabel6.Name = "randomLabel6";
            this.randomLabel6.Size = new System.Drawing.Size(20, 22);
            this.randomLabel6.TabIndex = 5;
            this.randomLabel6.Text = "6";
            // 
            // randomLabel5
            // 
            this.randomLabel5.AutoSize = true;
            this.randomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomLabel5.Location = new System.Drawing.Point(16, 13);
            this.randomLabel5.Name = "randomLabel5";
            this.randomLabel5.Size = new System.Drawing.Size(23, 25);
            this.randomLabel5.TabIndex = 4;
            this.randomLabel5.Text = "4";
            // 
            // randomLabel4
            // 
            this.randomLabel4.AutoSize = true;
            this.randomLabel4.Location = new System.Drawing.Point(16, 48);
            this.randomLabel4.Name = "randomLabel4";
            this.randomLabel4.Size = new System.Drawing.Size(13, 13);
            this.randomLabel4.TabIndex = 3;
            this.randomLabel4.Text = "3";
            // 
            // randomLabel3
            // 
            this.randomLabel3.AutoSize = true;
            this.randomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomLabel3.Location = new System.Drawing.Point(32, 60);
            this.randomLabel3.Name = "randomLabel3";
            this.randomLabel3.Size = new System.Drawing.Size(39, 29);
            this.randomLabel3.TabIndex = 2;
            this.randomLabel3.Text = "12";
            // 
            // randomLabel2
            // 
            this.randomLabel2.AutoSize = true;
            this.randomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomLabel2.Location = new System.Drawing.Point(77, 80);
            this.randomLabel2.Name = "randomLabel2";
            this.randomLabel2.Size = new System.Drawing.Size(18, 20);
            this.randomLabel2.TabIndex = 1;
            this.randomLabel2.Text = "7";
            // 
            // randomLabel1
            // 
            this.randomLabel1.AutoSize = true;
            this.randomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomLabel1.Location = new System.Drawing.Point(117, 64);
            this.randomLabel1.Name = "randomLabel1";
            this.randomLabel1.Size = new System.Drawing.Size(26, 29);
            this.randomLabel1.TabIndex = 0;
            this.randomLabel1.Text = "1";
            // 
            // bingoLabel1
            // 
            this.bingoLabel1.AutoSize = true;
            this.bingoLabel1.BackColor = System.Drawing.Color.LightGray;
            this.bingoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bingoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bingoLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bingoLabel1.Location = new System.Drawing.Point(257, 64);
            this.bingoLabel1.MaximumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel1.MinimumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel1.Name = "bingoLabel1";
            this.bingoLabel1.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.bingoLabel1.Size = new System.Drawing.Size(55, 55);
            this.bingoLabel1.TabIndex = 15;
            // 
            // bingoLabel3
            // 
            this.bingoLabel3.AutoSize = true;
            this.bingoLabel3.BackColor = System.Drawing.Color.LightGray;
            this.bingoLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bingoLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bingoLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bingoLabel3.Location = new System.Drawing.Point(379, 64);
            this.bingoLabel3.MaximumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel3.MinimumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel3.Name = "bingoLabel3";
            this.bingoLabel3.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.bingoLabel3.Size = new System.Drawing.Size(55, 55);
            this.bingoLabel3.TabIndex = 17;
            // 
            // bingoLabel5
            // 
            this.bingoLabel5.AutoSize = true;
            this.bingoLabel5.BackColor = System.Drawing.Color.LightGray;
            this.bingoLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bingoLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bingoLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bingoLabel5.Location = new System.Drawing.Point(501, 64);
            this.bingoLabel5.MaximumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel5.MinimumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel5.Name = "bingoLabel5";
            this.bingoLabel5.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.bingoLabel5.Size = new System.Drawing.Size(55, 55);
            this.bingoLabel5.TabIndex = 19;
            // 
            // bingoLabel4
            // 
            this.bingoLabel4.AutoSize = true;
            this.bingoLabel4.BackColor = System.Drawing.Color.LightGray;
            this.bingoLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bingoLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bingoLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bingoLabel4.Location = new System.Drawing.Point(440, 64);
            this.bingoLabel4.MaximumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel4.MinimumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel4.Name = "bingoLabel4";
            this.bingoLabel4.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.bingoLabel4.Size = new System.Drawing.Size(55, 55);
            this.bingoLabel4.TabIndex = 18;
            // 
            // bingoLabel2
            // 
            this.bingoLabel2.AutoSize = true;
            this.bingoLabel2.BackColor = System.Drawing.Color.LightGray;
            this.bingoLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bingoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bingoLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bingoLabel2.Location = new System.Drawing.Point(318, 64);
            this.bingoLabel2.MaximumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel2.MinimumSize = new System.Drawing.Size(55, 55);
            this.bingoLabel2.Name = "bingoLabel2";
            this.bingoLabel2.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.bingoLabel2.Size = new System.Drawing.Size(55, 55);
            this.bingoLabel2.TabIndex = 16;
            // 
            // fillerPanel
            // 
            this.fillerPanel.BackColor = System.Drawing.Color.Silver;
            this.fillerPanel.BackgroundImage = global::Bingo.Properties.Resources.FillerBackground;
            this.fillerPanel.Location = new System.Drawing.Point(11, 235);
            this.fillerPanel.Name = "fillerPanel";
            this.fillerPanel.Size = new System.Drawing.Size(633, 130);
            this.fillerPanel.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(657, 376);
            this.Controls.Add(this.bingoPanel);
            this.Controls.Add(this.fillerPanel);
            this.Controls.Add(this.choosenNrPanel);
            this.Controls.Add(this.infoPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.choosenNrPanel.ResumeLayout(false);
            this.choosenNrPanel.PerformLayout();
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            this.bingoPanel.ResumeLayout(false);
            this.bingoPanel.PerformLayout();
            this.randomPanel.ResumeLayout(false);
            this.randomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.TextBox nrTextBox;
        private System.Windows.Forms.Button nrOkButton;
        private System.Windows.Forms.Panel choosenNrPanel;
        private System.Windows.Forms.Label chosenLabel0;
        private System.Windows.Forms.Label chosenLabel9;
        private System.Windows.Forms.Label chosenLabel8;
        private System.Windows.Forms.Label chosenLabel7;
        private System.Windows.Forms.Label chosenLabel6;
        private System.Windows.Forms.Label chosenLabel5;
        private System.Windows.Forms.Label chosenLabel4;
        private System.Windows.Forms.Label chosenLabel3;
        private System.Windows.Forms.Label chosenLabel2;
        private System.Windows.Forms.Label chosenLabel1;
        private System.Windows.Forms.Label infoPanelLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Panel bingoPanel;
        private System.Windows.Forms.Panel randomPanel;
        private System.Windows.Forms.Label randomLabel4;
        private System.Windows.Forms.Label randomLabel3;
        private System.Windows.Forms.Label randomLabel2;
        private System.Windows.Forms.Label randomLabel1;
        private System.Windows.Forms.Label bingoLabel0;
        private System.Windows.Forms.Label bingoLabel6;
        private System.Windows.Forms.Label bingoLabel1;
        private System.Windows.Forms.Label bingoLabel3;
        private System.Windows.Forms.Label bingoLabel5;
        private System.Windows.Forms.Label bingoLabel4;
        private System.Windows.Forms.Label bingoLabel2;
        private System.Windows.Forms.Panel fillerPanel;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Label randomLabel8;
        private System.Windows.Forms.Label randomLabel7;
        private System.Windows.Forms.Label randomLabel6;
        private System.Windows.Forms.Label randomLabel5;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Label resultLabel;
    }
}


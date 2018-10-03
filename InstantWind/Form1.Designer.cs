namespace InstantWind
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtICAO = new System.Windows.Forms.TextBox();
            this.btnGetICAO = new System.Windows.Forms.Button();
            this.lblMETARwind = new System.Windows.Forms.Label();
            this.lblICAO = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape7 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTDZ = new System.Windows.Forms.Label();
            this.lblMID = new System.Windows.Forms.Label();
            this.lblEND = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.orologio = new System.Windows.Forms.Timer(this.components);
            this.lblOrario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rectangleShape8 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.cmbRwy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtngSTATUS = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblRwy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rectangleShape9 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtICAO
            // 
            this.txtICAO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtICAO.Location = new System.Drawing.Point(13, 13);
            this.txtICAO.Name = "txtICAO";
            this.txtICAO.Size = new System.Drawing.Size(50, 20);
            this.txtICAO.TabIndex = 0;
            this.txtICAO.TextChanged += new System.EventHandler(this.txtICAO_TextChanged);
            // 
            // btnGetICAO
            // 
            this.btnGetICAO.Enabled = false;
            this.btnGetICAO.Location = new System.Drawing.Point(118, 12);
            this.btnGetICAO.Name = "btnGetICAO";
            this.btnGetICAO.Size = new System.Drawing.Size(32, 23);
            this.btnGetICAO.TabIndex = 1;
            this.btnGetICAO.Text = "Go";
            this.btnGetICAO.UseVisualStyleBackColor = true;
            this.btnGetICAO.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMETARwind
            // 
            this.lblMETARwind.AutoSize = true;
            this.lblMETARwind.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMETARwind.Location = new System.Drawing.Point(114, 116);
            this.lblMETARwind.Name = "lblMETARwind";
            this.lblMETARwind.Size = new System.Drawing.Size(110, 27);
            this.lblMETARwind.TabIndex = 2;
            this.lblMETARwind.Text = "/////KT";
            // 
            // lblICAO
            // 
            this.lblICAO.AutoSize = true;
            this.lblICAO.Font = new System.Drawing.Font("DejaVu Sans Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICAO.Location = new System.Drawing.Point(19, 53);
            this.lblICAO.Name = "lblICAO";
            this.lblICAO.Size = new System.Drawing.Size(44, 18);
            this.lblICAO.TabIndex = 3;
            this.lblICAO.Text = "AD: ";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape9,
            this.rtngSTATUS,
            this.rectangleShape8,
            this.rectangleShape7,
            this.rectangleShape6,
            this.rectangleShape5,
            this.rectangleShape4,
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(413, 337);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape7
            // 
            this.rectangleShape7.BorderWidth = 2;
            this.rectangleShape7.CornerRadius = 1;
            this.rectangleShape7.Location = new System.Drawing.Point(23, 255);
            this.rectangleShape7.Name = "rectangleShape7";
            this.rectangleShape7.Size = new System.Drawing.Size(350, 36);
            // 
            // rectangleShape6
            // 
            this.rectangleShape6.BorderWidth = 2;
            this.rectangleShape6.CornerRadius = 1;
            this.rectangleShape6.Location = new System.Drawing.Point(24, 210);
            this.rectangleShape6.Name = "rectangleShape6";
            this.rectangleShape6.Size = new System.Drawing.Size(350, 36);
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.BorderWidth = 2;
            this.rectangleShape5.CornerRadius = 1;
            this.rectangleShape5.Location = new System.Drawing.Point(23, 166);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(350, 36);
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BorderWidth = 5;
            this.rectangleShape4.CornerRadius = 3;
            this.rectangleShape4.Location = new System.Drawing.Point(23, 255);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(75, 36);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BorderWidth = 5;
            this.rectangleShape3.CornerRadius = 3;
            this.rectangleShape3.Location = new System.Drawing.Point(24, 210);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(75, 36);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderWidth = 5;
            this.rectangleShape2.CornerRadius = 3;
            this.rectangleShape2.Location = new System.Drawing.Point(23, 166);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(76, 36);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(22, 80);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(292, 73);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InstantWind.Properties.Resources.enav;
            this.pictureBox1.Location = new System.Drawing.Point(204, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last METAR report:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "TDZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "MID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "END";
            // 
            // lblTDZ
            // 
            this.lblTDZ.AutoSize = true;
            this.lblTDZ.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDZ.Location = new System.Drawing.Point(114, 174);
            this.lblTDZ.Name = "lblTDZ";
            this.lblTDZ.Size = new System.Drawing.Size(244, 23);
            this.lblTDZ.TabIndex = 10;
            this.lblTDZ.Text = "Retrieving data...";
            // 
            // lblMID
            // 
            this.lblMID.AutoSize = true;
            this.lblMID.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMID.Location = new System.Drawing.Point(114, 218);
            this.lblMID.Name = "lblMID";
            this.lblMID.Size = new System.Drawing.Size(244, 23);
            this.lblMID.TabIndex = 11;
            this.lblMID.Text = "Retrieving data...";
            // 
            // lblEND
            // 
            this.lblEND.AutoSize = true;
            this.lblEND.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEND.Location = new System.Drawing.Point(114, 262);
            this.lblEND.Name = "lblEND";
            this.lblEND.Size = new System.Drawing.Size(244, 23);
            this.lblEND.TabIndex = 12;
            this.lblEND.Text = "Retrieving data...";
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // orologio
            // 
            this.orologio.Enabled = true;
            this.orologio.Interval = 1;
            this.orologio.Tick += new System.EventHandler(this.orologio_Tick);
            // 
            // lblOrario
            // 
            this.lblOrario.AutoSize = true;
            this.lblOrario.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrario.Location = new System.Drawing.Point(310, 39);
            this.lblOrario.Name = "lblOrario";
            this.lblOrario.Size = new System.Drawing.Size(89, 20);
            this.lblOrario.TabIndex = 13;
            this.lblOrario.Text = "00:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "WIND";
            // 
            // rectangleShape8
            // 
            this.rectangleShape8.Location = new System.Drawing.Point(322, 80);
            this.rectangleShape8.Name = "rectangleShape8";
            this.rectangleShape8.Size = new System.Drawing.Size(85, 73);
            // 
            // cmbRwy
            // 
            this.cmbRwy.FormattingEnabled = true;
            this.cmbRwy.Items.AddRange(new object[] {
            "...",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "01L",
            "02L",
            "03L",
            "04L",
            "05L",
            "06L",
            "07L",
            "08L",
            "09L",
            "10L",
            "11L",
            "12L",
            "13L",
            "14L",
            "15L",
            "16L",
            "17L",
            "18L",
            "19L",
            "20L",
            "21L",
            "22L",
            "23L",
            "24L",
            "25L",
            "26L",
            "27L",
            "28L",
            "29L",
            "30L",
            "31L",
            "32L",
            "33L",
            "34L",
            "35L",
            "36L",
            "01R",
            "02R",
            "03R",
            "04R",
            "05R",
            "06R",
            "07R",
            "08R",
            "09R",
            "10R",
            "11R",
            "12R",
            "13R",
            "14R",
            "15R",
            "16R",
            "17R",
            "18R",
            "19R",
            "20R",
            "21R",
            "22R",
            "23R",
            "24R",
            "25R",
            "26R",
            "27R",
            "28R",
            "29R",
            "30R",
            "31R",
            "32R",
            "33R",
            "34R",
            "35R",
            "36R"});
            this.cmbRwy.Location = new System.Drawing.Point(69, 13);
            this.cmbRwy.Name = "cmbRwy";
            this.cmbRwy.Size = new System.Drawing.Size(43, 21);
            this.cmbRwy.TabIndex = 15;
            this.cmbRwy.SelectedIndexChanged += new System.EventHandler(this.cmbRwy_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DejaVu Sans Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data status: ";
            // 
            // rtngSTATUS
            // 
            this.rtngSTATUS.FillColor = System.Drawing.Color.Red;
            this.rtngSTATUS.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rtngSTATUS.Location = new System.Drawing.Point(145, 305);
            this.rtngSTATUS.Name = "rtngSTATUS";
            this.rtngSTATUS.Size = new System.Drawing.Size(20, 20);
            // 
            // lblRwy
            // 
            this.lblRwy.AutoSize = true;
            this.lblRwy.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRwy.Location = new System.Drawing.Point(346, 119);
            this.lblRwy.Name = "lblRwy";
            this.lblRwy.Size = new System.Drawing.Size(32, 27);
            this.lblRwy.TabIndex = 17;
            this.lblRwy.Text = "__";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "RWY";
            // 
            // rectangleShape9
            // 
            this.rectangleShape9.Location = new System.Drawing.Point(301, 31);
            this.rectangleShape9.Name = "rectangleShape9";
            this.rectangleShape9.Size = new System.Drawing.Size(104, 33);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 337);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRwy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbRwy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOrario);
            this.Controls.Add(this.lblEND);
            this.Controls.Add(this.lblMID);
            this.Controls.Add(this.lblTDZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblICAO);
            this.Controls.Add(this.lblMETARwind);
            this.Controls.Add(this.btnGetICAO);
            this.Controls.Add(this.txtICAO);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstantWind";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtICAO;
        private System.Windows.Forms.Button btnGetICAO;
        private System.Windows.Forms.Label lblMETARwind;
        private System.Windows.Forms.Label lblICAO;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape7;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape6;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTDZ;
        private System.Windows.Forms.Label lblMID;
        private System.Windows.Forms.Label lblEND;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer orologio;
        private System.Windows.Forms.Label lblOrario;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape8;
        private System.Windows.Forms.ComboBox cmbRwy;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rtngSTATUS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRwy;
        private System.Windows.Forms.Label label7;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape9;
    }
}


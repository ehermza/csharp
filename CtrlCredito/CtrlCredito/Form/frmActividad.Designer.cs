namespace CtrldeCredito
{
    partial class frmActividad
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
            this.LVD = new System.Windows.Forms.RadioButton();
            this.ASP = new System.Windows.Forms.RadioButton();
            this.ESP = new System.Windows.Forms.RadioButton();
            this.CDR = new System.Windows.Forms.RadioButton();
            this.SPT = new System.Windows.Forms.RadioButton();
            this.lbLinea = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMinutos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.lbId_tarjeta = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.lbLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbMinutos)).BeginInit();
            this.SuspendLayout();
            // 
            // LVD
            // 
            this.LVD.AutoSize = true;
            this.LVD.Checked = true;
            this.LVD.Location = new System.Drawing.Point(28, 73);
            this.LVD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LVD.Name = "LVD";
            this.LVD.Size = new System.Drawing.Size(68, 21);
            this.LVD.TabIndex = 0;
            this.LVD.TabStop = true;
            this.LVD.Text = "lavado";
            this.LVD.UseVisualStyleBackColor = true;
            // 
            // ASP
            // 
            this.ASP.AutoSize = true;
            this.ASP.Location = new System.Drawing.Point(406, 73);
            this.ASP.Name = "ASP";
            this.ASP.Size = new System.Drawing.Size(71, 21);
            this.ASP.TabIndex = 1;
            this.ASP.Text = "aspirar";
            this.ASP.UseVisualStyleBackColor = true;
            // 
            // ESP
            // 
            this.ESP.AutoSize = true;
            this.ESP.Location = new System.Drawing.Point(306, 73);
            this.ESP.Name = "ESP";
            this.ESP.Size = new System.Drawing.Size(79, 21);
            this.ESP.TabIndex = 2;
            this.ESP.Text = "espuma";
            this.ESP.UseVisualStyleBackColor = true;
            // 
            // CDR
            // 
            this.CDR.AutoSize = true;
            this.CDR.Location = new System.Drawing.Point(211, 73);
            this.CDR.Name = "CDR";
            this.CDR.Size = new System.Drawing.Size(74, 21);
            this.CDR.TabIndex = 3;
            this.CDR.Text = "caldera";
            this.CDR.UseVisualStyleBackColor = true;
            // 
            // SPT
            // 
            this.SPT.AutoSize = true;
            this.SPT.Location = new System.Drawing.Point(117, 73);
            this.SPT.Name = "SPT";
            this.SPT.Size = new System.Drawing.Size(73, 21);
            this.SPT.TabIndex = 4;
            this.SPT.Text = "soplete";
            this.SPT.UseVisualStyleBackColor = true;
            // 
            // lbLinea
            // 
            this.lbLinea.Location = new System.Drawing.Point(96, 118);
            this.lbLinea.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.lbLinea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lbLinea.Name = "lbLinea";
            this.lbLinea.Size = new System.Drawing.Size(54, 25);
            this.lbLinea.TabIndex = 5;
            this.lbLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lbLinea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(27, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Línea N°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Duración                 min.";
            // 
            // lbMinutos
            // 
            this.lbMinutos.DecimalPlaces = 1;
            this.lbMinutos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.lbMinutos.Location = new System.Drawing.Point(237, 120);
            this.lbMinutos.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.lbMinutos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lbMinutos.Name = "lbMinutos";
            this.lbMinutos.Size = new System.Drawing.Size(54, 25);
            this.lbMinutos.TabIndex = 8;
            this.lbMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lbMinutos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tarjeta N°";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(370, 118);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(103, 32);
            this.btOK.TabIndex = 11;
            this.btOK.Text = "Registrar";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbId_tarjeta
            // 
            this.lbId_tarjeta.DisplayMember = "19234912";
            this.lbId_tarjeta.FormattingEnabled = true;
            this.lbId_tarjeta.ItemHeight = 17;
            this.lbId_tarjeta.Items.AddRange(new object[] {
            "19234912",
            "90992991",
            "76876562",
            "52025711"});
            this.lbId_tarjeta.Location = new System.Drawing.Point(115, 27);
            this.lbId_tarjeta.Name = "lbId_tarjeta";
            this.lbId_tarjeta.Size = new System.Drawing.Size(120, 21);
            this.lbId_tarjeta.TabIndex = 9;
            this.lbId_tarjeta.ValueMember = "0";
            // 
            // frmActividad
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 169);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbId_tarjeta);
            this.Controls.Add(this.lbMinutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLinea);
            this.Controls.Add(this.SPT);
            this.Controls.Add(this.CDR);
            this.Controls.Add(this.ESP);
            this.Controls.Add(this.ASP);
            this.Controls.Add(this.LVD);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMULADOR";
            ((System.ComponentModel.ISupportInitialize)(this.lbLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbMinutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton LVD;
        private System.Windows.Forms.RadioButton ASP;
        private System.Windows.Forms.RadioButton ESP;
        private System.Windows.Forms.RadioButton CDR;
        private System.Windows.Forms.RadioButton SPT;
        private System.Windows.Forms.NumericUpDown lbLinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lbMinutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.ListBox lbId_tarjeta;
    }
}
namespace CtrldeCredito
{
    partial class frmListRecarga
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
            this.btCalendarInit = new System.Windows.Forms.Button();
            this.lbFechaInit = new System.Windows.Forms.Label();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.btCalendarFin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBOX1 = new System.Windows.Forms.CheckBox();
            this.tbcdgo = new System.Windows.Forms.TextBox();
            this.TBOX1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCalendarInit
            // 
            this.btCalendarInit.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btCalendarInit.Location = new System.Drawing.Point(190, 28);
            this.btCalendarInit.Margin = new System.Windows.Forms.Padding(4);
            this.btCalendarInit.Name = "btCalendarInit";
            this.btCalendarInit.Size = new System.Drawing.Size(36, 30);
            this.btCalendarInit.TabIndex = 0;
            this.btCalendarInit.Text = "29";
            this.btCalendarInit.UseVisualStyleBackColor = true;
            this.btCalendarInit.Click += new System.EventHandler(this.btCalendarInit_Click);
            // 
            // lbFechaInit
            // 
            this.lbFechaInit.Location = new System.Drawing.Point(13, 34);
            this.lbFechaInit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaInit.Name = "lbFechaInit";
            this.lbFechaInit.Size = new System.Drawing.Size(169, 18);
            this.lbFechaInit.TabIndex = 2;
            this.lbFechaInit.Text = "label1";
            this.lbFechaInit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.Location = new System.Drawing.Point(13, 70);
            this.lbFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(169, 18);
            this.lbFechaFin.TabIndex = 3;
            this.lbFechaFin.Text = "label2";
            this.lbFechaFin.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btCalendarFin
            // 
            this.btCalendarFin.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btCalendarFin.Location = new System.Drawing.Point(190, 63);
            this.btCalendarFin.Margin = new System.Windows.Forms.Padding(4);
            this.btCalendarFin.Name = "btCalendarFin";
            this.btCalendarFin.Size = new System.Drawing.Size(36, 30);
            this.btCalendarFin.TabIndex = 4;
            this.btCalendarFin.Text = "29";
            this.btCalendarFin.UseVisualStyleBackColor = true;
            this.btCalendarFin.Click += new System.EventHandler(this.btCalendarFin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(16, 145);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.Size = new System.Drawing.Size(476, 211);
            this.dtgv.TabIndex = 6;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(16, 365);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(116, 29);
            this.btBuscar.TabIndex = 7;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Location = new System.Drawing.Point(29, 31);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(94, 22);
            this.rbt1.TabIndex = 8;
            this.rbt1.Text = "Terminales";
            this.rbt1.UseVisualStyleBackColor = true;
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Location = new System.Drawing.Point(29, 60);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(88, 22);
            this.rbt2.TabIndex = 9;
            this.rbt2.Text = "Pc Admin.";
            this.rbt2.UseVisualStyleBackColor = true;
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.Checked = true;
            this.rbt3.Location = new System.Drawing.Point(29, 89);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(62, 22);
            this.rbt3.TabIndex = 10;
            this.rbt3.TabStop = true;
            this.rbt3.Text = "Todos";
            this.rbt3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt2);
            this.groupBox1.Controls.Add(this.rbt3);
            this.groupBox1.Controls.Add(this.rbt1);
            this.groupBox1.Location = new System.Drawing.Point(262, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 128);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lugar de Recarga";
            // 
            // CBOX1
            // 
            this.CBOX1.AutoSize = true;
            this.CBOX1.Location = new System.Drawing.Point(16, 116);
            this.CBOX1.Name = "CBOX1";
            this.CBOX1.Size = new System.Drawing.Size(111, 22);
            this.CBOX1.TabIndex = 12;
            this.CBOX1.Text = "Cdgo. Tarjeta:";
            this.CBOX1.UseVisualStyleBackColor = true;
            this.CBOX1.CheckedChanged += new System.EventHandler(this.CBOX1_CheckedChanged);
            // 
            // tbcdgo
            // 
            this.tbcdgo.Enabled = false;
            this.tbcdgo.Location = new System.Drawing.Point(129, 113);
            this.tbcdgo.Name = "tbcdgo";
            this.tbcdgo.Size = new System.Drawing.Size(97, 26);
            this.tbcdgo.TabIndex = 13;
            // 
            // TBOX1
            // 
            this.TBOX1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBOX1.Location = new System.Drawing.Point(392, 362);
            this.TBOX1.Name = "TBOX1";
            this.TBOX1.ReadOnly = true;
            this.TBOX1.Size = new System.Drawing.Size(100, 32);
            this.TBOX1.TabIndex = 14;
            this.TBOX1.Text = "00,00";
            this.TBOX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "TOTAL: $";
            // 
            // frmListRecarga
            // 
            this.AcceptButton = this.btBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBOX1);
            this.Controls.Add(this.tbcdgo);
            this.Controls.Add(this.CBOX1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.btCalendarFin);
            this.Controls.Add(this.lbFechaFin);
            this.Controls.Add(this.lbFechaInit);
            this.Controls.Add(this.btCalendarInit);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmListRecarga";
            this.Text = "Listado de Recargas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalendarInit;
        private System.Windows.Forms.Label lbFechaInit;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.Button btCalendarFin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.RadioButton rbt3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CBOX1;
        private System.Windows.Forms.TextBox tbcdgo;
        private System.Windows.Forms.TextBox TBOX1;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button button3;

    }
}


namespace CtrldeCredito
{
    partial class App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.btAceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.SPortObject = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbSgdos = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt1.Location = new System.Drawing.Point(15, 94);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(183, 23);
            this.rbt1.TabIndex = 0;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Ver Listado de Recargas";
            this.rbt1.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(270, 146);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(96, 28);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(270, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt2.Location = new System.Drawing.Point(15, 132);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(192, 23);
            this.rbt2.TabIndex = 3;
            this.rbt2.TabStop = true;
            this.rbt2.Text = "Configurar Puerto Lectora";
            this.rbt2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 76);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestión de Crédito Servicio de Autolavado";
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt3.Location = new System.Drawing.Point(15, 170);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(172, 23);
            this.rbt3.TabIndex = 5;
            this.rbt3.TabStop = true;
            this.rbt3.Text = "Emulador de Actividad";
            this.rbt3.UseVisualStyleBackColor = true;
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(12, 233);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(354, 10);
            this.pbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbar.TabIndex = 7;
            // 
            // SPortObject
            // 
            this.SPortObject.PortName = "COM3";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.TimerReaderCard_Tick);
            // 
            // lbSgdos
            // 
            this.lbSgdos.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSgdos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbSgdos.Location = new System.Drawing.Point(209, 83);
            this.lbSgdos.Name = "lbSgdos";
            this.lbSgdos.Size = new System.Drawing.Size(157, 60);
            this.lbSgdos.TabIndex = 8;
            this.lbSgdos.Text = "--";
            this.lbSgdos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Red;
            this.lbl2.Location = new System.Drawing.Point(12, 203);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(40, 24);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "lbl2";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 259);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbSgdos);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.rbt3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbt2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.rbt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido /Gestión de Crédito Autolavado/";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbt3;
        private System.Windows.Forms.ProgressBar pbar;
        private System.IO.Ports.SerialPort SPortObject;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbSgdos;
        private System.Windows.Forms.Label lbl2;
    }
}
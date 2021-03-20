namespace CtrldeCredito
{
    partial class frmTicket
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SenderSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.Salir = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.COM1 = new System.Windows.Forms.RadioButton();
            this.COM2 = new System.Windows.Forms.RadioButton();
            this.COM3 = new System.Windows.Forms.RadioButton();
            this.COM4 = new System.Windows.Forms.RadioButton();
            this.btVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SenderSerialPort
            // 
            this.SenderSerialPort.PortName = "COM4";
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(249, 78);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(96, 27);
            this.Salir.TabIndex = 12;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // btOK
            // 
            this.btOK.Enabled = false;
            this.btOK.Location = new System.Drawing.Point(249, 45);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(96, 27);
            this.btOK.TabIndex = 13;
            this.btOK.Text = "Imprimir";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // COM1
            // 
            this.COM1.AutoSize = true;
            this.COM1.Location = new System.Drawing.Point(17, 20);
            this.COM1.Name = "COM1";
            this.COM1.Size = new System.Drawing.Size(68, 21);
            this.COM1.TabIndex = 14;
            this.COM1.Text = "COM1";
            this.COM1.UseVisualStyleBackColor = true;
            // 
            // COM2
            // 
            this.COM2.AutoSize = true;
            this.COM2.Location = new System.Drawing.Point(17, 46);
            this.COM2.Name = "COM2";
            this.COM2.Size = new System.Drawing.Size(68, 21);
            this.COM2.TabIndex = 15;
            this.COM2.Text = "COM2";
            this.COM2.UseVisualStyleBackColor = true;
            // 
            // COM3
            // 
            this.COM3.AutoSize = true;
            this.COM3.Checked = true;
            this.COM3.Location = new System.Drawing.Point(17, 72);
            this.COM3.Name = "COM3";
            this.COM3.Size = new System.Drawing.Size(68, 21);
            this.COM3.TabIndex = 16;
            this.COM3.TabStop = true;
            this.COM3.Text = "COM3";
            this.COM3.UseVisualStyleBackColor = true;
            // 
            // COM4
            // 
            this.COM4.AutoSize = true;
            this.COM4.Location = new System.Drawing.Point(17, 98);
            this.COM4.Name = "COM4";
            this.COM4.Size = new System.Drawing.Size(68, 21);
            this.COM4.TabIndex = 17;
            this.COM4.Text = "COM4";
            this.COM4.UseVisualStyleBackColor = true;
            // 
            // btVer
            // 
            this.btVer.Location = new System.Drawing.Point(249, 12);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(96, 27);
            this.btVer.TabIndex = 18;
            this.btVer.Text = "Verificar";
            this.btVer.UseVisualStyleBackColor = true;
            this.btVer.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 150);
            this.Controls.Add(this.btVer);
            this.Controls.Add(this.COM4);
            this.Controls.Add(this.COM3);
            this.Controls.Add(this.COM2);
            this.Controls.Add(this.COM1);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.Salir);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTicket";
            this.Text = "Imprimir ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort SenderSerialPort;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.RadioButton COM1;
        private System.Windows.Forms.RadioButton COM2;
        private System.Windows.Forms.RadioButton COM3;
        private System.Windows.Forms.RadioButton COM4;
        private System.Windows.Forms.Button btVer;
    }
}
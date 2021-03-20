namespace CtrldeCredito
{
    partial class frmAddCredito
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
            this.lbOutput = new System.Windows.Forms.Label();
            this.btSetImporte = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.lblCdgoTarjeta = new System.Windows.Forms.Label();
            this.btDtsCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOutput
            // 
            this.lbOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbOutput.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.Location = new System.Drawing.Point(12, 59);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(313, 88);
            this.lbOutput.TabIndex = 1;
            this.lbOutput.Text = "_";
            this.lbOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btSetImporte
            // 
            this.btSetImporte.Location = new System.Drawing.Point(214, 21);
            this.btSetImporte.Name = "btSetImporte";
            this.btSetImporte.Size = new System.Drawing.Size(111, 25);
            this.btSetImporte.TabIndex = 2;
            this.btSetImporte.TabStop = false;
            this.btSetImporte.Text = "Ingresar Importe";
            this.btSetImporte.UseVisualStyleBackColor = true;
            this.btSetImporte.Click += new System.EventHandler(this.btSetImporte_Click);
            this.btSetImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSetCredito_KeyPress);
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(12, 159);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(136, 28);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "Aceptar";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lblCdgoTarjeta
            // 
            this.lblCdgoTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCdgoTarjeta.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCdgoTarjeta.Location = new System.Drawing.Point(10, 9);
            this.lblCdgoTarjeta.Name = "lblCdgoTarjeta";
            this.lblCdgoTarjeta.Size = new System.Drawing.Size(198, 37);
            this.lblCdgoTarjeta.TabIndex = 5;
            this.lblCdgoTarjeta.Text = "lblCdgoTarjeta";
            this.lblCdgoTarjeta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btDtsCliente
            // 
            this.btDtsCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDtsCliente.Location = new System.Drawing.Point(189, 159);
            this.btDtsCliente.Name = "btDtsCliente";
            this.btDtsCliente.Size = new System.Drawing.Size(136, 28);
            this.btDtsCliente.TabIndex = 6;
            this.btDtsCliente.Text = "Datos Cliente";
            this.btDtsCliente.UseVisualStyleBackColor = true;
            this.btDtsCliente.Click += new System.EventHandler(this.btDtsCliente_Click);
            // 
            // frmAddCredito
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 199);
            this.Controls.Add(this.btDtsCliente);
            this.Controls.Add(this.lblCdgoTarjeta);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btSetImporte);
            this.Controls.Add(this.lbOutput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCredito";
            this.Text = "Agregar Saldo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Button btSetImporte;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lblCdgoTarjeta;
        private System.Windows.Forms.Button btDtsCliente;


    }
}
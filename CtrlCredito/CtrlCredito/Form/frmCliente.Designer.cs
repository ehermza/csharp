namespace CtrldeCredito
{
    partial class frmCliente
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
            this.tbFbk = new System.Windows.Forms.TextBox();
            this.tbDomicilio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTarjeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.tbDocNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EP1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbel13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EP1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFbk
            // 
            this.tbFbk.Location = new System.Drawing.Point(122, 330);
            this.tbFbk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFbk.MaxLength = 127;
            this.tbFbk.Name = "tbFbk";
            this.tbFbk.Size = new System.Drawing.Size(159, 20);
            this.tbFbk.TabIndex = 7;
            // 
            // tbDomicilio
            // 
            this.tbDomicilio.Location = new System.Drawing.Point(122, 201);
            this.tbDomicilio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDomicilio.MaxLength = 127;
            this.tbDomicilio.Name = "tbDomicilio";
            this.tbDomicilio.Size = new System.Drawing.Size(428, 20);
            this.tbDomicilio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Domicilio: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(391, 242);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTelefono.MaxLength = 63;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(159, 20);
            this.tbTelefono.TabIndex = 5;
            this.tbTelefono.TextChanged += new System.EventHandler(this.tbTelefono_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(287, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Telef. Fijo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(122, 242);
            this.tbCelular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCelular.MaxLength = 63;
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(159, 20);
            this.tbCelular.TabIndex = 4;
            this.tbCelular.TextChanged += new System.EventHandler(this.tbCelular_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 36;
            this.label5.Text = "Celular: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPatente
            // 
            this.tbPatente.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F);
            this.tbPatente.Location = new System.Drawing.Point(122, 138);
            this.tbPatente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPatente.MaxLength = 63;
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(104, 44);
            this.tbPatente.TabIndex = 1;
            this.tbPatente.Text = "CFK678";
            this.tbPatente.TextChanged += new System.EventHandler(this.tbPatente_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 28);
            this.label6.TabIndex = 35;
            this.label6.Text = "Patente:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(122, 87);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNombre.MaxLength = 63;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(428, 44);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.Text = "tbNombre";
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 48);
            this.label7.TabIndex = 34;
            this.label7.Text = "Apellido y Nombre:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 30;
            this.label2.Text = "facebook.com/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTarjeta
            // 
            this.tbTarjeta.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTarjeta.Location = new System.Drawing.Point(122, 31);
            this.tbTarjeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTarjeta.Name = "tbTarjeta";
            this.tbTarjeta.ReadOnly = true;
            this.tbTarjeta.Size = new System.Drawing.Size(225, 39);
            this.tbTarjeta.TabIndex = 28;
            this.tbTarjeta.Text = "tbtarjeta";
            this.tbTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "E-Mail: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(122, 285);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.MaxLength = 127;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(159, 20);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(439, 298);
            this.btOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(112, 28);
            this.btOK.TabIndex = 7;
            this.btOK.Text = "Aceptar";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(439, 334);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 28);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btModificar
            // 
            this.btModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.ForeColor = System.Drawing.Color.Black;
            this.btModificar.Location = new System.Drawing.Point(321, 334);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(112, 28);
            this.btModificar.TabIndex = 51;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btAddCredito_Click);
            // 
            // tbDocNumber
            // 
            this.tbDocNumber.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F);
            this.tbDocNumber.Location = new System.Drawing.Point(378, 138);
            this.tbDocNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDocNumber.MaxLength = 63;
            this.tbDocNumber.Name = "tbDocNumber";
            this.tbDocNumber.Size = new System.Drawing.Size(172, 44);
            this.tbDocNumber.TabIndex = 2;
            this.tbDocNumber.Text = "tbDocNumber";
            this.tbDocNumber.TextChanged += new System.EventHandler(this.tbDocNumber_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(335, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 19);
            this.label9.TabIndex = 54;
            this.label9.Text = "DNI:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EP1
            // 
            this.EP1.ContainerControl = this;
            // 
            // lbel13
            // 
            this.lbel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbel13.Font = new System.Drawing.Font("Broadway", 20.25F);
            this.EP1.SetIconAlignment(this.lbel13, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.lbel13.Location = new System.Drawing.Point(434, 31);
            this.lbel13.Name = "lbel13";
            this.lbel13.Size = new System.Drawing.Size(116, 39);
            this.lbel13.TabIndex = 58;
            this.lbel13.Text = "lbel13";
            this.lbel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(556, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 24);
            this.label10.TabIndex = 55;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(556, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 56;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Los Campos con asterisco (*) son obligatorios.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(401, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 33);
            this.label13.TabIndex = 59;
            this.label13.Text = "$";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tarjeta:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCliente
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 369);
            this.Controls.Add(this.lbel13);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbDocNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.tbFbk);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbDomicilio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCelular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPatente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTarjeta);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.EP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFbk;
        private System.Windows.Forms.TextBox tbDomicilio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPatente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.TextBox tbDocNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider EP1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbel13;
        private System.Windows.Forms.Label label1;
    }
}


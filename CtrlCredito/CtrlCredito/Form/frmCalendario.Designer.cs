namespace CtrldeCredito
{
    partial class frmCalendario
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
            this.MyCalendario = new System.Windows.Forms.MonthCalendar();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyCalendario
            // 
            this.MyCalendario.Location = new System.Drawing.Point(13, 13);
            this.MyCalendario.Name = "MyCalendario";
            this.MyCalendario.TabIndex = 0;
            this.MyCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(252, 146);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(62, 29);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // frmCalendario
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 190);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.MyCalendario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalendario";
            this.Text = "Elegir Fecha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MyCalendario;
        private System.Windows.Forms.Button btOK;
    }
}
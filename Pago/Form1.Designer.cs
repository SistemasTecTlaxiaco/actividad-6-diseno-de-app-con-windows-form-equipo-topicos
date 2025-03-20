namespace Pago
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancelarPago = new System.Windows.Forms.Button();
            this.btnVerificarPago = new System.Windows.Forms.Button();
            this.btnRealizarPago = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Idpago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMetodopago = new System.Windows.Forms.Label();
            this.txtReserva = new System.Windows.Forms.Label();
            this.txtIdPago = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 30;
            // 
            // btnCancelarPago
            // 
            this.btnCancelarPago.Location = new System.Drawing.Point(495, 278);
            this.btnCancelarPago.Name = "btnCancelarPago";
            this.btnCancelarPago.Size = new System.Drawing.Size(136, 56);
            this.btnCancelarPago.TabIndex = 29;
            this.btnCancelarPago.Text = "Calncelar Pago";
            this.btnCancelarPago.UseVisualStyleBackColor = true;
            // 
            // btnVerificarPago
            // 
            this.btnVerificarPago.Location = new System.Drawing.Point(297, 278);
            this.btnVerificarPago.Name = "btnVerificarPago";
            this.btnVerificarPago.Size = new System.Drawing.Size(136, 56);
            this.btnVerificarPago.TabIndex = 28;
            this.btnVerificarPago.Text = "Verificar Pago";
            this.btnVerificarPago.UseVisualStyleBackColor = true;
            // 
            // btnRealizarPago
            // 
            this.btnRealizarPago.Location = new System.Drawing.Point(129, 278);
            this.btnRealizarPago.Name = "btnRealizarPago";
            this.btnRealizarPago.Size = new System.Drawing.Size(136, 56);
            this.btnRealizarPago.TabIndex = 27;
            this.btnRealizarPago.Text = "Realizar Pago";
            this.btnRealizarPago.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(514, 209);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 20);
            this.textBox4.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(514, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 23;
            // 
            // Idpago
            // 
            this.Idpago.Location = new System.Drawing.Point(159, 116);
            this.Idpago.Name = "Idpago";
            this.Idpago.Size = new System.Drawing.Size(161, 20);
            this.Idpago.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fecha de Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Monto ";
            // 
            // txtMetodopago
            // 
            this.txtMetodopago.AutoSize = true;
            this.txtMetodopago.Location = new System.Drawing.Point(85, 209);
            this.txtMetodopago.Name = "txtMetodopago";
            this.txtMetodopago.Size = new System.Drawing.Size(91, 13);
            this.txtMetodopago.TabIndex = 18;
            this.txtMetodopago.Text = "Metodod de pago";
            // 
            // txtReserva
            // 
            this.txtReserva.AutoSize = true;
            this.txtReserva.Location = new System.Drawing.Point(85, 161);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(62, 13);
            this.txtReserva.TabIndex = 17;
            this.txtReserva.Text = "Id Reserva ";
            // 
            // txtIdPago
            // 
            this.txtIdPago.AutoSize = true;
            this.txtIdPago.Location = new System.Drawing.Point(85, 119);
            this.txtIdPago.Name = "txtIdPago";
            this.txtIdPago.Size = new System.Drawing.Size(44, 13);
            this.txtIdPago.TabIndex = 16;
            this.txtIdPago.Text = "Id Pago";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelarPago);
            this.Controls.Add(this.btnVerificarPago);
            this.Controls.Add(this.btnRealizarPago);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Idpago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMetodopago);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.txtIdPago);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancelarPago;
        private System.Windows.Forms.Button btnVerificarPago;
        private System.Windows.Forms.Button btnRealizarPago;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Idpago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtMetodopago;
        private System.Windows.Forms.Label txtReserva;
        private System.Windows.Forms.Label txtIdPago;
    }
}


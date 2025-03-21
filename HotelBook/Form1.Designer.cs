namespace HotelBook
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
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnsesion = new System.Windows.Forms.Button();
            this.btnCerarsesion = new System.Windows.Forms.Button();
            this.btnModificraperfil = new System.Windows.Forms.Button();
            this.idusuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nombreusuario = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.apellidousuario = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.emailusuario = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.contraseñausuario = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.clienteaodministrador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnregistrar
            // 
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(598, 40);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(163, 50);
            this.btnregistrar.TabIndex = 0;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsesion
            // 
            this.btnsesion.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsesion.Location = new System.Drawing.Point(598, 103);
            this.btnsesion.Name = "btnsesion";
            this.btnsesion.Size = new System.Drawing.Size(163, 51);
            this.btnsesion.TabIndex = 1;
            this.btnsesion.Text = "iniciar sesion ";
            this.btnsesion.UseVisualStyleBackColor = true;
            this.btnsesion.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCerarsesion
            // 
            this.btnCerarsesion.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerarsesion.Location = new System.Drawing.Point(598, 175);
            this.btnCerarsesion.Name = "btnCerarsesion";
            this.btnCerarsesion.Size = new System.Drawing.Size(163, 49);
            this.btnCerarsesion.TabIndex = 2;
            this.btnCerarsesion.Text = "cerrar sesion";
            this.btnCerarsesion.UseVisualStyleBackColor = true;
            this.btnCerarsesion.Click += new System.EventHandler(this.btnCerarsesion_Click);
            // 
            // btnModificraperfil
            // 
            this.btnModificraperfil.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificraperfil.Location = new System.Drawing.Point(598, 248);
            this.btnModificraperfil.Name = "btnModificraperfil";
            this.btnModificraperfil.Size = new System.Drawing.Size(167, 52);
            this.btnModificraperfil.TabIndex = 3;
            this.btnModificraperfil.Text = "Modificar perfil";
            this.btnModificraperfil.UseVisualStyleBackColor = true;
            this.btnModificraperfil.Click += new System.EventHandler(this.btnModificraperfil_Click);
            // 
            // idusuario
            // 
            this.idusuario.AutoSize = true;
            this.idusuario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idusuario.Location = new System.Drawing.Point(26, 49);
            this.idusuario.Name = "idusuario";
            this.idusuario.Size = new System.Drawing.Size(122, 25);
            this.idusuario.TabIndex = 4;
            this.idusuario.Text = "ID de usuario:";
            this.idusuario.Click += new System.EventHandler(this.idusuario_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nombreusuario
            // 
            this.nombreusuario.AutoSize = true;
            this.nombreusuario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreusuario.Location = new System.Drawing.Point(28, 92);
            this.nombreusuario.Name = "nombreusuario";
            this.nombreusuario.Size = new System.Drawing.Size(79, 25);
            this.nombreusuario.TabIndex = 6;
            this.nombreusuario.Text = "Nombre:";
            this.nombreusuario.Click += new System.EventHandler(this.nombreusuario_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(363, 20);
            this.textBox2.TabIndex = 7;
            // 
            // apellidousuario
            // 
            this.apellidousuario.AutoSize = true;
            this.apellidousuario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidousuario.Location = new System.Drawing.Point(28, 129);
            this.apellidousuario.Name = "apellidousuario";
            this.apellidousuario.Size = new System.Drawing.Size(80, 25);
            this.apellidousuario.TabIndex = 8;
            this.apellidousuario.Text = "Apellido:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(363, 20);
            this.textBox3.TabIndex = 9;
            // 
            // emailusuario
            // 
            this.emailusuario.AutoSize = true;
            this.emailusuario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailusuario.Location = new System.Drawing.Point(28, 166);
            this.emailusuario.Name = "emailusuario";
            this.emailusuario.Size = new System.Drawing.Size(82, 25);
            this.emailusuario.TabIndex = 10;
            this.emailusuario.Text = "Email @:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 171);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(363, 20);
            this.textBox4.TabIndex = 11;
            // 
            // contraseñausuario
            // 
            this.contraseñausuario.AutoSize = true;
            this.contraseñausuario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñausuario.Location = new System.Drawing.Point(26, 208);
            this.contraseñausuario.Name = "contraseñausuario";
            this.contraseñausuario.Size = new System.Drawing.Size(109, 25);
            this.contraseñausuario.TabIndex = 12;
            this.contraseñausuario.Text = "Contraseña:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(149, 214);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(363, 20);
            this.textBox5.TabIndex = 13;
            // 
            // clienteaodministrador
            // 
            this.clienteaodministrador.FormattingEnabled = true;
            this.clienteaodministrador.Location = new System.Drawing.Point(203, 264);
            this.clienteaodministrador.Name = "clienteaodministrador";
            this.clienteaodministrador.Size = new System.Drawing.Size(155, 21);
            this.clienteaodministrador.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 336);
            this.Controls.Add(this.clienteaodministrador);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.contraseñausuario);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.emailusuario);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.apellidousuario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nombreusuario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.idusuario);
            this.Controls.Add(this.btnModificraperfil);
            this.Controls.Add(this.btnCerarsesion);
            this.Controls.Add(this.btnsesion);
            this.Controls.Add(this.btnregistrar);
            this.Name = "Form1";
            this.Text = ".";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnsesion;
        private System.Windows.Forms.Button btnCerarsesion;
        private System.Windows.Forms.Button btnModificraperfil;
        private System.Windows.Forms.Label idusuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nombreusuario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label apellidousuario;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label emailusuario;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label contraseñausuario;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox clienteaodministrador;
    }
}



namespace Cibercafe_ElVicio
{
    partial class FrmHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorial));
            this.btnListCompu = new System.Windows.Forms.Button();
            this.btnListCabin = new System.Windows.Forms.Button();
            this.btnGanancias = new System.Windows.Forms.Button();
            this.btnHorasYRecaudacion = new System.Windows.Forms.Button();
            this.btnSoftware = new System.Windows.Forms.Button();
            this.btnPeriferico = new System.Windows.Forms.Button();
            this.btnJuego = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rtbHistorial = new System.Windows.Forms.RichTextBox();
            this.ibtnAyuda = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnListCompu
            // 
            this.btnListCompu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnListCompu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnListCompu.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListCompu.Location = new System.Drawing.Point(11, 6);
            this.btnListCompu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListCompu.Name = "btnListCompu";
            this.btnListCompu.Size = new System.Drawing.Size(498, 32);
            this.btnListCompu.TabIndex = 1;
            this.btnListCompu.Text = "Lista de computadoras ordenadas por minutos de uso de forma descendente";
            this.btnListCompu.UseVisualStyleBackColor = false;
            this.btnListCompu.Click += new System.EventHandler(this.BtnListCompu_Click);
            // 
            // btnListCabin
            // 
            this.btnListCabin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnListCabin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnListCabin.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListCabin.Location = new System.Drawing.Point(11, 46);
            this.btnListCabin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListCabin.Name = "btnListCabin";
            this.btnListCabin.Size = new System.Drawing.Size(498, 28);
            this.btnListCabin.TabIndex = 2;
            this.btnListCabin.Text = "Lista de cabinas ordenadas por minutos de uso de forma descendente";
            this.btnListCabin.UseVisualStyleBackColor = false;
            this.btnListCabin.Click += new System.EventHandler(this.BtnListCabin_Click);
            // 
            // btnGanancias
            // 
            this.btnGanancias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGanancias.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGanancias.Location = new System.Drawing.Point(14, 81);
            this.btnGanancias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Size = new System.Drawing.Size(495, 28);
            this.btnGanancias.TabIndex = 3;
            this.btnGanancias.Text = "Ganancias totales y clasificadas por servicio (teléfono/computadora)";
            this.btnGanancias.UseVisualStyleBackColor = false;
            this.btnGanancias.Click += new System.EventHandler(this.BtnGanancias_Click);
            // 
            // btnHorasYRecaudacion
            // 
            this.btnHorasYRecaudacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHorasYRecaudacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHorasYRecaudacion.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHorasYRecaudacion.Location = new System.Drawing.Point(14, 116);
            this.btnHorasYRecaudacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHorasYRecaudacion.Name = "btnHorasYRecaudacion";
            this.btnHorasYRecaudacion.Size = new System.Drawing.Size(495, 28);
            this.btnHorasYRecaudacion.TabIndex = 4;
            this.btnHorasYRecaudacion.Text = "Horas totales y la recaudación por tipo de llamada";
            this.btnHorasYRecaudacion.UseVisualStyleBackColor = false;
            this.btnHorasYRecaudacion.Click += new System.EventHandler(this.BtnHorasYRecaudacion_Click);
            // 
            // btnSoftware
            // 
            this.btnSoftware.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSoftware.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSoftware.Location = new System.Drawing.Point(14, 152);
            this.btnSoftware.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.Size = new System.Drawing.Size(495, 28);
            this.btnSoftware.TabIndex = 5;
            this.btnSoftware.Text = "El software más pedido por los clientes";
            this.btnSoftware.UseVisualStyleBackColor = false;
            this.btnSoftware.Click += new System.EventHandler(this.BtnSoftware_Click);
            // 
            // btnPeriferico
            // 
            this.btnPeriferico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPeriferico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPeriferico.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPeriferico.Location = new System.Drawing.Point(14, 185);
            this.btnPeriferico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPeriferico.Name = "btnPeriferico";
            this.btnPeriferico.Size = new System.Drawing.Size(495, 28);
            this.btnPeriferico.TabIndex = 6;
            this.btnPeriferico.Text = "El periférico más pedido por los clientes";
            this.btnPeriferico.UseVisualStyleBackColor = false;
            this.btnPeriferico.Click += new System.EventHandler(this.BtnPeriferico_Click);
            // 
            // btnJuego
            // 
            this.btnJuego.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnJuego.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJuego.Location = new System.Drawing.Point(14, 220);
            this.btnJuego.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnJuego.Name = "btnJuego";
            this.btnJuego.Size = new System.Drawing.Size(495, 28);
            this.btnJuego.TabIndex = 7;
            this.btnJuego.Text = "El juego más pedido por los clientes";
            this.btnJuego.UseVisualStyleBackColor = false;
            this.btnJuego.Click += new System.EventHandler(this.BtnJuego_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSalir.Location = new System.Drawing.Point(745, 256);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 28);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // rtbHistorial
            // 
            this.rtbHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbHistorial.Location = new System.Drawing.Point(515, 6);
            this.rtbHistorial.MinimumSize = new System.Drawing.Size(313, 243);
            this.rtbHistorial.Name = "rtbHistorial";
            this.rtbHistorial.ReadOnly = true;
            this.rtbHistorial.Size = new System.Drawing.Size(313, 243);
            this.rtbHistorial.TabIndex = 8;
            this.rtbHistorial.Text = "";
            // 
            // ibtnAyuda
            // 
            this.ibtnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ibtnAyuda.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.ibtnAyuda.IconColor = System.Drawing.Color.Black;
            this.ibtnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAyuda.IconSize = 25;
            this.ibtnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAyuda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ibtnAyuda.Location = new System.Drawing.Point(14, 256);
            this.ibtnAyuda.Name = "ibtnAyuda";
            this.ibtnAyuda.Size = new System.Drawing.Size(84, 28);
            this.ibtnAyuda.TabIndex = 10;
            this.ibtnAyuda.Text = "Ayuda";
            this.ibtnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAyuda.UseVisualStyleBackColor = false;
            this.ibtnAyuda.Click += new System.EventHandler(this.IbtnAyuda_Click);
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(840, 288);
            this.Controls.Add(this.ibtnAyuda);
            this.Controls.Add(this.rtbHistorial);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnJuego);
            this.Controls.Add(this.btnPeriferico);
            this.Controls.Add(this.btnSoftware);
            this.Controls.Add(this.btnHorasYRecaudacion);
            this.Controls.Add(this.btnGanancias);
            this.Controls.Add(this.btnListCabin);
            this.Controls.Add(this.btnListCompu);
            this.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(856, 327);
            this.Name = "FrmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHistorial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListCompu;
        private System.Windows.Forms.Button btnListCabin;
        private System.Windows.Forms.Button btnGanancias;
        private System.Windows.Forms.Button btnHorasYRecaudacion;
        private System.Windows.Forms.Button btnSoftware;
        private System.Windows.Forms.Button btnPeriferico;
        private System.Windows.Forms.Button btnJuego;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RichTextBox rtbHistorial;
        private FontAwesome.Sharp.IconButton ibtnAyuda;
    }
}
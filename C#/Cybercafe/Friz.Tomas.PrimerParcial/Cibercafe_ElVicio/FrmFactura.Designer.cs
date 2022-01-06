
namespace Cibercafe_ElVicio
{
    partial class FrmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCafe = new System.Windows.Forms.CheckBox();
            this.cbSoda = new System.Windows.Forms.CheckBox();
            this.cbDona = new System.Windows.Forms.CheckBox();
            this.cbTostado = new System.Windows.Forms.CheckBox();
            this.gpbAperitivos = new System.Windows.Forms.GroupBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.ibtnAyuda = new FontAwesome.Sharp.IconButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.gpbAperitivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Factura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIVA
            // 
            this.lblIVA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIVA.Location = new System.Drawing.Point(5, 246);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(180, 28);
            this.lblIVA.TabIndex = 4;
            this.lblIVA.Text = "Costo con IVA:";
            this.lblIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPagar.Location = new System.Drawing.Point(129, 320);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(140, 28);
            this.btnPagar.TabIndex = 5;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // lblDuracion
            // 
            this.lblDuracion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDuracion.Location = new System.Drawing.Point(5, 190);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(180, 28);
            this.lblDuracion.TabIndex = 10;
            this.lblDuracion.Text = "Duracion: ";
            this.lblDuracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCosto
            // 
            this.lblCosto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCosto.Location = new System.Drawing.Point(5, 218);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(180, 28);
            this.lblCosto.TabIndex = 11;
            this.lblCosto.Text = "Costo: ";
            this.lblCosto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(392, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Aperitivos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCafe
            // 
            this.cbCafe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCafe.Location = new System.Drawing.Point(7, 35);
            this.cbCafe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCafe.Name = "cbCafe";
            this.cbCafe.Size = new System.Drawing.Size(90, 23);
            this.cbCafe.TabIndex = 6;
            this.cbCafe.Text = "Cafe: $10";
            this.cbCafe.UseVisualStyleBackColor = true;
            // 
            // cbSoda
            // 
            this.cbSoda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSoda.Location = new System.Drawing.Point(103, 34);
            this.cbSoda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSoda.Name = "cbSoda";
            this.cbSoda.Size = new System.Drawing.Size(86, 23);
            this.cbSoda.TabIndex = 7;
            this.cbSoda.Text = "Soda: $5";
            this.cbSoda.UseVisualStyleBackColor = true;
            // 
            // cbDona
            // 
            this.cbDona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDona.Location = new System.Drawing.Point(300, 34);
            this.cbDona.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDona.Name = "cbDona";
            this.cbDona.Size = new System.Drawing.Size(90, 22);
            this.cbDona.TabIndex = 9;
            this.cbDona.Text = "Dona: $20";
            this.cbDona.UseVisualStyleBackColor = true;
            // 
            // cbTostado
            // 
            this.cbTostado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTostado.Location = new System.Drawing.Point(185, 34);
            this.cbTostado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTostado.Name = "cbTostado";
            this.cbTostado.Size = new System.Drawing.Size(109, 22);
            this.cbTostado.TabIndex = 8;
            this.cbTostado.Text = "Tostado: $25";
            this.cbTostado.UseVisualStyleBackColor = true;
            // 
            // gpbAperitivos
            // 
            this.gpbAperitivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAperitivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gpbAperitivos.Controls.Add(this.cbTostado);
            this.gpbAperitivos.Controls.Add(this.cbCafe);
            this.gpbAperitivos.Controls.Add(this.cbSoda);
            this.gpbAperitivos.Controls.Add(this.cbDona);
            this.gpbAperitivos.Location = new System.Drawing.Point(5, 34);
            this.gpbAperitivos.Name = "gpbAperitivos";
            this.gpbAperitivos.Size = new System.Drawing.Size(390, 78);
            this.gpbAperitivos.TabIndex = 1;
            this.gpbAperitivos.TabStop = false;
            this.gpbAperitivos.Text = "Tipos de aperitivos";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDuracion.Location = new System.Drawing.Point(213, 192);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(182, 23);
            this.txtDuracion.TabIndex = 2;
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCosto.Location = new System.Drawing.Point(213, 220);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(182, 23);
            this.txtCosto.TabIndex = 3;
            // 
            // txtIVA
            // 
            this.txtIVA.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtIVA.Location = new System.Drawing.Point(213, 248);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(182, 23);
            this.txtIVA.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrar.Location = new System.Drawing.Point(275, 320);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 28);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
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
            this.ibtnAyuda.Location = new System.Drawing.Point(5, 320);
            this.ibtnAyuda.Name = "ibtnAyuda";
            this.ibtnAyuda.Size = new System.Drawing.Size(116, 28);
            this.ibtnAyuda.TabIndex = 13;
            this.ibtnAyuda.Text = "Ayuda";
            this.ibtnAyuda.UseVisualStyleBackColor = false;
            this.ibtnAyuda.Click += new System.EventHandler(this.IbtnAyuda_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTipo.Location = new System.Drawing.Point(5, 165);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(180, 28);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo: ";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTipo
            // 
            this.txtTipo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTipo.Location = new System.Drawing.Point(213, 167);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(182, 23);
            this.txtTipo.TabIndex = 15;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(400, 357);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.ibtnAyuda);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.gpbAperitivos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(403, 313);
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFactura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.gpbAperitivos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbCafe;
        private System.Windows.Forms.CheckBox cbSoda;
        private System.Windows.Forms.CheckBox cbDona;
        private System.Windows.Forms.CheckBox cbTostado;
        private System.Windows.Forms.GroupBox gpbAperitivos;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Button btnCerrar;
        private FontAwesome.Sharp.IconButton ibtnAyuda;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
    }
}

namespace Cibercafe_ElVicio
{
    partial class FrmComputadoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComputadoras));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rctEspecificaciones = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbComputadoras = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTiempoLimite = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtLimitado = new System.Windows.Forms.RadioButton();
            this.rbtIlimitado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.ibtnAyuda = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempoLimite)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rctEspecificaciones);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbComputadoras);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudTiempoLimite);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDatos);
            this.panel1.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 408);
            this.panel1.TabIndex = 4;
            // 
            // rctEspecificaciones
            // 
            this.rctEspecificaciones.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rctEspecificaciones.Location = new System.Drawing.Point(3, 34);
            this.rctEspecificaciones.Name = "rctEspecificaciones";
            this.rctEspecificaciones.ReadOnly = true;
            this.rctEspecificaciones.Size = new System.Drawing.Size(274, 364);
            this.rctEspecificaciones.TabIndex = 1;
            this.rctEspecificaciones.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(283, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Computadoras";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbComputadoras
            // 
            this.cmbComputadoras.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbComputadoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComputadoras.FormattingEnabled = true;
            this.cmbComputadoras.Location = new System.Drawing.Point(283, 187);
            this.cmbComputadoras.Name = "cmbComputadoras";
            this.cmbComputadoras.Size = new System.Drawing.Size(268, 26);
            this.cmbComputadoras.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(283, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Datos del cliente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTiempoLimite
            // 
            this.nudTiempoLimite.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nudTiempoLimite.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudTiempoLimite.Location = new System.Drawing.Point(283, 109);
            this.nudTiempoLimite.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nudTiempoLimite.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudTiempoLimite.Name = "nudTiempoLimite";
            this.nudTiempoLimite.ReadOnly = true;
            this.nudTiempoLimite.Size = new System.Drawing.Size(268, 23);
            this.nudTiempoLimite.TabIndex = 3;
            this.nudTiempoLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTiempoLimite.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudTiempoLimite.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbtLimitado);
            this.groupBox1.Controls.Add(this.rbtIlimitado);
            this.groupBox1.Location = new System.Drawing.Point(283, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de tiempo:";
            // 
            // rbtLimitado
            // 
            this.rbtLimitado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtLimitado.Location = new System.Drawing.Point(15, 60);
            this.rbtLimitado.Name = "rbtLimitado";
            this.rbtLimitado.Size = new System.Drawing.Size(232, 34);
            this.rbtLimitado.TabIndex = 3;
            this.rbtLimitado.Text = "Tiempo Limitado";
            this.rbtLimitado.UseVisualStyleBackColor = true;
            this.rbtLimitado.CheckedChanged += new System.EventHandler(this.RbtLimitado_CheckedChanged);
            // 
            // rbtIlimitado
            // 
            this.rbtIlimitado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtIlimitado.Checked = true;
            this.rbtIlimitado.Location = new System.Drawing.Point(15, 22);
            this.rbtIlimitado.Name = "rbtIlimitado";
            this.rbtIlimitado.Size = new System.Drawing.Size(232, 32);
            this.rbtIlimitado.TabIndex = 2;
            this.rbtIlimitado.TabStop = true;
            this.rbtIlimitado.Text = "Tiempo Ilimitado";
            this.rbtIlimitado.UseVisualStyleBackColor = true;
            this.rbtIlimitado.CheckedChanged += new System.EventHandler(this.RbtIlimitado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Especificaciones del clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatos
            // 
            this.lblDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatos.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDatos.Location = new System.Drawing.Point(283, 260);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(268, 138);
            this.lblDatos.TabIndex = 14;
            this.lblDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConectar.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConectar.Location = new System.Drawing.Point(220, 426);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(142, 28);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrar.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(495, 426);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 28);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // ibtnAyuda
            // 
            this.ibtnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ibtnAyuda.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnAyuda.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.ibtnAyuda.IconColor = System.Drawing.Color.Black;
            this.ibtnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAyuda.IconSize = 25;
            this.ibtnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAyuda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ibtnAyuda.Location = new System.Drawing.Point(12, 426);
            this.ibtnAyuda.Name = "ibtnAyuda";
            this.ibtnAyuda.Size = new System.Drawing.Size(84, 28);
            this.ibtnAyuda.TabIndex = 11;
            this.ibtnAyuda.Text = "Ayuda";
            this.ibtnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAyuda.UseVisualStyleBackColor = false;
            this.ibtnAyuda.Click += new System.EventHandler(this.IbtnAyuda_Click);
            // 
            // FrmComputadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(582, 456);
            this.Controls.Add(this.ibtnAyuda);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConectar);
            this.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(598, 495);
            this.Name = "FrmComputadoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmComputadoras";
            this.Load += new System.EventHandler(this.FrmComputadoras_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempoLimite)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtLimitado;
        private System.Windows.Forms.RadioButton rbtIlimitado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTiempoLimite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbComputadoras;
        private System.Windows.Forms.RichTextBox rctEspecificaciones;
        private FontAwesome.Sharp.IconButton ibtnAyuda;
    }
}
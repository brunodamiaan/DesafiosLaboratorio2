
namespace Clase18
{
    partial class form1
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
            this.Titulo = new System.Windows.Forms.Label();
            this.tipoDePrenda = new System.Windows.Forms.Label();
            this.Camisa = new System.Windows.Forms.RadioButton();
            this.Pantalon = new System.Windows.Forms.RadioButton();
            this.checkMangaCorta = new System.Windows.Forms.CheckBox();
            this.checkBermuda = new System.Windows.Forms.CheckBox();
            this.calidadDePrenda = new System.Windows.Forms.Label();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.radioPremium = new System.Windows.Forms.RadioButton();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.buttonCalcularPrecio = new System.Windows.Forms.Button();
            this.textTotal = new System.Windows.Forms.Label();
            this.mostrarPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.Titulo.Location = new System.Drawing.Point(9, 9);
            this.Titulo.Name = "Título";
            this.Titulo.Size = new System.Drawing.Size(179, 15);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Venta al mayor";
            // 
            // tipoDePrenda
            // 
            this.tipoDePrenda.AutoSize = true;
            this.tipoDePrenda.Location = new System.Drawing.Point(12, 40);
            this.tipoDePrenda.Name = "tipoDePrenda";
            this.tipoDePrenda.Size = new System.Drawing.Size(80, 13);
            this.tipoDePrenda.TabIndex = 1;
            this.tipoDePrenda.Text = "Tipo de Prenda";
            // 
            // Camisa
            // 
            this.Camisa.AutoSize = true;
            this.Camisa.Location = new System.Drawing.Point(15, 68);
            this.Camisa.Name = "Camisa";
            this.Camisa.Size = new System.Drawing.Size(59, 17);
            this.Camisa.TabIndex = 2;
            this.Camisa.TabStop = true;
            this.Camisa.Text = "Camisa";
            this.Camisa.UseVisualStyleBackColor = true;
            this.Camisa.CheckedChanged += new System.EventHandler(this.Camisa_CheckedChanged);
            // 
            // Pantalon
            // 
            this.Pantalon.AutoSize = true;
            this.Pantalon.Location = new System.Drawing.Point(15, 92);
            this.Pantalon.Name = "Pantalon";
            this.Pantalon.Size = new System.Drawing.Size(67, 17);
            this.Pantalon.TabIndex = 3;
            this.Pantalon.TabStop = true;
            this.Pantalon.Text = "Pantalón";
            this.Pantalon.UseVisualStyleBackColor = true;
            this.Pantalon.CheckedChanged += new System.EventHandler(this.Pantalon_CheckedChanged);
            // 
            // checkMangaCorta
            // 
            this.checkMangaCorta.AutoSize = true;
            this.checkMangaCorta.Location = new System.Drawing.Point(102, 69);
            this.checkMangaCorta.Name = "checkMangaCorta";
            this.checkMangaCorta.Size = new System.Drawing.Size(86, 17);
            this.checkMangaCorta.TabIndex = 4;
            this.checkMangaCorta.Text = "Manga corta";
            this.checkMangaCorta.UseVisualStyleBackColor = true;
            // 
            // checkBermuda
            // 
            this.checkBermuda.AutoSize = true;
            this.checkBermuda.Location = new System.Drawing.Point(102, 93);
            this.checkBermuda.Name = "checkBermuda";
            this.checkBermuda.Size = new System.Drawing.Size(68, 17);
            this.checkBermuda.TabIndex = 5;
            this.checkBermuda.Text = "Bermuda";
            this.checkBermuda.UseVisualStyleBackColor = true;
            // 
            // calidadDePrenda
            // 
            this.calidadDePrenda.AutoSize = true;
            this.calidadDePrenda.Location = new System.Drawing.Point(15, 129);
            this.calidadDePrenda.Name = "calidadDePrenda";
            this.calidadDePrenda.Size = new System.Drawing.Size(93, 13);
            this.calidadDePrenda.TabIndex = 6;
            this.calidadDePrenda.Text = "Calidad de prenda";
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Location = new System.Drawing.Point(24, 155);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(68, 17);
            this.radioStandard.TabIndex = 7;
            this.radioStandard.TabStop = true;
            this.radioStandard.Text = "Standard";
            this.radioStandard.UseVisualStyleBackColor = true;
            // 
            // radioPremium
            // 
            this.radioPremium.AutoSize = true;
            this.radioPremium.Location = new System.Drawing.Point(102, 155);
            this.radioPremium.Name = "radioPremium";
            this.radioPremium.Size = new System.Drawing.Size(65, 17);
            this.radioPremium.TabIndex = 8;
            this.radioPremium.TabStop = true;
            this.radioPremium.Text = "Premium";
            this.radioPremium.UseVisualStyleBackColor = true;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(15, 192);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 9;
            this.labelPrecio.Text = "Precio";
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(18, 208);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(59, 20);
            this.textPrecio.TabIndex = 10;
            this.textPrecio.TextChanged += new System.EventHandler(this.textPrecio_TextChanged);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(99, 192);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 11;
            this.labelCantidad.Text = "Cantidad";
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(102, 208);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(65, 20);
            this.textCantidad.TabIndex = 12;
            this.textCantidad.TextChanged += new System.EventHandler(this.textCantidad_TextChanged);
            // 
            // buttonCalcularPrecio
            // 
            this.buttonCalcularPrecio.Location = new System.Drawing.Point(9, 243);
            this.buttonCalcularPrecio.Name = "buttonCalcularPrecio";
            this.buttonCalcularPrecio.Size = new System.Drawing.Size(177, 43);
            this.buttonCalcularPrecio.TabIndex = 13;
            this.buttonCalcularPrecio.Text = "Calcular Precio Final";
            this.buttonCalcularPrecio.UseVisualStyleBackColor = true;
            this.buttonCalcularPrecio.Click += new System.EventHandler(this.buttonCalcularPrecio_Click);
            // 
            // textTotal
            // 
            this.textTotal.AutoSize = true;
            this.textTotal.Location = new System.Drawing.Point(9, 301);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(0, 13);
            this.textTotal.TabIndex = 14;
            // 
            // mostrarPrecio
            // 
            this.mostrarPrecio.AutoSize = true;
            this.mostrarPrecio.Location = new System.Drawing.Point(9, 301);
            this.mostrarPrecio.Name = "mostrarPrecio";
            this.mostrarPrecio.Size = new System.Drawing.Size(0, 13);
            this.mostrarPrecio.TabIndex = 15;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 326);
            this.Controls.Add(this.mostrarPrecio);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.buttonCalcularPrecio);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.radioPremium);
            this.Controls.Add(this.radioStandard);
            this.Controls.Add(this.calidadDePrenda);
            this.Controls.Add(this.checkBermuda);
            this.Controls.Add(this.checkMangaCorta);
            this.Controls.Add(this.Pantalon);
            this.Controls.Add(this.Camisa);
            this.Controls.Add(this.tipoDePrenda);
            this.Controls.Add(this.Titulo);
            this.Name = "form1";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label tipoDePrenda;
        private System.Windows.Forms.RadioButton Camisa;
        private System.Windows.Forms.RadioButton Pantalon;
        private System.Windows.Forms.CheckBox checkMangaCorta;
        private System.Windows.Forms.CheckBox checkBermuda;
        private System.Windows.Forms.Label calidadDePrenda;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.RadioButton radioPremium;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Button buttonCalcularPrecio;
        private System.Windows.Forms.Label textTotal;
        private System.Windows.Forms.Label mostrarPrecio;
    }
}


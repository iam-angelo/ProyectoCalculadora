namespace Calculadora
{
    partial class frmCalculadora
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
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnxdos = new System.Windows.Forms.Button();
            this.btnxy = new System.Windows.Forms.Button();
            this.btndiezx = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnfac = new System.Windows.Forms.Button();
            this.btnraizdos = new System.Windows.Forms.Button();
            this.btnmasmenos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCaption
            // 
            this.txtCaption.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCaption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaption.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaption.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCaption.Location = new System.Drawing.Point(17, 16);
            this.txtCaption.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(298, 23);
            this.txtCaption.TabIndex = 0;
            this.txtCaption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCaption.TextChanged += new System.EventHandler(this.txtCaption_TextChanged);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn7.Location = new System.Drawing.Point(79, 106);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 48);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDividir.Location = new System.Drawing.Point(262, 49);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(4);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(53, 48);
            this.btnDividir.TabIndex = 2;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMultiplicar.Location = new System.Drawing.Point(262, 103);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(53, 48);
            this.btnMultiplicar.TabIndex = 3;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMenos.Location = new System.Drawing.Point(262, 159);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(53, 48);
            this.btnMenos.TabIndex = 4;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMas.Location = new System.Drawing.Point(262, 217);
            this.btnMas.Margin = new System.Windows.Forms.Padding(4);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(53, 48);
            this.btnMas.TabIndex = 5;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = false;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIgual.Location = new System.Drawing.Point(262, 271);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(4);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(53, 48);
            this.btnIgual.TabIndex = 6;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn0.Location = new System.Drawing.Point(140, 274);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(53, 48);
            this.btn0.TabIndex = 7;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPunto.Location = new System.Drawing.Point(201, 272);
            this.btnPunto.Margin = new System.Windows.Forms.Padding(4);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(53, 48);
            this.btnPunto.TabIndex = 8;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn3.Location = new System.Drawing.Point(201, 218);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 48);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn2.Location = new System.Drawing.Point(140, 217);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 48);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn1.Location = new System.Drawing.Point(79, 215);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 48);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn6.Location = new System.Drawing.Point(201, 162);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 48);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn5.Location = new System.Drawing.Point(140, 159);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 48);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn4.Location = new System.Drawing.Point(79, 162);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 48);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn9.Location = new System.Drawing.Point(201, 106);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 48);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn8.Location = new System.Drawing.Point(140, 106);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 48);
            this.btn8.TabIndex = 16;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCE.Location = new System.Drawing.Point(201, 50);
            this.btnCE.Margin = new System.Windows.Forms.Padding(4);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(53, 48);
            this.btnCE.TabIndex = 17;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnxdos
            // 
            this.btnxdos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnxdos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxdos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxdos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnxdos.Location = new System.Drawing.Point(18, 274);
            this.btnxdos.Margin = new System.Windows.Forms.Padding(4);
            this.btnxdos.Name = "btnxdos";
            this.btnxdos.Size = new System.Drawing.Size(53, 48);
            this.btnxdos.TabIndex = 18;
            this.btnxdos.Text = "x²";
            this.btnxdos.UseVisualStyleBackColor = false;
            this.btnxdos.Click += new System.EventHandler(this.btnxdos_Click);
            // 
            // btnxy
            // 
            this.btnxy.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnxy.Location = new System.Drawing.Point(18, 106);
            this.btnxy.Margin = new System.Windows.Forms.Padding(4);
            this.btnxy.Name = "btnxy";
            this.btnxy.Size = new System.Drawing.Size(53, 48);
            this.btnxy.TabIndex = 19;
            this.btnxy.Text = "x^y";
            this.btnxy.UseVisualStyleBackColor = false;
            this.btnxy.Click += new System.EventHandler(this.btnxy_Click);
            // 
            // btndiezx
            // 
            this.btndiezx.BackColor = System.Drawing.SystemColors.ControlText;
            this.btndiezx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiezx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiezx.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btndiezx.Location = new System.Drawing.Point(18, 162);
            this.btndiezx.Margin = new System.Windows.Forms.Padding(4);
            this.btndiezx.Name = "btndiezx";
            this.btndiezx.Size = new System.Drawing.Size(53, 48);
            this.btndiezx.TabIndex = 20;
            this.btndiezx.Text = "10^x";
            this.btndiezx.UseVisualStyleBackColor = false;
            this.btndiezx.Click += new System.EventHandler(this.btndiezx_Click);
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnlog.Location = new System.Drawing.Point(18, 218);
            this.btnlog.Margin = new System.Windows.Forms.Padding(4);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(53, 48);
            this.btnlog.TabIndex = 21;
            this.btnlog.Text = "log";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnborrar.Location = new System.Drawing.Point(140, 50);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(53, 48);
            this.btnborrar.TabIndex = 22;
            this.btnborrar.Text = "⌫";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnfac
            // 
            this.btnfac.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnfac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfac.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnfac.Location = new System.Drawing.Point(79, 49);
            this.btnfac.Margin = new System.Windows.Forms.Padding(4);
            this.btnfac.Name = "btnfac";
            this.btnfac.Size = new System.Drawing.Size(53, 48);
            this.btnfac.TabIndex = 23;
            this.btnfac.Text = "n!";
            this.btnfac.UseVisualStyleBackColor = false;
            this.btnfac.Click += new System.EventHandler(this.btnfac_Click);
            // 
            // btnraizdos
            // 
            this.btnraizdos.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnraizdos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnraizdos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnraizdos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnraizdos.Location = new System.Drawing.Point(17, 50);
            this.btnraizdos.Margin = new System.Windows.Forms.Padding(4);
            this.btnraizdos.Name = "btnraizdos";
            this.btnraizdos.Size = new System.Drawing.Size(53, 48);
            this.btnraizdos.TabIndex = 24;
            this.btnraizdos.Text = "2√x";
            this.btnraizdos.UseVisualStyleBackColor = false;
            this.btnraizdos.Click += new System.EventHandler(this.btnraizdos_Click);
            // 
            // btnmasmenos
            // 
            this.btnmasmenos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmasmenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmasmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmasmenos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnmasmenos.Location = new System.Drawing.Point(79, 274);
            this.btnmasmenos.Margin = new System.Windows.Forms.Padding(4);
            this.btnmasmenos.Name = "btnmasmenos";
            this.btnmasmenos.Size = new System.Drawing.Size(53, 48);
            this.btnmasmenos.TabIndex = 25;
            this.btnmasmenos.Text = "+/-";
            this.btnmasmenos.UseVisualStyleBackColor = false;
            this.btnmasmenos.Click += new System.EventHandler(this.btnmasmenos_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(330, 335);
            this.Controls.Add(this.btnmasmenos);
            this.Controls.Add(this.btnraizdos);
            this.Controls.Add(this.btnfac);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.btndiezx);
            this.Controls.Add(this.btnxy);
            this.Controls.Add(this.btnxdos);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtCaption);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnxdos;
        private System.Windows.Forms.Button btnxy;
        private System.Windows.Forms.Button btndiezx;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnfac;
        private System.Windows.Forms.Button btnraizdos;
        private System.Windows.Forms.Button btnmasmenos;
    }
}


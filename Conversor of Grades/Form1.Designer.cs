namespace Conversor_of_Grades
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cbTipodeTemp = new System.Windows.Forms.ComboBox();
            this.cbTipoAConvertir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(79, 165);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(224, 20);
            this.txtIngreso.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(457, 165);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(224, 20);
            this.txtResult.TabIndex = 2;
            // 
            // cbTipodeTemp
            // 
            this.cbTipodeTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipodeTemp.FormattingEnabled = true;
            this.cbTipodeTemp.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Kelvin"});
            this.cbTipodeTemp.Location = new System.Drawing.Point(79, 218);
            this.cbTipodeTemp.Name = "cbTipodeTemp";
            this.cbTipodeTemp.Size = new System.Drawing.Size(224, 21);
            this.cbTipodeTemp.TabIndex = 3;
            // 
            // cbTipoAConvertir
            // 
            this.cbTipoAConvertir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAConvertir.FormattingEnabled = true;
            this.cbTipoAConvertir.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Kelvin"});
            this.cbTipoAConvertir.Location = new System.Drawing.Point(457, 218);
            this.cbTipoAConvertir.Name = "cbTipoAConvertir";
            this.cbTipoAConvertir.Size = new System.Drawing.Size(224, 21);
            this.cbTipoAConvertir.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Conversor de Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(350, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "=>";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Purple;
            this.btnSalir.ForeColor = System.Drawing.Color.Aqua;
            this.btnSalir.Location = new System.Drawing.Point(599, 376);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 42);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoAConvertir);
            this.Controls.Add(this.cbTipodeTemp);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cbTipodeTemp;
        private System.Windows.Forms.ComboBox cbTipoAConvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}


﻿
namespace Gmaps
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numerico1 = new System.Windows.Forms.TextBox();
            this.numerico2 = new System.Windows.Forms.TextBox();
            this.categoriaCombo = new System.Windows.Forms.ComboBox();
            this.texto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(887, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CASO",
            "CIUDAD",
            "EDAD",
            "ESTADO",
            "FECHA DE DIAGNOSTICO",
            "FUENTE",
            "INICIO SINTOMAS",
            "LOCALIDAD",
            "SEXO",
            "UBICACION"});
            this.comboBox1.Location = new System.Drawing.Point(900, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(897, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "CARGAR DATOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numerico1
            // 
            this.numerico1.Enabled = false;
            this.numerico1.Location = new System.Drawing.Point(905, 329);
            this.numerico1.Name = "numerico1";
            this.numerico1.Size = new System.Drawing.Size(108, 22);
            this.numerico1.TabIndex = 4;
            // 
            // numerico2
            // 
            this.numerico2.Enabled = false;
            this.numerico2.Location = new System.Drawing.Point(1019, 329);
            this.numerico2.Name = "numerico2";
            this.numerico2.Size = new System.Drawing.Size(100, 22);
            this.numerico2.TabIndex = 5;
            // 
            // categoriaCombo
            // 
            this.categoriaCombo.Enabled = false;
            this.categoriaCombo.FormattingEnabled = true;
            this.categoriaCombo.Location = new System.Drawing.Point(905, 261);
            this.categoriaCombo.Name = "categoriaCombo";
            this.categoriaCombo.Size = new System.Drawing.Size(214, 24);
            this.categoriaCombo.TabIndex = 6;
            // 
            // texto
            // 
            this.texto.Enabled = false;
            this.texto.Location = new System.Drawing.Point(905, 418);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(214, 22);
            this.texto.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 554);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.categoriaCombo);
            this.Controls.Add(this.numerico2);
            this.Controls.Add(this.numerico1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numerico1;
        private System.Windows.Forms.TextBox numerico2;
        private System.Windows.Forms.ComboBox categoriaCombo;
        private System.Windows.Forms.TextBox texto;
    }
}


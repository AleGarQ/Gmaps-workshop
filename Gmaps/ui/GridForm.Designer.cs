
namespace Gmaps.ui
{
    partial class GridForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoriaCombo = new System.Windows.Forms.ComboBox();
            this.numerico1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.texto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numerico2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.comboBox1.Location = new System.Drawing.Point(698, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // categoriaCombo
            // 
            this.categoriaCombo.Enabled = false;
            this.categoriaCombo.FormattingEnabled = true;
            this.categoriaCombo.Location = new System.Drawing.Point(701, 106);
            this.categoriaCombo.Margin = new System.Windows.Forms.Padding(2);
            this.categoriaCombo.Name = "categoriaCombo";
            this.categoriaCombo.Size = new System.Drawing.Size(162, 21);
            this.categoriaCombo.TabIndex = 14;
            // 
            // numerico1
            // 
            this.numerico1.Enabled = false;
            this.numerico1.Location = new System.Drawing.Point(701, 131);
            this.numerico1.Margin = new System.Windows.Forms.Padding(2);
            this.numerico1.Name = "numerico1";
            this.numerico1.Size = new System.Drawing.Size(82, 20);
            this.numerico1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "CARGAR DATOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // texto
            // 
            this.texto.Enabled = false;
            this.texto.Location = new System.Drawing.Point(701, 170);
            this.texto.Margin = new System.Windows.Forms.Padding(2);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(162, 20);
            this.texto.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 341);
            this.dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtro";
            // 
            // numerico2
            // 
            this.numerico2.Enabled = false;
            this.numerico2.Location = new System.Drawing.Point(787, 131);
            this.numerico2.Margin = new System.Windows.Forms.Padding(2);
            this.numerico2.Name = "numerico2";
            this.numerico2.Size = new System.Drawing.Size(76, 20);
            this.numerico2.TabIndex = 13;
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.categoriaCombo);
            this.Controls.Add(this.numerico1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numerico2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GridForm";
            this.Text = "GridForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox categoriaCombo;
        private System.Windows.Forms.TextBox numerico1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox texto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numerico2;
    }
}
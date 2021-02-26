
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numerico2 = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.cade = new System.Windows.Forms.TextBox();
            this.filter2 = new System.Windows.Forms.Button();
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
            "SEXO",
            "LOCALIDAD"});
            this.comboBox1.Location = new System.Drawing.Point(888, 87);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // categoriaCombo
            // 
            this.categoriaCombo.Enabled = false;
            this.categoriaCombo.FormattingEnabled = true;
            this.categoriaCombo.Location = new System.Drawing.Point(888, 151);
            this.categoriaCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoriaCombo.Name = "categoriaCombo";
            this.categoriaCombo.Size = new System.Drawing.Size(219, 24);
            this.categoriaCombo.TabIndex = 14;
            this.categoriaCombo.SelectedIndexChanged += new System.EventHandler(this.categoriaCombo_SelectedIndexChanged);
            // 
            // numerico1
            // 
            this.numerico1.Enabled = false;
            this.numerico1.Location = new System.Drawing.Point(888, 206);
            this.numerico1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numerico1.Name = "numerico1";
            this.numerico1.Size = new System.Drawing.Size(108, 22);
            this.numerico1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "CARGAR DATOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 420);
            this.dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numerico2
            // 
            this.numerico2.Enabled = false;
            this.numerico2.Location = new System.Drawing.Point(1003, 206);
            this.numerico2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numerico2.Name = "numerico2";
            this.numerico2.Size = new System.Drawing.Size(104, 22);
            this.numerico2.TabIndex = 13;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(916, 374);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(187, 35);
            this.delete.TabIndex = 16;
            this.delete.Text = "BORRAR FILTRO";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(1113, 205);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(94, 23);
            this.filter.TabIndex = 17;
            this.filter.Text = "FILTRAR!";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Visible = false;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // cade
            // 
            this.cade.Enabled = false;
            this.cade.Location = new System.Drawing.Point(888, 295);
            this.cade.Name = "cade";
            this.cade.Size = new System.Drawing.Size(219, 22);
            this.cade.TabIndex = 18;
            // 
            // filter2
            // 
            this.filter2.Location = new System.Drawing.Point(1113, 294);
            this.filter2.Name = "filter2";
            this.filter2.Size = new System.Drawing.Size(94, 23);
            this.filter2.TabIndex = 19;
            this.filter2.Text = "FILTRAR!";
            this.filter2.UseVisualStyleBackColor = true;
            this.filter2.Visible = false;
            this.filter2.Click += new System.EventHandler(this.filter2_Click);
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 539);
            this.Controls.Add(this.filter2);
            this.Controls.Add(this.cade);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.categoriaCombo);
            this.Controls.Add(this.numerico1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numerico2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numerico2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.TextBox cade;
        private System.Windows.Forms.Button filter2;
    }
}
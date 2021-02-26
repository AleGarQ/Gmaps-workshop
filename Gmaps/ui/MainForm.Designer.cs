
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
            this.btnMap = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(91, 12);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(76, 23);
            this.btnMap.TabIndex = 8;
            this.btnMap.Text = "Mapa";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(164, 12);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(75, 23);
            this.btnGraph.TabIndex = 9;
            this.btnGraph.Text = "Gráfico";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(2, 51);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(970, 533);
            this.container.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Tabla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.container);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button button2;
    }
}


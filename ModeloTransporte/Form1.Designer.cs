namespace ModeloTransporte
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
            this.poner_nodo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._to = new System.Windows.Forms.ComboBox();
            this._de = new System.Windows.Forms.ComboBox();
            this.distancia = new System.Windows.Forms.MaskedTextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // poner_nodo
            // 
            this.poner_nodo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poner_nodo.Location = new System.Drawing.Point(459, 17);
            this.poner_nodo.Name = "poner_nodo";
            this.poner_nodo.Size = new System.Drawing.Size(93, 35);
            this.poner_nodo.TabIndex = 0;
            this.poner_nodo.Text = "Conectar";
            this.poner_nodo.UseVisualStyleBackColor = true;
            this.poner_nodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.distancia);
            this.panel2.Controls.Add(this._to);
            this.panel2.Controls.Add(this._de);
            this.panel2.Controls.Add(this.poner_nodo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 64);
            this.panel2.TabIndex = 2;
            // 
            // _to
            // 
            this._to.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._to.FormattingEnabled = true;
            this._to.Location = new System.Drawing.Point(151, 26);
            this._to.Name = "_to";
            this._to.Size = new System.Drawing.Size(121, 27);
            this._to.TabIndex = 2;
            // 
            // _de
            // 
            this._de.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._de.FormattingEnabled = true;
            this._de.Location = new System.Drawing.Point(12, 25);
            this._de.Name = "_de";
            this._de.Size = new System.Drawing.Size(121, 27);
            this._de.TabIndex = 1;
            // 
            // distancia
            // 
            this.distancia.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distancia.Location = new System.Drawing.Point(321, 25);
            this.distancia.Mask = "0000";
            this.distancia.Name = "distancia";
            this.distancia.Size = new System.Drawing.Size(36, 29);
            this.distancia.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button poner_nodo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox _de;
        private System.Windows.Forms.ComboBox _to;
        private System.Windows.Forms.MaskedTextBox distancia;
    }
}


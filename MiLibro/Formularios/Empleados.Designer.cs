namespace MiLibro.Formularios
{
    partial class Empleados
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.ActualizarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 41);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(611, 329);
            this.dataGrid.TabIndex = 1;
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(12, 386);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarBtn.TabIndex = 2;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // ActualizarBtn
            // 
            this.ActualizarBtn.Location = new System.Drawing.Point(93, 386);
            this.ActualizarBtn.Name = "ActualizarBtn";
            this.ActualizarBtn.Size = new System.Drawing.Size(75, 23);
            this.ActualizarBtn.TabIndex = 3;
            this.ActualizarBtn.Text = "Actualizar";
            this.ActualizarBtn.UseVisualStyleBackColor = true;
            this.ActualizarBtn.Click += new System.EventHandler(this.ActualizarBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(174, 386);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.EliminarBtn.TabIndex = 4;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(548, 12);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(75, 23);
            this.BuscarBtn.TabIndex = 5;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 421);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.ActualizarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.textBox1);
            this.Name = "Empleados";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button ActualizarBtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button BuscarBtn;
    }
}
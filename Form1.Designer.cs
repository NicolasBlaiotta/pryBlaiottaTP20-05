namespace pryBlaiotta
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewQuenaken = new System.Windows.Forms.DataGridView();
            this.dataGridViewOnas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTobas = new System.Windows.Forms.DataGridView();
            this.btnAgregarReserva = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnModificarReserva = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuenaken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTobas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewQuenaken);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quenaken";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewOnas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Onas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewTobas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(750, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tobas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewQuenaken
            // 
            this.dataGridViewQuenaken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuenaken.Location = new System.Drawing.Point(16, 27);
            this.dataGridViewQuenaken.Name = "dataGridViewQuenaken";
            this.dataGridViewQuenaken.Size = new System.Drawing.Size(693, 322);
            this.dataGridViewQuenaken.TabIndex = 0;
            // 
            // dataGridViewOnas
            // 
            this.dataGridViewOnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOnas.Location = new System.Drawing.Point(21, 26);
            this.dataGridViewOnas.Name = "dataGridViewOnas";
            this.dataGridViewOnas.Size = new System.Drawing.Size(695, 293);
            this.dataGridViewOnas.TabIndex = 0;
            // 
            // dataGridViewTobas
            // 
            this.dataGridViewTobas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTobas.Location = new System.Drawing.Point(29, 27);
            this.dataGridViewTobas.Name = "dataGridViewTobas";
            this.dataGridViewTobas.Size = new System.Drawing.Size(671, 276);
            this.dataGridViewTobas.TabIndex = 0;
            // 
            // btnAgregarReserva
            // 
            this.btnAgregarReserva.Location = new System.Drawing.Point(67, 414);
            this.btnAgregarReserva.Name = "btnAgregarReserva";
            this.btnAgregarReserva.Size = new System.Drawing.Size(103, 23);
            this.btnAgregarReserva.TabIndex = 1;
            this.btnAgregarReserva.Text = "Agregar reserva";
            this.btnAgregarReserva.UseVisualStyleBackColor = true;
            this.btnAgregarReserva.Click += new System.EventHandler(this.btnAgregarReserva_Click);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(205, 413);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(98, 23);
            this.btnCancelarReserva.TabIndex = 2;
            this.btnCancelarReserva.Text = "Cancelar reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // btnModificarReserva
            // 
            this.btnModificarReserva.Location = new System.Drawing.Point(353, 412);
            this.btnModificarReserva.Name = "btnModificarReserva";
            this.btnModificarReserva.Size = new System.Drawing.Size(103, 23);
            this.btnModificarReserva.TabIndex = 3;
            this.btnModificarReserva.Text = "Modificar reserva";
            this.btnModificarReserva.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificarReserva);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAgregarReserva);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuenaken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTobas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewQuenaken;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewOnas;
        private System.Windows.Forms.DataGridView dataGridViewTobas;
        private System.Windows.Forms.Button btnModificarReserva;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnAgregarReserva;
    }
}


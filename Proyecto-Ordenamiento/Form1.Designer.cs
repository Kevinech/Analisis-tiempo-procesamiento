namespace Proyecto_Ordenamiento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTiempoGenerar = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cmbTamano = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTimeMerge = new System.Windows.Forms.Label();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.lblTimeSelection = new System.Windows.Forms.Label();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbVista = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTimeInterpol = new System.Windows.Forms.Label();
            this.lblTimeJump = new System.Windows.Forms.Label();
            this.btnInterpolSearch = new System.Windows.Forms.Button();
            this.btnJumpSearch = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTiempoGenerar);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.cmbTamano);
            this.groupBox1.Location = new System.Drawing.Point(16, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1171, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamaño de datos";
            // 
            // lblTiempoGenerar
            // 
            this.lblTiempoGenerar.AutoSize = true;
            this.lblTiempoGenerar.Location = new System.Drawing.Point(809, 24);
            this.lblTiempoGenerar.Name = "lblTiempoGenerar";
            this.lblTiempoGenerar.Size = new System.Drawing.Size(135, 20);
            this.lblTiempoGenerar.TabIndex = 2;
            this.lblTiempoGenerar.Text = "lblTiempoGenerar";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(580, 16);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(153, 28);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar palabras";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cmbTamano
            // 
            this.cmbTamano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamano.FormattingEnabled = true;
            this.cmbTamano.Location = new System.Drawing.Point(331, 16);
            this.cmbTamano.Name = "cmbTamano";
            this.cmbTamano.Size = new System.Drawing.Size(189, 28);
            this.cmbTamano.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTimeMerge);
            this.groupBox2.Controls.Add(this.btnMergeSort);
            this.groupBox2.Controls.Add(this.lblTimeSelection);
            this.groupBox2.Controls.Add(this.btnSelectionSort);
            this.groupBox2.Location = new System.Drawing.Point(686, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenamientos";
            // 
            // lblTimeMerge
            // 
            this.lblTimeMerge.AutoSize = true;
            this.lblTimeMerge.Location = new System.Drawing.Point(380, 62);
            this.lblTimeMerge.Name = "lblTimeMerge";
            this.lblTimeMerge.Size = new System.Drawing.Size(103, 20);
            this.lblTimeMerge.TabIndex = 3;
            this.lblTimeMerge.Text = "lblTimeMerge";
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(321, 27);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(158, 28);
            this.btnMergeSort.TabIndex = 2;
            this.btnMergeSort.Text = "Merge Sort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // lblTimeSelection
            // 
            this.lblTimeSelection.AutoSize = true;
            this.lblTimeSelection.Location = new System.Drawing.Point(51, 62);
            this.lblTimeSelection.Name = "lblTimeSelection";
            this.lblTimeSelection.Size = new System.Drawing.Size(124, 20);
            this.lblTimeSelection.TabIndex = 1;
            this.lblTimeSelection.Text = "lblTimeSelection";
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(6, 27);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(158, 27);
            this.btnSelectionSort.TabIndex = 0;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbVista);
            this.groupBox3.Location = new System.Drawing.Point(13, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(668, 492);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vista";
            // 
            // lbVista
            // 
            this.lbVista.FormattingEnabled = true;
            this.lbVista.ItemHeight = 20;
            this.lbVista.Location = new System.Drawing.Point(6, 25);
            this.lbVista.Name = "lbVista";
            this.lbVista.Size = new System.Drawing.Size(656, 444);
            this.lbVista.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTimeInterpol);
            this.groupBox4.Controls.Add(this.lblTimeJump);
            this.groupBox4.Controls.Add(this.btnInterpolSearch);
            this.groupBox4.Controls.Add(this.btnJumpSearch);
            this.groupBox4.Controls.Add(this.tbBuscar);
            this.groupBox4.Location = new System.Drawing.Point(687, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(501, 179);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busquedas";
            // 
            // lblTimeInterpol
            // 
            this.lblTimeInterpol.AutoSize = true;
            this.lblTimeInterpol.Location = new System.Drawing.Point(348, 138);
            this.lblTimeInterpol.Name = "lblTimeInterpol";
            this.lblTimeInterpol.Size = new System.Drawing.Size(112, 20);
            this.lblTimeInterpol.TabIndex = 4;
            this.lblTimeInterpol.Text = "lblTimeInterpol";
            // 
            // lblTimeJump
            // 
            this.lblTimeJump.AutoSize = true;
            this.lblTimeJump.Location = new System.Drawing.Point(85, 138);
            this.lblTimeJump.Name = "lblTimeJump";
            this.lblTimeJump.Size = new System.Drawing.Size(97, 20);
            this.lblTimeJump.TabIndex = 3;
            this.lblTimeJump.Text = "lblTimeJump";
            // 
            // btnInterpolSearch
            // 
            this.btnInterpolSearch.Location = new System.Drawing.Point(295, 88);
            this.btnInterpolSearch.Name = "btnInterpolSearch";
            this.btnInterpolSearch.Size = new System.Drawing.Size(154, 29);
            this.btnInterpolSearch.TabIndex = 2;
            this.btnInterpolSearch.Text = "Interpol Search";
            this.btnInterpolSearch.UseVisualStyleBackColor = true;
            // 
            // btnJumpSearch
            // 
            this.btnJumpSearch.Location = new System.Drawing.Point(29, 88);
            this.btnJumpSearch.Name = "btnJumpSearch";
            this.btnJumpSearch.Size = new System.Drawing.Size(155, 29);
            this.btnJumpSearch.TabIndex = 1;
            this.btnJumpSearch.Text = "Jump Search";
            this.btnJumpSearch.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(89, 45);
            this.tbBuscar.MaxLength = 200;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(291, 26);
            this.tbBuscar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Ordenamientos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cmbTamano;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Label lblTimeSelection;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Label lblTimeMerge;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbVista;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnInterpolSearch;
        private System.Windows.Forms.Button btnJumpSearch;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label lblTimeInterpol;
        private System.Windows.Forms.Label lblTimeJump;
        private System.Windows.Forms.Label lblTiempoGenerar;
    }
}


namespace Interfaz
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
            this.txBanner = new System.Windows.Forms.Label();
            this.txSub = new System.Windows.Forms.Label();
            this.txExamen = new System.Windows.Forms.Label();
            this.txTareas = new System.Windows.Forms.Label();
            this.txProyectos = new System.Windows.Forms.Label();
            this.tbExamPercent = new System.Windows.Forms.TextBox();
            this.txPorcentaje = new System.Windows.Forms.Label();
            this.tbProjectPercent = new System.Windows.Forms.TextBox();
            this.tbTareasPercent = new System.Windows.Forms.TextBox();
            this.txCantidad = new System.Windows.Forms.Label();
            this.tbExamCant = new System.Windows.Forms.TextBox();
            this.tbProjectCant = new System.Windows.Forms.TextBox();
            this.tbTareasCant = new System.Windows.Forms.TextBox();
            this.butEmpezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txBanner
            // 
            this.txBanner.AutoSize = true;
            this.txBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBanner.Location = new System.Drawing.Point(45, 29);
            this.txBanner.Name = "txBanner";
            this.txBanner.Size = new System.Drawing.Size(162, 20);
            this.txBanner.TabIndex = 0;
            this.txBanner.Text = "Bienvenido, profesor";
            // 
            // txSub
            // 
            this.txSub.AutoSize = true;
            this.txSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSub.Location = new System.Drawing.Point(49, 70);
            this.txSub.Name = "txSub";
            this.txSub.Size = new System.Drawing.Size(396, 20);
            this.txSub.TabIndex = 1;
            this.txSub.Text = "Inserte los datos para evaluar los siguientes rubros:";
            // 
            // txExamen
            // 
            this.txExamen.AutoSize = true;
            this.txExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txExamen.Location = new System.Drawing.Point(49, 142);
            this.txExamen.Name = "txExamen";
            this.txExamen.Size = new System.Drawing.Size(69, 20);
            this.txExamen.TabIndex = 2;
            this.txExamen.Text = "Examen";
            // 
            // txTareas
            // 
            this.txTareas.AutoSize = true;
            this.txTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTareas.Location = new System.Drawing.Point(49, 264);
            this.txTareas.Name = "txTareas";
            this.txTareas.Size = new System.Drawing.Size(61, 20);
            this.txTareas.TabIndex = 3;
            this.txTareas.Text = "Tareas";
            // 
            // txProyectos
            // 
            this.txProyectos.AutoSize = true;
            this.txProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txProyectos.Location = new System.Drawing.Point(50, 202);
            this.txProyectos.Name = "txProyectos";
            this.txProyectos.Size = new System.Drawing.Size(75, 20);
            this.txProyectos.TabIndex = 4;
            this.txProyectos.Text = "Proyecto";
            // 
            // tbExamPercent
            // 
            this.tbExamPercent.Location = new System.Drawing.Point(174, 140);
            this.tbExamPercent.MaxLength = 3;
            this.tbExamPercent.Name = "tbExamPercent";
            this.tbExamPercent.Size = new System.Drawing.Size(100, 22);
            this.tbExamPercent.TabIndex = 5;
            this.tbExamPercent.Text = "%";
            // 
            // txPorcentaje
            // 
            this.txPorcentaje.AutoSize = true;
            this.txPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPorcentaje.Location = new System.Drawing.Point(179, 117);
            this.txPorcentaje.Name = "txPorcentaje";
            this.txPorcentaje.Size = new System.Drawing.Size(89, 20);
            this.txPorcentaje.TabIndex = 6;
            this.txPorcentaje.Text = "Porcentaje";
            // 
            // tbProjectPercent
            // 
            this.tbProjectPercent.Location = new System.Drawing.Point(174, 202);
            this.tbProjectPercent.Name = "tbProjectPercent";
            this.tbProjectPercent.Size = new System.Drawing.Size(100, 22);
            this.tbProjectPercent.TabIndex = 7;
            this.tbProjectPercent.Text = "%";
            // 
            // tbTareasPercent
            // 
            this.tbTareasPercent.Location = new System.Drawing.Point(174, 264);
            this.tbTareasPercent.Name = "tbTareasPercent";
            this.tbTareasPercent.Size = new System.Drawing.Size(100, 22);
            this.tbTareasPercent.TabIndex = 8;
            this.tbTareasPercent.Text = "%";
            // 
            // txCantidad
            // 
            this.txCantidad.AutoSize = true;
            this.txCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCantidad.Location = new System.Drawing.Point(356, 117);
            this.txCantidad.Name = "txCantidad";
            this.txCantidad.Size = new System.Drawing.Size(75, 20);
            this.txCantidad.TabIndex = 9;
            this.txCantidad.Text = "Cantidad";
            // 
            // tbExamCant
            // 
            this.tbExamCant.Location = new System.Drawing.Point(345, 140);
            this.tbExamCant.MaxLength = 2;
            this.tbExamCant.Name = "tbExamCant";
            this.tbExamCant.Size = new System.Drawing.Size(100, 22);
            this.tbExamCant.TabIndex = 10;
            // 
            // tbProjectCant
            // 
            this.tbProjectCant.Location = new System.Drawing.Point(345, 202);
            this.tbProjectCant.MaxLength = 2;
            this.tbProjectCant.Name = "tbProjectCant";
            this.tbProjectCant.Size = new System.Drawing.Size(100, 22);
            this.tbProjectCant.TabIndex = 11;
            // 
            // tbTareasCant
            // 
            this.tbTareasCant.Location = new System.Drawing.Point(345, 264);
            this.tbTareasCant.MaxLength = 2;
            this.tbTareasCant.Name = "tbTareasCant";
            this.tbTareasCant.Size = new System.Drawing.Size(100, 22);
            this.tbTareasCant.TabIndex = 12;
            // 
            // butEmpezar
            // 
            this.butEmpezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEmpezar.Location = new System.Drawing.Point(228, 322);
            this.butEmpezar.Name = "butEmpezar";
            this.butEmpezar.Size = new System.Drawing.Size(87, 39);
            this.butEmpezar.TabIndex = 13;
            this.butEmpezar.Text = "Siguiente";
            this.butEmpezar.UseVisualStyleBackColor = true;
            this.butEmpezar.Click += new System.EventHandler(this.butEmpezar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 385);
            this.Controls.Add(this.butEmpezar);
            this.Controls.Add(this.tbTareasCant);
            this.Controls.Add(this.tbProjectCant);
            this.Controls.Add(this.tbExamCant);
            this.Controls.Add(this.txCantidad);
            this.Controls.Add(this.tbTareasPercent);
            this.Controls.Add(this.tbProjectPercent);
            this.Controls.Add(this.txPorcentaje);
            this.Controls.Add(this.tbExamPercent);
            this.Controls.Add(this.txProyectos);
            this.Controls.Add(this.txTareas);
            this.Controls.Add(this.txExamen);
            this.Controls.Add(this.txSub);
            this.Controls.Add(this.txBanner);
            this.Name = "Form1";
            this.Text = ".:Calificaciones:.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txBanner;
        private System.Windows.Forms.Label txSub;
        private System.Windows.Forms.Label txExamen;
        private System.Windows.Forms.Label txTareas;
        private System.Windows.Forms.Label txProyectos;
        private System.Windows.Forms.TextBox tbExamPercent;
        private System.Windows.Forms.Label txPorcentaje;
        private System.Windows.Forms.TextBox tbProjectPercent;
        private System.Windows.Forms.TextBox tbTareasPercent;
        private System.Windows.Forms.Label txCantidad;
        private System.Windows.Forms.TextBox tbExamCant;
        private System.Windows.Forms.TextBox tbProjectCant;
        private System.Windows.Forms.TextBox tbTareasCant;
        private System.Windows.Forms.Button butEmpezar;
    }
}


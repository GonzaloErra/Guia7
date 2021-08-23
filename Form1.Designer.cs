
namespace Guia7
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
            System.Windows.Forms.GroupBox ListaAlumnos;
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.labelPromedio = new System.Windows.Forms.Label();
            this.TxPromedio = new System.Windows.Forms.TextBox();
            this.TxMatRestantes = new System.Windows.Forms.TextBox();
            this.labelMatRestantes = new System.Windows.Forms.Label();
            this.labelMatAprobadas = new System.Windows.Forms.Label();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.TxMatAprobadas = new System.Windows.Forms.TextBox();
            this.TxApellido = new System.Windows.Forms.TextBox();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.LabelRegistro = new System.Windows.Forms.Label();
            this.TxNroDeRegistro = new System.Windows.Forms.TextBox();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.ListaMostrar = new System.Windows.Forms.ListBox();
            this.TxtRegistroBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscarAlimno = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnMostrarDistinciones = new System.Windows.Forms.Button();
            this.RbDistincion3 = new System.Windows.Forms.RadioButton();
            this.RbDistincion2 = new System.Windows.Forms.RadioButton();
            this.RbDistincion1 = new System.Windows.Forms.RadioButton();
            ListaAlumnos = new System.Windows.Forms.GroupBox();
            ListaAlumnos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaAlumnos
            // 
            ListaAlumnos.Controls.Add(this.BtnMostrar);
            ListaAlumnos.Controls.Add(this.labelPromedio);
            ListaAlumnos.Controls.Add(this.TxPromedio);
            ListaAlumnos.Controls.Add(this.TxMatRestantes);
            ListaAlumnos.Controls.Add(this.labelMatRestantes);
            ListaAlumnos.Controls.Add(this.labelMatAprobadas);
            ListaAlumnos.Controls.Add(this.LabelApellido);
            ListaAlumnos.Controls.Add(this.TxMatAprobadas);
            ListaAlumnos.Controls.Add(this.TxApellido);
            ListaAlumnos.Controls.Add(this.LabelNombre);
            ListaAlumnos.Controls.Add(this.TxNombre);
            ListaAlumnos.Controls.Add(this.LabelRegistro);
            ListaAlumnos.Controls.Add(this.TxNroDeRegistro);
            ListaAlumnos.Controls.Add(this.BtnCargar);
            ListaAlumnos.Location = new System.Drawing.Point(57, 31);
            ListaAlumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ListaAlumnos.Name = "ListaAlumnos";
            ListaAlumnos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ListaAlumnos.Size = new System.Drawing.Size(197, 417);
            ListaAlumnos.TabIndex = 2;
            ListaAlumnos.TabStop = false;
            ListaAlumnos.Text = "Lista de Alumnos";
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(112, 377);
            this.BtnMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(79, 36);
            this.BtnMostrar.TabIndex = 18;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // labelPromedio
            // 
            this.labelPromedio.AutoSize = true;
            this.labelPromedio.Location = new System.Drawing.Point(59, 304);
            this.labelPromedio.Name = "labelPromedio";
            this.labelPromedio.Size = new System.Drawing.Size(68, 17);
            this.labelPromedio.TabIndex = 17;
            this.labelPromedio.Text = "Promedio";
            // 
            // TxPromedio
            // 
            this.TxPromedio.Location = new System.Drawing.Point(27, 329);
            this.TxPromedio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxPromedio.Name = "TxPromedio";
            this.TxPromedio.Size = new System.Drawing.Size(137, 22);
            this.TxPromedio.TabIndex = 16;
            // 
            // TxMatRestantes
            // 
            this.TxMatRestantes.Location = new System.Drawing.Point(27, 273);
            this.TxMatRestantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxMatRestantes.Name = "TxMatRestantes";
            this.TxMatRestantes.Size = new System.Drawing.Size(137, 22);
            this.TxMatRestantes.TabIndex = 15;
            // 
            // labelMatRestantes
            // 
            this.labelMatRestantes.AutoSize = true;
            this.labelMatRestantes.Location = new System.Drawing.Point(33, 249);
            this.labelMatRestantes.Name = "labelMatRestantes";
            this.labelMatRestantes.Size = new System.Drawing.Size(130, 17);
            this.labelMatRestantes.TabIndex = 13;
            this.labelMatRestantes.Text = "Materias Restantes";
            // 
            // labelMatAprobadas
            // 
            this.labelMatAprobadas.AutoSize = true;
            this.labelMatAprobadas.Location = new System.Drawing.Point(28, 199);
            this.labelMatAprobadas.Name = "labelMatAprobadas";
            this.labelMatAprobadas.Size = new System.Drawing.Size(135, 17);
            this.labelMatAprobadas.TabIndex = 12;
            this.labelMatAprobadas.Text = "Materias Aprobadas";
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Location = new System.Drawing.Point(59, 138);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(58, 17);
            this.LabelApellido.TabIndex = 11;
            this.LabelApellido.Text = "Apellido";
            // 
            // TxMatAprobadas
            // 
            this.TxMatAprobadas.Location = new System.Drawing.Point(27, 219);
            this.TxMatAprobadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxMatAprobadas.Name = "TxMatAprobadas";
            this.TxMatAprobadas.Size = new System.Drawing.Size(137, 22);
            this.TxMatAprobadas.TabIndex = 10;
            // 
            // TxApellido
            // 
            this.TxApellido.Location = new System.Drawing.Point(27, 162);
            this.TxApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxApellido.Name = "TxApellido";
            this.TxApellido.Size = new System.Drawing.Size(137, 22);
            this.TxApellido.TabIndex = 8;
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(59, 82);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(58, 17);
            this.LabelNombre.TabIndex = 6;
            this.LabelNombre.Text = "Nombre";
            // 
            // TxNombre
            // 
            this.TxNombre.Location = new System.Drawing.Point(27, 107);
            this.TxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(137, 22);
            this.TxNombre.TabIndex = 4;
            // 
            // LabelRegistro
            // 
            this.LabelRegistro.AutoSize = true;
            this.LabelRegistro.Location = new System.Drawing.Point(39, 31);
            this.LabelRegistro.Name = "LabelRegistro";
            this.LabelRegistro.Size = new System.Drawing.Size(110, 17);
            this.LabelRegistro.TabIndex = 2;
            this.LabelRegistro.Text = "Nro De Registro";
            // 
            // TxNroDeRegistro
            // 
            this.TxNroDeRegistro.Location = new System.Drawing.Point(27, 50);
            this.TxNroDeRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxNroDeRegistro.Name = "TxNroDeRegistro";
            this.TxNroDeRegistro.Size = new System.Drawing.Size(137, 22);
            this.TxNroDeRegistro.TabIndex = 1;
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(16, 377);
            this.BtnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(79, 36);
            this.BtnCargar.TabIndex = 0;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaMostrar
            // 
            this.ListaMostrar.FormattingEnabled = true;
            this.ListaMostrar.ItemHeight = 16;
            this.ListaMostrar.Location = new System.Drawing.Point(288, 31);
            this.ListaMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListaMostrar.Name = "ListaMostrar";
            this.ListaMostrar.Size = new System.Drawing.Size(233, 308);
            this.ListaMostrar.TabIndex = 5;
            // 
            // TxtRegistroBuscar
            // 
            this.TxtRegistroBuscar.Location = new System.Drawing.Point(325, 426);
            this.TxtRegistroBuscar.Name = "TxtRegistroBuscar";
            this.TxtRegistroBuscar.Size = new System.Drawing.Size(136, 22);
            this.TxtRegistroBuscar.TabIndex = 6;
            // 
            // BtnBuscarAlimno
            // 
            this.BtnBuscarAlimno.Location = new System.Drawing.Point(325, 454);
            this.BtnBuscarAlimno.Name = "BtnBuscarAlimno";
            this.BtnBuscarAlimno.Size = new System.Drawing.Size(136, 23);
            this.BtnBuscarAlimno.TabIndex = 7;
            this.BtnBuscarAlimno.Text = "Buscar";
            this.BtnBuscarAlimno.UseVisualStyleBackColor = true;
            this.BtnBuscarAlimno.Click += new System.EventHandler(this.BtnMost_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(288, 359);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(233, 23);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnMostrarDistinciones);
            this.groupBox1.Controls.Add(this.RbDistincion3);
            this.groupBox1.Controls.Add(this.RbDistincion2);
            this.groupBox1.Controls.Add(this.RbDistincion1);
            this.groupBox1.Location = new System.Drawing.Point(601, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 308);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GbDistinciones";
            // 
            // BtnMostrarDistinciones
            // 
            this.BtnMostrarDistinciones.Location = new System.Drawing.Point(20, 138);
            this.BtnMostrarDistinciones.Name = "BtnMostrarDistinciones";
            this.BtnMostrarDistinciones.Size = new System.Drawing.Size(133, 23);
            this.BtnMostrarDistinciones.TabIndex = 3;
            this.BtnMostrarDistinciones.Text = "Mostrar";
            this.BtnMostrarDistinciones.UseVisualStyleBackColor = true;
            this.BtnMostrarDistinciones.Click += new System.EventHandler(this.BtnMostrarDistinciones_Click);
            // 
            // RbDistincion3
            // 
            this.RbDistincion3.AutoSize = true;
            this.RbDistincion3.Location = new System.Drawing.Point(20, 99);
            this.RbDistincion3.Name = "RbDistincion3";
            this.RbDistincion3.Size = new System.Drawing.Size(161, 21);
            this.RbDistincion3.TabIndex = 2;
            this.RbDistincion3.TabStop = true;
            this.RbDistincion3.Text = "Promedio entre 7 y 8";
            this.RbDistincion3.UseVisualStyleBackColor = true;
            // 
            // RbDistincion2
            // 
            this.RbDistincion2.AutoSize = true;
            this.RbDistincion2.Location = new System.Drawing.Point(20, 72);
            this.RbDistincion2.Name = "RbDistincion2";
            this.RbDistincion2.Size = new System.Drawing.Size(161, 21);
            this.RbDistincion2.TabIndex = 1;
            this.RbDistincion2.TabStop = true;
            this.RbDistincion2.Text = "Promedio entre 8 y 9";
            this.RbDistincion2.UseVisualStyleBackColor = true;
            // 
            // RbDistincion1
            // 
            this.RbDistincion1.AutoSize = true;
            this.RbDistincion1.Location = new System.Drawing.Point(20, 45);
            this.RbDistincion1.Name = "RbDistincion1";
            this.RbDistincion1.Size = new System.Drawing.Size(171, 21);
            this.RbDistincion1.TabIndex = 0;
            this.RbDistincion1.TabStop = true;
            this.RbDistincion1.Text = "Promedio entre 9 Y 10";
            this.RbDistincion1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RbDistincion1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnBuscarAlimno);
            this.Controls.Add(this.TxtRegistroBuscar);
            this.Controls.Add(this.ListaMostrar);
            this.Controls.Add(ListaAlumnos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ListaAlumnos.ResumeLayout(false);
            ListaAlumnos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.TextBox TxNroDeRegistro;
        private System.Windows.Forms.Label LabelRegistro;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.Label labelMatRestantes;
        private System.Windows.Forms.Label labelMatAprobadas;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.TextBox TxMatAprobadas;
        private System.Windows.Forms.TextBox TxApellido;
        private System.Windows.Forms.TextBox TxPromedio;
        private System.Windows.Forms.TextBox TxMatRestantes;
        private System.Windows.Forms.Label labelPromedio;
        private System.Windows.Forms.ListBox ListaMostrar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.TextBox TxtRegistroBuscar;
        private System.Windows.Forms.Button BtnBuscarAlimno;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnMostrarDistinciones;
        private System.Windows.Forms.RadioButton RbDistincion3;
        private System.Windows.Forms.RadioButton RbDistincion2;
        private System.Windows.Forms.RadioButton RbDistincion1;
    }
}


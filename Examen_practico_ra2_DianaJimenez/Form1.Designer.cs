namespace examen_practico_ra2_DianaJimenez
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txt_direccion = new TextBox();
            txt_maestro = new TextBox();
            txt_email = new TextBox();
            btn_nuevo = new Button();
            btn_eliminar = new Button();
            btn_limpiar = new Button();
            dgv_Estudiante = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Curso = new DataGridViewTextBoxColumn();
            Seccion = new DataGridViewTextBoxColumn();
            Matricula = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Area_Tecnica = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Maestro_Titular = new DataGridViewTextBoxColumn();
            txt_telefono = new TextBox();
            txt_matricula = new TextBox();
            txt_nombre = new TextBox();
            cb_area_tecnica = new ComboBox();
            cb_genero = new ComboBox();
            cb_curso = new ComboBox();
            btn_agregar = new Button();
            cb_seccion = new ComboBox();
            btn_guardar = new Button();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Estudiante).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 10F);
            label1.Location = new Point(51, 77);
            label1.Name = "label1";
            label1.Size = new Size(80, 29);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 10F);
            label2.Location = new Point(51, 374);
            label2.Name = "label2";
            label2.Size = new Size(59, 29);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 10F);
            label3.Location = new Point(295, 77);
            label3.Name = "label3";
            label3.Size = new Size(62, 29);
            label3.TabIndex = 2;
            label3.Text = "Curso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 10F);
            label4.Location = new Point(40, 150);
            label4.Name = "label4";
            label4.Size = new Size(91, 29);
            label4.TabIndex = 3;
            label4.Text = "Matricula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 10F);
            label5.Location = new Point(283, 150);
            label5.Name = "label5";
            label5.Size = new Size(74, 29);
            label5.TabIndex = 4;
            label5.Text = "Seccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 10F);
            label6.Location = new Point(51, 235);
            label6.Name = "label6";
            label6.Size = new Size(84, 29);
            label6.TabIndex = 5;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Heading", 10F);
            label7.Location = new Point(267, 235);
            label7.Name = "label7";
            label7.Size = new Size(122, 29);
            label7.TabIndex = 6;
            label7.Text = "Area_Tecnica";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Heading", 10F);
            label8.Location = new Point(251, 374);
            label8.Name = "label8";
            label8.Size = new Size(152, 29);
            label8.TabIndex = 7;
            label8.Text = "Maestro_Titular ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Heading", 10F);
            label9.Location = new Point(40, 312);
            label9.Name = "label9";
            label9.Size = new Size(95, 29);
            label9.TabIndex = 8;
            label9.Text = "Direccion ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Heading", 10F);
            label10.Location = new Point(295, 312);
            label10.Name = "label10";
            label10.Size = new Size(73, 29);
            label10.TabIndex = 9;
            label10.Text = "Genero";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(267, 25);
            label11.Name = "label11";
            label11.Size = new Size(361, 52);
            label11.TabIndex = 10;
            label11.Text = "Datos_De_Estudiante";
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("Segoe UI", 8F);
            txt_direccion.Location = new Point(25, 344);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(150, 29);
            txt_direccion.TabIndex = 17;
            // 
            // txt_maestro
            // 
            txt_maestro.Font = new Font("Segoe UI", 8F);
            txt_maestro.Location = new Point(251, 409);
            txt_maestro.Name = "txt_maestro";
            txt_maestro.Size = new Size(150, 29);
            txt_maestro.TabIndex = 18;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 8F);
            txt_email.Location = new Point(25, 409);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(150, 29);
            txt_email.TabIndex = 19;
            // 
            // btn_nuevo
            // 
            btn_nuevo.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            btn_nuevo.ForeColor = Color.Black;
            btn_nuevo.Location = new Point(460, 138);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(112, 41);
            btn_nuevo.TabIndex = 21;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = true;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            btn_eliminar.ForeColor = Color.Black;
            btn_eliminar.Location = new Point(460, 193);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(112, 41);
            btn_eliminar.TabIndex = 23;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            btn_limpiar.ForeColor = Color.Black;
            btn_limpiar.Location = new Point(619, 193);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(112, 41);
            btn_limpiar.TabIndex = 24;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // dgv_Estudiante
            // 
            dgv_Estudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Estudiante.Columns.AddRange(new DataGridViewColumn[] { Nombre, Curso, Seccion, Matricula, Telefono, Area_Tecnica, Direccion, Genero, Email, Maestro_Titular });
            dgv_Estudiante.Location = new Point(428, 267);
            dgv_Estudiante.Name = "dgv_Estudiante";
            dgv_Estudiante.RowHeadersWidth = 62;
            dgv_Estudiante.Size = new Size(450, 193);
            dgv_Estudiante.TabIndex = 25;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Curso
            // 
            Curso.HeaderText = "curso";
            Curso.MinimumWidth = 8;
            Curso.Name = "Curso";
            Curso.Width = 150;
            // 
            // Seccion
            // 
            Seccion.HeaderText = "seccion";
            Seccion.MinimumWidth = 8;
            Seccion.Name = "Seccion";
            Seccion.Width = 150;
            // 
            // Matricula
            // 
            Matricula.HeaderText = "matricula";
            Matricula.MinimumWidth = 8;
            Matricula.Name = "Matricula";
            Matricula.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.Width = 150;
            // 
            // Area_Tecnica
            // 
            Area_Tecnica.HeaderText = "area_tecnica";
            Area_Tecnica.MinimumWidth = 8;
            Area_Tecnica.Name = "Area_Tecnica";
            Area_Tecnica.Width = 150;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "direccion";
            Direccion.MinimumWidth = 8;
            Direccion.Name = "Direccion";
            Direccion.Width = 150;
            // 
            // Genero
            // 
            Genero.HeaderText = "genero";
            Genero.MinimumWidth = 8;
            Genero.Name = "Genero";
            Genero.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // Maestro_Titular
            // 
            Maestro_Titular.HeaderText = "maestro_titular";
            Maestro_Titular.MinimumWidth = 8;
            Maestro_Titular.Name = "Maestro_Titular";
            Maestro_Titular.Width = 150;
            // 
            // txt_telefono
            // 
            txt_telefono.Font = new Font("Segoe UI", 8F);
            txt_telefono.Location = new Point(25, 267);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(150, 29);
            txt_telefono.TabIndex = 15;
            // 
            // txt_matricula
            // 
            txt_matricula.Font = new Font("Segoe UI", 8F);
            txt_matricula.Location = new Point(25, 193);
            txt_matricula.Name = "txt_matricula";
            txt_matricula.Size = new Size(150, 29);
            txt_matricula.TabIndex = 13;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Segoe UI", 8F);
            txt_nombre.Location = new Point(25, 109);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(150, 29);
            txt_nombre.TabIndex = 11;
            // 
            // cb_area_tecnica
            // 
            cb_area_tecnica.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_area_tecnica.FormattingEnabled = true;
            cb_area_tecnica.Location = new Point(248, 280);
            cb_area_tecnica.Name = "cb_area_tecnica";
            cb_area_tecnica.Size = new Size(155, 29);
            cb_area_tecnica.TabIndex = 26;
            // 
            // cb_genero
            // 
            cb_genero.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_genero.FormattingEnabled = true;
            cb_genero.Location = new Point(248, 344);
            cb_genero.Name = "cb_genero";
            cb_genero.Size = new Size(155, 29);
            cb_genero.TabIndex = 27;
            // 
            // cb_curso
            // 
            cb_curso.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_curso.FormattingEnabled = true;
            cb_curso.Location = new Point(246, 118);
            cb_curso.Name = "cb_curso";
            cb_curso.Size = new Size(155, 29);
            cb_curso.TabIndex = 28;
            // 
            // btn_agregar
            // 
            btn_agregar.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            btn_agregar.ForeColor = Color.Black;
            btn_agregar.Location = new Point(766, 138);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(112, 41);
            btn_agregar.TabIndex = 29;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // cb_seccion
            // 
            cb_seccion.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_seccion.FormattingEnabled = true;
            cb_seccion.Location = new Point(246, 193);
            cb_seccion.Name = "cb_seccion";
            cb_seccion.Size = new Size(155, 29);
            cb_seccion.TabIndex = 30;
            // 
            // btn_guardar
            // 
            btn_guardar.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            btn_guardar.ForeColor = Color.Black;
            btn_guardar.Location = new Point(619, 138);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(112, 41);
            btn_guardar.TabIndex = 22;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            btn_salir.ForeColor = Color.Black;
            btn_salir.Location = new Point(766, 193);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(112, 41);
            btn_salir.TabIndex = 31;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(908, 463);
            Controls.Add(btn_salir);
            Controls.Add(cb_seccion);
            Controls.Add(btn_agregar);
            Controls.Add(cb_curso);
            Controls.Add(cb_genero);
            Controls.Add(cb_area_tecnica);
            Controls.Add(dgv_Estudiante);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_nuevo);
            Controls.Add(txt_email);
            Controls.Add(txt_maestro);
            Controls.Add(txt_direccion);
            Controls.Add(txt_telefono);
            Controls.Add(txt_matricula);
            Controls.Add(txt_nombre);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_Estudiante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txt_direccion;
        private TextBox txt_maestro;
        private TextBox txt_email;
        private Button btn_nuevo;
        private Button btn_eliminar;
        private Button btn_limpiar;
        private DataGridView dgv_Estudiante;
        private TextBox txt_telefono;
        private TextBox txt_matricula;
        private TextBox txt_nombre;
        private ComboBox cb_area_tecnica;
        private ComboBox cb_genero;
        private ComboBox cb_curso;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewTextBoxColumn Seccion;
        private DataGridViewTextBoxColumn Matricula;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Area_Tecnica;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Maestro_Titular;
        private Button btn_agregar;
        private ComboBox cb_seccion;
        private Button btn_guardar;
        private Button btn_salir;
    }
}

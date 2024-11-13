namespace UI
{
    partial class FormPartidos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBoxAlta = new GroupBox();
            btnConfirmar = new Button();
            btnAgregarPartido = new Button();
            dateTimePickerPartido = new DateTimePicker();
            txbEquipoVisitante = new TextBox();
            txbEquipoLocal = new TextBox();
            comboBoxDeporte = new ComboBox();
            lblDeporte = new Label();
            lblEquipoLocal = new Label();
            lblEquipoVisitante = new Label();
            lblFechaPartido = new Label();
            btnGuardar = new Button();
            groupBoxEliminar = new GroupBox();
            lblIDEliminarPartido = new Label();
            txbIdEliminar = new TextBox();
            btnEliminar = new Button();
            groupBoxModificar = new GroupBox();
            txbMarcadorVisitante = new TextBox();
            txbMarcadorLocal = new TextBox();
            lblMarcadorVisitante = new Label();
            lblMarcadorLocal = new Label();
            lblIDActualizar = new Label();
            txbIdActualizar = new TextBox();
            btnModificar = new Button();
            dgvPartidos = new DataGridView();
            btnSalir = new Button();
            lblAlumno = new Label();
            groupBoxAlta.SuspendLayout();
            groupBoxEliminar.SuspendLayout();
            groupBoxModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAlta
            // 
            groupBoxAlta.Controls.Add(btnConfirmar);
            groupBoxAlta.Controls.Add(btnAgregarPartido);
            groupBoxAlta.Controls.Add(dateTimePickerPartido);
            groupBoxAlta.Controls.Add(txbEquipoVisitante);
            groupBoxAlta.Controls.Add(txbEquipoLocal);
            groupBoxAlta.Controls.Add(comboBoxDeporte);
            groupBoxAlta.Controls.Add(lblDeporte);
            groupBoxAlta.Controls.Add(lblEquipoLocal);
            groupBoxAlta.Controls.Add(lblEquipoVisitante);
            groupBoxAlta.Controls.Add(lblFechaPartido);
            groupBoxAlta.Controls.Add(btnGuardar);
            groupBoxAlta.Location = new Point(55, 12);
            groupBoxAlta.Name = "groupBoxAlta";
            groupBoxAlta.Size = new Size(430, 257);
            groupBoxAlta.TabIndex = 0;
            groupBoxAlta.TabStop = false;
            groupBoxAlta.Text = "Alta Partido";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(271, 220);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(153, 31);
            btnConfirmar.TabIndex = 14;
            btnConfirmar.Text = "Confirmar cambios";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnAgregarPartido
            // 
            btnAgregarPartido.Location = new Point(271, 178);
            btnAgregarPartido.Name = "btnAgregarPartido";
            btnAgregarPartido.Size = new Size(153, 31);
            btnAgregarPartido.TabIndex = 13;
            btnAgregarPartido.Text = "Agregar a la lista borrador";
            btnAgregarPartido.UseVisualStyleBackColor = true;
            btnAgregarPartido.Click += btnAgregarPartido_Click;
            // 
            // dateTimePickerPartido
            // 
            dateTimePickerPartido.Location = new Point(113, 135);
            dateTimePickerPartido.Name = "dateTimePickerPartido";
            dateTimePickerPartido.Size = new Size(285, 23);
            dateTimePickerPartido.TabIndex = 12;
            // 
            // txbEquipoVisitante
            // 
            txbEquipoVisitante.Location = new Point(113, 91);
            txbEquipoVisitante.Name = "txbEquipoVisitante";
            txbEquipoVisitante.Size = new Size(286, 23);
            txbEquipoVisitante.TabIndex = 11;
            // 
            // txbEquipoLocal
            // 
            txbEquipoLocal.Location = new Point(113, 56);
            txbEquipoLocal.Name = "txbEquipoLocal";
            txbEquipoLocal.Size = new Size(286, 23);
            txbEquipoLocal.TabIndex = 10;
            // 
            // comboBoxDeporte
            // 
            comboBoxDeporte.FormattingEnabled = true;
            comboBoxDeporte.Location = new Point(111, 20);
            comboBoxDeporte.Name = "comboBoxDeporte";
            comboBoxDeporte.Size = new Size(288, 23);
            comboBoxDeporte.TabIndex = 9;
            // 
            // lblDeporte
            // 
            lblDeporte.AutoSize = true;
            lblDeporte.Location = new Point(15, 28);
            lblDeporte.Name = "lblDeporte";
            lblDeporte.Size = new Size(49, 15);
            lblDeporte.TabIndex = 5;
            lblDeporte.Text = "Deporte";
            // 
            // lblEquipoLocal
            // 
            lblEquipoLocal.AutoSize = true;
            lblEquipoLocal.Location = new Point(15, 64);
            lblEquipoLocal.Name = "lblEquipoLocal";
            lblEquipoLocal.Size = new Size(75, 15);
            lblEquipoLocal.TabIndex = 6;
            lblEquipoLocal.Text = "Equipo Local";
            // 
            // lblEquipoVisitante
            // 
            lblEquipoVisitante.AutoSize = true;
            lblEquipoVisitante.Location = new Point(15, 99);
            lblEquipoVisitante.Name = "lblEquipoVisitante";
            lblEquipoVisitante.Size = new Size(92, 15);
            lblEquipoVisitante.TabIndex = 7;
            lblEquipoVisitante.Text = "Equipo Visitante";
            // 
            // lblFechaPartido
            // 
            lblFechaPartido.AutoSize = true;
            lblFechaPartido.Location = new Point(15, 135);
            lblFechaPartido.Name = "lblFechaPartido";
            lblFechaPartido.Size = new Size(79, 15);
            lblFechaPartido.TabIndex = 8;
            lblFechaPartido.Text = "Fecha Partido";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(110, 178);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 31);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar un partido";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBoxEliminar
            // 
            groupBoxEliminar.Controls.Add(lblIDEliminarPartido);
            groupBoxEliminar.Controls.Add(txbIdEliminar);
            groupBoxEliminar.Controls.Add(btnEliminar);
            groupBoxEliminar.Location = new Point(528, 12);
            groupBoxEliminar.Name = "groupBoxEliminar";
            groupBoxEliminar.Size = new Size(305, 93);
            groupBoxEliminar.TabIndex = 1;
            groupBoxEliminar.TabStop = false;
            groupBoxEliminar.Text = "Eliminar Partido";
            // 
            // lblIDEliminarPartido
            // 
            lblIDEliminarPartido.AutoSize = true;
            lblIDEliminarPartido.Location = new Point(6, 28);
            lblIDEliminarPartido.Name = "lblIDEliminarPartido";
            lblIDEliminarPartido.Size = new Size(126, 15);
            lblIDEliminarPartido.TabIndex = 12;
            lblIDEliminarPartido.Text = "Ingrese el ID a eliminar";
            // 
            // txbIdEliminar
            // 
            txbIdEliminar.Location = new Point(156, 22);
            txbIdEliminar.Name = "txbIdEliminar";
            txbIdEliminar.Size = new Size(60, 23);
            txbIdEliminar.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(202, 62);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(84, 25);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBoxModificar
            // 
            groupBoxModificar.Controls.Add(txbMarcadorVisitante);
            groupBoxModificar.Controls.Add(txbMarcadorLocal);
            groupBoxModificar.Controls.Add(lblMarcadorVisitante);
            groupBoxModificar.Controls.Add(lblMarcadorLocal);
            groupBoxModificar.Controls.Add(lblIDActualizar);
            groupBoxModificar.Controls.Add(txbIdActualizar);
            groupBoxModificar.Controls.Add(btnModificar);
            groupBoxModificar.Location = new Point(528, 111);
            groupBoxModificar.Name = "groupBoxModificar";
            groupBoxModificar.Size = new Size(305, 158);
            groupBoxModificar.TabIndex = 1;
            groupBoxModificar.TabStop = false;
            groupBoxModificar.Text = "Modificar Partido";
            // 
            // txbMarcadorVisitante
            // 
            txbMarcadorVisitante.Location = new Point(156, 84);
            txbMarcadorVisitante.Name = "txbMarcadorVisitante";
            txbMarcadorVisitante.Size = new Size(60, 23);
            txbMarcadorVisitante.TabIndex = 17;
            // 
            // txbMarcadorLocal
            // 
            txbMarcadorLocal.Location = new Point(156, 55);
            txbMarcadorLocal.Name = "txbMarcadorLocal";
            txbMarcadorLocal.Size = new Size(60, 23);
            txbMarcadorLocal.TabIndex = 16;
            // 
            // lblMarcadorVisitante
            // 
            lblMarcadorVisitante.AutoSize = true;
            lblMarcadorVisitante.Location = new Point(6, 92);
            lblMarcadorVisitante.Name = "lblMarcadorVisitante";
            lblMarcadorVisitante.Size = new Size(106, 15);
            lblMarcadorVisitante.TabIndex = 15;
            lblMarcadorVisitante.Text = "Marcador Visitante";
            // 
            // lblMarcadorLocal
            // 
            lblMarcadorLocal.AutoSize = true;
            lblMarcadorLocal.Location = new Point(6, 63);
            lblMarcadorLocal.Name = "lblMarcadorLocal";
            lblMarcadorLocal.Size = new Size(89, 15);
            lblMarcadorLocal.TabIndex = 14;
            lblMarcadorLocal.Text = "Marcador Local";
            // 
            // lblIDActualizar
            // 
            lblIDActualizar.AutoSize = true;
            lblIDActualizar.Location = new Point(6, 31);
            lblIDActualizar.Name = "lblIDActualizar";
            lblIDActualizar.Size = new Size(133, 15);
            lblIDActualizar.TabIndex = 13;
            lblIDActualizar.Text = "Ingrese el ID a actualizar";
            // 
            // txbIdActualizar
            // 
            txbIdActualizar.Location = new Point(156, 22);
            txbIdActualizar.Name = "txbIdActualizar";
            txbIdActualizar.Size = new Size(60, 23);
            txbIdActualizar.TabIndex = 13;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(202, 126);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(84, 26);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dgvPartidos
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPartidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidos.Location = new Point(16, 275);
            dgvPartidos.Name = "dgvPartidos";
            dgvPartidos.ReadOnly = true;
            dgvPartidos.Size = new Size(849, 223);
            dgvPartidos.TabIndex = 2;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(785, 501);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(80, 27);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(15, 516);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(276, 15);
            lblAlumno.TabIndex = 4;
            lblAlumno.Text = "LUG - Itinerario 11 - Montenegro Fernando Agustin";
            // 
            // FormPartidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(872, 540);
            Controls.Add(lblAlumno);
            Controls.Add(btnSalir);
            Controls.Add(dgvPartidos);
            Controls.Add(groupBoxModificar);
            Controls.Add(groupBoxEliminar);
            Controls.Add(groupBoxAlta);
            Name = "FormPartidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Partidos";
            Load += FormPartidos_Load;
            groupBoxAlta.ResumeLayout(false);
            groupBoxAlta.PerformLayout();
            groupBoxEliminar.ResumeLayout(false);
            groupBoxEliminar.PerformLayout();
            groupBoxModificar.ResumeLayout(false);
            groupBoxModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxAlta;
        private Label lblDeporte;
        private Label lblEquipoLocal;
        private Label lblEquipoVisitante;
        private Label lblFechaPartido;
        private Button btnGuardar;
        private GroupBox groupBoxEliminar;
        private Button btnEliminar;
        private GroupBox groupBoxModificar;
        private Button btnModificar;
        private DataGridView dgvPartidos;
        private Button btnSalir;
        private Label lblAlumno;
        private DateTimePicker dateTimePickerPartido;
        private TextBox txbEquipoVisitante;
        private TextBox txbEquipoLocal;
        private ComboBox comboBoxDeporte;
        private Label lblIDEliminarPartido;
        private TextBox txbIdEliminar;
        private TextBox txbMarcadorVisitante;
        private TextBox txbMarcadorLocal;
        private Label lblMarcadorVisitante;
        private Label lblMarcadorLocal;
        private Label lblIDActualizar;
        private TextBox txbIdActualizar;
        private Button btnConfirmar;
        private Button btnAgregarPartido;
    }
}


namespace DepreciationDBApp.Forms
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbSelectSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudContabilidad = new System.Windows.Forms.NumericUpDown();
            this.nudMatematicas = new System.Windows.Forms.NumericUpDown();
            this.nudEstadistica = new System.Windows.Forms.NumericUpDown();
            this.nudProgramacion = new System.Windows.Forms.NumericUpDown();
            this.lblContabilidad = new System.Windows.Forms.Label();
            this.lblMatematicas = new System.Windows.Forms.Label();
            this.lblEstadistica = new System.Windows.Forms.Label();
            this.lblProgramacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContabilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatematicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstadistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProgramacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(304, 89);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowTemplate.Height = 25;
            this.dgvStudent.Size = new System.Drawing.Size(492, 254);
            this.dgvStudent.TabIndex = 1;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(100, 3);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(87, 23);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Get Students";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(112, 32);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(498, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(111, 23);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "Id or Name";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.txtCorreo);
            this.gbInfo.Controls.Add(this.txtDireccion);
            this.gbInfo.Controls.Add(this.txtCelular);
            this.gbInfo.Controls.Add(this.txtCarnet);
            this.gbInfo.Controls.Add(this.txtApellido);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.lblCorreo);
            this.gbInfo.Controls.Add(this.lblDireccion);
            this.gbInfo.Controls.Add(this.lblCelular);
            this.gbInfo.Controls.Add(this.lblCarnet);
            this.gbInfo.Controls.Add(this.lblApellidos);
            this.gbInfo.Controls.Add(this.lblName);
            this.gbInfo.Location = new System.Drawing.Point(18, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(280, 213);
            this.gbInfo.TabIndex = 7;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(104, 178);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(167, 23);
            this.txtCorreo.TabIndex = 13;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(104, 132);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(167, 40);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(104, 103);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(167, 23);
            this.txtCelular.TabIndex = 11;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(104, 74);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(167, 23);
            this.txtCarnet.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(104, 45);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(167, 23);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 23);
            this.txtName.TabIndex = 8;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(3, 181);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(43, 15);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(3, 135);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(3, 106);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(44, 15);
            this.lblCelular.TabIndex = 4;
            this.lblCelular.Text = "Celular";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(3, 77);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(42, 15);
            this.lblCarnet.TabIndex = 2;
            this.lblCarnet.Text = "Carnet";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(3, 48);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(56, 15);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnAdd);
            this.flpButtons.Controls.Add(this.btnGet);
            this.flpButtons.Controls.Add(this.btnDelete);
            this.flpButtons.Controls.Add(this.btnUpdate);
            this.flpButtons.Location = new System.Drawing.Point(21, 382);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(257, 63);
            this.flpButtons.TabIndex = 8;
            // 
            // cmbSelectSearch
            // 
            this.cmbSelectSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectSearch.FormattingEnabled = true;
            this.cmbSelectSearch.Items.AddRange(new object[] {
            "Id or Code\t",
            "Name"});
            this.cmbSelectSearch.Location = new System.Drawing.Point(327, 24);
            this.cmbSelectSearch.Name = "cmbSelectSearch";
            this.cmbSelectSearch.Size = new System.Drawing.Size(137, 23);
            this.cmbSelectSearch.TabIndex = 9;
            this.cmbSelectSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSelectSearch_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(630, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudContabilidad);
            this.groupBox1.Controls.Add(this.nudMatematicas);
            this.groupBox1.Controls.Add(this.nudEstadistica);
            this.groupBox1.Controls.Add(this.nudProgramacion);
            this.groupBox1.Controls.Add(this.lblContabilidad);
            this.groupBox1.Controls.Add(this.lblMatematicas);
            this.groupBox1.Controls.Add(this.lblEstadistica);
            this.groupBox1.Controls.Add(this.lblProgramacion);
            this.groupBox1.Location = new System.Drawing.Point(18, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 138);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materias";
            // 
            // nudContabilidad
            // 
            this.nudContabilidad.Location = new System.Drawing.Point(103, 101);
            this.nudContabilidad.Name = "nudContabilidad";
            this.nudContabilidad.Size = new System.Drawing.Size(168, 23);
            this.nudContabilidad.TabIndex = 11;
            // 
            // nudMatematicas
            // 
            this.nudMatematicas.Location = new System.Drawing.Point(103, 72);
            this.nudMatematicas.Name = "nudMatematicas";
            this.nudMatematicas.Size = new System.Drawing.Size(168, 23);
            this.nudMatematicas.TabIndex = 10;
            // 
            // nudEstadistica
            // 
            this.nudEstadistica.Location = new System.Drawing.Point(104, 43);
            this.nudEstadistica.Name = "nudEstadistica";
            this.nudEstadistica.Size = new System.Drawing.Size(167, 23);
            this.nudEstadistica.TabIndex = 9;
            // 
            // nudProgramacion
            // 
            this.nudProgramacion.Location = new System.Drawing.Point(103, 14);
            this.nudProgramacion.Name = "nudProgramacion";
            this.nudProgramacion.Size = new System.Drawing.Size(168, 23);
            this.nudProgramacion.TabIndex = 8;
            // 
            // lblContabilidad
            // 
            this.lblContabilidad.AutoSize = true;
            this.lblContabilidad.Location = new System.Drawing.Point(0, 103);
            this.lblContabilidad.Name = "lblContabilidad";
            this.lblContabilidad.Size = new System.Drawing.Size(75, 15);
            this.lblContabilidad.TabIndex = 7;
            this.lblContabilidad.Text = "Contabilidad";
            // 
            // lblMatematicas
            // 
            this.lblMatematicas.AutoSize = true;
            this.lblMatematicas.Location = new System.Drawing.Point(3, 74);
            this.lblMatematicas.Name = "lblMatematicas";
            this.lblMatematicas.Size = new System.Drawing.Size(75, 15);
            this.lblMatematicas.TabIndex = 6;
            this.lblMatematicas.Text = "Matematicas";
            // 
            // lblEstadistica
            // 
            this.lblEstadistica.AutoSize = true;
            this.lblEstadistica.Location = new System.Drawing.Point(3, 45);
            this.lblEstadistica.Name = "lblEstadistica";
            this.lblEstadistica.Size = new System.Drawing.Size(62, 15);
            this.lblEstadistica.TabIndex = 5;
            this.lblEstadistica.Text = "Estadistica";
            // 
            // lblProgramacion
            // 
            this.lblProgramacion.AutoSize = true;
            this.lblProgramacion.Location = new System.Drawing.Point(3, 16);
            this.lblProgramacion.Name = "lblProgramacion";
            this.lblProgramacion.Size = new System.Drawing.Size(82, 15);
            this.lblProgramacion.TabIndex = 0;
            this.lblProgramacion.Text = "Programacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Promedio de notas:";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(478, 383);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(100, 23);
            this.txtPromedio.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 480);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSelectSearch);
            this.Controls.Add(this.flpButtons);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContabilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatematicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstadistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProgramacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbSelectSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMatematicas;
        private System.Windows.Forms.Label lblEstadistica;
        private System.Windows.Forms.Label lblProgramacion;
        private System.Windows.Forms.Label lblContabilidad;
        private System.Windows.Forms.NumericUpDown nudContabilidad;
        private System.Windows.Forms.NumericUpDown nudMatematicas;
        private System.Windows.Forms.NumericUpDown nudEstadistica;
        private System.Windows.Forms.NumericUpDown nudProgramacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPromedio;
    }
}


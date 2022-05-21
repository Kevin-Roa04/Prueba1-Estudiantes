using DepreciationDBApp.Domain.Helper;
using Sistematico.Applications.Interfaces;
using Sistematico.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciationDBApp.Forms
{
    public partial class Form1 : Form
    {
        private IStudentService studentService;

        public Form1(IStudentService studentService)
        {
            this.studentService = studentService;
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validations.emptyFields(txtName.Text, txtApellido.Text, txtCarnet.Text, txtCelular.Text, txtDireccion.Text, txtCorreo.Text, nudProgramacion.Value, nudEstadistica.Value, nudMatematicas.Value, nudContabilidad.Value))
                {
                    if(Validations.ValidationFiels(txtCorreo.Text, txtCelular.Text, txtCarnet.Text))
                    {
                        Estudiante estudiante = new Estudiante
                        {
                            Nombres = txtName.Text,
                            Apellidos = txtApellido.Text,
                            Carnet = txtCarnet.Text,
                            Phone = txtCelular.Text,
                            Direccion = txtDireccion.Text,
                            Correo = txtCorreo.Text,
                            Matematica = (int)nudMatematicas.Value,
                            Estadistica = (int)nudEstadistica.Value,
                            Contabilidad = (int)nudContabilidad.Value,
                            Programacion = (int)nudProgramacion.Value
                        };
                        studentService.Create(estudiante);
                        cleanTxts();
                        fillDgv();
                        return;
                    }
                }
                MessageBox.Show("You have must fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            fillDgv();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validations.emptyFields(txtName.Text, txtApellido.Text, txtCarnet.Text, txtCelular.Text, txtDireccion.Text, txtCorreo.Text, nudProgramacion.Value, nudEstadistica.Value, nudMatematicas.Value, nudContabilidad.Value))
                {
                    if (Validations.ValidationFiels(txtCorreo.Text, txtCelular.Text, txtCarnet.Text))
                    {
                        object n = dgvStudent.CurrentRow.Cells[0].Value;
                        if (n == null)
                        {
                            MessageBox.Show("Plis Choose a Student correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Estudiante estudiante = studentService.FindById((Int32)n);
                        estudiante.Nombres = txtName.Text;
                        estudiante.Apellidos = txtApellido.Text;
                        estudiante.Carnet = txtCarnet.Text;
                        estudiante.Phone = txtCelular.Text;
                        estudiante.Direccion = txtDireccion.Text;
                        estudiante.Correo = txtCorreo.Text;
                        estudiante.Programacion = (int)nudProgramacion.Value;
                        estudiante.Matematica = (int)nudMatematicas.Value;
                        estudiante.Estadistica = (int)nudEstadistica.Value;
                        estudiante.Contabilidad = (int)nudContabilidad.Value;
                        studentService.Update(estudiante);
                        cleanTxts();
                        fillDgv();
                        return;
                    }
                }
                MessageBox.Show("You have must fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillDgv();
            txtSearch.Visible = false;
            btnSearch.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                object n = dgvStudent.CurrentRow.Cells[0].Value;
                if (n == null)
                {
                    MessageBox.Show("Plis Choose a Student correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Estudiante estudiante = studentService.FindById((Int32)n);
                
                if (studentService.Delete(estudiante))
                {
                    cleanTxts();
                    fillDgv();
                }
                MessageBox.Show("The student don't be delete correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("You must select a DataGridView element", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Estudiante estudiante = studentService.GetAll()[e.RowIndex];
                    if (estudiante == null)
                    {
                        MessageBox.Show("The Student don't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    txtName.Text = estudiante.Nombres;
                    txtApellido.Text = estudiante.Apellidos;
                    txtCarnet.Text = estudiante.Carnet;
                    txtCelular.Text = estudiante.Phone;
                    txtDireccion.Text = estudiante.Direccion;
                    txtCorreo.Text = estudiante.Correo;
                    nudProgramacion.Value = estudiante.Programacion;
                    nudMatematicas.Value = estudiante.Matematica;
                    nudEstadistica.Value = estudiante.Estadistica;
                    nudContabilidad.Value = estudiante.Contabilidad;

                    txtPromedio.Text = studentService.GetAverageByStudent(estudiante).ToString();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }

        private void cmbSelectSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
            txtSearch.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSelectSearch.SelectedIndex > -1)
                {
                    if (cmbSelectSearch.SelectedIndex == 0)
                    {
                        List<Estudiante> estudiantes = new List<Estudiante>();
                        estudiantes.Add(studentService.FindById(Int32.Parse(txtSearch.Text)));
                        fillDgv(estudiantes);
                        return;
                    }
                    List<Estudiante> estudiantes1 = studentService.FindByName(txtSearch.Text);
                    fillDgv(estudiantes1);
                    return;
                }
                MessageBox.Show("You have to select an option in the comboBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region
        private void cleanTxts()
        {
            txtName.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCarnet.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            nudProgramacion.Value = 0;
            nudMatematicas.Value = 0;
            nudEstadistica.Value = 0;
            nudContabilidad.Value = 0;
            txtPromedio.Text = string.Empty;
        }
        private void fillDgv(List<Estudiante> students)
        {
            dgvStudent.DataSource = null;
            dgvStudent.DataSource = students;
        }
        private void fillDgv()
        {
            dgvStudent.DataSource = null;
            List<Estudiante> students = studentService.GetAll();
            dgvStudent.DataSource = students;
        }
        #endregion

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cmbSelectSearch.SelectedIndex == 0)
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Only numbers are allowed");
                    return;
                }
            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Only letters are allowed");
                }
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters are allowed");
            }
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters are allowed");
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed");
            }
        }
    }
}

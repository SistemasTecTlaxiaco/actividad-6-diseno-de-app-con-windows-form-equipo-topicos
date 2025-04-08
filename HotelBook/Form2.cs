using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicioLibrary;

namespace HotelBook
{
    public partial class Form2 : Form
    {
        private Servicio servicio;

        public Form2()
        {
            InitializeComponent();
            servicio = new Servicio();  // Asegúrate de que Servicio tenga un constructor sin parámetros
        }

        private void btnagregarservicio_Click(object sender, EventArgs e)
        {
            string servicioNuevo = textBox1.Text;
            if (!string.IsNullOrEmpty(servicioNuevo))
            {
                servicio.AgregarServicio(servicioNuevo);
                MessageBox.Show("Servicio agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor ingrese un servicio válido.");
            }
        }

        private void btneliminarservicio_Click(object sender, EventArgs e)
        {
            string servicioEliminar = textBox1.Text;
            if (!string.IsNullOrEmpty(servicioEliminar))
            {
                servicio.EliminarServicio(servicioEliminar);
                MessageBox.Show("Servicio eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor ingrese el servicio a eliminar.");
            }
        }

        private void btnmoficarservicio_Click(object sender, EventArgs e)
        {
            string servicioAntiguo = textBox1.Text;
            string servicioNuevo = textBox2.Text;
            if (!string.IsNullOrEmpty(servicioAntiguo) && !string.IsNullOrEmpty(servicioNuevo))
            {
                servicio.ModificarServicio(servicioAntiguo, servicioNuevo);
                MessageBox.Show("Servicio modificado exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor ingrese ambos servicios.");
            }
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
    }
}

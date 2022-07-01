using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RN;

namespace UI
{
    
    public partial class FrmInicio : Form
    {
        Administradora admin;
        
        public FrmInicio()
        {
            InitializeComponent();
            admin= new Administradora();
            refrescarLista();
          
        }
        public void refrescarLista()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = admin.darLista();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona per = null;
            try {
                int d = int.Parse(textBox1.Text.Trim());
                string n = textBox2.Text.Trim();
                per = new Persona(d, n);
                admin.ponerPersona(per);
                refrescarLista();
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la persona: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin = null;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Persona per =(Persona) listBox1.SelectedItem;
                admin.eliminarPersona(per);
                refrescarLista();
            }
        }
    }
}

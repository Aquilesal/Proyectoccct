using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("logo.png");
            labeltrans.Hide();
            labelcod.Hide();
            labelmonto.Hide();
            labelcodigo.Hide();
            labelmont.Hide();
            labeltransf.Hide();
            buttonCan.Hide();
            buttonval.Hide();  
        }

        //private bool is_validate()
        //{
        //    bool no_error = true;
            
        //        // Limpiar todos los mensajes de error
        //        try
        //        {
        //            long i = Convert.ToInt64(textBox1.Text);

        //        }
        //        catch
        //        {
        //            error.Clear(); // Limpiar todos los mensajes de error
        //            error.SetError(textBox1, "Ingrese un codigo valido");
        //            return false;
        //        }

            
        //    return no_error;

        //}

        private void buttonCan_Click(object sender, EventArgs e)
        {
                error.Clear();
                textBox1.Clear();
                labeltrans.Hide();
                labelcod.Hide();
                labelmonto.Hide();
                labelcodigo.Hide();
                labelmont.Hide();
                labeltransf.Hide();
                buttonCan.Hide();
                buttonval.Hide();
            
        }

        private void buttonval_Click(object sender, EventArgs e)
        {
        
            DialogResult dialogResult= MessageBox.Show("Se ha validado correctamente el usuario", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(dialogResult== DialogResult.OK)
            {
                Registro registro;
                WebClient webClient = new WebClient();


                string datos = webClient.DownloadString("http://localhost:3000/validar?bool=true&id=" + textBox1.Text + "");
                Console.WriteLine("Datos  ", datos);
                //registro = JsonConvert.DeserializeObject<Registro>(datos);

                error.Clear();
                textBox1.Clear();
                labeltrans.Hide();
                labelcod.Hide();
                labelmonto.Hide();
                labelcodigo.Hide();
                labelmont.Hide();
                labeltransf.Hide();
                buttonCan.Hide();
                buttonval.Hide();
            }
        }

        private void button_buscar(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                error.Clear();
                error.SetError(textBox1, "Ingrese Numero de Identificador");
            }
            else
            { Registro registro;
                WebClient webClient = new WebClient();


                string datos = webClient.DownloadString("http://localhost:3000/buscar?id=" + textBox1.Text + "");
                Console.WriteLine("My public IP Address is: {0}", datos);
                registro = JsonConvert.DeserializeObject<Registro>(datos);

                error.Clear();
                if (registro == null)
                {
                    MessageBox.Show("No se ha encontrado la id de transaccion solicitada", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //textBox1.Clear();
                    error.Clear();
                    labeltrans.Hide();
                    labelcod.Hide();
                    labelmonto.Hide();
                    labelcodigo.Hide();
                    labelmont.Hide();
                    labeltransf.Hide();
                    buttonCan.Hide();
                    buttonval.Hide();

                }
                else
                {
                    if (!registro.re_validado)
                    {

                        // Mostramos un mensaje si todo está correcto
                       // MessageBox.Show("Datos Agregados Correctamente", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        labeltransf.Text = registro.re_idtrans;
                        labelcodigo.Text = registro.re_codvippo;
                        labelmont.Text = registro.re_monto;

                        labeltrans.Show();
                        labelcod.Show();
                        labelmonto.Show();
                        labelcodigo.Show();
                        labelmont.Show();
                        labeltransf.Show();
                        buttonCan.Show();
                        buttonval.Show();

                    }


                    else
                    {
                        MessageBox.Show("El usuario con esa id de transaccion ya ha sido validado", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //textBox1.Clear();
                    }
                }
                
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else //Para todo lo demas
            {
                e.Handled = true; //No se acepta (si pulsas cualquier otra cosa pues no se envia)
                error.SetError(textBox1, "Solo ingrese numeros");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.ForeColor = Color.Black;
            error.Clear();
            //if (!is_validate())
            //{
            //    textBox1.ForeColor = Color.Red;
            //}
        }
    }
}

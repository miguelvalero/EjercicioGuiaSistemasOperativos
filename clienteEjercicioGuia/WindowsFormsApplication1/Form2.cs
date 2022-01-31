using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        int nForm;
        Socket server;
        public Form2(int nForm, Socket server)
        {
            InitializeComponent();
            this.nForm = nForm;
            this.server = server;
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            if (Longitud.Checked)
            {
                string mensaje = "1/"+nForm+"/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

            }
            else if (Bonito.Checked)
            {
                string mensaje = "2/" + nForm + "/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

             

            }
            else
            {
                // Enviamos nombre y altura
                string mensaje = "3/" + nForm + "/" + nombre.Text + "/" + alturaBox.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

              
            }
             
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numForm.Text = nForm.ToString();
        
        }

        public void TomaRespuesta1(string mensaje)
        {
            MessageBox.Show("Longitud: " + mensaje);
        }
        public void TomaRespuesta2(string mensaje)
        {
            if (mensaje == "SI")
                MessageBox.Show("Tu nombre es bonito");
            else
                MessageBox.Show("Tu nombre No es bonito. Lo siento");
        }
        public void TomaRespuesta3(string mensaje)
        {
            MessageBox.Show(mensaje);

        }
        
    }
}

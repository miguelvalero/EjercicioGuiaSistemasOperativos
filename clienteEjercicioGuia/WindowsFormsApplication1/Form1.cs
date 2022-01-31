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
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        Thread atender;

        delegate void DelegadoParaPonerTexto(string texto);

        List<Form2> formularios = new List<Form2>();

        public Form1()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false; //Necesario para que los elementos de los formularios puedan ser
            //accedidos desde threads diferentes a los que los crearon
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }



        private void AtenderServidor()
        {
            while (true)
            {
                //Recibimos mensaje del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                string[] trozos = Encoding.ASCII.GetString(msg2).Split('/');
                int codigo = Convert.ToInt32(trozos[0]);
                string mensaje;
               
                int nform;
                switch (codigo)
                {
                    case 1:  // respuesta a longitud
                         
                         nform = Convert.ToInt32(trozos[1]);
                         mensaje = trozos[2].Split('\0')[0];
                         formularios[nform].TomaRespuesta1(mensaje);
                      
                        break;
                    case 2:      //respuesta a si mi nombre es bonito
                        
                         nform = Convert.ToInt32(trozos[1]);
                         mensaje = trozos[2].Split('\0')[0];
                         formularios[nform].TomaRespuesta2(mensaje);
                        
                        break;
                    case 3:       //Recibimos la respuesta de si soy alto
                         nform = Convert.ToInt32(trozos[1]);
                         mensaje = trozos[2].Split('\0')[0];
                         formularios[nform].TomaRespuesta3(mensaje);
                        break;

                    case 4:     //Recibimos notificacion

                 
                        mensaje = trozos[1].Split('\0')[0];
                       
                        //Haz tu lo que no me dejas hacer a mi
                        contLbl.Invoke(new Action(() =>
                        {
                            contLbl.Text = mensaje;
                        }));

                        break;
                }
            }
        }


                    


        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9050);
            

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");
                //pongo en marcha el thread que atenderá los mensajes del servidor
                ThreadStart ts = delegate { AtenderServidor(); };
                atender = new Thread(ts);
                atender.Start();

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

          

        }

     
        private void button3_Click(object sender, EventArgs e)
        {
            //Mensaje de desconexión
            string mensaje = "0/";
        
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Nos desconectamos
            atender.Abort();
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();


        }
        private void PonerEnMarchaFormulario()
        {
            int cont = formularios.Count;
            Form2 f = new Form2(cont, server);
            formularios.Add(f);
            f.ShowDialog();
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThreadStart ts = delegate { PonerEnMarchaFormulario(); };
            Thread T = new Thread(ts);
            T.Start();  
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mensaje de desconexión
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Nos desconectamos
            atender.Abort();
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();

        }

       

     
     
    }
}

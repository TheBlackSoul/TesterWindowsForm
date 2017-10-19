using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Navegador.Utilidades;

namespace TesterWindowsForm
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void navegador1_Insertrecieve(object sender, EventArgs e)
        {
        }

        private void navegador1_Insertrecieve_1(object sender, EventArgs e)
        {
            //string bd = navegador1.nombreBD;
            //string server = navegador1.servidor;
            //string user = navegador1.usuario;
            //string pass = navegador1.pass;
            //string nametabla = navegador1.nombreTabla;

            String campo1 = txNombre.Text;
            String campo2 = textBox2.Text;
            String campo3 = textBox3.Text;
            ArrayList listavalores = new ArrayList();
            ArrayList listacampos = new ArrayList();
           

            listavalores.Add(0);
            listavalores.Add(campo1);
            listavalores.Add(campo2);
            listavalores.Add(campo3);
            listavalores.Add("member");
            listavalores.Add(0);

            listacampos.Add("id");
            listacampos.Add("name");
            listacampos.Add("email");
            listacampos.Add("password");
            listacampos.Add("type");
            listacampos.Add("remember_token");

            

            GeneradorSQL gsql = new GeneradorSQL("server","bd","user","pass","nametabla");
            gsql.setCodigoInstDML(1);
            gsql.setCampos(listacampos);
            gsql.setValores(listavalores);
            gsql.ejecutar();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String campo = txNombre.Tag.ToString();
            MessageBox.Show(campo);
        }
    }
}

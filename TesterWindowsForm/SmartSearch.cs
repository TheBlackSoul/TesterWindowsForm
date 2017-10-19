using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos_B;
using System.Text.RegularExpressions;

namespace Capa_Diseño2_B
{
    public partial class SmartSearch : UserControl
    {

        [Description("Nombre de la tabla ")]
        [Category("Datos Importantes")]
        public String NombreTabla { get; set; }


        String sentencia_inicio = ""; //la que va despues del select
        String condicion1 = "";
        String simbolo_condicional = "";
        String condicion2 = "";
        String sentencia_final = ""; //incluye lo que va despues del from
        String sentencia_completa = ""; //es para unir las dos sentencias y formar la consulta total              

        String campos = ""; //formara el campo
        int numero_campos= 0;
        String campos_agregados=""; //acumula todos los campos que el usuario seleccione

        bool inicia_condicion = false;
        public SmartSearch()
        {
            InitializeComponent();
        }        

        public static String stringpad = "server=localhost;user id=root;database=laboratorio;";

        Capa_Datos_B.Capa_Datos_B connection = new Capa_Datos_B.Capa_Datos_B(stringpad);

        private void SmartSearch_Load(object sender, EventArgs e)
        {
            connection.OpenConnection();
            connection.llenarCombobox(Cmb_campos, NombreTabla);
            connection.CloseConnection();
            
            Btn_creacond.Enabled = false;
            Btn_agregarcond.Enabled = false;
            Btn_crear.Enabled = false;
            Btn_nuevo.Enabled = false;

            Txt_condicion1.Enabled = false;
            Txt_condicion2.Enabled = false;

            Cmb_operadorcondiciones.Enabled = false;
            Txt_operador.Enabled = false;
        }

        String cadena_inicio = "";
        String cadena_cierre = "";

        private void Cmb_operaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            String operacion = Cmb_operaciones.SelectedItem.ToString();

            if (operacion.Equals("SUMAR"))
            {
                cadena_inicio = cadena_inicio + " SUM( ";
                cadena_cierre = cadena_cierre + " ) ";
            }
            else if (operacion.Equals("CONTAR"))
            {
                cadena_inicio = cadena_inicio + " COUNT( ";
                cadena_cierre = cadena_cierre + " ) ";
            }
            else if (operacion.Equals("MINIMO"))
            {
                cadena_inicio = cadena_inicio + " MIN( ";
                cadena_cierre = cadena_cierre + " ) ";
            }
            else if (operacion.Equals("MAXIMO"))
            {
                cadena_inicio = cadena_inicio + " MAX( ";
                cadena_cierre = cadena_cierre + " ) ";
            }
            else if (operacion.Equals("PROMEDIAR"))
            {
                cadena_inicio = cadena_inicio + " AVG( ";
                cadena_cierre = cadena_cierre + " ) ";
            }
        }

        private void Cmb_campos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inicia_condicion == true)
            {
                Txt_condicion1.Text = Cmb_campos.SelectedItem.ToString();
            }
            else if (inicia_condicion == false)
            {
                campos = cadena_inicio + " " + Cmb_campos.SelectedItem.ToString() + " " + cadena_cierre;
            }
        }

        private void Btn_agregarcam_Click(object sender, EventArgs e)
        {          
            Regex ver1 = new Regex("^([a-zA-Z]+_[a-zA-Z]+)+$");
            Regex ver2 = new Regex("^[a-zA-Z]+$");

            if (numero_campos == 0)
            {
                if (Txt_alias.Text.Equals(""))
                {
                    campos_agregados = campos_agregados + campos;
                }
                else if (!Txt_alias.Text.Equals(""))
                {
                    if (ver1.IsMatch(Txt_alias.Text) || ver2.IsMatch(Txt_alias.Text))
                    {
                        campos_agregados = campos_agregados + " ( " + campos + " ) " + " AS " + Txt_alias.Text;
                    }
                    else
                    {
                        MessageBox.Show("La cadena no puede llevar espacios en blanco, unirlos con un: _");
                    }
                } 
            }
            else if (numero_campos >= 1)
            { 
                if (Txt_alias.Text.Equals(""))
                {
                    campos_agregados = campos_agregados + " , " + campos;
                }
                else if (!Txt_alias.Text.Equals(""))
                {
                    if (ver1.IsMatch(Txt_alias.Text) || ver2.IsMatch(Txt_alias.Text))
                    {
                        campos_agregados = campos_agregados + " , " + " ( " + campos + " ) " + " AS " + Txt_alias.Text;
                    }
                    else
                    {
                        MessageBox.Show("La cadena no puede llevar espacios en blanco, unirlos con un: _");
                    }
                }
            }

            numero_campos++;

            Cmb_operaciones.Text = "";
            Cmb_campos.Items.Remove(Cmb_campos.SelectedItem);
            Cmb_campos.Text = "";
            Txt_alias.Clear();

        }

        private void Btn_creacampos_Click(object sender, EventArgs e)
        {
            Cmb_campos.Items.Clear();

            connection.OpenConnection();
            connection.llenarCombobox(Cmb_campos, NombreTabla);
            connection.CloseConnection();

            if (campos_agregados.Equals(""))
            {
                sentencia_inicio = "SELECT *FROM " + NombreTabla;
            }
            else if (!campos_agregados.Equals(""))
            {
                sentencia_inicio = "SELECT " + campos_agregados + " FROM " + NombreTabla;
            }

            cadena_inicio = "";
            cadena_cierre = "";
            campos = "";
            campos_agregados = "";
            numero_campos = 0;

            Btn_agregarcam.Enabled = false;
            Btn_creacampos.Enabled = false;

            Txt_alias.Enabled = false;

            Cmb_operaciones.Enabled = false;
            
            Btn_creacond.Enabled = true;
            Btn_agregarcond.Enabled = true;

            Txt_condicion1.Enabled = true;
            Txt_condicion2.Enabled = true; 

            Cmb_operadorcondiciones.Enabled = true;
            

            inicia_condicion = true;
        }

        private void Btn_agregarcond_Click(object sender, EventArgs e)
        {
          
            Regex er = new Regex("^[0-9]+$");
            
            if ((Txt_condicion1.Text.Equals("") && Txt_operador.Text.Equals(null) && Txt_condicion2.Text.Equals(""))
                || (!Txt_condicion1.Text.Equals("") && Txt_operador.Text.Equals(null) && Txt_condicion2.Text.Equals(""))
                || (Txt_condicion1.Text.Equals("") && !Txt_operador.Text.Equals(null) && Txt_condicion2.Text.Equals(""))
                || (Txt_condicion1.Text.Equals("") && Txt_operador.Text.Equals(null) && !Txt_condicion2.Text.Equals(""))
                || (!Txt_condicion1.Text.Equals("") && !Txt_operador.Text.Equals(null) && Txt_condicion2.Text.Equals(""))
                || (Txt_condicion1.Text.Equals("") && !Txt_operador.Text.Equals(null) && !Txt_condicion2.Text.Equals(""))
                || (!Txt_condicion1.Text.Equals("") && Txt_operador.Text.Equals(null) && !Txt_condicion2.Text.Equals("")))
            {
                MessageBox.Show("Deben estar llenos los tres campos! ");
            }
            else if (!Txt_condicion1.Text.Equals("") && !Txt_operador.Text.Equals("") && !Txt_condicion2.Text.Equals(""))
            {
                if (condicion1.Equals("") && condicion2.Equals(""))
                {
                    if (er.IsMatch(Txt_condicion1.Text) && er.IsMatch(Txt_condicion2.Text))
                    {
                        condicion1 = " " + Txt_condicion1.Text + " " + simbolo_condicional + " " + Txt_condicion2.Text + " ";
                    }
                    else if (er.IsMatch(Txt_condicion1.Text) && !er.IsMatch(Txt_condicion2.Text))
                    {
                        condicion1 = " " + Txt_condicion1.Text + " " + simbolo_condicional + " '" + Txt_condicion2.Text + "' ";
                    }
                    else if (!er.IsMatch(Txt_condicion1.Text) && er.IsMatch(Txt_condicion2.Text))
                    {
                        condicion1 = " " + Txt_condicion1.Text + " " + simbolo_condicional + " " + Txt_condicion2.Text + " ";
                    }
                    else if (!er.IsMatch(Txt_condicion1.Text) && !er.IsMatch(Txt_condicion2.Text))
                    {
                        condicion1 = " " + Txt_condicion1.Text + " " + simbolo_condicional + " '" + Txt_condicion2.Text + "' ";
                    } 
                }
                else if (!condicion1.Equals("") && condicion2.Equals(""))
                {
                    if (er.IsMatch(Txt_condicion1.Text) && er.IsMatch(Txt_condicion2.Text))
                    {
                        condicion2 = " " + Txt_condicion1.Text + " " + simbolo_condicional + " " + Txt_condicion2.Text + " ";
                    }
                    else if (er.IsMatch(Txt_condicion1.Text) && !er.IsMatch(Txt_condicion2.Text))
                    {
                        condicion2 = " " + Txt_condicion1.Text + " " + simbolo_condicional + " '" + Txt_condicion2.Text + "' ";
                    }
                    else if (!er.IsMatch(Txt_condicion1.Text) && er.IsMatch(Txt_condicion2.Text))
                    {
                        condicion2 = " " + Txt_condicion1.Text + " " + simbolo_condicional + " " + Txt_condicion2.Text + " ";
                    }
                    else if (!er.IsMatch(Txt_condicion1.Text) && !er.IsMatch(Txt_condicion2.Text))
                    {
                        condicion2 = " " + Txt_condicion1.Text + " " + simbolo_condicional + " '" + Txt_condicion2.Text + "' ";
                    }
                }
                else if (!condicion1.Equals("") && !condicion2.Equals(""))
                {
                    if (er.IsMatch(Txt_condicion1.Text) && er.IsMatch(Txt_condicion2.Text))
                    {
                        condicion1 = " " + Txt_condicion1.Text + " " + simbolo_condicional + " " + Txt_condicion2.Text + " ";                        
                    }
                    else if (er.IsMatch(Txt_condicion1.Text) && !er.IsMatch(Txt_condicion2.Text))
                    {
                        condicion1 = " " + Txt_condicion1.Text + " " + simbolo_condicional + " '" + Txt_condicion2.Text + "' ";
                    }
                    else if (!er.IsMatch(Txt_condicion1.Text) && er.IsMatch(Txt_condicion2.Text))
                    {
                        condicion1 = " " + Txt_condicion1.Text + " " + simbolo_condicional + " " + Txt_condicion2.Text + " ";
                    }
                    else if (!er.IsMatch(Txt_condicion1.Text) && !er.IsMatch(Txt_condicion2.Text))
                    {
                        condicion1 = " " + Txt_condicion1.Text + " " + simbolo_condicional + " '" + Txt_condicion2.Text + "' ";
                    }

                    condicion2 = "";
                }
            }
            Txt_condicion1.Clear();
            Txt_condicion2.Clear();
            Cmb_campos.Items.Remove(Cmb_campos.SelectedItem);
            Cmb_campos.Text = "";
            Cmb_operadorcondiciones.Text = "";
            Txt_operador.Clear();          
        }        

        private void Cmb_operadorcondiciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_operador.Text = Cmb_operadorcondiciones.SelectedItem.ToString();

            String operador_condicion = Cmb_operadorcondiciones.SelectedItem.ToString();
            if (operador_condicion.Equals("Y"))
            {
                if (!condicion1.Equals("") && !condicion2.Equals(""))
                {
                    Txt_condicion1.Text = "(( " + condicion1 + " )";
                    simbolo_condicional = " AND ";
                    Txt_condicion2.Text = "( " + condicion2 + " ))";
                }
                else
                {
                    MessageBox.Show("Primero debe crear condiciones!");
                    Cmb_operadorcondiciones.Text = "";
                    Txt_operador.Clear();
                }
            }
            else if (operador_condicion.Equals("O"))
            {
                if (!condicion1.Equals("") && !condicion2.Equals(""))
                {
                    Txt_condicion1.Text = "( " + condicion1;
                    simbolo_condicional = " OR ";
                    Txt_condicion2.Text = condicion2 + " )";
                }
                else
                {
                    MessageBox.Show("Primero debe crear condiciones!");
                    Cmb_operadorcondiciones.Text = "";
                    Txt_operador.Clear();
                }
            }
            else if (operador_condicion.Equals("MAYOR QUE"))
            {
                simbolo_condicional = " > ";
            }
            else if (operador_condicion.Equals("MENOR QUE"))
            {
                simbolo_condicional = " < ";
            }
            else if (operador_condicion.Equals("IGUAL"))
            {
                simbolo_condicional = " = ";
            }
            else if (operador_condicion.Equals("MENOR O IGUAL"))
            {
                simbolo_condicional = " <= ";
            }
            else if (operador_condicion.Equals("MAYOR O IGUAL"))
            {
                simbolo_condicional = " >= ";
            }
            else if (operador_condicion.Equals("DIFERENTE"))
            {
                simbolo_condicional = " <> ";
            }
        }

        private void Btn_agregacc_Click(object sender, EventArgs e)
        {
            String c = Cmb_campos.SelectedItem.ToString();

            if (c.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un campo");
            }
            else if (!c.Equals(""))
            {
                Txt_condicion1.Text = c;
            }
            Cmb_campos.Text = "";
        }

        private void Btn_creacond_Click(object sender, EventArgs e)
        {
            if (condicion1.Equals(""))
            {
                sentencia_final = "";
            }
            else if (!condicion1.Equals(""))
            {
                sentencia_final = " WHERE " + condicion1;
            }
            condicion1 = "";
            condicion2 = "";

            Cmb_operadorcondiciones.Enabled = false;
            Txt_operador.Enabled = false;

            Txt_condicion1.Enabled = false;
            Txt_condicion2.Enabled = false;

            Cmb_campos.Enabled = false;

            Btn_crear.Enabled = true;            
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            sentencia_completa = sentencia_inicio + sentencia_final;                     

            connection.OpenConnection();
            connection.llenarDatagridview(Dgv_resultado, sentencia_completa, NombreTabla);
            connection.CloseConnection();

            Btn_nuevo.Enabled = true;
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Cmb_campos.Items.Clear();

            connection.OpenConnection();
            connection.llenarCombobox(Cmb_campos, NombreTabla);
            connection.CloseConnection();

            Btn_creacond.Enabled = false;
            Btn_agregarcond.Enabled = false;
            Btn_crear.Enabled = false;
            Btn_nuevo.Enabled = false;

            Txt_condicion1.Enabled = false;
            Txt_condicion2.Enabled = false;

            Cmb_operadorcondiciones.Enabled = false;
            Txt_operador.Enabled = false;

            Cmb_operaciones.Enabled = true;
            Cmb_campos.Enabled = true;

            Txt_alias.Enabled = true;

            Btn_agregarcam.Enabled = true;
            Btn_creacampos.Enabled = true;

            
            sentencia_completa = "";
            sentencia_inicio = "";
            sentencia_final = "";

            numero_campos = 0;
            campos_agregados = "";

            inicia_condicion = false;
        }
    }
}

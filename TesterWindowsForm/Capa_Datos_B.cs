using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Datos_B
{
    public class Capa_Datos_B
    {
        private MySqlConnection conn;
        private MySqlDataReader mdr;
        private MySqlCommand mcm;
        private DataSet ds;
        private MySqlDataAdapter mda;

        private String connStr;         

        public Capa_Datos_B(String connetionn)
        {
            this.connStr = connetionn;           
        }

        public bool OpenConnection()
        {
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la conexión de la base de datos" + ex);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cerrar la base de datos" + ex);
                return false;
            }
        }

        public void llenarCombobox(ComboBox combobox2, String table)
        {
            mcm = new MySqlCommand("SELECT COLUMN_NAME AS Campos FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = 'laboratorio' AND TABLE_NAME = '" + table + "'", conn);
            mdr = mcm.ExecuteReader();
            while (mdr.Read()) {
                combobox2.Items.Add(mdr["Campos"].ToString());
            }
            mdr.Close();
        }

        public void llenarDatagridview(DataGridView busqueda , String sentencia_select, String tabla)
        {
            mda = new MySqlDataAdapter(sentencia_select, conn);
            ds = new DataSet();
            mda.Fill(ds,tabla);
            busqueda.DataSource = ds;
            busqueda.DataMember = tabla;
        }
    }    
}




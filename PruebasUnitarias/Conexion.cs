using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias
{
    class Conexion{

        public void Consulta(){
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MT0H5K8\\SQLEXPRESS;Initial Catalog=globaldigital;Integrated Security = True"))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("select id_categoria,nombre,precio,unidad from producto;", cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read()){

                    Console.WriteLine("Codigo:" + Convert.ToString(dr["id_categoria"] + ", Nombre:" + Convert.ToString(dr["nombre"]+", precio: "+ Convert.ToString(dr["precio"]))));
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No encontro nada");
                    Console.ReadKey();
                }
                cn.Close();
            }
        }

        public void SPInsertProduct(){

            try
            {

                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MT0H5K8\\SQLEXPRESS;Initial Catalog=globaldigital;Integrated Security = True");
                string strSql = "";
                strSql = "SP_Insertar_producto";
                SqlCommand cmd = new SqlCommand(strSql, cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCatergoria", 100002);
                cmd.Parameters.AddWithValue("@nombre", "PC");
                cmd.Parameters.AddWithValue("@precio", 1400.25);
                cmd.Parameters.AddWithValue("@unidad", 180);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex){
                Console.WriteLine("Error de ejecuacion: "+ex);
                Console.ReadKey();
            }

        }

    }
}

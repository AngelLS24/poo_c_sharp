using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.IO;


namespace Escuela
{
    public partial class FProfesores : Form
    {
        // Nombre de la base de datos
        public string databaseName = "Escuela";
        // Nombre del servidor
        public string serverName = "localhost";
        // Contador de intentos de inicio de sesion
        public int cont = 1;
        public FProfesores()
        {

            InitializeComponent();
            try
            {
                // Se genera la cadena con la especificaciones de la coneccion a la base de datos
                string connectionString = "Data Source=" + serverName + ";Integrated security=SSPI;" +
                    "Initial Catalog=master";
                // Se realiza una consulta que nos regresa 1 si la base de datos existe y 0 si no existe
                string query = "SELECT COUNT(*) FROM sysdatabases WHERE name = 'Escuela'";
                // Se realiza la conexion
                SqlConnection conect = new SqlConnection(connectionString);
                // Se abre la conexion
                conect.Open();
                // Se ejecuta la consulta
                SqlCommand cmd = new SqlCommand(query, conect);
                // Se lee el resultado de la consulta
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) // Si hay datos
                {
                    // Valida si existe la base de datos
                    if(Convert.ToInt32(dr[0]) == 0)
                    {
                        // Se llama a la funcion que crea la base de datos, recibe el nombre del servidor y de la base de datos
                        Escuela_DB.BaseDeDatos(databaseName, serverName);
                        Mensaje("\tBienvenido al sistema de Profesores", "Inicio");
                    }else
                        Mensaje("\tBienvenido al sistema de Profesores", "Inicio");
                }
                // Cierra la conexion
                conect.Close();
            }
            catch(Exception e)
            {
                Mensaje("\tError conectando con la base de datos: " + e.Message, "Error");
                Application.Exit();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string user = TBUser.Text;
            string pass = TBPass.Text;
            // Valida que no se ingresen valores nulos o campos vacios
            if (!String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(pass))
            {
                try
                {
                    // llama a la funcion para conectarse a la base de dato, recibe el usuario y password
                    string conexion = ConectaDB(user, pass);
                    // Inicia la vista del menu
                    Menu menu = new Menu(user, conexion);
                    // Hace visible el menu
                    menu.Visible = true;
                    // Hace invisible la vista principal
                    Visible = false;
                }
                catch (SqlException)
                {
                    Mensaje("\tContraseña o Usuario incorrectos\n\n\t\tIntento: " + cont, "Error");
                    cont++;
                    if(cont > 3)
                    {
                        Mensaje("Se excedio el numero de intentos", "Error");
                        Application.Exit();
                    }
                }                
            }
            else
                Mensaje("Debe llenar ambos campos", "Error");
        }
        public void Mensaje(String mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo);
        }

        public string ConectaDB(string user, string pass)
        {
            // Se genera la cadena con la especificaciones de la coneccion a la base de datos
            string connectionString = @"Data Source=" + serverName + ";Initial Catalog=" + databaseName + 
                ";User ID=" + user + ";Password=" + pass;
            // Se realiza la conexion
            SqlConnection conect = new SqlConnection(connectionString);
            // Abre la conexion
            conect.Open();
            Mensaje("Bienvenido de nuevo " + user, "Bienbenido");
            conect.Close();
            return connectionString;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    /*
     * Clase que se utiliza para la creación de la base de datos
     */
    public static class Escuela_DB
    {
        // Funcion que llama a todos los metodos que se utilizan para crear la base de datos, recibe el nombre del servidor
        // y el nombre de la base de datos
        public static void BaseDeDatos(string databaseName, string serverName)
        {
            // Funcion que guardara las consultas
            SqlCommand cmd = null;
            // Realiza una conexion a la base de datos
            SqlConnection conexion = new SqlConnection("Data Source=" + serverName +";Integrated security=SSPI;database=master");
            try
            {
                // Llama a la funcion que crea la base de datos
                CreateDB(conexion, cmd, databaseName);
                // Llama a la funcion que crea el usuario/login de la base de datos
                CreateUser(conexion, cmd, serverName, databaseName);
                // Llama a la funcion que crea la tabla
                CreateTables(conexion, cmd, databaseName, serverName);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la base de datos");
            }
        }
        // Funcion que crea la base de datos
        public static void CreateDB(SqlConnection conexion, SqlCommand cmd, string databaseName)
        {
            // Query que crea la base de datos
            string query = "CREATE DATABASE " + databaseName;
            // Se guarda el comando
    	    cmd = new SqlCommand(query, conexion);
	        try 
	        {
                // Verifica si la conexion esta abierta
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open(); // Si esta cerrada, abre la conexion
                // Ejecuta el query
			    cmd.ExecuteNonQuery();
			    MessageBox.Show("Se creó la base de datos...", "Escuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
	        }
	        catch (Exception ex)
	        {	
                MessageBox.Show(ex.ToString(), "Escuela", MessageBoxButtons.OK, MessageBoxIcon.Information);	
            }
	        finally
	        {
                // Cierra la conexion
			    if (conexion.State == ConnectionState.Open)
				    conexion.Close();
	        }
	    }

        public static void CreateUser(SqlConnection conexion, SqlCommand cmd, string serverName, string databaseName)
        {
            string log = "pepe"; // Alias
            string usr = "pepe"; // Nombre del usuario
            string pass = "hola123.,"; // Contraseña
            // Se crea el login a la base de datos
            string login = "CREATE LOGIN " + log + " WITH PASSWORD = '" + pass +"'";
            // Se crea el usuario para el login
            string user = "CREATE USER " + usr + " FOR LOGIN " + log ;
            // Cierra la conexio si se encuentra abierta
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            // Se genera la cadena con la especificaciones de la coneccion a la base de datos
            conexion.ConnectionString = "Data Source=" + serverName + ";Integrated security=SSPI;Initial Catalog=" + databaseName;
            try
            {
                // Abre la conexion a la base de datos
                conexion.Open();
                // Ejecuta el query que crea el login
                cmd = new SqlCommand(login, conexion);
                cmd.ExecuteNonQuery();
                // Ejecuta el query que crea al usuario
                cmd = new SqlCommand(user, conexion);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ha creado satisfactoriamente el inicio de sesión.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear login", "Escuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.ToString(), "Escuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                // Cierra la conexion si se encuentra abierta
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
        // Crea la tabla
        public static void CreateTables(SqlConnection conexion, SqlCommand cmd, string databaseName, string serverName)
        {
            // Se genera la cadena con la especificaciones de la coneccion a la base de datos
            string conString = @"Data Source=" + serverName + ";Initial Catalog=" + databaseName + ";Integrated Security=SSPI";
            string sql;

            // Ciera la conexion, si esta abierta
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            conexion.ConnectionString = conString;
            // Query que crea la base de datos
            sql = "CREATE TABLE alumnos (id INT NOT NULL PRIMARY KEY," +
                "nombre VARCHAR(20) NOT NULL, ap_paterno VARCHAR(20) NOT NULL, ap_materno VARCHAR(20) NOT NULL," +
                "cal_examen REAL NOT NULL, cal_proyecto REAL NOT NULL, tareas INT NOT NULL, grupo INT NOT NULL)";
            // Abre la conexion
            conexion.Open();
            cmd = new SqlCommand(sql, conexion);
            try
            {
                // Nombres de los alumnos
                string[] nom = {"JOSE", "JUAN", "LUIS", "CARLOS", "LULU", "MARIA", "LAURA", "OLIVIA", 
                    "ALAN", "ALEJANDRA", "SARAHI", "LUZ", "ALEJANDRO", "ANTONIO", "ABIGAIL" };
                // Apellidos de los alumnos
                string[] ape = {"SANCHEZ", "LOPEZ", "GARCIA", "JUAREZ", "TORRES", "MARQUEZ", "SALAZAR", "DOMINGUEZ", 
                    "JIMENEZ", "MARTINEZ", "SANTIAGO", "GUERRERO", "REYES", "AVILES", "SOLIS" };
                // Contador, sera el id del alumno
                int contador = 1000;
                // Variables
                int i1, i2, i3, examen, proyecto, tareas, grupo;
                Random rnum = new Random();
                // Ejecuta el query con la creacion de la tabla
                cmd.ExecuteNonQuery();
                // Ciclo con el que se insertan los registros en la tabla
                for(int i = 0; i < 30; i++)
                {
                    i1 = rnum.Next(nom.Length); // Iterador 1
                    i2 = rnum.Next(ape.Length); // Iterador 2
                    i3 = rnum.Next(ape.Length); // Iterador 3
                    examen = rnum.Next(11); // Calificacion del examen
                    proyecto = rnum.Next(6, 11); // Calificacion del proyecto
                    tareas = rnum.Next(5); // Numero de tareas
                    grupo = rnum.Next(1, 3); // Grupo 1 o 2
                    // Se genera el query que realiza los inserts
                    sql = "INSERT INTO alumnos(id, nombre, ap_paterno, ap_materno, cal_examen, cal_proyecto, tareas, grupo) " +
                    "VALUES (" + contador + ", '" + nom[i1] + "', '" + ape[i2] + "', '" + ape[i3] +"', " +
                    "'"+ examen + "', '" + proyecto + "', '" + tareas + "', '"+ grupo +"') ";
                    // Guarda ek query
                    cmd = new SqlCommand(sql, conexion);
                    contador++;
                    // Ejecuta el query
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Escuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
    }
}

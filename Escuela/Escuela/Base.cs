using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;		//Ojo. Es necesario para realizar las conexiones.


namespace Escuela
{
    public static class Base
    {
        
        //Nombre de la base de datos

        public static void Main()
        {
            //Acá pongo como debería de ser llamado sobre la función principal del programa
            CreateDB();
            CreateTables();
        }

        public static void CreateDB()
        {
            private String databaseName = "Escuela";        //Nombre de la base de datos
            private String databaseLocation = "C:\\" + databaseName;    //Sin extensión

            String createQuery;
            SqlConnection conexion = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");
            //Crea un nuevo objeto de SQL para realizar la conexión al localhost

            createQuery = "CREATE DATABASE " + databaseName + " ON PRIMARY " +
                            "(NAME = " + databaseName + "_Data, " +                 //Creamos el archivo Escuela_Data
                            "FILENAME = '" + databaseLocation + ".mdf', " +         //En la ubicación C:\\Escuela.mdf
                            "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                            "LOG ON (NAME = " + databaseName + "_Log, " +           //Creamos el archivo Escuela_Log
                            "FILENAME = '" + databaseLocation + ".ldf', " +         //En la ubicación C:\\Escuela.ldf
                            "SIZE = 1MB, " +
                            "MAXSIZE = 5MB, " +
                            "FILEGROWTH = 10%)";

            SqlCommand query = new SqlCommand(createQuery, conexion);
            try
            {
                conexion.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Se creó la base de datos...", "Escuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Muestra mensaje al invocar el método en un Form
            }
            catch (System.Exception ex)     //Atrapamos la excepción
            {
                MessageBox.Show(ex.ToString(), "Escuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally         //Cerrammos el canal de comunicación de estar abierto pase lo que pase
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        public static void CreateTables()
        {

            String databaseName = "Escuela";

            //Nos concectamos a la instancia local del servidor SQL
            Server srv;
            srv = new Server();

            //Entramos a la base de datos que creamos
            Database db;
            db = srv.Databases[databaseName];


            //########## Tabla Grupos ##########
            //Definimos un objeto de tipo tabla para usar su constructor donde le mandamos la instancia de la base de datos y el nombre de la tabla
            Table tb_Grupos;
            tb_Grupos = new Table(db, "Grupos");

            //Añadimos columnas a la tabla

            //---------- Columna GrupoID ----------
            Column gpID;
            gpID = new Column(tb_Grupos, "GrupoID", DataType.Int);
            gpID.Identity = true;
            gpID.IdentitySeed = 1;
            gpID.IdentityIncrement = 1;
            tb_Grupos.Columns.Add(gpID);
            //Creamos una columna con un valor entero serial que incrementa en uno y que se usará como llave principal


            //---------- Columna NombreGrupo ----------
            Column gpName;
            gpName = new Column(tb_Grupos, "Nombre", DataType.NChar(25));
            gpName.Collation = "Latin1_General_CI_AS";
            gpName.Nullable = false;
            tb_Grupos.Columns.Add(gpName);
            //Creamos una columna con un valor de tipo caracter que acepta caracteres del teclado latinoamericano

            //---------- Columna Cupo ----------
            Column gpCupo;
            gpCupo = new Column(tb_Grupos, "Cupo", DataType.Int);
            gpCupo.Nullable = true;
            tb_Grupos.Columns.Add(gpCupo);


            //Creamos la tabla anterior en el servidor
            tb_Grupos.Create();


            //########## Tabla Materias ##########
            Table tb_Materias;
            tb_Materias = new Table(db, "Grupos");

            //---------- Columna MateriaID ----------
            Column matID;
            matID = new Column(tb_Materias, "MateriaID", DataType.Int);
            matID.Identity = true;
            matID.IdentitySeed = 1;
            matID.IdentityIncrement = 1;
            tb_Materias.Columns.Add(matID);

            //---------- Columna NombreGrupo ----------
            Column matName;
            matName = new Column(tb_Materias, "Nombre", DataType.NChar(25));
            matName.Collation = "Latin1_General_CI_AS";
            matName.Nullable = false;
            tb_Materias.Columns.Add(matName);


            //Creamos la tabla anterior en el servidor
            tb_Materias.Create();


            //########## Tabla Alumnos ##########
            Table tb_Alumnos;
            tb_Alumnos = new Table(db, "Grupos");

            //Añadimos columnas a la tabla
            //---------- Columna GrupoID ----------
            Column aluID;
            aluID = new Column(tb_Alumnos, "AlumnoID", DataType.Int);
            aluID.Identity = true;
            aluID.IdentitySeed = 1;
            aluID.IdentityIncrement = 1;
            tb_Alumnos.Columns.Add(aluID);

            //---------- Columna NombreAlumno ----------
            Column aluName;
            aluName = new Column(tb_Alumnos, "Nombre", DataType.NChar(25));
            aluName.Collation = "Latin1_General_CI_AS";
            aluName.Nullable = false;
            tb_Alumnos.Columns.Add(aluName);

            //---------- Columna ApPatAlumno ----------
            Column aluPat;
            aluPat = new Column(tb_Alumnos, "Apellido Paterno", DataType.NChar(25));
            aluPat.Collation = "Latin1_General_CI_AS";
            aluPat.Nullable = false;
            tb_Alumnos.Columns.Add(aluPat);

            //---------- Columna ApMatAlumno ----------
            Column aluMat;
            aluMat = new Column(tb_Alumnos, "Apellido Materno", DataType.NChar(25));
            aluMat.Collation = "Latin1_General_CI_AS";
            aluMat.Nullable = true;
            tb_Alumnos.Columns.Add(aluMat);

            //---------- Columna FechaAlta ----------
            Column aluAlta;
            aluAlta = new Column(tb_Alumnos, "Fecha de alta", DataType.DateTime);
            aluAlta.Nullable = false;
            tb_Alumnos.Columns.Add(aluAlta);

            //Creamos la tabla anterior en el servidor
            tb_Alumnos.Create();

            /*
            //################# Metodos adicionales #################
            //Para usar la fecha como valor en una columna
            Column nombreColumna;
            nombreColumna = new Column(tb_Grupos, "Fecha", DataType.DateTime);   
            nombreColumna.Nullable = false;   
            tb_Grupos.Columns.Add(nombreColumna);
            //Si queremos añadir otra columna
            Column nombreColumna;   
            nombreColumna = new Column(tb, "nombreColumna", DataType.DateTime);   
            nombreColumna.Nullable = false;   
            tb.Columns.Add(nombreColumna);   
            //Usamos el método alter sobre el objeto tb
            tb.Alter();   
            //Si queremos eliminar la tabla
            tb.Drop();
            */
        }
    }
}

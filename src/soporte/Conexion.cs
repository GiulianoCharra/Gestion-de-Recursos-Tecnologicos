using System;
using System.Data;
using System.Data.SqlClient;

public class Conexion
{
	//private SqlConnection con;

	public Conexion()
	{

	}


    public static SqlConnection Conectar()
    {
		//string url = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
		string url = "data source=chongopc\\sqlexpress;initial catalog=\"gestión de recursos tecnológicos\";integrated security=true";
		SqlConnection con = new SqlConnection(url);
		con.Open();
		return con;
    }

    public static void Cerrar(SqlConnection con)
    {
        con.Close();
    }

	public static DataTable EjecutarComando(string consulta)
    {
		//Llama al metodo conectar para abrir la coneccion con la base de datos
		SqlConnection conexion = Conectar();
		SqlCommand command = new SqlCommand();

		return EjecutarComando(command, consulta);
	}

	public static DataTable EjecutarComando(SqlCommand command, string consulta)
	{
		//Llama al metodo conectar para abrir la coneccion con la base de datos
		SqlConnection conexion = Conectar();

		command.CommandType = CommandType.Text;
		command.CommandText = consulta;
		command.Connection = conexion;

		DataTable resultados = new DataTable();

		Console.WriteLine(command.CommandText);
		SqlDataAdapter adapter = new SqlDataAdapter(command);
		adapter.Fill(resultados);

		//Cierra la conexion con la base de datos abierta
		Cerrar(conexion);
		return resultados;
	}




}

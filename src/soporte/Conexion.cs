using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public abstract class Conexion
{

    public Conexion()
	{

	}


    public static SqlConnection Conectar()
    {
		//string url = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
		string url = "data source=chongopc\\sqlexpress;initial catalog=\"gestión de recursos tecnológicos\";integrated security=true";
		SqlConnection con = new SqlConnection(url);
		con = new SqlConnection(url);
		con.Open();
		return con;
    }

    public static void cerrar(SqlConnection con)
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


	/// <summary>
	/// Ejecuta una query en la base de datos con ciertos parametros
	/// </summary>
	/// <param name="parametros">Los parametros que se requieren para la ejecucion de la consulta </param>
	/// <param name="consulta"></param>
	/// <returns></returns>
	public static DataTable EjecutarComando(Dictionary<string, object> parametros, string consulta)
	{
		SqlConnection conexion = Conectar();
		SqlCommand command = new SqlCommand();

        foreach (var item in parametros)
        {
			command.Parameters.AddWithValue(item.Key, item.Value);
        }

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
		SqlDataAdapter adapter = new SqlDataAdapter(command);
		adapter.Fill(resultados);

		//Cierra la conexion con la base de datos abierta
		cerrar(conexion);
		return resultados;
	}

	/// <summary>
	/// Agrega una serie de parametros que seran cargados
	/// cuando se ejecute el comando en la base de datos
	/// </summary>
	public static SqlCommand agregarParametro(string parametro, Object valor)
    {
		return agregarParametro(new SqlCommand(), parametro, valor);
    }

	public static SqlCommand agregarParametro(SqlCommand comando, string parametro, Object valor)
	{
		comando.Parameters.AddWithValue(parametro, valor);
		return comando;
	}

	public static SqlCommand agregarParametro(Dictionary<string, object> dict)
	{
		SqlCommand comando = new SqlCommand();

		foreach (var item in dict)
        {
			comando.Parameters.AddWithValue(item.Key, item.Value);
        }
		return comando;
	}
}

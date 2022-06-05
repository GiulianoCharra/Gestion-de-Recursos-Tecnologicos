using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public abstract class Conexion
{
	private static SqlConnection conexion { get; set; }
    private static SqlCommand comando = new SqlCommand();
    public static SqlCommand Comando { get => comando; set => comando = value; }


    public Conexion()
	{

	}

    public static void Conectar()
    {
		//string url = System.Configuration.ConfigurationManager.AppSettings["GestionRTDB"];
		string url = "data source=chongopc\\sqlexpress;initial catalog=\"gestión de recursos tecnológicos\";integrated security=true";
		//SqlConnection con = new SqlConnection(url);
		conexion = new SqlConnection(url);
		conexion.Open();
		//return conexion;
    }
    public static void cerrar()
    {
        conexion.Close();
    }

	/// <summary>
	/// Ejecuta una query en la base de datos con ciertos parametros
	/// </summary>
	/// <param name="parametros">Los parametros que se requieren para la ejecucion de la consulta </param>
	/// <param name="consulta"></param>
	/// <returns></returns>
	public static DataTable EjecutarComando(Dictionary<string, object> parametros, string consulta)
	{
		comando.Parameters.Clear();
        foreach (var item in parametros)
        {
			agregarParametro(item.Key, item.Value);
        }

		return EjecutarComando(consulta);
	}
	public static DataTable EjecutarComando(string consulta)
	{
		//Llama al metodo conectar para abrir la coneccion con la base de datos
		Conectar();
		comando.CommandType = CommandType.Text;
		comando.CommandText = consulta;
		comando.Connection = conexion;

		DataTable resultados = new DataTable();
		SqlDataAdapter adapter = new SqlDataAdapter(comando);
		adapter.Fill(resultados);

		//Cierra la conexion
		cerrar();
		return resultados;
	}

	/// <summary>
	/// Agrega una serie de parametros que seran cargados
	/// cuando se ejecute el comando en la base de datos
	/// </summary>
	public static void agregarParametro(Dictionary<string, object> dict)
	{
		foreach (var item in dict)
        {
			agregarParametro(item.Key, item.Value);
        }
	}
	public static void agregarParametro(string parametro, Object valor)
    {
		comando.Parameters.AddWithValue(parametro, valor);
    }
}

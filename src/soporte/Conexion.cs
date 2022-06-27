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
		string url = "Data Source=CHONGOPC\\SQLEXPRESS;Initial Catalog=Gestión de Recursos Tecnológicos;Integrated Security=True";
		//string url = "Data Source=utnfrc63162.database.windows.net;Initial Catalog=\"Gestion Recursos Tecnologicos\";Persist Security Info=True;User ID=giuliano;Password=djbgme5coD1";
		//SqlConnection con = new SqlConnection(url);
		conexion = new SqlConnection(url);
		conexion.Open();
		//return conexion;
    }
    public static void cerrar()
    {
        conexion.Close();
    }
    internal static void limpiarParametros()
    {
		comando.Parameters.Clear();
    }

	/// <summary>
	/// Ejecuta una query en la base de datos con ciertos parametros
	/// </summary>
	/// <param name="parametros">Los parametros que se requieren para la ejecucion de la consulta </param>
	/// <param name="consulta"></param>
	/// <returns></returns>
	public static DataTable EjecutarComando(Dictionary<string, object> parametros, string consulta)
	{
		limpiarParametros();
		agregarParametros(parametros);
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

    public static int EjecutarInsercion(string consulta)
	{
		//Llama al metodo conectar para abrir la coneccion con la base de datos
		Conectar();
		comando.CommandType = CommandType.Text;
		comando.CommandText = consulta;
		comando.Connection = conexion;

		int id = Convert.ToInt32(comando.ExecuteScalar());

		//Cierra la conexion
		cerrar();
		return id;
	}
	public static int EjecutarInsercion(Dictionary<string, object> parametros, string consulta)
	{
		limpiarParametros();
		agregarParametros(parametros);
		return EjecutarInsercion(consulta);
	}

	/// <summary>
	/// Agrega una serie de parametros que seran cargados
	/// cuando se ejecute el comando en la base de datos
	/// </summary>
	public static void agregarParametros(Dictionary<string, object> dict)
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

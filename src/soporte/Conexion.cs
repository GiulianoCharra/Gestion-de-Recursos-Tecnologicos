using System;

public class Conexion
{
	public Conexion()
	{
		private string string_Connection;
		private SqlConnection con;
		

		public void conectar()
		{
			this.con = new SqlConnection(string_Connection);
			this.con.open();
		}

	}
}

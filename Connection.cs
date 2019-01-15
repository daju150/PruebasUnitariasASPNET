using System;

public class Class1
{
	public Class1(){
	}

    public SqlConnection Conexion(){
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MT0H5K8\\SQLEXPRESS;Initial Catalog=globaldigital;Integrated Security = True");
        return cn;
    }

}

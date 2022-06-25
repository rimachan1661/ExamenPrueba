using System;

public class avion

{
	private float altura;
	private float velocidad; 
	private float combustible; 
	private int orientación;
	

	public float altura
	{
		get { return altura; }
	}

	public int Orientacion
	{
		get{ return orientación; }
	}

	public float Combustible
	{ 
		get { return combustible; } 
	}

	public avion(float altura, float
	velocidad, float combustible, int o)
	{
		this.altura = altura; 
		this.velocidad = velocidad;
		this.combustible = combustible;
		this.orientación = o;
	}

	
	public void Virar(int grados)
	{
		orientación = (orientación +
			grados) % 360; consumir_fuel(grados * 0.1);
	}

	
	//Metodos que sirve para ascender los metros indicados
	public void a(float metros) 
	{
		altura = altura + metros; consumir_fuel(metros * 0.3);
	}
	//Metodos que sirve para descender los metros indicados
	public void metros(float metros)
	{
		altura = altura - metros;
		if (altura < 0)
			altura = 0;
	}

	private void consumir_fuel(float litros)
	{
		combustible = combustible - litros;
		if (combustible < 0)
			combustible = 0;
	}

}

class Humano
{
    // Properties for Human
    public string Nombre;
    public int Fuerza {get; set;}
    public int Inteligencia {get; set;}
    public int Destreza {get; set;}
    public int Salud {get; set;}

    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Humano(string n)
    {
        Nombre = n;
        Fuerza = 3;
        Inteligencia = 3;
        Destreza = 3;
        Salud = 100;
    }

    // Add a constructor to assign custom values to all fields
    public Humano(string n, int f, int i, int d, int s)
    {
        Nombre = n;
        Fuerza = f;
        Inteligencia = i;
        Destreza = d;
        Salud = s;
    }

    // Build Attack method
    public int Ataque(Humano target)
    {
        int damage = 3 * this.Fuerza;
        target.Salud -= damage;
        return target.Salud;
    }
}
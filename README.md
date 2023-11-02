# Humano

Repositorio publico para el bootcamp de Coding Dojo.
.
<h3>Objetivo:</h3>
    <li>Construir una clase utilizando conceptos de POO en C#.​​​</li>
    <li>Construir campos y métodos dentro de las clases.​​</li>

<h3>Instrucciones</h3>

<p>Crea un nuevo proyecto de consola .NET para esta tarea.​​<p>

<pre>
``` csharp
class Human
{
    // Properties for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
     
    // Add a constructor to assign custom values to all fields
     
    // Build Attack method
    public int Attack(Human target)
    {
    }
}
```
</pre>

<ul>
    <li>Cree una clase Human con cuatro campos públicos: Nombre (string), Fuerza (int), Inteligencia (int), Destreza (int)</li>
    <li>Agregue un método constructor que tome una string para inicializar el Nombre, y que inicializará la Fuerza, la Inteligencia y la Destreza a un valor predeterminado de 3, y la salud al valor predeterminado de 100.</li>
    <li>Creemos un constructor adicional que acepte 5 parámetros, para que podamos establecer valores personalizados para cada campo.</li>
    <li>Ahora agregue un nuevo método llamado Ataque, que cuando se invoca, debería reducir la salud de un objeto Humano que se pasa como parámetro. El daño realizado debe ser 3 * fuerza (3 puntos de daño al atacado, por cada 1 punto de fuerza del atacante). Este método debería devolver el estado restante del objeto de destino.</li>
</ul>

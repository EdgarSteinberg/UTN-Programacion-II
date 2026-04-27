/* Cómo funciona un Set (HashSet) en .NET

Un HashSet<T> mantiene la unicidad usando

👉 GetHashCode() + Equals()

🔹 Para tipos no nativos (clases propias) */

class Persona
{
    public string Nombre { get; set; }
}


/* Equals() por defecto → compara referencia
GetHashCode() por defecto → basado en la referencia */
/* Crear una clase Fruta con variables privadas color, peso, esEstacional.
● Crear setters y getters.
● Escribir una función llamada esComestible() que devuelva verdadero cuando la
fruta pesa menos de 200 gr y es de estación, y falso en cualquier otro caso.
● Definir dos constructores de modo tal que la fruta pueda crearse con los valores
color, peso y estacional al momento de instanciarse, o bien crearse sin valores
iniciales.
 */

class Fruta
{
    private string color = "";
    private float peso = 0;
    private bool esEstacional = false;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public float Peso
    {
        get { return peso; }
        set { peso = value; }
    }

    public bool EsEstacional
    {
        get { return esEstacional; }
        set { esEstacional = value; }
    }

    public bool EsComestible()
    {
        return peso < 200 && esEstacional;
    }

    public Fruta()
    {
    }

    public Fruta(string color, float peso, bool esEstacional)
    {
        this.color = color;
        this.peso = peso;
        this.esEstacional = esEstacional;
    }
}
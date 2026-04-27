/* 🧠 ¿Qué hace static?

👉 Permite usar un miembro sin crear una instancia (objeto).

🔹 Ejemplo simple */
/* ✔️ Uso:
👉 no hay new MathHelper() */

int r = MathHelper.Sumar(2, 3);

class MathHelper
{
    public static int Sumar(int a, int b)
    {
        return a + b;
    }
}



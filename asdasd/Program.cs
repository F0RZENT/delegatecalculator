First first;
first = Plus;
first += Minus;
first(123 , 321);

void Plus(int a, int b) => System.Console.WriteLine($" Плюс:{a + b}");
void Minus(int a, int b) => System.Console.WriteLine($" Минус:{a - b}");

delegate void First(int a, int b);

public class Calculator
{

    public static void Main() {
    Second second;
    second = Plus;
    second += Minus;
    second += Multiply;
    second += Dele;
    second(72, 3);
    void Plus(int a, int b) => System.Console.WriteLine($" Плюс:{a + b}");
    void Multiply(int a, int b) => System.Console.WriteLine($" Умножение:{a * b}");
    void Minus(int a, int b) => System.Console.WriteLine($" Минус:{a - b}");
    void Dele(int a, int b) => System.Console.WriteLine($" Деление:{a / b}");
    }

    delegate void Second(int a, int b);
}

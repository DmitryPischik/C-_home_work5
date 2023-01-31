// Написать программу масштабирования фигуры

void zoom(string input, int a)
{
    string[] parts = input.Split(" ");
    for (int i = 0; i < parts.Length; i++)
    {
        parts[i] = parts[i].Replace("(", "");
        parts[i] = parts[i].Replace(")", "");
        string[] parts2 = parts[i].Split(",");
        int x = int.Parse(parts2[0] ?? "0");
        int y = int.Parse(parts2[1] ?? "0");
        parts[i] = $"({x * a},{y * a})";
    }
    string output = string.Join(" ", parts);
    Console.WriteLine(output);
}

Console.Write("Задавйте вершины фигуры списком например: (0,0) (2,0) (2,2) (0,2): ");
string str = Console.ReadLine();
Console.Write("Задавйте коэффициент масштабирования: ");
int k = int.Parse(Console.ReadLine()?? "0");

zoom(str, k);

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");

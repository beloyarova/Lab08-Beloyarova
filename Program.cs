// using System.Diagnostics;

// int lessonNumber = 1;
// int totalLessons = 5;

// while (lessonNumber <= totalLessons)
// {
//     Console.WriteLine($"Пара {totalLessons}");
//     totalLessons -= 1;
// }

// Console.WriteLine("Пары закончились");

// Console.WriteLine("Вводите оценки по одной, для завершения введите -1: ");
// int grade = int.Parse(Console.ReadLine());
// int score = 0;

// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     score++;
//     grade = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Ввод завершён");
// Console.WriteLine($"Количество оценок: {score}");

// using System.Diagnostics;

// int sum = 0;
// int count = 0;
// int max = 0;

// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1)
// {
//     sum += grade;
//     count++;
//     if (grade > max)
//     {
//         max = grade;
//     }
//     grade = int.Parse(Console.ReadLine());
// }

// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
//     Console.WriteLine($"Наибольшая оценка: {max}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }

// string correctPassword = "qwerty123";
// int fall = 0;

// while (true)
// {
//     Console.WriteLine("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         Console.WriteLine("Доступ разрешен");
//         Console.WriteLine($"Количество неудачных попыток: {fall}");
//         break;
//     }

//     Console.WriteLine("Неверный пароль, попробуте снова");
//     fall++;
// }

// string answer;

// do
// {
//     Console.WriteLine("Введите дату посещения (например, 01.09); ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");

//     Console.Write("Добавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохранен");

// Самостоятельные задания

// Задание А

// using System.Diagnostics;
// using System.Runtime.InteropServices;

// int N = 5;
// int multiplication = 1;

// while (multiplication <= 10)
// {
//     Console.WriteLine($"{N} * {multiplication} = {N * multiplication}");
//     multiplication++;
// }

// // Задача Б

// int count = 0;
// string name;

// Console.WriteLine("Ведите имена участников (введите 'конец' для завершения списка): ");
// name = Console.ReadLine();

// while (name != "конец")
// {
//     count++;
//     name = Console.ReadLine();
// }

// Console.WriteLine($"Количество имён: {count}");

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

//Вариант 5

string correct = "1234";

while (true)
{
    Console.Write("Введите код домофона: ");
    string code = Console.ReadLine();

    if (code == correct)
    {
        Console.WriteLine("Дверь открыта");
        break;
    }

    Console.WriteLine("Дверь закрыта");
}

// Вариант 10

int garde;
int count = 0;

Console.WriteLine("Введите оценки (введите -1 для завершения): ");
garde = int.Parse(Console.ReadLine());

while (garde != -1)
{
    if (garde == 5)
    {
        count++;
    }
    garde = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Количество оценок равным 5: {count}");

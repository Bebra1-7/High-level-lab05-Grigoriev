// Console.WriteLine("Обратный отсчёт");

// int countdown = 5;
// while (countdown >= 1)
// {
//     Console.WriteLine(countdown);
//     countdown--;
// }
// Console.WriteLine("Пуск!");

// Console.WriteLine();
// Console.WriteLine("Сумма чисел от 1 до 10");

// int number = 1;
// int sum = 0;

// while (number <= 10)
// {
//     sum += number;
//     number++;
// }
// Console.WriteLine($"Сумма : {sum}");

// Console.WriteLine("Бесконечный цикл");

// int i = 1;
// while (i <= 5)
// {
//     Console.WriteLine($"Значение i: {i}");
//     i++;
// }

// Console.WriteLine("Валидация ввода через while");

// bool isValid = false;
// int enteredAge = 17;

// while (!isValid)
// {
//     Console.WriteLine("Введите ваш возраст (целое число)");
//     string input = Console.ReadLine();
//     isValid = int.TryParse(input, out enteredAge);

//     if (!isValid) Console.WriteLine("Это не похоже не целое число. Попробуйте ещё раз.");
// }
// Console.WriteLine($"Принято! Ваш возраст: {enteredAge}");

// Console.WriteLine("Меню (без выхода, один проход)");

// string menuChoice;
// do
// {
//     Console.WriteLine("1 - показать дату");
//     Console.WriteLine("2 - показать приветствие");
//     Console.WriteLine("0 - Exit");
//     menuChoice = Console.ReadLine();

//     switch (menuChoice)
//     {
//         case "1": Console.WriteLine($"Сегодня: {DateTime.Now:dd.MM.yyyy}"); break;
//         case "2": Console.WriteLine("Здравствуйте! Рады видеть вас снова."); break;
//         case "0": Console.WriteLine("До свидания!"); break;
//         default: Console.WriteLine("Такого пункта нет, попробуйте снова."); break;
//     }
// } while (menuChoice != "0");

// Console.WriteLine("Прямой счёт");

// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine();
// Console.WriteLine("Обратный счёт");
// for (int i = 5; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine();
// Console.WriteLine("Чётные числа от 0 до 20");
// for (int i = 0; i<= 20; i+= 2)
// {
//     Console.WriteLine(i);
// }

// Console.WriteLine("foreach по строке");

// string word = "Программирование";
// foreach (char letter in word)
// {
//     Console.WriteLine(letter);
// }
// Console.WriteLine();

// Console.WriteLine("Считем гласные");
// string sentence = "Курс алгоритмизации и программирования";
// string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
// int vowelCount = 0;

// foreach (char letter in sentence)
// {
//     if (vowels.Contains(letter)) vowelCount++;
// }
// Console.WriteLine($"Гласных букв в предложении: {vowelCount}");

// Console.WriteLine("Таблица умножения 1-9");

// for (int row = 1; row <= 9; row++)
// {
//     for (int col = 1; col <= 9; col++)
//     {
//         Console.WriteLine($"{row * col,4}");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();
// Console.WriteLine("Треугольник");

// for (int row = 1; row <=5; row++)
// {
//     for (int col = 1; col < row; col++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }
string paragraph;
string offer = " ";
string vowel = "AaEeIiOoUuYy";
string consonant = "BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxYyZz";
string highAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

int countVowel = 0;
int countConsonant = 0;
do
{
    Console.WriteLine("1 - Проанализировать предложение");
    Console.WriteLine("2 - Найти позицию первой заглавной буквы");
    Console.WriteLine("0 - Exit");

    Console.Write("Выберите пункт: ");
    paragraph = Console.ReadLine();
    if (paragraph != "0")
    {
        Console.Write("Введите предложение: ");
        offer = Console.ReadLine();
    }
    switch (paragraph)
    {
        case "1":
            foreach (char letter in offer)
            {
                if (vowel.Contains(letter)) countVowel++;
                else if (consonant.Contains(letter)) countConsonant++;
            }
            Console.WriteLine($"Гласных: {countVowel} \nСогласных: {countConsonant}");
            break;
        case "2":
            for (int i = 0; i < offer.Length; i++)
            {
                Console.WriteLine(i);
                if (char.IsUpper(offer[i])) Console.WriteLine($"Первая заглавная буква: {offer[i]} под индексом {i}"); break;
            }
            break;
        default: break;
    }
} while (paragraph != "0");

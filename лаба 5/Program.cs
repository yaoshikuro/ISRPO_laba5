//void SayHello()
//{
//    Console.WriteLine("Hello");
//}

//void SayHello() => Console.WriteLine("Hello");

//SayHello();

//void Game()
//{
//    string myGame = "GTA V";
//    Console.WriteLine(myGame);
//}

//Game();

//Console.Write("Введите своё имя: ");
//string? name = Console.ReadLine();

//Console.Write("Введите ваш язык (русский, немецкий, английский): ");
//string language = Console.ReadLine().ToLower();

//void SayHelloRu() => Console.WriteLine($"Привет {name}!");
//void SayHelloEn() => Console.WriteLine($"Hello {name}!");
//void SayHelloDe() => Console.WriteLine($"Guten Tag {name}!");

//switch (language)
//{
//    case "английский":
//        SayHelloEn();
//        break;
//    case "русский":
//        SayHelloRu();
//        break;
//    case "немецкий":
//        SayHelloDe();
//        break;
//    default:
//        Console.WriteLine("Язык не найден!");
//        break;
//}

//void Print(string message)
//{
//    Console.WriteLine(message);
//}

//Print(message: "Привет");
//Console.WriteLine("Как тебя зовут?");
//Console.Write("Введите своё имя: ");
//string? name = Console.ReadLine();
//Print(message: $"Твоё имя : {name}");

//void Sum(int x, int y)
//{
//    int result = x + y;
//    Console.WriteLine($"{x} + {y} = {result}");
//}

//Sum(10, 20);

//Console.Write("Введите переменную x: ");
//int x = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите переменную y: ");
//int y = Convert.ToInt32(Console.ReadLine());

//Sum(x, y);

//void PrintPerson(string personName, int age)
//{
//    Console.WriteLine($"Имя: {personName}, возраст: {age}");
//}

//PrintPerson("Владимир", 32);


//void Person(string name, int age = 18, string vuz = "ВолГУ")
//{
//    Console.WriteLine($"Имя: {name} \nВозраст: {age} \nВуз: {vuz}");
//}

//Person(name: "Александр");
//Person(name: "Иван", age: 30);
//Person(name: "Дмитрий", age: 20, vuz: "МГУ");

//Person(age: 30, name: "Иван");
//Person(vuz: "МГУ", age: 20, name: "Дмитрий");

//string GetMessage()
//{
//    return "Hello";
//}

//Console.WriteLine(GetMessage());

//int Sum(int a, int b)
//{
//    return a + b;
//}

//int result = Sum(10, 20);
//Console.WriteLine(result);

//void CheckValue(int number)
//{
//    if (number < 0)
//    {
//        Console.WriteLine("Отрицательное число");
//        return;
//    }
//    Console.WriteLine("Положительное число");
//}

//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//CheckValue(number);

//string GetMessage()
//{
//    return "Hello";
//}

//string message = GetMessage();
//Console.WriteLine(message);

//void PrintMessage(string message)
//{
//    Console.WriteLine(message);
//}

//PrintMessage(GetMessage());

//string GetMessage() => "hello";
//int Sum(int x, int y) => x + y;

//string GetHello()
//{
//    return "Hello";
//    Console.WriteLine("After return");
//}

//void PrintPerson(string name, int age)
//{
//    if (age > 120 || age < 1)
//    {
//        Console.WriteLine("Недопустимый возраст");
//        return;
//    }
//    Console.WriteLine($"Имя: {name} Возраст: {age}");
//}

//PrintPerson(name: "Алексей", age: 32);
//PrintPerson(name: "Dunkan", age: 1234);

//Random random = new Random();
//int randomNumber = random.Next(0, 100);
//Console.WriteLine($"Случайное число: {randomNumber}");

//double randomDouble = random.NextDouble();
//Console.WriteLine($"Случайное число с плавающей точкой: {randomDouble}");

//void ShowWelcomeMessage() => Console.WriteLine("Добро пожаловать в консольный прогноз погоды!");

//void ShowGoodbyeMessage() => Console.WriteLine("Спасибо за использование нашего прогноза! Хорошего дня!");

//string GetWeather()
//{
//    string[] weathers = ["Солнечно", "Облачно", "Дождь", "Снег", "Гроза"];
//    Random random = new Random();
//    int index = random.Next(weathers.Length);
//    return weathers[index];
//}

//ShowWelcomeMessage();
//string currentWeather = GetWeather();
//Console.WriteLine($"Погода на сегодня: {currentWeather}");
//ShowGoodbyeMessage();

//int Factorial(int n)
//{
//    if (n == 1) return 1;
//    return n * Factorial(n - 1);
//}

//int factorial4 = Factorial(4);
//int factorial5 = Factorial(5);
//int factorial6 = Factorial(6);

//Console.WriteLine($"Факториал числа 4 = {factorial4}");
//Console.WriteLine($"Факториал числа 5 = {factorial5}");
//Console.WriteLine($"Факториал числа 6 = {factorial6}");

//void Compare(int[] numbers1, int[] numbers2)
//{
//    int numbers1Sum = Sum(numbers1);
//    int numbers2Sum = Sum(numbers2);

//    if (numbers1Sum > numbers2Sum)
//        Console.WriteLine("сумма чисел из массива numbers1 больше");
//    else if (numbers1Sum < numbers2Sum)
//        Console.WriteLine("сумма чисел из массива numbers2 больше");
//    else
//        Console.WriteLine("суммы чисел обоих массивов равны");

//    int Sum(int[] numbers)
//    {
//        int result = 0;
//        foreach (int number in numbers)
//            result += number;
//        return result;
//    }
//}

//int[] numbers1 = [1, 2, 3];
//int[] numbers2 = [3, 4, 5, 6, 7];
//Compare(numbers1, numbers2);
//int Sum(int[] numbers)
//{
//    int limit = 0;
//    int result = 0;

//    static bool IsPassed(int number, int lim)
//    {
//        return number > lim;
//    }

//    foreach (int number in numbers)
//    {
//        if (IsPassed(number, lim: limit))
//            result += number;
//    }

//    return result;
//}
//int[] numbers1 = [-3, -2, -1, 0, 1, 2, 3];
//int[] numbers2 = [3, -4, 5, -6, 7];
//Console.WriteLine(Sum(numbers1));
//Console.WriteLine(Sum(numbers2));

//zadanie 1
//test
//    1: Ничего
//    2: void ShowWelcomeMessage()
//    3: Метод вызовет ошибку компиляции
//    4: void PrintNumber(int number)
//    5: PrintMessage('Hello, World!')

//zadanie 2
//void GreetUser()
//{
//    Console.Write("Ввежите ваше имя: ");
//    string yu = Console.ReadLine();
//    Console.WriteLine($"Привет, {yu} ! Добро пожаловать в программу!");
//} 
//GreetUser();

//zadanie 3
//void AddNumber()
//{
//Console.Write("Введите первое число: ");
//int vvod1 = Convert.ToInt32(Console.ReadLine());
//    Console.Write("Введите второе число: ");
//    int vvod2 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine($"Сумма равна: {vvod1 + vvod2}");
//}
//AddNumber();

//zadanie 4
//void IsEven()
//{
//    Console.Write("Введите число: ");
//    int vvod = Convert.ToInt32(Console.ReadLine());
//    if (vvod %2 == 0)
//    {
//        Console.WriteLine("true");
//    } else
//    {
//        Console.WriteLine("false"); 
//    }
//}
//IsEven();

//zadanie 5
//void FindMax()
//{
//    List<int> list = new List<int>() { };
//    Console.Write("Введите длину массива: ");
//    int vvod = Convert.ToInt32(Console.ReadLine());
//    for (int i = 0; i < vvod;  i++)
//    {
//        Console.Write("Введите число: ");
//        int vvod1 = Convert.ToInt32(Console.ReadLine());
//        list.Add(vvod1);
//    }
//    int n = 0;
//    for (int i =0; i < list.Count; i++)
//    {
//        if (n < list[i])
//        {
//            n = list[i];
//        }
//    }
//    Console.WriteLine(n);
//}
//FindMax();

//zadanie 6
//void ConvertCelsiusToFahrenheit()
//{
//    Console.Write("Введите градусы цельсия: ");
//    int cels = Convert.ToInt32(Console.ReadLine());
//    int ff = cels * 9 / 5 + 32;
//    Console.WriteLine($"Fahrenheit: {ff}");
//}
//ConvertCelsiusToFahrenheit();

//zadanie 7
//void CountVowels()
//{
//    Console.WriteLine("введите текст");
//    string gl = Console.ReadLine();
//    int n = 0;
//    for (int i = 0; i < gl.Length; i++)
//    {
//        if (gl[i] == 'a' || gl[i] == 'e' || gl[i] == 'i' || gl[i] == 'o' || gl[i] == 'u')
//        {
//            n++; 
//        }
//    }
//    Console.WriteLine(n);
//}
//CountVowels();

//zadanie 8
//void GeneratePassword()
//{

//}

//zadanie 9
void IsPalindrome()
{

}
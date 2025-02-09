using System;
using System.Linq;

class Program {
  static void Main()
  {
    // 1. Что такое LINQ?
    
    // LINQ (Language Integrated Query) — это инструмент в .NET, который позволяет легко работать с
    // коллекциями данных (например, списками или массивами) с помощью запросов, похожих на SQL.
    // С его помощью можно фильтровать, сортировать и преобразовывать данные.
    
    // 2. Что делают указанные методы расширения LINQ?
    
    int[] nums = {1,2,3,4};
    var squares = nums.Select(n => n*n); // Преобразование
    Console.WriteLine(string.Join(", ", squares));
    var evenNums = nums.Where(n => n%2==0); // Фильтрует
    Console.WriteLine(string.Join(", ", evenNums));
    var sortedNums = nums.OrderBy(n => n); // Сортирует по возрастанию
    Console.WriteLine(string.Join(", ", sortedNums));
    
    var items = new[] {
    new { Name = "apple", Category = "fruit" },
    new { Name = "carrot", Category = "vegetable" },
    new { Name = "banana", Category = "fruit" }
    };
    var sortedItems = items.OrderBy(i => i.Name).ThenBy(i => i.Category); // Дополнительная сортировка
    Console.WriteLine(string.Join(", ", sortedItems));
    
    var people = new[] {
    new { ID = 1, Name = "Alice" },
    new { ID = 2, Name = "Bob" }
    };
    var jobs = new[] {
        new { ID = 1, Job = "Engineer" },
        new { ID = 2, Job = "Designer" }
    };
    var result = people.Join(jobs, p => p.ID, j => j.ID, (p, j) => new {p.Name, j.Job}); // Объединяет две коллекции по общему ключу.
    Console.WriteLine(string.Join(", ", result));
    
    var reversedNums = nums.Reverse(); // Переворачивает порядок элементов.
    Console.WriteLine(string.Join(", ", reversedNums));
    
    var hasEven = nums.Any(n => n%2==0); // Проверяет, есть ли элементы, удовлетворяющие условию
    Console.WriteLine(hasEven);

    // 3. Что такое лямбда-функция?
    
    // Лямбда-функция — это короткая анонимная функция, которая определяется с помощью =>.
    Func<int, int> square = x => x * x;
    int squareResult = square(5); // result = 25
    
    // 4. Пример лямбда-функции:

    Func<int,int,int> sumNums = (x,y) => x+y;
    int sumNumsResult = sumNums(50,50);
    Console.WriteLine(sumNumsResult);
    
    // 5. Операции с двумя последовательностями
    
    int[] array1 = { 1, 2, 3 };
    int[] array2 = { 2, 3, 4 };
    var exceptResult = array1.Except(array2); // Возвращает элементы, которые есть в первой коллекции, но нет во второй
    Console.WriteLine(string.Join(", ", exceptResult));
    
    var intersectResult = array1.Intersect(array2); // Возвращает общие элементы
    Console.WriteLine(string.Join(", ", intersectResult));
    
    var unionResult = array1.Union(array2); // Объединяет коллекции, удаляя дубликаты.
    Console.WriteLine(string.Join(", ", unionResult));

    var concatResult = array1.Concat(array2); // Объединяет коллекции без удаления дубликатов.
    Console.WriteLine(string.Join(", ", concatResult));
    
    int[] numbers = { 1, 2, 3 };
    string[] words = { "one", "two", "three" };
    var zipResult = numbers.Zip(words, (n,w) => n + "-" + w); // Объединяет две коллекции попарно.
    Console.WriteLine(string.Join(", ", zipResult));
  }
}

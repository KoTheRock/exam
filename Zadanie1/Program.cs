public class Program
{
    static void Main()
    {
        string[] strings = {"Телевизор", "Холодильник","Рак", "Стол", "Привет", "Ком", "Чек"};
        string[] array = new string[strings.Length];
        int index = 0;

        foreach (string word in strings)
        {
            if (word.Length <= 3)
            {
                array[index] = word;
                index++;
            }
        }

        string result = string.Join(" ", array, 0, index);
        {
            Console.WriteLine("Массив строк равный либо меньше 3: " + result);
        }
        
    }
}
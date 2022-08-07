Console.Clear();
string[] inputArray = new string[]
{"one","two","three", "four", "1","3","2", "job"};

int elemCount = 0;  // Блок который считает количество нужных элементов для инициализации нового массива
for (int i = 0; i < inputArray.Length; i++)
    if (inputArray[i].Length <= 3) elemCount++;

string[] outArr = new string[elemCount];  //Этот блок отвечает за запись элемента массива в новый массив удовлетворя требованиям
int index = 0;
for (int i = 0; i < inputArray.Length; i++)
    if (inputArray[i].Length <= 3)
    {
        outArr[index] = inputArray[i];
        index++;
    }

void PrintArray(string[] array) // Метод который печатает массив в консоль
{

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
System.Console.WriteLine("Заданный массив");
PrintArray(inputArray);
System.Console.WriteLine();
System.Console.WriteLine("Массив который получился");
PrintArray(outArr);
Console.ReadKey();
Console.Clear();
string[] inputArray = new string[]
{"one","two","three", "four", "1","3","2", "job"};
int elemCount = 0;
for (int i = 0; i < inputArray.Length; i++)
    if (inputArray[i].Length <= 3) elemCount++;


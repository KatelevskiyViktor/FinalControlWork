
//first
// string[] stringsArray = new string[]{"hello", "2", "world", ":-)"}; 
// string[] stringsArray2 = new string[]{"1234", "1567", "-2", "comp sci"}; 
// string[] stringsArray3 = new string[]{"Russia", "Denmark", "Kazan"}; 


// string[] stringsArrayAfter = new string[4];
// string[] stringsArrayAfter2 = new string[4];
// string[] stringsArrayAfter3 = new string[3];

// void PrintIntArray(string[] array)
// {
//     Console.Write("Новый массив: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] != null)Console.Write(array[i]  + ", ");
        
//     }
//     Console.WriteLine();
// }   

// for (int i = 0; i < stringsArray.Length; i++)
// {
//     if(stringsArray[i].Length < 4)stringsArrayAfter[i] = stringsArray[i];
//     if(stringsArray2[i].Length < 4)stringsArrayAfter2[i] = stringsArray2[i];
//     if(i < 3){
//         if(stringsArray3[i].Length < 4)stringsArrayAfter3[i] = stringsArray3[i];  
//     }
    
// }

// PrintIntArray(stringsArrayAfter);
// PrintIntArray(stringsArrayAfter2);
// PrintIntArray(stringsArrayAfter3);
//endfirst


//second
List<string> allStrings = new List<string>();
List<string> smallStrings = new List<string>();
void PrintIntArray(List<string> array, string nameArray="Массив: ")
{
    Console.Write(nameArray);
    for (int i = 0; i < array.Count; i++)
    {
        if(array[i] != null)Console.Write(array[i]  + ", ");
        
    }
    Console.WriteLine();
}   

while(true){
    Console.Write("Enter strings or q to exit and score: ");
    string value = Console.ReadLine();
    if(value == "q")break;
    if(value.Length < 4)smallStrings.Add(value);
    allStrings.Add(value);
}

PrintIntArray(allStrings, "All strings: ");
PrintIntArray(smallStrings, "Strings length less 4 char: ");


//endsecond
// Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий новый массив, 
// каждый элемент которого равен разности элементов двух входящих массивов в той же ячейке. Если длины массивов 
// не равны, необходимо как-то оповестить пользователя.
// Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий новый массив, 
// каждый элемент которого равен частному элементов двух входящих массивов в той же ячейке. Если длины массивов 
// не равны, необходимо как-то оповестить пользователя. Важно: При выполнении метода единственное исключение, 
// которое пользователь может увидеть - RuntimeException, т.е. ваше.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11); // [-10; 10]
}


int[] CheckLength(int[] array1, int[] array2)
{
    int[] result=new int[array1.Length];
    if (array1.Length != array2.Length)
        return null;

    for (int i = 0; i < array1.Length; i++)
    {
        result[i]=array1[i]-array2[i];
    }
    return result;
}

double[] MasQuotient(int[] array1, int[] array2){
    double[] result=new double[array1.Length];
    // if (array1.Length != array2.Length){
    //     throw new SystemException("Длины массивов не совпадают");
    // }

    try{
        if (array1.Length != array2.Length)
            throw new SystemException("Длины массивов не совпадают");
        for (int i = 0; i < array1.Length; i++){
            result[i]=array1[i]/array2[i];
        }
        return result;
    }
    catch (DivideByZeroException) {
        Console.WriteLine("Делить на нуль нельзя!");
        return result; // возврат из блока catch
    }
    // catch (SystemException){
    //     Console.WriteLine("Длины массивов не совпадают");
    //     return result;
    // }
    
}

Console.Clear();
Console.Write("Введите кол-во элементо массива1: ");
int n = int.Parse(Console.ReadLine()!);
int[] array1 = new int[n];
Console.Write("Введите кол-во элементо массива2: ");
int m = int.Parse(Console.ReadLine()!);
int[] array2 = new int[m];

InputArray(array1);
InputArray(array2);

Console.WriteLine($"mas1 = [{string.Join(", ", array1)}]");
Console.WriteLine($"mas2 = [{string.Join(", ", array2)}]");

int[] result1 = CheckLength(array1, array2);
if (result1 == null)
    Console.WriteLine("Длины массивов не совпадают");
else Console.WriteLine($"[{string.Join(", ", result1)}]");
Console.WriteLine("---------------------");
double[] result2 = MasQuotient(array1, array2);
Console.WriteLine($"[{string.Join(", ", result2)}]");
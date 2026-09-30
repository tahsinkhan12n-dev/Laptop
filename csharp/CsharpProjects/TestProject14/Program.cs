/*
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int   : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long  : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");

Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort :{ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");

Console.WriteLine("Floting point types:");
Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue}");
Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue}");
Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue}");

int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");


int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");


decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

string name = "bad";
int num = 0;
if (int.TryParse(name, out num))
    Console.WriteLine($"Int: {num}");
else
    Console.WriteLine("Unable to convert");
if (num > 0)
    Console.WriteLine($"num, (w/ offset): {50 + num}");

*/
/*
using System.Security.Principal;

string[] values = {"12.4", "45", "ABC", "11", "DEF"};
string message = "";
decimal total = 0m;
for (int i = 0; i < values.Length; i++)
{
    decimal num;
    if (decimal.TryParse(values[i], out num))
        total += num;
    else
        message += values[i];
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
*/

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;
int result = Convert.ToInt32(value1 / value2);
Console.WriteLine($"value1 / value2 = {result}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"value2 / value3 = {result2}");

float result3 = value3 / value1;
Console.WriteLine($"value3 / value1 = {result3}");

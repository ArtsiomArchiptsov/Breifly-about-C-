/* Создать целочисленные и вещественные переменные. Вычислить их сумму, произведение, частное. Результат вывести на экран.
*/

/* Если типы данных операндов совпадают, то и тип данных результата операций с этими операндами будет совпадать.
*/


int num1 = 5;
int num2 = 9;
int sum = num1 + num2;
Console.WriteLine(sum);

Console.WriteLine("-----");

/* Если используются значения с разными типами данных, то результату присваивается значение типа данных с большим диапазоном значений
*/

long num3 = 4;
long sum2 = num3 + num2;
Console.WriteLine(sum2);

Console.WriteLine("-----");

double num4 = 5.5;
double sum3 = num4 + num1;
Console.WriteLine(sum3);

Console.WriteLine("-----");

// Умножение 

int multiplic = num1 * num2;
long multiplic2 = num1 * num3;
double multiplic3 = num1 * num4;
Console.WriteLine(multiplic);
Console.WriteLine("-----");
Console.WriteLine(multiplic2);
Console.WriteLine("-----");
Console.WriteLine(multiplic3);
Console.WriteLine("-----");

/*Деление.
При делении операндов тип данных которых int, ответ будет только целочисленным. Однако, при делении в ответе возможно и дробное значение. Следовательно принимается тип данных double.
*/

int qoutient = num1 / num2;
Console.WriteLine(qoutient);
Console.WriteLine("-----");
double qoutient2 = num1 / num4;
Console.WriteLine(qoutient2);


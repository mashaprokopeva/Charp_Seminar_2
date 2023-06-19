//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели (1-7): ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
bool isWeekend = false;
switch (dayOfWeek)
{
case 6: // Суббота
case 7: // Воскресенье
isWeekend = true;
   break;
            default:
if (dayOfWeek >= 8 || dayOfWeek <=0){
    Console.WriteLine("Вы вышли за предел дней недели (1-7), повторите попытку");
    return;
}
break;
}
if (isWeekend)
{
Console.WriteLine("Этот день является выходным.");
}
else
{
Console.WriteLine("Этот день не является выходным.");
}

﻿/* Классической демонстрацией использования циклов в цикле я предлагаю рассмотреть задачу
вывода таблицы умножения на экран. Итак, идея следующая. 
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($”{ i}
        * { j} = { i* j}”);
}
Console.WriteLine();
}
/* У нас есть цикл for, он очень легко строится. Дальше, мы указываем начальное значение.
Таблица умножения начинается с 2. Затем говорим, что пока счётчик i меньше или равен 10,
надо его увеличивать. После возьмём второй цикл, обратите внимание, что в первом
(внешнем) цикле использовался счётчик i, значит, внутренний будет j, который мы также
будем менять. Например, от 2 до меньше или равен 10. А телом второго цикла мы укажем
непосредственное произведение. Сделать это можно различными способами. Я использую
интерполяцию строк. 
Console.WriteLine($”{ i}
* { j} = { i* j}”)
/*    Посмотрим, что у нас из этого получится. Ожидаем увидеть, что-то похожее на таблицу
умножения. Действительно. 2*2=4, 2*3=6 и так далее. Вроде бы всё ок.
Но есть проблема, связанная с тем, что вся таблица идёт без разделений на части. Чтобы это
исправить после того, как отработает второй цикл, в нашем случае: 
for (int j = 2; j <= 10; j++)
{
    Console.WriteLine($”{ i}
    { j} = { i* j}”);
}
/* Делаем переход на новую строку. 
Console.WriteLine();
/*  То есть, выполняется вывод умножения на отдельное число, потом искусственный разрыв
строк и вывод умножения на новое число. Так получается более красиво. Отдельно умножение
на 2, 3, 4 и так далее. */

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}

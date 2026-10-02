// int totalExercises = 8;

// for (int number = totalExercises; number >= 1; number--)
// {
//     Console.WriteLine($"Упражнение {number}");
// }
// Console.WriteLine("Домашнее задание готово");

// //2
// for (int room = 5; room <= 50; room += 5) {
//     Console.WriteLine($"Кабинет {room}");
// }


// // 3
// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// {
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("^_^");
// }      


//4
int count = 0;
for (int ticket = 1; ticket <= 30; ticket++)
{
    if (ticket == 4 || ticket == 12 || ticket == 19)
    {
        count++;
        continue; //билет уже вытянут
    }
    Console.WriteLine($"Пропущенные билеты: {count}");
    Console.WriteLine($"Первый доступный билет: {ticket}");
    break;
}
Console.Write("Введите первый и второй катеты");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = Math.Sqrt((a * a) + (b * b));
Console.WriteLine("Периметр треугольника равен: {0}", c);
//задание 1.37, найти периметр треугольника по его катетам

// задание 2.21


Console.WriteLine("Введите число n  ");
int n = int.Parse(Console.ReadLine());

int x = n % 10 + n / 100 * 10 + n % 100 / 10 * 100;


Console.WriteLine(x);

// Задание 2.41
double m1, hour, minutes = 0;
Console.WriteLine("Введите угол в радианах :");
double alp = Convert.ToDouble(Console.ReadLine()); //ввод угла от 0 до 2*PI
alp = 180 / Math.PI; // перевод в градусы
hour = alp / 30.0; // целых часов, 30 градусов = 1 час
minutes = (alp - hour * 30) * 2;  // целых минут, 30 градусов = 60 минут
m1 = minutes * 6;  // угол одной минуты для часовой стрелки = 6 градусам
Console.WriteLine("Houer " + hour);
Console.WriteLine("Minutes = " + minutes);
Console.WriteLine("Min len =" + m1);

// Задание 4.107 

Console.WriteLine("Введите номер месяца");
int mounthN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите год");
int year = Convert.ToInt32(Console.ReadLine());

switch (mounthN)
{
    case 1: Console.Write("\nЯнварь - 31 день"); break;
    case 2:
        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            Console.Write("\nФевраль - 29 дней");
        }
        else
        {
            Console.Write("\nФевраль - 28 дней");
        }
        break;
    case 3: Console.Write("\nМарт - 31 день"); break;
    case 4: Console.Write("\nАпрель - 30 дней"); break;
    case 5: Console.Write("\nМай - 31 день"); break;
    case 6: Console.Write("\nИюнь - 30 дней"); break;
    case 7: Console.Write("\nИюль - 31 день"); break;
    case 8: Console.Write("\nАвгуст - 31 день"); break;
    case 9: Console.Write("\nСентябрь - 30 дней"); break;
    case 10: Console.Write("\nОктябрь - 31 день"); break;
    case 11: Console.Write("\nНоябрь - 30 дней"); break;
    case 12: Console.Write("\nДекабрь - 31 день"); break;
}


//Задание 4.110

Console.WriteLine("Введите номер масти карты (1-пик, 2-крести, 3-бубен, 4-червь ");
int cardNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер достоинства карты");
int cardDignity = Convert.ToInt32(Console.ReadLine());

switch (cardDignity)
{
    case 6:
        Console.Write("Шестерка");
        break;
    case 7:
        Console.Write("Семерка");
        break;
    case 8:
        Console.Write("Восьмерка");
        break;
    case 9:
        Console.Write("Девятка");
        break;
    case 10:
        Console.Write("Десятка");
        break;
    case 11:
        Console.Write("Валет");
        break;
    case 12:
        Console.Write("Дама");
        break;
    case 13:
        Console.Write("Король");
        break;
    case 14:
        Console.Write("Туз");
        break;
}
switch (cardNumber)
{
    case 1:
        Console.Write("\n пик");
        break;
    case 2:
        Console.Write("\n крести");
        break;
    case 3:
        Console.Write("\n бубен");
        break;
    case 4:
        Console.Write("\n червей");
        break;
}
// Задание 4.114

Console.Write("Введите год: ");
int yearY = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер месяца: ");
int mounth = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите день: ");
int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Дата предыдущего дня: {day - 1}.{mounth}.{yearY}");
Console.WriteLine($"Дата следующего дня: {day + 1}.{mounth}.{yearY}");

if (yearY % 4 == 0 && (yearY % 100 != 0 || yearY % 400 == 0))
{
    Console.WriteLine("Год високосный");
}
else
{
    Console.WriteLine("Год не високосный");
}

//7.111.Известны стоимости(в долларах) нескольких марок легковых автомобилей и мотоциклов.
//Верно ли, что средняя стоимость автомобилей превышает сред-нюю стоимость мотоциклов более чем в 3 раза?
//Стоимость одного автомо-биля превышает $5000, что больше стоимости любой марки мотоцикла.
int[] kar = new int[255];
int[] moto = new int[255];
double k = 0;
double o = 0;
int p, i;


Console.WriteLine("Введите количество Машин и Мотоциклов: ");
p = Convert.ToInt32(Console.ReadLine());
for (i = 1; i <= p; i++)
{
    Console.WriteLine("Введите стоимость " + i + "й" + " машины: " +
        "");
    kar[i] = Convert.ToInt32(Console.ReadLine());
}
for (i = 1; i <= p; i++)
{
    Console.WriteLine("Введите стоимость " + i + "" + " мотоцикла: ");
    moto[i] = Convert.ToInt32(Console.ReadLine());
}
for (i = 1; i < p; i++)
{
    o = o + kar[i];
    k =k + moto[i];
}
o = o / p;
k = k / n;
if ((a / 3) > k)
{
    Console.WriteLine("Верно!");
}
else
{
    Console.WriteLine("Не верно!");

}

//В соревнованиях по фигурному катанию спортсмены выступают в трех видах многоборья
//(обязательная, короткая и произвольная программы). Известны результаты (в баллах) каждого из
//15 участников соревнований (рис. 8.4). Организовать ввод информации по этой таблице и определить среднее количество баллов,
//полученных по каждому виду программы.
Random rand = new Random();
int[] obligatory = new int[15];// обязательная
int[] shortly = new int[15];// короткая

int[] arbitary = new int[15];// произвольная
Console.WriteLine($"{"Спортсмен",15} {"Обязательная",15} {"Короткая",15} {"Произвольная",15}");
for (int j = 0; j < 15; j++)// вывод д
{
    obligatory[j] = rand.Next(20);
    shortly[j] = rand.Next(20);
    arbitary[j] = rand.Next(20);
    Console.WriteLine($"{j + 1,15}{obligatory[j],15}{shortly[j],15}{arbitary[j],15}");
}
Console.WriteLine();

double averageObligatory = 0;// среднее значение по каждой программе
double averageShortly = 0;
double averageArbitary = 0;
for (int h = 0; h < 15; h++)
{

    averageObligatory += Convert.ToDouble(obligatory[h]);
    averageShortly += Convert.ToDouble(shortly[h]);
    averageArbitary += Convert.ToDouble(arbitary[h]);
}
averageObligatory = averageObligatory / 15;
averageShortly = averageShortly / 15;
averageArbitary = averageArbitary / 15;


Console.WriteLine("Среднее количество очков по обязательному виду программы - " + averageObligatory);
Console.WriteLine("Среднее количество очков по короткому виду программы - " + averageShortly);
Console.WriteLine("Среднее количество очков по произвольному виду программы - " + averageArbitary);

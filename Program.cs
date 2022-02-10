//
// Домашнее задание к занятию 19. LINQ
//
// Задача 1. Модель  компьютера  характеризуется
// кодом  и
// названием  марки компьютера,
// типом  процессора,
// частотой  работы  процессора,
// объемом оперативной памяти,
// объемом жесткого диска,
// объемом памяти видеокарты,
// стоимостью компьютера в условных единицах
// и количеством экземпляров, имеющихся в наличии.
// Создать список, содержащий 6-10 записей с различным набором значений характеристик.

//Определить:
//-все компьютеры с указанным процессором. Название процессора запросить у пользователя;
//-все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
//-вывести весь список, отсортированный по увеличению стоимости;
//-вывести весь список, сгруппированный по типу процессора;
//-найти самый дорогой и самый бюджетный компьютер;
//-есть ли хотя бы один компьютер в количестве не менее 30 штук?


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DZ19;



List<Сomputer> comps = new List<Сomputer>()
{
    new Сomputer(){Code = "001", Name ="Apple" , Cpu = "Intel", Freq = 3.2, Ram =8, Hdd = 2, Video=1, Price=2300, Quant=9 },
    new Сomputer(){Code = "002", Name ="Lenovo" , Cpu = "AMD", Freq = 3.5, Ram =4, Hdd = 4, Video=4, Price=1900, Quant=24 },
    new Сomputer(){Code = "002A", Name ="MSI" , Cpu = "Intel", Freq = 4, Ram =8, Hdd = 4, Video=6, Price=1750, Quant=12 },
    new Сomputer(){Code = "002F", Name ="Acer" , Cpu = "AMD", Freq = 4, Ram =4, Hdd = 2, Video=2, Price=1100, Quant=4 },
    new Сomputer(){Code = "003", Name ="ASUS" , Cpu = "Intel", Freq = 3.5, Ram =2, Hdd = 1, Video=1, Price=1150, Quant=52 },
    new Сomputer(){Code = "004", Name ="HP" , Cpu = "Intel", Freq = 3.2, Ram =4, Hdd = 2, Video=2, Price=950, Quant=27 },
    new Сomputer(){Code = "004-1", Name ="DELL" , Cpu = "AMD", Freq = 3.2, Ram =8, Hdd = 2, Video=1, Price=1650, Quant=31 },
    new Сomputer(){Code = "005", Name ="ASUS" , Cpu = "AMD", Freq = 3.5, Ram =8, Hdd = 1, Video=2, Price=1020, Quant=14 },
    new Сomputer(){Code = "006", Name =" MSI" , Cpu = "Intel", Freq = 3, Ram =2, Hdd = 2, Video=1, Price=870, Quant=8 },
    new Сomputer(){Code = "006-S", Name ="Acer" , Cpu = "AMD", Freq = 3.5, Ram =4, Hdd = 1, Video=1, Price=950, Quant=6 }
};


Console.WriteLine("Введите тип процессора (Intel или AMD): ");

string cpu = Console.ReadLine();

List<Computer> compsCpu = comps
                .Where(c => c.Cpu == cpu)
                .ToList();
Console.WriteLine();

//List<Computer> compsCPU = comps.Where(predicate: x => x.Cpu == cpu).ToList();

//List<Computer> compsCPU = comps.Where(a => a.Cpu == cpu).ToList();
//List<Computer> compsCPU = (List<Computer>)comps.Where(a => a.Cpu == cpu).ToList();

Print(compsCPU);

Console.ReadKey();




static void Print (List<Computer> comps)
{ 
        foreach(Computer c in comps)
    {
        Console.WriteLine($"{ c.GetHashCode} { c.Name} { c.Cpu} { c.Freq} { c.Ram} { c.Hdd} { c.Video} { c.Pice}");
    }
    Console.WriteLine();
}






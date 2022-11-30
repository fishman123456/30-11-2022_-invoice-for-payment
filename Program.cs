// разработать класс Счет для оплаты, в классе предусмотреть следующие поля
// 1) оплата за день,
// 2) ко-во дней,
// 3) штраф за один день задержки оплаты,
// 4) кол-во дней задержки оплаты,
// 5) сумма к оплате без штрафа (вычисляемое поле),
// 6) штраф (вычисляемое поле),
// 7) общая сумма к оплате (вычисляемое поле).

// В классе обьявить статическое 
// свойство типа bool, значение которого влияет на процесс формирования обьектов
// этого класса. Если значение этого свойства равно true, тогда сериализуются и
// десириализуются все поля, если false - вычисляемые поля не сериализуются.
// Разработать приложение, в котором необходимо продемонстрировать
// использование этого класса, результаты должны записываться и считыватся из файла.


using System.Runtime.Serialization.Formatters.Binary;
using System;
using static System.Console;

invoice h = new invoice(3,2,3,3);
Console.WriteLine(h.ToString());

BinaryFormatter binFormat =
new BinaryFormatter();
try
{
    using (Stream fStream =
    File.Create("test.bin"))
    {
        binFormat.Serialize(fStream, h);
    }
    WriteLine("BinarySerialize OK!\n");
    invoice p = null;
    using (Stream fStream =
    File.OpenRead("test.bin"))
    {
        p = (invoice)binFormat.
        Deserialize(fStream);
    }
    WriteLine(p);
}
catch (Exception ex)
{
    WriteLine(ex);
}
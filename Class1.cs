
[Serializable]
public class invoice
{
    public int _pay_day { get; set; } // TODO оплата за день
    public int _quantity { get; set; } // TODO кол - во дней
    public int _fine { get; set; } // TODO штраф за один день задержки оплаты
    public int _f_pay_day { get; set; } // TODO кол-во дней задержки оплаты
    public int q_pay_day { get; set; }  // TODO сумма к оплате без штрафа (вычисляемое поле)
    public int f_f_pay_day { get; set; }    // TODO штраф (вычисляемое поле),
    public int summ_pay { get; set; } // TODO общая сумма к оплате (вычисляемое поле).
    static bool property { get; set; }
   public  invoice() { }


  public invoice (int pay_day, int qantity, int fine, int f_pay_day)
    {
        _pay_day = pay_day;
        _quantity = qantity;
        _fine = fine;
        _f_pay_day = f_pay_day;
        q_pay_day = qantity * pay_day;         // сумма к оплате без штрафа (вычисляемое поле)
        f_f_pay_day = pay_day * fine;         //штраф (вычисляемое поле),
        summ_pay = q_pay_day + f_f_pay_day;  // общая сумма к оплате(вычисляемое поле).
    }

    public override string ToString()
    {
        return $" Оплата за день: {_pay_day}, кол-во дней {_quantity}," +
            $" сумма к оплате без штрафа {q_pay_day}, общая сумма {summ_pay}";
    }
}

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
using System;

public class CoffeeMachine
{
    public int Water { get; private set; }
    public int Coffee { get; private set; }
    public int Milk { get; private set; }
    public int Sugar { get; private set; }

    public CoffeeMachine(int water, int coffee, int milk, int sugar)
    {
        Water = water;
        Coffee = coffee;
        Milk = milk;
        Sugar = sugar;
    }

    public string MakeLatte(int amount)
    {
        if (Water >= 200 * amount && Coffee >= 15 * amount && Milk >= 150 * amount && Sugar >= 10 * amount)
        {
            Water -= 200 * amount;
            Coffee -= 15 * amount;
            Milk -= 150 * amount;
            Sugar -= 10 * amount;
            return $"ทำลาเต้ {amount} ถ้วยสำเร็จ!";
        }
        return "ส่วนผสมไม่เพียงพอ";
    }

    public string MakeBlackCoffee(int amount)
    {
        if (Water >= 250 * amount && Coffee >= 20 * amount)
        {
            Water -= 250 * amount;
            Coffee -= 20 * amount;
            return $"ทำกาแฟดำ {amount} ถ้วยสำเร็จ!";
        }
        return "ส่วนผสมไม่เพียงพอ";
    }

    public string PlainWater(int amount)
    {
        if (Water >= 250 * amount)
        {
            Water -= 250 * amount;
            return $"น้ำเปล่า {amount} แก้วสำเร็จ!";
        }
        return "น้ำเปล่าไม่เพียงพอ";
    }

    public string PlainMilk(int amount)
    {
        if (Milk >= 150 * amount)
        {
            Milk -= 150 * amount;
            return $"นม {amount} แก้วสำเร็จ";
        }
        return "นมไม่เพียงพอ";
    }

    public string ShowStock()
    {
        return $"น้ำ: {Water} ml, กาแฟ: {Coffee} g, นม: {Milk} ml, น้ำตาล: {Sugar} g";
    }

    public string IncreaseStock()
    {
        Water += 1000;
        Coffee += 1000;
        Milk += 1000;
        Sugar += 1000;

        return "เติมสต็อกเรียบร้อยแล้ว";
    }
}
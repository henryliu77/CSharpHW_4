using System;

public class PhoneList
{
    // 成員變數：住家電話、公司電話和手機電話
    public string HomePhone { get; set; }
    public string BusinessPhone { get; set; }
    public string CellPhone { get; set; }

    // 建構函式
    public PhoneList(string homePhone, string businessPhone, string cellPhone)
    {
        HomePhone = homePhone;
        BusinessPhone = businessPhone;
        CellPhone = cellPhone;
    }

    public override string ToString()
    {
        return $"住家: {HomePhone}, 公司: {BusinessPhone}, 手機: {CellPhone}";
    }
}

public class Cards
{
    // 成員變數：姓名、職業、年齡、電話（參考 PhoneList 類別）、電子郵件
    public string Name { get; set; }
    public string Occupation { get; set; }
    public int Age { get; set; }
    public PhoneList Phone { get; set; }
    public string Email { get; set; }

    // 建構函式
    public Cards(string name, string occupation, int age, PhoneList phone, string email)
    {
        Name = name;
        Occupation = occupation;
        Age = age;
        Phone = phone;
        Email = email;
    }

    // GetCard 方法：取得名片資料
    public string GetCard()
    {
        return $"姓名: {Name}\n職業: {Occupation}\n年齡: {Age}\n電話: {Phone}\n電子郵件: {Email}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 建立 PhoneList 實例
        PhoneList phoneList = new PhoneList("02-12345678", "03-98765432", "0912-345678");

        // 建立 Cards 實例
        Cards myCard = new Cards("Henry", "工程師", 30, phoneList, "henry@example.com");

        // 顯示名片資料
        Console.WriteLine(myCard.GetCard());
        Console.ReadKey();
    }
}

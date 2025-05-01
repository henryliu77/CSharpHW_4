using System;

public class Box
{
    // 屬性
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    // 建構函式
    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    // 計算體積的方法
    public double CalculateVolume()
    {
        return Length * Width * Height;
    }

    // 計算表面積的方法
    public double CalculateSurfaceArea()
    {
        return 2 * (Length * Width + Length * Height + Width * Height);
    }

    // 顯示盒子的資訊
    public void DisplayBoxInfo()
    {
        Console.WriteLine($"盒子資訊：");
        Console.WriteLine($"長度: {Length}, 寬度: {Width}, 高度: {Height}");
        Console.WriteLine($"體積: {CalculateVolume()}");
        Console.WriteLine($"表面積: {CalculateSurfaceArea()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 建立 Box 物件
        Box myBox = new Box(10, 5, 8);

        // 顯示盒子的資訊
        myBox.DisplayBoxInfo();
        Console.ReadKey();
    }
}

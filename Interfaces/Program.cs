using System;
interface IOne
{
    public void MethodOne();
}
interface ITwoe
{
    public void MethodTwo();
}
interface IThree
{
    public void MethodThree();
}
interface IFour
{
    public void MethodFour();
}
abstract class ClassOne : IThree
{
 public void MethodThree()
    {
        Console.WriteLine(" Good Morning");
    }
}
class ClassTwo : ClassOne, IFour
{
    public void MethodFour()
    {
        Console.WriteLine(" Everyone ");
    }
}
class MainClass
{
    static void Main()
    {
        ClassTwo classTwo = new ClassTwo();
        classTwo.MethodThree();
        classTwo.MethodFour();





    }
}

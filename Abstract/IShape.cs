namespace OOP_Tasks_Day1.Abstract
{
    public interface IShape
    {
        double Length { get; set; }
        double AreaVar { get; set; }
        double CalculateArea();
    }
}
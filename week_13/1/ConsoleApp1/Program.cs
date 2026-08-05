using System;
using static System.Net.Mime.MediaTypeNames;
namespace Demo
{
     public abstract class SatelliteImage
    {
        public int Id { get; }
        public double CloudCover { get; }
        public SatelliteImage(int id , double cloudCover)
        {
            Id = id;
            CloudCover = IsValid.Validate(cloudCover);
        }
        public abstract string SensorName { get; }
        public abstract int BasePriority { get; }

        public int Score() => BasePriority - (int)CloudCover;
     }

    public static class IsValid
    {
        public static double Validate(double cloudCover)
        {
            if (cloudCover < 0 || cloudCover > 100)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(cloudCover), cloudCover,
                    "CloudCover must be between 0 and 100.");
            }
            return cloudCover;
        }
    }
    public class SarImage: SatelliteImage
    { 
        public SarImage(int id,double cloudCover )
            :base(id,cloudCover) { }
        public override string SensorName => "SAR";
        public override int BasePriority => 100;
    }
    public class ImageFormatter
    {
        public static string Format(SatelliteImage image)
        {
            return $"Image {image.Id}: {(int)image.CloudCover}% cloud [{image.SensorName}]";
        }
    }
    public class Repository<T> where T : SatelliteImage
    {
        private List<T> _items = new();

        public void Add(T item) => _items.Add(item);
        public IReadOnlyList<T> Items => _items;

        public int TotalScore() => _items.Sum(image => image.Score());
    }
    class program
    {
        static void Main()
        {
            var repo = new Repository<SatelliteImage>();

            repo.Add(new SarImage(7, 148));
            //repo.Add(new EoImage(8, 35));
            //repo.Add(new IrImage(9, 10));
            foreach (var image in repo.Items)
            {
                Console.WriteLine(ImageFormatter.Format(image));
                Console.WriteLine(image.Score());
            }
        }
    }
}
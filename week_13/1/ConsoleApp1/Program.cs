using System;
using static System.Net.Mime.MediaTypeNames;
namespace Demo
{ 
enum Sensor
    {
    EO,
    SAR,
    IR
};

    class ImageMetadataManager
    {
        public int Id;
        public double CloudCover;
        public Sensor sensor1;

        public ImageMetadataManager(int id, double cloudCover, Sensor sensor)
        {
            Id = id;
            CloudCover = cloudCover;
            sensor1 = sensor;
        }


        public bool IsValid()
        {
            if (CloudCover > 100 || CloudCover < 0)
                return false;
            return true;
        }
        public string Format()
        {
            return $"ImageId: {Id} | CloudCover: {CloudCover}% | Sensor: {sensor1
                }";
        }
        public void SaveToFile(string path)
        {
            if (! File.Exists(path))
            {
                File.Create(path);
                File.WriteAllText(path, Format());
            }
            if (File.ReadAllText(path).Length > 0)
            {
                File.AppendAllText(path, Format());
            }
            else
            {
                File.WriteAllText(path, Format());
            }

        }
        public int Score()
        {
            switch (sensor1)
            {
                case Sensor.SAR:
                    return 100 - (int)CloudCover;
                case Sensor.EO:
                    return 60 - (int)CloudCover;
                case Sensor.IR:
                    return 40 - -(int)CloudCover;
                default:
                    return 0;   
            }
        }

    }
}
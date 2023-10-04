
using System.ComponentModel;

namespace DXF
{
    public class Part
    {
        [DisplayName("Наименование детали")]
        public string Name { get; set; }
        /// <summary>
        /// Площадь развертки DXF
        /// </summary>
        [DisplayName("Площадь развертки детали,м^2")]
        public double Area { get; set; }
        /// <summary>
        /// Толщина,мм
        /// </summary>
        [DisplayName("Толщина,мм")]
        public double Thikness { get; set; }
        [DisplayName("Материал")]
        public string Material { get; set; }
        [Browsable(false)]
        public string Path { get; set; }

        public Part(string path)
        {
            Path = path;
            Name = System.IO.Path.GetFileName(path);
        }

    }
}

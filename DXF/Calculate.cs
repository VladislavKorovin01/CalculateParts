
using netDxf.Entities;
using netDxf;

namespace DXF
{
    public class Calculate
    {

        /// <summary>
        /// Расчёт площади развертки DXF в м^2
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public double GetAreaPart(string path)
        {
            DxfDocument doc = DxfDocument.Load(path);
            double Xmax = 0;
            double Ymax = 0;
            double Xmin = 0;
            double Ymin = 0;

            foreach (EntityObject ent in doc.Entities.All.ToList())
            {
                if (ent is Polyline2D)
                {
                    foreach (Polyline2DVertex vert in ((Polyline2D)ent).Vertexes.ToList())
                    {
                        //Console.WriteLine($"X: {vert.Position.X} Y: {vert.Position.Y}");
                        Xmax = Math.Round(GetMax(Xmax, vert.Position.X), 2);
                        Xmin = Math.Round(GetMin(Xmin, vert.Position.X), 2);
                        Ymax = Math.Round(GetMax(Ymax, vert.Position.Y), 2);
                        Ymin = Math.Round(GetMin(Ymin, vert.Position.Y), 2);
                    }
                }
                else if (ent is Line)
                {
                    Xmax = Math.Round(GetMax(Xmax, ((Line)ent).StartPoint.X), 2);
                    Xmin = Math.Round(GetMax(Xmin, ((Line)ent).StartPoint.X), 2);
                    Ymax = Math.Round(GetMax(Ymax, ((Line)ent).StartPoint.Y), 2);
                    Ymin = Math.Round(GetMax(Ymin, ((Line)ent).StartPoint.Y), 2);
                }
                else if (ent is Circle)
                {
                    double CXmax = ((Circle)ent).Center.X + ((Circle)ent).Radius;
                    double CXmin = ((Circle)ent).Center.X - ((Circle)ent).Radius;
                    double CYmax = ((Circle)ent).Center.Y + ((Circle)ent).Radius;
                    double CYmin = ((Circle)ent).Center.Y - ((Circle)ent).Radius;

                    Xmax = Math.Round(GetMax(Xmax, CXmax), 2);
                    Xmin = Math.Round(GetMin(Xmin, CXmin), 2);
                    Ymax = Math.Round(GetMax(Ymax, CYmax), 2);
                    Ymin = Math.Round(GetMax(Ymin, CYmin), 2);
                }
            }
            //Console.WriteLine($"Xmax: {Xmax} Ymax: {Ymax} \n Xmin: {Xmin} Ymin: {Ymin}");
            double area = Math.Round(((Xmax + Xmin) * (Ymax + Ymin))/1000000, 6);
            return area;
        }

        public List<Part> GetAreaParts(string[] paths)
        {
            var parts = new List<Part>();

            foreach (var path in paths)
            {
                var area = GetAreaPart(path);
                parts.Add(new Part(path) {Area = area });
            }
            return parts;
        }

        private double GetMax(double item1, double item2)
        {
            if (item1 > item2)
                return item1;
            return item2;
        }

        private double GetMin(double item1, double item2)
        {
            if (item1 > item2)
                return item2;
            return item1;
        }
    }
}


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
            
            List<double> CooX = new List<double>();
            List<double> CooY = new List<double>();


            foreach (EntityObject ent in doc.Entities.All.ToList())
            {
                if (ent is Polyline2D)
                {
                    foreach (Polyline2DVertex vert in ((Polyline2D)ent).Vertexes.ToList())
                    {
                        CooX.Add(vert.Position.X);
                        CooY.Add(vert.Position.Y);
                    }
                }
                else if (ent is Line)
                {
                    CooX.Add(((Line)ent).StartPoint.X);
                    CooY.Add(((Line)ent).StartPoint.Y);
                    CooX.Add(((Line)ent).EndPoint.X);
                    CooY.Add(((Line)ent).EndPoint.Y);
                }
                else if (ent is Circle)
                {
                    double CXmax = ((Circle)ent).Center.X + ((Circle)ent).Radius;
                    double CXmin = ((Circle)ent).Center.X - ((Circle)ent).Radius;
                    double CYmax = ((Circle)ent).Center.Y + ((Circle)ent).Radius;
                    double CYmin = ((Circle)ent).Center.Y - ((Circle)ent).Radius;

                    CooX.Add(CXmax);
                    CooY.Add(CYmax);
                    CooX.Add(CXmin);
                    CooY.Add(CYmin);
                }
            }
            double xmax = Math.Abs(CooX.Max());
            double xmin = Math.Abs(CooX.Min());
            double ymax = Math.Abs(CooY.Max());
            double ymin = Math.Abs(CooY.Min());
            double area = Math.Round(((xmax + xmin) * (ymax + ymin))/1000000, 6);
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
    }
}

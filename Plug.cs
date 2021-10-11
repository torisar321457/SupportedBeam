using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace SupportedBeam
{
    class Plug
    {

        private string Material { get; set; }
        private string Name { get; set; }
        public Plug(string material, string name)
        {

            Material = material;
            Name = name;
        }
        public ContourPlate Create(Point[] points)
        {
            ContourPlate contourPlate = new ContourPlate()
            {
                Class = "1",
                Name = Name,
            };
            ContourPoint point4 = new ContourPoint(points[0], null);
            ContourPoint point5 = new ContourPoint(points[1], null);
            ContourPoint point6 = new ContourPoint(points[2], null);
            ContourPoint point7 = new ContourPoint(points[3], null);
            contourPlate.AddContourPoint(point4);
            contourPlate.AddContourPoint(point5);
            contourPlate.AddContourPoint(point6);
            contourPlate.AddContourPoint(point7);
           // contourPlate.PartNumber = new NumberingSeries("Пр", 1);
            contourPlate.AssemblyNumber = new NumberingSeries("Пр", 1);
            contourPlate.Profile.ProfileString = "PL4";
            contourPlate.Material.MaterialString = Material;
            contourPlate.Insert();
            return contourPlate;
        }
    }
}

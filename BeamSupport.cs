using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace SupportedBeam
{
    class BeamSupport
    {

        private string Material { get; set; }
        private string Profile { get; set; }

        public BeamSupport(string material, string profile)
        {
            Material = material;
            Profile = profile;
        }


        public Beam Createbeam(Point point, Point point1)//, string profile)
        {
            Beam beam = new Beam(point, point1);
            beam.Position.Depth = Position.DepthEnum.MIDDLE;
            beam.Name = "Прогон";
            beam.Class = "994";
            beam.Material.MaterialString = Material;
            beam.Profile.ProfileString = Profile;// "PK120X6.0_54157_2010";
            beam.Position.Depth = Position.DepthEnum.FRONT;
            beam.PartNumber = new NumberingSeries("Пр", 1);
            beam.AssemblyNumber = new NumberingSeries("Пр", 1);
            beam.Insert();
            return beam;
        }
    }
}

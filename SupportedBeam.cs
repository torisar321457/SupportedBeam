using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;

namespace SupportedBeam
{

    [Plugin("ПИ_Навес_Прогон")]
    [PluginUserInterface("SupportedBeam.SupportedBeamForm")]
    [PluginCoordinateSystem(PluginBase.CoordinateSystemType.FROM_FIRST_AND_SECOND_POINT)]
    public class SupportedBeam : PluginBase
    {
        private SupportedBeamData Data { get; set; }
        private double Move;
        private string Material;
        private string Profile;
        private string FILTERUSER01;
        private string FILTERUSER02;
        private string FILTERUSER03;
        private string FILTERUSER04;
        private string FILTERUSER05;
        private string FILTERUSER06;
        private string FILTERUSER07;
        private string FILTERUSER08;
        private string FILTERUSER09;
        private string FILTERUSER10;
        private string FILTERUSER11;
        private string FILTERUSER12;
        private string FILTERUSER13;
        private string FILTERUSER14;
        private string FILTERUSER15;
        private string FILTERUSER16;
        private string FILTERUSER17;
        private string FILTERUSER18;
        private string FILTERUSER19;
        private string FILTERUSER20;

        private string LEVEL1;
        private string LEVEL2;
        private string LEVEL3;
        private string LEVEL4;
        private string COMMENT1;
        private string COMMENT2;
        private string COMMENT3;
        private string COMMENT4;
        private string ARM1;
        private string ARM2;
        private string ARM3;
        private string ARM4;
        private string NAME1;
        private string SHORTNAME1;
        private string NUMBER1;
        private string UNITS1;
        private int ARMTYPE;
        private int FROST1;
        private int WATER1;
        private int EVENNESS1;
        private int HIDE1;
        public override List<InputDefinition> DefineInput()
        {
            Picker Picker = new Picker();
            List<InputDefinition> PointList = new List<InputDefinition>();
            Point Point1 = Picker.PickPoint("Выберите точку начала ");
            Point Point2 = Picker.PickPoint("Выберите точку конца");
            InputDefinition Input1 = new InputDefinition(Point1, Point2);
            PointList.Add(Input1);
            return PointList;
        }
        public SupportedBeam(SupportedBeamData data)
        {
            Data = data;
        }


        public void WriteUserProperty(ModelObject part)
        {
            // Для заполнения пользовательских полей  
            part.SetUserProperty("LEVEL1", LEVEL1);
            part.SetUserProperty("LEVEL2", LEVEL2);
            part.SetUserProperty("LEVEL3", LEVEL3);
            part.SetUserProperty("LEVEL4", LEVEL4);
            part.SetUserProperty("COMMENT1", COMMENT1);
            part.SetUserProperty("COMMENT2", COMMENT2);
            part.SetUserProperty("COMMENT3", COMMENT3);
            part.SetUserProperty("COMMENT4", COMMENT4);
            part.SetUserProperty("ARM1", ARM1);
            part.SetUserProperty("ARM2", ARM2);
            part.SetUserProperty("ARM3", ARM3);
            part.SetUserProperty("ARM4", ARM4);
            part.SetUserProperty("ARMTYPE", ARMTYPE);
            part.SetUserProperty("FROST1", FROST1);
            part.SetUserProperty("WATER1", WATER1);
            part.SetUserProperty("EVENNESS1", EVENNESS1);
            part.SetUserProperty("NAME1", NAME1);
            part.SetUserProperty("SHORTNAME1", SHORTNAME1);
            part.SetUserProperty("NUMBER1", NUMBER1);
            part.SetUserProperty("UNITS1", UNITS1);
            part.SetUserProperty("HIDE1", HIDE1);

            part.SetUserProperty("FILTERUSER01", FILTERUSER01);
            part.SetUserProperty("FILTERUSER01", FILTERUSER02);
            part.SetUserProperty("FILTERUSER01", FILTERUSER03);
            part.SetUserProperty("FILTERUSER01", FILTERUSER04);
            part.SetUserProperty("FILTERUSER01", FILTERUSER05);
            part.SetUserProperty("FILTERUSER01", FILTERUSER06);
            part.SetUserProperty("FILTERUSER01", FILTERUSER07);
            part.SetUserProperty("FILTERUSER01", FILTERUSER08);
            part.SetUserProperty("FILTERUSER01", FILTERUSER09);
            part.SetUserProperty("FILTERUSER01", FILTERUSER10);
            part.SetUserProperty("FILTERUSER01", FILTERUSER11);
            part.SetUserProperty("FILTERUSER01", FILTERUSER12);
            part.SetUserProperty("FILTERUSER01", FILTERUSER13);
            part.SetUserProperty("FILTERUSER01", FILTERUSER14);
            part.SetUserProperty("FILTERUSER01", FILTERUSER15);
            part.SetUserProperty("FILTERUSER01", FILTERUSER16);
            part.SetUserProperty("FILTERUSER01", FILTERUSER17);
            part.SetUserProperty("FILTERUSER01", FILTERUSER18);
            part.SetUserProperty("FILTERUSER01", FILTERUSER19);
            part.SetUserProperty("FILTERUSER01", FILTERUSER20);
        }
        private void GetValuesFromDialog()
        {
            Move = Data.Move;
            Material = Data.Material;
            Profile = Data.Profile;

            FILTERUSER01 = Data.FILTERUSER01;
            FILTERUSER02 = Data.FILTERUSER02;
            FILTERUSER03 = Data.FILTERUSER03;
            FILTERUSER04 = Data.FILTERUSER04;
            FILTERUSER05 = Data.FILTERUSER05;
            FILTERUSER06 = Data.FILTERUSER06;
            FILTERUSER07 = Data.FILTERUSER07;
            FILTERUSER08 = Data.FILTERUSER08;
            FILTERUSER09 = Data.FILTERUSER09;
            FILTERUSER10 = Data.FILTERUSER10;
            FILTERUSER11 = Data.FILTERUSER11;
            FILTERUSER12 = Data.FILTERUSER12;
            FILTERUSER13 = Data.FILTERUSER13;
            FILTERUSER14 = Data.FILTERUSER14;
            FILTERUSER15 = Data.FILTERUSER15;
            FILTERUSER16 = Data.FILTERUSER16;
            FILTERUSER17 = Data.FILTERUSER17;
            FILTERUSER18 = Data.FILTERUSER18;
            FILTERUSER19 = Data.FILTERUSER19;
            FILTERUSER20 = Data.FILTERUSER20;

            LEVEL1 = Data.LEVEL1;
            LEVEL2 = Data.LEVEL2;
            LEVEL3 = Data.LEVEL3;
            LEVEL4 = Data.LEVEL4;
            COMMENT1 = Data.COMMENT1;
            COMMENT2 = Data.COMMENT2;
            COMMENT3 = Data.COMMENT3;
            COMMENT4 = Data.COMMENT4;
            ARM1 = Data.ARM1;
            ARM2 = Data.ARM2;
            ARM3 = Data.ARM3;
            ARM4 = Data.ARM4;
            FROST1 = Data.FROST1;
            WATER1 = Data.WATER1;
            EVENNESS1 = Data.EVENNESS1;
            NAME1 = Data.NAME1;
            SHORTNAME1 = Data.SHORTNAME1;
            NUMBER1 = Data.NUMBER1;
            UNITS1 = Data.UNITS1;
            HIDE1 = Data.HIDE1;
            ARMTYPE = Data.ARMTYPE;

        }

        public Point TranslatePoint(Point point, Matrix matrixRotate)
        {
            return matrixRotate.Transform(point);
        }

        public Assembly CreateAssembly(Part fatherPart, List<Part> parts)
        {
            Assembly assembly = fatherPart.GetAssembly();
            assembly.AssemblyNumber = new NumberingSeries("Пр", 1);
            assembly.Name = fatherPart.Name;
            foreach (var item in parts)
            {
                assembly.Add(item);
            }
            assembly.Modify();
            return assembly;
        }

        public override bool Run(List<InputDefinition> Input)
        {

            try
            {
                GetValuesFromDialog();
                ArrayList identifier = (ArrayList)Input[0].GetInput();
                List<Point> points = new List<Point>();
                foreach (var item in identifier)
                {
                    points.Add((Point)item);
                }
                Matrix ToCurrentWP = MatrixFactory.Rotate(Move * Math.PI / 180, new Vector(1, 0, 0));
                List<Part> parts = new List<Part>();
                BeamSupport sbeam = new BeamSupport(Material, Profile);
                Beam beam =  sbeam.Createbeam(points[0], points[1]);
                parts.Add(beam);
                double subsubs = 4;
                Point[] point = new Point[4]
                {
                    new Point(-subsubs / 2, beam.GetSolid().MaximumPoint.Y - subsubs, beam.GetSolid().MaximumPoint.Z - subsubs),
                    new Point(-subsubs / 2, beam.GetSolid().MaximumPoint.Y - subsubs, beam.GetSolid().MinimumPoint.Z + subsubs),
                    new Point(-subsubs / 2, beam.GetSolid().MinimumPoint.Y + subsubs, beam.GetSolid().MinimumPoint.Z + subsubs),
                    new Point(-subsubs / 2, beam.GetSolid().MinimumPoint.Y + subsubs, beam.GetSolid().MaximumPoint.Z - subsubs)
                };
                Plug plug = new Plug(beam.Material.MaterialString, beam.Name);
               parts.Add(plug.Create(point.Select(x=> TranslatePoint(x,ToCurrentWP)).ToArray()));
                Point[] point1 = new Point[4];
                point.CopyTo(point1, 0);
                foreach (var item in point) item.X = points[1].X + subsubs / 2;
                parts.Add(plug.Create(point1.Select(x => TranslatePoint(x, ToCurrentWP)).ToArray()));
                foreach (var item in parts) WriteUserProperty(item);
                beam.Position.RotationOffset = -Move;
                beam.Modify();
                CreateAssembly(beam, parts.Where(x => x.Class != "994").ToList());
                ProEngineering.Metric.MetricForTry("ПИ_Навес_Прогон");
            }
            catch (Exception Ex)
            {
                ProEngineering.Metric.MetricForCatch("ПИ_Навес_Прогон", Ex.Message);
            }
            return true;
        }
    }
}


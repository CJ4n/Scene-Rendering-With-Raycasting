﻿using ObjLoader.Loader.Data;
namespace Filling_Triangular_Mesh
{
    public static class Utils
    {
        public const double Eps = 1e-8;
        public const double Infinity = 1 / Eps;
        public static double DotProduct(Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static double CosBetweenVersors(Vector3 v1, Vector3 v2)
        {

            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }
        public static double Magnitude(Vector3 v)
        {
            return Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
        }
        public static Vector3 Normalize(Vector3 v)
        {
            var magnitude = Magnitude(v);
            return new Vector3(v.X / magnitude, v.Y / magnitude, v.Z / magnitude);
        }

        public static double Slope(PointF p1, PointF p2)
        {
            return Math.Abs(p1.X - p2.X) < Utils.Eps ? Utils.Infinity : (double)(p2.Y - p1.Y) / (double)(p2.X - p1.X);
        }
    }
}


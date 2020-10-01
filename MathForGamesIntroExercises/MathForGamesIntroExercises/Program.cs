using System;

namespace MathForGamesIntroExercises
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BasicQuadratic(7f);
            CheckForRoot(1, 2, 3);
            LinearBlend(1, 2, 3);
            DistanceFormula(1, 2, 3, 4);
            InnerProduct(1, 2, 3, 4, 5, 6);
            PlaneDistance(1, 2, 3, 4, 5, 6, 7);
            CubicBezierCurve(.5f, 2, 3, 4, 5);
        }

        public static float BasicQuadratic(float x)
        {
            float y = 0;
            y = (x * x) + 2 * x - 7;
            return y;
        }
        public static bool CheckForRoot(float a, float b, float c)
        {
            double ans = Math.Sqrt((b * b) - 4 * a * c);
            if (ans >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public static float LinearBlend(float s, float e, float t)
        {
            float blendedSE = 0;
            blendedSE = s + t * (e - s);
            return blendedSE;
        }
        public static double DistanceFormula(float P1X, float P1Y, float P2X, float P2Y)
        {
            double distance = 0;
            float XSub = P2X - P1X;
            float YSub = P2Y - P1Y;
            distance = Math.Sqrt((XSub*XSub)+(YSub*YSub));
            return distance;
        }
        public static float InnerProduct(float PX, float PY, float PZ, float QX, float QY, float QZ)
        {
            float innerProduct = 0;
            innerProduct = PX * QX + PY * QY + PZ * QZ;
            return innerProduct;
        }
        public static float PlaneDistance(float planeA, float planeB, float planeC, float planeD, float OX, float OY, float OZ)
        {
            float distance = 0;
            float top = (planeA * OX + planeB * OY + planeC * OZ + planeD);
            float bottom = (float)Math.Sqrt(planeA * planeA + planeB * planeB + planeC * planeC);
            distance = top / bottom;
            return distance;
        }
        public static float CubicBezierCurve(float t, float P0, float P1, float P2, float P3)
        {
            float curve = 0;
            float oneMinusT = 1 - t;
            curve = (float)Math.Pow(oneMinusT, 3) * P0 + 3 * (float)Math.Pow(oneMinusT, 2) * t * P1 + 3 * oneMinusT * (float)Math.Pow(t, 2) * P2 + (float)Math.Pow(t, 3) * P3;
            return curve;
        }
    }
}

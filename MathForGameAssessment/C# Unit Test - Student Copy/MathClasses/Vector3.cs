using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector3
    {
        public float x, y, z;
        public Vector3(float v1, float v2, float v3)
        {
            x = v1;
            y = v2;
            z = v3;
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }
        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            return new Vector3(
           lhs.x * rhs,
           lhs.y * rhs,
           lhs.z * rhs);
        }
        //returns the magnitude of the vector
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
        //returns the squarded version of the magnitude
        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }
        //finds the distance between two 3d vectors
        public float Distance(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
        }
        //normalizes the vectors values doesn't return them
        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
            this.z /= m;
        }
        //returns a normalised version of the vector
        public Vector3 GetNormalised()
        {
            Vector3 tempVect3 = new Vector3(this.x, this.y, this.z);
            float m = Magnitude();
            tempVect3.x /= m;
            tempVect3.y /= m;
            tempVect3.z /= m;
            return tempVect3;
        }
        //returns the dot prodcut of the vector
        public float Dot(Vector3 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z;
        }
        //Cross product of a 3d vector
        public Vector3 Cross(Vector3 rhs)
        {
            return new Vector3(
           y * rhs.z - z * rhs.y,
           z * rhs.x - x * rhs.z,
           x * rhs.y - y * rhs.x);
        }
        //finds the angle between the vectors
        public float AngleBetween(Vector3 other)
        {
            // normalise the vectors
            Vector3 a = GetNormalised();
            Vector3 b = other.GetNormalised();
            // calculate the dot product
            float d = a.x * b.x + a.y * b.y + a.z * b.z;
            // return the angle between them
            return (float)Math.Acos(d);
        }
    }
}

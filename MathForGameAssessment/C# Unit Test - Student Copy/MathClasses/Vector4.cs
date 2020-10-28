using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
        public float x, y, z, w;
        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        //returns the magnitude if called too much might slow down performance.
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z + w * w);
        }
        //returns the squared magnitude 
        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z + w * w);
        }
        //finds the distance between two vector4s
        public float Distance(Vector4 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            float diffW = w - other.w;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ + diffW * diffW);
        }
        //normalises the vector note that it doesn't return anything
        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
            this.z /= m;
            this.w /= m;
        }
        //returns a normalised version of the vector
        public Vector4 GetNormalised()
        {
            Vector4 tempVect4 = new Vector4(this.x, this.y, this.z, this.w);
            float m = Magnitude();
            tempVect4.x /= m;
            tempVect4.y /= m;
            tempVect4.z /= m;
            tempVect4.w /= m;
            return tempVect4;
        }
        //returns the dot product
        public float Dot(Vector4 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z + w * rhs.w;
        }
        //finds the angle between the vectors
        public float AngleBetween(Vector4 other)
        {
            // normalise the vectors
            Vector4 a = GetNormalised();
            Vector4 b = other.GetNormalised();
            // calculate the dot product
            float d = a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
            // return the angle between them
            return (float)Math.Acos(d);
        }
        //operators for the class +-* no division
        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
           lhs.x + rhs.x,
           lhs.y + rhs.y,
           lhs.z + rhs.z,
           lhs.w + rhs.w);
        }
        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
           lhs.x - rhs.x,
           lhs.y - rhs.y,
           lhs.z - rhs.z,
           lhs.w - rhs.w);
        }
        public static Vector4 operator *(Vector4 lhs, float rhs)
        {
            return new Vector4(
           lhs.x * rhs,
           lhs.y * rhs,
           lhs.z * rhs,
           lhs.w * rhs);
        }
        //cross product
        public Vector4 Cross(Vector4 rhs)
        {
            return new Vector4(
           y * rhs.z - z * rhs.y,
           z * rhs.x - x * rhs.z,
           x * rhs.y - y * rhs.x,
           0);
        }
    }
}

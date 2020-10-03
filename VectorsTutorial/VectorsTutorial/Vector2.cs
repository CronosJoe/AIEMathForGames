using System;
namespace VectorsTutorial
{
    class Vector2
    {
        public float x, y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        //returns the magnitude of the vector
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y);
        }
        //returns the squarded version of the magnitude
        public float MagnitudeSqr()
        {
            return (x * x + y * y);
        }
        //finds the distance between two 2d vectors
        public float Distance(Vector2 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY);
        }
        //normalizes the vectors values doesn't return them
        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
        }
        //returns a normalised version of the vector
        public Vector2 GetNormalised()
        {
            Vector2 tempVect2 = new Vector2(this.x, this.y);
            float m = Magnitude();
            tempVect2.x /= m;
            tempVect2.y /= m;
            return tempVect2;
        }
        //returns the dot product
        public float Dot(Vector2 rhs)
        {
            return x * rhs.x + y * rhs.y;
        }
        //finds right handed perpendicular vector
        Vector2 GetPerpendicularRH()
        {
            return { -y, x };
        }
        //returns the left handed perpendicular vector
        Vector2 GetPerpendicularLH()
        {
            return { y, -x };
        }
        //finds the angle between the vectors
        float AngleBetween(Vector2 other)
        {
            // normalise the vectors
            Vector2 a = GetNormalised();
            Vector2 b = other.GetNormalised();
            // calculate the dot product
            float d = a.x * b.x + a.y * b.y;
            // return the angle between them
            return (float)Math.Acos(d);
        }
    }

    class Vector3
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
        float AngleBetween(Vector3 other)
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
    class Vector4
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
        float AngleBetween(Vector4 other)
        {
            // normalise the vectors
            Vector4 a = GetNormalised();
            Vector4 b = other.GetNormalised();
            // calculate the dot product
            float d = a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
            // return the angle between them
            return (float)Math.Acos(d);
        }
    }
}

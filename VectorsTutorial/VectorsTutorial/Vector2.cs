using System;
namespace VectorsTutorial
{
    class Vector2
    {
        public float x, y; 
    }

    class Vector3
    { 
        public float x, y, z;
        private float v1;
        private float v2;
        private float v3;

        public Vector3(float v1, float v2, float v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }
    }
}

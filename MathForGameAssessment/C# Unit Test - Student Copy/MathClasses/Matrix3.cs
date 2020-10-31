using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix3
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;
        public Vector3 xAxis;
        public Vector3 yAxis;
        public Vector3 zAxis;
        public readonly static Matrix3 identity = new Matrix3(1, 0, 0, 0, 1, 0, 0, 0, 1);
        //constructs
        public Matrix3(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9)
        {
            this.m1 = m1; this.m2 = m2; this.m3 = m3;
            this.m4 = m4; this.m5 = m5; this.m6 = m6;
            this.m7 = m7; this.m8 = m8; this.m9 = m9;
            this.xAxis = new Vector3(m1, m4, m7);
            this.yAxis = new Vector3(m2, m5, m8);
            this.zAxis = new Vector3(m3, m6, m9);
        }

        public Matrix3()
        {
            this.m1 = identity.m1; this.m2 = identity.m2; this.m3 = identity.m3;
            this.m4 = identity.m4; this.m5 = identity.m5; this.m6 = identity.m6;
            this.m7 = identity.m7; this.m8 = identity.m8; this.m9 = identity.m9;
            this.xAxis = new Vector3(m1, m4, m7);
            this.yAxis = new Vector3(m2, m5, m8);
            this.zAxis = new Vector3(m3, m6, m9);
        }
        //Matrix multiplying by matrix
        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {
            return new Matrix3(
                lhs.m1 * rhs.m1 + lhs.m4 * rhs.m2 + lhs.m7 * rhs.m3/*m1*/, lhs.m2 * rhs.m1 + lhs.m5 * rhs.m2 + lhs.m8 * rhs.m3/*m2*/, lhs.m3 * rhs.m1 + lhs.m6 * rhs.m2 + lhs.m9 * rhs.m3/*m3*/,
                 lhs.m1 * rhs.m4 + lhs.m4 * rhs.m5 + lhs.m7 * rhs.m6/*m4*/, lhs.m2 * rhs.m4 + lhs.m5 * rhs.m5 + lhs.m8 * rhs.m6/*m5*/, lhs.m3 * rhs.m4 + lhs.m6 * rhs.m5 + lhs.m9 * rhs.m6/*m6*/,
                 lhs.m1 * rhs.m7 + lhs.m4 * rhs.m8 + lhs.m7 * rhs.m9/*m7*/, lhs.m2 * rhs.m7 + lhs.m5 * rhs.m8 + lhs.m8 * rhs.m9/*m8*/, lhs.m3 * rhs.m7 + lhs.m6 * rhs.m8 + lhs.m9 * rhs.m9/*m9*/
                );
        }
        //matrix by scalar
        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            return new Vector3((lhs.m1 * rhs.x) + (lhs.m4 * rhs.y) + (lhs.m7 * rhs.z), (lhs.m2 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m8 * rhs.z), (lhs.m3 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m9 * rhs.z));
        }
        //Transposing a matrix3
        public Matrix3 GetTransposed()
        {
            // flip row and column
            return new Matrix3(
           m1, m4, m7,
           m2, m5, m8,
           m3, m6, m9);
        }
        //setting a scaled matrix3 to multiply by
        public void SetScaled(float x, float y, float z)
        {
            m1 = x; m2 = 0; m3 = 0;
            m4 = 0; m5 = y; m6 = 0;
            m7 = 0; m8 = 0; m9 = z;
        }
        //setting a scaled matrix 3 using a vector instead of 3 values.
        public void SetScaled(Vector3 v)
        {
            m1 = v.x; m2 = 0; m3 = 0;
            m4 = 0; m5 = v.y; m6 = 0;
            m7 = 0; m8 = 0; m9 = v.z;
        }
        //setting a matrix to the inputed matrix
        public void Set(Matrix3 m)
        {
            m1 = m.m1; m2 = m.m2; m3 = m.m3;
            m4 = m.m4; m5 = m.m5; m6 = m.m6;
            m7 = m.m7; m8 = m.m8; m9 = m.m9;
        }
        public void Set(float M1, float M2, float M3, float M4, float M5, float M6, float M7, float M8, float M9)
        {
            m1 = M1; m2 = M2; m3 = M3;
            m4 = M4; m5 = M5; m6 = M6;
            m7 = M7; m8 = M8; m9 = M9;
        }
        //scales a matrix.
        public void Scale(Vector3 v)
        {
            Matrix3 m = new Matrix3();
            m.SetScaled(v.x, v.y, v.z);
            Set(this * m);
        }
        public void Scale(float x, float y, float z)
        {
            Matrix3 m = new Matrix3();
            m.SetScaled(x, y, z);
            Set(this * m);
        }
        //sets a matrix to the rotated x
        public void SetRotateX(double radians)
        {
            Set(
            1, 0, 0,
            0, (float)Math.Cos(radians), (float)-Math.Sin(radians),
            0, (float)Math.Sin(radians), (float)Math.Cos(radians));
        }
        //rotates the matrix by the rotated x matrix.
        public void RotateX(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateX(radians);
            Set(this * m);
        }
        //repeat last two methods but for y
        public void SetRotateY(double radians)
        {
            Set((float)Math.Cos(radians), 0, (float)Math.Sin(radians),
             0, 1, 0,
             (float)-Math.Sin(radians), 0, (float)Math.Cos(radians));
        }
        public void RotateY(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateY(radians);
            Set(this * m);
        }
        //repeat last 4 methods but for z
        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), (float)-Math.Sin(radians), 0,
                (float)Math.Sin(radians), (float)Math.Cos(radians), 0,
                0, 0, 1);
        }
        public void RotateZ(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateZ(radians);
            Set(this * m);
        }
        public void SetEuler(float pitch, float yaw, float roll)
        {
            Matrix3 x = new Matrix3();
            Matrix3 y = new Matrix3();
            Matrix3 z = new Matrix3();
            x.SetRotateX(pitch);
            y.SetRotateY(yaw);
            z.SetRotateZ(roll);
            // combine rotations in a specific order
            Set(z * y * x);
        }
        //set rotate y/z/w not mentioned?
        public void SetTranslation(float x, float y)
        {
            m7 = x; m8 = y; m9 = 1;
        }
        public void Translate(float x, float y)
        {
            // apply vector offset
            m7 += x; m8 += y;
        }

    }
}
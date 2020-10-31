using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{

    public class Matrix4
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;
        public readonly static Matrix4 identity = new Matrix4(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
        public Vector4 xAxis;
        public Vector4 yAxis;
        public Vector4 zAxis;
        public Vector4 wAxis;
        public Matrix4(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9, float m10, float m11, float m12, float m13, float m14, float m15, float m16)
        {
            this.m1 = m1; this.m2 = m2; this.m3 = m3; this.m4 = m4;
            this.m5 = m5; this.m6 = m6; this.m7 = m7; this.m8 = m8;
            this.m9 = m9; this.m10 = m10; this.m11 = m11; this.m12 = m12;
            this.m13 = m13; this.m14 = m14; this.m15 = m15; this.m16 = m16;

            this.xAxis = new Vector4(m1, m5, m9, m13);
            this.yAxis = new Vector4(m2, m6, m10, m14);
            this.zAxis = new Vector4(m3, m7, m11, m15);
            this.wAxis = new Vector4(m4, m8, m12, m16);
        }

        public Matrix4()
        {
            this.m1 = identity.m1; this.m2 = identity.m2; this.m3 = identity.m3; this.m4 = identity.m4;
            this.m5 = identity.m5; this.m6 = identity.m6; this.m7 = identity.m7; this.m8 = identity.m8;
            this.m9 = identity.m9; this.m10 = identity.m10; this.m11 = identity.m11; this.m12 = identity.m12;
            this.m13 = identity.m13; this.m14 = identity.m14; this.m15 = identity.m15; this.m16 = identity.m16;

            this.xAxis = new Vector4(m1, m5, m9, m13);
            this.yAxis = new Vector4(m2, m6, m10, m14);
            this.zAxis = new Vector4(m3, m7, m11, m15);
            this.wAxis = new Vector4(m4, m8, m12, m16);
        }
        //operators
        public static Matrix4 operator *(Matrix4 lhs, Matrix4 rhs)
        {
            return new Matrix4(
                lhs.m1 * rhs.m1 + lhs.m5 * rhs.m2 + lhs.m9 * rhs.m3 + lhs.m13 * rhs.m4/*m1*/, lhs.m2 * rhs.m1 + lhs.m6 * rhs.m2 + lhs.m10 * rhs.m3 + lhs.m14 * rhs.m4/*m2*/, lhs.m3 * rhs.m1 + lhs.m7 * rhs.m2 + lhs.m11 * rhs.m3 + lhs.m15 * rhs.m4/*3*/ , lhs.m4 * rhs.m1 + lhs.m8 * rhs.m2 + lhs.m12 * rhs.m3 + lhs.m16 * rhs.m4/*m4*/,
                lhs.m1 * rhs.m5 + lhs.m5 * rhs.m6 + lhs.m9 * rhs.m7 + lhs.m13 * rhs.m8/*m5*/, lhs.m2 * rhs.m5 + lhs.m6 * rhs.m6 + lhs.m10 * rhs.m7 + lhs.m14 * rhs.m8/*m6*/, lhs.m3 * rhs.m5 + lhs.m7 * rhs.m6 + lhs.m11 * rhs.m7 + lhs.m15 * rhs.m8/*m7*/, lhs.m4 * rhs.m5 + lhs.m8 * rhs.m6 + lhs.m12 * rhs.m7 + lhs.m16 * rhs.m8/*m8*/,
                lhs.m1 * rhs.m9 + lhs.m5 * rhs.m10 + lhs.m9 * rhs.m11 + lhs.m13 * rhs.m12/*m9*/, lhs.m2 * rhs.m9 + lhs.m6 * rhs.m10 + lhs.m10 * rhs.m11 + lhs.m14 * rhs.m12/*m10*/, lhs.m3 * rhs.m9 + lhs.m7 * rhs.m10 + lhs.m11 * rhs.m11 + lhs.m15 * rhs.m12/*m11*/, lhs.m4 * rhs.m9 + lhs.m8 * rhs.m10 + lhs.m12 * rhs.m11 + lhs.m16 * rhs.m12/*12*/,
                lhs.m1 * rhs.m13 + lhs.m5 * rhs.m14 + lhs.m9 * rhs.m15 + lhs.m13 * rhs.m16/*m13*/, lhs.m2 * rhs.m13 + lhs.m6 * rhs.m14 + lhs.m10 * rhs.m15 + lhs.m14 * rhs.m16/*m14*/, lhs.m3 * rhs.m13 + lhs.m7 * rhs.m14 + lhs.m11 * rhs.m15 + lhs.m15 * rhs.m16/*m15*/, lhs.m4 * rhs.m13 + lhs.m8 * rhs.m14 + lhs.m12 * rhs.m15 + lhs.m16 * rhs.m16/*m16*/
                );
        }
        public static Vector4 operator *(Matrix4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.m1 * rhs.x + lhs.m5 * rhs.y + lhs.m9 * rhs.z + lhs.m13 * rhs.w, lhs.m2 * rhs.x + lhs.m6 * rhs.y + lhs.m10 * rhs.z + lhs.m14 * rhs.w, lhs.m3 * rhs.x + lhs.m7 * rhs.y + lhs.m11 * rhs.z + lhs.m15 * rhs.w, lhs.m4 * rhs.x + lhs.m8 * rhs.y + lhs.m12 * rhs.z + lhs.m16 * rhs.w);
        }
        public Matrix4 GetTransposed()
        {
            return new Matrix4(
                m1, m5, m9, m13,
                m2, m6, m10, m14,
                m3, m7, m11, m15,
                m4, m8, m12, m16);
        }
        //sets to a scaled matrix
        public void SetScaled(float x, float y, float z, float w)
        {
            m1 = x; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = y; m7 = 0; m8 = 0;
            m9 = 0; m10 = 0; m11 = z; m12 = 0;
            m13 = 0; m14 = 0; m15 = 0; m16 = w;
        }
        //same as previous but uses a vector instead of 4 inputed values.
        public void SetScaled(Vector4 v)
        {
            m1 = v.x; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = v.y; m7 = 0; m8 = 0;
            m9 = 0; m10 = 0; m11 = v.z; m12 = 0;
            m13 = 0; m14 = 0; m15 = 0; m16 = v.w;
        }
        //sets a matrix
        public void Set(Matrix4 m)
        {
            m1 = m.m1; m2 = m.m2; m3 = m.m3; m4 = m.m4;
            m5 = m.m5; m6 = m.m6; m7 = m.m7; m8 = m.m8;
            m9 = m.m9; m10 = m.m10; m11 = m.m11; m12 = m.m12;
            m13 = m.m13; m14 = m.m14; m15 = m.m15; m16 = m.m16;
        }
        //set with floats
        public void Set(float M1, float M2, float M3, float M4, float M5, float M6, float M7, float M8, float M9, float M10, float M11, float M12, float M13, float M14, float M15, float M16)
        {
            m1 = M1; m2 = M2; m3 = M3; m4 = M4;
            m5 = M5; m6 = M6; m7 = M7; m8 = M8;
            m9 = M9; m10 = M10; m11 = M11; m12 = M12;
            m13 = M13; m14 = M14; m15 = M15; m16 = M16;
        }
        //scales a matrix
        public void Scale(Vector4 v)
        {
            Matrix4 m = new Matrix4();
            m.SetScaled(v.x, v.y, v.z, v.w);
            Set(this * m);
        }
        public void Scale(float x, float y, float z, float w)
        {
            Matrix4 m = new Matrix4();
            m.SetScaled(x, y, z, w);
            Set(this * m);
        }
        public void SetRotateX(double radians)
        {
            Set(
            1, 0, 0, 0,
            0, (float)Math.Cos(radians), (float)-Math.Sin(radians),0,
            0, (float)Math.Sin(radians), (float)Math.Cos(radians),0,
            0,0,0,1);
        }
        //rotates the matrix by the rotated x matrix.
        public void RotateX(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateX(radians);
            Set(this * m);
        }
        //repeat last two methods but for y
        public void SetRotateY(double radians)
        {
            Set((float)Math.Cos(radians), 0, (float)Math.Sin(radians), 0,
             0, 1, 0, 0,
             (float)-Math.Sin(radians), 0, (float)Math.Cos(radians),0,
             0,0,0,1);
        }
        public void RotateY(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateY(radians);
            Set(this * m);
        }
        //repeat last 4 methods but for z
        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), (float)-Math.Sin(radians), 0, 0,
                (float)Math.Sin(radians), (float)Math.Cos(radians), 0, 0,
                0, 0, 1,0,
                0,0,0,1);
        }
        public void RotateZ(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateZ(radians);
            Set(this * m);
        }
        public void SetTranslation(float x, float y, float z)
        {
            m13 = x; m14 = y; m15 = z; m16 = 1;
        }
        public void Translate(float x, float y, float z)
        {
            // apply vector offset
            m13 += x; m14 += y; m15 += z;
        }
    }
}

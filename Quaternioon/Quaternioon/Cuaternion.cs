using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Motor_fisica2
{
    public class Cuaternion
    {
        #region atributos
        private float a;
        private float x;
        private float y;
        private float z;
        #endregion

        #region constructores
        public Cuaternion()
        {
        }
        public Cuaternion(float A, float X, float Y, float Z)
        {
            a = A;
            x = X;
            y = Y;
            z = Z;

        }
        public Cuaternion(Cuaternion q)
            : this(q.a, q.x, q.y, q.z)
        {

        }
        #endregion

        #region propiedades
        public float A
        {
            get
            {
                return a;
            }
        }
        public float X
        {
            get
            {
                return x;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }
        }
        public float Z
        {
            get
            {
                return z;
            }
        }
        #endregion

        #region propiedades_staticas
        //vector 1
        public static Cuaternion One
        {
            get
            {
                return new Cuaternion(0, 1, 1, 1);
            }
        }

        public static Cuaternion Zero
        {
            get
            {
                return new Cuaternion(0, 0, 0, 0);
            }
        }
        public static Cuaternion UnitX
        {
            get
            {
                return new Cuaternion(0, 1, 0, 0);
            }
        }

        public static Cuaternion UnitY
        {
            get
            {
                return new Cuaternion(0, 0, 1, 0);
            }
        }

        public static Cuaternion UnitZ
        {
            get
            {
                return new Cuaternion(0, 0, 0, 1);
            }
        }
        #endregion

        #region metodos

        public static float modulo(Cuaternion Q)
        {
            float m;
            m = Convert.ToSingle(Math.Sqrt(
                Math.Pow(Q.A, 2) + Math.Pow(Q.X, 2) +
                    Math.Pow(Q.Y, 2) +
                    Math.Pow(Q.Z, 2)));
            return m;

        }

        public float modulo()
        {
            return Convert.ToSingle(
                (Math.Sqrt(Convert.ToDouble(a * a + x * x + y * y + z * z))));
        }

        public void norma()
        {
            float d = modulo();
            if (d > 0)
            {
                a = a / d;
                x = x / d;
                y = y / d;
                z = z / d;
            }

        }


        #endregion

        #region metodos_staticos

        #endregion










    }
}

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


        public static Cuaternion op_multiplicarescalar(float lambda, Cuaternion Q)
        {
            return new Cuaternion(lambda * Q.a, lambda * Q.x, lambda * Q.y, lambda * Q.z);

        }

        public static Cuaternion suma(Cuaternion Q1, Cuaternion Q2)
        {
            return new Cuaternion(Q1.a + Q2.a, Q1.x + Q2.x, Q1.y + Q2.y, Q1.z + Q2.z);
        }

        public static Cuaternion resta(Cuaternion Q1, Cuaternion Q2)
        {
            return suma(Q1, op_multiplicarescalar(-1, Q2));
        }

        public static Cuaternion producto_quater(Cuaternion Q1, Cuaternion Q2)
        {
            return new Cuaternion(
                Q1.A * Q2.A - (Q1.X * Q2.X + Q1.Y * Q2.Y + Q1.Z * Q2.Z),
                Q1.A * Q2.X + Q2.A * Q1.X + Q1.Y * Q2.Z - Q1.Z * Q2.Y,
                Q2.A * Q1.Y + Q1.A * Q2.Y + Q1.Z * Q2.X - Q1.X * Q2.Z,
                Q2.A * Q1.Z + Q1.A * Q2.Z - Q1.Y * Q2.X + Q1.X * Q2.Y);
        }

        public static float producto_escalar(Cuaternion Q1, Cuaternion Q2)
        {
            return (Q1.A * Q2.A + Q1.X * Q2.X + Q1.Y * Q2.Y + Q1.Z * Q2.Z);

        }


        public static Cuaternion normalizar(Cuaternion Q)
        {
            float d = Q.modulo();
            if (d > 0)
            {
                Q.a = Q.A / d;
                Q.x = Q.X / d;
                Q.y = Q.Y / d;
                Q.z = Q.Z / d;
            }
            return new Cuaternion(Q);
        }

        public static Cuaternion conjugado(Cuaternion Q)
        {
            return new Cuaternion(Q.A, -1 * Q.X, -1 * Q.Y, -1 * Q.Z);
        }

        public static Cuaternion transf_rotar(float angulo, Cuaternion q)
        {
            return new Cuaternion(Convert.ToSingle(Math.Cos((angulo / 2) * (Math.PI / 180))),
                Convert.ToSingle(Math.Sin((angulo / 2) * (Math.PI / 180))) * q.x,
                Convert.ToSingle(Math.Sin((angulo / 2) * (Math.PI / 180))) * q.y,
                Convert.ToSingle(Math.Sin((angulo / 2) * (Math.PI / 180))) * q.z);
        }

        public static Cuaternion quater_inverso(Cuaternion Q)
        {
            float d = Q.modulo();
            if (d > 0)
            {
                Q.a = Q.A;
                Q.x = (-1) * Q.X;
                Q.y = (-1) * Q.Y;
                Q.z = (-1) * Q.Z;
            }


            return new Cuaternion(Convert.ToSingle(Q.A / (Math.Pow(d, 2))),
                Convert.ToSingle(Q.x / (Math.Pow(d, 2))),
                Convert.ToSingle(Q.y / (Math.Pow(d, 2))),
                Convert.ToSingle(Q.z / (Math.Pow(d, 2))));

        }


        #endregion




        //ESTO ES UNA PRUEBA DEL USO DE SOURCETREE





    }
}

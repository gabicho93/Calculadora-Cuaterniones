using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Motor_fisica2;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        //rotar
        private void button1_Click(object sender, EventArgs e)
        {
            float theta; 
            float p1,p2,p3,p4;
            float d1, d2, d3, d4;
            
            theta = Convert.ToSingle(Convert.ToDouble(this.textBox1.Text));
            
            p1 = Convert.ToSingle(Convert.ToDouble(this.textBox2.Text));
            p2 = Convert.ToSingle(Convert.ToDouble(this.textBox3.Text));
            p3 = Convert.ToSingle(Convert.ToDouble(this.textBox4.Text));
            p4 = Convert.ToSingle(Convert.ToDouble(this.textBox11.Text));
            Cuaternion p= new Cuaternion(p1,p2,p3,p4);

            d1 = Convert.ToSingle(Convert.ToDouble(this.textBox5.Text));
            d2 = Convert.ToSingle(Convert.ToDouble(this.textBox6.Text));
            d3 = Convert.ToSingle(Convert.ToDouble(this.textBox7.Text));
            d4 = Convert.ToSingle(Convert.ToDouble(this.textBox12.Text));
            Cuaternion d= new Cuaternion(d1,d2,d3,d4);
                                    
            Cuaternion q1 = new Cuaternion();
            q1 = Cuaternion.normalizar(d);
            Cuaternion q2 = new Cuaternion();
            q2 = Cuaternion.transf_rotar(theta, q1);
            Cuaternion q3 = new Cuaternion();
            q3 = Cuaternion.conjugado(q2);
            Cuaternion q4 = new Cuaternion();
            q4 =Cuaternion.producto_quater(q2,p);
            Cuaternion Qr = new Cuaternion();
            Qr = Cuaternion.producto_quater(q4,q3);

            this.textBox8.Text = Qr.A.ToString();
            this.textBox9.Text = Qr.X.ToString();
            this.textBox10.Text =Qr.Y.ToString();
            this.textBox13.Text =Qr.Z.ToString();

            
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float p1, p2, p3, p4;
            float d1, d2, d3, d4;

            p1 = Convert.ToSingle(Convert.ToDouble(this.textBox2.Text));
            p2 = Convert.ToSingle(Convert.ToDouble(this.textBox3.Text));
            p3 = Convert.ToSingle(Convert.ToDouble(this.textBox4.Text));
            p4 = Convert.ToSingle(Convert.ToDouble(this.textBox11.Text));
            Cuaternion p = new Cuaternion(p1, p2, p3, p4);

            d1 = Convert.ToSingle(Convert.ToDouble(this.textBox5.Text));
            d2 = Convert.ToSingle(Convert.ToDouble(this.textBox6.Text));
            d3 = Convert.ToSingle(Convert.ToDouble(this.textBox7.Text));
            d4 = Convert.ToSingle(Convert.ToDouble(this.textBox12.Text));
            Cuaternion d = new Cuaternion(d1, d2, d3, d4);

            Cuaternion q4 = new Cuaternion();
            q4 = Cuaternion.producto_quater(p, d);

            this.textBox8.Text = q4.A.ToString();
            this.textBox9.Text = q4.X.ToString();
            this.textBox10.Text = q4.Y.ToString();
            this.textBox13.Text = q4.Z.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float p1, p2, p3, p4;
            p1 = Convert.ToSingle(Convert.ToDouble(this.textBox2.Text));
            p2 = Convert.ToSingle(Convert.ToDouble(this.textBox3.Text));
            p3 = Convert.ToSingle(Convert.ToDouble(this.textBox4.Text));
            p4 = Convert.ToSingle(Convert.ToDouble(this.textBox11.Text));
            Cuaternion p = new Cuaternion(p1, p2, p3, p4);

            Cuaternion q4 = new Cuaternion();
            q4 = Cuaternion.quater_inverso(p);

            this.textBox8.Text = q4.A.ToString();
            this.textBox9.Text = q4.X.ToString();
            this.textBox10.Text = q4.Y.ToString();
            this.textBox13.Text = q4.Z.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float theta;
            float p1, p2, p3, p4;

            theta = Convert.ToSingle(Convert.ToDouble(this.textBox1.Text));

            p1 = Convert.ToSingle(Convert.ToDouble(this.textBox5.Text));
            p2 = Convert.ToSingle(Convert.ToDouble(this.textBox6.Text));
            p3 = Convert.ToSingle(Convert.ToDouble(this.textBox7.Text));
            p4 = Convert.ToSingle(Convert.ToDouble(this.textBox12.Text));
            Cuaternion p = new Cuaternion(p1, p2, p3, p4);

            Cuaternion q4 = new Cuaternion();
            q4 = Cuaternion.transf_rotar(theta, p);

            this.textBox8.Text = q4.A.ToString();
            this.textBox9.Text = q4.X.ToString();
            this.textBox10.Text = q4.Y.ToString();
            this.textBox13.Text = q4.Z.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            float p1, p2, p3, p4;

          
            p1 = Convert.ToSingle(Convert.ToDouble(this.textBox2.Text));
            p2 = Convert.ToSingle(Convert.ToDouble(this.textBox3.Text));
            p3 = Convert.ToSingle(Convert.ToDouble(this.textBox4.Text));
            p4 = Convert.ToSingle(Convert.ToDouble(this.textBox11.Text));
            Cuaternion p = new Cuaternion(p1, p2, p3, p4);

            Cuaternion q4 = new Cuaternion();
            q4 = Cuaternion.conjugado( p);

            this.textBox8.Text = q4.A.ToString();
            this.textBox9.Text = q4.X.ToString();
            this.textBox10.Text = q4.Y.ToString();
            this.textBox13.Text = q4.Z.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float p1, p2, p3, p4;


            p1 = Convert.ToSingle(Convert.ToDouble(this.textBox2.Text));
            p2 = Convert.ToSingle(Convert.ToDouble(this.textBox3.Text));
            p3 = Convert.ToSingle(Convert.ToDouble(this.textBox4.Text));
            p4 = Convert.ToSingle(Convert.ToDouble(this.textBox11.Text));
            Cuaternion p = new Cuaternion(p1, p2, p3, p4);

            Cuaternion q4 = new Cuaternion();
            q4 = Cuaternion.normalizar(p);

            this.textBox8.Text = q4.A.ToString();
            this.textBox9.Text = q4.X.ToString();
            this.textBox10.Text = q4.Y.ToString();
            this.textBox13.Text = q4.Z.ToString();
        }
    }
}

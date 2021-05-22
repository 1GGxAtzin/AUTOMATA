using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT_TC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         
            InitializeComponent();
        }
        List<string> cadena = new List<string>();
        List<int> lestado = new List<int>();



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = true;
            tcadena.Enabled = true;
            testados.Enabled = true;
            tresultado.Enabled = true;
            tresultado.Text = "";
            tcadena.Text = "";
            testados.Text = "";
            cadena.Clear();
            lestado.Clear();
            
        }
        void estado6(int length){
            int i = lestado.Count();
            for (i = lestado.Count(); i < length; ++i)
            {
                if (cadena[i] == "0" || cadena[i] == "1" || cadena[i] == "2" || cadena[i] == "3" || cadena[i] == "4" || cadena[i] == "5" || cadena[i] == "6" || cadena[i] == "7" || cadena[i] == "8" || cadena[i] == "9")
                {
                    lestado.Add(6);
                    
                }
                else if(cadena[i] != "0" || cadena[i] != "1" || cadena[i] != "2" || cadena[i] != "3" || cadena[i] != "4" || cadena[i] != "5" || cadena[i] != "6" || cadena[i] != "7" || cadena[i] != "8" || cadena[i] != "9")
                {
                    tresultado.Text = "Error de cadena";
                    
                    for (i = 0; i < lestado.Count(); ++i)
                    {
                        testados.Text += lestado[i];
                    }
                    return;

                }

            }
            lestado.Add(6);
            
            tresultado.Text = "Exponencial";
            for (int u = 0; u < lestado.Count(); ++u)
            {
                testados.Text += lestado[u] + " ";
            }




        }
        void estado5(int length)
        {
            int i = lestado.Count();
            if (cadena[i] == "0" || cadena[i] == "1" || cadena[i] == "2" || cadena[i] == "3" || cadena[i] == "4" || cadena[i] == "5" || cadena[i] == "6" || cadena[i] == "7" || cadena[i] == "8" || cadena[i] == "9")
            {
                lestado.Add(5);
                estado6(length);
            }
            else
            {
                tresultado.Text = "cadena invalida";
                for (i = 0; i < lestado.Count(); ++i)
                {
                    testados.Text += lestado[i];
                }
            }

        }
        void estado4(int length)
        {
            int i = lestado.Count();
            if (cadena[i] == "+" || cadena[i]== "-")
            {
                lestado.Add(4);
                estado5(length);
            }
            else
            {
                tresultado.Text = "cadena invalida";
                for (i = 0; i < lestado.Count(); ++i)
                {
                    testados.Text += lestado[i];
                }
            }       

        }
        void estado3(int length)
        {
            int j = lestado.Count(); 
            int i = lestado.Count();
            for (i = lestado.Count(); i < length; ++i)
            {                             

                if (cadena[i] == "0" || cadena[i] == "1" || cadena[i] == "2" || cadena[i] == "3" || cadena[i] == "4" || cadena[i] == "5" || cadena[i] == "6" || cadena[i] == "7" || cadena[i] == "8" || cadena[i] == "9")
                {
                    lestado.Add(3);
                    j++;

                }
                else if (cadena[i] == "E")
                {
                    lestado.Add(3);
                    estado4(length);
                    return;

                }
            }
            if(i == length)
            {
                tresultado.Text = "Numero con Decimal";
                lestado.Add(3);
                for (int u = 0; u < lestado.Count(); ++u)
                {
                    testados.Text += lestado[u] +" ";
                }
            }
     
        }
        void estado2(int length)
        {
            int i = lestado.Count();
            

           if (cadena[i] == "0" || cadena[i] == "1" || cadena[i] == "2" || cadena[i] == "3" || cadena[i] == "4" || cadena[i] == "5" || cadena[i] == "6" || cadena[i] == "7" || cadena[i] == "8" || cadena[i] == "9")
                {
                lestado.Add(2);
                estado3(length);
               
                }
           else if (cadena[i] == "E")
            {
                lestado.Add(2);
                estado4(length);
                return;
               
            }
            else 
            {
               
                tresultado.Text = "Cadena incorrecta";

                for (i = 0; i < lestado.Count(); ++i)
                {
                    testados.Text += lestado[i];
                }

            }
            


        }
        void estado1(int length)
        {
            int j = lestado.Count();
            int i = lestado.Count();
            for (i = lestado.Count(); i < length; ++i)
            {

                if (cadena[i] == "0" || cadena[i] == "1" || cadena[i] == "2" || cadena[i] == "3" || cadena[i] == "4" || cadena[i] == "5" || cadena[i] == "6" || cadena[i] == "7" || cadena[i] == "8" || cadena[i] == "9")
                {
                    lestado.Add(1);
                    j++;

                }
                else if(cadena[i]== ".")
                {
                    lestado.Add(1);
                    estado2(length);
                    return;
                }
                else
                {
                    tresultado.Text = "Cadena incorrecta";

                    for (i = 0; i < lestado.Count(); ++i)
                    {
                        testados.Text += lestado[i];
                    }
                    return;

                }
            }
                if (i == length)
                {
                    tresultado.Text = "Numero entero positivo";
                    testados.Text = "Estado: ";
                    for (int u = 0; u < length; ++u)
                    {
                        testados.Text += lestado[u] + "\n";
                    }
                }

            

        }
        void estado7(int length)
        {
            int j = 1;
            int i = 1;
            for (i=1; i< length; ++i)
            {
                char character = char.Parse(cadena[i]);
                if (Char.IsLetter(character))
                {
                    
                    lestado.Add(7);
                    j++;

                }

            }
            if (j == i)
            {
                
                tresultado.Text = "Cadena de caracteres (A - Z)";
                testados.Text = "Estado: ";
                for(int u = 0; u < length; ++u)
                {
                    testados.Text += lestado[u]+" ";
                }
            }
            else
            {
               
                tresultado.Text = "Cadena incorrecta";
                for (i = 0; i < j-1; ++i)
                {
                    testados.Text += lestado[i];
                }
            }
        }
        void estado10(int length)
        {
            if (cadena[1] == "&" && length ==2)
            {
                tresultado.Text = "Operador Logico";
                lestado.Add(10);
                lestado.Add(8);
                for(int i = 0; i< lestado.Count() ; ++i)
                {
                    testados.Text += lestado[i]+"  ";
                }
            }
            else
            {
                tresultado.Text = "Cadena incorrecta";
                for (int i = 0; i < lestado.Count(); ++i)
                {
                    testados.Text += lestado[i];
                }
            }
        }
        void estado11(int length)
        {
            if (cadena[1] == "|" && length == 2)
            {
                tresultado.Text = "Operador Logico";
                lestado.Add(11);
                lestado.Add(8);
                for (int i = 0; i < lestado.Count(); ++i)
                {
                    testados.Text += lestado[i] + "  ";
                }
            }
            else
            {
                tresultado.Text = "Cadena incorrecta";
                for (int i = 0; i < lestado.Count(); ++i)
                {
                    testados.Text += lestado[i];
                }
            }
        }
        void estado0(int length)
        {
            char character = char.Parse(cadena[0]);
            if (cadena[0] == "0" || cadena[0] == "1" || cadena[0] == "2" || cadena[0] == "3" || cadena[0] == "4" || cadena[0] == "5" || cadena[0] == "6" || cadena[0] == "7" || cadena[0] == "8" || cadena[0] == "9")
                {
                lestado.Add(0);
                estado1(length);
            }
            
            else if(Char.IsLetter(character)){
                lestado.Add(0);
                estado7(length);

                
            }
            else if (cadena[0] == "&")
            {
                lestado.Add(0);
                estado10(length);
            }
            else if(cadena[0]== "+" || cadena[0] == "-" || cadena[0] == "*" || cadena[0] == "/" && cadena.Count() == 1) 
            {
                tresultado.Text = "Operador Aritmetico";
                lestado.Add(0);
                lestado.Add(8);
                for (int i = 0; i < lestado.Count(); ++i)
                {
                    testados.Text += lestado[i]+" ";
                }

            }
            else if (cadena[0] == "|")
            {
                lestado.Add(0);
                estado11(length);
            }
            else if (cadena[0] == "<" || cadena[0] == ">" || cadena[0] == "!" || cadena[0] == "=" && cadena.Count() == 2 && cadena[1]== "=")
            {
                tresultado.Text = "Operador Relacional";
                lestado.Add(0);
                lestado.Add(9);
                lestado.Add(8);
                for (int i = 0; i < lestado.Count(); ++i)
                {
                    testados.Text += lestado[i] + " ";
                }

            }
            else
            {
                tresultado.Text = "Cadena invalida";
                lestado.Add(0);
                testados.Text = "0";
                return;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            tcadena.Enabled = false;
            testados.Enabled = false;
            tresultado.Enabled = false;
            if (tcadena.Text != "")
            {
                
                int length = tcadena.Text.Length;
                string valor = tcadena.Text;
                
                char caracter;
                //AGREGAR CADENA A LA LISTA
                for (int i = 0; i < length; ++i)
                {
                    caracter = valor[i];
                    cadena.Add(caracter.ToString());
                    
                }
                estado0(length);

            }
            
        }
    }
}

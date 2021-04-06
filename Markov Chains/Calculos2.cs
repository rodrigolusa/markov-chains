using System;
using System.Collections.Generic;
using System.Text;

namespace Markov_Chains
{
    class Matrix
    {
        float[,] matriz;

        public Matrix(float[,] m)
        {
            matriz = m;
        }

        public float[,] Suma(float[,] m)
        {
            float[,] Sumada = new float[m.GetLength(0), m.GetLength(1)];

            if (matriz.GetLength(0) != m.GetLength(0) || matriz.GetLength(1) != m.GetLength(1))
                throw new Exception("Las matrices son impoisibles de sumar");

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Sumada[i, j] = m[i, j] + matriz[i, j];
                }
            }

            return Sumada;
        }

        public float[,] EscalarMult(float escalar)
        {
            float[,] multiplicada = new float[matriz.GetLength(0), matriz.GetLength(1)];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    multiplicada[i, j] = escalar * matriz[i, j];
                }
            }

            return multiplicada;
        }

        public float[,] Resta(float[,] m)
        {
            if (matriz.GetLength(0) != m.GetLength(0) || matriz.GetLength(1) != m.GetLength(1))
                throw new Exception("Las matrices son impoisibles de restar");

            Matrix matriz1 = new Matrix(m);

            return Suma(matriz1.EscalarMult(-1));
        }

        private float[,] ElimFilCol(float[,] a, int fila, int column)
        {
            float[,] result = new float[a.GetLength(0) - 1, a.GetLength(1) - 1];
            bool fil = false;
            bool col = false;
            for (int i = 0; i < result.GetLength(0); i++)
            {
                col = false;
                if (i == fila) { fil = true; }
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (j == column) { col = true; }
                    if (!fil && !col) { result[i, j] = a[i, j]; }
                    if (!fil && col) { result[i, j] = a[i, j + 1]; }
                    if (fil && !col) { result[i, j] = a[i + 1, j]; }
                    if (fil && col) { result[i, j] = a[i + 1, j + 1]; }

                }
            }
            return result;
        }

        public float Determinante()
        {
            if (matriz.GetLength(0) != matriz.GetLength(1))
                throw new Exception("Matriz no cuadrada");
            return Determinante(this.matriz);
        }
        private float Determinante(float[,] m)
        {
            float determinante = 0;


            if (m.Length == 1)
                return m[0, 0];

            else
            {
                for (int i = 0; i < m.GetLength(0); i++)
                {
                    determinante += (float)Math.Pow(-1, i) * m[i, 0] * Determinante(ElimFilCol(m, i, 0));
                }
            }

            return determinante;
        }

        private float[,] SustCol(float[,] m, float[] soluciones, int col)
        {
            float[,] sustituida = new float[m.GetLength(0), m.GetLength(1)];

            for (int i = 0; i < sustituida.GetLength(0); i++)
            {
                for (int j = 0; j < sustituida.GetLength(1); j++)
                {
                    if (j == col)
                        sustituida[i, j] = soluciones[i];

                    else
                        sustituida[i, j] = m[i, j];
                }
            }
            return sustituida;
        }

        public float[] Cramer(float[] terminos)
        {
            float[] soluciones = new float[terminos.Length];

            float determinante = Determinante(matriz);

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soluciones[j] = Determinante(SustCol(matriz, terminos, j)) / determinante;
            }
            return soluciones;
        }
        public float[,] Inversa()
        {
            float determinante = Determinante();
            float[,] result = new float[matriz.GetLength(0), matriz.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = (float)Math.Pow(-1, i + j) * Determinante(ElimFilCol(matriz, i, j));
                }
            }
            result = EscalarMult(Transpuesta(result), 1 / determinante);
            return result;
        }
        float[,] Transpuesta(float[,] m)
        {
            float[,] result = new float[m.GetLength(0), m.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = m[j, i];
                }
            }
            return result;
        }
        public float[,] Transpuesta()
        {
            float[,] result = new float[matriz.GetLength(0), matriz.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = matriz[j, i];
                }
            }
            return result;

        }
        float[,] EscalarMult(float[,] matriz, float escalar)
        {
            float[,] multiplicada = new float[matriz.GetLength(0), matriz.GetLength(1)];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    multiplicada[i, j] = escalar * matriz[i, j];
                }
            }

            return multiplicada;
        }
        public float[,] ProductoMatrices(float[,] b)
        {
            if (matriz.GetLength(1) != b.GetLength(0))
                throw new Exception("No se puede multiplicar");
            float[,] result = new float[matriz.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    for (int k = 0; k < matriz.GetLength(1); k++)
                    {
                        result[i, j] += matriz[i, k] * b[k, j];
                    }
            return result;
        }
        public float[,] Gauss()
        {
            bool sePuedeContinuar = true;
            float[,] result = new float[matriz.GetLength(0), matriz.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = matriz[i, j];
                }

            }
            for (int i = 0; i < Math.Min(result.GetLength(0), result.GetLength(1)); i++)
            {
                if (result[i, i] == 0)
                {
                    for (int j = i + 1; j < result.GetLength(0); j++)
                    {
                        if (result[j, i] != 0)
                        {
                            IntercambiarFilas(result, i, j);
                            sePuedeContinuar = true;
                            break;
                        }
                        else
                        {
                            sePuedeContinuar = false;
                        }
                    }
                }
                if (sePuedeContinuar)
                {
                    AnulaColumna(result, i);
                }

            }
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = (float)Math.Round(result[i, j], 2);
                }
            }
            return result;
        }

        private void AnulaColumna(float[,] matriz, int i)
        {
            float terminoAnulante = 0;
            for (int j = i + 1; j < matriz.GetLength(0); j++)
            {
                terminoAnulante = -1 * matriz[j, i] / matriz[i, i];
                for (int k = i; k < matriz.GetLength(1); k++)
                {
                    matriz[j, k] = matriz[i, k] * terminoAnulante + matriz[j, k];
                }
            }
        }

        private void IntercambiarFilas(float[,] result, int i, int j)
        {
            float[] fila1 = new float[result.GetLength(1)];
            for (int k = 0; k < result.GetLength(1); k++)
            {
                fila1[k] = result[i, k];
            }
            for (int k = 0; k < result.GetLength(1); k++)
            {
                result[i, k] = result[j, k];
                result[j, k] = fila1[k];

            }
        }
    }
}
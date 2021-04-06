using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Markov_Chains
{
    public partial class FrmMain : Form
    {
        public float[,] matrix;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbMenu_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelCalc.Visible = false;
            panelEdit.Visible = false;
            panelTools.Visible = false;
            lblWarning.Text = "";
            lblException.Text = "";
        }

        private void NewMatrix()
        {
            for (int i = 0; i < 2; i++)
            {
                dgvDataMatrix.Columns.Add((i+1).ToString(), "");
            }
            for (int i = 0; i < 2; i++)
            {
                dgvDataMatrix.Rows.Add();
            }
        }

        private void FormatDataGrid(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.Width = 50;
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Height = 30;
            }

            dgv.Refresh();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearDataGrid(dgvDataMatrix);
            ClearDataGrid(dgvDataResult);
            lblWarning.Text = "";
            lblException.Text = "";
            NewMatrix();
            FormatDataGrid(dgvDataMatrix);
            panelTools.Visible = true;
            changeVisibleDataMatrix(false);
            changeVisibleEditMatrix(true);
            dgvDataMatrix.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = !panelEdit.Visible;
            panelCalc.Visible = false;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            panelCalc.Visible = !panelCalc.Visible;
            panelEdit.Visible = false;
        }

        private void BrnEditData_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            lblException.Text = "";
            panelTools.Visible = true;
            changeVisibleDataMatrix(true);
            changeVisibleEditMatrix(false);
        }

        private void BtnEditMatrix_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            lblException.Text = "";
            panelTools.Visible = true;
            changeVisibleDataMatrix(false);
            changeVisibleEditMatrix(true);
        }

        private void changeVisibleEditMatrix(bool status)
        {
            btnMatrixAdd.Visible = status;
            btnMatrixSub.Visible = status;
            btnMatrixSave.Visible = status;
        }

        private void changeVisibleDataMatrix(bool status)
        {
            btnDataEdit.Visible = status;
            btnDataEdit.Enabled = status;
            btnDataSave.Visible = status;
            btnDataSave.Enabled = !status;
        }

        private void BtnDataEdit_Click(object sender, EventArgs e)
        {
            btnDataSave.Enabled = true;
            dgvDataMatrix.Enabled = true;
            btnDataEdit.Enabled = false;
        }

        private void BtnDataSave_Click(object sender, EventArgs e)
        {
            saveDataMatrix();
            btnDataSave.Enabled = false;
            panelTools.Visible = false;
            dgvDataMatrix.Enabled = false;
        }

        private void BtnMatrixSave_Click(object sender, EventArgs e)
        {
            panelTools.Visible = false;
        }

        private void BtnMatrixAdd_Click(object sender, EventArgs e)
        {
            if(dgvDataMatrix.Columns.Count < 10)
            {
                dgvDataMatrix.Columns.Add(dgvDataMatrix.Columns.Count.ToString(), "");
                dgvDataMatrix.Rows.Add();
                FormatDataGrid(dgvDataMatrix);             
            }
        }

        private void BtnMatrixSub_Click(object sender, EventArgs e)
        {
            if(dgvDataMatrix.Columns.Count > 2)
            {
                dgvDataMatrix.Columns.RemoveAt(dgvDataMatrix.Columns.Count - 1);
                dgvDataMatrix.Rows.RemoveAt(dgvDataMatrix.Rows.Count - 1);
                FormatDataGrid(dgvDataMatrix);
            }
        }

        private void ClearDataGrid (DataGridView dgv)
        {
            int linhas = dgv.Rows.Count;
            int colunas = dgv.Columns.Count;

            for(int i = linhas - 1; i >= 0; i--)
            {
                dgv.Rows.RemoveAt(i);
            }
            for (int i = colunas -1; i >= 0; i--)
            {
                dgv.Columns.RemoveAt(i);
            }
            dgv.Refresh();
        }

        private void saveDataMatrix()
        {
            matrix = new float[dgvDataMatrix.Columns.Count,dgvDataMatrix.Rows.Count]; //matriz[coluna, linha]

            foreach (DataGridViewRow row in dgvDataMatrix.Rows)
            {                
                foreach (DataGridViewCell cell in row.Cells)
                {
                    matrix[cell.ColumnIndex, cell.RowIndex] = float.Parse(cell.Value.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                }
            }
           
        }

        private void BtnNumberPass_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            lblException.Text = "";
            try
            {
                int[] estadosAbsorventes = Calculos.ObterListaEstadosAbsorventes(matrix);
                float[,] matrizN = Calculos.ObterMatrizN(matrix, estadosAbsorventes);
                if (matrizN != null)
                {
                    float[,] matrizI = Calculos.gerarIdentidade(matrizN.GetLength(0), matrizN.GetLength(1));
                    float[,] matrizIminusN = Calculos.SubtraindoMatrizes(matrizI, matrizN);
                    Matrix matrizResult = new Matrix(matrizIminusN);
                    float[,] matrizNumeroMedioPassagens = matrizResult.Inversa();

                    SetResults(matrizNumeroMedioPassagens);
                }
                else
                {
                    lblWarning.Text = "Impossivel Calcular";
                }
            }
            catch (Exception ex)
            {
                lblWarning.Text = "Impossivel Calcular";
                lblException.Text = ex.Message;
            }
        }

        private void SetResults(float[,] matriz)
        {
            // DataGridView dgv = new DataGridView();
            ClearDataGrid(dgvDataResult);
            dgvDataResult.Refresh();
            for(int x = 0; x < matriz.GetLength(0); x++)
            {
                dgvDataResult.Columns.Add("", "");
            }
            for(int x = 0; x < matriz.GetLongLength(1); x++)
            {
                dgvDataResult.Rows.Add();
            }
            foreach (DataGridViewRow row in dgvDataResult.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    cell.Value = (float)Math.Round(matriz[cell.ColumnIndex, cell.RowIndex], 2);
                }
            }

            FormatDataGrid(dgvDataResult);
            //dgvDataResult.DataSource = dgv.DataSource;
        }

        private void SetarCabecalhoLinha(DataGridView dgv)
        {
            foreach (DataGridViewRow linha in dgv.Rows)
            {
                linha.HeaderCell.Value = (linha.Index + 1).ToString();
            }
        }

        private void BtnTimeAbs_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            lblException.Text = "";
            try
            {
                int[] estadosAbsorventes = Calculos.ObterListaEstadosAbsorventes(matrix);
                float[,] matrizN = Calculos.ObterMatrizN(matrix, estadosAbsorventes);
                if (matrizN != null)
                {
                    float[,] matrizI = Calculos.gerarIdentidade(matrizN.GetLength(0), matrizN.GetLength(1));
                    float[,] matrizIminusN = Calculos.SubtraindoMatrizes(matrizI, matrizN);
                    Matrix matrizResult = new Matrix(matrizIminusN);
                    float[,] matrizInversa = matrizResult.Inversa();
                    float[,] matrizUnitaria = Calculos.GerarMatrizUnitaria(matrizInversa.GetLength(0));
                    float[,] matrizTimeAbs = Calculos.MultiplicandoMatrizes(matrizInversa, matrizUnitaria);

                    SetResults(matrizTimeAbs);
                }
                else
                {
                    lblWarning.Text = "Impossivel Calcular";
                }
            }
            catch (Exception ex)
            {
                lblWarning.Text = "Impossivel Calcular";
                lblException.Text = ex.Message;
            }
        }

        private void BtnProbAbs_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            lblException.Text = "";
            try
            {
                int[] estadosAbsorventes = Calculos.ObterListaEstadosAbsorventes(matrix);
                float[,] matrizN = Calculos.ObterMatrizN(matrix, estadosAbsorventes);
                if (matrizN != null)
                {
                    float[,] matrizI = Calculos.gerarIdentidade(matrizN.GetLength(0), matrizN.GetLength(1));
                    float[,] matrizIminusN = Calculos.SubtraindoMatrizes(matrizI, matrizN);
                    Matrix matrizResult = new Matrix(matrizIminusN);
                    float[,] matrizInversa = matrizResult.Inversa();
                    float[,] matrizA = Calculos.GerarMatrizA(matrix, estadosAbsorventes);
                    float[,] matrizProbAbs = Calculos.MultiplicandoMatrizes(matrizInversa, matrizA);

                    SetResults(matrizProbAbs);
                }
                else
                {
                    lblWarning.Text = "Impossivel Calcular";
                }
            }
            catch(Exception ex)
            {
                lblWarning.Text = "Impossivel Calcular";
                lblException.Text = ex.Message;
            }
            
        }
    }
}

using System;
using System.Windows.Forms;

namespace AdvanCalculator
{
    public partial class CalculatorGui : Form
    {
        private readonly QuadraticEquation _quadraticEquation;
        private MatrixInverse _matrixInverse;

        public CalculatorGui()
        {
            InitializeComponent();
            _quadraticEquation = new QuadraticEquation();
            _matrixInverse = new MatrixInverse();
        }

        private void btnCalculateQuadratic_Click(object sender, EventArgs e)
        {
            float aValue = float.Parse(txtQuadraticA.Text);
            float bValue = float.Parse(txtQuadraticB.Text);
            float cValue = float.Parse(txtQuadraticC.Text);

            QuadraticResult result = _quadraticEquation.GetResult(aValue, bValue, cValue);
            lblX1.Text = result.FirstValue;
            lblX2.Text = result.SecondValue;
        }

        private void btnCalculateInverse_Click(object sender, EventArgs e)
        {
            float aValue = float.Parse(txtInverseA.Text);
            float bValue = float.Parse(txtInverseB.Text);
            float cValue = float.Parse(txtInverseC.Text);
            float dValue = float.Parse(txtInverseD.Text);
            float[] result = _matrixInverse.GetResult(aValue, bValue, cValue, dValue);
            lblResultA.Text = result[0].ToString();
            lblResultB.Text = result[1].ToString();
            lblResultC.Text = result[2].ToString();
            lblResultD.Text = result[3].ToString();
        }
    }
}
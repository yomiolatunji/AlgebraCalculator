namespace AdvanCalculator
{
    internal class MatrixInverse
    {
        public float[] GetResult(float a, float b, float c, float d)
        {
            float[] result = new float[4];
            float determinant = a * d - b * c;

            result[0] = d / determinant;
            result[1] = -b / determinant;
            result[2] = -c / determinant;
            result[3] = a / determinant;
            return result;
        }
    }
}
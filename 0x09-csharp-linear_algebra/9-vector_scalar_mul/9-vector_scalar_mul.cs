using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] mul = new double[2];
        int i;

        if (vector.Length < 2 || vector.Length > 3)
        {
            for (i = 0 ; i < 2 ; i++)
                mul[i] = -1;
            return mul;
        }

        int len;
        if  (vector.Length == 2)
            len = 2;
        else
            len = 3;

        int vector_lenght = vector.Length;
        double[] mul2 = new double[len];
        for (i = 0 ; i < vector_lenght ; i++)
            mul2[i] = (vector[i] * scalar);

        return mul2;
    }
}

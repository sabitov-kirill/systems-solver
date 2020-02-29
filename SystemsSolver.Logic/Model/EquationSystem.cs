using System;
using System.Collections.Generic;
using System.Text;
using SystemsSolver.Logic.Model;

namespace SystemsSolver.Logic.Model
{
    public class EquationSystem
    {
        LinearEquation[] equations;
		double[,] CoefficientMatrix;
        int EquationsQuantity { get; }

        public EquationSystem(int eqAmount, double[,] coeffsValue, char[] varChars)
        {
            EquationsQuantity = eqAmount;
            int VariableAmount = EquationsQuantity;
            int CoefficientAmount = VariableAmount + 1;
            equations = new LinearEquation[EquationsQuantity];
			CoefficientMatrix = new double[EquationsQuantity, CoefficientAmount];
			CoefficientMatrix = coeffsValue;

            double[][] SystemCoeffsValue = new double[EquationsQuantity][];
            for (int line = 0; line < EquationsQuantity; line++)
            {
                SystemCoeffsValue[line] = new double[CoefficientAmount];
                for (int col = 0; col < CoefficientAmount; col++)
                {
                    SystemCoeffsValue[line][col] = coeffsValue[line, col];
                }
            }

            for(int TimesRepeated = 0; TimesRepeated < EquationsQuantity; TimesRepeated++)
            {
                equations[TimesRepeated] = new LinearEquation(VariableAmount, varChars, SystemCoeffsValue[TimesRepeated]);
            }
        }
        
        public double CalculateDeterminant(double c11, double c12, double c21, double c22)
		{
			return c11 * c22 - c21 * c12;
		}
		
		public double CalculateDeterminant(double c11, double c12, double c13, double c21, double c22, double c23, double c31, double c32, double c33)
		{
			return c11 * c22 * c33 + c31 * c12 * c23 + c21 * c13 * c32 - c31 * c22 * c13 - c21 * c12 * c33 - c11 * c23 * c32;
		}
		
		public string SolveEquationsSystem()
        {

            if (EquationsQuantity == 2)
            {
                double det = CalculateDeterminant(CoefficientMatrix[0, 0], CoefficientMatrix[0, 1], CoefficientMatrix[1, 0], CoefficientMatrix[1, 1]);
                double det1 = CalculateDeterminant(CoefficientMatrix[0, 2], CoefficientMatrix[0, 1], CoefficientMatrix[1, 2], CoefficientMatrix[1, 1]);
                double det2 = CalculateDeterminant(CoefficientMatrix[0, 0], CoefficientMatrix[0, 2], CoefficientMatrix[1, 0], CoefficientMatrix[1, 2]);

                if (det == 0)
                {
                    if (det1 == 0 & det2 == 0)
                    {

                        return $"Система имеет бесконечно много решений. \n({equations[0].VariableChar[0]}, {equations[0].VariableChar[1]}) = (x, ({CoefficientMatrix[0, 2]} - {CoefficientMatrix[0, 0]}x) / {CoefficientMatrix[0, 1]}), x∈R";
                    }
                    else if (det1 != 0 | det2 != 0)
                    {
                        return $"({equations[0].VariableChar[0]}, {equations[0].VariableChar[1]})∈∅";
                    }
                }
                double root1 = det1 / det;
                double root2 = det2 / det;

                return $"({equations[0].VariableChar[0]}, {equations[0].VariableChar[1]}) = ({root1}, {root2})";
            }
            else if (EquationsQuantity == 3)
            {
                double det = CalculateDeterminant(CoefficientMatrix[0, 0], CoefficientMatrix[0, 1], CoefficientMatrix[0, 2],
                                                  CoefficientMatrix[1, 0], CoefficientMatrix[1, 1], CoefficientMatrix[1, 2],
                                                  CoefficientMatrix[2, 0], CoefficientMatrix[2, 1], CoefficientMatrix[2, 2]);

                double det1 = CalculateDeterminant(CoefficientMatrix[0, 3], CoefficientMatrix[0, 1], CoefficientMatrix[0, 2],
                                                   CoefficientMatrix[1, 3], CoefficientMatrix[1, 1], CoefficientMatrix[1, 2],
                                                   CoefficientMatrix[2, 3], CoefficientMatrix[2, 1], CoefficientMatrix[2, 2]);

                double det2 = CalculateDeterminant(CoefficientMatrix[0, 0], CoefficientMatrix[0, 3], CoefficientMatrix[0, 2],
                                                   CoefficientMatrix[1, 0], CoefficientMatrix[1, 3], CoefficientMatrix[1, 2],
                                                   CoefficientMatrix[2, 0], CoefficientMatrix[2, 3], CoefficientMatrix[2, 2]);

                double det3 = CalculateDeterminant(CoefficientMatrix[0, 0], CoefficientMatrix[0, 1], CoefficientMatrix[0, 3],
                                                   CoefficientMatrix[1, 0], CoefficientMatrix[1, 1], CoefficientMatrix[1, 3],
                                                   CoefficientMatrix[2, 0], CoefficientMatrix[2, 1], CoefficientMatrix[2, 3]);

                if (det == 0)
                {
                    if (det1 == 0 & det2 == 0 & det3 == 0)
                    {
                        return "Система имеет бесконечно много решений.";
                    }
                    else if (det1 != 0 | det2 != 0 | det3 != 0)
                    {
                        return $"({equations[0].VariableChar[0]}, {equations[0].VariableChar[1]}, {equations[0].VariableChar[2]})∈∅";
                    }
                }

                double root1 = det1 / det;
                double root2 = det2 / det;
                double root3 = det3 / det;

                return $"({equations[0].VariableChar[0]}, {equations[0].VariableChar[1]}, {equations[0].VariableChar[2]}) = ({root1}, {root2}, {root3})";
            }
            else
                return null;
        }
	}
}

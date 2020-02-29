using System;
using System.Collections.Generic;
using System.Text;

namespace SystemsSolver.Logic.Model
{
    public class LinearEquation : Equation
    {
        public LinearEquation(int varAmount, char[] varChars, double[] coeffsValue)
        {
            VarriableQuantity = varAmount;
            CoefficientQuantity = varAmount + 1;

            coefficients = new Сoefficient[VarriableQuantity + 1];

            for (int TimesRepeated = 0; TimesRepeated < CoefficientQuantity; TimesRepeated++)
            {
                coefficients[TimesRepeated] = new Сoefficient(coeffsValue[TimesRepeated]);
            }

            VariableChar = new char[varAmount];

            for (int TimesRepeated = 0; TimesRepeated < VarriableQuantity; TimesRepeated++)
            {
                VariableChar[TimesRepeated] = varChars[TimesRepeated];
            }
        }
    }
}

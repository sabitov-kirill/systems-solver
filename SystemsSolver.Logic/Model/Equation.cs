using System;
using static System.Math;

namespace SystemsSolver.Logic.Model
{
    public abstract class Equation
    {
        public Сoefficient[] coefficients;
        public int VarriableQuantity { get; protected set; }
        public int CoefficientQuantity { get; protected set; }
        public char[] VariableChar { get; protected set; }
    }
}

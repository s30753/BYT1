using System;

namespace Calc
{
     public class Calculator
     {
          double A;
          double B;
          char _operator;

          public Calculator(double A, double B, char _operator)
          {
               char[] _operators = { '+', '-', '*', '/' };
               if (!_operators.Contains(_operator))
               {
                    throw new ArgumentException($"Not an arithmetic operator: {_operator}");
               }

               this.A = A;
               this.B = B;
               this._operator = _operator;
          }

          public double Calculate()
          {
               return _operator switch
               {
                    '+' => A + B,
                    '-' => A - B,
                    '*' => A * B,
                    '/' => B == 0 ? throw new DivideByZeroException("Division by zero not allowed") : this.A / this.B,
                    _ => throw new Exception($"Invalid operator: {_operator}")
               };
          }
     }
}

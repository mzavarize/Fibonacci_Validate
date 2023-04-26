using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateProgram;

public class Validate
{
    private readonly int _numberVerify;
    public Validate(int numberVerify)
    {
        _numberVerify = numberVerify;
    }
    internal bool ValidateNumber()
        {
        return ValidateNumberRecursive(0, 1);
        }

    private bool ValidateNumberRecursive( int numberFibonacciAnt2,int numberFibonacciAnt1)
    {
        bool valid = false;
        int numberFibonacci = numberFibonacciAnt1 + numberFibonacciAnt2;

        if (numberFibonacci < _numberVerify)
           return ValidateNumberRecursive(numberFibonacciAnt1, numberFibonacci);
        
        if (numberFibonacci == _numberVerify)
            valid = true;
        return valid;
    }

}

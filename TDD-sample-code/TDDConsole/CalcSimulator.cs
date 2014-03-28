using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDConsole
{


    public class CalcSimulator
    {
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        public int Value { get; private set; }
        public CalcOperationEnum Operation { get; set; }

        public void Clear()
        {
            Operand1 = Operand2  = 0;
        }

        public void ApplyOperation()
        {
            switch (Operation)
            {
                case CalcOperationEnum.ADD:
                    Value = Operand1 + Operand2;
                    break;

                case CalcOperationEnum.SUB:
                    Value = Operand1 - Operand2;
                    break;

                case CalcOperationEnum.MUL:
                    Value = Operand1 * Operand2;
                    break;
            }
        }

        public int GetTotal() { return 0; }
    }

    public enum CalcOperationEnum
    {
        ADD = 1,
        SUB = 2,
        MUL = 3
    }
}

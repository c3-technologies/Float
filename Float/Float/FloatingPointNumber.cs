using System;
namespace Float
{
    /// <summary>
    /// Represents a floating-point number in accordance with IEEE specification 754.
    /// </summary>
    public class FloatingPointNumber
    {
        private Precision precision;
        private byte[] pBytes;
        private byte[] qBytes;
        private byte signBit;
        private string floatingPointValue;


        public FloatingPointNumber()
        {
            precision = Precision.Half;
            pBytes = new byte[1];
            pBytes[0] = 0x0;
            qBytes = new byte[1];
            qBytes[0] = 0x0;
            signBit = 0x0;

            floatingPointValue = "0";
        }
    }
}

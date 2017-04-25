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

        public FloatingPointNumber(Precision precision, byte[] pBytes, byte[] qBytes, byte signBit){
            this.pBytes = pBytes;
            this.qBytes = qBytes;
            this.signBit = signBit;

            switch(precision){
                case Precision.Single:
                    _initializeSinglePrecision();
                    break;
                case Precision.Half:
                    _initializeHalfPrecision();
                    break;
                case Precision.Double:
                    _initializeDoublePrecision();
                    break;
                default:
                    _initializeQuadPrecision();
                    break;
            }
        }

        private void _initializeQuadPrecision()
        {
            throw new NotImplementedException();
        }

        private void _initializeDoublePrecision()
        {
            throw new NotImplementedException();
        }

        private void _initializeHalfPrecision()
        {
            throw new NotImplementedException();
        }

        private void _initializeSinglePrecision()
        {
            throw new NotImplementedException();
        }
    }
}

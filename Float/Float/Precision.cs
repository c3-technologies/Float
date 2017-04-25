using System;
namespace Float
{
    /// <summary>
    /// Enumerates the precision of a floating point conversion
    /// </summary>
    public enum Precision
    {
        /// <summary>
        /// Single precision, 32-bit representation of a number.
        /// </summary>
        Single = 0x01,

        /// <summary>
        /// Half precision, 16-bit representation of a number.
        /// </summary>
        Half = 0x02,

        /// <summary>
        /// Double precision, 64-bit representation of a number.
        /// </summary>
        Double = 0x03,

        /// <summary>
        /// Quad precision, 128-bit represenation of a number.
        /// </summary>
        Quad = 0x04
    }
}

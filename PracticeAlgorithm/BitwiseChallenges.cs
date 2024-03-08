namespace PracticeAlgorithm;

public class BitwiseChallenges
{
   //  Bitwise AND (&): Performs a bitwise AND operation on each pair of corresponding bits.
   // The result is 1 if both bits are 1, otherwise 0.
   //  Bitwise OR (|): Performs a bitwise OR operation on each pair of corresponding bits.
   // The result is 1 if at least one of the bits is 1, otherwise 0.
   //  Bitwise XOR (^): Performs a bitwise XOR (exclusive OR) operation on each pair of corresponding bits.
   // The result is 1 if the bits are different, otherwise 0.
   //  Bitwise NOT (~): Flips the bits of the operand. It changes 1 to 0 and 0 to 1.
   //  Left Shift (<<): Shifts the bits of the left operand to the left by a specified number of positions.
   // The vacant positions are filled with zeros.
   // Right Shift (>>): Shifts the bits of the left operand to the right by a specified number of positions.
   // The vacant positions are filled with either zeros or the sign bit, depending on whether the operand is a
   // signed or unsigned type.
   [Fact]
   public void ChallengesBitwise()
   {
      int a = 5; // Binary: 00000101
      string aBitwise = Convert.ToString(a, 2);
      int b = 3; // Binary: 00000011
      string bBitwise = Convert.ToString(b, 2);
      
      int resultAnd = a & b; // Bitwise AND
      string resultAndBitwise = Convert.ToString(resultAnd, 2);
      int resultOr = a | b; // Bitwise OR
      string resultOrBitwise = Convert.ToString(resultOr, 2);

      int resultXor = a ^ b; // Bitwise XOR
      string resultXorBitwise = Convert.ToString(resultXor, 2);
      int resultNotA = ~a; // Bitwise NOT
      string resultNotABitwise = Convert.ToString(resultNotA, 2);
      int leftShiftResult = a << 2; // Left shift by 2 positions
      int rightShiftResult = a >> 2; // Right shift by 2 positions
      string leftShiftResultBitwise = Convert.ToString(leftShiftResult, 2);
      string rightShiftResultBitwise = Convert.ToString(rightShiftResult, 2);
      
   }
}
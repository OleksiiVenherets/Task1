using System;

namespace EpamPracticeTask1
{
    /// <summary>
    /// Class for 3D Vector operations
    /// </summary>
    public class VectorOperations: IOperation
    {
        /// <summary>
        /// Calculate scalar multiplication for two vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>Return result of scalar multiplication</returns>
        public double ScalarMultiplication(Vector firstVector, Vector secondVector)
        {
            if (firstVector == null || secondVector == null)
                throw new ArgumentNullException();
            double scalar = firstVector.X*secondVector.X + firstVector.Y*secondVector.Y + firstVector.Z*secondVector.Z;
            return scalar;
        }
        /// <summary>
        /// Calculate vector multiplication fpr two vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>Return result of vector multiplication</returns>
        public Vector VectorMultiplication(Vector firstVector, Vector secondVector)
        {
            if (firstVector == null || secondVector == null)
                throw new ArgumentNullException();
            var resultVector = new Vector(
                 firstVector.Y * secondVector.Z + firstVector.Z * secondVector.Y,
                 firstVector.Z * secondVector.X + firstVector.X * secondVector.Z,
                 firstVector.X * secondVector.Y + firstVector.Y * secondVector.X
                 );
            return resultVector;
        }
        /// <summary>
        /// Calculate mixed multiplication for three vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <param name="thirdVector">third vector</param>
        /// <returns>Return result of mixed multiplication</returns>
        public double MixedMultiplication(Vector firstVector, Vector secondVector, Vector thirdVector)
        {
            if (firstVector == null || secondVector == null)
                throw new ArgumentNullException();
            var result = ScalarMultiplication(firstVector, VectorMultiplication(secondVector, thirdVector));
            return result;
        }
        /// <summary>
        /// Calculate angle between two vectors
        /// </summary>
        /// <param name="firstVector"></param>
        /// <param name="secondVector"></param>
        /// <returns>Return angle between two vectors</returns>
        public double Angle(Vector firstVector, Vector secondVector)
        {
            if (firstVector == null || secondVector == null)
                throw new ArgumentNullException();
            var result = ScalarMultiplication(firstVector, secondVector)/(firstVector.Length * secondVector.Length);
            return result;
        }
    }
}
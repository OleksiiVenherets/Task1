using System.Security.Cryptography.X509Certificates;

namespace EpamPracticeTask1
{
    public interface IOperation
    {
        /// <summary>
        /// Calculate scalar multiplication for two vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>Return result of scalar multiplication</returns>
        double ScalarMultiplication (Vector firstVector, Vector secondVector);
        /// <summary>
        /// Calculate vector multiplication fpr two vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>Return result of vector multiplication</returns>
        Vector VectorMultiplication(Vector firstVector, Vector secondVector);
        /// <summary>
        /// Calculate mixed multiplication for three vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <param name="thirdVector">third vector</param>
        /// <returns>Return result of mixed multiplication</returns>
        double MixedMultiplication(Vector firstVector, Vector secondVector, Vector thirdVector);
        /// <summary>
        /// Calculate angle between two vectors
        /// </summary>
        /// <param name="firstVector"></param>
        /// <param name="secondVector"></param>
        /// <returns>Return angle between two vectors</returns>
        double Angle(Vector firstVector, Vector secondVector);
    }
}
using System;
using System.Collections.Generic;

namespace EpamPracticeTask1
{
    /// <summary>
    /// Class for 3D Vector
    /// </summary>
    public class Vector
    {
        /// <summary>
        /// Get X coordinate for vector
        /// </summary>
        public int X { get; }
        /// <summary>
        /// Get Y coordinate for vector
        /// </summary>
        public int Y { get; }
        /// <summary>
        /// Get Z coordinate for vector
        /// </summary>
        public int Z { get; }

        /// <summary>
        /// Get the length of vector
        /// </summary>
        public double Length => Math.Sqrt(X*X + Y*Y + Z*Z);
        /// <summary>
        /// Initializate the new vector object with (x, y, z)
        /// </summary>
        /// <param name="x">Coordinate x</param>
        /// <param name="y">Coordinate y</param>
        /// <param name="z">Coordinate z</param>
        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        /// <summary>
        /// Adding two vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>result of adding two vectors</returns>
        public static Vector operator +(Vector firstVector, Vector secondVector)
        {
            if (firstVector == null || secondVector == null)
                throw new ArgumentNullException();
            var resultVector = new Vector(firstVector.X + secondVector.X, firstVector.Y + secondVector.Y, firstVector.Z + secondVector.Z);
            return resultVector;
        }
        /// <summary>
        /// Substracting two vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>result of substracting two vectors</returns>
        public static Vector operator -(Vector firstVector, Vector secondVector)
        {
            if (firstVector == null || secondVector == null)
                throw new ArgumentNullException();
            var resultVector = new Vector(firstVector.X - secondVector.X, firstVector.Y - secondVector.Y, firstVector.Z - secondVector.Z);
            return resultVector;
        }
        /// <summary>
        /// Check is two vectors are equal
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>return true if two vectors are equals</returns>
        //public static bool operator ==(Vector firstVector, Vector secondVector)
        //{
        //    if (firstVector == null || secondVector == null)
        //        throw new ArgumentNullException();
        //    return firstVector.X == secondVector.X && firstVector.Y == secondVector.Y && firstVector.Z == secondVector.Z;
        //}
        /// <summary>
        /// Check is two vectors are not equal
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>return true if two vectors are not equals</returns>
        //public static bool operator !=(Vector firstVector, Vector secondVector)
        //{
        //    if (firstVector == null || secondVector == null)
        //        throw new ArgumentNullException();
        //    return firstVector.X != secondVector.X || firstVector.Y != secondVector.Y || firstVector.Z != secondVector.Z;
        //}
        /// <summary>
        /// Check if length of first vector more then length of second vector
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>return true if length of first vector more then length of second vector</returns>
        public static bool operator >(Vector firstVector, Vector secondVector)
        {
            if (firstVector == null || secondVector == null)
                throw new ArgumentNullException();
            return firstVector.Length > secondVector.Length;
        }
        /// <summary>
        /// Check if length of first vector less then length of second vector
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>return true if length of first vector less then length of second vector</returns>
        public static bool operator <(Vector firstVector, Vector secondVector)
        {
            if (firstVector == null || secondVector == null)
                throw new ArgumentNullException();
            return firstVector.Length < secondVector.Length;
        }

        /// <summary>
        /// Get vector int string introduction
        /// </summary>
        /// <returns>vector in string introduction</returns>
        public override string ToString()
        {
            return $"Point x: {X}\tPoint y: {Y}\tPoint z: {Z}";
        }
    }
}
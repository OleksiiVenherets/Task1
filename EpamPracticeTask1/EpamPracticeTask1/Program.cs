using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamPracticeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            var firstVector = new Vector(5, 5, 5);
            var secondVector = new Vector(1, 2, 3);
            var thirdVector = new Vector(2, 4, 5);
            var vectorOperation = new VectorOperations();
            //Length
            Console.WriteLine($"First vectors length {firstVector.Length}");
            Console.WriteLine($"Second vectors length {secondVector.Length}");
            Console.WriteLine($"third vectors length {thirdVector.Length}");
            //Adding
            try
            {
                var result = (firstVector + secondVector).ToString();
                Console.WriteLine($"Adding first and second vectors {result}");
            }

            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            //Substracting
            try
            {
                var result = (firstVector - secondVector).ToString();
                Console.WriteLine($"Substracting first and second vectors {result}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + e.Source);
            }
            //Multiplication
            try
            {
                Console.WriteLine($"Scalar multiplication {vectorOperation.ScalarMultiplication(firstVector, secondVector)}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + e.Source);
            }

            try
            {
                var result = (vectorOperation.VectorMultiplication(firstVector, secondVector)).ToString();
                Console.WriteLine($"Vector multiplication {result}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + e.Source);
            }

            try
            {
                Console.WriteLine($"Mixed multiplication {vectorOperation.MixedMultiplication(firstVector, secondVector,thirdVector )}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + e.Source);
            }
            //Angle between two vectors
            try
            {
                Console.WriteLine($"Angle between two vectors {vectorOperation.Angle(firstVector, secondVector)} rad.");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + e.Source);
            }
            //Comparing
            try
            {
                Console.WriteLine(firstVector > secondVector
                    ? "First vector is bigger then second"
                    : "First vector is not bigger then second");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + e.Source);
            }

            try
            {
                Console.WriteLine(secondVector < thirdVector
                    ? "Second vector is smaller then third"
                    : "Second vector is not smaller then third");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + e.Source);
            }

            Console.ReadKey();
        }
    }
}

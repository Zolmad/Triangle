using System;
using Xunit;

namespace Triangle
{
    public class Triangle
    {
        [Fact]
        public void FindSidesAndAngles()
        {
            //Arrange

            int sideA = 5;
            int sideB = 3;
            int angA = 60;
            int angB = 75;

            var calculate = new CalculateArea();
            var calculateAng = new CalculateAngle();

            //Act
            var area = calculate.FindArea(sideA, sideB);
            var angle = calculateAng.FindAngle(angA, angB);


            //Assert
            Assert.Equal(7.5, area);
            Assert.Equal(-45, angle);

                
        }
    }

    public class CalculateArea
    {
        internal object FindArea(int sideA, int sideB)
        {
            double result = 0.5 * (sideA * sideB);

            return result;
        }
    }

    public class CalculateAngle
    {
        internal object FindAngle(int angA, int angB)
        {
            int result = (angA + angB) - 180;

            return result;
        }
    }
}

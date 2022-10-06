using ContosoPizza.Models;
using ContosoPizza.Dtos;

namespace ContosoPizza.Services;

public static class MathService
{
    public static String SimpleMath(int num1, int num2, int amount){
        for(int i = 0; i < amount; i++){
            int product = num1 * num2;
        }

        return "Finished!";
    }
    public static float Factorial(int num){
        float product = 1;
        for(int i = 1; i <= num; i++){
            product *= i;
        }

        return product;
    }

    public static List<Coordinate> CreateCoordinates(int amount){
        List<Coordinate> coordinates = new List<Coordinate>();

        Random r = new Random();
        
        for(int i = 0; i < amount; i++){
            float lattitude = (float)r.NextDouble() * 180 - 90;
            float longitude = (float)r.NextDouble() * 360 - 180;
            string nsHemisphere = lattitude>0? "North" : "South";
            string ewHemisphere = longitude>0? "East" : "West";
            Coordinate coordinate = new Coordinate(lattitude, longitude, nsHemisphere, ewHemisphere);
            coordinates.Add(coordinate);
        }
        return coordinates;
    }
}
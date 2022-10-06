namespace ContosoPizza.Models;

public class Coordinate{
    public float lattitude {get; set;}
    public float longitude {get; set;}
    public string? nsHemisphere {get; set;}
    public string? ewHemisphere {get; set;}

    public Coordinate(float lattitude, float longitude, string nsHemisphere, string ewHemisphere){
        this.lattitude = lattitude;
        this.longitude = longitude;
        this.nsHemisphere = nsHemisphere;
        this.ewHemisphere = ewHemisphere;
    }
}
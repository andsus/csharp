using System;

public class SpaceAge
{
    static  double earth_year_in_earth_years = 1.0;
    static  double mercury_year_in_earth_years = 0.2408467;
    static  double venus_year_in_earth_years = 0.61519726;
    static  double mars_year_in_earth_years = 1.8808158;
    static  double jupiter_year_in_earth_years = 11.8626158;
    static  double saturn_year_in_earth_years = 29.447498;
    static  double uranus_year_in_earth_years = 84.016846;
    static  double neptune_year_in_earth_years = 164.79132;
    double seconds = 0.0;
    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth() => this.SecondsToYears(earth_year_in_earth_years);
    
    public double OnMercury() => this.SecondsToYears(mercury_year_in_earth_years);

    public double OnVenus() => this.SecondsToYears(venus_year_in_earth_years);

    public double OnMars() => this.SecondsToYears(mars_year_in_earth_years);

    public double OnJupiter() => this.SecondsToYears(jupiter_year_in_earth_years);

    public double OnSaturn() => this.SecondsToYears(saturn_year_in_earth_years);
    
    public double OnUranus() => this.SecondsToYears(uranus_year_in_earth_years);

    public double OnNeptune() => this.SecondsToYears(neptune_year_in_earth_years);

    private double SecondsToYears(double yearFactor) {
        return this.seconds / 60.0 / 60.0 / 24.0 / 365.25 / yearFactor;
    }
}
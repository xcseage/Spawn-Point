using System.Collections;
using System.Collections.Generic;

public class CityModule : Module {

    private Region region;

    City city;


    public CityModule(Region parent)
    {

        region = parent;
    }

    public override void init()
    {
        city = new City(region);

        throw new System.NotImplementedException();
    }
}

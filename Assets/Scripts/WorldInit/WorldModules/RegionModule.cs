using System.Collections;
using System.Collections.Generic;


public class RegionModule : Module{

    private World world;

    List<Region> regionList;

    int regionCount = 5;

	public RegionModule (World parent)
    {

        world = parent;
    }

    public override void init()
    {
        for (int i = 0; i < regionCount; ++i)
        {

            regionList.Add(new Region(world));
        }

        throw new System.NotImplementedException();
    }
}

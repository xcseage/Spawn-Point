using System.Collections;
using System.Collections.Generic;

public class VillageModule : Module{

    private Region region;

    List<Village> villageList;


    public VillageModule(Region parent)
    {

        region = parent;
    }

    public override void init()
    {
        for (int i = 0; i < villageCount; ++i)
        {     
            villageList.Add(new Village(region));
        }

        throw new System.NotImplementedException();
    }
}

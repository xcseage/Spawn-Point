using System.Collections;
using System.Collections.Generic;


public class Region
{

    List<Module> modules;

    World parent;

    public Region(World parent)
    {
        this.parent = parent;

        modules = new List<Module>();

        loadModules();
        initModules();
    }

    void loadModules ()
    {
        modules.Add(new CityModule(this));
        modules.Add(new VillageModule(this));
    }

    void initModules()
    {

        foreach(Module n in modules)
        {
            n.init();
        }
    }


}

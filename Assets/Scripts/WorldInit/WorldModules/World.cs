using System.Collections;
using System.Collections.Generic;


public class World {

    List<Module> modules;

	public World ()
    {
        modules = new List<Module>();

        loadModule();
        initModules();
    }

    void loadModule ()
    {
        modules.Add(new RegionModule(this));
    }

    void initModules ()
    {

        foreach(Module n in modules)
        {
            n.init();
        }
    }


}

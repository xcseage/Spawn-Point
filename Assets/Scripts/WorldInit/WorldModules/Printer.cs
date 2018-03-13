using System.Collections;
using System.Collections.Generic;
using System;


public class Printer {

    static bool enabled = false;

	public static void print(string s)
    {

        if (enabled)
        {
            Console.WriteLine(s);
        }
    }
}

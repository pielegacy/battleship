

using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;

namespace Battleships
{

public class Cheating
{
    public static Ship eTug;
    public static Ship eSubmarine;
    public static Ship eDestroyer;
    public static Ship eBattleship;
    public static Ship eAircraftCarrier;

    public static void storeLocation(Ship t,Ship s,Ship d,Ship b,Ship ac){
        eTug = t;
        eSubmarine = s;
        eDestroyer = d;
        eBattleship = b;
        eAircraftCarrier = ac;
    }
	
}

}
//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================

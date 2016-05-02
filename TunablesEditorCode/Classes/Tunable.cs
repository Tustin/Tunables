using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunablesEditorCode.Classes;

namespace TunablesEditorCode.Classes
{
    public class Tunable
    {
        public string name { get; set; }

        public int index { get; set; }

        public string type { get; set; }

        public Tunable(string Name, int Index, string Type)
        {
            name = Name;
            index = Index;
            type = Type;
        }

        public static bool Poke(Tunable tunable, int value, PS3Lib.PS3API ps3)
        {
            if (value > int.MaxValue || value < int.MinValue)
                return false;

           ps3.Extension.WriteInt32(Globals.CurrentAddress + ((uint)tunable.index * 4), value);
           return true;
        }
        public static bool Poke(Tunable tunable, float value, PS3Lib.PS3API ps3)
        {
            if (value > float.MaxValue || value < float.MinValue)
                return false;

            ps3.Extension.WriteFloat(Globals.CurrentAddress + ((uint)tunable.index * 4), value);
            return true;
        }
    }
}

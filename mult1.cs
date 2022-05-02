using System;
public class test
{
    public static void Main()
    {
        byte[] tavut = pvm(31, 5, 99);
        System.Console.WriteLine("Arvoilla 31,5,99 koodisi antaa tavut");
        string s = "";
        for (int i = 0; i < 2; i++)
        {
            s += Convert.ToString(tavut[i], 2).PadLeft(8, '0') + " ";
        }
        System.Console.WriteLine(s);
    }

    // BYCODEBEGIN
    /// <summary>
    /// Funktio palauttaa kaksi tavua, joihin asetettu kentät:
    /// Day - 5 bittiä
    /// Month - 4 bittiä
    /// Year - 7 bittiä
    /// </summary>
    /// <param name="Day">Päivä kuukaudessa 1-31</param>
    /// <param name="Month">Kuukausi vuodessa 1-12</param>
    /// <param name="Year">Vuosi, kahdella merkillä 00-99</param>
    /// <returns>parametreista muodostetut tavut</returns>
    public static byte[] pvm(int Day, int Month, int Year)
    {
        byte[] tavut = new byte[2];
        short dmy = 0;
        dmy = (short)(dmy ^ (Day << 11));
        dmy = (short)(dmy ^ (Month << 7));
        dmy = (short)(dmy ^ Year);
        tavut[0] = (byte)(dmy >> 8);
        tavut[1] = (byte)(dmy & 0xFF);
        return tavut;
    }
    // BYCODEEND
}


namespace tpmodul3_1302204035;

public class DoorMachine
{
    enum state
    {
        TERKUNCI,
        TERBUKA
    }

    public void doorMachine()
    {
        state main = state.TERKUNCI;
        state kunciPintu = state.TERKUNCI;
        state bukaPintu = state.TERBUKA;
        string[] screen = { "Terkunci", "Terbuka" };
        while (main == state.TERKUNCI)
        {
            Console.WriteLine("Pintu " + screen[(int)main]);
            Console.WriteLine("->Buka Pintu");
            Console.WriteLine(main = bukaPintu);
            Console.WriteLine("->Tutup Pintu");
            Console.WriteLine(main = kunciPintu);
            main = bukaPintu;
        }  
    }
}
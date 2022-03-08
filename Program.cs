// See https://aka.ms/new-console-template for more information

using tpmodul3_1302204035;

//KodePos
void kPos()
{
    KodePos kd1 = new KodePos();
    KodePos kd2 = new KodePos();
    KodePos kd3 = new KodePos();
    KodePos kd4 = new KodePos();
    KodePos kd5 = new KodePos();
    KodePos kd6 = new KodePos();
    KodePos kd7 = new KodePos();
    KodePos kd8 = new KodePos();
    KodePos kd9 = new KodePos();
    KodePos kd10 = new KodePos();
    KodePos kd11 = new KodePos();
    
    kd1.setKelurahan("Batununggal");
    kd2.setKelurahan("Kujangsari");
    kd3.setKelurahan("Mengger");
    kd4.setKelurahan("Wates");
    kd5.setKelurahan("Cijaura");
    kd6.setKelurahan("Jatisari");
    kd7.setKelurahan("Margasari");
    kd8.setKelurahan("Sekejati");
    kd9.setKelurahan("Kebonwaru");
    kd10.setKelurahan("Maleer");
    kd11.setKelurahan("Samoja");
    
    kd1.setKodePos(40266);
    kd2.setKodePos(40287);
    kd3.setKodePos(40267);
    kd4.setKodePos(40256);
    kd5.setKodePos(40287);
    kd6.setKodePos(40286);
    kd7.setKodePos(40286);
    kd8.setKodePos(40286);
    kd9.setKodePos(40272);
    kd10.setKodePos(40274);
    kd11.setKodePos(40273);
    
    Console.WriteLine("Kelurahan " + "\t" + "Kode Pos ");
    Console.WriteLine(kd1.getKelurahan() + "\t" + kd1.getKodePos());
    Console.WriteLine(kd2.getKelurahan() + "\t" + kd2.getKodePos());
    Console.WriteLine(kd3.getKelurahan() + "\t"+"\t" + kd3.getKodePos());
    Console.WriteLine(kd4.getKelurahan() + "\t"+"\t" + kd4.getKodePos());
    Console.WriteLine(kd5.getKelurahan() + "\t"+"\t" + kd5.getKodePos());
    Console.WriteLine(kd6.getKelurahan() + "\t" + kd6.getKodePos());
    Console.WriteLine(kd7.getKelurahan() + "\t" + kd7.getKodePos());
    Console.WriteLine(kd8.getKelurahan() + "\t" + kd8.getKodePos());
    Console.WriteLine(kd9.getKelurahan() + "\t" + kd9.getKodePos());
    Console.WriteLine(kd10.getKelurahan() + "\t"+"\t" + kd10.getKodePos());
    Console.WriteLine(kd11.getKelurahan() + "\t"+"\t" + kd11.getKodePos()+"\n");
}

kPos();
//DoorMachine class
DoorMachine door = new DoorMachine();
door.doorMachine();
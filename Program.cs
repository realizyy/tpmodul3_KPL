// See https://aka.ms/new-console-template for more information

using tpmodul3_1302204035;

//membuat data KodePos
void CreateData()
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
    
    Console.Write("Kelurahan : " + kd1.getKelurahan() + "\n" + "Kode Pos : " + kd1.getKodePos());
}

CreateData();
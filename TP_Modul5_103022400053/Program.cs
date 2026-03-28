HaloGeneric halo = new HaloGeneric();
halo.SapaUser("Laukpindang");
DataGeneric<string> dg = new DataGeneric<string>("103022400053");
dg.PrintData();
class HaloGeneric
{
    public void SapaUser(string user)
    {
        Console.WriteLine("Halo user " + user);
    }
}   
﻿
public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}
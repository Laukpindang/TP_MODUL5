class HaloGeneric { 
    public void SapaUser(string user)
    {
        Console.WriteLine("Halo user " + user);
    }

    public static void Main(string[] args) 
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Laukpindang");
    }
}
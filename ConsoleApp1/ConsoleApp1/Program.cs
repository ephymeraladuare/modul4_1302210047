// See https://aka.ms/new-console-template for more information
enum Kelurahan
{
    Batununggal,
    Kujangsari,
    Mengger,
    Wates,
    Cijaura,
    Jatisari,
    Margasari,
    Sekejati,
    Kebonwaru,
    Maleer,
    Samoja
}
private static int KodePos(Kelurahan inputK)
{
    int[] outKodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
    return outKodePos[(int)inputK];
}
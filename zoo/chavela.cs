using System;

class Chavela : Aves, IPlumas
{
    public override void Dormir()
    {
        console.writeline("yo duermo");
    }

    public override void HacerRuidos()
    {
        console.writeline("grugrugru");
    }
    public override void Comer()
    {
        console.writeline("yo como maiz");
    }

     public override void Volar()
    {
        console.writeline("yo voy por el aire");
    }    

    public interface TPlumas()
    {
        
    }

}
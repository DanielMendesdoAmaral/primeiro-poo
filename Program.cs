using System;

namespace primeiro_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem t = new Personagem();
            t.nome = "Tony Stark";
            t.idade = 35;
            t.armadura = "Bleeding Edge";
            t.ia = "Jarvis";

            Personagem r = new Personagem();
            r.nome = "Riri Williams";
            r.idade = 18;
            r.armadura = "Iron Heart";
            r.ia = "A.M.I";

            System.Console.WriteLine($"LUTA\n\n{t.nome}\t x\t {r.nome}\n{t.idade} anos  \t x\t {r.idade} anos\n{t.armadura}\t x\t {r.armadura}\n{t.ia}     \t x \t {r.ia}\n");

            System.Console.WriteLine($"{t.nome} ataca Riri usando 35.5 de força e 30 de potência, resultando num ataque de {t.Atacar(35.5, 30)}FP.\n{r.Defender()}\n");
        }
    }
}
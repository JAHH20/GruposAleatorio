using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GruposAleatoriosLibreria;

namespace UnitTestGrupos_Aleatorios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GenerarGrupos()
        {
            
            String[] Participantes = {"Sam","Heidy","jesus","Stephen","Alberto","Yadira" };
            Randomizer.Randomize(Participantes);

          
        }
    }
}

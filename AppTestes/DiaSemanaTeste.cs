using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;
using System;

namespace AppTestes
{
    [TestClass]
    public class DiaSemanaTeste
    {
        DiaSemana objDiaSemana;
        EnumDias resultado;

        [TestInitialize]
        public void Inicializa()
        {
            objDiaSemana = new DiaSemana();
        }

        [TestMethod]
        public void Busca5Dias()
        {
            resultado = objDiaSemana.BuscaDiaSemana(EnumDias.Seg, 5);
            Assert.AreEqual(EnumDias.Sab, resultado);
        }

        [TestMethod]
        public void Busca18Dias()
        {
            resultado = objDiaSemana.BuscaDiaSemana(EnumDias.Qua, 18);
            Assert.AreEqual(EnumDias.Dom, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void BuscaQuantidadeDiasInvalido()
        {
            resultado = objDiaSemana.BuscaDiaSemana(EnumDias.Qui, -3);
        }
    }
}
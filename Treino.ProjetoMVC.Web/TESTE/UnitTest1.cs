using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Treino.Aluno.DomainModel;
using Treino.Aluno.Repository;
using System.Data.Entity;

using Treino.Aluno.UI.Web;
namespace TESTE
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SexoREP sexo = new SexoREP();

            sexo.Criar();
        }

         [TestMethod]
        public void TESTAR_CLASSIFICACAO()
        {

           

        }



    }
}

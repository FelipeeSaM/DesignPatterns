using System;
using ChainOfResponsability.Handler;

namespace ChainOfResponsability.ConcreteHandler
{
    public class SupervisorEquipe : IAutorizador
    {
        private int ALCADA_DIAS = 15;
        public override void AutorizarLicenca(string nome, int dias)
        {
            if (dias <= ALCADA_DIAS)
            {
                AprovarLicenca(nome, dias);
            }
            else
            {
                _autorizador?.AutorizarLicenca(nome, dias);
            }
        }
        private void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"O Supervisor da Equipe aprovou {dias} dias " +
                $"de licença remunerada para : {nome}\n");
        }
    }
}

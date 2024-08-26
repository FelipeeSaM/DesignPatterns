using ChainOfResponsability.ConcreteHandler;

namespace ChainOfResponsability
{
    internal class Program {
        static void Main(string[] args) {
            #region explicação
            // Definição
            /*
             * Evita acoplar o remetente de uma solicitação ao seu receptor, dando a mais de
             * um objeto a chance de lidar com a solicitaçaõ.
             * Encadeia os objetos receptores e passa a solicitação ao longo da cadeia até que
             * um objeto as trate.
             * Simplifica a interconexão entre objetos
             * Evita a dependência de um objeto receptor e um objeto solicitante ou destinatário
             */
            // Quando usar:
            /*
             * Quando tivermos mais de um manipulador para uma solicitação
             * Motivos pelos quais um gerenciador deve pasasr uma solicitação para outro na cadeia
             * Quando temos um conjunto de manipuladores que variam de forma dinâmica
             * Manter a flexibilidade na atribuição de solicitações a manipuladores
             * Tivermos uma "cadeia" muito lógica de manipuladores que devem ser executados
             * em ordem repetidas vezes
             */
            // Vantagens:
            /*
             * Controle na ordem de tratamento da solicitação
             * Desacopla a classe que invoca operações, de classes que executam operações (SRP)
             * Pode introduzir novos manipuladores no aplicativo sem quebrar o código existente (Open/close)
             */
            #endregion

            GerenteProjeto gerenteProjeto = new GerenteProjeto();
            SupervisorEquipe supervisorEquipe = new SupervisorEquipe();
            SetorRH setorRH = new SetorRH();

            gerenteProjeto.ProximoAutorizador(supervisorEquipe);
            supervisorEquipe.ProximoAutorizador(setorRH);

            gerenteProjeto.AutorizarLicenca("Macoratti", 5);
            gerenteProjeto.AutorizarLicenca("Amanda", 14);
            gerenteProjeto.AutorizarLicenca("Benedito", 18);
            gerenteProjeto.AutorizarLicenca("Janice", 30);
            gerenteProjeto.AutorizarLicenca("Felipe", 50);

            Console.ReadKey();
        }
    }
}

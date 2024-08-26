namespace ChainOfResponsability.Handler
{
    public abstract class IAutorizador
    {
        protected IAutorizador _autorizador;
        public void ProximoAutorizador(IAutorizador autorizador)
        {
            _autorizador = autorizador;
        }
        public abstract void AutorizarLicenca(string nome, int dias);
    }
}

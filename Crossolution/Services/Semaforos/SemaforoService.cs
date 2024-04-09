namespace Crossolution.Services.Semaforos
{
    public class SemaforoService : Request
    {
        private readonly Request _request;
        private const string apiUrLBase = "http://xyz.somee.com/CrossolutionApi/Semaforos";

        //ctor + TAB -> atalho para contrutor
        public SemaforoService()
        {
            _request = new Request();
        }
    }
}

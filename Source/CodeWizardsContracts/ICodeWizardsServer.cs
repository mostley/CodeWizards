using System.ServiceModel;

namespace CodeWizards.Contracts
{
    [ServiceContract]
    public interface ICodeWizardsServer
    {
        [OperationContract]
        void WriteScroll(string token, string name, string code);

        [OperationContract]
        string Join(string username);

        [OperationContract]
        void Leave(string token);

        [OperationContract]
        WorldUpdate GetUpdate(string token);
    }
}

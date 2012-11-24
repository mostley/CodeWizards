namespace CodeWizards.Contracts
{
    using System.Runtime.Serialization;

    [DataContract]
    public class WizardBody : Entity
    {
        public double Mana { get; set; }
    }
}

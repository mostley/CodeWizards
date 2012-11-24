namespace CodeWizards.Contracts
{
    using System.Runtime.Serialization;

    [DataContract]
    public abstract class Entity
    {
        [DataMember]
        public Vector Position { get; set; }
    }
}

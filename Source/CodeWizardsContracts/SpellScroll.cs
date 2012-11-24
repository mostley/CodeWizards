namespace CodeWizards.Contracts
{
    using System.Runtime.Serialization;

    [DataContract]
    public class SpellScroll
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Code { get; set; }
    }
}

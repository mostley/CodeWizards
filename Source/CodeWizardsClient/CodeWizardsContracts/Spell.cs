namespace CodeWizards.Contracts
{
    public abstract class Spell
    {
        public Entity Target { get; set; }

        protected abstract void Invoke(IMagic magic, out bool carryOn);
    }
}

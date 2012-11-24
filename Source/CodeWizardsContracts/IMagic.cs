namespace CodeWizards.Contracts
{
    public interface IMagic
    {
        void Delve(double mana);
        void Levitate(Vector direction, double mana);
        void Cast(string name, Entity target);
        void WriteScroll(string name, string code);
    }
}
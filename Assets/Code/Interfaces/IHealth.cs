namespace Code.Interfaces
{
    public interface IHealth
    {
        bool IsDead { get; }
        
        void AddDamage();
    }
}
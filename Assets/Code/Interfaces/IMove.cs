namespace Code.Interfaces
{
    public interface IMove
    {
        float Speed { get; }
        void Move(float vertical, float deltaTime);
    }
}
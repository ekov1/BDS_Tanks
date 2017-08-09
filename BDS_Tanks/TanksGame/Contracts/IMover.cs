namespace TanksGame.Contracts
{
    public interface IMover
    {
        void Move(IMovable obj, int offsetX, int offsetY);
    }
}
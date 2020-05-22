namespace CovariantReturns
{
    public class Airplane : Vehicle
    {
        public override Fly TypeOfRide()
        {
            return new Fly();
        }
    }
}
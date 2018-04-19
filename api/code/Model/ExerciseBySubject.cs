namespace SnappetChallenge.Model
{
    public class ExerciseByInfo
    {
        public int Quantity { get; }
        public string Info { get; }

        public ExerciseByInfo(int quantity, string info)
        {
            Quantity = quantity;
            Info = info;
        }
    }
}

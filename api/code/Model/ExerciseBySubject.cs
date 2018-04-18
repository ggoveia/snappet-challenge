namespace SnappetChallenge.Model
{
    public class ExerciseBySubject
    {
        public int Quantity { get; }
        public string Subject { get; }

        public ExerciseBySubject(int quantity, string subject)
        {
            Quantity = quantity;
            Subject = subject;
        }
    }
}

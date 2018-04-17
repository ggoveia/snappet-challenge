using System.IO;

namespace SnappetChallenge.Repository
{
    public class ExerciseRepository : IExerciseRepository
    {
        public string GetExerciseInfo()
        {
            using (StreamReader r = new StreamReader("Data\\Informations.json"))
            {
                return r.ReadToEnd();
            }
        }
    }
}

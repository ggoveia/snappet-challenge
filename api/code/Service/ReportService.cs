using SnappetChallenge.Model;
using SnappetChallenge.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SnappetChallenge.Service
{
    public class ReportService : IReportService
    {
        private readonly IExerciseRepository _exerciseRepository;

        public ReportService(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }

        public IEnumerable<ExerciseBySubject> GetExercisesBySubject(DateTime startDate, DateTime endDate)
        {
            var allExercises = _exerciseRepository.Get(startDate, endDate);

            return allExercises.GroupBy(c => c.Subject)
                    .Select(v => new ExerciseBySubject(v.Count(), v.First().Subject));
        }
        
    }
}

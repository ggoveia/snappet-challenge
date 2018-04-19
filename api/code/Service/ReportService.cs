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

        public IEnumerable<ExerciseByInfo> GetExercisesBySubject(DateTime startDate, DateTime endDate)
        {
            var allExercises = _exerciseRepository.Get(startDate, endDate);

            return allExercises.GroupBy(c => c.Subject)
                    .Select(v => new ExerciseByInfo(v.Count(), v.First().Subject));
        }

        public IEnumerable<ExerciseByInfo> GetExercisesByDomain(DateTime startDate, DateTime endDate)
        {
            var allExercises = _exerciseRepository.Get(startDate, endDate);

            return allExercises.GroupBy(c => c.Domain)
                    .Select(v => new ExerciseByInfo(v.Count(), v.First().Domain));
        }



    }
}

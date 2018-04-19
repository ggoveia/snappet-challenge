using SnappetChallenge.Model;
using System;
using System.Collections.Generic;

namespace SnappetChallenge.Service
{
    public interface IReportService
    {
        IEnumerable<ExerciseByInfo> GetExercisesBySubject(DateTime startDate, DateTime endDate);

        IEnumerable<ExerciseByInfo> GetExercisesByDomain(DateTime startDate, DateTime endDate);


    }
}

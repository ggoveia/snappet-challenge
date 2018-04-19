using Moq;
using Newtonsoft.Json;
using SnappetChallenge.Model;
using SnappetChallenge.Repository;
using SnappetChallenge.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SnappetChallengeTests
{
    public class ReportServiceTests
    {
        IReportService sut;
        Mock<IExerciseRepository> _exerciseRepository;

        public ReportServiceTests()
        {
            SetupMock();
            sut = new ReportService(_exerciseRepository.Object);
        }

        [Fact]
        public void CanGroupExercisesBySubject() {

            var result =  sut.GetExercisesBySubject(DateTime.Parse("2015-03-02"), DateTime.Parse("2015-03-02"));
            Assert.Equal(3, result.Count());
            
        }

        [Fact]
        public void CanGroupExercisesByDomain()
        {
            var result = sut.GetExercisesByDomain(DateTime.Parse("2015-03-02"), DateTime.Parse("2015-03-02"));
            Assert.Equal(4, result.Count());

        }

        [Fact]
        public void TotalByGroup()
        {
            var result = sut.GetExercisesBySubject(DateTime.Parse("2015-03-02"), DateTime.Parse("2015-03-02"));
            Assert.Equal(6, result.Sum(r => r.Quantity));

        }

        private void SetupMock() {

            _exerciseRepository = new Mock<IExerciseRepository>();

            _exerciseRepository.Setup(e => e.Get(It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(GetExerciseList());

        }

        private IEnumerable<Exercise> GetExerciseList() {

            return JsonConvert.DeserializeObject<IEnumerable<Exercise>>("[{\"SubmittedAnswerId\":2395278, \"SubmitDateTime\":\"2015-03-02T07:35:38.740\", \"Correct\":1, \"Progress\":0, \"UserId\":40281, \"ExerciseId\":1038396, \"Difficulty\":\"-200\", \"Subject\":\"Subject1\", \"Domain\":\"-\", \"LearningObjective\":\"Diverse leerdoelen Begrijpend Lezen\" }, " +
                "{ \"SubmittedAnswerId\":2396494, \"SubmitDateTime\":\"2015-03-02T07:36:48.530\", \"Correct\":1, \"Progress\":2, \"UserId\":40281, \"ExerciseId\":1029120, \"Difficulty\":\"329.2341931\", \"Subject\":\"Subject2\", \"Domain\":\"Domain1\", \"LearningObjective\":\"Diverse leerdoelen Begrijpend Lezen\" }, " +
                "{ \"SubmittedAnswerId\":2396638, \"SubmitDateTime\":\"2015-03-02T07:36:55.487\", \"Correct\":1, \"Progress\":0, \"UserId\":40282, \"ExerciseId\":1013670, \"Difficulty\":\"-200\", \"Subject\":\"Subject1\", \"Domain\":\"Domain1\", \"LearningObjective\":\"Diverse leerdoelen Begrijpend Lezen\" }, " +
                "{ \"SubmittedAnswerId\":2396696, \"SubmitDateTime\":\"2015-03-02T07:36:59.653\", \"Correct\":1, \"Progress\":2, \"UserId\":40281, \"ExerciseId\":1029121, \"Difficulty\":\"353.3972855\", \"Subject\":\"Subject2\", \"Domain\":\"Domain1\", \"LearningObjective\":\"Diverse leerdoelen Begrijpend Lezen\" }, " +
                "{ \"SubmittedAnswerId\":2397209, \"SubmitDateTime\":\"2015-03-02T07:37:24.030\", \"Correct\":1, \"Progress\":0, \"UserId\":40285, \"ExerciseId\":1038506, \"Difficulty\":\"-200\", \"Subject\":\"Subject3\", \"Domain\":\"Domain2\", \"LearningObjective\":\"Diverse leerdoelen Begrijpend Lezen\" }, " +
                "{ \"SubmittedAnswerId\":2397600, \"SubmitDateTime\":\"2015-03-02T07:37:43.500\", \"Correct\":0, \"Progress\":-10, \"UserId\":40285, \"ExerciseId\":1038509, \"Difficulty\":\"230.6971675\", \"Subject\":\"Subject3\", \"Domain\":\"Domain3\", \"LearningObjective\":\"Diverse leerdoelen Begrijpend Lezen\" }]");

        }
    }
}

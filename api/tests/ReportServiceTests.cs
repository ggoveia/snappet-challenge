using Moq;
using SnappetChallenge.Repository;
using SnappetChallenge.Service;
using Xunit;

namespace SnappetChallengeTests
{
    public class ReportServiceTests
    {
        IReportService sut;

        IMock<IExerciseRepository> _exerciseRepository;


        public ReportServiceTests()
        {
            _exerciseRepository = new Mock<IExerciseRepository>();
            sut = new ReportService(_exerciseRepository.Object);
        }

        [Fact]
        public void CanFilterExercisesBySubject() {
            

        }
    }
}

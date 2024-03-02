using coolOrange_CandidateChallenge;
using NUnit.Framework;

namespace coolOrange_CandidateChallengeTest
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        public void GetPriority_ReturnsCorrectPriority()
        {
            Task task = new Task("Test Task");
            task.setPriority(Priority.MED_PRIORITY);

            int priority = task.getPriority();

            Assert.AreEqual((int)Priority.MED_PRIORITY, priority);
        }

        [Test]
        public void SetComplexity_SetsCorrectComplexity()
        {
            Task task = new Task("Test Task");

            task.setComplexity(10);

            Assert.AreEqual(10, task.getComplexity());
        }

        [Test]
        public void CompareTo_CompareTwoTasks_CompareBasedOnComplexity()
        {
            Task task1 = new Task("Task 1");
            Task task2 = new Task("Task 2");

            task1.setComplexity(5);
            task2.setComplexity(10);

            int result = task1.CompareTo(task2);

            Assert.AreEqual(-1, result);
        }
    }
}

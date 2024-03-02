using System;

namespace coolOrange_CandidateChallenge
{
    /// <summary>
    /// Represents the priority levels that can be assigned to a task.
    /// </summary>
    public enum Priority
    {
        MIN_PRIORITY = 1,  // Minimum priority level
        MED_PRIORITY = 5,  // Medium priority level
        MAX_PRIORITY = 10  // Maximum priority level
    }

    /// <summary>
    /// Defines methods to set and retrieve the priority of an object.
    /// </summary>
    public interface IPriority
    {
        /// <summary>
        /// Sets the priority of the object.
        /// </summary>
        /// <param name="priority">The priority level to be set.</param>
        void setPriority(Priority priority);

        /// <summary>
        /// Retrieves the priority of the object.
        /// </summary>
        /// <returns>The priority level of the object.</returns>
        int getPriority();
    }

    /// <summary>
    /// Defines methods to set and retrieve the complexity of an object.
    /// </summary>
    public interface IComplexity
    {
        /// <summary>
        /// Sets the complexity of the object.
        /// </summary>
        /// <param name="complexity">The complexity value to be set.</param>
        void setComplexity(int complexity);

        /// <summary>
        /// Retrieves the complexity of the object.
        /// </summary>
        /// <returns>The complexity value of the object.</returns>
        int getComplexity();
    }

    /// <summary>
    /// Represents a task with a name, priority, and complexity.
    /// </summary>
    public class Task : IPriority, IComplexity, IComparable
    {
        private String name;
        private Priority priority;
        private int complexity;

        /// <summary>
        /// Initializes a new instance of the Task class with the specified name.
        /// </summary>
        /// <param name="name">The name of the task.</param>
        public Task(String name)
        {
            this.name = name;
            this.priority = Priority.MED_PRIORITY;
            this.complexity = 0;
        }

        /// <summary>
        /// Retrieves the name of the task.
        /// </summary>
        /// <returns>The name of the task.</returns>
        public String getName()
        {
            return this.name;
        }

        /// <summary>
        /// Sets the priority of the task.
        /// </summary>
        /// <param name="priority">The priority level to be set.</param>
        public void setPriority(Priority priority)
        {
            this.priority = priority;
        }

        /// <summary>
        /// Retrieves the priority of the task.
        /// </summary>
        /// <returns>The priority level of the task.</returns>
        public int getPriority()
        {
            return (int)priority;
        }

        /// <summary>
        /// Sets the complexity of the task.
        /// </summary>
        /// <param name="complexity">The complexity value to be set.</param>
        public void setComplexity(int complexity)
        {
            this.complexity = complexity;
        }

        /// <summary>
        /// Retrieves the complexity of the task.
        /// </summary>
        /// <returns>The complexity value of the task.</returns>
        public int getComplexity()
        {
            return this.complexity;
        }

        /// <summary>
        /// Compares this task with another task based on their complexity.
        /// </summary>
        /// <param name="obj">The task to compare with this task.</param>
        /// <returns>
        /// A value indicating the relative order of the tasks.
        /// Returns a negative integer if this task has lower complexity than the other task,
        /// zero if both tasks have the same complexity, or a positive integer otherwise.
        /// </returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (!(obj is Task otherTask))
            {
                throw new ArgumentException("Object is not a Task");
            }

            return this.complexity.CompareTo(otherTask.complexity);
        }
    }
}

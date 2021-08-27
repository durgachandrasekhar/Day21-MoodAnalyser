using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyserCustomException : Exception
    {
        /// <summary>
        /// /Enum for exception type
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_FILES, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        /// <summary>
        /// The type/creating type variable
        /// </summary>
        private readonly ExceptionType type;
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyserCustomException"/> class.
        /// </summary>
        /// <param name="Type">The type.</param>
        /// <param name="message">The message.</param>
        public MoodAnalyserCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }

}
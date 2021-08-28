using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyserUsingReflection
{
    public class MoodAnalyser
    {
        public static object CreateMoodAnalyseUsingParameters(string className, string constructorName, string message)
        {
            Type type = typeof(Mood);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructor.Invoke(new object[] { "Happy" });
                    return instance;
                }
                else
                {
                    throw new CustomAnalyse(CustomAnalyse.ExceptionType.NO_SUCH_METHOD, "Constructor not found");
                }
            }
            else
            {
                throw new CustomAnalyse(CustomAnalyse.ExceptionType.NO_SUCH_CLASS, "Class not found");
            }
        }
        public string InvokeMethod(string methodName, string message)
        {
            try
            {
                Type type = typeof(Mood);
                MethodInfo method = type.GetMethod(methodName);

                object MoodAnalayserObject = MoodAnalyser.CreateMoodAnalyseUsingParameters("Mood", "Mood", "Happy");
                object MethodObject = method.Invoke(MoodAnalayserObject, null);
                return MethodObject.ToString();
            }
            catch (NullReferenceException e)
            {
                throw new CustomAnalyse(CustomAnalyse.ExceptionType.NO_SUCH_METHOD, "No such Method");
            }
        }
    }
}

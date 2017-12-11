using System;

namespace Esendex.Voice.Sdk
{
    public interface IAnswerphoneOptions
    {
        Guid DoNotCallAnyOtherNumbers { get; }
        Guid ContinueWithOtherContactNumbers { get; }
    }

    public class AnswerphoneOptions : IAnswerphoneOptions
    {
        public Guid DoNotCallAnyOtherNumbers => Guid.Parse("7D14DF0F-8EC5-469E-B683-2A0514B5688D");
        public Guid ContinueWithOtherContactNumbers => Guid.Parse("29204019-EF3E-40E6-9E56-B81C3981336F");
    }
}
using System;

namespace Esendex.Voice.Sdk
{
    public interface ICallRetryOptions
    {
        Guid AttemptAllNumbersThatHaveNotBeenDialledBeforeAttemptingRetried { get; }
        Guid EnsureScheduledRetriedAreMadeAtTheCorrectTime { get; }
    }

    public class CallRetryOptions : ICallRetryOptions
    {
        public Guid AttemptAllNumbersThatHaveNotBeenDialledBeforeAttemptingRetried => Guid.Parse("BAAD61F0-E526-454B-B093-0280161BAE25");
        public Guid EnsureScheduledRetriedAreMadeAtTheCorrectTime => Guid.Parse("F6DB0CD6-2CCD-4F50-975F-E136CEACA129");
    }
}
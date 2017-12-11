using System;

namespace Esendex.Voice.Sdk
{
    public interface IBlacklistSetting
    {
        Guid DoNotStopSmsBasedOnVoiceMessageResult { get; }
        Guid BlacklistNumberThatIsAnswered { get; }
        Guid BlacklistAllNumbersWhenAnsweredByPerson { get; }
        Guid BlacklistAllNumbersWhenAnsweredByPersonOrAnswerPhone { get; }
        Guid BlacklistTheNumberAnsweredByPerson { get; }
    }

    public class BlacklistSetting : IBlacklistSetting
    {
        public Guid DoNotStopSmsBasedOnVoiceMessageResult => Guid.Parse("5D481FAE-2A98-4E23-8569-49FDD140CBAA");
        public Guid BlacklistNumberThatIsAnswered => Guid.Parse("EC400D50-1DAF-458A-B3BD-737E89DACC49");
        public Guid BlacklistAllNumbersWhenAnsweredByPerson => Guid.Parse("DDD600E7-954F-4C58-95A8-A7DB32BA664F");
        public Guid BlacklistAllNumbersWhenAnsweredByPersonOrAnswerPhone => Guid.Parse("9A8451A2-6226-439C-B1F9-AA00A260F988");
        public Guid BlacklistTheNumberAnsweredByPerson => Guid.Parse("9E5FB8B3-2CBC-4883-A248-F40545F71162");
    }
}

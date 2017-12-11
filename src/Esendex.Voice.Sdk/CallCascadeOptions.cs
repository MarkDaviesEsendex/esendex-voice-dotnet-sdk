using System;

namespace Esendex.Voice.Sdk
{
    public interface ICallCascadeOptions
    {
        Guid CallHighestPriorityNumberForEachRecordFirstBeforeMovingOnToNextPriority { get; }
        Guid CallAllNumbersInEachRecordsBeforeMocingToTheNextRecord { get; }
    }

    public class CallCascadeOptions : ICallCascadeOptions
    {
        public Guid CallHighestPriorityNumberForEachRecordFirstBeforeMovingOnToNextPriority => Guid.Parse("4A79A803-38D1-4700-B09F-10C16EC2434A");
        public Guid CallAllNumbersInEachRecordsBeforeMocingToTheNextRecord => Guid.Parse("7A9231B3-5628-4817-8B18-93C1FBDF368D");
    }
}
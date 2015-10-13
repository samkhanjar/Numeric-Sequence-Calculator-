using System.Collections.Generic;

namespace NumricSequenceCalculator.Interfaces
{
    public interface ISequence
    {
        List<int> EvenSequence(int number);
        List<int> OddSequence(int number);
        List<int> AllNumbers(int number);
        List<string> AllNumbersMultipleOf(int number);
        List<int> FabonacciSequence(int number);
    }
}

namespace Workshops_TDD
{
    public interface INumberConverter
    {
        void ConvertToRomeSymbols(int numberToConvert, out string ancientRomeNumbers);
    }
}
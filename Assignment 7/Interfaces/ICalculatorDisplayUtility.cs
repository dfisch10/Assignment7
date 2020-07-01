namespace Assignment_7
{
    public interface ICalculatorDisplayUtility
    {

        void Menu(bool menuRecall, ICalculator calculator) { }
        void ConvertStringToInt() { }
        void CompareUserInputToAcceptedOptionsList() { }
        void handleUserInput(ICalculator calculator) { }
        void receiveMenuOption() { }
        void receiveUserInputForOperand() { }
        void outputDisplay() { }
        void receiveInput() { }
        void errorMessageDisplay() { }
        void receiveOperandAmount() { }
    }
}
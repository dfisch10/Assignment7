namespace Assignment_7
{
    public interface ICalculatorDisplayUtility
    {
        #region Methods

        /// <summary>
        /// This method displays the Menu options, and activates the appropriate option/methods depending on the user Input.
        /// </summary>
        /// <param name="menuRecall">Initialized at true and then returns true/false depending if the menu should be recalled or not after selection made (or if calculator object is null).</param>
        /// <param name="calculator">Generates a Calculator object to utilize calculator methods (add, subtract, multiply, and divide) as part of user input handling.</param>
        void Menu(bool menuRecall, ICalculator calculator) { }

        /// <summary>
        /// Changes user inputs, which are in string format due to Console.ReadLine(), and then converts them to int type
        /// </summary>
        /// <param name="input">The string input that is entered by the user at prompt.</param>
        /// <returns>Converts and returns the user inputted string value as type int.</returns>
        void ConvertStringToInt() { }

        /// <summary>
        /// Compares the user's input, to a list of acceptable options, based off of the menu options (1-5), then returns if the input is valid or not (true or false).
        /// </summary>
        /// <param name="input">The string input that is entered by the user at prompt.</param>
        /// <param name="inputOptions">The List of valid inputs allowed to activate the menu options.</param>
        /// <returns>Returns true/false depending on if the user inputted value is on of the accepted values from the valid input options.</returns>
        void CompareUserInputToAcceptedOptionsList() { }

        /// <summary>
        /// Determines what cases/procedures to run based off of the option the user selected from the menu. Also throws error message if value entered is null, or not one of the accepted case values.
        /// </summary>
        /// <param name="calculator">Object creation to utilize/call the Calculator class methods dependent on which option was chosen.</param>
        /// <returns>Returns true/false based of the user inputted menu option to determine if the menu should be recalled or not.</returns>
        void handleUserInput(ICalculator calculator) { }

        /// <summary>
        /// Takes in the user input after the menu prompt, and checks it against the valid input options. Throws error message if not one of the valid optioons.
        /// </summary>
        /// <returns>Returns converted user input from string type to int type, or throws error message if input was invalid.</returns>
        void receiveMenuOption() { }

        /// <summary>
        /// Checks the user inputted values for the mathematical operands to ensure they are not null/empty, and that they only entered numerical characters. Then converts the input to type int and returns it.
        /// </summary>
        /// <returns>Returns converted user input from string type to int type for entered operands, or throws error message if input was invalid.</returns>
        void receiveUserInputForOperand() { }

        /// <summary>
        /// Changes the foreground color of the answer line to Cyan, then resets the console color back to default after displaying the answer line.
        /// </summary>
        /// <param name="result"> The resulting sum, difference, product, or quotient after the two operands have utilized the specified mathmatical operator. </param>
        void outputDisplay() { }

        /// <summary>
        /// Takes in the user input for the menu options.
        /// </summary>
        /// <returns>Returns the user input as a string type via Console.ReadLine()</returns>
        void receiveInput() { }

        /// <summary>
        /// Displays a custom error message that is passed into the method, and changes the foreground color of that message to dark red. It then resets the console foreground color to its default after being displayed. 
        /// </summary>
        /// <param name="errorMessage">A custom string type message passed into the method.</param>
        void errorMessageDisplay() { }

        /// <summary>
        /// Prompts the user for the amount of operands(numbers) they would like to use to do their designated calculation.
        /// </summary>
        /// <returns>Returns the user input as a string type via Console.ReadLine()</returns>
        void receiveOperandAmount() { }
        #endregion
    }
}
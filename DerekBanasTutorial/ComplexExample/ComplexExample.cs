namespace LearningCSharp.DerekBanasTutorial.ComplexExample
{
    class ComplexExample
    {
        public ComplexExample()
        {
            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powerButton = new PowerButton(TV);

            powerButton.Execute();
            powerButton.Undo();

            powerButton.Execute();
            powerButton.Undo();
        }
    }
}
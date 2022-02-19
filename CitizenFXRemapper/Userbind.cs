namespace CitizenFXRemapper
{
    internal class Userbind
    {
        private string action;
        private string inputMethod;
        private string key;
        private string result;

        public Userbind(string action, string inputMethod, string key, string result)
        {
            this.action = action;
            this.inputMethod = inputMethod;
            this.key = key;
            this.result = result;
        }
    }
}
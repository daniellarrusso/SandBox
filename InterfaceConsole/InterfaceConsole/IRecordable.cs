namespace InterfaceConsole
{
    interface IRecordable
    {
        void Record(string test);
        string Name { get; set; }
        
    }
}
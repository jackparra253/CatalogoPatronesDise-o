namespace Person.Domain
{
    public class IdInfo
    {
        public int IdNumber { get; private set; }

        public IdInfo(int idNumber)
        {
            IdNumber = idNumber;
        }
    }
}

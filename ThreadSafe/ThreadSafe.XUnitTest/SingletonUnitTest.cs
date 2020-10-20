using ThreadSafe.Domain;
using Xunit;

namespace ThreadSafe.XUnitTest
{
    public class SingletonUnitTest
    {
        [Fact (DisplayName = "Should GetInstance return new instance and value")]
        public void Singleton_Case_GetInstance()
        {
            var value = "Hi singleton";

            var singleton = Singleton.GetIntance(value);

            Assert.Equal(value, singleton.Value);
        }
    }
}

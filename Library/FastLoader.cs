using System.Threading;

namespace task8_26
{
    public class FastLoader : ITechnics
    {
        public void Tech()
        {
            Thread.Sleep(1000);
        }
    }
}

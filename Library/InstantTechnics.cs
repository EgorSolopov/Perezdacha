using System.Threading;

namespace task8_26
{
    public class InstantTechnics : ITechnics
    {
        public void Tech()
        {
            Thread.Sleep(1);
        }
    }
}

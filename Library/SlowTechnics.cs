using System.Threading;

namespace task8_26
{
    public class SlowTechnics : ITechnics
    {
        public void Tech()
        {
            Thread.Sleep(5000);
        }
    }
}

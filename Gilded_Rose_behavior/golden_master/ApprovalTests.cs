using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;

namespace Gilded_Rose_behavior.golden_master
{
    internal class ApprovalTests
    {
        [UseReporter(typeof(DiffReporter))]
        [TestFixture]
        public class ApprovalTest
        {
            [Test]
            public void ThirtyDays()
            {
                StringBuilder fakeoutput = new StringBuilder();
                Console.SetOut(new StringWriter(fakeoutput));
                Console.SetIn(new StringReader("a\n"));

                GildedRoseConsole.Program.Main(new string[] { });

                var output = fakeoutput.ToString();
                Approvals.Verify(output);
            }
        }
    }
}

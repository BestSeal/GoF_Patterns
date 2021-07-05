using System.Threading;

namespace Interpreter
{
    public class HyphenDash : BaseInterpreter
    {
        public HyphenDash(Context context) : base(context, " - ", " — ")
        {
        }
    }
}
namespace Interpreter
{
    public class MultipleSpaces : BaseInterpreter
    {
        public MultipleSpaces(Context context) : base(context, " +", " ")
        {
        }
    }
}
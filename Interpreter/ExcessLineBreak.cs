using System;

namespace Interpreter
{
    public class ExcessLineBreak : BaseInterpreter
    {
        public ExcessLineBreak(Context context) : base(context, "\n+", "\n")
        {
        }


    }
}
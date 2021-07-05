namespace Interpreter
{
    public class ExcessSpace : BaseInterpreter
    {
        public ExcessSpace(Context context) : base(context, "", "")
        {
        }

        public override void Correct()
        {
            _context.Value = _context.Value.Replace("( ", "(");
            _context.Value = _context.Value.Replace(" )", ")");
            _context.Value = _context.Value.Replace(" ,", ",");
            _context.Value = _context.Value.Replace(" .", ".");
        }
    }
}
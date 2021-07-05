using System.Linq;
using System.Text;

namespace Interpreter
{
    public class Quotes : BaseInterpreter
    {
        public Quotes(Context context) : base(context, "", "")
        {
            
        }
        
        public override void Correct()
        {
            while (_context.Value.Count(x => x == '\"') > 1)
            {
                var result = new StringBuilder(_context.Value);
                var isFound = false;
                
                for (var i = 0; i < result.Length; i++)
                {
                    if (result[i] == '\"')
                    {
                        if (isFound)
                        {
                            result[i] = '»';
                            break;
                        }
                        else
                        {
                            result[i] = '«';
                            isFound = true;
                        }
                    }
                }
                _context.Value = result.ToString();
            }
        }
    }
}
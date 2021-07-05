using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Interpreter
{
    public class BaseInterpreter
    {
        protected readonly Context _context;
        protected Regex _replaceRule;
        protected string _replace;
        private readonly List<BaseInterpreter> _rules;
        
        public BaseInterpreter(string context)
        {
            _context = new Context();
            _context.Value = context;
            _rules = new List<BaseInterpreter>();
            _rules.Add(new ExcessSpace(_context));
            _rules.Add(new Quotes(_context));
            _rules.Add(new Tabs(_context));
            _rules.Add(new MultipleSpaces(_context));
            _rules.Add(new HyphenDash(_context));
            _rules.Add(new ExcessLineBreak(_context));
        }

        public BaseInterpreter(Context context, string replaceRule, string replace)
        {
            _context = context;
            _replaceRule = new Regex(replaceRule, RegexOptions.Compiled | RegexOptions.Multiline);
            _replace = replace;
        }

        public virtual void Correct()
        {
            _context.Value = _replaceRule.Replace(_context.Value, _replace);
        }
        
        public virtual void Interpret()
        {
            var initContext = "";
            while (initContext != _context.Value)
            {
                initContext = _context.Value;
                foreach (var rule in _rules)
                {
                    rule.Correct();
                }
            }
        }

        public string GetResult()
            => _context.Value;
    }
}
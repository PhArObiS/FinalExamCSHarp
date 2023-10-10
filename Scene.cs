using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeilLopes_FinalExamOOP
{
    public abstract class Scene
    {
        public abstract void Describe();
        public abstract ConsoleKey PresentChoices();
        public abstract Scene HandleChoices(ConsoleKey key, Hero hero); 
    }
}

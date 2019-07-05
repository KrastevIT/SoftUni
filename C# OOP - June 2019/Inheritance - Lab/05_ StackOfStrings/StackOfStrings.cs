using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        private StackOfStrings stack;

        public StackOfStrings()
        {

        }

        public bool IsEmpty()
        {
            if (stack == null)
            {
                return false;
            }

            return true;
        }

        public void AddRange(List<string> items)
        {
            foreach (var item in items)
            {
                stack.Push(item);
            }
        }
    }
}

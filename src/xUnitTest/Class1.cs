using System;

namespace xUnitTest
{
    public class Class1
    {
        public void Success()
        {

        }

        public void Throw()
        {
            throw new Exception("this is exception");
        }

        public bool BoolExec(bool value)
        {
            return value;
        }
    }
}

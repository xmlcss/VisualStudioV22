//Add方法
using OperationLib;
namespace Addlib
{
    public class Add : Operation
    {
        public Add(int n1, int n2) : base(n1, n2) { }
        public override string Type
        { get { return "+"; } }

    public override int GetResult()
        {
        return this.NumberOne + this.NumberTwo;
        }
    }

    public class Sub : OperationLib.Operation
    {
        public Sub(int n1, int n2) : base(n1, n2) { }
        public override string Type
        { get { return "-"; } }

        public override int GetResult()
        {
            return this.NumberOne - this.NumberTwo;
        }
    }
}

using System;

namespace Cha4PolymorphicEx
{
    #region:接口定义
    //修饰符 interface 接口名称:继承的接口列表
    /// <summary>
    /// IBankAccount接口，限定存款、取款以及存款金额
    /// </summary>
    public interface IBankAccount
    {
        //接口的内容
        void PayIn(decimal amount);//存款
        bool Withdraw(decimal amount);//取款
        decimal Balance { get; }
    }

    //接口也可以彼此继承
    /// <summary>
    /// 转账接口，限定转账行为
    /// </summary>
    interface ITransferBankAccount : IBankAccount
    {
        bool TransferTo(IBankAccount destination, decimal amount);
    }
    #endregion

    /// <summary>
    /// 银行账户类SaverAccount
    /// </summary>
    class SaverAccount : IBankAccount
    {
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
        }

        public void PayIn(decimal amount)
        {
            _balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                return true;
            }
            Console.WriteLine("withdraw is failed");
            return false;
        }
    }
}

//WageSystem.cs--公司工资系统（WageSystem）设计及实现
//知识点：多态实现
//需求描述------------------------------------------------------------------------------------------------------------------------------
/*
 在一个公司中，有四种类型的员工，包括固定工，计时工，佣金员工，底薪佣金员工。他们的工资计算方式如下：
佣金员工：按照销售额百分比提成。佣金比例*总销售额
抽成员工：佣金+底薪，即：佣金比例*总销售额+底薪
固定工资员工：周薪相同，
计时工：按时计酬，工作时间<=40,:每小时钱*小时数，工作时间>40，按1.5倍计算
公司每周给员工发放工资，请编程实现该工资系统。

扩展：公司工资系统-加入发票功能
 ----------------------------------------------------------------------------------------------------------------------------------------*/
namespace Cha4PolymorphicEx
{
    #region：基类Employee第一版：未引入发票功能时
    ////抽象基类Employee
    //public abstract class Employee
    //{
    //    public string FirstName { get; private set; }
    //    public string LastName { get; private set; }
    //    public string SocialNumber { get; private set; }

    //    public Employee(string name, string lName, string sn)
    //    {
    //        FirstName = name;
    //        LastName = lName;
    //        SocialNumber = sn;
    //    }
    //    public abstract decimal Earnings();
    //    public override string ToString()
    //    {
    //        return $"{FirstName} {LastName}\n" + $"social security number:{SocialNumber}";
    //    }
    //}
    #endregion

    #region：基类Employee第二版：引入发票类时，需实现IPayable接口中的定义
    public abstract class Employee : IPayable
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string SocialNumber { get; private set; }

        public Employee(string name, string lName, string sn)
        {
            FirstName = name;
            LastName = lName;
            SocialNumber = sn;
        }
        public abstract decimal Earnings();
        public override string ToString()
        {
            return $"{FirstName} {LastName}\n" + $"social security number: {SocialNumber}";
        }
        public decimal GetPaymentAmount() => Earnings();
    }
    #endregion

    //固定工-周薪相同
    public class SalariedEmployee : Employee
    {
        public decimal WeeklySalary { get; set; }

        public SalariedEmployee(string first, string last, string sn, decimal salary)
               : base(first, last, sn)
        {
            WeeklySalary = salary;
        }
        public override decimal Earnings()
        {
            return WeeklySalary;
        }
    }

    //小时工-按时计酬
    public class HourlyEmployee : Employee
    {
        public decimal Wage { get; set; }
        public decimal Hours { get; set; }
        public HourlyEmployee(string first, string last, string sn, decimal wg, decimal ho)
                   : base(first, last, sn)
        {
            Wage = wg;
            Hours = ho;
        }
        public override decimal Earnings()
        {
            if (Hours <= 40)
                return Wage * Hours;
            else
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
        }
    }

    //佣金员工-按照销售额百分比提成
    public class CommisionEmployee : Employee
    {
        public decimal GrossSales { get; set; }
        public decimal CommissionRate { get; set; }

        public CommisionEmployee(string first, string last, string ssn, decimal sales, decimal rate) : base(first, last, ssn)
        {
            GrossSales = sales;
            CommissionRate = rate;
        }

        public override decimal Earnings()
        {
            return CommissionRate * GrossSales;
        }
    }

    //抽成员工-佣金+底薪
    public class BasePlusCommisionEmployee : CommisionEmployee
    {
        public decimal BaseSalary { get; set; }

        public BasePlusCommisionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
            : base(first, last, ssn, sales, rate)
        {
            BaseSalary = salary;
        }

        public override decimal Earnings()
        {
            return BaseSalary + base.Earnings();
        }
    }

    //IPayable接口
    public interface IPayable
    {
        decimal GetPaymentAmount();
    }

    //发票类
    public class Invoice : IPayable
    {
        public string PartNumber { get; }
        public string PartDescription { get; }
        private int quantity;//数量
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Quantity)} must be >=0");
                }
                quantity = value;
            }
        }
        private decimal pricePerItem;//单价
        public decimal PricePerItem
        {
            get { return pricePerItem; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PricePerItem)} must be >=0");
                }
                pricePerItem = value;
            }
        }

        public Invoice(string pn, string pd, int qt, decimal ppi)
        {
            PartNumber = pn;
            PartDescription = pd;
            Quantity = qt;
            PricePerItem = ppi;
        }
        public decimal GetPaymentAmount() => Quantity * PricePerItem;
        public override string ToString()
        {
            return $"invoice:\n part number: {PartNumber} ({PartDescription})\n" +
                $"quantity: {Quantity} , price per item: {PricePerItem}";
        }
    }

    //测试类
    public class Test
    {
        static void Main(string[] args)
        {
            //var employee = new CommisionEmployee("sue", "john", "111", 1000M, 0.06M);

            //Console.WriteLine("employee information::");
            //Console.WriteLine($"First name is {employee.FirstName}");
            //Console.WriteLine($"Last name is {employee.LastName}");
            //Console.WriteLine($"earnings:{employee.Earnings()}");

            //var employee1 = new BasePlusCommisionEmployee("Bob", "Lewis", "666", 3000M, 0.04M, 300M);
            //Console.WriteLine("employee1 information::");
            //Console.WriteLine($"First name is {employee1.FirstName}");
            //Console.WriteLine($"Last name is {employee1.LastName}");
            //Console.WriteLine($"earnings:{employee1.Earnings()}");

            //CommisionEmployee ce = employee1;
            //Console.WriteLine(ce.ToString());
            //Console.WriteLine(ce.Earnings());

            #region 引入发票之后的 多态调用
            var payableObjects = new List<IPayable>()
            {
               new Invoice("001","seat",2,275M),
               new Invoice("006","tire",4,80M),
               new SalariedEmployee("John","Smith","111",800M),
               new SalariedEmployee("Lisa","Bar","222",1000M)
            };

            Console.WriteLine("Invoices and Employees processed polymorphically:\n");
            foreach (var payable in payableObjects)
            {
                Console.WriteLine($"{payable}");
                Console.WriteLine($"payment due :{payable.GetPaymentAmount():C}\n");
            }
            #endregion
            Console.ReadKey();
        }
    }
}

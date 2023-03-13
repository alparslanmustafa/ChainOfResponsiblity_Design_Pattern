using ChainOfResponsiblity_Design_Pattern.DAL.Entities;
using ChainOfResponsiblity_Design_Pattern.DAL;

namespace ChainOfResponsiblity_Design_Pattern.ChainOfResponsiblityDesignPattern
{
    public class AreaDirector : Employee
    {
        Context context = new Context();
        public override void ProcessRequest(WithDraw req)
        {
            if (req.Amount <= 150000)
            {
                CustomerProccess customerProcess = new CustomerProccess();
                customerProcess.Amount = req.Amount;
                customerProcess.EmployeeTitle = this.GetType().Name;
                customerProcess.EmployeeName = "Gizem Öztürk";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, müşteriye ödeme yapıldı";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProccess customerProcess = new CustomerProccess();
                customerProcess.Amount = req.Amount;
                customerProcess.EmployeeTitle = this.GetType().Name;
                customerProcess.EmployeeName = "Gizem Öztürk";
                customerProcess.Description = "Limit Günlük Para Çekme Tutarını Aştığı İçin İşlem Onaylanamadı";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}

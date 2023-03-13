namespace ChainOfResponsiblity_Design_Pattern.ChainOfResponsiblityDesignPattern
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee supervisor)
        {
            this.NextApprover = supervisor;
        }
        public abstract void ProcessRequest(WithDraw req);
    }
}

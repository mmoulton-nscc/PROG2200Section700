using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public interface IWorker
    {
        string CalculateWeeklySalary(int weeklyHours, int wage);
    }
}

using System;
using System.Threading.Tasks;
using Quartz;

public class ShowDateTimeJob : IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        var now = DateTime.Now.ToString("HH : mm : ss");
        Console.WriteLine($" Merhaba, saat şuan {now}");
        return Task.CompletedTask;
    }
}
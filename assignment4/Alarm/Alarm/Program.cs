using System;

class Alarm
{
    //定义滴答事件
    public event EventHandler Tick;
    //定义响铃事件
    public event EventHandler AlarmRing;

    public void Start()
    {
        //模拟闹钟走时
        for(int i=0;i<10;i++)
        {
            OnTick(EventArgs.Empty);
            System.Threading.Thread.Sleep(1000);
        }
        //触发响铃时间
        OnAlarmRing(EventArgs.Empty);
    }
    protected virtual void OnTick(EventArgs e)
    {
        //触发滴答事件，并显示在控制台
        Tick.Invoke(this, e);
        Console.WriteLine("闹钟在走时");
    }
    protected virtual void OnAlarmRing(EventArgs e)
    {
        //触发响铃事件，并显示在控制台
        AlarmRing.Invoke(this, e);
        Console.WriteLine("闹钟响铃啦，该起床了");
    }
}

class Program
{
    static void Main()
    {
        Alarm alarm = new Alarm();
        //订阅滴答事件
        alarm.Tick += (sender, args) =>
        {
            Console.WriteLine();
        };
        //订阅响铃事件
        alarm.AlarmRing += (sender, args) =>
        {
            Console.WriteLine();
        };
        alarm.Start();
        Console.ReadLine();
    }
}
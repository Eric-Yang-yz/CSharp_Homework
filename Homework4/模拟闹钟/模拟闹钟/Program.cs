using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_2
{
    public delegate void ClockTick(object sender,TimeArgs args);
    public delegate void ClockAlarm(object sender,TimeArgs args);//声明两个委托类型

    public class TimeArgs
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
    }

    public class AlarmClock//事件发布类
    {
        public event ClockTick Tick;
        public event ClockAlarm Alarm;//定义事件
        public void Run(TimeArgs AlarmTime)//闹钟启动
        {
            TimeArgs CurrentTime = new TimeArgs() { hour = 0, minute = 0, second = 0 };//当前时间
            while (true)
            {
                if (IsTime(AlarmTime,CurrentTime))Alarm(this,AlarmTime);
                Tick(this,CurrentTime);
                System.Threading.Thread.Sleep(1000);
            }
        }
        public bool IsTime(TimeArgs a,TimeArgs b)
        {
            return a.hour == b.hour && a.minute == b.minute && a.second == b.second;
        }
    }

    public class MyAlarmClock
    {
        public AlarmClock Clock1 = new AlarmClock();
        public MyAlarmClock()//订阅事件
        {
            Clock1.Tick += MyTick;
            Clock1.Alarm += MyAlarm;
        }
        void MyTick(object sender,TimeArgs args)
        {
            Console.WriteLine("当前时间：[" + args.hour + ":" + args.minute + ":" + args.second + "]");
            if (args.second < 59) args.second++;
            else
            {
                args.second = 0;
                args.minute++;
                if (args.minute == 60)
                {
                    args.minute = 0;
                    args.hour = (args.hour + 1) % 24;
                }
            }
            
        }
        void MyAlarm(object sender,TimeArgs args)
        {
            for (int i=0;i<10;i++)
            Console.WriteLine("滴!滴!滴!滴!滴!滴!滴!滴!滴!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyAlarmClock CLK = new MyAlarmClock();
            TimeArgs AlarmTime = new TimeArgs()
            {
                hour = 0,
                minute = 1,
                second = 0
            };
            CLK.Clock1.Run(AlarmTime);
        }
    }
}

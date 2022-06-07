namespace Age // Form1.cs
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public DateTime start;
        //public bool opened=false;
        public Form1()
        {
            InitializeComponent();
            instance=this;
        }
        private void button2_Click(object sender,EventArgs e)
        {
            Settings sett=new();
            sett.Show();
        }
        private void Copy_Click(object sender,EventArgs e)
        {
            if(Output.Text.Length>0)Clipboard.SetText(Output.Text);
        }
        private void timer1_Tick(object sender,EventArgs e)
        {
            decimal completedYears=0,divide,elapsedSeconds=0;
            DateTime destination=DateTime.Now; // make it to work
            //DateTime destination=new(2022,6,7,13,17,5); // for testing purposes, to be deleted
            
            int startMonth=start.Month,startDay=start.Day,startHour=start.Hour,startMinute=start.Minute,startSecond=start.Second;
            if(destination.Month>startMonth||destination.Month==startMonth&&(destination.Day>startDay||destination.Day==startDay&&(destination.Hour>start.Hour||destination.Hour==start.Hour&&(destination.Minute>start.Minute||destination.Second>start.Second)))) // I am after a birthday already in this year
            {
                completedYears+=destination.Year-start.Year;
                if(startMonth==destination.Month)
                {
                    elapsedSeconds=86400*(destination.Day-start.Day);
                    if(destination.Hour<start.Hour)
                    {
                        elapsedSeconds-=86400;
                        elapsedSeconds+=3600*(destination.Hour+24-start.Hour);
                    }
                    else elapsedSeconds+=3600*(destination.Hour-start.Hour);
                    if(destination.Minute<start.Minute)
                    {
                        elapsedSeconds-=3600;
                        elapsedSeconds+=60*(destination.Minute+60-start.Minute);
                    }
                    else elapsedSeconds+=60*(destination.Minute-start.Minute);
                    elapsedSeconds+=destination.Second-start.Second;
                }
                else
                {
                    elapsedSeconds+=goToMonthEnd(startMonth++,startDay,startHour,startMinute,startSecond,DateTime.IsLeapYear(destination.Year));
                    while(start.Month<destination.Month)elapsedSeconds+=goToMonthEnd(startMonth++,1,0,0,0,DateTime.IsLeapYear(destination.Year));
                    elapsedSeconds+=86400*(destination.Day-start.Day);
                    if(destination.Hour<start.Hour)
                    {
                        elapsedSeconds-=86400;
                        elapsedSeconds+=3600*(destination.Hour+24-start.Hour);
                    }
                    else elapsedSeconds+=3600*(destination.Hour-start.Hour);
                    if(destination.Minute<start.Minute)
                    {
                        elapsedSeconds-=3600;
                        elapsedSeconds+=60*(destination.Minute+60-start.Minute);
                    }
                    else elapsedSeconds+=60*(destination.Minute-start.Minute);
                    elapsedSeconds+=destination.Second-start.Second;
                }
            }
            else // I had birthday in previous year, next birthday this year ahead of me
            {
                Int32 destinationMonth=1;
                completedYears+=destination.Year-1-start.Year;
                elapsedSeconds+=goToYearEnd(startMonth,startDay,startHour,startMinute,startSecond,DateTime.IsLeapYear(destination.Year-1));
                while(destinationMonth<destination.Month)elapsedSeconds+=goToMonthEnd(destinationMonth++,1,0,0,0,DateTime.IsLeapYear(destination.Year));
                elapsedSeconds+=86400*(destination.Day-1)+3600*destination.Hour+60*destination.Minute+destination.Second;
            }
            if((DateTime.IsLeapYear(destination.Year)&&destination.Month>2||(destination.Month==2&&destination.Day==29))||(DateTime.IsLeapYear(destination.Year-1)&&destination.Month<=2))divide=31622400;
            else divide=31536000;
            Output.Text=Convert.ToString(Math.Round(elapsedSeconds/divide+completedYears,7));
        }
        /// <summary>
        /// Returns seconds to the end of a month
        /// </summary>
        /// <param name="month">The month you want to calculate in</param>
        /// <param name="day">From which day you want to start calculating</param>
        /// <param name="hour">From which hour</param>
        /// <param name="minute">and minute</param>
        /// <param name="second">...and second</param>
        /// <param name="isLeap">Whether we should consider February as 28 or 29 days</param>
        /// <returns>Amount of seconds</returns>
        private uint goToMonthEnd(int month,int day,int hour, int minute,int second,bool isLeap)
        {
            uint result=0,maxReach;
            if(month==1||month==3||month==5||month==7||month==8||month==10||month==12)maxReach=31;
            else if(month==4||month==6||month==9||month==11)maxReach=30;
            else if(isLeap)maxReach=29;
            else maxReach=28;
            while(day++<maxReach)++result;
            result*=86400;
            result+=Convert.ToUInt32((60-second+60*(59-minute)+3600*(23-hour)));
            return result;
        }
        private uint goToYearEnd(int month,int day,int hour,int minute,int second,bool isLeap)
        {
            uint result=0;
            result+=goToMonthEnd(month,day,hour,minute,second,isLeap);
            while(month<12)result+=goToMonthEnd(++month,1,0,0,0,isLeap);
            //label1.Text=Convert.ToString(result); // DEBUG
            return result;
        }
    }
}
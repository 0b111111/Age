using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Age // Settings.cs
{
    public partial class Settings:Form
    {
        bool mouseDown=false,expanded=false,areNumbers=false;
        Point lastLocation;
        int year,month,day,hour=12,minute=0,second=0;
        public Settings()
        {
            #pragma warning disable CS1690
            #pragma warning disable CA1846
            #pragma warning disable IDE0057
            #pragma warning disable IDE1006
            InitializeComponent();
            Form1.instance.Settings.Enabled=false;
            if(Form1.instance.start.Year>1776)
            {
                string[] temp=new string[6];
                if(Form1.instance.start.Year<10)temp[0]+="0";
                temp[0]+=Convert.ToString(Form1.instance.start.Year);
                if(Form1.instance.start.Month<10)temp[1]+="0";
                temp[1]+=Convert.ToString(Form1.instance.start.Month);
                if(Form1.instance.start.Day<10)temp[2]+="0";
                temp[2]+=Convert.ToString(Form1.instance.start.Day);
                if(Form1.instance.start.Hour<10)temp[3]+="0";
                temp[3]+=Convert.ToString(Form1.instance.start.Hour);
                if(Form1.instance.start.Minute<10)temp[4]+="0";
                temp[4]+=Convert.ToString(Form1.instance.start.Minute);
                if(Form1.instance.start.Second<10)temp[5]+="0";
                temp[5]+=Convert.ToString(Form1.instance.start.Second);
                Input.Text=temp[0]+"-"+temp[1]+"-"+temp[2]+" "+temp[3]+":"+temp[4]+":"+temp[5];
            }
        }
        private void Settings_IsEnter(object sender,KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter&&OK.Enabled)OK_Click(this,e);
        }
        private void button1_Click(object sender,EventArgs e) // CANCEL
        {
            Form1.instance.Settings.Enabled=true;
            this.Close();
        }
        private void Help_Click(object sender,EventArgs e)
        {
            if(!expanded)
            {
                Size=new(550,100);
                expanded=true;
                pictureBox1.Visible=false;
                pictureBox2.Visible=true;
            }
            else
            {
                Size=new(240,100);
                expanded=false;
                pictureBox1.Visible=true;
                pictureBox2.Visible=false;
            }
        }
        private void OK_Click(object sender,EventArgs e)
        {
            Form1.instance.start=new(year,month,day,hour,minute,second);
            Form1.instance.timer1.Enabled=true;
            Form1.instance.Settings.Enabled=true;
            Form1.instance.timer1_Tick(this,new());
            this.Close();
        }
        private void Settings_MouseDown(object sender,MouseEventArgs e)
        {
            mouseDown=true;
            lastLocation=e.Location;
        }
        private void Settings_MouseMove(object sender,MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location=new Point((this.Location.X-lastLocation.X)+e.X,(this.Location.Y-lastLocation.Y)+e.Y);
                this.Update();
            }
        }
        private void Settings_MouseUp(object sender,MouseEventArgs e)
        {
            mouseDown=false;
        }
        private void Settings_Validate(object sender,EventArgs e)
        {
            if(Input.Text.Length==10)
            {
                if (int.TryParse(Input.Text.Substring(0,4),out year)&&Input.Text[4]=='-'&&int.TryParse(Input.Text.Substring(5,2),out month)&&int.TryParse(Input.Text.Substring(8,2),out day)&&Input.Text[7]=='-')
                {
                    if(year>=1900&&year<=2300&&month>=1&&month<=12&&day>=1&&day<=31)areNumbers=true;
                    else areNumbers=false;
                }
                else areNumbers=false;
            }
            else if(Input.Text.Length==19)
            {
                if(int.TryParse(Input.Text.Substring(0,4),out year)&&Input.Text[4]=='-'&&int.TryParse(Input.Text.Substring(5,2),out month)&&Input.Text[7]=='-'&&int.TryParse(Input.Text.Substring(8,2),out day)&&Input.Text[10]==' '&&int.TryParse(Input.Text.Substring(11,2),out hour)&&Input.Text[13]==':'&&int.TryParse(Input.Text.Substring(14,2),out minute)&&Input.Text[16]==':'&&int.TryParse(Input.Text.Substring(17,2),out second))
                {
                    if(year>=1900&&year<=2300&&month>=1&&month<=12&&day>=1&&day<=31&&minute>=0&&minute<=59&&second>=0&&second<=59)areNumbers=true;
                    else areNumbers=false;
                }
                else areNumbers=false;
            }
            else areNumbers=false;
            if(areNumbers)
            {
                if(((month==2&&day<=29&&DateTime.IsLeapYear(year))||(month==2&&day<=28)||((month==9||month==11||month==4||month==6)&&day<=30)||(month==1||month==3||month==5||month==7||month==8||month==10||month==12))&&hour<=23&&minute<=59&&second<=59&&hour>=0&&minute>=0&&second>=0)OK.Enabled=true;
                else OK.Enabled=false;
            }
            else OK.Enabled=false;
        }
    }
}

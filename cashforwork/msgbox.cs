using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.Speech.Synthesis;

namespace cashforwork
{
    public static class msgbox
    {
        public static Boolean yes;       
        public static void Show( string message, string label)
        {
            MessageBox.Show(message, label, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowSkip(string message, string label)
        {

            MessageBox.Show( message, label, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        public static void Warning(string message, string label)
        {
            MessageBox.Show( message, label, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Warning2( string message, string label)
        {
            MessageBox.Show( message, label, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }       
        public static bool Confirm( string message, string label){
          var confirm=  MessageBox.Show(message,label,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
          if (confirm == DialogResult.Yes)
          {
              return true;
          }
          else { return false; }
        }
        public static bool WarningConfirm( string message, string label)
        {
            var confirm = MessageBox.Show( message, label, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (confirm == DialogResult.Yes)
            {
                return true;
            }
            else { return false; }
        }
        //public static void ShowTaskBarMessage(Form frm, int duration, string message, bool speak) {
        //    if (speak)
        //    {
        //        SpeechSynthesizer speech = new SpeechSynthesizer();
        //        speech.SpeakAsync(message);
        //    }

        //    Tile mt = new Tile();
        //    mt.Style = ColorStyle.Red;
        //    mt.Text = message;

        //    TaskWindow mtw = new TaskWindow(duration, mt);
        //    mtw.Style = ColorStyle.Red;
        //    mtw.Opacity = .89;
        //    mtw.ShowDialog();
        //}
        //public static void ShowTaskBarMessage2(Form frm, int duration, string message, bool speak)
        //{
        //    if (speak)
        //    {
        //        SpeechSynthesizer speech = new SpeechSynthesizer();
        //        speech.SpeakAsync(message);
        //    }

        //    Tile mt = new Tile();
        //    mt.Style = ColorStyle.Red;
        //    mt.Text = message;
            
        //    TaskWindow mtw = new TaskWindow(duration, mt);
        //    mtw.Style = ColorStyle.Red;
        //    mtw.Opacity=.89;
        //    mtw.ShowDialog();
        //}
    }
}

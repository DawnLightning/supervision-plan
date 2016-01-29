using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace supervision_plan.Models
{
    public class EmailRecordModle
    {
        private string m_Email_Receiver;

        public string Email_Receiver
        {
            get { return m_Email_Receiver; }
            set { m_Email_Receiver = value; }
        }
        private string m_Teacher_Identity;

        public string Teacher_Identity
        {
            get { return m_Teacher_Identity; }
            set { m_Teacher_Identity = value; }
        }
        private string m_Email_Theme;

        public string Email_Theme
        {
            get { return m_Email_Theme; }
            set { m_Email_Theme = value; }
        }
        private string m_Time_Now;

        public string Time_Now
        {
            get { return m_Time_Now; }
            set { m_Time_Now = value; }
        }
        private string m_Email_Type;

        public string Email_Type
        {
            get { return m_Email_Type; }
            set { m_Email_Type = value; }
        }
        private string m_File_State;

        public string File_State
        {
            get { return m_File_State; }
            set { m_File_State = value; }
        }
        private string m_Enclosure_Path;

        public string Enclosure_Path
        {
            get { return m_Enclosure_Path; }
            set { m_Enclosure_Path = value; }
        }
    }
}

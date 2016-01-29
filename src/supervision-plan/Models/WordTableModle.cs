using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace supervision_plan.Models
{
    public class WordTableModel
    {
        private string m_Supervisor;

        public string Supervisor
        {
            get { return m_Supervisor; }
            set { m_Supervisor = value; }
        }
        private string m_Time;

        public string Time
        {
            get { return m_Time; }
            set { m_Time = value; }
        }
        private string m_Classroom;

        public string Classroom
        {
            get { return m_Classroom; }
            set { m_Classroom = value; }
        }
        private string m_Perfession;

        public string Perfession
        {
            get { return m_Perfession; }
            set { m_Perfession = value; }
        }
        private string m_Teacher;

        public string Teacher
        {
            get { return m_Teacher; }
            set { m_Teacher = value; }
        }
        private string m_Class;

        public string Class
        {
            get { return m_Class; }
            set { m_Class = value; }
        }
        private string m_Subject;

        public string Subject
        {
            get { return m_Subject; }
            set { m_Subject = value; }
        }
        private string m_teachingtype;

        public string Teachingtype
        {
            get { return m_teachingtype; }
            set { m_teachingtype = value; }
        }
    }
}

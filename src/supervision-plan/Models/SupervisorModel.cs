using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace supervision_plan.Models
{
    public class SupervisorModle
    {
        private string m_SpareID;

        public string SpareID
        {
            get { return m_SpareID; }
            set { m_SpareID = value; }
        }
        private string m_SupervisorId;

        public string SupervisorId
        {
            get { return m_SupervisorId; }
            set { m_SupervisorId = value; }
        }
        private string m_SupervisorName;

        public string SupervisorName
        {
            get { return m_SupervisorName; }
            set { m_SupervisorName = value; }
        }
        private int m_SpareWeek;

        public int SpareWeek
        {
            get { return m_SpareWeek; }
            set { m_SpareWeek = value; }
        }
        private int m_SpareDay;

        public int SpareDay
        {
            get { return m_SpareDay; }
            set { m_SpareDay = value; }
        }
        private int m_SpareNumber;

        public int SpareNumber
        {
            get { return m_SpareNumber; }
            set { m_SpareNumber = value; }
        }
        private bool m_Isassigned;

        public bool Isassigned
        {
            get { return m_Isassigned; }
            set { m_Isassigned = value; }
        }
    }
}

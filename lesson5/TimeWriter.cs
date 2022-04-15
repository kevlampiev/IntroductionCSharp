using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    internal class TimeWriter:FileWriter
    {
        public TimeWriter(int taskNo, string fileName) : base(taskNo, fileName)
        { }

        public override object GetUserData()
        {
            return (object)DateTime.Now.ToString("HH:mm:ss");
        }

        public override void SaveUserData(object userData)
        {
            File.WriteAllText(OutputFileName, userData.ToString());
        }
    }
}

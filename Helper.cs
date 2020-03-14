using RobotAssistant.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssistant
{
    public class Helper
    { 
        public static bool IsNumeric(object Expression)
        {
            double retNum; 
            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public static string LastIdDoctor(ArrayList list)
        {
            string id = "";
            // 3 doctor thì last index 0, 1, 2 => Length - 1 = 3 - 1 = 2
            Doctor temp = (Doctor)list[list.Count - 1];
            // lấy id cuối cùng trong bảng Doctor
            int lastId = Convert.ToInt32(temp.id);
            // id = 10
            // => 0010 thêm 2 số 0
            // 4 - id.ToString().Length 5=> 1 ; 14 => 2; 154 => 3  
            for (int i=0;i < 4-lastId.ToString().Length; i++)
            {
                id += "0";
            }
            return id + (lastId+1).ToString();
        }
    }
}

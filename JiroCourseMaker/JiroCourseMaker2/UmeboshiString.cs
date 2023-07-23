using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiroCourseMaker2 {
    static class UmeboshiString {
        /// <summary>
        ///  文字列を指定の最初から指定の箇所まで切り取ります
        /// </summary>
        /// <param name="str"></param>
        /// <param name="Start"></param>
        /// <returns></returns>
        static public string CutToStart(string str, string Start) {
            if (!str.Contains(Start)) return str;
            return str.Substring(0, str.IndexOf(Start));
        }

        /// <summary>
        /// 文字列の指定の箇所より後ろを最後まで切り取ります
        /// </summary>
        /// <param name="str"></param>
        /// <param name="End"></param>
        /// <returns></returns>
        static public string CutToEnd(string str, string End) {
            if (!str.Contains(End)) return str;
            return str.Substring(str.IndexOf(End) + End.Length);
        }

        /// <summary>
        /// 文字列の指定の箇所と指定の箇所との間を切り取ります
        /// </summary>
        /// <param name="str"></param>
        /// <param name="Start"></param>
        /// <param name="End"></param>
        /// <returns></returns>
        static public string CutStartToEnd(string str, string Start, string End) {
            if (!str.Contains(Start) || !str.Contains(End)) return str;
            return str.Substring(str.IndexOf(Start) + Start.Length, str.LastIndexOf(End) - End.Length - 1);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiroCourseMaker2 {
    /// <summary>
    ///  太鼓さん次郎用tjcファイル情報
    /// </summary>
    public class Pack {
        public string PackName;
        /// <summary>
        /// tjcの情報
        /// </summary>
        public List<TJC> TJCs;

        /// <summary>
        /// パックフォルダのgenre.iniカラー
        /// </summary>
        public Color PackFolderColor;

        /// <summary>
        /// 段位フォルダのgenre.iniカラー
        /// </summary>
        public Color CoursesFolderColor;

        /// <summary>
        /// 楽曲フォルダのgenre.iniカラー
        /// </summary>
        public Color SongsFolderColor;

    }

    /// <summary>
    /// コース情報
    /// </summary>
    public class TJC {

        /// <summary>
        /// コース名
        /// </summary>
        public string Name;

        /// <summary>
        /// ライフ値
        /// </summary>
        public int Life;

        /// <summary>
        /// 使用する譜面
        /// </summary>
        public List<TJA> TJAs;

        /// <summary>
        /// 楽曲フォルダ内のコースカラー
        /// </summary>
        public Color TJCColor;

    }

    public class TJD {

    }
}

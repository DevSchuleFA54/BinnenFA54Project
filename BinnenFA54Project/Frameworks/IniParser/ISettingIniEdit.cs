using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinnenFA54Project.Frameworks.IniParser
{
    interface ISettingIniEdit
    {
        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void EditOnTopMost(bool flag);


        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void EditUIControls(bool flag);


        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void EditIconInTray(bool flag);


        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void EditDateFormat(string dateFormat);

    }
}
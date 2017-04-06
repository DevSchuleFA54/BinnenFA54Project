using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinnenFA54Project.Frameworks.IniParser
{
    interface ISettingIni
    {
        /**
         * Returns true or false property.
         *
         * @return      bool
         * @discussion  None
         */
        bool OnTopMost();


        /**
         * Returns true or false property.
         *
         * @return      bool
         * @discussion  None
         */
        bool UIControls();


        /**
         * Returns true or false property.
         *
         * @return      bool
         * @discussion  None
         */
        bool IconInTray();


        /**
         * Returns a string of the date format.
         *
         * @return      string
         * @discussion  None
         */
        string DateFormat();

    }
}

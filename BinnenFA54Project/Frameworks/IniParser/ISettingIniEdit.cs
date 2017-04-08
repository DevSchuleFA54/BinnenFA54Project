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
        void SetOnTopMost(bool flag);


        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void SetUIControls(bool flag);


        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void SetIconInTray(bool flag);


        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void SetDateFormat(string dateFormat);


        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void SetApplicationTitle(string applicationTitle);


        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void SetPassedWithPercent(int passedWithPercent);


        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void SetCompanyName(string companyName);


        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void SetStreetName(string streetName);


        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void SetPostcodeAndCity(string postcodeAndCity);


        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void SetCountry(string country);


        /**
         * Modify the Setting.ini values.
         *
         * @return      None
         * @discussion  None
         */
        void SetPhoneNumber(string phoneNumber);

    }
}
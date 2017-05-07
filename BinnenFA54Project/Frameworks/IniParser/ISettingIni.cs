namespace BinnenFA54Project.Frameworks.IniParser
{
    /// <summary>
    /// Interface for the SettingIniImpl.
    /// </summary>
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
         * Returns a string of the language.
         *
         * @return      string
         * @discussion  None
         */
        string LocalizeLanguage();


        /**
         * Returns a string of the date format.
         *
         * @return      string
         * @discussion  None
         */
        string DateFormat();


         /**
         * Returns a string of the application title.
         *
         * @return      string
         * @discussion  None
         */
        string ApplicationTitle();


        /**
        * Returns a int of the percent to pass.
        *
        * @return      int
        * @discussion  None
        */
        int PassedWithPercent();


        /**
        * Returns a string of the developers company name.
        *
        * @return      string
        * @discussion  None
        */
        string CompanyName();


        /**
        * Returns a string of the street name and house number.
        *
        * @return      string
        * @discussion  None
        */
        string StreetName();


        /**
        * Returns a string of the post code and city name.
        *
        * @return      string
        * @discussion  None
        */
        string PostcodeAndCity();


        /**
        * Returns a string of the country name.
        *
        * @return      string
        * @discussion  None
        */
        string Country();


        /**
        * Returns a string of the developers company phone number.
        *
        * @return      string
        * @discussion  None
        */
        string PhoneNumber();

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinnenFA54Project.Properties;
using IniParser;
using IniParser.Model;

namespace BinnenFA54Project.Frameworks.IniParser
{
    class ResultsIni
    {
        private static FileIniDataParser iniParser = new FileIniDataParser();
        private static IniData data = new IniData();
        private static string settingPath = AppDomain.CurrentDomain.BaseDirectory + "Results.ini";


        public static void SaveExamResults(string examName, int passWithP, bool pass)
        {
            if (!File.Exists(settingPath))
            {
#if DEBUG
                MessageBox.Show("Created Results.ini");
#endif // DEBUG
                File.WriteAllText(settingPath, Resources.Results);
            }

            try
            {
                data = iniParser.ReadFile(settingPath);
                var sectionData = data.Sections.GetSectionData("ExamResults");
                string lastNewKeyName = String.Empty;

                // Get the amount of keys and store in lastNewKeyName.
                lastNewKeyName = ("LOG" + (sectionData.Keys.Count + 1)); // Key Name

                // Key Value
                string value = string.Format("{0} - ({1}%) - {2}",
                    examName, passWithP, pass ? Resources.ResourceManager.GetString("PASSED") :
                                                Resources.ResourceManager.GetString("FAILED"));

                sectionData.Keys.AddKey(lastNewKeyName, value);
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static Dictionary<int, string> GetExamResults()
        {
            Dictionary<int, string> examResultsDic = new Dictionary<int, string>();

            try
            {
                data = iniParser.ReadFile(settingPath);
                var sectionData = data.Sections.GetSectionData("ExamResults");

                for (int i = 1; i <= sectionData.Keys.Count; i++)
                {
                    examResultsDic.Add(i, data["ExamResults"]["LOG" + i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return examResultsDic;
        }


        /// <summary>
        /// Deletes all keys and their data.
        /// Used for clearing the results history of the exam.
        /// </summary>
        public static void ClearExamResults()
        {
            data = iniParser.ReadFile(settingPath);

            data.Sections.GetSectionData("ExamResults").Keys.RemoveAllKeys();

            iniParser.WriteFile(settingPath, data);
        }



    }
}

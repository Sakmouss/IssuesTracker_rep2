using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace IssuesTracker.services
{
    public class ProjectsXmlMethods
    {
        static string root = "C:\\Users\\WORD\\Documents";

        public static void CreatePojectDir()
        {
            if (!Directory.Exists($"{root}\\Projects"))
            {
                Directory.CreateDirectory($"{root}\\Projects");
            }
            else { };
        }
        public static void CreateDirectory(string directoryname)
        {
            if (Directory.Exists($"{root}Projects\\{directoryname}")) { }
            else
            {
                Directory.CreateDirectory($"{root}Projects\\{directoryname}");
            }
        }
        public static void createProjectFile(string projectname, int projectid)
        {
            string projectname1 = projectname.Replace(' ', '_');

            try
            {
                string path = $"{root}Projects\\{projectname}\\{projectname1}.xml";

                if (!File.Exists(path))
                {
                    XElement doc = new XElement("Project", new XAttribute("Name", projectname),
                    new XAttribute("Id", projectid.ToString()), new XElement("Issues"));
                    doc.Save(path);
                }
                else { };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace OperateData
{
    public class OperXML
    {
        public static bool excitFile = System.IO.File.Exists(System.Environment.CurrentDirectory + "\\login.xml");

        public static string[] GetUserInfo()
        {
             string[] userInfo = new string[2];
            try
            {
                XmlDocument userXML = new XmlDocument();
                if (excitFile)
                {
                    userXML.Load(System.Environment.CurrentDirectory+"\\login.xml");
                    XmlNode root = userXML;
                    XmlNodeList userinfoNode = root.ChildNodes;
                    userInfo[0] = userinfoNode[0].Attributes["value"].Value;
                    userInfo[1] = userinfoNode[1].Attributes["value"].Value;
                    return userInfo;
                }
                else
                {
                    MessageBox.Show("缺少配置文件，无法保存账号密码");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            return userInfo;

        }

        public static void UpdateUserInfo(string name,string password)
        {
            try
            {
                XmlDocument userXML = new XmlDocument();
                if(excitFile)
                {
                    userXML.Load(System.Environment.CurrentDirectory + "\\login.xml");
                    XmlNode root = userXML.FirstChild;
                    XmlNodeList userInfoNode = root.ChildNodes;
                    userInfoNode[0].Attributes["value"].Value = name;
                    userInfoNode[1].Attributes["value"].Value = password;
                    userXML.Save("login.xml");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

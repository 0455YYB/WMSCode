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
                    XmlElement root = userXML.DocumentElement;
                    XmlNodeList userinfoNode = root.ChildNodes;
                    foreach(XmlNode node in userinfoNode)
                    {
                        userInfo[0] =(string)node.Attributes["value"].Value;
                        userInfo[1] =(string)node.Attributes["value"].Value;
                    }
                    
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
                    XmlElement root = userXML.DocumentElement;
                    XmlNodeList userInfoNode = root.GetElementsByTagName("user");
                    foreach(XmlNode node in userInfoNode)
                    {
                        if(node.Name=="name")
                        {
                            ((XmlElement)node).SetAttribute("value", name);
                            break;
                        }
                        else if(node.Name=="password")
                        {
                            ((XmlElement)node).SetAttribute("value",password);
                            break;
                        }
                       
                    }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SerialPortCommunication
{
    public partial class SaveManager
    {
        private ISerialPortTestfrm mForm;
        private StreamWriter sw;
        private StreamReader sr;
        private FileStream fs;
        private XmlSerializer xmlS;

        private PropertyInfo[] props;

        public SaveManager(ISerialPortTestfrm form)
        {
            mForm = form;
            props = form.GetType().GetProperties();
        }

       
        public void Save(object Object, string filepath, string filename)
        {
            try
            {
                xmlS = new XmlSerializer(Object.GetType());
                fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);

                xmlS.Serialize(sw, Object);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.GetType() + ": " + e.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sw != null)
                {
                    sw.Close();
                    MessageBox.Show("Saving succeeded!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

       
    }
}

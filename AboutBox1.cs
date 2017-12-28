using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Crypto_calc
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;

            textBoxDescription.AppendText("\n");
            textBoxDescription.AppendText("Donate:"+"\n");
            textBoxDescription.AppendText("BTC:" + "\t" + "1DhjTmRsQN2fBNSBArMmuvdaWDnxLBpedu" + "\n");
            textBoxDescription.AppendText("LTC:" + "\t" + "Li3LYheoR4hJkaQwC1FhsfeatddEucX2Mw" + "\n");
            textBoxDescription.AppendText("ETH:" + "\t" + "0x526409f42f9eeb3326f9e396165c034d9aef6e0d" + "\n");
            textBoxDescription.AppendText("DOGE:" + "\t" + "D9Tux2XRbkmEFTwm8fqZULZbU5mxxLsVMP" + "\n");
            textBoxDescription.AppendText("EMC2:" + "\t" + "EXPuGrKqKs1cDFqiJhDqgwx5DDpPjbeWb9" + "\n");

            textBoxDescription.AppendText("Qestions ? Contact me @" + "\n");
            textBoxDescription.AppendText("https://github.com/JanSedlak66/crypto_calc" + "\n");
            textBoxDescription.AppendText("https://www.linkedin.com/in/jan-sedlak-889a5314a/");
            
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
    }
}

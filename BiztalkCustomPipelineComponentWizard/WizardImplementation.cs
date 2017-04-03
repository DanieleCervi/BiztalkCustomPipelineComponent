using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TemplateWizard;
using System.Windows.Forms;
using EnvDTE;

namespace BiztalkCustomPipelineComponentWizard
{
    public class WizardImplementation : IWizard
    {
        private UserInputForm inputForm;

        private const string propertiesText = "\t\tpublic %type% %propName% { get; set; }\r\n";
        private const string loadpropText = "\t\t\tval = ReadPropertyBag(propertyBag, \"%propName%\");\r\n\t\t\tif (val != null) this.%propName% = (%type%)val;\r\n\r\n";
        private const string savepropText = "\t\t\tval = (object)%propName%;\r\n\t\t\tpropertyBag.Write(\"%propName%\", ref val);\r\n\r\n";
        private string enableText = string.Empty;

        // This method is called before opening any item that   
        // has the OpenInEditor attribute.  
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        // This method is only called for item templates,  
        // not for project templates.  
        public void ProjectItemFinishedGenerating(ProjectItem
            projectItem)
        {
        }

        // This method is called after the project is created.  
        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            try
            {
                // Display a form to the user. The form collects   
                // input for the custom message.  
                inputForm = new UserInputForm();
                inputForm.ShowDialog();

                var pcName = UserInputForm.PCName;
                var pcDescription = UserInputForm.PCDescription;
                var pcCategory = UserInputForm.PCCategory;
                var pcProperties = UserInputForm.PCProperties;
                var propertiesString = string.Empty;
                var loadProps = "object val;\r\n";
                var saveProps = "object val;\r\n";
                var enable = UserInputForm.PCEnabled;

                if (enable)
                {
                    pcProperties.Add("Enabled", "bool");
                    enableText = "\r\n\t\t\tif (!Enabled)\r\n\t\t\t\treturn pInMsg;\r\n\r\n";
                }

                foreach (var prop in pcProperties)
                {
                    propertiesString += propertiesText.Replace("%type%", prop.Value).Replace("%propName%", prop.Key);
                    loadProps += loadpropText.Replace("%propName%", prop.Key).Replace("%type%", prop.Value);
                    saveProps += savepropText.Replace("%propName%", prop.Key).Replace("%type%", prop.Value);
                }

                // Add custom parameters.  
                replacementsDictionary.Add("$pcName$", pcName);
                replacementsDictionary.Add("$pcDescription$", pcDescription);
                replacementsDictionary.Add("$pcCategory$", "CATID_" + pcCategory);
                replacementsDictionary.Add("$properties$", propertiesString);
                replacementsDictionary.Add("$loadProps$", loadProps);
                replacementsDictionary.Add("$saveProps$", saveProps);
                replacementsDictionary.Add("$enabled$", enableText);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // This method is only called for item templates,  
        // not for project templates.  
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.BizTalk.Message.Interop;
using Microsoft.BizTalk.Component.Interop;
using System.IO;
using System.Xml;

namespace $safeprojectname$
{
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.$pcCategory$)]
    [System.Runtime.InteropServices.Guid("$guid2$")]
    public class CustomComponent : IBaseComponent, IComponentUI, IComponent, IPersistPropertyBag
    {

        #region IBaseComponent
        public string Description
        {
            get
            {
                return "$pcDescription$";
            }
        }

        public string Name
        {
            get
            {
                return "$pcName$";
            }
        }

        public string Version
        {
            get
            {
                return "1.0.0.0";
            }
        }
        #endregion

        #region IComponentUI

        public IntPtr Icon
        {
            get
            {
                return new System.IntPtr();
            }
        }

        public System.Collections.IEnumerator Validate(object projectSystem)
        {
            return null;
        }

        #endregion

        #region IPersistPropertyBag

$properties$

        public void GetClassID(out Guid classID)
        {
            classID = new Guid("$guid2$");
        }

        public void InitNew()
        {
        }

        public void Load(IPropertyBag propertyBag, int errorLog)
        {
            $loadProps$
        }

        public void Save(IPropertyBag propertyBag, bool clearDirty, bool saveAllProperties)
        {
            $saveProps$
        }

        private static object ReadPropertyBag(IPropertyBag pb, string propName)
        {
        object val = null;
        try
        {
            pb.Read(propName, out val, 0);
        }

        catch (ArgumentException)
        {
            return val;
        }
        catch (Exception ex)
        {
            throw new ApplicationException(String.Format(
                "Error while reading property '{0}' from PropertyBag",
                propName), ex);
        }
        return val;
        }

        #endregion

        #region IComponent

        public IBaseMessage Execute(IPipelineContext pContext, IBaseMessage pInMsg)
        {
            IBaseMessagePart bodyPart = pInMsg.BodyPart;
            $enabled$
            if (bodyPart != null)
            {
                //Put your implementation here.

                /*
                 * This example is for adding a not promoted property:
                 * 
                 * filePropertiesNamespace="http://schemas.microsoft.com/BizTalk/2003/file-properties";
                 * pInMsg.Context.Write("ReceivedFileName", filePropertiesNamespace, "New file name");
                 * 
                 * to only read a proproperty, is just simple as:
                 * pInMsg.Context.Read("ReceivedFileName", "filePropertiesNamespace");
                 * 
                 * 
                 * to promote is the same as writing:
                 * pInMsg.Context.Write("ReceivedFileName", filePropertiesNamespace, "New file name");
                 * 
                 */

                /*
                 * Hint: When you submit the stream to BizTalk, is must be seekable and it's offset at the beginning.
                 * If your stream isn't seekable, you should implement something like the following before returning:

                Stream originalStream = bodyPart.GetOriginalDataStream();
                MemoryStream streamToReturn = new MemoryStream();
                byte[] buffer = new byte[32768];
                int read;
                while ((read = originalStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    streamToReturn.Write(buffer, 0, read);
                }
                streamToReturn.Position = 0;
                pInMsg.BodyPart.Data = streamToReturn;

                */
            }

        return pInMsg;

        }

        #endregion
    }
}
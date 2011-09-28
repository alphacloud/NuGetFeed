﻿using System.Web.Mvc;
using System.Xml.Linq;

namespace NuGetFeed.Infrastructure.ModelBinders
{
    using System.IO;

    public class XmlModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            return XDocument.Load(controllerContext.HttpContext.Request.InputStream);
        }
    }
}
using System;
using System.Web.Mvc;
using StructureMap;

namespace WroxPizza.Core.Web.Setup
{
    public class StructureMapControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(Type controllerType)
        {
            if (controllerType == null)
                return null;

            return ObjectFactory.GetInstance(controllerType) as Controller;
        }
    }
}

using System;
using System.Reflection;

namespace Org.Niladri.Net.Web.Webapi2.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}
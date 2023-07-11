using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetNuke.Entities.Tabs;
using FortyFingers.DnnMassManipulate.Components;

namespace FortyFingers.DnnMassManipulate.ManipulatorModules.Search
{
    public class SearchModel
    {
        public SearchModel()
        {
        }
        public ContextHelper Context { get; set; }
    }

    public class SearchPostModel
    {
        public string SearchInput { get; set; }
    }
}
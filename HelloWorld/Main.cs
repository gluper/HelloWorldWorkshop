using _3S.CoDeSys.Core.Commands;
using _3S.CoDeSys.Core.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    [TypeGuid("{03B0731F-35FD-4626-9811-59920D304401}")]
    public class MyCommand : IStandardCommand
    {
        public Guid Category => new Guid("{7292189D-FA9F-4C01-8D6E-81B9E01C7ED5}");

        public string Name => Resources.HelloWorldCommandName;

        public string Description => Resources.HelloWorldCommandDescription;

        public string ToolTipText => Resources.HelloWorldCommandDescription;

        public System.Drawing.Icon SmallIcon => Res.HelloIcon;

        public System.Drawing.Icon LargeIcon => SmallIcon;

        public bool Enabled => true;

        public string[] BatchCommand => new string[0];

        public void AddedToUI()
        {
        }

        public string[] CreateBatchArguments()
        {
            return new string[0];
        }

        public void ExecuteBatch(string[] arguments)
        {
            MessageBox.Show("Hello World!!!!");
        }

        public bool IsVisible(bool bContextMenu)
        {
            return true;
        }

        public void RemovedFromUI()
        {
        }
    }

    [TypeGuid("{7292189D-FA9F-4C01-8D6E-81B9E01C7ED5}")]
    public class WorkshopCommandCategory : ICommandCategory
    {
        public string Text => "Workshop Category";

        public string Description => "Commands for AP Workshop";
    }
}

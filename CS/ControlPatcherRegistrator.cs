using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{

    public class ControlPatcher<T> where T : Control
    {
        Action<T> _ProcessControlAction;
        public ControlPatcher(Action<T> processControlAction)
        {
            _ProcessControlAction = processControlAction;
        }

        public void ProcessContainer(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control.GetType() == typeof(T))
                {
                    ProcessControl(control);
                }
                else
                    ProcessContainer(control);
            }
        }

        private void ProcessControl(object control)
        {
            _ProcessControlAction(control as T);
        }
    }

    public class ControlPatcherRegistrator : Component
    {

        bool IsDesignMode()
        {
            return DesignMode || DevExpress.Utils.Design.DesignTimeTools.IsDesignMode;
        }

        public ControlPatcherRegistrator(IContainer container)
        {
            if (!IsDesignMode())
                return;


        }

        public Form ContainerControl
        {
            get { return _containerControl; }
            set
            {
                _containerControl = value;
                SubscribeEvents();
            }
        }
        private Form _containerControl = null;

        public override ISite Site
        {
            get { return base.Site; }
            set
            {
                base.Site = value;
                if (value == null)
                    return;
                IDesignerHost host = value.GetService(typeof(IDesignerHost)) as IDesignerHost;
                if (host == null)
                    return;
                IComponent componentHost = host.RootComponent;
                if (componentHost is Form)
                {
                    _containerControl = componentHost as Form;
                }
            }
        }

        void SubscribeEvents()
        {
            if (ContainerControl == null)
                return;
            ContainerControl.Load -= ContainerControl_Load;
            ContainerControl.Load += ContainerControl_Load;
        }

        private void ContainerControl_Load(object sender, EventArgs e)
        {
            Register();
        }

        public void Register()
        {
            new ControlPatcher<ButtonEdit>((edit) => edit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor).ProcessContainer(ContainerControl);
            new ControlPatcher<DateEdit>((edit) => edit.Properties.WeekDayAbbreviationLength = 3).ProcessContainer(ContainerControl);
            new ControlPatcher<TextEdit>((edit) => edit.Properties.NullValuePrompt = "Enter your text here").ProcessContainer(ContainerControl);
        }
    }
}

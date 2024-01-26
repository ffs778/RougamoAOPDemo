using Rougamo;
using Rougamo.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo
{
    public class CheckAttribute:MoAttribute
    {
        Permisson _permisson;
        public CheckAttribute(Permisson permisson)
        {
            _permisson = permisson;
        }
        public override void OnEntry(MethodContext context)
        {
            if (Global.CurrentUser is null  || Global.CurrentUser.Permission > _permisson)
            {
                System.Windows.Forms.MessageBox.Show($"无权访问,所需权限【{_permisson}】");
                context.ReplaceReturnValue(this, null);
            }
        }
    }
}

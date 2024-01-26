using Rougamo;
using Rougamo.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo
{
    public class CheckPermissonAttribute : MoAttribute
    {
        Permisson _permisson;
        public CheckPermissonAttribute(Permisson permisson)
        {
            _permisson = permisson;
        }
        public override void OnEntry(MethodContext context)
        {
            if (Global.CurrentUser is null || Global.CurrentUser.Permission > _permisson)
            {
                System.Windows.Forms.MessageBox.Show($"无权访问,所需权限【{_permisson}】");
                context.ReplaceReturnValue(this, null);
            }
        }
    }
    public class LogAttribute : MoAttribute
    {
        public LogAttribute() { }
        public override void OnEntry(MethodContext context)
        {
            var args = context.Arguments.Length > 0 ? "[" + string.Join("],[", context.Arguments) + "]" : "无";
            LogHelper.Info($"开始执行方法{context.Method.Name},入参{args}");
        }
        public override void OnExit(MethodContext context)
        {
            LogHelper.Info("执行结束");
        }
    }
    public class CatchExceptionAttribute : MoAttribute
    {
        public CatchExceptionAttribute() { }
        public override void OnException(MethodContext context)
        {
            var args = context.Arguments.Length > 0 ? "[" + string.Join("],[", context.Arguments) + "]" : "无";
            string msg = $"方法{context.Method.Name}出现错误,入参{args}";
            LogHelper.Error(msg);
            System.Windows.Forms.MessageBox.Show(msg);
            context.HandledException(this, null);
        }
    }
}

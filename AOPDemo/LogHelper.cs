﻿using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo
{
    public class LogHelper
    {
        /// <summary>
        /// 普通日志
        /// </summary>
        /// <param name="message">日志内容</param>
        public static void Info(string message)
        {
            ILog log = LogManager.GetLogger("Info");
            if (log.IsInfoEnabled)
            {
                log.Info(message);
            }
        }
        /// <summary>
        /// 错误日志带异常
        /// </summary>
        /// <param name="message">错误日志</param>
        public static void Error(string message, Exception ex)
        {
            ILog log = LogManager.GetLogger("Error");
            if (log.IsErrorEnabled)
            {
                log.Error(message, ex);
            }
        }

        /// <summary>
        /// 错误日志不带异常
        /// </summary>
        /// <param name="message">错误日志</param>
        public static void Error(string message)
        {
            ILog log = LogManager.GetLogger("Error");
            if (log.IsErrorEnabled)
            {
                log.Error(message);
            }
        }
    }

}

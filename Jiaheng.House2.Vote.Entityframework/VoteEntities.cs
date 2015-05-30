using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Jiaheng.House2.Vote.Entityframework
{
    public partial class Entities
    {
        #region Fields

        //定义索引名称
        const string ContextKey = "TYEntities";

        //标记为ThreadStaticAttribute的静态字段不在线程之间共享。
        //每个执行线程都有单独的字段实例，并且独立地设置及获取该字段的值。如果在不同的线程中访问该字段，则该字段将包含不同的值。
        [ThreadStatic]
        private static Entities _current;

        #endregion

        #region Properties

        public bool Disposed { get; set; }

        /// <summary>
        /// 当系统工作在HttpContext下，将使用延迟家在技术返回一个TYEntities（ObjectContext），如果没有HttpContext将返回null
        /// 
        /// 不论在哪里使用TYEntities，在请求结束后都需要调用TYEntities.Cleanup()方法
        /// 最佳的方式是TYEntities.Cleanup()放到Global.asax.cs文件里面。
        /// void Application_EndRequest(object sender, EventArgs e)
        /// {
        ///     TYStudioDemo.Models.TYEntities.Cleanup();
        /// }
        /// </summary>
        private static Entities ForWebRequest
        {
            get
            {
                var context = HttpContext.Current;

                //检查HttpContext是否存在
                if (context != null)
                {
                    //试着从context中得到TYEntities
                    var result = context.Items[ContextKey] as Entities;

                    if (result == null)
                    {
                        //创建新的datacontext，并且保存到context里面
                        result = new Entities();
                        context.Items[ContextKey] = result;
                    }

                    return result;
                }

                return null;
            }
        }

        /// <summary>
        /// 这是一个用来获取TYEntities(ObjectContext)的公共属性
        /// 
        /// 如果你通过HttpContext获取TYEntities，同样不论在哪里使用TYEntities，在请求结束后都需要调用TYEntities.Cleanup()方法
        /// 
        /// 如果没有通过HttpContext获取TYEntities，你必须在使用结束之后调用TYEntities.Cleanup()方法，来清理ObjectContext。
        /// 
        /// 需要注意的一点是，无论使用哪种方式获取TYEntities，我们都必须手动的清理和Dispose TYEntities(ObjectContext)。
        /// 所以一定不要在using块中使用TYEntities(ObjectContext)。
        /// </summary>
        public static Entities Current
        {
            get
            {
                //从HttpContext中获取datacontext
                var result = Entities.ForWebRequest;

                if (result != null)
                    return result;

                //试着获取当前活动的TYEntities
                if (_current == null)
                    _current = new Entities();

                return _current;
            }
        }

        /// <summary>
        /// 清理结束TYEntities(ObjectContext)
        /// </summary>
        public static void Cleanup()
        {
            if (HttpContext.Current != null)
            {
                var result = HttpContext.Current.Items[ContextKey] as Entities;

                if (result != null)
                    result.Dispose();

                HttpContext.Current.Items[ContextKey] = null;
            }
            else if (_current != null)
            {
                _current.Dispose();
                _current = null;
            }
        }


        protected override void Dispose(bool disposing)
        {
            bool disposed = Disposed;
            Disposed = true;

            if (!disposed)
                Cleanup();

            base.Dispose(disposing);
        }

        #endregion
    }
}

using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class ViewersManager
    {
        public static void Create(Viewer item)
        {
            try
            {
                ViewersDBManager viewersDBManager = new ViewersDBManager();
                viewersDBManager.Create(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Viewer Read(int key)
        {
            try
            {
                ViewersDBManager viewersDBManager = new ViewersDBManager();
                return viewersDBManager.Read(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static IEnumerable<Viewer> ReadAll()
        {
            try
            {
                ViewersDBManager viewersDBManager = new ViewersDBManager();
                return viewersDBManager.ReadAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Update(Viewer item)
        {
            try
            {
                ViewersDBManager viewersDBManager = new ViewersDBManager();
                viewersDBManager.Update(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Delete(int key)
        {
            try
            {
                ViewersDBManager viewersDBManager = new ViewersDBManager();
                viewersDBManager.Delete(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

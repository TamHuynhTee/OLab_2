using OLab_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLab_2.Controllers
{
    public static class JobControllers
    {
        public static bool AddOrUpdate(Job input)
        {
            try
            {
                using (var _context = new DBOLabManagementEntities())
                {
                    _context.Jobs.AddOrUpdate(input);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Windows.Forms.MessageBox.Show(ve.PropertyName.ToString() +
                            eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName).ToString() +
                            ve.ErrorMessage.ToString());
                    }
                }
                return false;
            }
        }
      
        public static List<Job> GetList()
        {
            using (var _context = new DBOLabManagementEntities())
            {
                return (from u in _context.Jobs
                        select u).ToList();
            }
        }

        public static void Delete(string MaCV)
        {
            using (var _context = new DBOLabManagementEntities())
            {
                var find = (from u in _context.Jobs
                            where u.MaCV == MaCV
                            select u).ToList();
                if (find.Count == 0)
                    return;
                _context.Jobs.Remove(find[0]);
                _context.SaveChanges();
            }
        }
    }
}

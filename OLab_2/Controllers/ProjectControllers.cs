using OLab_2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLab_2.Controllers
{
    public static class ProjectControllers
    {
        public static bool AddOrUpdate(Project input)
        {
            try
            {
                using (var _context = new DBOLabManagementEntities())
                {
                    _context.Projects.AddOrUpdate(input);
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
        public static List<Project> GetList()
        {
            using (var _context = new DBOLabManagementEntities())
            {
                return (from u in _context.Projects
                        select u).ToList();
            }
        }
        public static void Delete(string MaDA)
        {
            using (var _context = new DBOLabManagementEntities())
            {
                var find = (from u in _context.Projects
                            where u.MaDA == MaDA
                            select u).ToList();
                if (find.Count == 0)
                    return;
                _context.Projects.Remove(find[0]);
                _context.SaveChanges();
            }
        }

    }
}

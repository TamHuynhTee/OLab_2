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
    public static class SLevelControllers
    {
        public static bool AddOrUpdate(SalaryLevel input)
        {
            try
            {
                using (var _context = new DBOLabManagementEntities())
                {
                    _context.SalaryLevels.AddOrUpdate(input);
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
        public static decimal Salary(string Level)
        {
            using (var _context = new DBOLabManagementEntities())
            {
                var temp = (from u in _context.SalaryLevels
                            where u.HocVan.Trim()==Level
                            select u).ToList();
                if (temp.Count == 1)
                {
                    return temp[0].Luong;
                }
                else
                {
                    return 0;
                };
            }
        }
        public static void clearAllData()
        {
            using (var _context = new DBOLabManagementEntities())
            {
                var temp = (from u in _context.SalaryLevels
                            select u).ToList();
                _context.SalaryLevels.RemoveRange(temp);
                _context.SaveChanges();
            }
        }
        public static List<SalaryLevel> GetList()
        {
            using (var _context = new DBOLabManagementEntities())
            {
                return (from u in _context.SalaryLevels
                        select u).ToList();
            }
        }
    }
}

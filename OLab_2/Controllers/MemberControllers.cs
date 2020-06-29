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
    public static class MemberControllers
    {
        public static bool AddOrUpdate(Member input)
        {
            try
            {
                using (var _context = new DBOLabManagementEntities())
                {
                    _context.Members.AddOrUpdate(input);
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

        public static Member Get(string MaTV)
        {
            using (var _context = new DBOLabManagementEntities())
            {
                var temp = (from u in _context.Members
                            where u.MaTV == MaTV
                            select u).ToList();
                if (temp.Count == 1)
                {
                    return temp[0];
                }
                else
                {
                    return null;
                };
            }
        }
        public static List<Member> GetList()
        {
            using (var _context = new DBOLabManagementEntities())
            {
                return (from u in _context.Members
                        select u).ToList();
            }
        }

        public static void Delete(string MaTV)
        {
            using (var _context = new DBOLabManagementEntities())
            {
                var find = (from u in _context.Members
                            where u.MaTV == MaTV
                            select u).ToList();
                if (find.Count == 0)
                    return;
                _context.Members.Remove(find[0]);
                _context.SaveChanges();
            }
        }

    }
}

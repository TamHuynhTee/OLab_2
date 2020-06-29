using OLab_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLab_2.Controllers
{
    public static class AllController
    {
        public static void clearAllData()
        {
            List<Project> LP = ProjectControllers.GetList();
            List<Member> LM = MemberControllers.GetList();
            List<Job> LJ = JobControllers.GetList();

            foreach (Member run in LM)
            {
                run.MaDA = null; run.MaCV = null;
                MemberControllers.AddOrUpdate(run);
            }
            foreach (Project run in LP)
            {
                run.MaNQL = null;
                ProjectControllers.AddOrUpdate(run);
            }
            foreach (Job run in LJ)
            {
                run.MaNQL = null;
                run.MaDA = null;
                JobControllers.AddOrUpdate(run);
            }

            foreach (Member run in LM)
                MemberControllers.Delete(run.MaTV);
            foreach (Project run in LP)
                ProjectControllers.Delete(run.MaDA);
            foreach (Job run in LJ)
                JobControllers.Delete(run.MaCV);
        }
        public static void SaveAllData(List<Project> LP, List<Job> LJ, List<Member> LM)
        {
            foreach (Member run in LM)
            {
                string MaDA = run.MaDA, MaCV = run.MaCV;
                run.MaDA = null; run.MaCV = null;
                MemberControllers.AddOrUpdate(run);
                run.MaDA = MaDA; run.MaCV = MaCV;
            }
            foreach (Project run in LP)
            {
                string MaNQL = run.MaNQL;
                run.MaNQL = null;
                ProjectControllers.AddOrUpdate(run);
                run.MaNQL = MaNQL;
            }
            foreach (Job run in LJ)
            {
                string MaNQL = run.MaNQL;
                string MaDA = run.MaDA;
                run.MaNQL = run.MaDA = null;
                JobControllers.AddOrUpdate(run);
                run.MaNQL = MaNQL;
                run.MaDA = MaDA;
            }

            foreach (Project run in LP)
                ProjectControllers.AddOrUpdate(run);
            foreach (Job run in LJ)
                JobControllers.AddOrUpdate(run);
            foreach (Member run in LM)
                MemberControllers.AddOrUpdate(run);

        }
    }
}

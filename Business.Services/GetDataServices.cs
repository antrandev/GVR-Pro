using Data.BaseRepository;
using Data.Entity;
using Data.Entity.Model;
using Infrastructure.Utilities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class GetDataServices
    {
        DataContext dataContext;
        public GetDataServices(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<string> GetOtherReousrce()
        {
            using(var context = new DataContext())
            {
                var unitofwork = new UnitOfWork(context);
                var KeyName = unitofwork.Query<OtherReousrce>().Select(s=> s.KeyName).ToList();
                return KeyName;
            }
        }

        public string SaveChangeOtherResource()
        {
            string[] listOtherResource = typeof(ResourceKeyPermission).GetEnumNames();
            List<string> listResourceName = new List<string>();
            listResourceName = GetOtherReousrce();
            if (listOtherResource != null && listOtherResource.Count() > 0)
            {
                listOtherResource = listOtherResource.Where(d => !string.IsNullOrWhiteSpace(d)
                   && !listResourceName.Contains(d.Split(new string[1] { "__" }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault())).ToArray();
            }
            return null;
        }

    }
}

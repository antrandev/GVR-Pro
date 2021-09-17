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


        public string SaveChangeOtherResource()
        {
            string[] listOtherResource = typeof(ResourceKeyPermission).GetEnumNames();
            List<string> listResourceName = new List<string>();
            if (listOtherResource != null && listOtherResource.Count() > 0)
            {
                listOtherResource = listOtherResource.Where(d => !string.IsNullOrWhiteSpace(d)
                   && !listResourceName.Contains(d.Split(new string[1] { "__" }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault())).ToArray();
            }
            return null;
        }

    }
}

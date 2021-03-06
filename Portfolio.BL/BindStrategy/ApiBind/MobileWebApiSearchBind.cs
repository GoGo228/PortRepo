﻿using Portfolio.BL.Mappers.ApiMappers;
using Portfolio.DAL.Concrate.BaseRepositories;
using Portfolio.UIModels.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BL.BindStrategy.ApiBind
{
    public class MobileWebApiSearchBind
    {
        public List<MobileWebApiSearchModel> BindData(string SearchRequest)
        {
            RepositoryHolder holder = new RepositoryHolder();

            MobileWebApiSearchMapper mapper = new MobileWebApiSearchMapper();
            var _userRepository = holder.UserRepository;
            List<MobileWebApiSearchModel> resultnewData =
                _userRepository.
                    FetchBy(z=> z.cPosition==SearchRequest).  //fix this search with contain mathod maybe
                    
                    Select(p => mapper.EntityToModel(p)).
                    
                    ToList();

            return resultnewData;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CacheDictionary.Models;
using Interfaces;

namespace CacheDictionary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICacheStore _cacheStore;

        public HomeController(ICacheStore cacheStore)
        {
            _cacheStore = cacheStore;
        }

        //[HttpGet]
        //[Route("{userId:int}")]
        //public ActionResult<UserInfo> Get(int userId)
        //{
        //    var userInfoCacheKey = new UserInfoCacheKey(userId);
        //    UserInfo userInfo = this._cacheStore.Get(userInfoCacheKey);

        //    if (userInfo == null)
        //    {
        //        userInfo = this.GetFromDatabase(userId);

        //        this._cacheStore.Add(userInfo, userInfoCacheKey);
        //    }

        //    return userInfo;
        //}
    }
}

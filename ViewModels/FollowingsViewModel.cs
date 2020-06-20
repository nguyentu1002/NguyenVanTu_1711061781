using Lab456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab456.ViewModels
{
    public class FollowingsViewModel
    {
        public IEnumerable<ApplicationUser> FollowingLectures { get; set; }
    }
}
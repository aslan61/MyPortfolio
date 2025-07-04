﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutnavbarComponentPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.todoListcount = context.ToDoLists.Where(x => x.Status == false).Count();
            var values=context.ToDoLists.Where(x=>x.Status==false).ToList();
            return View(values);
        }
    }
}

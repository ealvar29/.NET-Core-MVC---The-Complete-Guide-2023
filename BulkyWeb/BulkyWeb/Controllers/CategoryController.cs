﻿using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public CategoryController(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            var categoryList = _dbContext.Categories.ToList();
            return View(categoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

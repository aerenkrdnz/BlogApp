﻿using BlogApp.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Services
{
    public interface ICategoryService
    {
        bool AddCategory(AddCategoryDto addCategoryDto);
        List<ListCategoryDto> GetCategories();
        UpdateCategoryDto GetCategory(int id);
        void UpdateCategory(UpdateCategoryDto updateCategoryDto);
        void DeleteCategory(int id);
    }
}

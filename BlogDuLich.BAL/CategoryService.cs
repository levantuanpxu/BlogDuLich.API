﻿using BlogDuLich.BAL.Interface;
using BlogDuLich.DAL.Interface;
using BlogDuLich.Domain.Request.Category;
using BlogDuLich.Domain.Response.Category;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogDuLich.BAL
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<CreateCategoryResult> CreateCategory(CreateCategoryRequest request)
        {
            return await categoryRepository.CreateCategory(request);
        }
        public async Task<UpdateCategoryResult> UpdateCategory(UpdateCategoryRequest request)
        {
            return await categoryRepository.UpdateCategory(request);
        }
        public async Task<DeleteCategoryResult> DeleteCategory(DeleteCategoryRequest request)
        {
            return await categoryRepository.DeleteCategory(request);
        }

        public async Task<IEnumerable<Category>> Gets()
        {
            return await categoryRepository.Gets();
        }


    }
}

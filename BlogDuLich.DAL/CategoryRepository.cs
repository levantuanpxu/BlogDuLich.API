﻿using BlogDuLich.DAL.Interface;
using BlogDuLich.Domain.Request.Category;
using BlogDuLich.Domain.Response.Category;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace BlogDuLich.DAL
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public async Task<CreateCategoryResult> CreateCategory(CreateCategoryRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryName", request.CategoryName);
                return await SqlMapper.QueryFirstOrDefaultAsync<CreateCategoryResult>(cnn: connect,
                                                    sql: "sp_CreateCategoris",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<UpdateCategoryResult> UpdateCategory(UpdateCategoryRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", request.CategoryId);
                parameters.Add("@CategoryName", request.CategoryName);               
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateCategoryResult>(cnn: connect,
                                                    sql: "sp_UpdateCategoris",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<DeleteCategoryResult> DeleteCategory(DeleteCategoryRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", request.CategoryId);
                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteCategoryResult>(cnn: connect,
                                                    sql: "sp_DeleteCategoris",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Category>> Gets()
        {
            //var sql = "SELECT CategoryId, CategoryName FROM [dbo].[Category] WHERE IsDeleted =0";
            //return await SqlMapper.QueryAsync<Category>(cnn: connect, sql: sql, commandType: CommandType.Text);
            return await SqlMapper.QueryAsync<Category>(cnn: connect,
                                                sql: "sp_GetCategoris",
                                                commandType: CommandType.StoredProcedure);
        }
    }
}

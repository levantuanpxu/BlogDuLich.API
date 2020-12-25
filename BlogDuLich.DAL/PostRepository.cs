using BlogDuLich.DAL.Interface;
using BlogDuLich.Domain.Request.Post;
using BlogDuLich.Domain.Response.Post;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace BlogDuLich.DAL
{
    public class PostRepository : BaseRepository, IPostRepository
    {
        public async Task<CreatePostResult> CreatePost(CreatePostRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Title", request.Title);
                parameters.Add("@FullContent", request.FullContent);
                parameters.Add("@Image", request.Image);
                parameters.Add("@Published", request.Published);
                parameters.Add("@ContactId", request.ContactId);
                parameters.Add("@CategoryId", request.CategoryId);
                return await SqlMapper.QueryFirstOrDefaultAsync<CreatePostResult>(cnn: connect,
                                                    sql: "sp_CreatePost",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<UpdatePostResult> UpdatePost(UpdatePostRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PostId", request.PostId);
                parameters.Add("@Title", request.Title);
                parameters.Add("@FullContent", request.FullContent);
                parameters.Add("@Image", request.Image);
                parameters.Add("@Published", request.Published);
                parameters.Add("@ContactId", request.ContactId);
                parameters.Add("@CategoryId", request.CategoryId);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdatePostResult>(cnn: connect,
                                                    sql: "sp_UpdatePost",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<DeletePostResult> DeletePost(DeletePostRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PostId", request.PostId);
                return await SqlMapper.QueryFirstOrDefaultAsync<DeletePostResult>(cnn: connect,
                                                    sql: "sp_DeletePost",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Post>> Gets()
        {
            //var sql = "SELECT CategoryId, CategoryName FROM [dbo].[Category] WHERE IsDeleted =0";
            //return await SqlMapper.QueryAsync<Category>(cnn: connect, sql: sql, commandType: CommandType.Text);
            return await SqlMapper.QueryAsync<Post>(cnn: connect,
                                                sql: "sp_GetPost",
                                                commandType: CommandType.StoredProcedure);
        }
    }
}

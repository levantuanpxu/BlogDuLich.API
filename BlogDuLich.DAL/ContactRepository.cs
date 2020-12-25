using BlogDuLich.DAL.Interface;
using BlogDuLich.Domain.Request.Contact;
using BlogDuLich.Domain.Response.Contact;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace BlogDuLich.DAL
{
    public class ContactRepository : BaseRepository, IContactRepository
    {
        public async Task<CreateContactResult> CreateContact(CreateContactRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Name", request.Name);
                parameters.Add("@Gmail", request.Gmail);
                parameters.Add("@Subject", request.Subject);
                parameters.Add("@Messages", request.Messages);                      
                return await SqlMapper.QueryFirstOrDefaultAsync<CreateContactResult>(cnn: connect,
                                                    sql: "sp_CreateContact",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<UpdateContactResult> UpdateContact(UpdateContactRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ContactId", request.ContactId);
                parameters.Add("@Name", request.Name);
                parameters.Add("@Gmail", request.Gmail);
                parameters.Add("@Subject", request.Subject);
                parameters.Add("@Messages", request.Messages);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateContactResult>(cnn: connect,
                                                    sql: "sp_UpdateContact",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<DeleteContactResult> DeleteContact(DeleteContactRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ContactId", request.ContactId);
                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteContactResult>(cnn: connect,
                                                    sql: "sp_DeleteContact",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Contact>> Gets()
        {
            //var sql = "SELECT CategoryId, CategoryName FROM [dbo].[Category] WHERE IsDeleted =0";
            //return await SqlMapper.QueryAsync<Category>(cnn: connect, sql: sql, commandType: CommandType.Text);
            return await SqlMapper.QueryAsync<Contact>(cnn: connect,
                                                sql: "sp_GetContact",
                                                commandType: CommandType.StoredProcedure);
        }
    }
}

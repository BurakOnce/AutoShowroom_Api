﻿using AutoShowroom_Api.Dtos.ContactDtos;
using AutoShowroom_Api.Models.DapperContext;
using Dapper;

namespace AutoShowroom_Api.Repositories.ContactRepositories
{
    
        public class ContactRepository : IContactRepository
        {
            private readonly Context _context;
            public ContactRepository(Context context)
            {
                _context = context;
            }
            public Task CreateContact(CreateContactDto createContactDto)
            {
                throw new NotImplementedException();
            }

        public async Task<List<Last4ContactResultDto>> GetLast4Contact()
        {
            string query = "Select Top(4) * From Contact order by ContactID Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Last4ContactResultDto>(query);
                return values.ToList();
            }
        }

        public Task DeleteContact(int id)
            {
                throw new NotImplementedException();
            }

            public Task<List<ResultContactDto>> GetAllContactAsync()
            {
                throw new NotImplementedException();
            }

            public Task<GetByIDContactDto> GetContact(int id)
            {
                throw new NotImplementedException();
            }


        }
    
}

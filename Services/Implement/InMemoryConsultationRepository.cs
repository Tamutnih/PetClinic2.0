﻿using ClinicService.Models;

namespace ClinicService.Services.Implementation
{

    /// <summary>
    /// Реализация хранения данных записей в памяти приложения
    /// </summary>
    public class InMemoryConsultationRepository : IConsultationRepository
    {
        public int Create(Consultation item)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Consultation> GetAll()
        {
            throw new NotImplementedException();
        }

        public Consultation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Consultation item)
        {
            throw new NotImplementedException();
        }
    }
}
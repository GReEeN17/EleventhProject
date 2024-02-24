using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleventhProject.Server.Application.Contracts.DonationHistory;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.DonationHistory;

public class DonationHistoryService : IDonationHistoryService
{
    public Task<DonationHistoryModel> CreateDonationHistory(PetModel recipient, PetModel donor, DateTime date)
    {
        throw new NotImplementedException();
    }

    public Task<DonationHistoryModel> GetDonationHistoryById(int donationHistoryId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<DonationHistoryModel> GetAllDonationHistory()
    {
        throw new NotImplementedException();
    }
}
﻿using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public interface IProjectionRepository
    {
        List<ProjectionModel> GetAllProjections();

        ProjectionModel GetProjectionById(int id);  

        ProjectionModel GetProjectionByMovieId(int movieId);
    }
}

using DinkToPdf.Contracts;
using DinkToPdf;
//using ERPRetailProAPI.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Respositeries;
using Respositeries.DAServices;
//using Respositeries.Services;
using Services;
//using Services.Interfaces.Common;
using Services.Interfaces.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Respositeries.Services.Marketplace;
//using Services.Interfaces.MarketplaceUser;
using Microsoft.AspNetCore.Http;
//using Services.Interfaces.MarketplaceDealer;

namespace ERPRetailProAPI.BusinessLogics.ServiceRegistrations
{
    public static class BusinessLogicRegistration
    {
        public static void AddMyServices(IServiceCollection services)
        {
            services.AddScoped<ITokenManager, TokenManager>();
            services.AddScoped<IErrorService, ErrorManager>();
            services.AddScoped<IUserService, UserService>();
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }
    }
}

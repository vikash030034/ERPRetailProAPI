using Data;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respositeries
{
    public class ErrorManager : BaseService, IErrorService
    {
        private readonly ERPRetailProDbContext _context;
        private readonly IConfiguration _configuration;

        public ErrorManager(ERPRetailProDbContext context, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
            : base(httpContextAccessor, context)
        {
            this._context = context;
            this._configuration = configuration;
        }
        public void addErrorLog(ErrorLogs error)
        {
            _context.ErrorLogs.Add(new ErrorLogs {
                CreatedAT= DateTime.UtcNow,
                LocationController = error.LocationController,
                Message=error.Message
            });
        }
    }
}

using Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Respositeries
{
    public abstract class BaseService
    {
        protected readonly IHttpContextAccessor _httpContextAccessor;
        protected readonly ERPRetailProDbContext _context;
        protected readonly string _tenantId;
        protected readonly string _userId;

        public BaseService(IHttpContextAccessor httpContextAccessor, ERPRetailProDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            //_tenantId = _httpContextAccessor.HttpContext?.User?.Claims?.FirstOrDefault(c => c.Type == "TenantId")?.Value;
            //if (_tenantId!= null)
            //{
            //    _context.TenantId = Convert.ToInt32(_tenantId);
            //}
            _context.TenantId = 1;
        }

    }
}

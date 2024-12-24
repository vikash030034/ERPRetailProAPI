using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services.Interfaces.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Jwt.AccessToken;

namespace Respositeries.DAServices
{
    public class UserService : IUserService
    {
        private readonly ERPRetailProDbContext _context;
        public UserService(ERPRetailProDbContext context) {  _context = context; }

        public  bool CheckUserPasswordAsync(Users user, string pwd)
        {
            string strKeyword = "$12TcA#";
            string encryptedPassword = "";
            System.Security.Cryptography.SHA1 sha = System.Security.Cryptography.SHA1.Create();
            byte[] preHash = System.Text.Encoding.UTF8.GetBytes((pwd+ strKeyword));
            byte[] hash = sha.ComputeHash(preHash);
            encryptedPassword = System.Convert.ToBase64String(hash, 0, 15);
            encryptedPassword = encryptedPassword.Substring(0, 10);
            if(user.UPWD_N== encryptedPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static char Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            char[] charArr = result.ToCharArray();
            return charArr[0];
        }

        public static int Asc(char String)
        {
            int num;
            byte[] numArray;
            int num1 = Convert.ToInt32(String);
            if (num1 >= 128)
            {
                try
                {
                    Encoding fileIOEncoding = Encoding.Default;
                    char[] str = new char[] { String };
                    if (!fileIOEncoding.IsSingleByte)
                    {
                        numArray = new byte[2];
                        if (fileIOEncoding.GetBytes(str, 0, 1, numArray, 0) != 1)
                        {
                            if (BitConverter.IsLittleEndian)
                            {
                                byte num2 = numArray[0];
                                numArray[0] = numArray[1];
                                numArray[1] = num2;
                            }
                            num = BitConverter.ToInt16(numArray, 0);
                        }
                        else
                        {
                            num = numArray[0];
                        }
                    }
                    else
                    {
                        numArray = new byte[1];
                        fileIOEncoding.GetBytes(str, 0, 1, numArray, 0);
                        num = numArray[0];
                    }
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
            else
            {
                num = num1;
            }
            return num;
        }


        public async Task<Users> FindByUserAsync(string userId)
        {
            return await _context.Users.Where(a=>a.Abbr==userId).FirstOrDefaultAsync();
        }

      

        public async Task<IEnumerable<Users>> GetAllUsersList()
        {
            return await _context.Users.ToListAsync();
        }
    }
}

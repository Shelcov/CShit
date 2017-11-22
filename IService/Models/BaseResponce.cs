using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Models
{
    public class BaseResponce
    {
        /// <summary>
        /// успешность операции
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// сообщение
        /// </summary>
        public string Message { get; set; }
    }
}

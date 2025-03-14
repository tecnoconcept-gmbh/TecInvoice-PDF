using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecInvoice_PDF.Config
{
    public interface IConfig
    {
        string xmlFilePath { get; set; }
        string pdfFilePath { get; set; }
    }
}

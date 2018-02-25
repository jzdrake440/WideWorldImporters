using DataTables.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTables.Models
{
    public interface IPpeProfile
    {
        PpeService BuildService();
    }
}

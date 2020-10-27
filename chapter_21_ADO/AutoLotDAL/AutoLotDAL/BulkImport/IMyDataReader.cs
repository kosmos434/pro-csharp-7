using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using AutoLotDAL.Models;

namespace AutoLotDAL.BulkImport
{
    public interface IMyDataReader<T> : IDataReader
    {
        List<T> Records { get; set; }
    }
}

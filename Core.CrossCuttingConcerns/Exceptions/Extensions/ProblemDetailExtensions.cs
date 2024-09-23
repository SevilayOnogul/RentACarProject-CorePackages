using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.Extensions;

public static class ProblemDetailExtensions
{
    public static string AsJson<TProblemDetail>(this TProblemDetail detail)
        where TProblemDetail : ProblemDetails=>JsonSerializer.Serialize(detail);
}

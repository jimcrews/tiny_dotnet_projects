﻿using DI_Lifetime.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_Lifetime.Middleware
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<CustomMiddleware> _logger;

        public CustomMiddleware(RequestDelegate next, ILogger<CustomMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, GuidService guidService)
        {
            var logMessage = $"Middleware: The GUID from " +
                             $"GuidService is {guidService.GetGuid()}";

            _logger.LogInformation(logMessage);

            context.Items.Add("MiddlewareGuid", logMessage);

            // Call the next delegate/middleware in the pipeline
            await _next(context);
        }
    }
}

namespace Hashdji.Software.Wentikoo.Extensions
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class ControllerExtension
    {
        public static IActionResult Created(this ControllerBase controller)
        {
            controller.Response.Headers.Add("Message", "Created");
            return new StatusCodeResult(201);
        }

        public static IActionResult Deleted(this ControllerBase controller)
        {
            controller.Response.Headers.Add("Message", "Deleted");
            return new StatusCodeResult(204);
        }

        public static IActionResult Updated(this ControllerBase controller)
        {
            controller.Response.Headers.Add("Message", "Updated");
            return new StatusCodeResult(204);
        }
    }
}

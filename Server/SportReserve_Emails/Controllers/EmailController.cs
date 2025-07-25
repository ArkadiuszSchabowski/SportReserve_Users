﻿using Microsoft.AspNetCore.Mvc;
using SportReserve_Emails.Interfaces;
using SportReserve_Emails.Models;

namespace SportReserve_Emails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _service;

        public EmailController(IEmailService service)
        {
            _service = service;
        }
        [HttpPost("send-one")]
        public async Task<ActionResult> SendEmail([FromBody] SendEmailDto dto)
        {
            await _service.SendEmail(dto);
            return Ok();
        }

        [HttpPost("send-many")]
        public async Task<ActionResult> SendManyEmails([FromBody] List<SendEmailsDto> dto)
        {
            await _service.SendManyEmails(dto);
            return Ok();
        }
    }
}

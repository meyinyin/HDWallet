﻿using System;
using HDWallet.Core;
using HDWallet.Tron;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HDWallet.Api.V1.Controllers.Tron
{
    [ApiController]
    [ApiVersion( "1.0" )]
    [Route("api/v{version:apiVersion}")]
    public class TronHDWalletController : Secp256k1HDWalletController<TronWallet>
    {
        public TronHDWalletController(
            ILogger<TronHDWalletController> logger,
            Func<IHDWallet<TronWallet>> hDWallet) : base(logger, hDWallet) {}

        [HttpGet("/Tron/{account}/external/{index}")]
        public ActionResult<string> GetDeposit(uint account, uint index)
        {
            return base.DepositWallet(account, index);
        }

        [HttpGet("/Tron/{account}/internal/{index}")]
        public ActionResult<string> GetChange(uint account, uint index)
        {
            return base.ChangeWallet(account, index);
        }
    }
}

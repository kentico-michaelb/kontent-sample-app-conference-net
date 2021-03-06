﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kentico.Kontent.Delivery;
using KenticoKontentModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace kontent_sample_app_conference_net.Controllers
{
    public class RegistrationController : BaseController
    {
        public RegistrationController(IDeliveryClient deliveryClient, IConfiguration configuration) : base(deliveryClient, configuration)
        {

        }

        public async Task<ViewResult> Index(string location)
        {
            ViewBag.location = location;

            DeliveryItemListingResponse<Registration> response = await DeliveryClient.GetItemsAsync<Registration>(
                new EqualsFilter("system.type", "registration")
                );
            return View(response.Items[0]);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kentico.Kontent.Delivery;
using KenticoKontentModels;
using Microsoft.AspNetCore.Mvc;

namespace kontent_sample_app_conference_net.Controllers
{
    public class SponsorsController : BaseController
    {
        public SponsorsController(IDeliveryClient deliveryClient) : base(deliveryClient)
        {

        }

        public async Task<ViewResult> Index(string location)
        {
            ViewBag.location = location;

            DeliveryItemListingResponse<Sponsor> response = await DeliveryClient.GetItemsAsync<Sponsor>(
                new EqualsFilter("system.type", "sponsor")
                );
            return View(response.Items);
        }
    }
}
﻿using Modelo_PixSafra.Models.Interfaces;

namespace Modelo_PixSafra.Models.Endpoints
{
    public class Webhook :  IEndpointSafra
    {
        public string Homologacao { get; set; }
        public string Producao { get; set; }
    }
}

using Modelo_PixSafra.Enumeradores;
using Modelo_PixSafra.Models.Endpoints;

namespace Modelo_PixSafra.Models
{
    public class EndpointsSafra
    {
        public Portal Portal { get; set; }
        public Gateway Gateway { get; set; }
        public Reconciliation Reconciliation { get; set; }
        public Webhook Webhook { get; set; }
        public OAuth OAuth { get; set; }


        public EndpointsSafra InserirEndpointPadrao()
        {
            EndpointsSafra endpointSafra = new();
            Portal portal = new();
            Gateway gateway = new();
            Reconciliation reconciliation = new();
            Webhook webhook = new();
            OAuth oAuth = new();

            portal.Homologacao = EnumUrlEndpointsHom.Portal.GetDescription();
            gateway.Homologacao = EnumUrlEndpointsHom.Gateway.GetDescription();
            reconciliation.Homologacao = EnumUrlEndpointsHom.Reconciliation.GetDescription();
            webhook.Homologacao = EnumUrlEndpointsHom.Webhook.GetDescription();
            oAuth.Homologacao = EnumUrlEndpointsHom.OAuth.GetDescription();

            endpointSafra.Portal = portal;
            endpointSafra.Gateway = gateway;
            endpointSafra.Reconciliation = reconciliation;
            endpointSafra.Webhook = webhook;
            endpointSafra.OAuth = oAuth;

            return endpointSafra;
        }
    }
}

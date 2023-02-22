using System.ComponentModel;

namespace Modelo_PixSafra.Enumeradores
{
    public enum EnumUrlEndpointsHom
    {
        //Url do portal de desenvolvimento.| {{ENDPOINT_PORTAL}}
        [Description("https://portal-api-hml.safrapay.com.br")]
        Portal,

        //Url do gateway de desenvolvimento. | {{ENDPOINT_GATEWAY}}
        [Description("https://payment-hml.safrapay.com.br")]
        Gateway,

        //Url do reconciliation de desenvolvimento. | {{ENDPOINT_RECONCILIATION}}
        [Description("https://reconciliation-hml.safrapay.com.br")]
        Reconciliation,

        //Url do Webhook de desenvolvimento. | {{ENDPOINT_WEBHOOK}}
        [Description("https://webhook-hml.safrapay.com.br")]
        Webhook,

        //Url utilizada para acessar o portal de desenvolvimento. | {{OAUTH_URL}}
        [Description("https://portal-hml.safrapay.com.br")]
        OAuth
    }
}

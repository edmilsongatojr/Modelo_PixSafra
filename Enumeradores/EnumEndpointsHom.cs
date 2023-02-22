using System.ComponentModel;

namespace Modelo_PixSafra.Enumeradores
{
    public enum EnumEndpointsHom
    {
        //PORTAL ENDPOINT

        //O Endpoint é utilizado para fazer login no portal da Safrapay, sem que o usuário precise inserir login e senha.  
        [Description("/v1/Login/GenerateToken")]
        GenerateToken,

        //GATEWAY ENDPOINT

        //O Endpoint é utilizado para gerar um par de acessos, token de acesso e token de atualização, que são necessários para consumir a API. 
        [Description("/v2/merchant/auth")]
        Auth,

        //O endpoint responsável por criar um QRCode para transação pix.  
        [Description("/v2/charge/pix")]
        Pix
    }   
}

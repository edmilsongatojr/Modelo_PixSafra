using System.ComponentModel;

namespace Modelo_PixSafra.Enumeradores
{
    public enum EnumEndpointsHom
    {
        //O Endpoint é utilizado para fazer login no portal da Safrapay, sem que o usuário precise inserir login e senha.  
        [Description("/v1/Login/GenerateToken")]
        GenerateToken
    }   
}

using EcommerceCheckout.App;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    private readonly PedidoService _service = new();

    [Fact]
    public void GerarCodigoRastreio_SudesteE42_RetornaSUDESTE0042()
    {
        var resultado = _service.GerarCodigoRastreio("sudeste", 42);
        Assert.Equal("SUDESTE-0042", resultado);
    }

    [Fact]
    public void CalcularPontosFidelidade_150_Retorna30()
    {
        var resultado = _service.CalcularPontosFidelidade(150);
        Assert.Equal(30, resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_VipAbaixoDe200_RetornaTrue()
    {
        var resultado = _service.TemDireitoAFreteGratis(150, true);
        Assert.True(resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_NaoVipAbaixoDe200_RetornaFalse()
    {
        var resultado = _service.TemDireitoAFreteGratis(150, false);
        Assert.False(resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_NaoVipExatamente200_RetornaTrue()
    {
        var resultado = _service.TemDireitoAFreteGratis(200, false);
        Assert.True(resultado);
    }
}
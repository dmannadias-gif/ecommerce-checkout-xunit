# ecommerce-checkout-xunit

Solução .NET 10 com cálculo de rastreio, pontos de fidelidade e frete grátis de uma loja online, coberta por testes unitários com xUnit.

## Estrutura

- `EcommerceCheckout.App` — código de produção (`PedidoService`)
- `EcommerceCheckout.Tests` — testes unitários (`PedidoServiceTests`)

## Métodos

| Método | Retorno | Regra |
|---|---|---|
| `GerarCodigoRastreio(string regiao, int numeroPedido)` | `string` | Região em maiúsculas + número com 4 dígitos. Ex.: `("sudeste", 42)` → `"SUDESTE-0042"` |
| `CalcularPontosFidelidade(int valorTotal)` | `int` | 2 pontos a cada R$ 10 completos. Ex.: `150` → `30` |
| `TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)` | `bool` | `true` se valor ≥ R$ 200 ou cliente VIP |

## Cobertura dos testes

| Teste | Assert | Cenário |
|---|---|---|
| GerarCodigoRastreio | `Assert.Equal` | "sudeste", 42 → "SUDESTE-0042" |
| CalcularPontosFidelidade | `Assert.Equal` | 150 → 30 |
| Frete grátis VIP | `Assert.True` | 150, VIP |
| Frete grátis não-VIP | `Assert.False` | 150, não-VIP |
| Frete grátis limite | `Assert.True` | 200, não-VIP (valor-limite) |

## Como executar

Pré-requisito: .NET 10 SDK

```bash
git clone https://github.com/dmannadias-gif/ecommerce-checkout-xunit.git
cd ecommerce-checkout-xunit
dotnet test
```

## Licença

MIT

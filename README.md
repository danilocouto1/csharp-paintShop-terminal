# PaintShop - Calculadora de Tinta

Este é um programa simples em C# que ajuda a calcular a quantidade de tinta necessária para pintar áreas de diferentes tamanhos. Foi desenvolvido por Danilo Couto.

## Autor

- **Danilo Couto**
- E-mail: dansantos45@hotmail.com
- LinkedIn: [Danilo Couto no LinkedIn](https://www.linkedin.com/in/danilocoutopsantos/)

## Descrição

O programa fornece um conjunto de classes e métodos para calcular a quantidade de tinta necessária para pintar diferentes áreas, como paredes individuais e salas inteiras. Ele também ajuda a calcular o custo total com base no preço da tinta por balde.

## Classes e Métodos

O programa inclui as seguintes classes e métodos:

1. **Classe Wall (Parede):**

    - Propriedades:
      - `Width`: Largura da parede.
      - `Height`: Altura da parede.
      - `ExcludedArea`: Área que não será pintada (opcional).
      - `PaintableArea`: Área que pode ser pintada.

2. **Classe Room (Sala):**

    - Propriedades:
      - `TotalPaintableArea`: Calcula a área total a ser pintada em uma sala com base nas paredes.
      - `walls`: Array de objetos de parede que compõem a sala.

3. **Classe PaintUtilities (Utilitários de Pintura):**

    - Propriedades:
      - `SquareMetersPerBucket`: Calcula a quantidade de metros quadrados que um balde de tinta pode cobrir.
      - `BucketSizeLiters`: Tamanho em litros de um balde de tinta.
      - `SquareMetersPerLiter`: Quantos metros quadrados um litro de tinta pode cobrir.

    - Métodos:
      - `GetNeededPaintBuckets`: Calcula a quantidade de baldes de tinta necessários com base na área a ser pintada.
      - `CalculateCost`: Calcula o custo total da tinta com base no preço por balde e na área a ser pintada.

## Como Usar

```csharp
// Exemplo de uso do programa
Wall wall = new Wall(4.0, 3.0); // Cria uma parede com largura de 4 metros e altura de 3 metros
double areaToPaint = wall.PaintableArea;

Room room = new Room(new Wall[] { wall, wall, wall }); // Cria uma sala com três paredes idênticas
double totalAreaToPaint = room.TotalPaintableArea;

decimal pricePerBucket = 50.0; // Preço por balde de tinta
int neededBuckets = PaintUtilities.GetNeededPaintBuckets(areaToPaint);
decimal totalCost = PaintUtilities.CalculateCost(pricePerBucket, areaToPaint);

// Output
Console.WriteLine($"Área da parede a ser pintada: {areaToPaint} metros quadrados");
Console.WriteLine($"Área total da sala a ser pintada: {totalAreaToPaint} metros quadrados");
Console.WriteLine($"Número de baldes de tinta necessários: {neededBuckets}");
Console.WriteLine($"Custo total da tinta: ${totalCost}");
```
## Dependências

Este programa não possui dependências externas, além das bibliotecas padrão do C#.

## Licença

Este programa é de código aberto e está disponível sob a licença MIT. Você pode encontrar mais detalhes na [licença](LICENSE) deste projeto.

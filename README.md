### Desafio Hepta

---

#### **Tecnologias Envolvidas**

1. **C#:**  
   Linguagem de programação principal utilizada no projeto.

2. **.NET Core:**  
   Plataforma utilizada para construir a aplicação, garantindo portabilidade, desempenho e escalabilidade, além de permitir a integração com ferramentas como **xUnit** para testes automatizados.

3. **xUnit:**  
   Framework de teste unitário escolhido devido à sua simplicidade.

---

#### **Algoritmos Utilizados**

O projeto implementa uma lógica para calcular as variáveis binárias `gama` e `epsilon` com base em listas de números binários. A lógica segue o seguinte processo:

1. **Iteração por Colunas:**  
   A lista de números binários é tratada como uma matriz lógica. Cada posição da string representa uma coluna, e cada coluna é processada individualmente.

2. **Contagem de Bits (1 e 0):**  
   Para cada coluna, o algoritmo conta o número de bits 1 e 0. A lógica identifica o bit mais comum (para gama) e o menos comum (para epsilon).

3. **Construção dos Resultados:**  
   Os resultados binários são concatenados bit a bit com base nos cálculos e, ao final, convertidos para valores decimais.

---

#### **Padrão de Projeto Utilizado: Strategy**

##### **Motivo da Escolha**
O **Strategy Pattern** foi adotado devido à necessidade de encapsular diferentes variações da lógica de cálculo (`gama` e `epsilon`) sem duplicar código ou tornar o sistema rígido. Dessa forma garantimos uma melhor Flexibilidade, Responsabilidade Única, Testabilidade, Extensibilidade.

---

#### **Implementação do Strategy Pattern**

1. **Interface `ISubmarineCalculatorStrategy`:**  
   Define o contrato comum para todas as estratégias. Isso garante que qualquer nova estratégia deve implementar o método `Calculate`, recebendo uma lista de números binários como entrada.

2. **Estratégias Concretas (`EnergyGamaCalculation` e `EnergyEpsilonCalculation`):**  
   Cada estratégia implementa a lógica de cálculo para sua métrica específica:
   - `EnergyGamaCalculation`: Calcula o bit mais comum em cada coluna.
   - `EnergyEpsilonCalculation`: Calcula o bit menos comum em cada coluna.

3. **Contexto (`Submarine`):**  
   O contexto herda da interface ISubmarine que possui o método Energy, onde delega o cálculo para a estratégia correspondente. Isso desacopla o cliente da lógica específica de cada cálculo.

---

#### **Vantagens do Strategy Pattern no Contexto**

- **Manutenção Facilitada**  

- **Redução de Duplicação**  

- **Clareza do Código**

---

#### **Conclusão**

O uso do **Strategy Pattern** neste projeto proporciona uma solução limpa, modular e extensível para lidar com cálculos binários variados. Essa escolha foi motivada pela necessidade de flexibilizar a lógica de cálculo, mantendo o código alinhado aos princípios de boas práticas como SOLID. A implementação modular também facilita a manutenção, reduz o acoplamento e melhora a cobertura de testes automatizados. 

Esse design garante que o sistema possa ser adaptado facilmente a novos requisitos, permitindo escalabilidade e reutilização do código.


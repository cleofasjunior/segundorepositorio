# 🧠 Fluxo Lógico do Sistema de Notas

Este documento descreve o algoritmo utilizado para determinar a situação acadêmica do aluno. O objetivo é garantir que a regra de negócio seja transparente e auditável.

## 📝 Regras de Negócio

O sistema recebe duas notas (N1 e N2), calcula a média aritmética simples e aplica as seguintes condições:

1.  **Aprovação:** Média igual ou superior a **7.0**.
2.  **Recuperação:** Média entre **5.0** e **6.9**.
3.  **Reprovação:** Média inferior a **5.0**.

## 🔄 Fluxograma do Algoritmo

```mermaid
graph TD
    A[Início] --> B[/Receber Nome do Aluno/]
    B --> C[/Receber Nota 1/]
    C --> D[/Receber Nota 2/]
    D --> E[Calcular Média = N1 + N2 / 2]
    
    E --> F{Média >= 7?}
    F -- Sim --> G[Definir Status: APROVADO 🟢]
    F -- Não --> H{Média >= 5?}
    
    H -- Sim --> I[Definir Status: RECUPERAÇÃO 🟡]
    H -- Não --> J[Definir Status: REPROVADO 🔴]
    
    G --> K[Exibir Relatório Final]
    I --> K
    J --> K
    K --> L[Fim]
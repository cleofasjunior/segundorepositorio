# Sistema de Notas em Python
import os

def limpar_tela():
    # Comando para limpar tela dependendo do sistema (Windows ou Linux/Mac)
    os.system('cls' if os.name == 'nt' else 'clear')

def main():
    limpar_tela()
    print("=== 🎓 Sistema de Cálculo de Médias (Python) 🎓 ===")
    
    # 1. Entrada de Dados
    nome_aluno = input("Digite o nome do aluno: ")
    
    # float() converte o texto para número decimal
    nota1 = float(input("Digite a primeira nota: "))
    nota2 = float(input("Digite a segunda nota: "))
    
    # 2. Processamento
    media = (nota1 + nota2) / 2
    
    # 3. Lógica de Decisão (If / Elif / Else)
    if media >= 7:
        status = "APROVADO 🟢"
    elif media >= 5:
        status = "EM RECUPERAÇÃO 🟡"
    else:
        status = "REPROVADO 🔴"
        
    # 4. Saída (f-string para formatação)
    print("-" * 30)
    print(f"Aluno: {nome_aluno}")
    print(f"Média Final: {media:.1f}") # .1f limita a 1 casa decimal
    print(f"Situação: {status}")
    print("-" * 30)

if __name__ == "__main__":
    main()
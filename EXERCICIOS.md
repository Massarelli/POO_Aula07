# 📚 Exercícios de Sobrecarga de Métodos (Overload) — C#

Os exercícios abaixo foram pensados para alunos que já conhecem:

- classes
- métodos
- atributos
- construtores
- encapsulamento
- herança básica

E agora precisam praticar **sobrecarga de métodos**.

---

# 🎯 Objetivo da Aula

Fazer os alunos entenderem que:

> Sobrecarga é quando temos vários métodos com o mesmo nome, mas com parâmetros diferentes.

---

# ✅ Exercício 1 — Calculadora

## 🎯 Objetivo
Criar uma classe `Calculadora` utilizando sobrecarga no método `Somar`.

---

# 📌 Requisitos

Criar os métodos:

```csharp
Somar(int a, int b)
Somar(double a, double b)
Somar(int a, int b, int c)
```

---

# ✅ Exemplo esperado

```text
10
15.5
30
```

---

# 🚀 Desafio extra

Criar também:

```csharp
Subtrair()
Multiplicar()
Dividir()
```

Com sobrecarga.

---

# ✅ Exercício 2 — Cadastro de Produto

## 🎯 Objetivo
Trabalhar construtores sobrecarregados.

---

# 📌 Criar classe

```csharp
Produto
```

---

# 📌 Atributos

- Nome
- Preco
- Estoque

---

# 📌 Requisitos

Criar 3 construtores:

```csharp
Produto()

Produto(string nome)

Produto(string nome, double preco, int estoque)
```

---

# ✅ Exemplo esperado

```text
Produto criado sem dados
Produto: Notebook
Produto: Mouse - R$ 150
```

---

# 🚀 Desafio extra

Adicionar validações no construtor.

---

# ✅ Exercício 3 — Sistema de Login

## 🎯 Objetivo
Utilizar sobrecarga em métodos de autenticação.

---

# 📌 Criar classe

```csharp
Usuario
```

---

# 📌 Criar métodos

```csharp
Login(string email)

Login(string email, string senha)

Login(string email, string senha, string token)
```

---

# ✅ Regras

Cada método deve exibir uma mensagem diferente.

---

# ✅ Exemplo esperado

```text
Login por email

Login com email e senha

Login com autenticação em duas etapas
```

---

# ✅ Exercício 4 — Envio de Notificações

## 🎯 Objetivo
Praticar overload em cenários reais.

---

# 📌 Criar classe

```csharp
Notificacao
```

---

# 📌 Métodos

```csharp
Enviar(string mensagem)

Enviar(string mensagem, string usuario)

Enviar(string mensagem, string usuario, bool urgente)
```

---

# ✅ Exemplo esperado

```text
Mensagem enviada

Mensagem enviada para Leonardo

Mensagem URGENTE enviada
```

---

# ✅ Exercício 5 — Conversor de Temperatura

## 🎯 Objetivo
Praticar sobrecarga com tipos diferentes.

---

# 📌 Criar classe

```csharp
Conversor
```

---

# 📌 Métodos

```csharp
Converter(double celsius)

Converter(int fahrenheit)
```

---

# ✅ Regras

- Celsius → Fahrenheit
- Fahrenheit → Celsius

---

# 🚀 Desafio extra

Adicionar Kelvin.

---

# ✅ Exercício 6 — Impressora

## 🎯 Objetivo
Entender como o mesmo método pode imprimir conteúdos diferentes.

---

# 📌 Criar classe

```csharp
Impressora
```

---

# 📌 Métodos

```csharp
Imprimir(string texto)

Imprimir(int numero)

Imprimir(double valor)

Imprimir(string texto, int copias)
```

---

# ✅ Exemplo esperado

```text
Texto: Olá

Número: 10

Valor: 15.5

Imprimindo 3 cópias...
```

---

# ✅ Exercício 7 — Agendamento Médico

## 🎯 Objetivo
Trabalhar overload em cenários mais próximos do mercado.

---

# 📌 Criar classe

```csharp
Consulta
```

---

# 📌 Métodos

```csharp
Agendar(string paciente)

Agendar(string paciente, string medico)

Agendar(string paciente, string medico, DateTime data)
```

---

# ✅ Exemplo esperado

```text
Consulta agendada

Consulta agendada com médico

Consulta agendada com data definida
```

---

# 🏆 Exercício Desafio Final

# 🎮 Sistema de Personagens

## 🎯 Objetivo
Misturar:
- classes
- métodos
- encapsulamento
- construtores
- sobrecarga

---

# 📌 Criar classe

```csharp
Personagem
```

---

# 📌 Atributos

- Nome
- Vida
- Nivel

---

# 📌 Criar métodos sobrecarregados

```csharp
Atacar()

Atacar(string habilidade)

Atacar(string habilidade, int danoExtra)
```

---

# ✅ Exemplo esperado

```text
Ataque básico

Ataque usando Fireball

Ataque usando Fireball com dano extra
```

---

# 🚀 SUPER DESAFIO

Adicionar:

- inimigos
- sistema de batalha
- barra de vida
- crítico
- defesa

---

# 💡 Dica para os alunos

Sobrecarga depende de:

- quantidade de parâmetros
OU
- tipo dos parâmetros

---

# ❌ NÃO É SOBRECARGA

```csharp
void Somar(int a, int b)

int Somar(int a, int b)
```

Porque mudou apenas o retorno.

---

# ✅ É SOBRECARGA

```csharp
void Somar(int a, int b)

void Somar(double a, double b)

void Somar(int a, int b, int c)
```
# Especificação de Projeto

## Personas
# 👥 Personas do Sistema de E-commerce

---

## 🛍️ Persona 1 – Cliente Final

**Nome:** Juliana Ribeiro  
**Idade:** 28 anos  
**Profissão:** Analista de Marketing  
**Localização:** São Paulo – SP  
**Descrição:**  
Juliana adora fazer compras online, principalmente em promoções. Usa o celular para quase tudo, valoriza uma experiência fluida, rápida e segura. Gosta de comparar produtos, ler comentários e compartilhar links com amigos.

**Objetivos:**
- Encontrar produtos com facilidade.
- Finalizar compras de forma rápida e segura.
- Receber notificações de promoções.

**Frustrações:**
- Sites lentos ou com muitas etapas até a finalização da compra.
- Falta de informações claras sobre frete ou política de devolução.

---

## 📦 Persona 2 – Administrador do Sistema

**Nome:** Marcos Silva  
**Idade:** 35 anos  
**Profissão:** Gerente de E-commerce  
**Localização:** Belo Horizonte – MG  
**Descrição:**  
Marcos é responsável por manter o sistema rodando bem. Ele atualiza produtos, monitora vendas, acompanha o estoque e cuida das promoções. Valoriza dashboards intuitivos, agilidade e segurança no painel administrativo.

**Objetivos:**
- Cadastrar e editar produtos rapidamente.
- Visualizar relatórios com indicadores de vendas.
- Gerenciar usuários e cupons com facilidade.

**Frustrações:**
- Painéis administrativos lentos ou com excesso de cliques.
- Falta de filtros ou opções para exportar dados.

---

## 💬 Persona 3 – Atendente de Suporte

**Nome:** Fernanda Costa  
**Idade:** 24 anos  
**Profissão:** Suporte ao Cliente  
**Localização:** Recife – PE  
**Descrição:**  
Fernanda lida com trocas, dúvidas e reclamações de clientes. Usa o sistema para consultar pedidos, status de entrega e iniciar processos de reembolso. Precisa de agilidade e precisão nas informações para resolver chamados rapidamente.

**Objetivos:**
- Acessar rapidamente o histórico de pedidos de clientes.
- Iniciar devoluções ou reembolsos com poucos cliques.
- Notificar clientes de forma automática.

**Frustrações:**
- Informações de pedidos desatualizadas.
- Falta de integração entre pedidos e logística.

---

## Histórias de usuário

---

## 1. Cadastro e Autenticação

- **HU01.** Como **cliente**, quero **criar uma conta com nome, e-mail e senha**, para que **eu possa realizar compras no site**.  
- **HU02.** Como **cliente**, quero **recuperar minha senha pelo e-mail**, para que **eu possa acessar minha conta mesmo se esquecer a senha**.  
- **HU03.** Como **cliente**, quero **entrar usando minha conta do Google ou Facebook**, para que **eu não precise preencher formulários longos**.  
- **HU04.** Como **cliente**, quero **habilitar autenticação em dois fatores**, para que **minha conta fique mais segura**.

---

## 2. Gerenciamento de Produtos (Admin)

- **HU05.** Como **administrador**, quero **cadastrar novos produtos com nome, imagens e preço**, para que **eles fiquem disponíveis para venda**.  
- **HU06.** Como **administrador**, quero **editar e remover produtos existentes**, para que **eu possa manter o catálogo atualizado**.  
- **HU07.** Como **administrador**, quero **associar categorias e tags aos produtos**, para que **os clientes possam encontrá-los com mais facilidade**.

---

## 3. Navegação e Busca

- **HU08.** Como **cliente**, quero **navegar por categorias e aplicar filtros**, para que **eu encontre o produto ideal mais rapidamente**.  
- **HU09.** Como **cliente**, quero **usar a busca com sugestões automáticas**, para que **eu encontre produtos mesmo com termos aproximados**.  
- **HU10.** Como **cliente**, quero **ver recomendações de produtos**, para que **eu descubra itens relacionados ao meu interesse**.

---

## 4. Carrinho e Checkout

- **HU11.** Como **cliente**, quero **adicionar produtos ao carrinho**, para que **eu possa comprar vários itens de uma vez**.  
- **HU12.** Como **cliente**, quero **escolher entre boleto, Pix ou cartão de crédito**, para que **eu possa pagar da forma que preferir**.  
- **HU13.** Como **cliente**, quero **salvar meus endereços de entrega**, para que **eu não precise digitar tudo novamente a cada compra**.

---

## 5. Pós-Venda

- **HU14.** Como **cliente**, quero **avaliar um produto após a entrega**, para que **outros clientes saibam minha opinião**.  
- **HU15.** Como **cliente**, quero **ver o histórico dos meus pedidos**, para que **eu possa acompanhar minhas compras anteriores**.  
- **HU16.** Como **cliente**, quero **solicitar devolução ou reembolso com poucos cliques**, para que **eu tenha segurança ao comprar**.

---

## 6. Painel Administrativo

- **HU17.** Como **administrador**, quero **gerenciar usuários da plataforma**, para que **eu possa controlar os acessos e permissões**.  
- **HU18.** Como **administrador**, quero **configurar banners e promoções**, para que **o site fique mais atrativo e atualizado**.

---

## 7. Funcionalidades Avançadas

- **HU19.** Como **cliente**, quero **adicionar produtos à minha wishlist**, para que **eu possa comprá-los mais tarde**.  
- **HU20.** Como **cliente**, quero **compartilhar um produto nas redes sociais**, para que **meus amigos também possam ver**.  

---

## Requisitos Funcionais - E-commerce 

### 1. Cadastro e Autenticação

- **RF01.** O sistema deve permitir o cadastro de clientes com nome, e-mail, telefone, endereço e senha.  
- **RF02.** O sistema deve validar e autenticar usuários via login com e-mail e senha.  
- **RF03.** O sistema deve permitir a recuperação de senha por e-mail.  
- **RF04.** O sistema deve permitir login com contas de redes sociais (Google, Facebook, etc).  
- **RF05.** O sistema deve permitir autenticação em dois fatores para maior segurança.  

---

### 2. Gerenciamento de Produtos

- **RF06.** O sistema deve permitir que administradores cadastrem, editem e removam produtos.  
- **RF07.** O sistema deve permitir associar múltiplas imagens a um produto.  
- **RF08.** O sistema deve permitir definir categorias, subcategorias e tags para cada produto.  
- **RF09.** O sistema deve permitir aplicar descontos e cupons promocionais por produto, categoria ou usuário.  
- **RF10.** O sistema deve controlar o estoque de produtos automaticamente após cada venda.  

---

### 3. Navegação e Busca

- **RF11.** O sistema deve permitir a navegação por categorias, subcategorias e filtros (preço, avaliação, marca, etc).  
- **RF12.** O sistema deve possuir uma busca inteligente com sugestões automáticas.  
- **RF13.** O sistema deve exibir produtos relacionados e recomendados com base no histórico de navegação e compra do usuário.  

---

### 4. Carrinho e Checkout

- **RF14.** O sistema deve permitir adicionar, remover e alterar quantidades de produtos no carrinho.  
- **RF15.** O sistema deve calcular automaticamente o valor total da compra com frete e descontos.  
- **RF16.** O sistema deve permitir finalizar a compra com múltiplos métodos de pagamento (boleto, cartão, Pix, PayPal).  
- **RF17.** O sistema deve permitir salvar endereços para entregas futuras.  
- **RF18.** O sistema deve gerar um número de pedido e enviar confirmação por e-mail.  

---

### 5. Pagamento e Faturamento

- **RF19.** O sistema deve integrar com gateways de pagamento seguros.  
- **RF20.** O sistema deve validar e processar o pagamento em tempo real.  
- **RF21.** O sistema deve gerar nota fiscal eletrônica automaticamente após a compra.  

---

### 6. Entregas e Logística

- **RF22.** O sistema deve calcular o frete automaticamente via integração com transportadoras.  
- **RF23.** O sistema deve permitir rastreamento do pedido com status atualizado.  
- **RF24.** O sistema deve notificar o cliente sobre cada mudança no status do pedido (em preparo, enviado, entregue).  

---

### 7. Pós-Venda

- **RF25.** O sistema deve permitir ao cliente avaliar produtos e deixar comentários.  
- **RF26.** O sistema deve permitir solicitações de troca, devolução ou reembolso.  
- **RF27.** O sistema deve permitir ao cliente visualizar o histórico completo de pedidos.  

---

### 8. Painel Administrativo

- **RF28.** O sistema deve fornecer dashboard com KPIs: vendas, visitas, produtos mais vendidos, etc.  
- **RF29.** O sistema deve permitir gerenciamento de usuários (clientes, atendentes, administradores).  
- **RF30.** O sistema deve permitir configurar categorias, banners, promoções e páginas institucionais (sobre, política de privacidade).  

---

### 9. Segurança e Performance

- **RF31.** O sistema deve criptografar senhas e dados sensíveis.  
- **RF32.** O sistema deve manter logs de acesso e ações administrativas.  
- **RF33.** O sistema deve possuir cache para melhorar desempenho em navegação e busca.  
- **RF34.** O sistema deve limitar tentativas de login para evitar ataques de força bruta.  

---

### 10. Funcionalidades Avançadas

- **RF35.** O sistema deve oferecer chat com atendimento em tempo real (humano ou bot).  
- **RF36.** O sistema deve enviar notificações por e-mail e/ou push.  
- **RF37.** O sistema deve permitir vendas com assinatura (recorrência mensal, por exemplo).  
- **RF38.** O sistema deve permitir wishlist (lista de desejos) por usuário.  
- **RF39.** O sistema deve permitir que o cliente compartilhe produtos nas redes sociais.  
- **RF40.** O sistema deve ter suporte a internacionalização (multi-idioma e multi-moeda).  

## Requisito não funcional

###  Segurança

- **RNF01.** As senhas devem ser armazenadas de forma criptografada.
- **RNF02.** O sistema deve implementar autenticação em dois fatores (2FA) para administradores.
- **RNF03.** Deve haver limitação de tentativas de login para evitar ataques de força bruta.
- **RNF04.** Toda comunicação deve ser feita via HTTPS com certificado SSL válido.

---

###  Desempenho

- **RNF05.** As páginas devem carregar em no máximo 3 segundos em conexões de 5 Mbps.
- **RNF06.** O sistema deve suportar até 10.000 usuários simultâneos sem degradação perceptível.
- **RNF07.** As buscas devem retornar resultados em menos de 1 segundo em média.

---

###  Usabilidade

- **RNF08.** A interface deve ser responsiva e adaptável a dispositivos móveis e desktops.
- **RNF09.** O sistema deve estar disponível em pelo menos dois idiomas (Português e Inglês).
- **RNF10.** O processo de compra deve ser possível em até 3 cliques a partir da visualização do produto.

---

###  Manutenibilidade

- **RNF11.** O sistema deve seguir uma arquitetura modular para facilitar atualizações e correções.
- **RNF12.** O código deve estar documentado seguindo o padrão interno da equipe de desenvolvimento.

---

###  Escalabilidade

- **RNF13.** O sistema deve ser escalável horizontalmente em ambiente de nuvem.
- **RNF14.** O banco de dados deve permitir particionamento para lidar com grande volume de dados.

---

###  Disponibilidade e Confiabilidade

- **RNF15.** A aplicação deve ter uma disponibilidade mínima de 99,5% ao mês (SLA).
- **RNF16.** Em caso de falhas, o sistema deve realizar tentativas automáticas de recuperação e registrar logs de erro.

---

###  Compatibilidade e Integração

- **RNF17.** O sistema deve ser compatível com os navegadores: Chrome, Firefox, Edge e Safari.

---

## Restrições

As seguintes restrições devem ser observadas durante o desenvolvimento, implantação e operação do sistema:


###  Tempo e Cronograma

- **R01.** O sistema deve estar com a versão mínima funcional (MVP) entregue em até 5 meses após o início do desenvolvimento.
- **R02.** As funcionalidades de cadastro, autenticação, carrinho e pagamento devem estar prontas até o segundo mês do projeto.

---

###  Orçamento

- **R03.** O custo total da infraestrutura (servidores, APIs de terceiros, gateways, etc.) não deve ultrapassar R$2.000 mensais.
- **R04.** Ferramentas e bibliotecas utilizadas devem ser preferencialmente de código aberto ou possuir licenças gratuitas.

---

###  Tecnológicas

- **R05.** A aplicação deve ser compatível com dispositivos Android e iOS, utilizando design responsivo.
- **R06.** A hospedagem deve ser feita em ambiente cloud (AWS, Azure, ou similar) com suporte a escalabilidade.

---

###  Legais e Regulatórias

- **R07.** O sistema deve estar em conformidade com a LGPD (Lei Geral de Proteção de Dados).
- **R08.** Dados pessoais sensíveis devem ser tratados com consentimento e criptografia adequada.

---

###  Integrações

- **R09.** O sistema deve integrar-se obrigatoriamente com gateways de pagamento homologados (ex: Stripe, PayPal, PagSeguro).
- **R10.** A emissão de nota fiscal deve ser feita por meio de integração com sistema externo compatível com a prefeitura local.

---
# Diagrama de casos de uso

![alt text](<UML Use Case Diagram.jpg>)
 
<a href="https://miro.com/app/board/uXjVIBLsGlM=/">Clique aqui para acessar o Diagrama</a>

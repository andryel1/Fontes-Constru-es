# Personas

## Histórias de usuário

# 🛒 Requisitos Funcionais - E-commerce 

## 1. Cadastro e Autenticação

- **RF01.** O sistema deve permitir o cadastro de clientes com nome, e-mail, telefone, endereço e senha.  
- **RF02.** O sistema deve validar e autenticar usuários via login com e-mail e senha.  
- **RF03.** O sistema deve permitir a recuperação de senha por e-mail.  
- **RF04.** O sistema deve permitir login com contas de redes sociais (Google, Facebook, etc).  
- **RF05.** O sistema deve permitir autenticação em dois fatores para maior segurança.  

---

## 2. Gerenciamento de Produtos

- **RF06.** O sistema deve permitir que administradores cadastrem, editem e removam produtos.  
- **RF07.** O sistema deve permitir associar múltiplas imagens a um produto.  
- **RF08.** O sistema deve permitir definir categorias, subcategorias e tags para cada produto.  
- **RF09.** O sistema deve permitir aplicar descontos e cupons promocionais por produto, categoria ou usuário.  
- **RF10.** O sistema deve controlar o estoque de produtos automaticamente após cada venda.  

---

## 3. Navegação e Busca

- **RF11.** O sistema deve permitir a navegação por categorias, subcategorias e filtros (preço, avaliação, marca, etc).  
- **RF12.** O sistema deve possuir uma busca inteligente com sugestões automáticas.  
- **RF13.** O sistema deve exibir produtos relacionados e recomendados com base no histórico de navegação e compra do usuário.  

---

## 4. Carrinho e Checkout

- **RF14.** O sistema deve permitir adicionar, remover e alterar quantidades de produtos no carrinho.  
- **RF15.** O sistema deve calcular automaticamente o valor total da compra com frete e descontos.  
- **RF16.** O sistema deve permitir finalizar a compra com múltiplos métodos de pagamento (boleto, cartão, Pix, PayPal).  
- **RF17.** O sistema deve permitir salvar endereços para entregas futuras.  
- **RF18.** O sistema deve gerar um número de pedido e enviar confirmação por e-mail.  

---

## 5. Pagamento e Faturamento

- **RF19.** O sistema deve integrar com gateways de pagamento seguros.  
- **RF20.** O sistema deve validar e processar o pagamento em tempo real.  
- **RF21.** O sistema deve gerar nota fiscal eletrônica automaticamente após a compra.  

---

## 6. Entregas e Logística

- **RF22.** O sistema deve calcular o frete automaticamente via integração com transportadoras.  
- **RF23.** O sistema deve permitir rastreamento do pedido com status atualizado.  
- **RF24.** O sistema deve notificar o cliente sobre cada mudança no status do pedido (em preparo, enviado, entregue).  

---

## 7. Pós-Venda

- **RF25.** O sistema deve permitir ao cliente avaliar produtos e deixar comentários.  
- **RF26.** O sistema deve permitir solicitações de troca, devolução ou reembolso.  
- **RF27.** O sistema deve permitir ao cliente visualizar o histórico completo de pedidos.  

---

## 8. Painel Administrativo

- **RF28.** O sistema deve fornecer dashboard com KPIs: vendas, visitas, produtos mais vendidos, etc.  
- **RF29.** O sistema deve permitir gerenciamento de usuários (clientes, atendentes, administradores).  
- **RF30.** O sistema deve permitir configurar categorias, banners, promoções e páginas institucionais (sobre, política de privacidade).  

---

## 9. Segurança e Performance

- **RF31.** O sistema deve criptografar senhas e dados sensíveis.  
- **RF32.** O sistema deve manter logs de acesso e ações administrativas.  
- **RF33.** O sistema deve possuir cache para melhorar desempenho em navegação e busca.  
- **RF34.** O sistema deve limitar tentativas de login para evitar ataques de força bruta.  

---

## 10. Funcionalidades Avançadas

- **RF35.** O sistema deve oferecer chat com atendimento em tempo real (humano ou bot).  
- **RF36.** O sistema deve enviar notificações por e-mail e/ou push.  
- **RF37.** O sistema deve permitir vendas com assinatura (recorrência mensal, por exemplo).  
- **RF38.** O sistema deve permitir wishlist (lista de desejos) por usuário.  
- **RF39.** O sistema deve permitir que o cliente compartilhe produtos nas redes sociais.  
- **RF40.** O sistema deve ter suporte a internacionalização (multi-idioma e multi-moeda).  

# Requisito não funcional

---

##  Segurança

- **RNF01.** As senhas devem ser armazenadas de forma criptografada.
- **RNF02.** O sistema deve implementar autenticação em dois fatores (2FA) para administradores.
- **RNF03.** Deve haver limitação de tentativas de login para evitar ataques de força bruta.
- **RNF04.** Toda comunicação deve ser feita via HTTPS com certificado SSL válido.

---

##  Desempenho

- **RNF05.** As páginas devem carregar em no máximo 3 segundos em conexões de 5 Mbps.
- **RNF06.** O sistema deve suportar até 10.000 usuários simultâneos sem degradação perceptível.
- **RNF07.** As buscas devem retornar resultados em menos de 1 segundo em média.

---

## 📱 Usabilidade

- **RNF08.** A interface deve ser responsiva e adaptável a dispositivos móveis e desktops.
- **RNF09.** O sistema deve estar disponível em pelo menos dois idiomas (Português e Inglês).
- **RNF10.** O processo de compra deve ser possível em até 3 cliques a partir da visualização do produto.

---

##  Manutenibilidade

- **RNF11.** O sistema deve seguir uma arquitetura modular para facilitar atualizações e correções.
- **RNF12.** O código deve estar documentado seguindo o padrão interno da equipe de desenvolvimento.

---

##  Escalabilidade

- **RNF13.** O sistema deve ser escalável horizontalmente em ambiente de nuvem.
- **RNF14.** O banco de dados deve permitir particionamento para lidar com grande volume de dados.

---

##  Disponibilidade e Confiabilidade

- **RNF15.** A aplicação deve ter uma disponibilidade mínima de 99,5% ao mês (SLA).
- **RNF16.** Em caso de falhas, o sistema deve realizar tentativas automáticas de recuperação e registrar logs de erro.

---

##  Compatibilidade e Integração

- **RNF17.** O sistema deve ser compatível com os navegadores: Chrome, Firefox, Edge e Safari.

---

# Restrições

# Diagrama de casos de uso

![alt text](<UML Use Case Diagram.jpg>)
 
<a href="https://miro.com/app/board/uXjVIBLsGlM=/">Clique aqui para acessar o Diagrama</a>

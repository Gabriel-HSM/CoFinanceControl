namespace CoFinanceControl.Domain.Enums
{
    public enum Cargo
    {
        /// Administrador - Acesso total ao sistema, gerenciamento de usuários, configurações e relatórios
        Admin = 1,
        
        /// Gerente Financeiro - Gerenciamento de contas, transações, fluxo de caixa e relatórios financeiros
        GerenteFinanceiro = 2,
        

        /// Analista Financeiro - Análise de dados financeiros, criação de relatórios e previsões

        AnalistaFinanceiro = 3,
        

        /// Contador - Registro de transações, conciliação bancária e auditoria financeira

        Contador = 4,

        /// Operador Financeiro - Processamento de transações, pagamentos e recebimentos

        OperadorFinanceiro = 5,
    }
}
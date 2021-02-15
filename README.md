## Clarify.Climate

Instruções para rodar o projeto

```bash
# Rodar script para geração de tabelas e registros
executar o script database-generate.sql
Dependendo do momento que rodar o script as datas estejam defasadas. Caso seja esse o caso ajuste o script para datas recentes

# Ajustar connection string
Ajustar connection string nos arquivos
* ..\Clarify.Climate\Clarify.Climate.Web\Web.config
* ..\Clarify.Climate\Clarify.Climate.Repository\App.config

# Definição de projeto de execução
Escolha o projeto ..\Clarify.Climate\Clarify.Climate.Web como o projeto de startup

#Rodar projeto
Executar o projeto
```

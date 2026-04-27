<header>
        <h1>📇 Agenda de Contatos (Windows Forms)</h1>
        <p>Uma aplicação desktop simples e eficiente desenvolvida em C# para gerenciamento de contatos. O sistema permite adicionar, remover e persistir dados em um arquivo de texto local.</p>
    </header>

    <img src="Captura de tela 2026-04-27 001636.png" alt="Descrição da Imagem" width="500" height="800">

    <hr>

    <section>
        <h2>🚀 Funcionalidades</h2>
        <ul>
            <li><strong>Cadastro de Contatos:</strong> Salva nome e telefone com validação de campos.</li>
            <li><strong>Persistência de Dados:</strong> Todos os contatos são salvos automaticamente em um arquivo <code>contatos.txt</code>, garantindo que os dados não sejam perdidos ao fechar o programa.</li>
            <li><strong>Interface Intuitiva:</strong> Listagem organizada com alinhamento visual e caixas de confirmação para exclusão.</li>
            <li><strong>Arquitetura Limpa:</strong> Separação entre a lógica de interface (Form1) e o modelo de dados (Contato).</li>
        </ul>
    </section>

    <section>
        <h2>🛠️ Tecnologias Utilizadas</h2>
        <ul>
            <li><strong>Linguagem:</strong> C#</li>
            <li><strong>Framework:</strong> .NET (Windows Forms)</li>
            <li><strong>Manipulação de Dados:</strong> LINQ e I/O de arquivos.</li>
        </ul>
    </section>

    <section>
        <h2>📁 Estrutura do Projeto</h2>
        <p>O projeto é composto por dois arquivos principais de código:</p>
        <ul>
            <li><strong>Form1.cs:</strong> Gerencia os eventos da interface, como cliques de botões e carregamento da lista.</li>
            <li><strong>Contato.cs:</strong> Classe de modelo que define as propriedades do contato e a lógica de formatação do texto.</li>
        </ul>
    </section>

    <section>
        <h2>⚙️ Como Executar</h2>
        <ol>
            <li>Certifique-se de ter o <strong>Visual Studio</strong> (2019 ou superior) instalado com a carga de trabalho de ".NET Desktop Development".</li>
            <li>Crie um novo projeto do tipo <strong>Windows Forms App</strong>.</li>
            <li>Substitua o código do seu formulário pelo código presente em <code>Form1.cs</code>.</li>
            <li>Adicione a classe <code>Contato.cs</code> ao seu projeto.</li>
            <li>Pressione <kbd>F5</kbd> para compilar e rodar.</li>
        </ol>
    </section>

    <section>
        <h2>📝 Formato do Arquivo de Dados</h2>
        <p>Os dados são armazenados no mesmo diretório do executável no formato:</p>
        <pre>
Nome do Contato | (88) 99999-9999
Ana Silva       | (11) 98765-4321
        </pre>
    </section>

    <section>
        <h2>🤝 Contribuição</h2>
        <p>Sinta-se à vontade para clonar este repositório e adicionar novas funcionalidades, como:</p>
        <ul>
            <li>[ ] Barra de busca/filtro de contatos.</li>
            <li>[ ] Edição de contatos existentes.</li>
            <li>[ ] Validação de máscara para o campo de telefone.</li>
        </ul>
    </section>

    <footer>
        <p><em>Nota: Este projeto foi desenvolvido para fins de aprendizado sobre manipulação de arquivos e listas em C#.</em></p>
    </footer>
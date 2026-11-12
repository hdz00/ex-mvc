const Botao = document.getElementById("Botao");

if (Botao)
{
    Botao.addEventListener("click", function()
    {
        document.getElementById("mensagem").textContent="ola";
    });
}

const form = document.getElementById("form");

if (form)
{
    form.addEventListener("submit", function(event)
    {
        event.preventDefault();

        const nome=document.getElementById("nome").value;

        alert("Obrigado "+nome+" voce foi registrado.");

        form.reset();
    });
}